using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;
using Segundaria.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICourseRepository, SqlCourseRepository>();
builder.Services.AddScoped<IDegreeRepository, SqlDegreeRepository>();
builder.Services.AddScoped<IParentRepository, SqlParentRepository>();
builder.Services.AddScoped<ISectionRepository, SqlSectionRepository>();
builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();
builder.Services.AddScoped<ITeacherRepository, SqlTeacherRepository>();
builder.Services.AddScoped<ITuitionRepository, SqlTuitionRepository>();
builder.Services.AddScoped<IUserRepository, SqlUserRepository>();

builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdminTuition")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
