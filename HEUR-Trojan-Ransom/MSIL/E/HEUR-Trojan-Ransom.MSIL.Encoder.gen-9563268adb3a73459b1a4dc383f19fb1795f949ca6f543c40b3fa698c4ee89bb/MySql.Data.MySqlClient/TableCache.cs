namespace MySql.Data.MySqlClient;

internal class TableCache
{
	private static readonly BaseTableCache cache;

	static TableCache()
	{
		cache = new BaseTableCache(480);
	}

	public static void AddToCache(string commandText, ResultSet resultSet)
	{
		cache.AddToCache(commandText, resultSet);
	}

	public static ResultSet RetrieveFromCache(string commandText, int cacheAge)
	{
		return (ResultSet)cache.RetrieveFromCache(commandText, cacheAge);
	}

	public static void RemoveFromCache(string commandText)
	{
		cache.RemoveFromCache(commandText);
	}

	public static void DumpCache()
	{
		cache.Dump();
	}
}
