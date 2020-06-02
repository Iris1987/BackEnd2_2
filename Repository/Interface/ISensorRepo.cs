﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface ISensorRepo
    {
        Sensor getById(int id);
        IEnumerable<Sensor> getAll();
    }
}
