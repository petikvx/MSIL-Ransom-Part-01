using ns6;

namespace ns2;

internal class Class15
{
	internal static string smethod_0(string string_0, int int_0)
	{
		char[] array = Class20.smethod_18(string_0, 60655);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(array[i] ^ int_0);
		}
		return new string(array);
	}
}
