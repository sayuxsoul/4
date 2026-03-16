using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Core;
using School.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SchoolContext context) : base(context)
        {
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public  Department GetById(int id)
        {
            return _context.Departments.Find(id);
        }
    }
}