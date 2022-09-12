public class GClass4
{
	private uint uint_0;

	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ uint_0;
		uint_0 = GClass5.smethod_0(uint_0, 7) ^ num;
		return num;
	}

	public GClass4()
	{
		uint_0 = 2021418999u;
	}
}
