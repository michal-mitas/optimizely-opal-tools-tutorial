using OpalToolsTutorial.Web.RolePlayingGame.Character;
using Optimizely.Opal.Tools;

var builder = WebApplication.CreateBuilder(args);

// Add the Opal Tools service
builder.Services.AddOpalToolService();

// Register sample tools
builder.Services.AddOpalTool<CharacterTools>();

var app = builder.Build();

// Map the Opal Tools endpoints (creates /discovery and tool-specific endpoints)
app.MapOpalTools();

// Start the app
app.Run();