using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using restruent2.Models;
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    public static List<MenuItem> menuItems = new List<MenuItem>
    {
         new MenuItem { Id = 1, Name = "Noodles", Description = "Chinese Food", Price = 99M, Category = "Starters", ImageUrl = "~/Content/Images/a1.jpg" },
            new MenuItem { Id = 2, Name = "Briyani", Description = "North Indian", Price = 139M, Category = "Main Course", ImageUrl = "~/Content/Images/a2.jpg" },
            new MenuItem { Id = 3, Name = "Chicken Rice", Description = "South Indian", Price = 199M, Category = "Desserts", ImageUrl = "~/Content/Images/a3.jpg" },
            new MenuItem { Id = 4, Name = "Coffee", Description = "Drink", Price = 79M, Category = "Drinks", ImageUrl = "~/Content/Images/f2.jpg" }
    };


    public ActionResult Menu()
    {
        return View(menuItems);
    }
    //[HttpPost]
    //public ActionResult AddMenuItem(MenuItem newItem)
    //{
    //    newItem.Id = menuItems.Count + 1;
    //    menuItems.Add(newItem);
    //    return RedirectToAction("Menu");
    //}
    //public ActionResult RemoveMenuItem(int id)
    //{
    //    var item = menuItems.FirstOrDefault(x => x.Id == id);
    //    if (item != null)
    //    {
    //        menuItems.Remove(item);
    //    }
    //    return RedirectToAction("Menu");
    //}


    public ActionResult About()
    {
        return View();
    }

    public ActionResult Contact()
    {
        return View();
    }

    public ActionResult Cart()
    {
        return View();
    }
}
