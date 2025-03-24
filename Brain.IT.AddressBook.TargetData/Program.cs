using Brain.IT.AddressBook.TargetData.Data;
using Brain.IT.AddressBook.TargetData.Profiles;
using Brain.IT.AddressBook.TargetData.Repositories;
using Brain.IT.AddressBook.TargetData.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
builder.Services.AddSwaggerGen(c =>
{
	c.IncludeXmlComments(xmlPath);
});

builder.Services.AddDbContext<TargetDBContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<IdentityUser>()
	.AddEntityFrameworkStores<TargetDBContext>();

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddAutoMapper(typeof(ContactProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();

	// Create database
	using var scope = app.Services.CreateScope();
	var context = scope.ServiceProvider.GetRequiredService<TargetDBContext>();

	try
	{
		context.Database.Migrate();
	}
	catch (Exception ex)
	{
		throw new Exception("Crate databse error", ex);
	}
}

app.MapIdentityApi<IdentityUser>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
