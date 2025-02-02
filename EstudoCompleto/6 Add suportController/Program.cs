using System.Text;
using Blog;
using Blog.Data;
using Blog.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
// builder.Services.AddAuthentication(x =>
// {
//     x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
// }).AddJwtBearer(x =>
// {
//     x.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuerSigningKey = true,
//         IssuerSigningKey = new SymmetricSecurityKey(key),
//         ValidateIssuer = false,
//         ValidateAudience = false
//     };
// });

// builder
//     .Services
//     .AddControllers()
//     .ConfigureApiBehaviorOptions(options =>
//     {
//         options.SuppressModelStateInvalidFilter = true;
//     });
1 builder.Services.AddDbContext<BlogDataContext>();

// builder.Services.AddTransient<TokenService>();

2 var app = builder.Build();

// app.UseAuthentication();
// app.UseAuthorization();

3 app.MapControllers();

4 app.Run();