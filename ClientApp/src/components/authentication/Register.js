import React from "react";
import { Field, Formik, Form } from "formik";

import { RegisterSchema } from "../../validators/Validate";
import { register } from "../../services/AuthService";

const Register = () => {
    const initialValues = {
        username: "",
        email: "",
        password: "",
        role: ""
    };

    const handleRegistration = (values) => {
        console.log(values);
        register(values.username, values.email, values.password, values.role);
    };

    return (
        <Formik
            initialValues={initialValues}
            validationSchema={RegisterSchema}
            onSubmit={handleRegistration}
        >
            {(formik) => {
                const {
                    values,
                    handleChange,
                    handleSubmit,
                    errors,
                    touched,
                    handleBlur,
                    isValid,
                    dirty,
                } = formik;

                return (
                    <div className="flex flex-col gap-y-4">
                        <h1 className="text-3xl text-center">Sign up to continue</h1>
                        <Form onSubmit={handleSubmit}>
                            <div className="my-4">
                                <div className="w-full">
                                    <input
                                        type="text"
                                        name="username"
                                        placeholder="Username"
                                        value={values.username}
                                        onChange={handleChange}
                                        onBlur={handleBlur}
                                        className={`border w-full rounded-full text-center p-2
                      ${errors.email && touched.email ? "border-red-500" : "border-lime-500"}
                    `}
                                    />
                                </div>
                                {errors.username && touched.username && (
                                    <span className="text-red-500">{errors.username}</span>
                                )}
                            </div>
                            <div className="w-full">
                                <div className="w-full">
                                    <input
                                        type="email"
                                        name="email"
                                        placeholder="Email"
                                        value={values.email}
                                        onChange={handleChange}
                                        onBlur={handleBlur}
                                        className={`border w-full rounded-full text-center p-2
                      ${errors.password && touched.password ? "border-red-500" : "border-lime-500"}
                    `}
                                    />
                                    {errors.email && touched.email && (
                                        <span className="text-red-500">{errors.email}</span>
                                    )}
                                </div>
                            </div>
                            <div className="my-4">
                                <div className="w-full">
                                    <input
                                        type="password"
                                        name="password"
                                        placeholder="Password"
                                        value={values.password}
                                        onChange={handleChange}
                                        onBlur={handleBlur}
                                        className={`border w-full rounded-full text-center p-2
                      ${errors.password && touched.password ? "border-red-500" : "border-lime-500"}
                    `}
                                    />
                                    {errors.password && touched.password && (
                                        <span className="text-red-500">{errors.password}</span>
                                    )}
                                </div>
                            </div>
                            <div
                                role="group"
                                id="radio-group"
                                aria-labelledby="radio-group"
                                className="flex flex-row justify-around"
                            >
                                <label htmlFor="user" className={` w-36 text-center rounded-full ${values.role === "User" ? "bg-green" : ""}`}>
                                    <Field type="radio" id="user" name="role" value="User" className="hidden" />
                                    Sign up as User
                                </label>
                                <label htmlFor="trainer" className={` w-36 text-center rounded-full ${values.role === "Trainer" ? "bg-green" : ""}`}>
                                    <Field type="radio" id="trainer" name="role" value="Trainer" className="hidden" />
                                    Sign up as Trainer
                                </label>
                            </div>
                            <div className="flex justify-center">
                                <button
                                    type="submit"
                                    className={`my-4 w-[8rem] h-[2rem] border rounded-full ${!(dirty && isValid) ? "" : "bg-green"}`}
                                    disabled={!(dirty && isValid)}
                                >
                                    Sign up
                                </button>
                            </div>
                        </Form>
                    </div>
                );
            }}
        </Formik>
    );
};

export default Register;