import axios from "axios";
import Cookies from "js-cookie";

const BASE_URL = process.env.REACT_APP_API_BASE_URL

export const fetchProfile = async () => {
    const token = Cookies.get("X-Access-Token");
    const id = Cookies.get("Id");
    try {
        const response = await axios
            .get(`${BASE_URL}/api/Users/${id}`, { headers: { authorization: `bearer ${token}` } });
        return response.data;
    } catch (err) {
        console.log(err);
    };
};

export const putProfile = async (reqObj) => {
    const token = Cookies.get("X-Access-Token");
    const id = Cookies.get("Id");
    try {
        const response = await axios.put(`${BASE_URL}/api/Users/${id}`, reqObj, { headers: { authorization: `bearer ${token}` } })
        return response.data;
    } catch (err) {
        console.log(err)
    };
};