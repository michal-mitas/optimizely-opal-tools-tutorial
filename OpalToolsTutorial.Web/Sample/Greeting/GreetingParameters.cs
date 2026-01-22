using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpalToolsTutorial.Web.Sample.Greeting;

public class GreetingParameters
{
    [Required]
    [Description("Name of the person to greet")]
    public string Name { get; set; } = string.Empty;

    [Description("Language for greeting (defaults to random)")]
    public string? Language { get; set; }
}