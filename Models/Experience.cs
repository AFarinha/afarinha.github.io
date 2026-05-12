namespace AndreFarinhaPortfolio.Models;

public sealed class Experience
{
    public string Company { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Responsibilities { get; set; } = [];
    public List<string> Technologies { get; set; } = [];
}

