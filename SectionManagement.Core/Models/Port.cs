



namespace SectionManagement.Core.Models;

public class Port
{
    public int PortId { get; set; }
    public string Name { get; set; } = string.Empty;

    public IList<SectionSinglePort> SectionSinglePorts { get; set; } = new List<SectionSinglePort>();
}