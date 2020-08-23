using System;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }
    }
}
