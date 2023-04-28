import * as Yup from "yup";

export const LogInSchema = Yup.object().shape({
    email: Yup.string().email().required("Email is required"),
    password: Yup.string()
        .required("Password is required")
        .min(8, "Password is too short, must be atleast 8 characters")
});

export const RegisterSchema = Yup.object().shape({
    username: Yup.string()
        .required("Username is required"),
    email: Yup.string().email().required("Email is required"),
    password: Yup.string()
        .required("Password is required")
        .min(8, "Password is too short, must be atleast 8 characters")
        .matches(
            /^.*(?=.{8,})((?=.*[!@#$%^&*()\-_=+{};:,<.>]){1})(?=.*\d)((?=.*[a-z]){1})((?=.*[A-Z]){1}).*$/,
            "Password must contain at least 8 characters, one uppercase, one number and one special case character"
        )
});

export const ProfileSchema = Yup.object().shape({
    firstName: Yup.string().required("First name required"),
    lastName: Yup.string().required("Last name required"),
    city: Yup.string().required("City required"),
    zipcode: Yup.number().required("Zipcode required"),
    bio: Yup.string().required("Bio required")
});

export const AppointmentSchema = Yup.object().shape({
    city: Yup.string()
        .required('City is required')
        .min(2, 'City must be at least 2 characters')
        .max(50, 'City must not exceed 50 characters'),
    country: Yup.string()
        .required('Country is required')
        .min(2, 'Country must be at least 2 characters')
        .max(50, 'Country must not exceed 50 characters'),
    postalCode: Yup.string()
        .required('Postal code is required')
        .matches(/^\d{5}(?:[-\s]\d{4})?$/, 'Postal code is not valid'),
    state: Yup.string()
        .required('State is required')
        .min(2, 'State must be at least 2 characters')
        .max(50, 'State must not exceed 50 characters'),
    streetAddress: Yup.string()
        .required('Street address is required')
        .min(5, 'Street address must be at least 5 characters')
        .max(100, 'Street address must not exceed 100 characters'),
    startTimeUtc: Yup.date().required('Start time is required'),
    endTimeUtc: Yup.date()
        .required('End time is required')
        .min(Yup.ref('startTimeUtc'), 'End time must be later than start time'),
});