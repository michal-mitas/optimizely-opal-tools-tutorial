using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpalToolsTutorial.Web.RolePlayingGame;

public class HireAdventurersParameters
{
    [Required]
    [Description("A list of adventurer names to be hired")]
    public List<string> AdventurerNames { get; set; } = new List<string>();

    [Required]
    [Description("A name of the current Opal user making this request")]
    public string GuildClientName { get; set; } = string.Empty;
}