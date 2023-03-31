import { useState } from "react";
import { NavLink } from "react-router-dom";
import { HamburgerButton, StretchingOne } from "@icon-park/react";
import { useCookieWatcher } from "@fcannizzaro/react-use-cookie-watcher";
import Cookies from "js-cookie";

import AuthWrapper from "../authentication/AuthWrapper";
import { logout } from "../../services/AuthService";

const Navigation = () => {
    const cookieExists = useCookieWatcher("X-Access-Token", {
        checkEvery: 500
    });

    const roleValue = Cookies.get("Role");
    const [isNavOpen, setIsNavOpen] = useState(false);
    const [isFormVisible, setIsFormVisible] = useState(false);

    const onLoginVisible = () => {
        setIsFormVisible(true);
    };

    return (
        <nav className="lg-white shadow-md bg-white fixed top-0 w-[100vw]">
            <AuthWrapper isFormVisible={isFormVisible} setIsFormVisible={setIsFormVisible} />
            <div className="mx-auto px-4 min-h-[2.5rem]">
                <div className="flex justify-between">
                    <div className="flex space-x-7">
                        <div className="flex items-center py-1">
                            <StretchingOne
                                theme="outline"
                                size="32"
                                fill="#ee0a0a"
                                className="h-8 w-8 mr-2"
                            />
                        </div>
                        <section className="flex md:hidden">
                            <div
                                className="flex flex-col justify-center"
                                onClick={() => setIsNavOpen((prev) => !prev)}
                            >
                                <div>
                                    <HamburgerButton size="32" />
                                </div>
                            </div>
                            <div className={isNavOpen ? "absolute w-[40%] h-[100vh] top-0 left-0 bg-white z-10 flex flex-col justify-center items-center" : "hidden"}>
                                <div
                                    className="absolute top-0 px-8 py-8"
                                    onClick={() => setIsNavOpen(false)}
                                >
                                    <svg
                                        className="h-8 w-8 text-gray-600"
                                        viewBox="0 0 24 24"
                                        fill="none"
                                        stroke="currentColor"
                                        strokeWidth="2"
                                        strokeLinecap="round"
                                        strokeLinejoin="round"
                                    >
                                        <line x1="18" y1="6" x2="6" y2="18" />
                                        <line x1="6" y1="6" x2="18" y2="18" />
                                    </svg>
                                </div>
                                <ul className="flex flex-col items-center justify-between min-h-[250px]">
                                    <li className="border-b border-gray-400 my-8">
                                        <NavLink
                                            to="/home"
                                            className="font-semibold text-gray-500 text-lg hover:text-green duration-150"
                                        >
                                            Home
                                        </NavLink>
                                    </li>
                                    {cookieExists ?
                                        <>
                                            <li className="border-b border-gray-400 my-8">
                                                <NavLink
                                                    to="/profile"
                                                    className="font-semibold text-gray-500 text-lg hover:text-green duration-150"
                                                >
                                                    Profile
                                                </NavLink>
                                            </li>
                                        </>
                                        :
                                        <></>
                                    }
                                    {roleValue === "User" ?
                                        <li className="border-b border-gray-400 my-8">
                                            <NavLink
                                                to="/findtrainers"
                                                className="font-semibold text-gray-500 text-lg hover:text-green duration-150"
                                            >
                                                Find Trainers
                                            </NavLink>
                                        </li>
                                        :
                                        <></>
                                    }
                                    <li className="border-b border-gray-400 my-8 uppercase">
                                        <button
                                            type="button"
                                            onClick={cookieExists ? logout : onLoginVisible}
                                            className={cookieExists ?
                                                "py-2 px-2 font-medium text-gray-500 rounded hover:bg-green hover:text-white transition duration-150" :
                                                "py-2 px-2 font-medium text-gray-500 rounded hover:bg-green hover:text-white transition duration-150"
                                            }
                                        >
                                            {cookieExists ? "Log out" : "Log in"}
                                        </button>
                                    </li>
                                    <li className="border-b border-gray-400 my-8 uppercase">
                                        {cookieExists ? <></> :
                                            <button
                                                onClick={onLoginVisible}
                                                className="py-2 px-2 font-medium text-gray-500 rounded hover:bg-green hover:text-white transition duration-150"
                                            >
                                                Sign up
                                            </button>
                                        }
                                    </li>
                                </ul>
                            </div>
                        </section>
                        <div className="hidden md:flex items-center py-4 px-2">
                            <div className="font-semibold text-gray-500 text-lg duration-150 px-2 border-r-2">
                                <NavLink to="/home" className="hover:text-green hover:border-b">Home</NavLink>
                            </div>
                            {cookieExists ?
                                <>
                                    <div className="font-semibold text-gray-500 text-lg duration-150 px-2 border-r-2">
                                        <NavLink
                                            to="/profile"
                                            className="hover:text-green hover:border-b"
                                        >
                                            Profile
                                        </NavLink>
                                    </div>
                                </>
                                :
                                <></>
                            }
                            {roleValue === "User" ?
                                <div className="font-semibold text-gray-500 text-lg duration-150 px-2 border-r-2">
                                    <NavLink
                                        to="/findtrainers"
                                        className="hover:text-green hover:border-b"
                                    >
                                        Find Trainers
                                    </NavLink>
                                </div>
                                :
                                <></>
                            }
                        </div>
                    </div>
                    <div className="hidden md:flex items-center space-x-3">
                        {cookieExists ? <></> :
                            <button
                                onClick={onLoginVisible}
                                className="py-2 px-2 font-medium text-gray-500 rounded hover:bg-green hover:text-white transition duration-150"
                            >
                                Sign up
                            </button>
                        }
                        <button
                            type="button"
                            onClick={cookieExists ? logout : onLoginVisible}
                            className="py-2 px-2 mx-4 font-medium text-gray-500 rounded hover:bg-green hover:text-white transition duration-150"
                        >
                            {cookieExists ? "Log out" : "Log in"}
                        </button>
                    </div>
                </div>
            </div>
        </nav>
    );
};

export default Navigation;