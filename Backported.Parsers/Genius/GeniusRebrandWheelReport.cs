using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.Genius;

public struct GeniusRebrandWheelReport(byte[] data) : IAuxReport, IRelativeWheelReport, IWheelButtonReport
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
    public bool[] AuxButtons { get; set; } = 
    [
        data[1].IsBitSet(2),
        data[1].IsBitSet(3),
        data[1].IsBitSet(4),
    ];
}
