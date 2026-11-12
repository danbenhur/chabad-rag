// Step 2: the passage lives in a data file, not in the code.
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Path to data/passage.json at the repo root (two folders up from the project).
var dataPath = Path.Combine(builder.Environment.ContentRootPath, "..", "..", "data", "passage.json");
var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

app.MapGet("/passage", async () =>
{
    // Read the file as text, then turn the JSON text into a Passage record (deserialize).
    var json = await File.ReadAllTextAsync(dataPath);
    var passage = JsonSerializer.Deserialize<Passage>(json, jsonOptions);
    return passage is null ? Results.Problem("passage.json is empty or invalid") : Results.Ok(passage);
});

app.Run();

// A record = a small immutable data type. ASP.NET turns it into JSON automatically.
record Passage(string Source, string Text);
