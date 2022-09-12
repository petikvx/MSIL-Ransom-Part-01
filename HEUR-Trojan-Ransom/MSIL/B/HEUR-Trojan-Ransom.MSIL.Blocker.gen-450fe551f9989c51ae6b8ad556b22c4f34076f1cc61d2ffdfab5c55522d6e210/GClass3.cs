public class GClass3
{
	private static uint[] uint_0;

	public unsafe uint method_0(long long_0, uint uint_1)
	{
		uint num = 0u;
		for (int i = 0; i < uint_1; i++)
		{
			num = uint_0[(*(byte*)(long_0 + i) ^ num) & 0xFF] ^ (num >> 8);
		}
		return ~num;
	}

	public GClass3()
	{
		if (uint_0 != null)
		{
			return;
		}
		uint_0 = new uint[256];
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			uint_0[i] = num;
		}
	}
}
