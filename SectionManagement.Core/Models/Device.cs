

namespace SectionManagement.Core.Models;


public class Device
{
    public int DeviceId { get; set; }
    public string Name { get; set; } = string.Empty;

    public int? SectionSingleId { get; set; }
    public SectionSingle SectionSingle { get; set; } = new SectionSingle();

}