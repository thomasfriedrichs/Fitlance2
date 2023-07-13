// Custom hook for lazy loading items
// items - An array of items to be displayed
// loadCount - The number of items to display each time

import { useState, useEffect } from "react";

const useLazyLoadItems = (items, loadCount, containerRef) => {
    // State to store the items that are currently displayed
    const [displayedItems, setDisplayedItems] = useState([]);

    //Sort items by date
    const sortItems = (items) => {
        return [...items].sort((a, b) => {
            return new Date(a.startTimeUtc) - new Date(b.startTimeUtc);
        });
    };

    // Effect to initialize the displayed items when the items array changes
    useEffect(() => {
        if (items) {
            setDisplayedItems(sortItems(items.slice(0, loadCount)));
        }
    }, [items, loadCount]);

    // Effect to add the scroll event listener to the window
    useEffect(() => {
        const handleScroll = () => {
            if (!containerRef.current) return;

            const container = containerRef.current;
            const { scrollHeight, scrollTop, clientHeight } = container;

            // Check if the user has scrolled to the bottom of the container
            if (scrollHeight - scrollTop <= clientHeight + 1) {
                // Load more items
                setDisplayedItems((prevItems) => {
                    const nextIndex = prevItems.length;
                    return [...prevItems, ...items.slice(nextIndex, nextIndex + loadCount)];
                });
            }
        };

        if (containerRef.current) {
            containerRef.current.addEventListener("scroll", handleScroll);
        }

        // Clean up the event listener when the component is unmounted
        return () => {
            if (containerRef.current) {
                containerRef.current.removeEventListener("scroll", handleScroll);
            }
        };
    }, [items, loadCount, containerRef]);

    return displayedItems;
};

export default useLazyLoadItems;