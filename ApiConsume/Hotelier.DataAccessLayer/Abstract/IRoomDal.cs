﻿using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IRoomDal:IGenericDal<Room>
    {
        int RoomCount();
    }
}
