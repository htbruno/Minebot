﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Minebot.Packets
{
    class DestroyEnt
    {
        public DestroyEnt(Wrapped.Wrapped socket, Form1 mainform)
        {
            int times = (int)socket.readByte();
            while (times != 0)
            {
                socket.readInt();
                times--;
            }
        }
    }
}
