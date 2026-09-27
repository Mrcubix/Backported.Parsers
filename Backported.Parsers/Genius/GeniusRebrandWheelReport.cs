using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Plugin.Tablet.Wheel;

namespace Backported.Parsers.Genius;

public struct GeniusRebrandWheelReport(byte[] data) : IAuxReport, IRelativeWheelReport, IWheelButtonReport
{
    public byte[] Raw { get; set; } = data;
    public bool[] AuxButtons { get; set; } = 
    [
        data[1].IsBitSet(2),
        data[1].IsBitSet(3),
        data[1].IsBitSet(4),
    ];
    public int[] AnalogDeltas { get; set; } = 
    [
        (sbyte)data[2]
    ];
    public bool[][] WheelButtons { get; set; } = 
    [
        [
            data[3] == 0x01
        ]
    ];
}
