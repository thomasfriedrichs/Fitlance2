import { useState, useEffect } from "react";

const useButtonDisabled = (formik, startTime, endTime) => {
    const [isButtonDisabled, setIsButtonDisabled] = useState(true);

    useEffect(() => {
        setIsButtonDisabled(!(formik.dirty && formik.isValid && startTime && endTime));
    }, [formik.dirty, formik.isValid, startTime, endTime]);

    return isButtonDisabled;
};

export default useButtonDisabled;
