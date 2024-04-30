using Microsoft.EntityFrameworkCore;

namespace Test_EmployeeAPI
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


            string cs = "server=SaiRoopesh\\SQLEXPRESS;user id=sa;password=Home@1405;database=test_employee";
            builder.Services.AddDbContext<test_employeeContext>(options => options.UseSqlServer(cs));
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());



            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
