import React, { useState } from "react";

import images from "./../../assets/profileImages/index";
import AppointmentFormWithFormik from "../appointments/AppointmentForm";
import { postAppointment } from "../../services/AppointmentService";

const SingleTrainer = ({ trainer, imageIndex }) => {
    const { bio, firstName, lastName, city, zipCode, id } = trainer;
    const [appointmentFormView, setAppointmentFormView] = useState(false);

    const toggleDropdownForm = () => {
        setAppointmentFormView(!appointmentFormView);
    };

    return (
        <div className={`relative border rounded-sm md:m-4 flex flex-col md:flex-row justify-between
      ${appointmentFormView ? "h-80 md:h-64" : "h-48 md:h-32"}`}>
            <div className="flex flex-row">
                <div className="p-2 h-24 w-24">
                    <img
                        className="object-cover h-24 w-32 rounded-full"
                        src={images[imageIndex].image}
                        alt={images[imageIndex].alt} />
                </div>
                <div className="flex flex-col md:flex-row md:justify-between w-2/3">
                    <div className="flex flex-row h-4">
                        <h1 className="p-2 font-semibold">{firstName}</h1>
                        <h1 className="p-2 font-semibold">{lastName}</h1>
                    </div>
                    <div className="flex flex-row mr-1 md:mr-6">
                        <p className="p-2 font-semibold">{city}</p>
                        <p className="p-2 font-semibold">{zipCode}</p>
                    </div>
                    <div>
                        <p className="p-2">{bio}</p>
                    </div>
                </div>
            </div>
            <section>
                {appointmentFormView ?
                    <AppointmentFormWithFormik
                        toggleView={toggleDropdownForm}
                        query={postAppointment}
                        reqType={"post"}
                        trainerId={id} />
                    : null}
            </section>
            <button
                onClick={toggleDropdownForm}
                className="absolute bottom-0 right-0 p-2">
                {appointmentFormView ? "Cancel" : "Make Appointment"}
            </button>
        </div>
    )
}

export default SingleTrainer;