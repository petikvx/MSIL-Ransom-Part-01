public class GClass1
{
	private uint uint_0;

	public GClass1()
	{
		uint_0 = 1507395093u;
	}

	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ uint_0;
		uint_0 = GClass2.smethod_0(uint_0, 7) ^ num;
		return num;
	}
}
