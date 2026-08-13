using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.UCLogic
{
    public struct UCLogicV1WheelReport : IRelativeWheelReport
    {
        public UCLogicV1WheelReport(byte[] report)
        {
            Raw = report;
            AnalogDeltas = [
                (sbyte)report[4],
            ];
        }

        public byte[] Raw { set; get; }
        public int[] AnalogDeltas { get; set; }
    }
}