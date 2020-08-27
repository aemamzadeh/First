using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_MVC.Models
{
    public class Project1
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }


        public Project1(long id, string name, string client, string description)
        {
            Id = id;
            Name = name;
            Client = client;
            Description = description;
        }

    }
}
