using System;

namespace WorkingTime
{
    public static class WorkingTimeFunction
    {
        public static double availableDaysOff(int hoursPerWeek, int workedDays, int overtime)
        {
            if (hoursPerWeek < 20 || workedDays < 0 || overtime < 0 || hoursPerWeek > 40 || workedDays > 200 || overtime > 22)
            {
                ArgumentLogger.addEntryToList(hoursPerWeek, workedDays, overtime, -1);
                throw new ArgumentException("Invalid arguments supplied!");
            }

            double hoursPerDay = 8.0;
            double daysPerWeek = 5.0;
            double employmentLevel = hoursPerWeek / 40.0;
            double workedHours = workedDays * hoursPerDay * employmentLevel;
            double vacationHours = workedHours / daysPerWeek;
            double availableHoursFromOvertime = overtime * 1.5;

            double result = (vacationHours + availableHoursFromOvertime) / hoursPerDay;

            ArgumentLogger.addEntryToList(hoursPerWeek, workedDays, overtime, result);
            return result;
        }
    }
}
