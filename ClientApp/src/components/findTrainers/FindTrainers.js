import React from "react";
import { useQuery } from "@tanstack/react-query";

import { fetchTrainers } from "../../services/TrainerService";
import SingleTrainer from "./SingleTrainer";

const FindTrainers = () => {
    const { data, isLoading, isError, error } = useQuery(["findTrainers"], fetchTrainers);

    if (isLoading) {
        return <span>Loading...</span>
    };

    if (isError) {
        return <span className="mt-32">Error: {error.message}</span>
    };

    return (
        <div className="flex justify-center">
            <div className="mt-8 md:mt-12 mb-20 p-4 md:p-8 w-full md:w-[80vw] h-full">
                <div className="flex justify-start mt-2">
                    <h1 className="text-4xl">
                        Find Trainers
                    </h1>
                </div>
                <div className="mt-10">
                    {data.map((trainer, i) => {
                        const imageIndex = Math.floor(Math.random() * 61);
                        return (
                            <SingleTrainer
                                key={i}
                                trainer={trainer}
                                imageIndex={imageIndex} />
                        );
                    })}
                </div>
            </div>
        </div>
    );
};

export default FindTrainers;