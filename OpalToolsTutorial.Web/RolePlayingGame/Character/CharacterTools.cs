using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.RolePlayingGame.Character;

public class CharacterTools
{
    [OpalTool(Name = "get-character")]
    [Description("Get's a character details")]
    public object GetCharacter(CharacterParameters parameters)
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