using BenchmarkDotNet.Attributes;
using System;

namespace _Benchmark
{
    public class BenchMarkIfVsSwitch
    {
        [Benchmark]
        public void SwitchFunction()
        {
            string day = "Saturday";
            string DayType;
            switch (day)
            {
                case "Monday":
                    DayType = "Weekday";
                    break;
                case "Tuesday":
                    DayType = "Weekday";
                    break;
                case "Wednesday":
                    DayType = "Weekday";
                    break;
                case "Thursday":
                    DayType = "Weekday";
                    break;
                case "Friday":
                    DayType = "Weekday";
                    break;
                case "Saturday":
                    DayType = "Weekend";
                    break;
                default:
                    DayType = "Weekend";
                    break;
            }
        }

        [Benchmark]
        public void IfFunction()
        {
            string day = "Saturday";
            string DayType;
            if (day == "Monday")
                DayType = "Weekday";
            else if (day == "Tuesday")
                DayType = "Weekday";
            else if (day == "Wednesday")
                DayType = "Weekday";
            else if (day == "Thursday")
                DayType = "Weekday";
            else if (day == "Friday")
                DayType = "Weekday";
            else if (day == "Saturday")
                DayType = "Weekend";
            else
                DayType = "Weekend";

        }

    }

}



