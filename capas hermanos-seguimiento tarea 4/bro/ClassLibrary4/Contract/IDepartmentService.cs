using School.Application.Core;
using School.Application.Dtos.Department;

namespace School.Application.Contract
{
    public interface IDepartmentService
    {
        ServiceResult GetAll();

        ServiceResult GetById(int id);

        ServiceResult Save(DepartmentDto dto);
    }
}