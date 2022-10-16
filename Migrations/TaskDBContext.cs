using Microsoft.EntityFrameworkCore;

namespace task_api.Migrations;

public class TaskDbContext: DbContext {
    public DbSet<Task> Task { get; set; }

    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base (options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Task>(entity => 
        {
            entity.HasKey(e => e.TaskId);
            entity.Property(e => e.Title);
            entity.Property(e => e.Completed);
        });
    }
}