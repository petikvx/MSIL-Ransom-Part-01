internal abstract class _5BB924E7
{
	public struct _7EED3C28
	{
		public uint _767B08AB;

		public void _48811E8E()
		{
			_767B08AB = 0u;
		}

		public void _158E45C5()
		{
			if (_767B08AB < 4)
			{
				_767B08AB = 0u;
			}
			else if (_767B08AB < 10)
			{
				_767B08AB -= 3u;
			}
			else
			{
				_767B08AB -= 6u;
			}
		}

		public void _336D75C2()
		{
			_767B08AB = ((_767B08AB < 7) ? 7u : 10u);
		}

		public void _3A4C01BE()
		{
			_767B08AB = ((_767B08AB < 7) ? 8u : 11u);
		}

		public void _052562EB()
		{
			_767B08AB = ((_767B08AB < 7) ? 9u : 11u);
		}

		public bool _721169E8()
		{
			return _767B08AB < 7;
		}
	}

	public const uint _4E31274C = 12u;

	public const int _65EB6CEC = 6;

	private const int _6D3D527E = 2;

	public const uint _3D8F0395 = 4u;

	public const uint _54C60C97 = 2u;

	public const int _636422ED = 4;

	public const uint _1C743BB0 = 4u;

	public const uint _5DF44CEB = 14u;

	public const uint _3DAF359D = 128u;

	public const int _25926B25 = 4;

	public const uint _44063EC2 = 16u;

	public const int _77E06444 = 3;

	public const int _5CD26B28 = 3;

	public const int _049425B5 = 8;

	public const uint _0A1615D1 = 8u;

	public const uint _577B75A2 = 8u;

	public static uint _6C960412(uint _29780F64)
	{
		_29780F64 -= 2;
		if (_29780F64 < 4)
		{
			return _29780F64;
		}
		return 3u;
	}
}
