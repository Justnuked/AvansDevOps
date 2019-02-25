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
        public enum PipeLineType{
            RELEASE, DEVELOPMENT
        };
        private List<IPipeLineModule> modules;
        private string name;
        private PipeLineType type;
        private IPipeLineModule failedModule;

        public Pipeline(string name, PipeLineType type)
        {
            modules = new List<IPipeLineModule>();
            this.name = name;
            this.type = type;
        }

        public void AddModule(IPipeLineModule module)
        {
            modules.Add(module);
        }

        public PipeLineType GetPipeLineType()
        {
            return this.type;
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

        public IPipeLineModule GetFailedModule()
        {
            return this.failedModule;
        }

        public void Execute()
        {
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
                Notify("Pipeline completed with success", true);
            }
            else
            {
                Notify("Module " + failedModule.ToString() + " has failed", false);
            }
        }
    }
}
