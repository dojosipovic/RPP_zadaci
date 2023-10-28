using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReport
{
    internal abstract class Project : IProject
    {
        public string Name { get; set; }
        public string Mentor { get; set; }

        public Project(string mentor, string name)
        {
            Name = name;
            Mentor = mentor;
        }

        public abstract string CreateReport();
    }
}
