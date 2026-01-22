using System.ComponentModel;

namespace OpalToolsTutorial.Web.Sample.TodaysDate;

public class DateParameters
{
    [Description("Date format (defaults to ISO format)")]
    public string Format { get; set; } = "yyyy-MM-dd";
}