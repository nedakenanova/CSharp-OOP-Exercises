using System;
using System.Globalization;
class Program
{
    public static bool TryParseBgDate(string s, out DateTime date)
    {
        if (s == null)
        {
            throw new ArgumentNullException("The string is null");
        }
        string[] formats = { "dd.MM.yyyy", "d/M/yy" };


        return DateTime.TryParseExact(
            s.Trim(),
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out date
        );
    }
}    