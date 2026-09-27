using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.Genius;

public struct GeniusRebrandWheelReport(byte[] data) : IAbsoluteWheelReport
{
    public byte[] Raw { get; set; } = data;
    public uint?[] AnalogPositions { get; set; } =
    [
        data[7]
    ];
}
