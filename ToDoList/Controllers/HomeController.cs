using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        ToDoListContext db = new ToDoListContext();

        public ActionResult Index()
        {
            IEnumerable<Goal> goals = db.Goals;
            ViewBag.Goals = goals;
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Goal = db.Goals.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Goal goalEdited)
        {
            Goal goal = db.Goals.Find(goalEdited.Id);
            goal.Name = goalEdited.Name;
            goal.Note = goalEdited.Note;
            goal.DateTimeToDo = goalEdited.DateTimeToDo;
            db.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Goal goal)
        {
            db.Goals.Add(goal);
            db.SaveChanges();
            return Redirect("/");
        }

        public ActionResult Remove(int id)
        {
            db.Goals.Remove(db.Goals.Find(id));
            db.SaveChanges();
            return Redirect("/");
        }
    }
}