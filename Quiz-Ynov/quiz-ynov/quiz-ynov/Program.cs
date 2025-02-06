
using quiz_ynov.Business;
using quiz_ynov.Business.Services;
using quiz_ynov.Controllers.Mappers;

namespace quiz_ynov
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
            builder.Services.AddScoped<IQuizService,QuizService>();
            builder.Services.AddScoped<QuizMapper>();
            builder.Services.AddScoped<IQuestionService, QuestionService>();
            builder.Services.AddScoped<QuestionMapper>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<CategoryMapper>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}
