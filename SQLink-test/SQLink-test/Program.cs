
using Microsoft.EntityFrameworkCore;
using SQLink_test.Controllers;
using SQLink_test.Data;
using SQLink_test.service;
using SQLink_test.service.Cservice;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IDataContext, DataContext>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<DbcontextTicket>();
builder.Services.AddScoped<TicketsDb>();
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

var app = builder.Build();
TicketEndPoint.MapTicketEndpoints(app);
Usercontroller.MapUserEndpoints(app);
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


app.MapGet("/", () => "Hello World!");

app.Run();
