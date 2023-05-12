﻿using project_management_system_backend.Data;
using project_management_system_backend.Models;

namespace project_management_system_backend.Repostories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApiDbContext _context;

        public ProjectRepository(ApiDbContext context)
        {
            _context = context;
        }
        public async Task<List<Project>> GetAllProjects()
        {
            var projectList = _context.projects.ToList();
            return projectList;
        }
        public async Task<Project> GetProjectByID(int id)
        {
            var project = _context.projects.Where(x => x.ProjectId == id).FirstOrDefault();
            return project;
        }
        public async Task<Project> CreatProject(Project project)
        {
            _context.projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public async Task DeleteProject(Project projectToDelete)
        {
            _context.projects.Remove(projectToDelete);
            await _context.SaveChangesAsync();
        }
        public async Task<Project> UpdateProject(Project project)
        {
            var projectToUpdate = GetProjectByID(project.ProjectId).Result;
            projectToUpdate.Name = project.Name;
            projectToUpdate.Key = project.Key;
            projectToUpdate.Description = project.Description;
            projectToUpdate.ClientId = project.ClientId;
            projectToUpdate.ReportedBy = project.ReportedBy;
            projectToUpdate.EstimatedTime = project.EstimatedTime;
            projectToUpdate.StartDate = project.StartDate;
            projectToUpdate.EndDate = project.EndDate;
            projectToUpdate.Budget = project.Budget;
            projectToUpdate.HourlyRate = project.HourlyRate;
            projectToUpdate.Lead = project.Lead;
            projectToUpdate.Status = project.Status;
            projectToUpdate.Updated = DateTime.Now;
            _context.projects.Update(projectToUpdate);
            _context.SaveChanges();
            return project;
        }
    }
}
