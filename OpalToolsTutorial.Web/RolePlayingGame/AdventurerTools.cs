using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.RolePlayingGame;

public class AdventurerTools
{
    
    private static readonly Dictionary<string, Adventurer> Adventurers = new Dictionary<string, Adventurer>
    {
        { "Bob", new Adventurer { Name = "Bob", Race = "Human", Class = "Warrior", Level = 1, HP = 16, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Alice", new Adventurer { Name = "Alice", Race = "Elf", Class = "Mage", Level = 1, HP = 10, Inventory = new[] { "Book", "Potion", "Wand" } } },
        { "Charlie", new Adventurer { Name = "Charlie", Race = "Dwarf", Class = "Rogue", Level = 1, HP = 12, Inventory = new[] { "Dagger", "Sword", "Shield" } } },
        { "Dave", new Adventurer { Name = "Dave", Race = "Gnome", Class = "Priest", Level = 1, HP = 8, Inventory = new[] { "Book", "Potion", "Wand" } } },
        { "Eve", new Adventurer { Name = "Eve", Race = "Halfling", Class = "Rogue", Level = 1, HP = 14, Inventory = new[] { "Dagger", "Sword", "Shield" } } },
        { "Frank", new Adventurer { Name = "Frank", Race = "Orc", Class = "Warrior", Level = 1, HP = 18, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "George", new Adventurer { Name = "George", Race = "Troll", Class = "Warrior", Level = 1, HP = 20, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Harry", new Adventurer { Name = "Harry", Race = "Human", Class = "Warrior", Level = 1, HP = 16, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Ivy", new Adventurer { Name = "Ivy", Race = "Elf", Class = "Mage", Level = 1, HP = 10, Inventory = new[] { "Book", "Potion", "Wand" } } },
    };

    [OpalTool(Name = "get-adventurer-details")]
    [Description("Get's adventurer details based on his name")]
    public object GetAdventurer(AdventurerParameters parameters)
    {
        if (Adventurers.ContainsKey(parameters.Name))
        {
            return Adventurers[parameters.Name];
        }
        else
        {
            return new {
                error = "Adventurer not found"
            };
        }
    }

    [OpalTool(Name = "get-all-adventurers")]
    [Description("Get's all Adventurers details")]
    public object GetAllAdventurers(GetAllAdventurersParameters parameters)
    {
        return Adventurers.Values.ToList();
    }

    [OpalTool(Name = "hire-adventurers")]
    [Description("Hires adventurers and assigns them on a quest")]
    [OpalAuthorization("OptiId", "cms", true)]
    public object HireAdventurers(HireAdventurersParameters parameters)
    {
        return "Those adventurers have been hired by " + parameters.GuildClientName + ": " + string.Join(", ", parameters.AdventurerNames);
    }
}