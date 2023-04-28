import TimeRangePicker from "@wojtekmaj/react-timerange-picker";
import '@wojtekmaj/react-timerange-picker/dist/TimeRangePicker.css';
import 'react-clock/dist/Clock.css';

import "./index.css";

const CustomTimeRangePicker = ({ field, form, ...props }) => {
    const { setFieldValue } = form;
    const { name } = field;

    const formatTimeRange = () => {
        const startTime = form.values.startTime;
        const endTime = form.values.endTime;
        return [
            startTime ? `${startTime.getHours()}:${startTime.getMinutes()}` : '',
            endTime ? `${endTime.getHours()}:${endTime.getMinutes()}` : '',
        ];
    };

    const handleChange = (val) => {
        const [start, end] = val;
        const [startHour, startMinute] = start.split(':');
        const [endHour, endMinute] = end.split(':');

        const newStartTime = new Date(form.values.startTime);
        newStartTime.setHours(startHour, startMinute);
        setFieldValue('startTime', newStartTime);

        const newEndTime = new Date(form.values.endTime);
        newEndTime.setHours(endHour, endMinute);
        setFieldValue('endTime', newEndTime);
    };

    return (
        <TimeRangePicker
            {...field}
            {...props}
            value={formatTimeRange()}
            onChange={handleChange}
        />
    );
};

export default CustomTimeRangePicker;