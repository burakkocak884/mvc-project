using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic; 
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.AspNetCore.Identity.UI;



namespace mvc_project.Models
{
    public class MainDBContext : DbContext 
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options) {} 
        public DbSet<User> Users { get; set; } 
        public DbSet<Car> Cars { get; set; } 
        public DbSet<ServiceRecord> ServiceRecords { get; set; } 
        public DbSet<ServiceRecordHistory> ServiceRecordsHistory { get; set; }
    }
}