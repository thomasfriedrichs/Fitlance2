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
    const startTimeUtcDate = new Date(startTimeUtc);
    const startTimePst = new Date(startTimeUtcDate.getTime() - 7 * 60 * 60 * 1000).toLocaleString('en-US');

    const onEdit = () => {
        setFormView(!formView);
    };

    return (
        <div className="border shadow-sm rounded-sm m-4">
            <section
                className="bg-white p-2 w-full mx-auto"
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
                        <h2 className="text-lg font-bold mt-4 mb-2">Start Time (PST)</h2>
                        <p>{startTimePst}</p>
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