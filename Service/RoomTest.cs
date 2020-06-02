using Model;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class RoomTest: IRoom //: IGetService<Datasensor>
    {
        //private readonly IGetInterface<Datasensor> repository;
        private readonly IDatasensorRepo repository;

        public RoomTest(/*IGetInterface<Datasensor> repository*/ IDatasensorRepo repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Datasensor> GetDS()
        {
            return repository.getAll();
        }

        public IEnumerable<Datasensor> GetAllByRoom(string room)
        {
            return null;//repository.getAll().Where(x => x.IdControllersensorNavigation.Room == room);
        }

     
    }
}
