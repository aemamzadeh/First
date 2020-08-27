using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Teacher_MVC.Data;
using Teacher_MVC.Models;

namespace Teacher_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = ProjectsData.GetProjects();
            return View("_Projects",projects);
        }
    }
}
