using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsReport
{
    internal class ProjectCatalog
    {
        private List<IProject> projects { get; set; }

        public ProjectCatalog(List<IProject> projects)
        {
            this.projects = projects;
        }

        public string CreateReport()
        {
            string report = $"PROJECTS:{Environment.NewLine}-------------{Environment.NewLine}";
            projects.ForEach(project => report += project.CreateReport() + Environment.NewLine);

            return report;
        }

        public string CreateReport(string mentor)
        {
            string report = $"PROJECTS:{Environment.NewLine}-------------{Environment.NewLine}";
            projects
                .FindAll(x => x.Mentor == mentor)
                .ForEach(project => report += project.CreateReport() + Environment.NewLine);

            return report;
        }

        public List<string> GetMentors()
        {
            return projects.Select(x => x.Mentor)
                .Distinct()
                .ToList();
        }
    }
}
