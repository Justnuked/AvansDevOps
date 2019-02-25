using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeLine.Interfaces;
using Utilities.Observable;

namespace PipeLine.Classes
{
    public class Pipeline : Observable
    {
        private List<IPipeLineModule> modules;
        string name;

        public Pipeline(string name)
        {
            modules = new List<IPipeLineModule>();
            this.name = name;
        }

        public void AddModule(IPipeLineModule module)
        {
            modules.Add(module);
        }

        public void RemoveModule(IPipeLineModule module)
        {
            if(modules.Contains(module)){
                modules.Remove(module);
            }
        }

        public List<IPipeLineModule> GetAllModules()
        {
            return modules;
        }

        public void Execute()
        {
            IPipeLineModule failedModule = null;

            foreach(IPipeLineModule m in modules){
                m.Execute();
                if (m.GetStatus() == Status.FAILED)
                {
                    failedModule = m;
                    break;
                }
            }

            if (failedModule == null)
            {
                Notify("Pipeline completed with succes");
            }
            else
            {
                Notify("Module " + failedModule.ToString() + " has failed");
            }
        }


    }
}
