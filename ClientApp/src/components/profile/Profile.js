import React, { useState } from "react";
import { useQuery } from "@tanstack/react-query";

import EditForm from "./EditForm";
import UserInfo from "./UserInfo";
import { fetchProfile } from "../../services/ProfileService";
import Appointments from "../appointments/Appointments";

const Profile = () => {
    const { data, isLoading, isError, error } = useQuery(["profile"], fetchProfile);
    const [editView, setEditView] = useState(false);

    const editProfile = () => {
        setEditView(true);
    };

    if (isLoading) {
        return <span>Loading...</span>
    };

    if (isError) {
        return <span className="mt-32">Error: {error.message}</span>
    };

    return (
        <div className="flex justify-center">
            <div className="mt-8 md:mt-12 mb-20 p-8 w-full md:w-[80vw] h-full">
                <div className="border-b-2 flex justify-between">
                    <h1 className="text-4xl">Profile</h1>
                    {editView ?
                        null
                        :
                        <button
                            className="text-green"
                            onClick={editProfile}>
                            Edit Profile
                        </button>}
                </div>
                <section>
                    {editView ?
                        <EditForm
                            setNeedsEdit={setEditView}
                            data={data} />
                        :
                        <UserInfo data={data} />
                    }
                </section>
                <section>
                    <Appointments />
                </section>
            </div>
        </div>
    );
};

export default Profile;