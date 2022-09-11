using System;
using System.Data;

namespace Business.Data;

public interface ITransaction : IDisposable
{
	IDbTransaction Transaction { get; }

	void BeginTransaction();

	void BeginTransaction(IsolationLevel isolationLevel);

	void Commit();

	void Rollback();
}
