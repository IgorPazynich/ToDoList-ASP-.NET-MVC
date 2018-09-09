using System.Collections.Generic;
using ToDoList.Context;
using ToDoList.Models;

namespace ToDoList.Logic
{
    static class WorkWithDB
    {
        static ToDoListContext db = new ToDoListContext();

        internal static IEnumerable<Goal> GetGoals()
        {
            return db.Goals;
        }

        internal static Goal FindGoal(int id)
        {
            return db.Goals.Find(id);
        }

        internal static void EditGoal(Goal goalEdited)
        {
            Goal goal = db.Goals.Find(goalEdited.Id);
            goal.Name = goalEdited.Name;
            goal.Note = goalEdited.Note;
            goal.DateTimeToDo = goalEdited.DateTimeToDo;
            db.SaveChanges();
        }

        internal static void AddGoal (Goal goal)
        {
            db.Goals.Add(goal);
            db.SaveChanges();
        }

        internal static void RemoveGoal(int id)
        {
            db.Goals.Remove(db.Goals.Find(id));
            db.SaveChanges();
        }
    }
}