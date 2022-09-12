using System;

namespace MySql.Data.MySqlClient.Interceptors;

internal sealed class StandardExceptionInterceptor : BaseExceptionInterceptor
{
	public override Exception InterceptException(Exception exception)
	{
		return exception;
	}
}
