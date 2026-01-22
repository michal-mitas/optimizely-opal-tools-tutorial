using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.Sample.Greeting;

public class GreetingTool
{
    [OpalTool(Name = "greeting")]
    [Description("Greets a person in a random language (English, Spanish, or French)")]
    public object Greet(GreetingParameters parameters)
    {
        // Get parameters
        var name = parameters.Name;
        var language = parameters.Language;

        // If language not specified, choose randomly
        if (string.IsNullOrEmpty(language))
        {
            var random = new Random();
            var languages = new[] { "english", "spanish", "french" };
            language = languages[random.Next(languages.Length)];
        }

        // Generate greeting based on language
        string greeting;
        if (language.ToLower() == "spanish")
        {
            greeting = $"�Hola, {name}! �C�mo est�s?";
        }
        else if (language.ToLower() == "french")
        {
            greeting = $"Bonjour, {name}! Comment �a va?";
        }
        else // Default to English
        {
            greeting = $"Hello, {name}! How are you?";
        }

        return new
        {
            greeting,
            language
        };
    }
}