using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReport
{
    internal class IndividualProject : Project
    {
        public string Student { get; set; }

        public IndividualProject(string student, string mentor, string name) : base(mentor, name)
        {
            Student = student;
        }

        public override string CreateReport()
        {
            return $"Project name: {Name}{Environment.NewLine}Mentor: {Mentor}{Environment.NewLine}Member: {Student}{Environment.NewLine}";
        }
    }
}
