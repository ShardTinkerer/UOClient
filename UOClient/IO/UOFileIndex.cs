﻿using System;

namespace UOClient.IO
{
    internal record struct UOFileIndex
    {
        public static UOFileIndex Invalid = new(IntPtr.Zero, 0, 0, 0, 0);

        public IntPtr Address;
        public uint FileSize;
        public long Offset;
        public int Length;
        public int DecompressedLength;
        public short Width;
        public short Height;
        public ushort Hue;
        public sbyte AnimOffset;

        public UOFileIndex(IntPtr address, uint fileSize, long offset, int length, int decompressed,
            short width = 0, short height = 0, ushort hue = 0)
        {
            Address = address;
            FileSize = fileSize;
            Offset = offset;
            Length = length;
            DecompressedLength = decompressed;
            Width = width;
            Height = height;
            Hue = hue;

            AnimOffset = 0;
        }
    }

    internal struct UOFileIndex5D
    {
        public uint FileID;
        public uint BlockID;
        public uint Position;
        public uint Length;
        public uint GumpData;

        public UOFileIndex5D(uint file, uint index, uint offset, uint length, uint extra = 0)
        {
            FileID = file;
            BlockID = index;
            Position = offset;
            Length = length;
            GumpData = extra;
        }
    }
}