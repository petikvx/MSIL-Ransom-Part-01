using System;

namespace MySql.Data.MySqlClient;

internal class CommandTimer : IDisposable
{
	private bool _timeoutSet;

	private MySqlConnection _connection;

	public CommandTimer(MySqlConnection connection, int timeout)
	{
		_connection = connection;
		if (connection != null)
		{
			_timeoutSet = connection.SetCommandTimeout(timeout);
		}
	}

	public void Dispose()
	{
		if (_timeoutSet)
		{
			_timeoutSet = false;
			_connection.ClearCommandTimeout();
			_connection = null;
		}
	}
}
