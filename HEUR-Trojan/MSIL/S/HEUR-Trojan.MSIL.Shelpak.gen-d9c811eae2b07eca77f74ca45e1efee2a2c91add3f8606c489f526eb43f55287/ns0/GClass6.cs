using System.Text;

namespace ns0;

public class GClass6 : GClass0
{
	private static GClass6 gclass6_0 = new GClass6();

	public static bool bool_3 = true;

	public override GEnum0 GEnum0_0 => GEnum0.const_4;

	public override bool Boolean_3 => true;

	public override string String_0
	{
		get
		{
			return "null";
		}
		set
		{
		}
	}

	public override bool Boolean_7
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static GClass6 smethod_3()
	{
		if (bool_3)
		{
			return gclass6_0;
		}
		return new GClass6();
	}

	private GClass6()
	{
	}

	public override GStruct0 GetEnumerator()
	{
		return default(GStruct0);
	}

	public override GClass0 Clone()
	{
		return smethod_3();
	}

	public override bool Equals(object obj)
	{
		if ((object)this == obj)
		{
			return true;
		}
		return obj is GClass6;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append("null");
	}
}
