import React, { useState } from "react";

import { putAppointment } from "../../services/AppointmentService";
import AppointmentForm from "./AppointmentForm";

const SingleAppointment = (appointment) => {
    const [formView, setFormView] = useState(false);
    const { address, appointmentDate, trainerId, id } = appointment.appointment;

    const onEdit = () => {
        setFormView(!formView);
    };

    return (
        <div className="border rounded-sm m-4">
            <div className="flex justify-between">
                <p className="p-2 font-semibold">
                    {address === null ? "Add address" : address}
                </p>
                <p className="p-2 font-semibold">
                    {appointmentDate === null ? "Add Date" : appointmentDate}
                </p>
            </div>
            {formView ?
                <AppointmentForm
                    toggleView={onEdit}
                    query={putAppointment}
                    reqType={"put"}
                    trainerId={trainerId}
                    address={address}
                    appointmentDate={appointmentDate}
                    id={id} />
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