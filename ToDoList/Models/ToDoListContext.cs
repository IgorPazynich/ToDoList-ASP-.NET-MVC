using System;
using System.Data.Entity;


namespace ToDoList.Models
{
    public class ToDoListContext: DbContext
    {
        public DbSet<Goal> Goals { get; set; }
    }
}