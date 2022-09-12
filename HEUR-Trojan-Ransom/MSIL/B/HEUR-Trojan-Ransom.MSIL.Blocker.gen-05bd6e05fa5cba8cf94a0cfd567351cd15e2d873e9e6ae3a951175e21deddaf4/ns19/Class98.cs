using System;
using System.Diagnostics;
using System.Globalization;
using ns10;
using ns3;

namespace ns19;

internal static class Class98
{
	[Conditional("DEBUG")]
	public static void smethod_0([Attribute4(false)] bool bool_0, string? string_0 = null)
	{
	}

	public static bool smethod_1(object? object_0, object? object_1)
	{
		if (object_0 == object_1)
		{
			return true;
		}
		if (object_0 != null && object_1 != null)
		{
			if (object_0!.GetType() != object_1!.GetType())
			{
				if (Class4.smethod_560(object_0) && Class4.smethod_560(object_1))
				{
					return Convert.ToDecimal(object_0, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(object_1, CultureInfo.CurrentCulture));
				}
				if ((!(object_0 is double) && !(object_0 is float) && !(object_0 is decimal)) || (!(object_1 is double) && !(object_1 is float) && !(object_1 is decimal)))
				{
					return false;
				}
				return Class4.smethod_641(Convert.ToDouble(object_0, CultureInfo.CurrentCulture), Convert.ToDouble(object_1, CultureInfo.CurrentCulture));
			}
			return object_0!.Equals(object_1);
		}
		return false;
	}

	public static int smethod_2(byte[] byte_0, byte[] byte_1)
	{
		int num = byte_0.Length.CompareTo(byte_1.Length);
		if (num != 0)
		{
			return num;
		}
		int num2 = 0;
		int num3;
		while (true)
		{
			if (num2 < byte_0.Length)
			{
				num3 = byte_0[num2].CompareTo(byte_1[num2]);
				if (num3 != 0)
				{
					break;
				}
				num2++;
				continue;
			}
			return 0;
		}
		return num3;
	}
}
