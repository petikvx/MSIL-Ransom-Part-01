using System;

namespace MySql.Data.MySqlClient.Memcached;

public class MemcachedException : Exception
{
	public MemcachedException(string msg)
		: base(msg)
	{
	}

	public MemcachedException(string msg, Exception e)
		: base(msg, e)
	{
	}
}
