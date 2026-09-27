using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.Genius;

public struct GeniusRebrandWheelReport(byte[] data) : IAbsoluteWheelReport, IWheelButtonReport
{
    public byte[] Raw { get; set; } = data;
    public uint?[] AnalogPositions { get; set; } =
    [
        data[7]
    ];
    public bool[][] WheelButtons { get; set; } = 
    [
        [
            data[3] == 0x01
        ]
    ];
}
