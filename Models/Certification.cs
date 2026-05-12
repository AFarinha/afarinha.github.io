namespace AndreFarinhaPortfolio.Models;

public sealed class Certification
{
    public string Name { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string Issued { get; set; } = string.Empty;
    public string CredentialId { get; set; } = string.Empty;
    public string CredentialUrl { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = [];
}

