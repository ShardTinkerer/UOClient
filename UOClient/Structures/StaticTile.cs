﻿using System.Runtime.InteropServices;

namespace UOClient.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct StaticTile
    {
        public ushort Id;
        public ushort Color;
        public sbyte Z;
    }
}
