using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpalToolsTutorial.Web.RolePlayingGame;
public class AdventurerParameters
{
    [Required]
    [Description("Name of the adventurer")]
    public string Name { get; set; } = string.Empty;
}