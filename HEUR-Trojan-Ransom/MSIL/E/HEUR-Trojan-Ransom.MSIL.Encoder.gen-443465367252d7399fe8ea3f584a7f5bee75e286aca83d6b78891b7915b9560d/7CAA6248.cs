using System;
using System.IO;

public class _7CAA6248
{
	private class _2DCD6103
	{
		private _28017652 _4A151368;

		private _28017652 _6DFF2C38;

		private readonly _61C15ECC[] _72831BEE = new _61C15ECC[16];

		private readonly _61C15ECC[] _6D340980 = new _61C15ECC[16];

		private _61C15ECC _5A353578 = new _61C15ECC(8);

		private uint _40F9764E;

		public void _7E7F63DE(uint _6BE56316)
		{
			for (uint num = _40F9764E; num < _6BE56316; num++)
			{
				_72831BEE[num] = new _61C15ECC(3);
				_6D340980[num] = new _61C15ECC(3);
			}
			_40F9764E = _6BE56316;
		}

		public void _10BB6FED()
		{
			_4A151368._6D315CCB();
			for (uint num = 0u; num < _40F9764E; num++)
			{
				_72831BEE[num]._239C5706();
				_6D340980[num]._239C5706();
			}
			_6DFF2C38._6D315CCB();
			_5A353578._239C5706();
		}

		public uint _6AE8126F(_1C435DF5 _57B67C6F, uint _12EA5C34)
		{
			if (_4A151368._6446122F(_57B67C6F) == 0)
			{
				return _72831BEE[_12EA5C34]._56276FD6(_57B67C6F);
			}
			uint num = 8u;
			if (_6DFF2C38._6446122F(_57B67C6F) == 0)
			{
				return num + _6D340980[_12EA5C34]._56276FD6(_57B67C6F);
			}
			num += 8;
			return num + _5A353578._56276FD6(_57B67C6F);
		}
	}

	private class _7FB7146E
	{
		private struct _0859517C
		{
			private _28017652[] _58B27ADA;

			public void _5E1E1DC6()
			{
				_58B27ADA = new _28017652[768];
			}

			public void _15171779()
			{
				for (int i = 0; i < 768; i++)
				{
					_58B27ADA[i]._6D315CCB();
				}
			}

			public byte _75C40F3D(_1C435DF5 _71C85A13)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | _58B27ADA[num]._6446122F(_71C85A13);
				}
				while (num < 256);
				return (byte)num;
			}

			public byte _37AF69F4(_1C435DF5 _4ECF20F5, byte _2DE57FA2)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)(_2DE57FA2 >> 7) & 1u;
					_2DE57FA2 = (byte)(_2DE57FA2 << 1);
					uint num3 = _58B27ADA[(1 + num2 << 8) + num]._6446122F(_4ECF20F5);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | _58B27ADA[num]._6446122F(_4ECF20F5);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}
		}

		private uint _61A73E61 = 1u;

		private _0859517C[] _336736EA;

		private int _380D374D;

		private int _00872319;

		private uint _071564B8;

		public void _7BE06B79(int _094D6AF2, int _29483022)
		{
			if (_336736EA == null || _380D374D != _29483022 || _00872319 != _094D6AF2)
			{
				_00872319 = _094D6AF2;
				_071564B8 = (uint)((1 << _094D6AF2) - 1);
				_380D374D = _29483022;
				uint num = (uint)(1 << _380D374D + _00872319);
				_336736EA = new _0859517C[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					_336736EA[num2]._5E1E1DC6();
				}
			}
		}

		public void _26D42283()
		{
			uint num = (uint)(1 << _380D374D + _00872319);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				_336736EA[num2]._15171779();
			}
		}

		private uint _01A41B62(uint _52F40D8E, byte _59041783)
		{
			return ((_52F40D8E & _071564B8) << _380D374D) + (uint)(_59041783 >> 8 - _380D374D);
		}

		public byte _5FB57945(_1C435DF5 _01517C32, uint _2A1E2E60, byte _7A7E42A7)
		{
			return _336736EA[_01A41B62(_2A1E2E60, _7A7E42A7)]._75C40F3D(_01517C32);
		}

		public byte _676B612A(_1C435DF5 _7F107BD8, uint _5D672734, byte _5BD42F90, byte _287346B3)
		{
			return _336736EA[_01A41B62(_5D672734, _5BD42F90)]._37AF69F4(_7F107BD8, _287346B3);
		}
	}

	private uint _68A61D53 = 1u;

	private readonly _2FFC2891 _563D3CDF = new _2FFC2891();

	private readonly _1C435DF5 _52487DD3 = new _1C435DF5();

	private readonly _28017652[] _20D14C26 = new _28017652[192];

	private readonly _28017652[] _3DA33D69 = new _28017652[12];

	private readonly _28017652[] _75554C0F = new _28017652[12];

	private readonly _28017652[] _1FD66250 = new _28017652[12];

	private readonly _28017652[] _506458D0 = new _28017652[12];

	private readonly _28017652[] _2E066FA3 = new _28017652[192];

	private readonly _61C15ECC[] _01013C73 = new _61C15ECC[4];

	private readonly _28017652[] _24EA1ECE = new _28017652[114];

	private _61C15ECC _4C3913E4 = new _61C15ECC(4);

	private readonly _2DCD6103 _298D4D43 = new _2DCD6103();

	private readonly _2DCD6103 _74044A49 = new _2DCD6103();

	private readonly _7FB7146E _274F726E = new _7FB7146E();

	private uint _256D5E91;

	private uint _4F2D31EA;

	private uint _11F22750;

	public _7CAA6248()
	{
		_256D5E91 = uint.MaxValue;
		for (int i = 0; (long)i < 4L; i++)
		{
			_01013C73[i] = new _61C15ECC(6);
		}
	}

	private void _23BE2121(uint _4E2C2527)
	{
		if (_256D5E91 != _4E2C2527)
		{
			_256D5E91 = _4E2C2527;
			_4F2D31EA = Math.Max(_256D5E91, 1u);
			uint _537B7CE = Math.Max(_4F2D31EA, 4096u);
			_563D3CDF._10A87990(_537B7CE);
		}
	}

	private void _59997C7B(int _6C4B6DD0, int _72DF5B8C)
	{
		if (_6C4B6DD0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (_72DF5B8C > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		_274F726E._7BE06B79(_6C4B6DD0, _72DF5B8C);
	}

	private void _54645AAB(int _3BED05BE)
	{
		if (_3BED05BE > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = (uint)(1 << _3BED05BE);
		_298D4D43._7E7F63DE(num);
		_74044A49._7E7F63DE(num);
		_11F22750 = num - 1;
	}

	private void _6EC70ACD(Stream _78DB3986, Stream _466E1C2B)
	{
		_52487DD3._382E08CA(_78DB3986);
		_563D3CDF._573F4131(_466E1C2B, _06EF2748: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= _11F22750; num2++)
			{
				uint num3 = (num << 4) + num2;
				_20D14C26[num3]._6D315CCB();
				_2E066FA3[num3]._6D315CCB();
			}
			_3DA33D69[num]._6D315CCB();
			_75554C0F[num]._6D315CCB();
			_1FD66250[num]._6D315CCB();
			_506458D0[num]._6D315CCB();
		}
		_274F726E._26D42283();
		for (uint num = 0u; num < 4; num++)
		{
			_01013C73[num]._239C5706();
		}
		for (uint num = 0u; num < 114; num++)
		{
			_24EA1ECE[num]._6D315CCB();
		}
		_298D4D43._10BB6FED();
		_74044A49._10BB6FED();
		_4C3913E4._239C5706();
	}

	public void _06185CCF(Stream _2A020606, Stream _094E01AB, long _796A7958)
	{
		_6EC70ACD(_2A020606, _094E01AB);
		_5BB924E7._7EED3C28 _7EED3C = default(_5BB924E7._7EED3C28);
		_7EED3C._48811E8E();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (num5 < (ulong)_796A7958)
		{
			if (_20D14C26[_7EED3C._767B08AB << 4]._6446122F(_52487DD3) != 0)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			_7EED3C._158E45C5();
			byte _61C9021E = _274F726E._5FB57945(_52487DD3, 0u, 0);
			_563D3CDF._3B196B7C(_61C9021E);
			num5++;
		}
		while (num5 < (ulong)_796A7958)
		{
			uint num6 = (uint)(int)num5 & _11F22750;
			if (_20D14C26[(_7EED3C._767B08AB << 4) + num6]._6446122F(_52487DD3) == 0)
			{
				byte b = _563D3CDF._25DA7FDA(0u);
				byte _61C9021E2 = (_7EED3C._721169E8() ? _274F726E._5FB57945(_52487DD3, (uint)num5, b) : _274F726E._676B612A(_52487DD3, (uint)num5, b, _563D3CDF._25DA7FDA(num)));
				_563D3CDF._3B196B7C(_61C9021E2);
				_7EED3C._158E45C5();
				num5++;
				continue;
			}
			uint num8;
			if (_3DA33D69[_7EED3C._767B08AB]._6446122F(_52487DD3) == 1)
			{
				if (_75554C0F[_7EED3C._767B08AB]._6446122F(_52487DD3) == 0)
				{
					if (_2E066FA3[(_7EED3C._767B08AB << 4) + num6]._6446122F(_52487DD3) == 0)
					{
						_7EED3C._052562EB();
						_563D3CDF._3B196B7C(_563D3CDF._25DA7FDA(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (_1FD66250[_7EED3C._767B08AB]._6446122F(_52487DD3) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (_506458D0[_7EED3C._767B08AB]._6446122F(_52487DD3) == 0)
						{
							num7 = num3;
						}
						else
						{
							num7 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num7;
				}
				num8 = _74044A49._6AE8126F(_52487DD3, num6) + 2;
				_7EED3C._3A4C01BE();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + _298D4D43._6AE8126F(_52487DD3, num6);
				_7EED3C._336D75C2();
				uint num9 = _01013C73[_5BB924E7._6C960412(num8)]._56276FD6(_52487DD3);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += _61C15ECC._29CF53AA(_24EA1ECE, num - num9 - 1, _52487DD3, num10);
					}
					else
					{
						num += _52487DD3._1FB5514D(num10 - 4) << 4;
						num += _4C3913E4._74037086(_52487DD3);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num >= _563D3CDF._0BC9310C + num5 || num >= _4F2D31EA)
			{
				if (num == uint.MaxValue)
				{
					break;
				}
				throw new InvalidDataException("rep0");
			}
			_563D3CDF._03E80E20(num, num8);
			num5 += num8;
		}
		_563D3CDF._78635A2B();
		_563D3CDF._55C94E63();
		_52487DD3._018F7E21();
	}

	public void _1AD70668(byte[] _66FB2CFC)
	{
		if (_66FB2CFC.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int _72DF5B8C = (int)_66FB2CFC[0] % 9;
		int num = (int)_66FB2CFC[0] / 9;
		int _6C4B6DD = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(_66FB2CFC[1 + i] << i * 8);
		}
		_23BE2121(num3);
		_59997C7B(_6C4B6DD, _72DF5B8C);
		_54645AAB(num2);
	}
}
