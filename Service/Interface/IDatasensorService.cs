﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IDatasensorService
    {
        Object GetAllDataByRoom();
        IEnumerable<Datasensor> GetRoomDataByTypeValue();
       

    }
}
