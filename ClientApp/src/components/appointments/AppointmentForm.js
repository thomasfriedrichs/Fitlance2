import React, { useState } from "react";
import { Form, Formik, ErrorMessage, Field } from "formik";
import Cookies from "js-cookie";
import { useQueryClient, useMutation } from "@tanstack/react-query";
import DatePicker from "react-date-picker";
import TimeRangePicker from "@wojtekmaj/react-timerange-picker";
import 'react-date-picker/dist/DatePicker.css';
import 'react-calendar/dist/Calendar.css';
import '@wojtekmaj/react-timerange-picker/dist/TimeRangePicker.css';
import 'react-clock/dist/Clock.css';

import { AppointmentSchema } from "../../validators/Validate";
import "./index.css";

const AppointmentForm = props => {
    const userId = Cookies.get("Id");
    const currentDate = new Date();
    const [startTime, setStartTime] = useState(new Date());
    const [endTime, setEndTime] = useState(new Date());
    const { toggleView, query, reqType, } = props;
    const {
        city,
        country,
        endTimeUtc,
        postalCode,
        state,
        trainerId,
        streetAddress,
        startTimeUtc,
        id
    } = props.appointment || {};
    const queryClient = useQueryClient();

    const mutation = useMutation({
        mutationFn: async values => {
            await reqType === "put" ? query(id, values) : query(values);
        },
        onSuccess: () => {
            queryClient.invalidateQueries({ queryKey: ["getAppointments"] });
            return toggleView();
        },
        onError: (error) => {
            console.log("query error", error);
        }
    });

    console.log(props)

    const handleChangeDate = (date) => {
        const start = new Date(date);
        start.setHours(startTime.getHours());
        start.setMinutes(startTime.getMinutes());
        setStartTime(start);

        const end = new Date(date);
        end.setHours(endTime.getHours());
        end.setMinutes(endTime.getMinutes());
        setEndTime(end);
    };

    const handleChangeTimeRange = ([start, end]) => {
        setStartTime(start);
        setEndTime(end);
    };

    const initialValues = {
        clientId: userId,
        trainerId: trainerId,
        streetAddress: streetAddress === null ? "" : streetAddress,
        city: city === null ? "" : city,
        country: country === null ? "" : country,
        postalCode: postalCode === null ? "" : postalCode,
        state: state === null ? "" : state,
        updateTimeUtc: currentDate,
        startTimeUtc: startTimeUtc === null ? startTime : startTimeUtc,
        endTimeUtc: endTimeUtc === null ? endTime : endTimeUtc,
        isActive: true
    };

    return (
        <Formik
            initialValues={initialValues}
            validationSchema={AppointmentSchema}
            onSubmit={mutation.mutate}
            enableReinitialize={true}
        >
            {(formik) => {
                const {
                    values,
                    handleChange,
                    handleSubmit,
                    errors,
                    touched,
                    isValid,
                    dirty
                } = formik;
                return (
                    <Form
                        onSubmit={handleSubmit}
                        className="flex flex-col justify-center">
                        <input
                            type="text"
                            name="streetAddress"
                            id="streetAddress"
                            placeholder="Street Address"
                            value={values.streetAddress}
                            onChange={handleChange}
                            className={`border w-[95%] rounded-lg text-center m-2 shadow-sm
                                ${errors.streetAddress && touched.streetAddress ? "border-red-500" : "border-lime-500"}
                            `} />
                        {errors.streetAddress && touched.streetAddress && (
                            <span className="text-red-500">{errors.streetAddress}</span>
                        )}
                        <div className="mb-4 m-2">
                            <label htmlFor="date" className="block text-sm font-medium text-gray-700">
                                Date:
                            </label>
                            <DatePicker
                                value={startTime}
                                onChange={handleChangeDate}
                                name="date"
                                className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-indigo-300 focus:ring focus:ring-indigo-200 focus:ring-opacity-50"
                            />
                            <ErrorMessage name="date" component="div" className="text-sm text-red-600" />
                        </div>
                        <div className="mb-4 m-2">
                            <label htmlFor="timeRange" className="block text-sm font-medium text-gray-700">
                                Time Range:
                            </label>
                            <TimeRangePicker
                                value={[startTime, endTime]}
                                onChange={handleChangeTimeRange}
                                name="timeRange"
                                className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-indigo-300 focus:ring focus:ring-indigo-200 focus:ring-opacity-50"
                            />
                            <ErrorMessage
                                name="timeRange"
                                component="div"
                                className="text-sm text-red-600"
                            />
                        </div>
                        <div className="flex flex-row justify-center">
                            <button
                                disabled={!(dirty && isValid)}
                                type="submit"
                                className={`my-4 w-1/2 md:w-full border rounded-full ${!(dirty && isValid) ? "" : "bg-green"}`}
                            >
                                Make Appointment
                            </button>
                        </div>
                    </Form>
                )
            }}
        </Formik>
    );
};

export default AppointmentForm;