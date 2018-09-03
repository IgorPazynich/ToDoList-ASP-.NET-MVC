using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Goal
    {
        // ID задачи
        public int Id { get; set; }
        // Название задачи
        public string Name { get; set; }
        // Описание задачи
        public string Note { get; set; }
        // Время выполнения задачи
        public DateTime? DateTimeToDo { get; set; }
    }
}