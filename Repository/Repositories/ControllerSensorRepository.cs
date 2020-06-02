using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    /// <summary>
    /// Generic repository class inheriting generic interface IGetInterface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ControllerSensorRepository : IControllerSensorRepo
    {
        private readonly SensorContext context;


        public ControllerSensorRepository(SensorContext context)
        {
            this.context = context;

        }

        public IEnumerable<ControllerSensor> getAll()
        {
            return context.ControllerSensors.ToList();

        }

        public ControllerSensor getById(int id)
        {
            return context.ControllerSensors.Find(id);
        }

        //AsNoTracking not used within methods that are manipulating essences (create, delete..) and have SaveChanges() method



        //get with include - used usually with generic classes
        //v1
        //public IEnumerable<ControllerSensor> GetWithInclude(params Expression<Func<ControllerSensor, object>>[] includeProperties)
        //{
        //    return Include(includeProperties).ToList();
        //}
        ////v2 
        //public IEnumerable<ControllerSensor> GetWithInclude(Func<ControllerSensor, bool> predicate, params Expression<Func<ControllerSensor, object>>[] includeProperties)
        //{
        //    var query = Include(includeProperties);
        //    return query.Where(predicate).ToList();
        //}

        ////auxillary method
        //private IQueryable<ControllerSensor> Include(params Expression<Func<ControllerSensor, object>>[] includeProperties)
        //{
        //    IQueryable<ControllerSensor> query = dbSet.AsNoTracking();
        //    return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        //}


    }
}
