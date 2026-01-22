using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpalToolsTutorial.Web.RolePlayingGame.Character;

public class CharacterParameters
{
    [Required]
    [Description("Name of the character")]
    public string Name { get; set; } = string.Empty;
}