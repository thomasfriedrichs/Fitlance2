import React, { useState, useEffect } from "react";
import { Form, Formik, ErrorMessage, Field } from "formik";
import Cookies from "js-cookie";
import { useQueryClient, useMutation } from "@tanstack/react-query";
import DateTimeRangePicker from '@wojtekmaj/react-datetimerange-picker';
import '@wojtekmaj/react-datetimerange-picker/dist/DateTimeRangePicker.css';
import 'react-calendar/dist/Calendar.css';

import { AppointmentSchema } from "../../validators/Validate";
import { getLatLngFromAddress } from "./helpers/geocode";
import StatePicker from "./StatePicker";
import "./index.css";

const AppointmentForm = props => {
    const {
        city,
        country,
        endTimeUtc,
        postalCode,
        state,
        trainerId,
        streetAddress,
        startTimeUtc,
        id,
    } = props.appointment || {};
    const userId = Cookies.get("Id");
    const currentDate = new Date();
    const [startTime, setStartTime] = useState(new Date());
    const [endTime, setEndTime] = useState(new Date(currentDate.getTime() + 1 + 60 * 60 * 1000));
    const [geocodeError, setGeocodeError] = useState(null);
    const { toggleView, query, reqType, } = props;
    const queryClient = useQueryClient();

    const mutation = useMutation({
        mutationFn: async values => {
            const addressString = [
                values.streetAddress,
                values.city,
                values.state,
                values.postalCode,
                values.country,
            ].join(", ");

            try {
                const { lat, lng } = await getLatLngFromAddress(addressString);
                console.log(lat,lng)
                const updatedValues = {
                    ...values,
                    latitude: lat,
                    longitude: lng,
                };
                await reqType === "put" ? query(id, updatedValues) : query(updatedValues);
            } catch (error) {
                console.error("Error fetching coordinates:", error);
                console.log("Address string:", addressString);
                setGeocodeError("Please enter a valid address.");
            }
        },
        onSuccess: () => {
            queryClient.invalidateQueries({ queryKey: ["getAppointments"] });
            return toggleView();
        },
        onError: (error) => {
            console.log("query error", error);
        }
    });

    const handleChangeDateTimeRange = (dateTimeRange, formik) => {
        if (Array.isArray(dateTimeRange) && dateTimeRange.length === 2) {
            const [newStartTime, newEndTime] = dateTimeRange;
            if (newStartTime instanceof Date && newEndTime instanceof Date) {
                formik.setFieldValue("startTimeUtc", newStartTime);
                formik.setFieldValue("endTimeUtc", newEndTime);
            }
        }
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
                        <div className="grid grid-cols-1 gap-4 md:grid-cols-2 px-2">
                            <div>
                                <label htmlFor="streetAddress" className="block text-sm font-medium text-gray-700">
                                    Street Address
                                </label>
                                <input
                                    type="text"
                                    name="streetAddress"
                                    id="streetAddress"
                                    placeholder="Street Address"
                                    value={values.streetAddress}
                                    onChange={handleChange}
                                    className={`w-full rounded-lg text-center p-1 shadow-sm
                                        ${errors.streetAddress && touched.streetAddress ? "border-red-500" : "border-lime-500"}
                                    `}
                                />
                                {errors.streetAddress && touched.streetAddress && (
                                    <span className="text-red-500">{errors.streetAddress}</span>
                                )}
                            </div>
                            <div>
                                <label htmlFor="city" className="block text-sm font-medium text-gray-700">
                                    City
                                </label>
                                <input
                                    type="text"
                                    name="city"
                                    id="city"
                                    placeholder="City"
                                    value={values.city}
                                    onChange={handleChange}
                                    className={`w-full rounded-lg text-center p-1 shadow-sm
                                        ${errors.city && touched.city ? "border-red-500" : "border-lime-500"}
                                    `}
                                />
                                {errors.city && touched.city && (
                                    <span className="text-red-500">{errors.city}</span>
                                )}
                            </div>
                            <div className="md:col-span-2">
                                <div className="grid grid-cols-3 gap-4">
                                    <div>
                                        <label htmlFor="country" className="block text-sm font-medium text-gray-700">
                                            Country
                                        </label>
                                        <input
                                            type="text"
                                            name="country"
                                            id="country"
                                            placeholder="Country"
                                            value={values.country}
                                            onChange={handleChange}
                                            className={`w-full rounded-lg text-center p-1 shadow-sm
                                                ${errors.country && touched.country ? "border-red-500" : "border-lime-500"}
                                            `}
                                        />
                                        {errors.country && touched.country && (
                                            <span className="text-red-500">{errors.country}</span>
                                        )}
                                    </div>
                                    <div>
                                        <label htmlFor="postalCode" className="block text-sm font-medium text-gray-700">
                                            Postal Code
                                        </label>
                                        <input
                                            type="text"
                                            name="postalCode"
                                            id="postalCode"
                                            placeholder="Postal Code"
                                            value={values.postalCode}
                                            onChange={handleChange}
                                            className={`w-full rounded-lg text-center p-1 shadow-sm
                                                ${errors.postalCode && touched.postalCode ? "border-red-500" : "border-lime-500"}
                                            `}
                                        />
                                        {errors.postalCode && touched.postalCode && (
                                            <span className="text-red-500">{errors.postalCode}</span>
                                        )}
                                    </div>
                                    <div>
                                        <label htmlFor="state" className="block text-sm font-medium text-gray-700">
                                            State
                                        </label>
                                        <Field
                                            component={StatePicker}
                                            name="state"
                                            className={`w-full rounded-lg text-center p-1
                                                ${errors.state && touched.state ? "border-red-500" : "border-lime-500"}
                                            `}
                                        />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="mb-4 m-2">
                            <label htmlFor="startTimeUtc" className="block text-sm font-medium text-gray-700">
                                Start Time
                            </label>
                            <DateTimeRangePicker
                                value={[values.startTimeUtc, values.endTimeUtc]}
                                onChange={(dateTimeRange) => {
                                    handleChangeDateTimeRange(dateTimeRange, formik);
                                }}
                                className="mt-1 block w-full rounded-md shadow-sm focus:border-indigo-300 focus:ring focus:ring-indigo-200 focus:ring-opacity-50"
                            />

                            <ErrorMessage name="startTimeUtc" component="div" className="text-sm text-red-600" />
                        </div>
                        {geocodeError && (
                            <div className="text-red-600 text-center">
                                {geocodeError}
                            </div>
                        )}
                        <div className="flex flex-row justify-center">
                            <button
                                disabled={!(dirty && isValid)}
                                type="submit"
                                className={`my-4 mx-2 w-1/2 md:w-full border rounded-full ${!(dirty && isValid) ? "" : "bg-green"}`}
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