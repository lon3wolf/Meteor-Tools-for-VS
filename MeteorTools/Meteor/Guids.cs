// Guids.cs
// MUST match guids.h
using System;

namespace MeteorTools.Meteor
{
    static class GuidList
    {
        public const string guidMeteorPkgString = "7962dc68-7c89-44ef-aeda-684dd5a0073c";
        public const string guidMeteorCmdSetString = "21d791c3-c697-4f64-95d8-d7f9a75ada29";

        public static readonly Guid guidMeteorCmdSet = new Guid(guidMeteorCmdSetString);
    };
}