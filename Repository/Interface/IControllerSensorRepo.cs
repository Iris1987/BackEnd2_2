using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IControllerSensorRepo
    {
        ControllerSensor getById(int id);
        IEnumerable<ControllerSensor> getAll();
    }
}
