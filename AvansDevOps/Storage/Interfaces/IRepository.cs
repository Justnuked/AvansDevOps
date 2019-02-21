using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Interfaces
{
    interface IRepository<Entity> where Entity : class
    {
        void Save(Entity e);
        void Delete(Entity e);
        void Update(int id, Entity newE);
        List<Entity> GetAll();
        Entity GetById();

    }
}
