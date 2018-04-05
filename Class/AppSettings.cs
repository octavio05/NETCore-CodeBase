using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_ProjectBase.Class
{
    public class AppSettings
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public string ConnectionString { get; set; }
    }
}
