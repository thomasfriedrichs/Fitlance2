// helpers/geocode.js

import axios from "axios";

export const getLatLngFromAddress = async (address) => {
    try {
        const response = await axios.get(
            `https://nominatim.openstreetmap.org/search?format=json&q=${encodeURIComponent(
                address
            )}`
        );

        if (response.data && response.data.length > 0) {
            const { lat, lon } = response.data[0];
            return { lat, lng: lon };
        } else {
            throw new Error("Couldn't find coordinates for the provided address");
        }
    } catch (error) {
        console.error("Error getting coordinates:", error);
        throw error;
    }
};
