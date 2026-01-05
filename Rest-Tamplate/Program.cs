var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<Reposetory>();




////Cors
//string allowAnything = "allowAnything";
//string allowGetPut = "allowGetPut";

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(allowGetPut,
//                builder =>
//                    builder.AllowAnyOrigin()
//                    .WithMethods("GET", "PUT")
//                    .AllowAnyHeader());
//    options.AddPolicy(allowAnything,
//        builder =>
//            builder.AllowAnyOrigin()
//                .AllowAnyMethod()
//                .AllowAnyHeader());
//});
//app.UseCors(allowAnything);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
