using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Dtos.Course
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Titlle { get; set; }
        
        public int credits { get; set; }
    }
}
