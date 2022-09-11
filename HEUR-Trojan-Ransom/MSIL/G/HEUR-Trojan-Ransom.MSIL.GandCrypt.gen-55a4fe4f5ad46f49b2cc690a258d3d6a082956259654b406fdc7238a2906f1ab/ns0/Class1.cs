namespace ns0;

internal sealed class Class1
{
	internal static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = Class5.smethod_3(byte_0, byte_1, i);
		}
	}

	public void method_0(string string_0, int int_0, int int_1)
	{
		if (method_1())
		{
			smethod_1(7, string_0, int_0, int_1);
		}
	}

	public bool method_1()
	{
		return false;
	}

	private static void smethod_1(int int_0, string string_0, int int_1, int int_2)
	{
	}
}
