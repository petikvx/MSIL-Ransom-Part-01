using System;
using System.Data;

namespace Business.Data;

public interface IConnection : IDisposable, ITransaction, IData2
{
	IEntity Entity { get; }

	IDbCommand CreateCommand();
}
