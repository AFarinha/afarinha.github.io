namespace AndreFarinhaPortfolio.Models;

public sealed class ProfileInfo
{
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = [];
    public List<string> AboutParagraphs { get; set; } = [];
    public string AzureHighlight { get; set; } = string.Empty;
}

