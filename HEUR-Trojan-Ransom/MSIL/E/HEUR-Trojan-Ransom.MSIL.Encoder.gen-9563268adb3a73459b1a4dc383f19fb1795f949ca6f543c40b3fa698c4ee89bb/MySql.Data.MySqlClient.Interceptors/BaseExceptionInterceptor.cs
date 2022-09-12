using System;

namespace MySql.Data.MySqlClient.Interceptors;

public abstract class BaseExceptionInterceptor
{
	protected MySqlConnection ActiveConnection { get; private set; }

	public abstract Exception InterceptException(Exception exception);

	public virtual void Init(MySqlConnection connection)
	{
		ActiveConnection = connection;
	}
}
