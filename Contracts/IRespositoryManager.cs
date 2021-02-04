using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRespositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }

        Task SaveAsync();
    }
}
