using System;
using System.Collections.Generic;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Interface;
using DAL.Models;

namespace BLL.Service
{
    public static class ProjectService
    {
        private static readonly IProjectDbOperation ProjectRepository = DataFactory.ProjectRepository();

        public static bool CreateProject(ProjectDto projectDto) =>
            ProjectRepository.Add(Mapper.Map(projectDto, new Project()));

        public static List<ProjectDto> GetProjects() => Mapper.Map(ProjectRepository.GetAll(), new List<ProjectDto>());

        public static ProjectDto GetProject(int id) => Mapper.Map(ProjectRepository.Get(id), new ProjectDto());

        public static bool DeleteProject(int id) => ProjectRepository.Delete(id);

        public static bool UpdateProject(ProjectDto projectDto) =>
            ProjectRepository.Update(Mapper.Map(projectDto, new Project()));

        public static List<ProjectDto> GetProjectsByStatus(string status) =>
            Mapper.Map(ProjectRepository.GetByStatus(status), new List<ProjectDto>());

        public static List<ProjectDto> GetProjectsByStatusAndDate(string status, DateTime date) =>
            Mapper.Map(ProjectRepository.GetByStatusAndStartDate(status, date), new List<ProjectDto>());
    }
}