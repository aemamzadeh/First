using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_MVC.Models;

namespace Teacher_MVC.Data
{
    public class ProjectsData
    {

        public static List<Project1> GetProjects()
        {

            return new List<Project1>
            {
                new Project1(1, "P1", "NIOC", "description1"),
                new Project1(2, "P2", "NISOC", "description2"),
                new Project1(3, "P3", "NIDC", "description3"),
                new Project1(4, "P4", "NIOPDC", "description4")
            };
        }

        public static Project1 GetProject1By(long id)
        {

            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
