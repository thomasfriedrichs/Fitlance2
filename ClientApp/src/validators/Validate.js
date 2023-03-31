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
    address: Yup.string().required("Location required"),
    appointmentDate: Yup.string().matches(/(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d/, "Must format date MM/DD/YYYY")
});