﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Minebot.Classes
{
    public class MapBlock
    {
       public int ID;
       public string Name;
       public int x;
       public int y;
       public int z;
       public int cx;
       public int cz;

       public MapBlock(int id, int X, int Y, int Z,int CX, int CZ)
       {
           ID = id;
           x = X;
           y = Y;
           z = Z;
           cx = CX;
           cz = CZ;

           Name = ((C_Minebot.functions.blockitemid)ID).ToString();
       }
      
    }
}
