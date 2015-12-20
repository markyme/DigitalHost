﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalHouse.Communication.Protocols;

namespace DigitalHouse.Communication.Session
{
    public interface ILogin
    {
        void Login();
        bool IsLoggedIn();
        void Logout();
    }

    public interface IHomeSession
    {
        void Write(string message);
        event NewMessageRecievedEvent OnMessageRecieved;
    }
}
