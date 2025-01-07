import axios from "axios";
import { Run } from "@/lib/ent/run";

async function getRuns() {
    const runs = await axios.get('http://localhost:5192/api/Runs');
    return runs.data;
};

async function postRun(run: Run) {  
    await axios.post('http://localhost:5192/api/Runs', run);
};

export const RunService = {
    getRuns,
    postRun
};