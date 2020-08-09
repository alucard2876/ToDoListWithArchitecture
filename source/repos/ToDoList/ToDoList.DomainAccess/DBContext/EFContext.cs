using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.DomainAccess.DBContext
{
    public class EFContext : DbContext
    { 
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
    }
}
