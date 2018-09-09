using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Goal
    {
        // ID задачи
        public int Id { get; set; }
        // Название задачи
        [Required]
        public string Name { get; set; }
        // Описание задачи
        public string Note { get; set; }
        // Время выполнения задачи
        public DateTime? DateTimeToDo { get; set; }
    }
}