public class GClass2
{
	private uint uint_0;

	public GClass2()
	{
		uint_0 = 1108489216u;
	}

	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ uint_0;
		uint_0 = GClass3.smethod_0(uint_0, 7) ^ num;
		return num;
	}
}
