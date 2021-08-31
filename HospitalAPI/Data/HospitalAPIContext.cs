using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalAPI.Models;

namespace HospitalAPI.Data
{
    public class HospitalAPIContext : DbContext
    {
        public HospitalAPIContext (DbContextOptions<HospitalAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalAPI.Models.Staff> Staff { get; set; }

        public DbSet<HospitalAPI.Models.Message> Message { get; set; }
    }
}
