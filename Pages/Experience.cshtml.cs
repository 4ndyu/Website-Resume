using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;
using static ResumeWebsite.Pages.Experience;

namespace ResumeWebsite.Pages
{
    public class Experience
    {
        public enum JobType
        {
            FullTime = 0,
            PartTime = 1,
            Casual = 2,
            Volunteer = 3,
            WorkExperience = 4
        }

        public enum IndustryType
        {
            Construction = 0,
            CustomerService = 1,
            InformationTech = 2,
            Gift = 3
        }

        public JobType JobStatus { get; set; }
        public IndustryType Industry { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public List<string> Projects { get; set; }

        public Experience(JobType jobStatus, IndustryType industry, string position, string company, DateTime startDate, DateTime endDate, string description)
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

        public string JobTypeToString()
        {
            string typeStr;

            switch (this.JobStatus)
            {
                case JobType.FullTime:
                    typeStr = "Full-Time";
                    break;
                case JobType.PartTime:
                    typeStr = "Part-Time";
                    break;
                case JobType.Casual:
                    typeStr = "Casual";
                    break;
                case JobType.Volunteer:
                    typeStr = "Volunteer";
                    break;
                default:
                    typeStr = "Work Experience";
                    break;
            }

            return typeStr;
        }

        public string IndustryTypeToString()
        {
            string typeStr;

            switch (this.Industry)
            {
                case IndustryType.InformationTech:
                    typeStr = "Information Technology and Communications";
                    break;
                case IndustryType.Construction:
                    typeStr = "Construction";
                    break;
                case IndustryType.Gift:
                    typeStr = "Gift";
                    break;
                default:
                    typeStr = "Customer Service";
                    break;
            }

            return typeStr;
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
                    JobType.FullTime,
                    IndustryType.InformationTech,
                    "Software Engineer",
                    "Immersive Technologies",
                    new DateTime(2022, 5, 1),
                    new DateTime(2022, 12, 15),
                    "My responsibility was to troubleshoot raised bugs and implement a working fix to the issue\r\n        without introducing new bugs. Develop and complete a thorough unit test and test plans for\r\n        implemented changes, with documentation to help my fellow co-workers understand what the\r\n        changes are. While also, following the company’s programming standards. During projects, I\r\n        would communicate and contribute my design to the team and discuss a better solution to\r\n        implement."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Resolving reported bugs.");
            experiences[experiences.Count - 1].Projects.Add("Adding new features to an internal tool.");
            experiences[experiences.Count - 1].Projects.Add("Creating a new internal tool to monitor a projectors health.");
            
            experiences.Add(
                new Experience
                (
                    JobType.Volunteer,
                    IndustryType.InformationTech,
                    "Front-End Developer",
                    "Obsi PTY LTD",
                    new DateTime(2021, 11, 1),
                    new DateTime(2022, 04, 1),
                    "The project is a website that allows a service care business to manage its customers and\r\n        employees. The main feature enables the employee to be called in for work on short notice. The\r\n        website should display their availability and provide the customer details and needs.\r\n        My task has been adding missing features and functionality, such as creating the Rate Page for\r\n        the customer, which should display the rates details the hired staff will be getting per hour."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Adding missing or improving features to the Website pages");
            experiences[experiences.Count - 1].Projects.Add("Adding missing or improving features to the accompany Mobile application");

            experiences.Add(
                new Experience
                (
                    JobType.PartTime,
                    IndustryType.CustomerService,
                    "TCU Buddies",
                    "Murdoch University",
                    new DateTime(2020, 02, 1),
                    new DateTime(2020, 06, 1),
                    "I acted as a guide and aided a group of foreign exchange student from Japan in adapting in Australia.\r\nMy duties was to communicate with the students and organize activities."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Guiding the exchange students around Murdoch and Perth");
            experiences[experiences.Count - 1].Projects.Add("Weekly meet ups");


            experiences.Add(
                new Experience
                (
                    JobType.Volunteer,
                    IndustryType.CustomerService,
                    "Open Day Welcomer",
                    "Murdoch University",
                    new DateTime(2019, 07, 28),
                    new DateTime(2019, 07, 28),
                    "Welcome visitors to Murdoch University and direct them to the location they are interested in, while giving them pamphlets."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Welcoming Visitors");

            experiences.Add(
                new Experience
                (
                    JobType.Volunteer,
                    IndustryType.Gift,
                    "Open Day Gift Packager",
                    "Murdoch University",
                    new DateTime(2019, 07, 19),
                    new DateTime(2019, 07, 19),
                    "To help organise and package the Open Day Gift bags."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Packaging gift bags");

            experiences.Add(
                new Experience
                (
                    JobType.WorkExperience,
                    IndustryType.Construction,
                    "Construction Trainee",
                    "Ertech",
                    new DateTime(2016, 01, 1),
                    new DateTime(2017, 12, 1),
                    "Training to gain skills that will be helpful to work as a construction worker."
                )
            );
            experiences[experiences.Count - 1].Projects.Add("Laying PCV piping into the ground.");
            experiences[experiences.Count - 1].Projects.Add("Laying concrete piping into the ground.");
            experiences[experiences.Count - 1].Projects.Add("Learning to operate construction machine.");
        }
    }
}
