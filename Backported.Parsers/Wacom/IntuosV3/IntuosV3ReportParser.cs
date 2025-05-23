using OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV3;
using OpenTabletDriver.Plugin.Tablet;

namespace Backported.Parsers.Wacom.IntuosV3
{
    public class IntuosV3ReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] data)
        {
            return data[0] switch
            {
                0x11 => new IntuosV3AuxReport(data),
                0x1E => new IntuosV3ExtendedReport(data),
                0x1F => data[1] == 0x01 ? new IntuosV3Report(data) : new DeviceReport(data),
                _ => new DeviceReport(data)
            };
        }
    }
}