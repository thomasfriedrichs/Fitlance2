import { useCookieWatcher } from '@fcannizzaro/react-use-cookie-watcher';
import img1 from './assets/img1.jpg';
import img2 from './assets/img2.jpg';
import img3 from './assets/img3.jpg';
import img4 from './assets/img4.jpg';

const Home = () => {
    const cookieExists = useCookieWatcher('X-Access-Token', {
        checkEvery: 500,
    });

    return (
        <div className="min-h-screen bg-gray-100 py-20">
            <header className="w-full text-center py-8">
                <h1 className="text-3xl sm:text-6xl font-bold mb-4">Welcome</h1>
                <p className="text-xl sm:text-3xl mb-6">
                    Discover a World of Fitness Opportunities with Fitlance
                </p>
            </header>
            <main className="w-full">
                <section className="md:flex md:justify-center md:items-start md:space-x-6">
                    <div className="w-full md:w-1/2 px-4">
                        <img
                            src={img1}
                            alt="People exercising"
                            className="w-full h-auto object-cover object-center rounded-lg shadow-md mb-4 md:mb-0"
                        />
                    </div>
                    <div className="w-full md:w-1/2 px-4 md:text-2xl">
                        <p>
                            At Fitlance, we believe that a healthy lifestyle is the key to a
                            happier, more fulfilling life. That's why we've created a platform
                            that makes finding the perfect personal trainer, exploring new
                            types of exercises, and attending workout classes easier than
                            ever. With our extensive network of fitness
                            professionals, you'll never be at a loss for options when it comes
                            to your fitness journey.
                        </p>
                    </div>
                </section>
                <section className="md:flex md:justify-center md:items-start md:space-x-6 mt-6">
                    <div className="order-first md:order-first w-full md:w-1/2 px-4 md:text-2xl">
                        <p>
                            Personal trainers can make all the difference in achieving your
                            fitness goals. Fitlance connects you with a diverse range of
                            experts who specialize in various training disciplines such as
                            strength training, functional fitness, yoga, Pilates, and more.
                            Whether you're a beginner looking for guidance or an experienced
                            athlete seeking to break through plateaus, our platform will help
                            you find the perfect match to elevate your workouts.
                        </p>
                    </div>
                    <div className="w-full md:w-1/2 px-4">
                        <img
                            src={img2}
                            alt="Personal Trainer"
                            className="w-full h-auto object-cover object-center rounded-lg shadow-md mb-4 md:mb-0"
                        />
                    </div>
                </section>
                <section className="md:flex md:justify-center md:items-start md:space-x-6 mt-6">
                    <div className="w-full md:w-1/2 px-4">
                        <img
                            src={img3}
                            alt="Beach Workout"
                            className="w-full h-auto object-cover object-center rounded-lg shadow-md mb-4 md:mb-0"
                        />
                    </div>
                    <div className="order-last md:order-first w-full md:w-1/2 px-4 md:text-2xl">
                        <p>
                            For those who thrive in group settings, Fitlance provides access to a wide variety of workout
                            classes held by top-rated instructors in your area. Experience the camaraderie and motivation
                            that comes from sweating it out alongside others, while learning new skills and staying
                            accountable to your goals. Choose from popular classes such as Zumba, CrossFit, and spinning,
                            or explore niche offerings like aerial yoga and aquatic fitness.
                        </p>
                    </div>
                </section>
                <section className="md:flex md:justify-center md:items-start md:space-x-6 mt-6">
                    <div className="w-full md:w-1/2 px-4">
                        <img
                            src={img4}
                            alt="Run at sunet"
                            className="w-full h-auto object-cover object-center rounded-lg shadow-md mb-4 md:mb-0"
                        />
                    </div>
                    <div className="order-first md:order-first w-full md:w-1/2 px-4 md:text-2xl">
                        <p>
                            Join the Fitlance community today and unlock endless possibilities for your fitness journey.
                            Together, we'll help you become the best version of yourself.
                        </p>
                    </div>
                </section>
                <section className="w-full px-4 sm:px-0 mt-12">
                    {!cookieExists && (
                        <div className="max-w-xl mx-auto text-center">
                            <p className="text-xl sm:text-3xl mb-4">
                                Get started by registering today
                            </p>
                            <button className="bg-blue-500 text-white px-6 py-2 rounded-lg hover:bg-blue-600 transition-all">
                                Register
                            </button>
                        </div>
                    )}
                </section>
            </main>
        </div>
    );
};

export default Home;