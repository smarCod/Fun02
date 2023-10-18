



namespace SectionManagement.Core.Models;

public enum SectionTyp
{
    Base,
    Room,
    Corridor,
    Stairs
};


public class SectionSingle
{
    public int SectionSingleId { get; set; }
    //public string SectionDesctiption { get; set; } = string.Empty;
    public SectionTyp SectionTyp { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Size { get; set; }
    public string Description { get; set; } = string.Empty;

    public int? SectionId { get; set; }
    public Section Section { get; set; } = new Section();

    public IList<Device> Devices { get; set; } = new List<Device>();

    public IList<SectionSinglePort> SectionSinglePorts { get; set; } = new List<SectionSinglePort>();
}