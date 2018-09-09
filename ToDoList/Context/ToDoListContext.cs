using System.Data.Entity;
using ToDoList.Models;


namespace ToDoList.Context
{
    public class ToDoListContext: DbContext
    {
        public DbSet<Goal> Goals { get; set; }
    }
}