using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IT212FinalProject.Data;

namespace IT212FinalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<IT212FinalProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("IT212FinalProjectContext") ?? throw new InvalidOperationException("Connection string 'IT212FinalProjectContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
