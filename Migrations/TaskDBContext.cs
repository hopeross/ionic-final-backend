using Microsoft.EntityFrameworkCore;
using task_api.Models;

namespace task_api.Migrations;

public class TaskDbContext: DbContext {
    public DbSet<Tasks> Tasks { get; set; }

    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base (options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tasks>(entity => 
        {
            entity.HasKey(e => e.TaskId);
            entity.Property(e => e.Title);
            entity.Property(e => e.Completed);
        });
    }
}