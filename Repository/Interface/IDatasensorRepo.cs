using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IDatasensorRepo
    {
        Datasensor getById(int id);
        IEnumerable<Datasensor> getAll();
    }
}
