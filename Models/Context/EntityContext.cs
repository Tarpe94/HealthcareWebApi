using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.EntityModels.Appointments;
using Models.EntityModels.Doctors;
using Models.EntityModels.DoctorsTimeOff;
using Models.EntityModels.MedicalRecords;
using Models.EntityModels.Ordinations;
using Models.EntityModels.Permissions;
using Models.EntityModels.RolePermissions;
using Models.EntityModels.Roles;
using Models.EntityModels.Specializations;
using Models.EntityModels.UserRoles;
using Models.EntityModels.Users;
using Models.EntityModels.UserToken;

namespace Models.Context
{
    public class EntityContext(DbContextOptions<EntityContext> options) : DbContext(options)
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorsTimeOff> DoctorTimeOffs { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Ordination> Ordinations { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserToken> UserToken { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityContext).Assembly);
            base.OnModelCreating(modelBuilder);

            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Doctor" },
                new Role { Id = 2, Name = "Patient" }
            );

            // Seed Permissions
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Name = "CanEdit" },
                new Permission { Id = 2, Name = "CanDelete" },
                new Permission { Id = 3, Name = "CanView" }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "doctor",
                    Password = "doctor123",
                    Email = "doctor@example.com",
                    Phone = "1234567890",
                    FirstName = "Doctor",
                    LastName = "Doctor",
                },
                new User
                {
                    Id = 2,
                    Username = "john_doe",
                    Password = "password123",
                    Email = "john.doe@example.com",
                    Phone = "0987654321",
                    FirstName = "John",
                    LastName = "Doe",
                }
            );

            // Seed UserRoles
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { UserId = 1, RoleId = 1 },
                new UserRole { UserId = 2, RoleId = 2 }
            );

            // Seed RolePermissions
            modelBuilder.Entity<RolePermission>().HasData(
                new RolePermission { RoleId = 1, PermissionId = 1 },
                new RolePermission { RoleId = 1, PermissionId = 2 },
                new RolePermission { RoleId = 1, PermissionId = 3 },
                new RolePermission { RoleId = 2, PermissionId = 3 }
            );
        }

    }
}
