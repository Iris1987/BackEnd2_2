using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Repository.Repositories
{
    public class DataSensorRepository:IDatasensorRepo 
    {
        private readonly SensorContext context;
        public DataSensorRepository(SensorContext context)
        {
            this.context = context;
        }
        public IEnumerable<Datasensor> getAll()
        {
         

            return context.DataSensors.ToList();
        }

        public Datasensor getById(int id)
        {
            return context.DataSensors.Find(id);
        }
    }
}