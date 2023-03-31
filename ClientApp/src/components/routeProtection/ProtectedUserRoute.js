import React from "react";
import Cookies from "js-cookie";
import { Navigate } from "react-router-dom";

const ProtectedUserRoute = ({ children }) => {
    const role = Cookies.get("Role");

    if (role !== "User") {
        return <Navigate to="/home" replace />
    };

    return children;
};

export default ProtectedUserRoute;