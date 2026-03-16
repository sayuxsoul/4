using School.Domain.Core;
using System;

namespace School.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public decimal Budget { get; set; }
    }
}



