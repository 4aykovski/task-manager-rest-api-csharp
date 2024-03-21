using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository.Entity;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }
    public DbSet<RefreshSession> RefreshSessions { get; set; }
    public DbSet<PrivateBoard> PrivateBoards { get; set; }
    public DbSet<PrivateCategory> PrivateCategories { get; set; }
    public DbSet<PrivateTask> PrivateTasks { get; set; }
    public DbSet<ProjectBoard> ProjectBoards { get; set; }
    public DbSet<ProjectCategory> ProjectCategories { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // pk for projectMembers table
        modelBuilder.Entity<ProjectMember>()
            .HasKey(pm => new { pm.ProjectId, pm.UserId });

        // many to many relation between projects and users
        modelBuilder.Entity<ProjectMember>()
            .HasOne(pm => pm.User)
            .WithMany(u => u.ProjectsMember)
            .HasForeignKey(pm => pm.UserId);
        modelBuilder.Entity<ProjectMember>()
            .HasOne(pm => pm.Project)
            .WithMany(p => p.Members)
            .HasForeignKey(pm => pm.ProjectId);
    }
}