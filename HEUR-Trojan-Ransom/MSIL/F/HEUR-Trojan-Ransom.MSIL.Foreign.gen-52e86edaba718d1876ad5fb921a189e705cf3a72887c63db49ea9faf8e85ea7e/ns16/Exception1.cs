using System;
using MySql.Data.MySqlClient.Interceptors;

namespace ns16;

internal sealed class Exception1 : BaseExceptionInterceptor
{
	public override Exception vmethod_0(Exception exception_0)
	{
		return exception_0;
	}
}
