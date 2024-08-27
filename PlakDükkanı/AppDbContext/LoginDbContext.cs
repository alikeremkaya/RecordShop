using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PlakDükkanı.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanı.AppDbContext
{
    

    public class LoginDbContext:DbContext
    {

        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=DESKTOP-V1THAGN\\SQLEXPRESS; Database=DedeminPlaklari1;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }








        public override int SaveChanges()
        {

            SetBaseProperties();
            return base.SaveChanges();
        }

        private void SetBaseProperties()
        {
            // O anda işlemi yapılan entryleri izle bana dön
            var entries = ChangeTracker.Entries<BaseEntity>();
            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);
            }
        }
        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Deleted)
            {
                //Veri tabanına silme işlemi olarak gidiyordu, bunu modified çevirdik veri tabanında komple uçmadı.
                entry.State = EntityState.Modified;
                entry.Entity.Status = Enum.Status.Silindi;
                entry.Entity.SilmeTarihi = DateTime.Now;

            }
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = Enum.Status.Degistirildi;
                entry.Entity.DegisimTarihi = DateTime.Now;

            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = Enum.Status.Eklendi;
                entry.Entity.OlusturmaTarihi = DateTime.Now;

            }
        }
    }

}
