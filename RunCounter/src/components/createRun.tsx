import { Button } from "@/components/ui/button";
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from "@/components/ui/dialog";
import { Input } from "@/components/ui/input";
import {
  Popover,
  PopoverContent,
  PopoverTrigger,
} from "@/components/ui/popover";
import { cn } from "@/lib/utils";
import { useState } from "react";
import { format } from "date-fns";
import { Calendar } from "@/components/ui/calendar";

function CreateRun() {
  const [date, setDate] = useState(new Date());
  const [runName, setRunName] = useState("");
  const [distance, setDistance] = useState("");
  const [time, setTime] = useState("");
  const [pace, setPace] = useState("");
  const [notes, setNotes] = useState("");

  return (
    <div>
      <Dialog>
        <DialogTrigger>
          <Button>Create Run</Button>
        </DialogTrigger>
        <DialogContent>
          <DialogHeader>
            <DialogTitle>Dialog Title</DialogTitle>
            <DialogDescription>
              This is a description of the dialog content.
            </DialogDescription>
          </DialogHeader>
          <Input
            onChange={(e) => setRunName(e.target.value)}
            placeholder="Run Name"
          />
          <Input
            onChange={(e) => setDistance(e.target.value)}
            type="number"
            placeholder="Distance in km ex 10"
          />
          <Input
            onChange={(e) => setTime(e.target.value)}
            type="number"
            placeholder="Time in minutes ex 64"
          />
          <Input
            onChange={(e) => setPace(e.target.value)}
            type="number"
            placeholder="Pace ex 6,10"
          />
          <Popover>
            <PopoverTrigger asChild>
              <Button
                variant={"outline"}
                className={cn(
                  "w-[280px] justify-start text-left font-normal",
                  !date && "text-muted-foreground"
                )}
              >
                {date ? format(date, "PPP") : <span>Pick a date</span>}
              </Button>
            </PopoverTrigger>
            <PopoverContent className="w-auto p-0">
              <Calendar
                mode="single"
                selected={date}
                onDayClick={(day) => setDate(day)}
                initialFocus
              />
            </PopoverContent>
          </Popover>
          <Input
            onChange={(e) => setNotes(e.target.value)}
            placeholder="Notes"
          />
          <Button>Create Run</Button>
        </DialogContent>
      </Dialog>
    </div>
  );
}

export default CreateRun;
