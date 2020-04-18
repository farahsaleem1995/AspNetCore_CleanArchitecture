using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
  public class DepndencyContainer
  {
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
      // Presentation layer
      services.AddDbContext<UniversityDbContext>(options =>
      {
        options.UseSqlServer(
                  configuration.GetConnectionString("UnversityDBConnection"));
      });

      services.AddDefaultIdentity<IdentityUser>(options =>
      {
        options.SignIn.RequireConfirmedAccount = false;
      })
      .AddEntityFrameworkStores<UniversityDbContext>();

      // Core layer
      services.AddScoped<ICourseService, CourseService>();
      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      // Data layer
      services.AddScoped<ICourseRepository, CourseRepository>();
    }
  }
}
