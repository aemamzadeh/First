using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_MVC.Models;

namespace Teacher_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project1>
            {
                new Project1(1,"P1","NIOC","description1"),
                new Project1(2,"P2", "NISOC", "description2"),
                new Project1(3,"P3", "NIDC", "description3"),
                new Project1(4,"P4", "NIOPDC", "description4")
            };
            return View("_Projects",projects);
        }
    }
}
