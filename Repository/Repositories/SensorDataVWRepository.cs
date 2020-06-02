using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class SensorDataVWRepository : ISensorDataVWRepo
    {
        private readonly SensorContext context;
        public SensorDataVWRepository(SensorContext context)
        {
            this.context = context;
        }
        public IEnumerable<SensordataVW> getAll()
        {
            return context.SensorDataVWs.ToList();
        }

        public SensordataVW getById(int id)
        {
            return context.SensorDataVWs.Find(id);
        }
    }
}
