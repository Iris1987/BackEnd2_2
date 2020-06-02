using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface ISensorDataVWRepo
    {
        SensordataVW getById(int id);
        IEnumerable<SensordataVW> getAll();
    }
}
