namespace ns0;

internal sealed class Class6
{
	public static readonly uint[] uint_0;

	internal uint uint_1 = uint.MaxValue;

	static Class6()
	{
		uint_0 = new uint[256];
		for (uint num = 0u; num < 256; num++)
		{
			uint num2 = num;
			for (int i = 0; i < 8; i++)
			{
				num2 = (((num2 & 1) == 0) ? (num2 >> 1) : ((num2 >> 1) ^ 0xEDB88320u));
			}
			uint_0[num] = num2;
		}
	}

	public Class6()
	{
		Class5.smethod_11();
	}
}
