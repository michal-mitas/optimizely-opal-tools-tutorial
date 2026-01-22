using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpalToolsTutorial.Web.RolePlayingGame;

<<<<<<<< HEAD:OpalToolsTutorial.Web/RolePlayingGame/GetCharacterParameters.cs
public class GetCharacterParameters
========
public class AdventurerParameters
>>>>>>>> tutorial/001-get-adventurer-details:OpalToolsTutorial.Web/RolePlayingGame/AdventurerParameters.cs
{
    [Required]
    [Description("Name of the adventurer")]
    public string Name { get; set; } = string.Empty;
}