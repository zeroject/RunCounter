import CreateRun from "@/components/createRun";
import { ChartConfig, ChartContainer, ChartTooltip, ChartTooltipContent } from "@/components/ui/chart";
import { Progress } from "@/components/ui/progress";
import { useAuth0 } from "@auth0/auth0-react";
import { useEffect, useState } from "react";
import { Bar, BarChart, XAxis } from "recharts"

const chartData = [
  { month: "January", desktop: 186, mobile: 80 },
  { month: "February", desktop: 305, mobile: 200 },
  { month: "March", desktop: 237, mobile: 120 },
  { month: "April", desktop: 73, mobile: 190 },
  { month: "May", desktop: 209, mobile: 130 },
  { month: "June", desktop: 214, mobile: 140 },
]

const chartConfig = {
  desktop: {
    label: "Desktop",
    color: "#2563eb",
  }
} satisfies ChartConfig


function Home() {
  const { isAuthenticated } = useAuth0();
  const [progress, setProgress] = useState(0);


  useEffect(() => {
    const timer = setTimeout(() => setProgress(66), 500)
    return () => clearTimeout(timer)
  }, [])

  return (
    <div>
      {isAuthenticated ? (
        <div className="flex justify-end pr-4">
          <CreateRun />
        </div>
      ) : (
        <></>
      )}
      <div className="flex flex-col items-center">
        <h1 className="text-4xl font-bold mb-4">Welcome to Run Tracker</h1>
        <div className="w-96">
          <label className="text-lg">Km left {1000 - progress}</label>
          <Progress value={progress} />
          <ChartContainer config={chartConfig} className="mt-4" title="Runs">
            <BarChart accessibilityLayer width={600} height={300} data={chartData}>
              <XAxis
                dataKey="month"
                axisLine={false}
                tickLine={false}
                tickMargin={10} />
              <ChartTooltip content={<ChartTooltipContent  />} />
              <Bar dataKey="desktop" fill="#8884d8" />
            </BarChart>
          </ChartContainer>
        </div>
      </div>
    </div>
  );
}

export default Home;
