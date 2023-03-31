import React from "react";

import images from "../../assets/profileImages";

const UserInfo = ({ data }) => {
    const { firstName, lastName, zipCode, city, bio } = data;
    const imageIndex = Math.floor(Math.random() * 4);

    return (
        <section>
            <div className="flex flex-col md:flex-row mt-4">
                <div className="basis-1/4 h-full">
                    <div className="p-2 h-48 w-48">
                        <img
                            className="object-cover h-48 w-48"
                            src={images[imageIndex].image}
                            alt={images[imageIndex].alt} />
                    </div>
                </div>
                <div className="basis-3/4 h-full text-left">
                    <div className="py-6 md:px-12 text-2xl">
                        {firstName === null || lastName === null ?
                            <p className="text-red-400">Please update Name</p>
                            :
                            <div className="flex flex-row">
                                <p className="p-2">{firstName}</p>
                                <p className="p-2">{lastName}</p>
                            </div>
                        }
                    </div>
                    <div className="flex flex-row">
                        <div className="py-6 md:px-12 text-2xl">
                            {city === null ?
                                <p className="text-red-400">Please update City</p>
                                :
                                <div>
                                    <p className="p-2">{city}</p>
                                </div>
                            }
                        </div>
                        <div className="py-6 text-2xl">
                            {zipCode === null ?
                                <p className="text-red-400">Please update Zipcode</p>
                                :
                                <div>
                                    <p className="p-2">{zipCode}</p>
                                </div>
                            }
                        </div>
                    </div>
                    <div className="py-6 md:px-12 text-2xl">
                        {bio === null ?
                            <p className="text-red-400">Please update Bio</p>
                            :
                            <div>
                                <p className="p-2">{bio}</p>
                            </div>
                        }
                    </div>
                </div>
            </div>
        </section>
    );
};

export default UserInfo;