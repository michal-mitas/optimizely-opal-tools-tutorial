using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.Sample.TodaysDate;

public class TodaysDateTool
{
    [OpalTool(Name = "todays-date")]
    [Description("Returns today's date in the specified format")]
    public object GetDate(DateParameters parameters)
    {
        // Get parameters
        var format = parameters.Format;

        // Get today's date
        var today = DateTime.Now;

        // Format the date
        var formattedDate = today.ToString(format);

        return new
        {
            date = formattedDate,
            format,
            timestamp = ((DateTimeOffset)today).ToUnixTimeSeconds()
        };
    }
}