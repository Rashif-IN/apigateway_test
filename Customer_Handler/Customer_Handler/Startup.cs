using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using cqrs_Test.Application.Interfaces;
using cqrs_Test.Application.UseCase.Customer.Command.PostCustomer;
using cqrs_Test.Application.UseCase.Customer.Queries.GetCustomer;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Customer_Handler
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<IContext>(option => option.UseNpgsql("Host=localhost;Database=microservice1customer;Username=postgres;Password=docker;"));
            services.AddMvc().AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblyContaining(typeof(PostCustomerCommandValidation)));
            services.AddMediatR(typeof(GetCustomerQueryHandler).GetTypeInfo().Assembly);

            //services.AddAuthentication(options => {
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(option => {
            //    option.SaveToken = false;
            //    option.RequireHttpsMetadata = false;
            //    option.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("ini secret key nya harus panjang gaboleh pendek")),
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //    };
            //});

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidator<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
