namespace UtilExtensions;

public static class DateTimeExtensions
{
    public static void Deconstruct(this DateTime d, out int month, out int day, out int year)
    {
        day = d.Day;
        month = d.Month;
        year = d.Year;
    }
}
