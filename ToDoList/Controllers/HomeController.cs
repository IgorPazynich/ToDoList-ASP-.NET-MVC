using System.Web.Mvc;
using ToDoList.Logic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Goals = WorkWithDB.GetGoals();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Goal = WorkWithDB.FindGoal(id);
            ViewBag.Title = "Редактирование задачи";
            return View("GoalView");
        }

        [HttpPost]
        public ActionResult Edit(Goal goalEdited)
        {
            WorkWithDB.EditGoal(goalEdited);
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Goal = new Goal();
            ViewBag.Title = "Добавление задачи";
            return View("GoalView");
        }

        [HttpPost]
        public ActionResult Add(Goal goal)
        {
            WorkWithDB.AddGoal(goal);
            return Redirect("/");
        }

        public ActionResult Remove(int id)
        {
            WorkWithDB.RemoveGoal(id);
            return Redirect("/");
        }
    }
}