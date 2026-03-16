using School.Application.Contract;
using School.Application.Core;
using School.Application.Dtos.Department;
using School.Domain.Entities;
using School.Infrastructure.Interfaces;

namespace School.Application.Service
{
    public class DepartmentService : BaseService, IDepartmentService
    {
        private readonly IDepartmentRepository repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            this.repository = repository;
        }

        public ServiceResult GetAll()
        {
            result.Data = repository.GetAll();
            result.Success = true;

            return result;
        }

        public ServiceResult GetById(int id)
        {
            result.Data = repository.GetById(id);
            result.Success = true;

            return result;
        }

        public ServiceResult Save(DepartmentDto dto)
        {
            if (string.IsNullOrEmpty(dto.Name))
            {
                result.Success = false;
                result.Message = "Department name is required";
                return result;
            }

            Department department = new Department();
            department.Name = dto.Name;

            result.Success = true;
            result.Message = "Department created";

            return result;
        }
    }
}