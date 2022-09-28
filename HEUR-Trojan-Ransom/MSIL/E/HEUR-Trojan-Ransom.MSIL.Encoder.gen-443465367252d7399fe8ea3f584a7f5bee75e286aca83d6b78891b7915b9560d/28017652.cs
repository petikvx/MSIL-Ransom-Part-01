internal struct _28017652
{
	private const int _0F805376 = 11;

	private const uint _0B5E0FF9 = 2048u;

	private const int _16243CE0 = 5;

	private uint _7D643C61;

	public void _6D315CCB()
	{
		_7D643C61 = 1024u;
	}

	public uint _6446122F(_1C435DF5 _25DB134E)
	{
		uint num = (_25DB134E._5B141704 >> 11) * _7D643C61;
		if (_25DB134E._05792C7C < num)
		{
			_25DB134E._5B141704 = num;
			_7D643C61 += 2048 - _7D643C61 >> 5;
			if (_25DB134E._5B141704 < 16777216)
			{
				_25DB134E._05792C7C = (_25DB134E._05792C7C << 8) | (byte)_25DB134E._14BC66D2.ReadByte();
				_25DB134E._5B141704 <<= 8;
			}
			return 0u;
		}
		_25DB134E._5B141704 -= num;
		_25DB134E._05792C7C -= num;
		_7D643C61 -= _7D643C61 >> 5;
		if (_25DB134E._5B141704 < 16777216)
		{
			_25DB134E._05792C7C = (_25DB134E._05792C7C << 8) | (byte)_25DB134E._14BC66D2.ReadByte();
			_25DB134E._5B141704 <<= 8;
		}
		return 1u;
	}
}
