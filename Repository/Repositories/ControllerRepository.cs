using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ControllerRepository : IControllerRepo
    {
        private readonly SensorContext context;

        public ControllerRepository(SensorContext context)
        {
            this.context = context;
        }
        public IList<ControllerClass> getAll()
        {
            return context.Controllers.ToList();
        }

        public ControllerClass getById(int id)
        {
            return context.Controllers.Find(id);
        }
    }
}
