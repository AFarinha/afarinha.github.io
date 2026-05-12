namespace AndreFarinhaPortfolio.Models;

public sealed class SkillCategory
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = [];
}

