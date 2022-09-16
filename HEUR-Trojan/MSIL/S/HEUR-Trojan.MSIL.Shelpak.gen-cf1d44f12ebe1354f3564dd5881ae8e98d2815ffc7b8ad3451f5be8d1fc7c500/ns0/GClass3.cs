using System.Text;

namespace ns0;

public class GClass3 : GClass0
{
	private string string_0;

	public override GEnum0 GEnum0_0 => GEnum0.const_2;

	public override bool Boolean_1 => true;

	public override string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public override GStruct0 GetEnumerator()
	{
		return default(GStruct0);
	}

	public GClass3(string string_1)
	{
		string_0 = string_1;
	}

	public override GClass0 Clone()
	{
		return new GClass3(string_0);
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append('"').Append(GClass0.smethod_0(string_0)).Append('"');
	}

	public override bool Equals(object obj)
	{
		if (base.Equals(obj))
		{
			return true;
		}
		if (obj is string text)
		{
			return string_0 == text;
		}
		GClass3 gClass = obj as GClass3;
		if (gClass != null)
		{
			return string_0 == gClass.string_0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return string_0.GetHashCode();
	}
}
