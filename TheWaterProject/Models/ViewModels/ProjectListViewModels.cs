namespace TheWaterProject.Models.ViewModels
{
    public class ProjectListViewModels
    {
        public IQueryable<Project> Projects { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

    }
}
