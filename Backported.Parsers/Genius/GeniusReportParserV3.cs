using System.Diagnostics.CodeAnalysis;
using OpenTabletDriver.Configurations.Parsers.Genius;
using OpenTabletDriver.Plugin.Tablet;

namespace Backported.Parsers.Genius
{
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    public class GeniusReportParserV3 : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] data)
        {
            return data[0] switch
            {
                0x02 => new GeniusTabletReport(data),
                0x05 => new GeniusButtonStripAuxReport(data),
                0x0A => new GeniusRebrandWheelReport(data),
                _ => new DeviceReport(data)
            };
        }
    }
}
