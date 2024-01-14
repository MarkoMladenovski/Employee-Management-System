using AutoMapper;
using EmployeeNamespace.DTOs;
using EmployeeNamespace.Model;

public class MappingProfile : Profiles
{
    public MappingProfile()
    {
              CreateMap<Employee, EmployeeDto>();
        CreateMap<EmployeeDto, Employee>();

                CreateMap<Department, DepartmentDto>();
        CreateMap<DepartmentDto, Department>();

        CreateMap<Project, ProjectDto>();
        CreateMap<ProjectDto, Project>();

        CreateMap<Employee, EmployeeDto>():


            }
}
