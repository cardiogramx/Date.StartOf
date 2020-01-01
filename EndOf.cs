using System;

namespace Date.StartOf
{
    public static partial class StartOf
    {
        public static DateTime EndOfBusinessDay(this DateTime dateTime) =>
           new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 18, 0, 0);

        public static DateTime EndOfDay(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59);

        public static DateTime EndOfBusinessWeek(this DateTime dateTime) => dateTime.DayOfWeek switch
        {
            DayOfWeek.Saturday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-1),
            DayOfWeek.Sunday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-2),
            DayOfWeek.Monday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-3),
            DayOfWeek.Tuesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-4),
            DayOfWeek.Wednesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-5),
            DayOfWeek.Thursday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-6),

            _ => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day)
        };

        public static DateTime EndOfWeek(this DateTime dateTime) => dateTime.DayOfWeek switch
        {
            DayOfWeek.Sunday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-1),
            DayOfWeek.Monday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-2),
            DayOfWeek.Tuesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-3),
            DayOfWeek.Wednesday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-4),
            DayOfWeek.Thursday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-5),
            DayOfWeek.Friday => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).AddDays(-6),

            _ => new DateTime(dateTime.Year, dateTime.Month, dateTime.Day)
        };

        public static DateTime EndOfMonth(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.Month, dateTime.AddDays(-dateTime.Day + 1).Day);

        public static DateTime EndOfYear(this DateTime dateTime) =>
            new DateTime(dateTime.Year, dateTime.AddMonths(-dateTime.Month + 1).Month, 1);
    }
}