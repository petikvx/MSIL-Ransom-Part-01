using System.Collections.Generic;
using System.Text;

namespace ns0;

public class GClass1 : GClass0
{
	private List<GClass0> list_0 = new List<GClass0>();

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

	public override GEnum0 GEnum0_0 => GEnum0.const_0;

	public override bool Boolean_4 => true;

	public override GClass0 this[int int_0]
	{
		get
		{
			if (int_0 >= 0 && int_0 < list_0.Count)
			{
				return list_0[int_0];
			}
			return new Class0(this);
		}
		set
		{
			if (value == null)
			{
				value = GClass6.smethod_3();
			}
			if (int_0 >= 0 && int_0 < list_0.Count)
			{
				list_0[int_0] = value;
			}
			else
			{
				list_0.Add(value);
			}
		}
	}

	public override GClass0 this[string string_0]
	{
		get
		{
			return new Class0(this);
		}
		set
		{
			if (value == null)
			{
				value = GClass6.smethod_3();
			}
			list_0.Add(value);
		}
	}

	public override int Int32_0 => list_0.Count;

	public override IEnumerable<GClass0> Prop_0
	{
		get
		{
			foreach (GClass0 item in list_0)
			{
				yield return item;
			}
		}
	}

	public override GStruct0 GetEnumerator()
	{
		return new GStruct0(list_0.GetEnumerator());
	}

	public override void Add(string string_0, GClass0 gclass0_0)
	{
		if (gclass0_0 == null)
		{
			gclass0_0 = GClass6.smethod_3();
		}
		list_0.Add(gclass0_0);
	}

	public override GClass0 Remove(int int_0)
	{
		if (int_0 >= 0 && int_0 < list_0.Count)
		{
			GClass0 result = list_0[int_0];
			list_0.RemoveAt(int_0);
			return result;
		}
		return null;
	}

	public override GClass0 Remove(GClass0 gclass0_0)
	{
		list_0.Remove(gclass0_0);
		return gclass0_0;
	}

	public override GClass0 Clone()
	{
		GClass1 gClass = new GClass1();
		gClass.list_0.Capacity = list_0.Capacity;
		foreach (GClass0 item in list_0)
		{
			if (item != null)
			{
				gClass.Add(item.Clone());
			}
			else
			{
				gClass.Add(null);
			}
		}
		return gClass;
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append('[');
		int count = list_0.Count;
		if (bool_3)
		{
			genum1_0 = GEnum1.const_0;
		}
		for (int i = 0; i < count; i++)
		{
			if (i > 0)
			{
				stringBuilder_0.Append(',');
			}
			if (genum1_0 == GEnum1.const_1)
			{
				stringBuilder_0.AppendLine();
			}
			if (genum1_0 == GEnum1.const_1)
			{
				stringBuilder_0.Append(' ', int_0 + int_1);
			}
			list_0[i].WriteToStringBuilder(stringBuilder_0, int_0 + int_1, int_1, genum1_0);
		}
		if (genum1_0 == GEnum1.const_1)
		{
			stringBuilder_0.AppendLine().Append(' ', int_0);
		}
		stringBuilder_0.Append(']');
	}
}
