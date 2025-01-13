import axios from "axios";
import { Run } from "@/lib/ent/run";
import { url } from "./env";

async function getRuns() {
    const runs = await axios.get(url + '/Runs');
    return runs.data;
};

async function postRun(run: Run) {  
    await axios.post(url + '/Runs', run);
};

export const RunService = {
    getRuns,
    postRun
};