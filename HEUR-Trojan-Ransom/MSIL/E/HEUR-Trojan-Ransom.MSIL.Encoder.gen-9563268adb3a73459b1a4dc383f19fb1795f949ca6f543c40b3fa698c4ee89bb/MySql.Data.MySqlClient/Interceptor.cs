using System;

namespace MySql.Data.MySqlClient;

internal abstract class Interceptor
{
	protected MySqlConnection Connection;

	protected void LoadInterceptors(string interceptorList)
	{
		if (string.IsNullOrEmpty(interceptorList))
		{
			return;
		}
		string[] array = interceptorList.Split(new char[1] { '|' });
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text))
			{
				object o = Activator.CreateInstance(Type.GetType(ResolveType(text)));
				AddInterceptor(o);
			}
		}
	}

	protected abstract void AddInterceptor(object o);

	protected virtual string ResolveType(string nameOrType)
	{
		return nameOrType;
	}
}
