namespace ETLDaraWarehouse.Entities.DWH;

public class DimSupplier
{
    public int IDSupplier { get; set; }
    public string NameSupplier { get; set; } = string.Empty;
    public string? NameContact { get; set; }
    public string? TitleContact { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? CodePostal { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? PageHome { get; set; }

}
