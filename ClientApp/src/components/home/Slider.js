import React, { useState } from "react";
import { Left, Right } from "@icon-park/react";

import Images from "./Images";

const Slider = () => {
    const [currentIndex, setCurrentIndex] = useState(0);

    const onLeft = () => {
        if (currentIndex === 0) {
            setCurrentIndex(Images.length - 1)
        } else {
            setCurrentIndex(currentIndex - 1)
        };
    };

    const onRight = () => {
        if (currentIndex === Images.length - 1) {
            setCurrentIndex(0)
        } else {
            setCurrentIndex(currentIndex + 1)
        };
    };

    return (
        <div className="flex items-center justify-center">
            <Left size={60} onClick={onLeft} />
            <img
                src={Images[currentIndex].src}
                alt={Images[currentIndex].alt}
                className="max-w-[16rem] min-[500px]:max-h-[16rem] sm:max-h-[24rem] sm:max-w-none lg:max-h-[38rem]"
            />
            <Right size={60} onClick={onRight} />
        </div>
    );
};

export default Slider;