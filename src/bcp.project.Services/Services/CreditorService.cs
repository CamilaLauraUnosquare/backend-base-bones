using System;
using System.Runtime.InteropServices;
using bcp.project.DataAccess.Interfaces;
using bcp.project.Models.CreditorModels;
using bcp.project.Services.Interfaces;

namespace bcp.project.Services.Services;

public class CreditorService: ICreditorService
{

    private readonly ICreditorRepository CreditorRepository;

    public CreditorService(ICreditorRepository creditorRepository)
    {
        this.CreditorRepository = creditorRepository;
    }

    public async Task<List<Creditor>> GetAllCreditors()
    {
        return await this.CreditorRepository.GetCreditors();
    }
}

