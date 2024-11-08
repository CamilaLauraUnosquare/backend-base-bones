using System;
using System.Data;
using System.Data.SqlClient;
using bcp.project.DataAccess.Interfaces;
using bcp.project.Models.CreditorModels;
using Dapper;

namespace bcp.project.DataAccess.Repositories;

public class CreditorRepository: ICreditorRepository
{
    private readonly string ConnectionString;
	public CreditorRepository(string connectionString)
	{
        this.ConnectionString = connectionString;
	}

    public async Task<List<Creditor>> GetCreditors()
    {
        using IDbConnection db = new SqlConnection(this.ConnectionString);
        string storeProcedure = "Get_All_Creditors";
        DynamicParameters parameters = new();
        var creditors = await db.QueryAsync<Creditor>(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
        return creditors.ToList();

        throw new NotImplementedException();
    }
}

