namespace PortfolioAPI.Models
{
    public class CV
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Objective { get; set; }
        public List<Education> Education { get; set; }
        public List<Experience> Experience { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string School { get; set; }
        public string Duration { get; set; }
    }

    public class Experience
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string Repository { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public string Proficiency { get; set; }
    }
}
