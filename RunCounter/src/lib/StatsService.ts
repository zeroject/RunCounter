import axios from "axios";

async function getStats() {
    const stats = await axios.get('http://localhost:5192/api/Stats');
    return stats.data;
};

export const StatsService = {
    getStats,
};