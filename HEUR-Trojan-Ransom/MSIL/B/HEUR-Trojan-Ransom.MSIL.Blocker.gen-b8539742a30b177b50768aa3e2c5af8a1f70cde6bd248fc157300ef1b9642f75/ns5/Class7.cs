using System;
using System.Text;
using ns2;
using ns6;

namespace ns5;

internal class Class7
{
	private static string[] string_0 = new string[0];

	private static uint uint_0 = 0u;

	public static void smethod_0(Class8.Struct1 struct1_0)
	{
		string @string = Encoding.Default.GetString(struct1_0.byte_0);
		char[] trimChars = new char[1];
		string[] array = @string.Trim(trimChars).Split(new char[1] { '*' }, StringSplitOptions.RemoveEmptyEntries);
		if (Class13.pS != struct1_0.uint_0 && struct1_0.uint_0 != 0 && Class13.pS != 0)
		{
			Class8.smethod_6();
		}
		else if (!smethod_1(string_0, array) || uint_0 != struct1_0.uint_1)
		{
			string_0 = array;
			uint_0 = struct1_0.uint_1;
			switch (struct1_0.uint_1)
			{
			default:
				Class8.smethod_2();
				break;
			case 1u:
				Class2.smethod_1();
				break;
			case 2u:
				VG.smethod_7(Convert.ToString(array[0]));
				break;
			case 3u:
				VG.smethod_5(Convert.ToString(array[0]));
				break;
			case 4u:
				Class2.smethod_0(Class2.Enum0.const_2, array);
				break;
			case 5u:
				Class2.smethod_0(Class2.Enum0.const_1, array);
				break;
			case 6u:
				Class2.smethod_0(Class2.Enum0.const_0, array);
				break;
			}
		}
	}

	private static bool smethod_1(object[] object_0, object[] object_1)
	{
		if (object_0.Length != object_1.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < object_0.Length)
			{
				if (!object.Equals(object_0[num], object_1[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
