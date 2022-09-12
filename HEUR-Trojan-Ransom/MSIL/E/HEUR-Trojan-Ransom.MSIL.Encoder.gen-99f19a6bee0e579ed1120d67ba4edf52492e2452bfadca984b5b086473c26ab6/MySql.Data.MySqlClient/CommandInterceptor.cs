using System;
using System.Collections.Generic;
using System.Data;

namespace MySql.Data.MySqlClient;

internal sealed class CommandInterceptor : Interceptor
{
	private bool _insideInterceptor;

	private readonly List<BaseCommandInterceptor> _interceptors = new List<BaseCommandInterceptor>();

	public CommandInterceptor(MySqlConnection connection)
	{
		Connection = connection;
		LoadInterceptors(connection.Settings.CommandInterceptors);
	}

	public bool ExecuteScalar(string sql, ref object returnValue)
	{
		if (_insideInterceptor)
		{
			return false;
		}
		_insideInterceptor = true;
		bool flag = false;
		foreach (BaseCommandInterceptor interceptor in _interceptors)
		{
			flag |= interceptor.ExecuteScalar(sql, ref returnValue);
		}
		_insideInterceptor = false;
		return flag;
	}

	public bool ExecuteNonQuery(string sql, ref int returnValue)
	{
		if (_insideInterceptor)
		{
			return false;
		}
		_insideInterceptor = true;
		bool flag = false;
		foreach (BaseCommandInterceptor interceptor in _interceptors)
		{
			flag |= interceptor.ExecuteNonQuery(sql, ref returnValue);
		}
		_insideInterceptor = false;
		return flag;
	}

	public bool ExecuteReader(string sql, CommandBehavior behavior, ref MySqlDataReader returnValue)
	{
		if (_insideInterceptor)
		{
			return false;
		}
		_insideInterceptor = true;
		bool flag = false;
		foreach (BaseCommandInterceptor interceptor in _interceptors)
		{
			flag |= interceptor.ExecuteReader(sql, behavior, ref returnValue);
		}
		_insideInterceptor = false;
		return flag;
	}

	protected override void AddInterceptor(object o)
	{
		if (o == null)
		{
			throw new ArgumentException("Unable to instantiate CommandInterceptor");
		}
		if (!(o is BaseCommandInterceptor))
		{
			throw new InvalidOperationException(string.Format(Resources.TypeIsNotCommandInterceptor, o.GetType()));
		}
		((BaseCommandInterceptor)o).Init(Connection);
		_interceptors.Insert(0, (BaseCommandInterceptor)o);
	}

	protected override string ResolveType(string nameOrType)
	{
		if (MySqlConfiguration.Settings != null && MySqlConfiguration.Settings.CommandInterceptors != null)
		{
			foreach (InterceptorConfigurationElement commandInterceptor in MySqlConfiguration.Settings.CommandInterceptors)
			{
				if (string.Compare(commandInterceptor.Name, nameOrType, ignoreCase: true) == 0)
				{
					return commandInterceptor.Type;
				}
			}
			return base.ResolveType(nameOrType);
		}
		return base.ResolveType(nameOrType);
	}
}
