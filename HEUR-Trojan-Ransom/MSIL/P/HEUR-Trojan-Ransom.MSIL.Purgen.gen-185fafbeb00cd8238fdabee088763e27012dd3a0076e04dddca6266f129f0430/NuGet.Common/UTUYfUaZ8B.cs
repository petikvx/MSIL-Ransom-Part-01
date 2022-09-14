using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

[DefaultMember("Item")]
public class UTUYfUaZ8B
{
	private IDictionary<string, object> OBKQbMCk8d;

	private IDictionary<string, object> xUCa8qqb6K;

	[CompilerGenerated]
	private readonly string _7yJCZIhp5l;

	public string ycROx8VJg0
	{
		[CompilerGenerated]
		get
		{
			return _7yJCZIhp5l;
		}
	}

	public int _2k64Eenruc => OBKQbMCk8d.Count;

	public object _2irZNTcrsP
	{
		get
		{
			if (key != null)
			{
				OBKQbMCk8d.TryGetValue(key, out var value);
				return value;
			}
			return null;
		}
		set
		{
			OBKQbMCk8d[key] = value;
		}
	}

	public UTUYfUaZ8B(string eventName)
		: this(eventName, new Dictionary<string, object>())
	{
	}

	public UTUYfUaZ8B(string eventName, Dictionary<string, object> properties)
	{
		_7yJCZIhp5l = eventName;
		OBKQbMCk8d = properties;
		xUCa8qqb6K = new Dictionary<string, object>();
	}

	public IEnumerator<KeyValuePair<string, object>> I9n94ELCzQ()
	{
		return OBKQbMCk8d.GetEnumerator();
	}

	public void Dxae2liRpk(string d0NaicTeOw, object _2uBhUcLRxd)
	{
		xUCa8qqb6K[d0NaicTeOw] = _2uBhUcLRxd;
	}

	public IEnumerable<KeyValuePair<string, object>> HstFnZP7jE()
	{
		return xUCa8qqb6K;
	}
}
