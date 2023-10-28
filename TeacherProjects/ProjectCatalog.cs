using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProjects
{
    internal class ProjectCatalog
    {
        private List<Project> _projects { get; set; }

        public ProjectCatalog()
        {
            _projects = new List<Project>()
            {
                new Project("T01", "Library.NET", "Marko Mijač"),
                new Project("T02", "Warehouse.NET", "Marko Mijač")
            };
        }

        public List<Project> GetProjects(string teacher)
        {
            return _projects.FindAll(x => x.Teacher == teacher);
        }
    }
}
