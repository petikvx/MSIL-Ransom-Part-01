using System.Collections.Generic;

namespace System.Data.SQLite;

public interface ISQLiteConnectionPool
{
	void GetCounts(string fileName, ref Dictionary<string, int> counts, ref int openCount, ref int closeCount, ref int totalCount);

	void ClearPool(string fileName);

	void ClearAllPools();

	void Add(string fileName, object handle, int version);

	object Remove(string fileName, int maxPoolSize, out int version);
}
