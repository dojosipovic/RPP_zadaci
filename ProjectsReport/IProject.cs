using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReport
{
    internal interface IProject
    {
        string Name { get; set; }
        string Mentor { get; set; }

        string CreateReport();
    }
}
