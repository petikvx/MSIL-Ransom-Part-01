using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hy6rase;

[DefaultMember("Item")]
public class Viscositi1s
{
	private IDictionary<string, object> Ce2entites;

	private IDictionary<string, object> idictionary_0;

	[CompilerGenerated]
	private readonly string Exuvi7l;

	public string Fuj1
	{
		[CompilerGenerated]
		get
		{
			return Exuvi7l;
		}
	}

	public int Tenia7e7 => Ce2entites.Count;

	public object Sa7oriness
	{
		get
		{
			if (key != null)
			{
				Ce2entites.TryGetValue(key, out var value);
				return value;
			}
			return null;
		}
		set
		{
			Ce2entites[key] = value;
		}
	}

	public Viscositi1s(string eventName)
		: this(eventName, new Dictionary<string, object>())
	{
	}

	public Viscositi1s(string eventName, Dictionary<string, object> properties)
	{
		Exuvi7l = eventName;
		Ce2entites = properties;
		idictionary_0 = new Dictionary<string, object>();
	}

	public IEnumerator<KeyValuePair<string, object>> Rebi0di0g()
	{
		return Ce2entites.GetEnumerator();
	}

	public void Har7equin(string Unf5lder, object Ta4orine)
	{
		idictionary_0[Unf5lder] = Ta4orine;
	}

	public IEnumerable<KeyValuePair<string, object>> Q8iverer()
	{
		return idictionary_0;
	}
}
