import React from "react";
import { Routes, Route } from "react-router-dom";

import Home from "./components/home/Home";
import NotFound from "./components/layout/NotFound";
import ProtectedRoute from "./components/routeProtection/ProtectedRoute";
import Profile from './components/profile/Profile';
import ProtectedUserRoute from "./components/routeProtection/ProtectedUserRoute";
import FindTrainers from "./components/findTrainers/FindTrainers";

const AppRoutes = () => {
    return (
        <Routes>
            <Route
                index
                element={<Home />}
            />
            <Route
                exact
                path="home"
                element={<Home />}
            />
            <Route
                path="profile"
                element={
                    <ProtectedRoute>
                        <Profile />
                    </ProtectedRoute>
                }
            />
            <Route
                path="findtrainers"
                element={
                    <ProtectedRoute>
                        <ProtectedUserRoute>
                            <FindTrainers />
                        </ProtectedUserRoute>
                    </ProtectedRoute>
                }
            />
            <Route
                to="*"
                element={<NotFound />}
            />
        </Routes>
    );
};

export default AppRoutes;