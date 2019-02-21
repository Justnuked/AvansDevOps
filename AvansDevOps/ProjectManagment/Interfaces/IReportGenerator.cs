using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Interfaces
{
    interface IReportGenerator
    {
        void GenerateReport(ISprint sprint);
        void GenerateReport(Project project);
    }
}
