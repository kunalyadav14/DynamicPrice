using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DynamicPrice.Models;

namespace DynamicPrice.Data
{
    public partial class DynamicPriceContext : DbContext
    {
        public DynamicPriceContext()
        {
            
        }

        public DynamicPriceContext(DbContextOptions<DynamicPriceContext> options)
            : base(options)
        {
        }

        public   virtual DbSet<CexDatum> CexData { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=INSUPLTDVKY\\SQLEXPRESS;initial catalog=DynamicPrice;user=sa; password='12345678'; trusted_connection=yes;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
          
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
