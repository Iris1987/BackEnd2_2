using Model;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class DataSensorService : IDatasensorService
    {
        private readonly IDatasensorRepo repository;
        private readonly IControllerSensorRepo repositoryCS;
        private readonly ISensorRepo repositoryS;
        private readonly ITypeValueRepo repositoryTV;

        public DataSensorService(
            IDatasensorRepo repository, 
            IControllerSensorRepo repositoryCS,
            ISensorRepo repositoryS,
            ITypeValueRepo repositoryTV)
        {
            this.repository = repository;
            this.repositoryCS = repositoryCS;
            this.repositoryS = repositoryS;
            this.repositoryTV = repositoryTV;
        }
        

        public Object GetAllDataByRoom()
        {
            var ds = repository.getAll();
            var cs = repositoryCS.getAll();
            var s = repositoryS.getAll();
            var tv = repositoryTV.getAll();


            //var result = ds.Where(x=>x.Controllersensor.Controller.)
            return null;
        }

        public IEnumerable<Datasensor> GetRoomDataByTypeValue()
        {
            return null;//repository.getAll().GroupBy(x=>x.Typevalue.)
        }
    }
}
