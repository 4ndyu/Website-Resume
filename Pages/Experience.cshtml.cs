using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace ResumeWebsite.Pages
{
    public class Experience
    {
        public string JobStatus { get; set; }
        public string Industry { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public List<string> Projects { get; set; }

        public Experience(string jobStatus, string industry, string position, string company, DateTime startDate, DateTime endDate, string description)
        {
            
            JobStatus = jobStatus;
            Industry = industry;
            Position = position;
            Company = company;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            Projects = new List<string> ();
        }
    }
    
    public class ExperienceModel : PageModel
    {
        public List<Experience> experiences = new List<Experience>();

        public void OnGet()
        {
            experiences.Add(
                new Experience
                (
                    "Full-Time",
                    "Information Technologies and Communication",
                    "Software Engineer",
                    "Immersive Technologies",
                    new DateTime(2022, 5, 1),
                    new DateTime(2022, 12, 15),
                    "My responsibility was to troubleshoot raised bugs and implement a working fix to the issue\r\n        without introducing new bugs. Develop and complete a thorough unit test and test plans for\r\n        implemented changes, with documentation to help my fellow co-workers understand what the\r\n        changes are. While also, following the company�s programming standards. During projects, I\r\n        would communicate and contribute my design to the team and discuss a better solution to\r\n        implement."
                )
            );
            experiences.Add(
                new Experience
                (
                    "Volunteer",
                    "Information Technologies and Communication",
                    "Front-End Developer",
                    "Obsi PTY LTD",
                    new DateTime(2021, 11, 1),
                    new DateTime(2022, 04, 1),
                    "The project is a website that allows a service care business to manage its customers and\r\n        employees. The main feature enables the employee to be called in for work on short notice. The\r\n        website should display their availability and provide the customer details and needs.\r\n        My task has been adding missing features and functionality, such as creating the Rate Page for\r\n        the customer, which should display the rates details the hired staff will be getting per hour."
                )
            );
        }
    }
}