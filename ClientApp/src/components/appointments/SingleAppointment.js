import React, { useState } from "react";

import { putAppointment } from "../../services/AppointmentService";
import AppointmentForm from "./AppointmentForm";

const SingleAppointment = (appointment) => {
    const [formView, setFormView] = useState(false);
    const {
        streetAddress,
        city,
        state,
        postalCode,
        country,
        startTimeUtc,
    } = appointment.appointment;
    const startTimeUtcDate = new Date(startTimeUtc + 'Z');
    const startTimeLocal = startTimeUtcDate.toLocaleString();
    const timezone = startTimeUtcDate.toLocaleTimeString(undefined, { timeZoneName: 'short' }).split(' ')[2];


    const onEdit = () => {
        setFormView(!formView);
    };

    return (
        <div className="border-b shadow-sm rounded-sm hover:bg-slate-100">
            <section
                className="p-2 w-full mx-auto hover:bg-slate-100"
                role="region"
                aria-label="Appointment Information"
            >
                <h1 className="text-xl sm:text-2xl font-bold mb-4">Appointment Information</h1>
                <div className="flex justify-between">
                    <div>
                        <h2 className="text-lg font-bold mb-2">Address</h2>
                        <address>
                            {streetAddress}
                            <br />
                            {city}, {state} {postalCode}
                            <br />
                            {country}
                        </address>
                    </div>
                    <div>
                        <h2 className="text-lg font-bold mb-2">Start Time ({timezone})</h2>
                        <p>{startTimeLocal}</p>
                    </div>
                </div>
            </section>
            {formView ?
                <AppointmentForm
                    toggleView={onEdit}
                    query={putAppointment}
                    reqType={"put"}
                    appointment={appointment.appointment}/>
                : null}
            <button
                className="p-2"
                onClick={onEdit}>
                {formView ? "Cancel" : "Edit"}
            </button>
        </div>
    );
};

export default SingleAppointment;