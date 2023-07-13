import { useState } from "react";
import { BigX } from "@icon-park/react";

import Login from "./Login";
import Register from "./Register";

const AuthWrapper = ({ isFormVisible, setIsFormVisible }) => {
    const [currentTab, setCurrentTab] = useState(0);

    const forms = [
        { component: <Login /> },
        { component: <Register /> }
    ];

    const setToLogin = () => {
        setCurrentTab(0);
    };

    const setToRegister = () => {
        setCurrentTab(1);
    };

    const formClose = () => {
        setIsFormVisible(false);
    };

    return (
        <div className={isFormVisible ? "visible" : "hidden"}>
            <div className="fixed border rounded-lg z-30 p-4 bg-slate-300 opacity-100  h-[60vh] w-[90vw] sm:w-[50vw] lg:w-[40vw] left-[5%] top-[20%] sm:left-[25%] lg:left-[30%] ">
                <button onClick={formClose}>
                    <BigX theme="filled" size="24" fill="#333" />
                </button>
                <div className="flex flex-row justify-evenly">
                    <div className="w-[50%] text-center">
                        <button
                            className={currentTab === 0 ? "bg-slate-300" : "bg-green w-full rounded-full"}
                            onClick={setToLogin}
                        >
                            Login
                        </button>
                    </div>
                    <div className="w-[50%] text-center">
                        <button
                            className={currentTab === 1 ? "bg-slate-300" : "bg-green w-full rounded-full"}
                            onClick={setToRegister}
                        >
                            Sign up
                        </button>
                    </div>
                </div>
                <div className="mt-4">
                    {forms[currentTab].component}
                </div>
            </div>
        </div>
    )
};

export default AuthWrapper;