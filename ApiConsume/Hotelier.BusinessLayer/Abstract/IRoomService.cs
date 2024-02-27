﻿using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Abstract
{
    public interface IRoomService:IGenericService<Room>
    {
        int TRoomCount();
    }
}
