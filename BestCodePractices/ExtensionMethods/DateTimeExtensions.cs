using System;

namespace BestCodePractices.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static string ToUnixTimeStamp(this DateTime dateTime)
        {
            var unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var unixTimeStampInTicks = (dateTime - unixStart).Ticks;
            var ticks = unixTimeStampInTicks / TimeSpan.TicksPerSecond;
            return ticks.ToString();
        }

        public static DateTime GetStartDayOfWeek(this DateTime date, DayOfWeek startOfWeek)
        {
            int diff = date.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return date.AddDays(-1 * diff).Date;
        }

        public static DateTime GetLastDayOfWeek(this DateTime date, DayOfWeek startOfWeek)
        {
            return date.GetStartDayOfWeek(startOfWeek).AddDays(6).Date;
        }

        public static DateTime ToTimeZone(this DateTime dateTime, TimeZoneInfo timeZoneInfo)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime.ToUniversalTime(), timeZoneInfo);
        }

        public static DateTime ToTimeZone(this DateTime dateTime, string timeZoneId)
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return dateTime.ToUniversalTime().ToTimeZone(timeZoneInfo);
        }
    }
}