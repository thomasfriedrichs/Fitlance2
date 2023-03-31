import { QueryClient, QueryClientProvider } from "@tanstack/react-query";

import AppRoutes from "./AppRoutes";
import Layout from "./components/layout/Layout";

const queryClient = new QueryClient();

const App = () => {
    return (
        <QueryClientProvider client={queryClient}>
            <Layout>
                <AppRoutes />
            </Layout>
        </QueryClientProvider>
    );
};

export default App;