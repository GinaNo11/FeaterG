﻿using System;
using System.Collections.Generic;
using System.Text;
using FeaterG.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FeaterG.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Car> Car { get; set; }
    }
}
