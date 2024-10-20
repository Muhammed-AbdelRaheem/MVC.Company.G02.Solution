﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Interfaces
{
    public interface IUnitOfwork
    {
        public IDepartmentRepository DepartmentRepository { get; }
        public IEmployeeRepository EmployeeRepository { get; }

        Task<int> SaveChangeAsync();
    }
}
