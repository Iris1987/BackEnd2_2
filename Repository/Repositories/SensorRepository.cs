using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class SensorRepository : ISensorRepo
    {
        private readonly SensorContext context;
        public SensorRepository(SensorContext context)
        {
            this.context = context;
        }
        public IEnumerable<Sensor> getAll()
        {
            return context.Sensors.ToList();
        }

        public Sensor getById(int id)
        {
            return context.Sensors.Find(id);
        }
    }
}
