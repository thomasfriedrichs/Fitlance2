import { Navigate } from "react-router-dom";
import { useCookieWatcher } from "@fcannizzaro/react-use-cookie-watcher";

const ProtectedRoute = ({ children }) => {
    const cookieExists = useCookieWatcher("X-Access-Token", {
        checkEvery: 500
    });

    if (!cookieExists) {
        return <Navigate to="/home" replace />;
    };

    return children;
};

export default ProtectedRoute;