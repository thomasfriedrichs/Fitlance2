import React, { useRef } from "react";
import { useQuery } from "@tanstack/react-query";
import Cookies from "js-cookie";
import { Calendar, momentLocalizer } from "react-big-calendar";
import moment from "moment";
import "react-big-calendar/lib/css/react-big-calendar.css";

import { getUserAppointments, getTrainerAppointments } from "../../services/AppointmentService";
import SingleAppointment from "./SingleAppointment";
import CustomToolbar from "./CustomToolbar";
import useLazyLoadItems from "./hooks/useLazyLoadItems";
import "./calendar-styles.css";

const Appointments = () => {
    const role = Cookies.get("Role");
    const appointmentsContainerRef = useRef();
    const { data, isLoading, isError, error } = useQuery(["getAppointments"], role === "User" ? getUserAppointments : getTrainerAppointments);

    const displayedAppointments = useLazyLoadItems(data, 5, appointmentsContainerRef);
    const localizer = momentLocalizer(moment);

    const calendarEvents = () => {
        return data.map((appointment) => ({
            start: new Date(appointment.startTimeUtc), 
            end: new Date(appointment.endTimeUtc), 
        }));
    };



    if (isLoading) {
        return <div className="my-72">Loading...</div>
    };

    if (isError) {
        return <div className="my-72">Error: {error.message}</div>
    };

    return (
        <section className="flex justify-center">
            <div className="mt-8 md:mt-12 mb-20 w-full">
                <div className=" flex justify-start">
                    <h1 className="text-2xl">
                        Appointments
                    </h1>
                </div>
                <div className="md:flex md:justify-around md:items-start md:space-x-2 mt-6">
                    <div className="h-[32rem] md:w-2/5">
                        <Calendar
                            events={calendarEvents()}
                            startAccessor="start"
                            endAccessor="end"
                            localizer={localizer}
                            components={{
                                toolbar: (props) => <CustomToolbar {...props} localizer={localizer} />,
                            }}/>
                    </div>
                    <div ref={appointmentsContainerRef} className="md:w-1/2 h-[50rem] overflow-y-auto">
                        {displayedAppointments.map((appointment, i) => {
                            return (
                                <SingleAppointment key={i} appointment={appointment}/>
                            );
                        })}
                    </div>
                </div>
            </div>
        </section>
    );
};

export default Appointments;