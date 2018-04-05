using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_ProjectBase.Interfaces
{
    public interface IDataAccess
    {
        string GetConnectionString();
    }
}
