import React from "react";
import images from "../../assets/profileImages";

const UserInfo = ({ data }) => {
    const { firstName, lastName, zipCode, city, bio } = data;
    const imageIndex = Math.floor(Math.random() * 61);

    return (
        <section className="bg-white p-4 rounded-lg">
            <div className="flex flex-col md:flex-row mt-4">
                <aside className="basis-1/4 h-full">
                    <div className="p-2 h-48 w-48">
                        <img
                            className="object-cover h-48 w-48 rounded-full"
                            src={images[imageIndex].image}
                            alt={images[imageIndex].alt}
                            aria-describedby="profile-image-description" />
                    </div>
                </aside>
                <div className="basis-3/4 h-full text-left ml-0 md:ml-6" role="main">
                    <div className="py-2 md:py-4 text-xl md:text-2xl font-semibold">
                        {firstName === null || lastName === null ?
                            <p className="text-red-400" aria-live="polite">Please update Name</p>
                            :
                            <div className="flex flex-row" tabIndex="0">
                                <p className="p-2">{firstName}</p>
                                <p className="p-2">{lastName}</p>
                            </div>
                        }
                    </div>
                    <div className="flex flex-row">
                        <div className="py-2 md:py-4 text-xl md:text-2xl font-semibold">
                            {city === null ?
                                <p className="text-red-400" aria-live="polite">Please update City</p>
                                :
                                <div tabIndex="0">
                                    <p className="p-2">{city}</p>
                                </div>
                            }
                        </div>
                        <div className="py-2 md:py-4 text-xl md:text-2xl font-semibold">
                            {zipCode === null ?
                                <p className="text-red-400" aria-live="polite">Please update Zipcode</p>
                                :
                                <div tabIndex="0">
                                    <p className="p-2">{zipCode}</p>
                                </div>
                            }
                        </div>
                    </div>
                    <div className="py-2 md:py-4 text-xl md:text-2xl font-semibold">
                        {bio === null ?
                            <p className="text-red-400" aria-live="polite">Please update Bio</p>
                            :
                            <div tabIndex="0">
                                <p className="p-2">{bio}</p>
                            </div>
                        }
                    </div>
                </div>
            </div>
            <div id="profile-image-description" className="sr-only">Profile image of {firstName} {lastName}</div>
        </section>
    );
};

export default UserInfo;