namespace OpalToolsTutorial.Web.RolePlayingGame;

public record Adventurer
{
    public required string Name { get; set; }
    public required string Race { get; set; }
    public required string Class { get; set; }
    public required int Level { get; set; }
    public required int HP { get; set; }
    public required string[] Inventory { get; set; }
}