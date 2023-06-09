﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_CFA.Entities;

namespace Assignment_CFA.Data
{
    public class Assignment_CFAContext : DbContext
    {
        public Assignment_CFAContext (DbContextOptions<Assignment_CFAContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment_CFA.Entities.Student> Student { get; set; } = default!;
    }
}
