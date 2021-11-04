using System.Numerics;
using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Tablet;

namespace OpenTabletDriver.Vendors.Acepen
{
    public struct AcepenAuxReport : IAuxReport
    {
        public AcepenAuxReport(byte[] report, bool[] auxState)
        {
            Raw = report;

            auxState[BitOperations.Log2(report[4])] = report[3].IsBitSet(0);
            AuxButtons = auxState;
        }

        public bool[] AuxButtons { set; get; }
        public byte[] Raw { set; get; }
    }
}