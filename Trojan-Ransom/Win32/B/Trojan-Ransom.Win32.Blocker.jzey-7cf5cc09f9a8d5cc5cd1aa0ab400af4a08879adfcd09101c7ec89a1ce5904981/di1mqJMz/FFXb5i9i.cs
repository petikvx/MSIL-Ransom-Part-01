using System;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace di1mqJMz;

internal class FFXb5i9i
{
	internal static void UoxZtdZj(XmlSerializer xmlSerializer_0, XmlWriter xmlWriter_0, object object_0, int int_0)
	{
		switch (int_0 ^ 0x4DDE)
		{
		}
		xmlSerializer_0.Serialize(xmlWriter_0, object_0);
	}

	internal static void LfyQ8gZ7(int int_0)
	{
		switch (int_0 ^ 0x31D7)
		{
		}
		ProjectData.ClearProjectError();
	}

	internal static Delegate PcI4tKMj(Delegate delegate_0, Delegate delegate_1, int int_0)
	{
		return (int_0 ^ 0x7FD2) switch
		{
			1 => Delegate.Remove(delegate_0, delegate_1), 
			_ => Delegate.Combine(delegate_0, delegate_1), 
		};
	}

	internal static bool WyG16Cjm(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0xA239) switch
		{
			1 => string_0.EndsWith(string_1), 
			2 => string_0.StartsWith(string_1), 
			3 => string_0.Equals(string_1), 
			_ => string_0.Contains(string_1), 
		};
	}

	internal static string smethod_0(string string_0, string string_1, string string_2, int int_0)
	{
		return (int_0 ^ 0xCD7D) switch
		{
			_ => string_0 + string_1 + string_2, 
		};
	}

	internal static string MhuSoiDL(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		return (int_0 ^ 0x24BF) switch
		{
			_ => string_0 + string_1 + string_2 + string_3, 
		};
	}

	internal static string[] fLadxka9(string string_0, char[] char_0, int int_0)
	{
		return (int_0 ^ 0x8409) switch
		{
			_ => string_0.Split(char_0), 
		};
	}

	internal static string Be2UxXd8(string[] string_0, int int_0)
	{
		return (int_0 ^ 0xD14D) switch
		{
			_ => string.Concat(string_0), 
		};
	}

	internal static Type VcIT67Rx(object object_0, int int_0)
	{
		return (int_0 ^ 0xE2B7) switch
		{
			_ => object_0.GetType(), 
		};
	}

	internal static string pOhcgUVE(MemberInfo memberInfo_0, int int_0)
	{
		return (int_0 ^ 0xD4E1) switch
		{
			_ => memberInfo_0.Name, 
		};
	}

	internal static string UUMks6OM(string string_0, int int_0)
	{
		return (int_0 ^ 0xF6B0) switch
		{
			1 => string_0.Trim(), 
			_ => string_0.ToString(), 
		};
	}

	internal static bool smethod_1(object object_0, int int_0)
	{
		return (int_0 ^ 0xBCBC) switch
		{
			_ => Information.IsNothing(object_0), 
		};
	}

	internal static object smethod_2(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, int int_0)
	{
		return (int_0 ^ 0xABE5) switch
		{
			_ => NewLateBinding.LateGet(object_0, type_0, string_0, object_1, string_1, type_1, bool_0), 
		};
	}

	internal static object TCNI2YTH(object object_0, object object_1, int int_0)
	{
		return (int_0 ^ 0x5CF) switch
		{
			1 => Operators.ConcatenateObject(object_0, object_1), 
			2 => Operators.AddObject(object_0, object_1), 
			3 => Operators.ModObject(object_0, object_1), 
			4 => Operators.AndObject(object_0, object_1), 
			_ => Operators.SubtractObject(object_0, object_1), 
		};
	}

	internal static object joZDbSGP(object object_0, object object_1, bool bool_0, int int_0)
	{
		return (int_0 ^ 0x5948) switch
		{
			_ => Operators.CompareObjectEqual(object_0, object_1, bool_0), 
		};
	}

	internal static object nWO7RQjw(object object_0, int int_0)
	{
		return (int_0 ^ 0x565A) switch
		{
			_ => Operators.NotObject(object_0), 
		};
	}

	internal static bool rs8UXJ4a(object object_0, int int_0)
	{
		return (int_0 ^ 0x5255) switch
		{
			_ => Conversions.ToBoolean(object_0), 
		};
	}

	internal static int fEqPi5J6(object object_0, int int_0)
	{
		return (int_0 ^ 0x57F8) switch
		{
			_ => Conversions.ToInteger(object_0), 
		};
	}

	internal static void smethod_3(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool bool_0, bool bool_1, int int_0)
	{
		switch (int_0 ^ 0xF0B2)
		{
		}
		NewLateBinding.LateSetComplex(object_0, type_0, string_0, object_1, string_1, type_1, bool_0, bool_1);
	}

	internal static string F6ODWxg3(object object_0, int int_0)
	{
		return (int_0 ^ 0x5943) switch
		{
			_ => Conversions.ToString(object_0), 
		};
	}
}
