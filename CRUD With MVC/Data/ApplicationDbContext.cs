﻿using CRUD_With_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_With_MVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
