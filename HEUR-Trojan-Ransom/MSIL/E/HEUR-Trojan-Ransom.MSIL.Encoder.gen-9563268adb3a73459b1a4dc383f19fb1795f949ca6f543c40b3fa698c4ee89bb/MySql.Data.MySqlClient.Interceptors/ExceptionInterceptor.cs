using System;
using System.Collections.Generic;
using System.Linq;

namespace MySql.Data.MySqlClient.Interceptors;

internal sealed class ExceptionInterceptor : Interceptor
{
	private readonly List<BaseExceptionInterceptor> _interceptors = new List<BaseExceptionInterceptor>();

	public ExceptionInterceptor(MySqlConnection connection)
	{
		Connection = connection;
		LoadInterceptors(connection.Settings.ExceptionInterceptors);
		_interceptors.Add(new StandardExceptionInterceptor());
	}

	protected override void AddInterceptor(object o)
	{
		if (o == null)
		{
			throw new ArgumentException("Unable to instantiate ExceptionInterceptor");
		}
		if (!(o is BaseExceptionInterceptor))
		{
			throw new InvalidOperationException(string.Format(Resources.TypeIsNotExceptionInterceptor, o.GetType()));
		}
		(o as BaseExceptionInterceptor).Init(Connection);
		_interceptors.Insert(0, (BaseExceptionInterceptor)o);
	}

	public void Throw(Exception exception)
	{
		throw _interceptors.Aggregate(exception, (Exception current, BaseExceptionInterceptor ie) => ie.InterceptException(current));
	}

	protected override string ResolveType(string nameOrType)
	{
		if (MySqlConfiguration.Settings != null && MySqlConfiguration.Settings.ExceptionInterceptors != null)
		{
			foreach (InterceptorConfigurationElement exceptionInterceptor in MySqlConfiguration.Settings.ExceptionInterceptors)
			{
				if (string.Compare(exceptionInterceptor.Name, nameOrType, ignoreCase: true) == 0)
				{
					return exceptionInterceptor.Type;
				}
			}
			return base.ResolveType(nameOrType);
		}
		return base.ResolveType(nameOrType);
	}
}
