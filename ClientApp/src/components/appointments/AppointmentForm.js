import React, { useState } from "react";
import { Form, Formik, ErrorMessage, Field } from "formik";
import Cookies from "js-cookie";
import { useQueryClient, useMutation } from "@tanstack/react-query";
import DateTimePicker from "react-datetime-picker";

import { AppointmentSchema } from "../../validators/Validate";
import CustomTimeRangePicker from "./CustomTimeRangePicker";
import CustomDatePicker from "./CustomDatePicker";

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

    const initialValues = {
        clientId: userId,
        trainerId: trainerId,
        streetAddress: streetAddress === null ? "" : streetAddress,
        city: city === null ? "" : city,
        country: country === null ? "" : country,
        postalCode: postalCode === null ? "" : postalCode,
        state: state === null ? "" : state,
        updateTimeUtc: currentDate,
        startTimeUtc: startTimeUtc === null ? "" : startTimeUtc,
        endTimeUtc: endTimeUtc === null ? "" : endTimeUtc,
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
                            className={`border w-[95%] rounded-lg text-center p-1 m-2
                                ${errors.streetAddress && touched.streetAddress ? "border-red-500" : "border-lime-500"}
                            `} />
                        {errors.streetAddress && touched.streetAddress && (
                            <span className="text-red-500">{errors.streetAddress}</span>
                        )}
                        <div className="mb-4">
                            <label htmlFor="date" className="block text-sm font-medium text-gray-700">
                                Date:
                            </label>
                            <Field
                                name="date"
                                component={CustomDatePicker}
                                className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-indigo-300 focus:ring focus:ring-indigo-200 focus:ring-opacity-50"
                            />
                            <ErrorMessage name="date" component="div" className="text-sm text-red-600" />
                        </div>
                        <div className="mb-4">
                            <label htmlFor="timeRange" className="block text-sm font-medium text-gray-700">
                                Time Range:
                            </label>
                            <Field
                                name="timeRange"
                                component={CustomTimeRangePicker}
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