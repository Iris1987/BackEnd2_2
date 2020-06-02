using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IControllerRepo
    {
        ControllerClass getById(int id);
        IList<ControllerClass> getAll();
    }
}
