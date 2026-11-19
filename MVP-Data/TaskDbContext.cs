using Microsoft.EntityFrameworkCore;
using MVP_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
        public DbSet<TaskItem> TaskItems => Set<TaskItem>();
    }
}
