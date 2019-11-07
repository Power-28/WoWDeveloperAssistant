﻿namespace WoWDeveloperAssistant.DBC.Structures
{
    public sealed class CriteriaTreeEntry
    {
        public uint ID;
        public string Description;
        public uint Parent;
        public uint Amount;
        public sbyte Operator;
        public uint CriteriaID;
        public int OrderIndex;
        public short Flags;
    }
}