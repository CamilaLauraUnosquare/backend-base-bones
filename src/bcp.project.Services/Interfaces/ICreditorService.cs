using System;
using bcp.project.Models.CreditorModels;

namespace bcp.project.Services.Interfaces;

public interface ICreditorService
{
    public Task<List<Creditor>> GetAllCreditors();
}

