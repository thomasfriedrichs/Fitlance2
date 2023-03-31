import React from "react";
import { Instagram, Twitter, FacebookOne, Tiktok } from "@icon-park/react";

const Footer = () => {
    return (
        <footer
            className="bg-slate-100 fixed bottom-0 h-24 w-[100vw]"
        >
            <div className="py-[2rem] flex justify-evenly">
                <span>
                    <Instagram size="32" />
                </span>
                <span>
                    <Twitter size="32" />
                </span>
                <span>
                    <FacebookOne size="32" />
                </span>
                <span>
                    <Tiktok size="32" />
                </span>
            </div>
        </footer>
    );
};

export default Footer;