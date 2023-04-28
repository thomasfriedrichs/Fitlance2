import React from "react";
import DatePicker from "react-date-picker";
import 'react-date-picker/dist/DatePicker.css';
import 'react-calendar/dist/Calendar.css';

import "./index.css";

const CustomDatePicker = ({ field, form, ...props }) => {
    const { setFieldValue } = form;
    const { name } = field;

    const handleChange = (val) => {
        const newStartDate = new Date(form.values.startTime);
        newStartDate.setFullYear(val.getFullYear(), val.getMonth(), val.getDate());
        setFieldValue('startTime', newStartDate);

        const newEndDate = new Date(form.values.endTime);
        newEndDate.setFullYear(val.getFullYear(), val.getMonth(), val.getDate());
        setFieldValue('endTime', newEndDate);
    };

    return (
        <DatePicker
            {...field}
            {...props}
            value={field.value}
            onChange={handleChange}
        />
    );
};

export default CustomDatePicker;