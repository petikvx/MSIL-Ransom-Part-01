using System;
using System.Globalization;
using System.Text;

namespace ns0;

public class GClass4 : GClass0
{
	private double double_0;

	public override GEnum0 GEnum0_0 => GEnum0.const_3;

	public override bool Boolean_0 => true;

	public override string String_0
	{
		get
		{
			return double_0.ToString(CultureInfo.InvariantCulture);
		}
		set
		{
			if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				double_0 = result;
			}
		}
	}

	public override double Double_0
	{
		get
		{
			return double_0;
		}
		set
		{
			double_0 = value;
		}
	}

	public override long Int64_0
	{
		get
		{
			return (long)double_0;
		}
		set
		{
			double_0 = value;
		}
	}

	public override GStruct0 GetEnumerator()
	{
		return default(GStruct0);
	}

	public GClass4(double double_1)
	{
		double_0 = double_1;
	}

	public GClass4(string string_0)
	{
		String_0 = string_0;
	}

	public override GClass0 Clone()
	{
		return new GClass4(double_0);
	}

	internal override void WriteToStringBuilder(StringBuilder stringBuilder_0, int int_0, int int_1, GEnum1 genum1_0)
	{
		stringBuilder_0.Append(String_0);
	}

	private static bool smethod_3(object object_0)
	{
		if (!(object_0 is int) && !(object_0 is uint) && !(object_0 is float) && !(object_0 is double) && !(object_0 is decimal) && !(object_0 is long) && !(object_0 is ulong) && !(object_0 is short) && !(object_0 is ushort) && !(object_0 is sbyte))
		{
			return object_0 is byte;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (base.Equals(obj))
		{
			return true;
		}
		GClass4 gClass = obj as GClass4;
		if (gClass != null)
		{
			return double_0 == gClass.double_0;
		}
		if (smethod_3(obj))
		{
			return Convert.ToDouble(obj) == double_0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return double_0.GetHashCode();
	}
}
