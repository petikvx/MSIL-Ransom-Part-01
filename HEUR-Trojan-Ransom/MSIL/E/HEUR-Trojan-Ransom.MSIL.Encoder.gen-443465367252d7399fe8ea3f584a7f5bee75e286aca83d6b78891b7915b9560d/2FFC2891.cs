using System.IO;

public class _2FFC2891
{
	private byte[] _01127147;

	private uint _0EFE5004;

	private uint _4EE51B15;

	private uint _6FF84927;

	private Stream _69882A4C;

	private uint _513B73ED = 1u;

	public uint _0BC9310C;

	public void _10A87990(uint _537B7CE7)
	{
		if (_4EE51B15 != _537B7CE7)
		{
			_01127147 = new byte[_537B7CE7];
		}
		_4EE51B15 = _537B7CE7;
		_0EFE5004 = 0u;
		_6FF84927 = 0u;
	}

	public void _573F4131(Stream _78273289, bool _06EF2748)
	{
		_55C94E63();
		_69882A4C = _78273289;
		if (!_06EF2748)
		{
			_6FF84927 = 0u;
			_0EFE5004 = 0u;
			_0BC9310C = 0u;
		}
	}

	public void _55C94E63()
	{
		_78635A2B();
		_69882A4C = null;
	}

	public void _78635A2B()
	{
		uint num = _0EFE5004 - _6FF84927;
		if (num != 0)
		{
			_69882A4C.Write(_01127147, (int)_6FF84927, (int)num);
			if (_0EFE5004 >= _4EE51B15)
			{
				_0EFE5004 = 0u;
			}
			_6FF84927 = _0EFE5004;
		}
	}

	public void _03E80E20(uint _350E28FF, uint _784F4024)
	{
		uint num = _0EFE5004 - _350E28FF - 1;
		if (num >= _4EE51B15)
		{
			num += _4EE51B15;
		}
		while (_784F4024 != 0)
		{
			if (num >= _4EE51B15)
			{
				num = 0u;
			}
			_01127147[_0EFE5004++] = _01127147[num++];
			if (_0EFE5004 >= _4EE51B15)
			{
				_78635A2B();
			}
			_784F4024--;
		}
	}

	public void _3B196B7C(byte _61C9021E)
	{
		_01127147[_0EFE5004++] = _61C9021E;
		if (_0EFE5004 >= _4EE51B15)
		{
			_78635A2B();
		}
	}

	public byte _25DA7FDA(uint _7F476384)
	{
		uint num = _0EFE5004 - _7F476384 - 1;
		if (num >= _4EE51B15)
		{
			num += _4EE51B15;
		}
		return _01127147[num];
	}
}
