using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalToolsTutorial.Web.RolePlayingGame.Character;

public class CharacterTools
{
    private record Character
    {
        public required string Name { get; set; }
        public required string Race { get; set; }
        public required string Class { get; set; }
        public required int Level { get; set; }
        public required int HP { get; set; }
        public required string[] Inventory { get; set; }
    }
    
    private static readonly Dictionary<string, Character> characters = new Dictionary<string, Character>
    {
        { "Bob", new Character { Name = "Bob", Race = "Human", Class = "Warrior", Level = 1, HP = 16, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Alice", new Character { Name = "Alice", Race = "Elf", Class = "Mage", Level = 1, HP = 10, Inventory = new[] { "Book", "Potion", "Wand" } } },
        { "Charlie", new Character { Name = "Charlie", Race = "Dwarf", Class = "Rogue", Level = 1, HP = 12, Inventory = new[] { "Dagger", "Sword", "Shield" } } },
        { "Dave", new Character { Name = "Dave", Race = "Gnome", Class = "Priest", Level = 1, HP = 8, Inventory = new[] { "Book", "Potion", "Wand" } } },
        { "Eve", new Character { Name = "Eve", Race = "Halfling", Class = "Rogue", Level = 1, HP = 14, Inventory = new[] { "Dagger", "Sword", "Shield" } } },
        { "Frank", new Character { Name = "Frank", Race = "Orc", Class = "Warrior", Level = 1, HP = 18, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "George", new Character { Name = "George", Race = "Troll", Class = "Warrior", Level = 1, HP = 20, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Harry", new Character { Name = "Harry", Race = "Human", Class = "Warrior", Level = 1, HP = 16, Inventory = new[] { "Sword", "Shield", "Armor" } } },
        { "Ivy", new Character { Name = "Ivy", Race = "Elf", Class = "Mage", Level = 1, HP = 10, Inventory = new[] { "Book", "Potion", "Wand" } } },
    };


    [OpalTool(Name = "get-character")]
    [Description("Get's a character details")]
    public object GetCharacter(GetCharacterParameters parameters)
    {
        if (characters.ContainsKey(parameters.Name))
        {            
            return characters[parameters.Name];
        }
        else
        {
            return new {
                error = "Character not found"
            };
        }
    }

    [OpalTool(Name = "get-all-characters")]
    [Description("Get's all characters details")]
    public object GetAllCharacters(GetAllCharactersParameters parameters)
    {
        return characters.Values.ToList();
    }
}