import axios from "axios";
import Cookies from "js-cookie";
import jwt_decode from "jwt-decode";

const BASE_URL = process.env.REACT_APP_API_BASE_URL

export const login = (email, password) => {
    return axios
        .post(`${BASE_URL}/api/Auth/login`, {
            email,
            password
        }, {
            withCredentials: true
        })
        .then(() => {
            const decoded = jwt_decode(Cookies.get("X-Access-Token"));
            Cookies.set("Id", decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid"], { path: "/" });
            Cookies.set("Role", decoded["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"], { path: "/" });
            window.location.href = "/";
        })
        .catch(console.error());
};

export const logout = () => {
    Cookies.remove("X-Access-Token");
    Cookies.remove("Role");
    Cookies.remove("Email");
    Cookies.remove("Id");
};

export const register = (username, email, password, role) => {
    return axios.post(`${BASE_URL}/api/Auth/register`, {
        username,
        email,
        password,
        role
    }, {
        withCredentials: true
    })
    .then(() => {
        const decoded = jwt_decode(Cookies.get("X-Access-Token"));
        Cookies.set("Id", decoded["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid"], { path: "/" });
        Cookies.set("Role", decoded["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"], { path: "/" });
        window.location.href = "/";
    })
        .catch(console.error());
};