import axios from "axios";
import { url } from "./env";

async function getStats() {
    const stats = await axios.get(url + '/Stats');
    return stats.data;
};

export const StatsService = {
    getStats,
};