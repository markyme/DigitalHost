﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHouse.Communication.Protocols
{
    public interface IMessageResponseSender
    {
        void SendMessage(string message);
    }
}
