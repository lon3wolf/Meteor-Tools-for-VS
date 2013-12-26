// Guids.cs
// MUST match guids.h
using System;

namespace MeteorTools.MeteorTools
{
    static class GuidList
    {
        public const string guidMeteorToolsPkgString = "e38885f5-7924-450c-bc93-945cc407115a";
        public const string guidMeteorToolsCmdSetString = "f40f4259-ec15-4bf8-bedf-7b86eaadf1f3";

        public static readonly Guid guidMeteorToolsCmdSet = new Guid(guidMeteorToolsCmdSetString);
    };
}