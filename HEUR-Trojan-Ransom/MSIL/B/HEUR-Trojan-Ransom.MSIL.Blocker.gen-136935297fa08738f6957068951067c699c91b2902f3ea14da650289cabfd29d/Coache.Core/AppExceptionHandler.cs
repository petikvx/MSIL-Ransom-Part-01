using System;
using System.Data.SqlClient;
using System.Threading;

namespace Coache.Core;

internal class AppExceptionHandler
{
	public static void Invoke(object sender, ThreadExceptionEventArgs e)
	{
		if (e.Exception is SqlException)
		{
			Exception exception = e.Exception;
			SqlExceptionHandler.Handle((SqlException)(object)((exception is SqlException) ? exception : null));
		}
		else
		{
			ViewsManager.Alert(e.Exception.Message);
		}
	}
}
