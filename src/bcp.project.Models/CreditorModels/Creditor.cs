using System;
namespace bcp.project.Models.CreditorModels;

public class Creditor
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string UserEmail { get; set; } = string.Empty;
    public double UserSalary { get; set; }
}

