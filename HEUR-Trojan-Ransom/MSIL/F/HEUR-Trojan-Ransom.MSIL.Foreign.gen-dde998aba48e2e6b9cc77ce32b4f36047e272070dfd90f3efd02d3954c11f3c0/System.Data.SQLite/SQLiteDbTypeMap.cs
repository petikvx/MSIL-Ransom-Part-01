using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteDbTypeMap : Dictionary<string, SQLiteDbTypeMapping>
{
	private Dictionary<DbType, SQLiteDbTypeMapping> reverse;

	[NonSerialized]
	internal static GetString _001D;

	public SQLiteDbTypeMap()
		: base((IEqualityComparer<string>?)new TypeNameStringComparer())
	{
		reverse = new Dictionary<DbType, SQLiteDbTypeMapping>();
	}

	public SQLiteDbTypeMap(IEnumerable<SQLiteDbTypeMapping> collection)
		: this()
	{
		Add(collection);
	}

	public new int Clear()
	{
		int num = 0;
		if (reverse != null)
		{
			num += reverse.Count;
			reverse.Clear();
		}
		num += base.Count;
		base.Clear();
		return num;
	}

	public void Add(IEnumerable<SQLiteDbTypeMapping> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException(_001D(107384511));
		}
		foreach (SQLiteDbTypeMapping item in collection)
		{
			Add(item);
		}
	}

	public void Add(SQLiteDbTypeMapping item)
	{
		if (item == null)
		{
			throw new ArgumentNullException(_001D(107384974));
		}
		if (item.typeName == null)
		{
			throw new ArgumentException(_001D(107384997));
		}
		Add(item.typeName, item);
		if (item.primary)
		{
			reverse.Add(item.dataType, item);
		}
	}

	public bool ContainsKey(DbType key)
	{
		if (reverse == null)
		{
			return false;
		}
		return reverse.ContainsKey(key);
	}

	public bool TryGetValue(DbType key, out SQLiteDbTypeMapping value)
	{
		if (reverse == null)
		{
			value = null;
			return false;
		}
		return reverse.TryGetValue(key, out value);
	}

	public bool Remove(DbType key)
	{
		if (reverse == null)
		{
			return false;
		}
		return reverse.Remove(key);
	}

	static SQLiteDbTypeMap()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteDbTypeMap));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001D(107400986), _001D(107400949)), _001D(107400944), _001D(107400939)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001D(107400966)))
		{
			return;
		}
		throw new SecurityException(_001D(107400909));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
