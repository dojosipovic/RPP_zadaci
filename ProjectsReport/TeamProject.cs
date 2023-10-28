using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReport
{
    internal class TeamProject : Project
    {
        public List<string> TeamMembers { get; set; }

        public TeamProject(string mentor, string name, List<string> members) : base(mentor, name)
        {
            TeamMembers = members;
        }

        public override string CreateReport()
        {
            string report = $"Project name: {Name}{Environment.NewLine}Mentor: {Mentor}{Environment.NewLine}Team members:{Environment.NewLine}";
            TeamMembers.ForEach(x => report += $"- {x}{Environment.NewLine}");

            return report;
        }
    }
}
