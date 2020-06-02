using Model;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ControllerTest:IControllerTest
    {
        private readonly IControllerRepo rep;

        public ControllerTest(IControllerRepo rep)
        {
            this.rep = rep;
        }
        public IList<ControllerClass> GetS()
        {
            return rep.getAll();
        }

      
    }
}
