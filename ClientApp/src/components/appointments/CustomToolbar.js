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
                    className={`text-gray-600 font-semibold text-lg focus:outline-none hover:text-blue-600 
                              ${view === name ? 'underline' : ''}`}
                >
                    {viewDisplayNames[name]}
                </button>
            ));
        }
    };


    return (
        <div className="flex justify-between items-center p-2 bg-gray-200 border-b border-gray-300">
            <div className="flex space-x-4">
                <button
                    onClick={goToBack}
                    className="text-gray-600 font-semibold text-lg focus:outline-none hover:text-blue-600"
                >
                    &#8249;
                </button>
                <button
                    onClick={goToCurrent}
                    className="text-gray-600 font-semibold text-lg focus:outline-none hover:text-blue-600"
                >
                    Today
                </button>
                <button
                    onClick={goToNext}
                    className="text-gray-600 font-semibold text-lg focus:outline-none hover:text-blue-600"
                >
                    &#8250;
                </button>
            </div>
            <span className="font-semibold text-lg">{label()}</span>
            <div className="flex space-x-4">{viewNamesGroup()}</div>
        </div>
    );
};

export default CustomToolbar;