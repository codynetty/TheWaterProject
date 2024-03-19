using System.ComponentModel.DataAnnotations;

namespace TheWaterProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = "N/a";
        public string ProgramName { get; set; }
        public string ProjectType { get; set; }
        public int ProjectImpact { get; set; }
        public DateTime ProjectInstallation { get; set; }
        public string ProjectPhase { get; set; }

    }
}
