import { Navigate } from 'react-big-calendar';

const CustomToolbar = (toolbar) => {
    const goToBack = () => {
        toolbar.onNavigate(Navigate.PREVIOUS);
    };

    const goToNext = () => {
        toolbar.onNavigate(Navigate.NEXT);
    };

    const goToCurrent = () => {
        toolbar.onNavigate(Navigate.TODAY);
    };

    const label = () => {
        const date = toolbar.date;
        return `${date.toLocaleString('default', { month: 'long' })} ${date.getFullYear()}`;
    };

    const viewDisplayNames = {
        month: 'Month',
        week: 'Week',
        day: 'Day',
        agenda: 'Agenda',
    };

    const viewNamesGroup = () => {
        const viewNames = toolbar.views;
        const view = toolbar.view;

        if (viewNames.length > 1) {
            return viewNames.map((name) => (
                <button
                    key={name}
                    onClick={() => toolbar.onView(name)}
                    className={`text-gray-600 font-semibold text-lg rounded-lg p-0.5 m-0.5 focus:outline-none hover:bg-[#dc3545] hover:text-white 
                                ${view === name ? 'text-white bg-[#dc3545]' : ''}`}
                >
                    {viewDisplayNames[name]}
                </button>
            ));
        }
    };

    return (
        <div className="flex flex-wrap justify-around items-center p-2 bg-gray-200 border-b border-gray-300">
            <div className="flex flex-wrap justify-around items-center w-full md:w-1/2">
                <div className="flex space-x-4 mb-2 md:mb-0">
                    <button
                        onClick={goToBack}
                        className="text-gray-600 font-semibold text-lg focus:outline-none"
                    >
                        &#8249;
                    </button>
                    <button
                        onClick={goToCurrent}
                        className="text-gray-600 font-semibold text-lg focus:outline-none hover:bg-[#dc3545] hover:text-white rounded-lg p-1"
                    >
                        Today
                    </button>
                    <button
                        onClick={goToNext}
                        className="text-gray-600 font-semibold text-lg focus:outline-none"
                    >
                        &#8250;
                    </button>
                </div>
                <span className="font-semibold text-lg mb-2 md:mb-0">{label()}</span>
            </div>
            <div className="flex">
                {viewNamesGroup()}
            </div>
        </div>
    );
};

export default CustomToolbar;