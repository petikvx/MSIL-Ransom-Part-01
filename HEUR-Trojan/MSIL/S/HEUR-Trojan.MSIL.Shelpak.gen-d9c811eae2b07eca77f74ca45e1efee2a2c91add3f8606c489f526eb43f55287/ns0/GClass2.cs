using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0;

public class GClass2 : GClass0
{
	[CompilerGenerated]
	private sealed class Class4
	{
		public GClass0 gclass0_0;

		internal bool _003CRemove_003Eb__0(KeyValuePair<string, GClass0> k)
		{
			return k.Value == gclass0_0;
		}
	}

	private Dictionary<string, GClass0> dictionary_0 = new Dictionary<string, GClass0>();

	private bool bool_3;

	public override bool Boolean_6
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public override GEnum0 GEnum0_0 => GEnum0.const_1;

	public override bool Boolean_5 => true;

	public override GClass0 this[string string_0]
	{
		get
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				return dictionary_0[string_0];
			}
			return new Class0(this, string_0);
		}
		set
		{
			if (value == null)
			{
				value = GClass6.smethod_3();
			}
			if (dictionary_0.ContainsKey(string_0))
			{
				dictionary_0[string_0] = value;
			}
			else
			{
				dictionary_0.Add(string_0, value);
			}
		}
	}

	public override GClass0 this[int int_0]
	{
		get
		{
			if (int_0 >= 0 && int_0 < dictionary_0.Count)
			{
				return dictionary_0.ElementAt(int_0).Value;
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				value = GClass6.smethod_3();
			}
			if (int_0 >= 0 && int_0 < dictionary_0.Count)
			{
				string key = dictionary_0.ElementAt(int_0).Key;
				dictionary_0[key] = value;
			}
		}
	}

	public override int Int32_0 => dictionary_0.Count;

	public override IEnumerable<GClass0> Prop_0
	{
		get
		{
			foreach (KeyValuePair<string, GClass0> item in dictionary_0)
			{
				yield return item.Value;
			}
		}
	}

	public override GStruct0 GetEnumerator()
	{
		return new GStruct0(dictionary_0.GetEnumerator());
	}

	public override void Add(string string_0, GClass0 gclass0_0)
	{
		if (gclass0_0 == null)
		{
			gclass0_0 = GClass6.smethod_3();
		}
		if (string_0 != null)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				dictionary_0[string_0] = gclass0_0;
			}
			else
			{
				dictionary_0.Add(string_0, gclass0_0);
			}
		}
		else
		{
			dictionary_0.Add(Guid.NewGuid().ToString(), gclass0_0);
		}
	}

	public override GClass0 Remove(string string_0)
	{
		if (!dictionary_0.ContainsKey(string_0))
		{
			return null;
		}
		GClass0 result = dictionary_0[string_0];
		dictionary_0.Remove(string_0);
		return result;
	}

	public override GClass0 Remove(int int_0)
	{
		if (int_0 >= 0 && int_0 < dictionary_0.Count)
		{
			KeyValuePair<string, GClass0> keyValuePair = dictionary_0.ElementAt(int_0);
			dictionary_0.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}
		return null;
	}

	public override GClass0 Remove(GClass0 gclass0_0)
	{
		try
		{
			KeyValuePair<string, GClass0> keyValuePair = dictionary_0.Where((KeyValuePair<string, GClass0> k) => k.Value == gclass0_0).First();
			dictionary_0.Remove(keyValuePair.Key);
			return gclass0_0;
		}
		catch
		{
			return null;
		}
	}

	public override GClass0 Clone()
	{
		GClass2 gClass = new GClass2();
		foreach (KeyValuePair<string, GClass0> item in dictionary_0)
		{
			gClass.Add(item.Key, item.Value.Clone());
		}
		return gClass;
	}

	public override bool HasKey(string string_0)
	{
		return dictionary_0.ContainsKey(string_0);
	}

	public override GClass0 GetValueOrDefault(string string_0, GClass0 gclass0_0)
	{
		if (dictionary_0.TryGetValue(string_0, out var value))
		{
			return value;
		}
		return gclass0_0;
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append('{');
		bool flag = true;
		if (bool_3)
		{
			genum1_0 = GEnum1.const_0;
		}
		foreach (KeyValuePair<string, GClass0> item in dictionary_0)
		{
			if (!flag)
			{
				stringBuilder_0.Append(',');
			}
			flag = false;
			if (genum1_0 == GEnum1.const_1)
			{
				stringBuilder_0.AppendLine();
			}
			if (genum1_0 == GEnum1.const_1)
			{
				stringBuilder_0.Append(' ', int_0 + int_1);
			}
			stringBuilder_0.Append('"').Append(GClass0.smethod_0(item.Key)).Append('"');
			if (genum1_0 == GEnum1.const_0)
			{
				stringBuilder_0.Append(':');
			}
			else
			{
				stringBuilder_0.Append(" : ");
			}
			item.Value.WriteToStringBuilder(stringBuilder_0, int_0 + int_1, int_1, genum1_0);
		}
		if (genum1_0 == GEnum1.const_1)
		{
			stringBuilder_0.AppendLine().Append(' ', int_0);
		}
		stringBuilder_0.Append('}');
	}
}
