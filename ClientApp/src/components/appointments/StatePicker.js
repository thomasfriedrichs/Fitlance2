import React from "react";

const StatePicker = ({ field }) => {
    const states = [
    "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
    "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
    "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
    "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
    "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
    ];

    return (
        <select
            {...field}
            className="shadow-sm w-[95%] rounded-lg text-center p-1"
        >
        <option value="" disabled>
            Select State
        </option>
        {states.map((state) => (
            <option key={state} value={state}>
                {state}
            </option>
        ))}
        </select>
    );
};

export default StatePicker;
