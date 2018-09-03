using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToDoList.Models
{
    public class ToDoListInitializer : DropCreateDatabaseIfModelChanges<ToDoListContext>
    {
        protected override void Seed(ToDoListContext db)
        {
            db.Goals.Add(new Goal
            {
                Name = "Моя первая задача",
                Note = "Выполнить первую задачу быстро",
                DateTimeToDo = DateTime.ParseExact("05.09.2018 00:00", "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture)
            });
            db.Goals.Add(new Goal
            {
                Name = "Моя вторая задача",
                Note = "Выполнить сразу после первой задачи!",
                DateTimeToDo = DateTime.ParseExact("06.09.2018 00:00", "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture)
            });
        }
    }
}