using Microsoft.EntityFrameworkCore;
using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Context
{
    internal class FileEntityContext : DbContext
    {
        public DbSet<FileEntity> FileEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=FileApplication;Trusted_Connection=True;");
    }
}
