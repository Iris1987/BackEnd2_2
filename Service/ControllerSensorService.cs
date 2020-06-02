using Model;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ControllerSensorService : IControllerSensorService
    {
        private readonly IControllerSensorRepo repository;
       // private readonly IControllerRepo repositoryC;
        private readonly ISensorRepo repositoryS;

        public ControllerSensorService(IControllerSensorRepo repository,/* IControllerRepo repositoryC,*/ ISensorRepo repositoryS)
        {
            this.repository = repository;
           // this.repositoryC = repositoryC;
            this.repositoryS = repositoryS;
        }
        public Object GetControllerSensorStateByRoom(string room)
        {
            //var controller = repositoryC.getAll();
            var sensor = repositoryS.getAll();

            var result = repository.getAll().Where(x => x.Room == room).Select(s => new
            {
                room = s.Room,
                sensorName = s.Sensors.Sensorname,
                mac = s.Sensors.Mac,
               // controllerName = s.Controller.Controllername,
                dateInstall = s.DateInstall,
                state = s.State
            }).FirstOrDefault();

            return result;
        }
    }
}
