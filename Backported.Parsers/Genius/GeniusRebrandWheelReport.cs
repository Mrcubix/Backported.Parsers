using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.Genius;

public struct GeniusRebrandWheelReport(byte[] data) : IRelativeWheelReport, IWheelButtonReport
{
    public byte[] Raw { get; set; } = data;
    public int[] AnalogDeltas { get; set; } = 
    [
        data[2] == 0x01 ? 1 : data[2] == 0xFF ? -1 : 0
    ];
    public bool[][] WheelButtons { get; set; } = 
    [
        [
            data[3] == 0x01
        ]
    ];
}
