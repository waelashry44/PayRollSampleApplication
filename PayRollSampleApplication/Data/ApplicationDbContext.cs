using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PayRollSampleApplication.Entities.Configuration;
using PayRollSampleApplication.Entities.Models;

namespace PayRollSampleApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DependentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeAttachmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new JobPositionConfiguration());
            modelBuilder.ApplyConfiguration(new JobStatusConfiguration());
            modelBuilder.ApplyConfiguration(new NationalityConfiguration());
            modelBuilder.ApplyConfiguration(new RelationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SalaryDetailConfiguration());

            modelBuilder.HasSequence<int>("EmployeeId")
            .StartsAt(1000)
            .IncrementsBy(1);
            modelBuilder.Entity<Employee>()
                        .Property(o => o.EmployeeId)
                        .UseHiLo("EmployeeId");
        }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAttachment> EmployeeAttachments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<RelationType> RelationTypes { get; set; }
        public DbSet<SalaryDetail> SalaryDetails { get; set; }
        public DbSet<PaySlipDetail> PaySlipDetails  { get; set; }
    }
}