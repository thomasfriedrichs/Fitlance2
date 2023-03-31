import axios from "axios";
import Cookies from "js-cookie";

export const fetchTrainers = async () => {
    const token = Cookies.get("X-Access-Token");
    try {
        const response = await axios
            .get(`${process.env.REACT_APP_API_BASE_URL}/api/Users/FindTrainers`, { headers: { authorization: `bearer ${token}` } });
        return response.data;
    } catch (err) {
        console.log(err);
    };
};