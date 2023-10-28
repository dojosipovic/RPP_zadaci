using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherProjects
{
    internal static class ProjectReporter
    {
        public static string GenerateReport(string teacher)
        {
            ProjectCatalog catalog = new ProjectCatalog();
            var projects = catalog.GetProjects(teacher);

            return PrepareReport(teacher, projects);
        }

        private static string PrepareReport(string teacher, List<Project> projects)
        {
            string report = $"Projects for teacher {teacher}:{Environment.NewLine}============{Environment.NewLine}";
            projects.ForEach(x => report += $"{x.TeamName} - {x.Description}{Environment.NewLine}");

            return report;
        }
    }
}
