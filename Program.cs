using Microsoft.EntityFrameworkCore;
using backendnet.Data;
using backendnet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using backendnet.Middlewares;
using backendnet.Services;

var builder = WebApplication.CreateBuilder(args);

//Soporte para generar JWT
builder.Services.AddScoped<JwtTokenService>();

//Agregar soporte para MySQL
var connectionString = builder.Configuration.GetConnectionString("DataContext");
builder.Services.AddDbContext<IdentityContext>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

//Soporte para el Identity
builder.Services.AddIdentity<CustomIdentityUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
    //Cambiar a como queramos manejar las contraseñas
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
})
.AddEntityFrameworkStores<IdentityContext>();

//Soporte para JWT
builder.Services
    .AddHttpContextAccessor() //Para poder acceder al HttpContext()
    .AddAuthorization() //Para autorizar en cada metodo el acceso
    .AddAuthentication(options =>{
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options => //Para Autenticar con JWT
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"], //Leido desde appSettings
            ValidAudience = builder.Configuration["Jwt:Audience"], //Leido desde appSetting
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Secret"]!))
        };
    });

//Agregar soporte para CORS
builder.Services.AddCors(options =>{
    options.AddDefaultPolicy(
        policy => {
            policy.WithOrigins("http://localhost:3001", "http://localhost:8080")
                .AllowAnyHeader()
                .WithMethods("GET", "POST", "PUT", "DELETE");
        });
});

//Funcionalidad a los controladores
builder.Services.AddControllers();
//Agrega la funcionalidad para la documentacion de la API
builder.Services.AddSwaggerGen();

//Construye la aplicacion web
var app = builder.Build();

//Mostraremos la documentacion solo en ambiente de desarrollo
if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Se agrega el middleware para el manejo de errores
app.UseExceptionHandler("/error");

//Utiliza rutas oara los endpoints de los controladores
app.UseRouting();

//Utiliza Autenticacion
app.UseAuthorization();
//Utiliza Autorizacion
app.UseAuthorization();
//Agrefa el middleware para refrescar el token
app.UseSlidingExpirationJwt();

//Usa Cors con la policy definida anteriormente
app.UseCors();
//Establece el uso de rutas sin especificaruna por default
app.MapControllers();

app.Run();
