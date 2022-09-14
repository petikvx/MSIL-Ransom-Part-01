using System.Text;

namespace ns0;

public class GClass5 : GClass0
{
	private bool bool_3;

	public override GEnum0 GEnum0_0 => GEnum0.const_5;

	public override bool Boolean_2 => true;

	public override string String_0
	{
		get
		{
			return bool_3.ToString();
		}
		set
		{
			if (bool.TryParse(value, out var result))
			{
				bool_3 = result;
			}
		}
	}

	public override bool Boolean_7
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

	public override GStruct0 GetEnumerator()
	{
		return default(GStruct0);
	}

	public GClass5(bool bool_4)
	{
		bool_3 = bool_4;
	}

	public GClass5(string string_0)
	{
		String_0 = string_0;
	}

	public override GClass0 Clone()
	{
		return new GClass5(bool_3);
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append(bool_3 ? "true" : "false");
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is bool)
		{
			return bool_3 == (bool)obj;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return bool_3.GetHashCode();
	}
}
