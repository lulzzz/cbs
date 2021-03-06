using Dolittle.Events.Processing;
using Events.External;
namespace Read.Projects
{
    public class ProjectsEventProcessor : ICanProcessEvents
    {
        private IProjects _projects;

        public ProjectsEventProcessor(IProjects projects)
        {
            _projects = projects;
        }
        public void Process(ProjectCreated projectCreated)
        {
            _projects.Save(new Project()
            {
                Id = projectCreated.Id,
                Name = projectCreated.Name
            });
        }

        public void Process(ProjectUpdated projectUpdated)
        {
            var project = _projects.GetById(projectUpdated.Id);
            project.Name = projectUpdated.Name;
            _projects.Save(project);
        }
    }
}
