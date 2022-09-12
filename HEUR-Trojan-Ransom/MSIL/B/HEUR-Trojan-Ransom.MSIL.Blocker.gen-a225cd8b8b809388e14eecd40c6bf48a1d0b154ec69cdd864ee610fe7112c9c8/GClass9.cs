public class GClass9
{
	public const int int_0 = 32;

	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	public static uint smethod_1(uint uint_0, int int_1)
	{
		uint num = uint_0 >> int_1;
		uint num2 = uint_0 << 32 - int_1;
		return num | num2;
	}

	public static uint smethod_2(uint uint_0)
	{
		uint num = uint_0 & 0xFF00FFu;
		uint num2 = uint_0 & 0xFF00FF00u;
		return ((num >> 8) | (num << 24)) + ((num2 << 8) | (num2 >> 24));
	}
}
