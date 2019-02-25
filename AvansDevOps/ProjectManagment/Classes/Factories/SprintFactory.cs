using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Classes.Factories
{
    class SprintFactory
    {
        public Sprint CreateSprint(string type, DateTime start, DateTime end)
        {
            switch (type)
            {
                case "product":
                    return new ProductSprint(start, end);

                case "release":
                    return new ReleaseSprint(start, end);

                default:
                    // error logic
                    return null;
            }
        }
    }
}
