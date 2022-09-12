using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MySql.Data.MySqlClient;

internal class ProcedureCache
{
	private readonly Dictionary<int, ProcedureCacheEntry> _procHash;

	private readonly Queue<int> _hashQueue;

	private readonly int _maxSize;

	public ProcedureCache(int size)
	{
		_maxSize = size;
		_hashQueue = new Queue<int>(_maxSize);
		_procHash = new Dictionary<int, ProcedureCacheEntry>(_maxSize);
	}

	public ProcedureCacheEntry GetProcedure(MySqlConnection conn, string spName, string cacheKey)
	{
		ProcedureCacheEntry value = null;
		if (cacheKey != null)
		{
			int hashCode = cacheKey.GetHashCode();
			lock (_procHash)
			{
				_procHash.TryGetValue(hashCode, out value);
			}
		}
		if (value == null)
		{
			value = AddNew(conn, spName);
			conn.PerfMonitor.AddHardProcedureQuery();
			if (conn.Settings.Logging)
			{
				MySqlTrace.LogInformation(conn.ServerThread, string.Format(Resources.HardProcQuery, spName));
			}
		}
		else
		{
			conn.PerfMonitor.AddSoftProcedureQuery();
			if (conn.Settings.Logging)
			{
				MySqlTrace.LogInformation(conn.ServerThread, string.Format(Resources.SoftProcQuery, spName));
			}
		}
		return value;
	}

	internal string GetCacheKey(string spName, ProcedureCacheEntry proc)
	{
		string text = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(spName);
		stringBuilder.Append("(");
		string text2 = "";
		if (proc.parameters != null)
		{
			foreach (MySqlSchemaRow row in proc.parameters.Rows)
			{
				if (row["ORDINAL_POSITION"].Equals(0))
				{
					text = "?=";
					continue;
				}
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}?", new object[1] { text2 });
				text2 = ",";
			}
		}
		stringBuilder.Append(")");
		return text + stringBuilder.ToString();
	}

	private ProcedureCacheEntry AddNew(MySqlConnection connection, string spName)
	{
		ProcedureCacheEntry procData = GetProcData(connection, spName);
		if (_maxSize <= 0)
		{
			return procData;
		}
		int hashCode = GetCacheKey(spName, procData).GetHashCode();
		lock (_procHash)
		{
			if (_procHash.Keys.Count >= _maxSize)
			{
				TrimHash();
			}
			if (!_procHash.ContainsKey(hashCode))
			{
				_procHash[hashCode] = procData;
				_hashQueue.Enqueue(hashCode);
				return procData;
			}
			return procData;
		}
	}

	private void TrimHash()
	{
		int key = _hashQueue.Dequeue();
		_procHash.Remove(key);
	}

	private static ProcedureCacheEntry GetProcData(MySqlConnection connection, string spName)
	{
		string text = string.Empty;
		string text2 = spName;
		int num = spName.IndexOf(".");
		if (num != -1)
		{
			text = spName.Substring(0, num);
			text2 = spName.Substring(num + 1, spName.Length - num - 1);
		}
		string[] restrictionValues = new string[4]
		{
			null,
			(text.Length > 0) ? text : connection.CurrentDatabase(),
			text2,
			null
		};
		MySqlSchemaCollection schemaCollection = connection.GetSchemaCollection("procedures", restrictionValues);
		if (schemaCollection.Rows.Count > 1)
		{
			throw new MySqlException(Resources.ProcAndFuncSameName);
		}
		if (schemaCollection.Rows.Count == 0)
		{
			throw new MySqlException(string.Format(Resources.InvalidProcName, text2, text));
		}
		ProcedureCacheEntry obj = new ProcedureCacheEntry
		{
			procedure = schemaCollection
		};
		ISSchemaProvider iSSchemaProvider = new ISSchemaProvider(connection);
		string[] restrictions = iSSchemaProvider.CleanRestrictions(restrictionValues);
		MySqlSchemaCollection mySqlSchemaCollection = (obj.parameters = iSSchemaProvider.GetProcedureParameters(restrictions, schemaCollection));
		return obj;
	}
}
