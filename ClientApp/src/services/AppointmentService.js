import axios from "axios";
import Cookies from "js-cookie";

const BASE_URL = process.env.REACT_APP_API_BASE_URL

export const postAppointment = async (reqObj) => {
    const token = Cookies.get("X-Access-Token");
    try {
        axios.post(`${BASE_URL}/api/Appointments`, reqObj, { headers: { authorization: `bearer ${token}` } });
    } catch (err) {
        console.log(err);
    };
};

export const putAppointment = async (id, reqObj) => {
    const token = Cookies.get("X-Access-Token");
    try {
        axios.put(`${BASE_URL}/api/Appointments/${id}`, reqObj, { headers: { authorization: `bearer ${token}` } });
    } catch (err) {
        console.log(err);
    };
};

export const getUserAppointments = async () => {
    const token = Cookies.get("X-Access-Token");
    const id = Cookies.get("Id");
    try {
        const response =
            await axios.get(`${BASE_URL}/api/Appointments/GetUserAppointments/${id}`, { headers: { authorization: `bearer ${token}` } });
        return response.data;
    } catch (err) {
        console.log(err);
    };
};

export const getTrainerAppointments = async () => {
    const token = Cookies.get("X-Access-Token");
    const id = Cookies.get("Id");
    try {
        const response =
            await axios.get(`${BASE_URL}/api/Appointments/GetTrainerAppointments/${id}`, { headers: { authorization: `bearer ${token}` } });
        return response.data;
    } catch (err) {
        console.log(err);
    };
};