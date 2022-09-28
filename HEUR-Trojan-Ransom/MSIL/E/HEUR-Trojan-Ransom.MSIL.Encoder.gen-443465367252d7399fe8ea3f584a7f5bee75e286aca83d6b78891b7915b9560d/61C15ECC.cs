internal struct _61C15ECC
{
	private readonly _28017652[] _25AF5CFB;

	private readonly int _6CA04CC7;

	public _61C15ECC(int _6E624910)
	{
		_6CA04CC7 = _6E624910;
		_25AF5CFB = new _28017652[1 << _6E624910];
	}

	public void _239C5706()
	{
		for (uint num = 1u; num < 1 << _6CA04CC7; num++)
		{
			_25AF5CFB[num]._6D315CCB();
		}
	}

	public uint _56276FD6(_1C435DF5 _1D77041B)
	{
		uint num = 1u;
		for (int num2 = _6CA04CC7; num2 > 0; num2--)
		{
			num = (num << 1) + _25AF5CFB[num]._6446122F(_1D77041B);
		}
		return num - (uint)(1 << _6CA04CC7);
	}

	public uint _74037086(_1C435DF5 _3117221C)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < _6CA04CC7; i++)
		{
			uint num3 = _25AF5CFB[num]._6446122F(_3117221C);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint _29CF53AA(_28017652[] _570D106F, uint _4B195859, _1C435DF5 _63CE26FD, int _6F3759E7)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < _6F3759E7; i++)
		{
			uint num3 = _570D106F[_4B195859 + num]._6446122F(_63CE26FD);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
