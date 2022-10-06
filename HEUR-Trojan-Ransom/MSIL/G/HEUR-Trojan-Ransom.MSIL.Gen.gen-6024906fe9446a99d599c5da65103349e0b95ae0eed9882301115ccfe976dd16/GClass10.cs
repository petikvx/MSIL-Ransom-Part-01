public class GClass10
{
	private uint uint_0;

	public GClass10()
	{
		uint_0 = 1229266895u;
	}

	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ uint_0;
		uint_0 = GClass11.smethod_0(uint_0, 7) ^ num;
		return num;
	}
}
