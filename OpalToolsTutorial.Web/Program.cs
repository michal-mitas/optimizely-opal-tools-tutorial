using OpalToolsTutorial.Web.Sample.Greeting;
using OpalToolsTutorial.Web.Sample.TodaysDate;
using Optimizely.Opal.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

// Add the Opal Tools service
builder.Services.AddOpalToolService();

// Register sample tools
builder.Services.AddOpalTool<GreetingTool>();
builder.Services.AddOpalTool<TodaysDateTool>();


var app = builder.Build();

// Map the Opal Tools endpoints (creates /discovery and tool-specific endpoints)
app.MapOpalTools();

// Start the app
app.Run();

// Tool parameter models

// Tool implementations