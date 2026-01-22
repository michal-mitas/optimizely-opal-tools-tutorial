using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.RolePlayingGame;

public class AdventurerTools
{
    [OpalTool(Name = "get-adventurer-details")]
    [Description("Get's adventurer details based on his name")]
    public object GetCharacter(AdventurerParameters parameters)
    {
        if (parameters.Name == "Bob")
        {
            // Return a character details
            return new {
                name = "Bob",
                race = "Human",
                className = "Warrior",
                level = 1,
                hp = 16,
                inventory = new[] { "Sword", "Shield", "Armor" }
            };
        }
        else
        {
            return new {
                error = "Character not found"
            };
        }
    }
}