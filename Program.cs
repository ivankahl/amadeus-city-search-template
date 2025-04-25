using AmadeusCitySearch.Amadeus;

var builder = WebApplication.CreateBuilder(args);

// Register the AmadeusOptions class
builder.Services.Configure<AmadeusOptions>(builder.Configuration.GetSection(AmadeusOptions.Amadeus));

// Register all the HttpClient-related services
builder.Services.AddHttpClient();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Write endpoints here

await app.RunAsync();