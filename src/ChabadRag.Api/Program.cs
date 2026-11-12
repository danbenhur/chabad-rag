// Step 1: one endpoint, one hardcoded Tanya passage. No AI, no Azure yet.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/passage", () => new Passage(
    Source: "Tanya, Likkutei Amarim, Chapter 1",
    Text: "תניא [בסוף פרק ג' דנדה]: משביעים אותו: תהי צדיק ואל תהי רשע, ואפילו כל העולם כולו אומרים לך צדיק אתה – היה בעיניך כרשע."
));

app.Run();

// A record = a small immutable data type. ASP.NET turns it into JSON automatically.
record Passage(string Source, string Text);
