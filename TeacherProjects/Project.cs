using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProjects
{
    internal class Project
    {
        public string TeamName { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }

        public Project(string teamName, string desc, string teacher)
        {
            TeamName = teamName;
            Description = desc;
            Teacher = teacher;
        }
    }
}
