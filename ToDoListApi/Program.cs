
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using ToDoListApi.Models;
using ToDoListApi.Repository;

namespace ToDoListApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("Task1")));
            builder.Services.AddScoped<ITaskRepo, TaskRepo>();
            builder.Services.AddScoped<Context, Context>();
            builder.Services.AddCors(options => {
                options.AddPolicy("Policy", policy => {
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("Policy");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}