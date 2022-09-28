public class _2C3D1292
{
	public const int _31C02FA2 = 32;

	public static uint _46584D64(uint _0FCA513C, int _76EB7C7D)
	{
		uint num = _0FCA513C << _76EB7C7D;
		uint num2 = _0FCA513C >> 32 - _76EB7C7D;
		return num | num2;
	}

	public static uint _0D165BB0(uint _29D841C4, int _4B7865A6)
	{
		uint num = _29D841C4 >> _4B7865A6;
		uint num2 = _29D841C4 << 32 - _4B7865A6;
		return num | num2;
	}

	public static uint _6242651D(uint _2E2B189B)
	{
		uint num = _2E2B189B & 0xFF00FFu;
		uint num2 = _2E2B189B & 0xFF00FF00u;
		return ((num >> 8) | (num << 24)) + ((num2 << 8) | (num2 >> 24));
	}
}
