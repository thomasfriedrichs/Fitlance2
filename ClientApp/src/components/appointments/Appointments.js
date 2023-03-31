import React from "react";
import { useQuery } from "@tanstack/react-query";
import Cookies from "js-cookie";

import { getUserAppointments, getTrainerAppointments } from "../../services/AppointmentService";
import SingleAppointment from "./SingleAppointment";

const Appointments = () => {
    const role = Cookies.get("Role");
    const { data, isLoading, isError, error } = useQuery(["getAppointments"], role === "User" ? getUserAppointments : getTrainerAppointments);

    if (isLoading) {
        return <div className="my-72">Loading...</div>
    };

    if (isError) {
        return <div className="my-72">Error: {error.message}</div>
    };

    return (
        <div className="flex justify-center">
            <div className="mt-8 md:mt-12 mb-20 w-full">
                <div className="border-b-2 flex justify-start">
                    <h1 className="text-2xl">
                        Appointments
                    </h1>
                </div>
                <div>
                    {data.map((appointment, i) => {
                        return (
                            <SingleAppointment key={i} appointment={appointment} />
                        );
                    })}
                </div>
            </div>
        </div>
    );
};

export default Appointments;