import Slider from "./Slider";
import { useCookieWatcher } from "@fcannizzaro/react-use-cookie-watcher";

const Home = () => {
    const cookieExists = useCookieWatcher("X-Access-Token", {
        checkEvery: 500
    });

    return (
        <div className="flex flex-col mt-8 mb-40">
            <section className="">
                <h1 className="text-center font-bold m-12 mt-20 sm:text-6xl">
                    Welcome!
                </h1>
                <p className="text-center m-12 sm:text-3xl">
                    Fitlance is a hub for finding the best personal trainers in your area
                </p>
                {cookieExists ? <></> :
                    <div>
                        <p className="text-center m-8 sm:text-3xl">Get started by registering today</p>
                    </div>
                }
            </section>
            <div>
                <Slider />
            </div>
        </div>
    );
};

export default Home;