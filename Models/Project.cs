namespace AndreFarinhaPortfolio.Models;

public sealed class Project
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = [];
    public List<string> Technologies { get; set; } = [];
}

