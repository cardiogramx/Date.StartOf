using System;

namespace Date.StartOf
{
    public static partial class StartOf
    {
        public static DateTime StartOfBusinessDay(this DateTime dateTime) =>
           new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 8, 0, 0);

        public static DateTime StartOfDay(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);

        public static DateTime StartOfBusinessWeek(this DateTime dateTime) => dateTime.DayOfWeek switch
        {
            DayOfWeek.Tuesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-1),
            DayOfWeek.Wednesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-2),
            DayOfWeek.Thursday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-3),
            DayOfWeek.Friday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-4),
            DayOfWeek.Saturday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-5),
            DayOfWeek.Sunday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-6),

            _ => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day)
        };

        public static DateTime StartOfWeek(this DateTime dateTime) => dateTime.DayOfWeek switch
        {
            DayOfWeek.Monday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-1),
            DayOfWeek.Tuesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-2),
            DayOfWeek.Wednesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-3),
            DayOfWeek.Thursday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-4),
            DayOfWeek.Friday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-5),
            DayOfWeek.Saturday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-6),

            _ => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day)
        };

        public static DateTime StartOfMonth(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.Month, dateTime.AddDays(-dateTime.Day + 1).Day);

        public static DateTime StartOfYear(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.AddMonths(-dateTime.Month + 1).Month, 1);
    }
}