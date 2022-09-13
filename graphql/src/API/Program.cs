using GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQL(b => b
    .AddAutoClrMappings()
    .AddErrorInfoProvider(options => options.ExposeExceptionDetails = builder.Environment.IsDevelopment())
    .AddSystemTextJson());

var app = builder.Build();

app.UseGraphQL();
app.UseGraphQLPlayground();

app.Run();
