public class _628E3B04
{
	private uint _27F84C63;

	public _628E3B04()
	{
		_27F84C63 = 474447289u;
	}

	public uint _125822E8(uint _43836904)
	{
		uint num = _43836904 ^ _27F84C63;
		_27F84C63 = _2C3D1292._46584D64(_27F84C63, 7) ^ num;
		return num;
	}
}
