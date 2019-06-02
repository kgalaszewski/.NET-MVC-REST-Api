﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NotDonkeyApp_UG.Data;
using NotDonkeyApp_UG.Models;

namespace GraniteHouse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AnimalNotDonkey> NotDonkeys { get; set; }
        public DbSet<AnimalWikiInformation> AnimalsInformations { get; set; }
    }
}
