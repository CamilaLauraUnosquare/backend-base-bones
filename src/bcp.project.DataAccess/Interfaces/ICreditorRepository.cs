using System;
using bcp.project.Models.CreditorModels;

namespace bcp.project.DataAccess.Interfaces
{
	public interface ICreditorRepository
	{
		public Task<List<Creditor>> GetCreditors();
	}
}

