



namespace SectionManagement.Core.Models;

public class Section
{
    public int SectionId { get; set; }
    public string Name { get; set; } = string.Empty;

    public IList<SectionSingle> SectionSingles { get; set; } = new List<SectionSingle>();
}