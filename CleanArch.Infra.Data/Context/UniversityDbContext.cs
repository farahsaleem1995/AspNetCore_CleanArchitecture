using CleanArch.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : IdentityDbContext
    {
        public DbSet<Course> Courses{ get; set; }

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
            : base(options)
        {

        }
    }
}
