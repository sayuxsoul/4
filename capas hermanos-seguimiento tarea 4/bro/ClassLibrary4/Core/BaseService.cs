using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Core
{
    public class BaseService : IBaseService
    {
        protected ServiceResult result;

        public BaseService()
        {
            result = new ServiceResult();
        }
    }
}