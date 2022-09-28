using System;
using System.Runtime.InteropServices;

public class _1585204C
{
	private static uint[] _26D47C4B;

	public _1585204C()
	{
		if (_26D47C4B != null)
		{
			return;
		}
		_26D47C4B = new uint[256];
		for (int i = 0; i < 256; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			_26D47C4B[i] = num;
		}
	}

	public uint _41D968BA(IntPtr _1DEE5B7C, uint _3B4102D7)
	{
		uint num = 0u;
		for (int i = 0; i < _3B4102D7; i++)
		{
			num = _26D47C4B[(Marshal.ReadByte(new IntPtr(_1DEE5B7C.ToInt64() + i)) ^ num) & 0xFF] ^ (num >> 8);
		}
		return ~num;
	}
}
