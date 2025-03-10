﻿using AppRestFul.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRestFul.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }

       
    }
}
