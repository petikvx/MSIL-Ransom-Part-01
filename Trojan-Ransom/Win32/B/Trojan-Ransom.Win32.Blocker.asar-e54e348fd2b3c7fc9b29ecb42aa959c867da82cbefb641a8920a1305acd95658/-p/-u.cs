using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace _0023p;

internal class _0023u
{
	internal sealed class _0023y
	{
		private static readonly int[] _0023fE;

		private static readonly int[] _0023gE;

		private static readonly int[] _0023hE;

		private static readonly int[] _0023iE;

		private int _0023jE;

		private int _0023kE;

		private int _0023lE;

		private int _0023mE;

		private int _0023nE;

		private bool _0023oE;

		private _0023H _0023gv;

		private _0023P _0023P;

		private _0023V _0023pE;

		private _0023S _0023qE;

		private _0023S _0023rE;

		public _0023y(byte[] P_0)
		{
			_0023gv = new _0023H();
			_0023P = new _0023P();
			_0023jE = 2;
			_0023gv._0023G(P_0, 0, P_0.Length);
		}

		private bool _0023v()
		{
			int num = _0023P._0023M();
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = num;
			}
			int num8 = default(int);
			int num13 = default(int);
			while (true)
			{
				int num3 = num2;
				int num4 = 258;
				while (true)
				{
					if (num3 >= num4)
					{
						while (true)
						{
							int num5 = _0023jE;
							int num6;
							if (2u != 0)
							{
								num6 = num5;
							}
							num3 = num6;
							num4 = 7;
							if (num4 == 0)
							{
								break;
							}
							switch (num3 - num4)
							{
							case 0:
								while (true)
								{
									int num7 = _0023qE._0023R(_0023gv);
									if (0 == 0)
									{
										num8 = num7;
									}
									if (((uint)num7 & 0xFFFFFF00u) != 0)
									{
										if (num8 >= 257)
										{
											break;
										}
										if (0 == 0)
										{
											goto IL_0097;
										}
									}
									_0023P obj = _0023P;
									int num9 = num8;
									if (0 == 0)
									{
										obj._0023I(num9);
									}
									int num10 = num2 - 1;
									if (0 == 0)
									{
										num2 = num10;
									}
									if (num10 < 258)
									{
										return true;
									}
								}
								_0023lE = _0023fE[num8 - 257];
								_0023kE = _0023gE[num8 - 257];
								goto case 1;
							case 1:
								if (_0023kE > 0)
								{
									_0023jE = 8;
									int num12 = _0023gv._0023z(_0023kE);
									if (0 == 0)
									{
										num13 = num12;
									}
									if (num13 < 0)
									{
										return false;
									}
									_0023gv._0023A(_0023kE);
									_0023lE += num13;
								}
								_0023jE = 9;
								goto case 2;
							case 2:
								num8 = _0023rE._0023R(_0023gv);
								if (num8 < 0)
								{
									return false;
								}
								_0023mE = _0023hE[num8];
								_0023kE = _0023iE[num8];
								goto case 3;
							case 3:
								{
									if (_0023kE > 0)
									{
										_0023jE = 10;
										int num11 = _0023gv._0023z(_0023kE);
										if (num11 < 0)
										{
											return false;
										}
										_0023gv._0023A(_0023kE);
										_0023mE += num11;
									}
									_0023P._0023K(_0023lE, _0023mE);
									num2 -= _0023lE;
									_0023jE = 7;
									break;
								}
								IL_0097:
								if (num8 < 0)
								{
									return false;
								}
								goto IL_009d;
							}
							goto end_IL_01dc;
							IL_009d:
							_0023rE = null;
							_0023qE = null;
							if (0 == 0)
							{
								_0023jE = 2;
								return true;
							}
						}
						continue;
					}
					return true;
					continue;
					end_IL_01dc:
					break;
				}
			}
		}

		private bool _0023w()
		{
			int num2;
			int num10;
			while (0 == 0)
			{
				int num = _0023jE;
				if (uint.MaxValue != 0)
				{
					num2 = num;
				}
				if (8 == 0)
				{
					continue;
				}
				int num4;
				int num5;
				int num3;
				switch (num2)
				{
				case 2:
					break;
				case 3:
				{
					int num7 = _0023gv._0023z(16);
					if (4u != 0)
					{
						num2 = num7;
					}
					_0023nE = num7;
					num4 = num2;
					num5 = 0;
					if (num5 == 0)
					{
						if (num4 < num5)
						{
							return false;
						}
						_0023gv._0023A(16);
						_0023jE = 4;
						goto case 4;
					}
					goto IL_0144;
				}
				case 4:
				{
					int num8 = _0023gv._0023z(16);
					num4 = num8;
					num5 = 0;
					goto IL_0144;
				}
				case 5:
				{
					int num6 = _0023P._0023L(_0023gv, _0023nE);
					_0023nE -= num6;
					if (_0023nE == 0)
					{
						_0023jE = 2;
						num3 = 1;
						goto IL_0192;
					}
					return !_0023gv._0023E();
				}
				case 6:
					if (!_0023pE._0023w(_0023gv))
					{
						return false;
					}
					_0023qE = _0023pE._0023T();
					_0023rE = _0023pE._0023U();
					_0023jE = 7;
					goto case 7;
				case 7:
				case 8:
				case 9:
				case 10:
					return _0023v();
				case 12:
					return false;
				default:
					{
						num3 = 0;
						if (num3 == 0)
						{
							return (byte)num3 != 0;
						}
						goto IL_0192;
					}
					IL_0192:
					return (byte)num3 != 0;
					IL_0144:
					if (num4 < num5)
					{
						return false;
					}
					_0023gv._0023A(16);
					_0023jE = 5;
					goto case 5;
				}
				if (_0023oE)
				{
					_0023jE = 12;
					return false;
				}
				int num9 = _0023gv._0023z(3);
				if (5u != 0)
				{
					num10 = num9;
				}
				break;
			}
			if (num10 < 0)
			{
				return false;
			}
			while (true)
			{
				_0023H _0023H = _0023gv;
				if (5u != 0)
				{
					_0023H._0023A(3);
				}
				if (((uint)num10 & (true ? 1u : 0u)) != 0)
				{
					_0023oE = true;
				}
				int num11 = num10 >> 1;
				if (0 == 0)
				{
					num2 = num11;
				}
				switch (num2)
				{
				case 0:
				{
					_0023H _0023H2 = _0023gv;
					if (uint.MaxValue != 0)
					{
						_0023H2._0023D();
					}
					_0023jE = 3;
					break;
				}
				case 1:
					_0023qE = _0023S._0023yE;
					_0023rE = _0023S._0023zE;
					_0023jE = 7;
					break;
				case 2:
					goto IL_00e5;
				}
				break;
				IL_00e5:
				if (3u != 0)
				{
					_0023pE = new _0023V();
					_0023jE = 6;
					break;
				}
			}
			return true;
		}

		public int _0023x(byte[] P_0, int P_1, int P_2)
		{
			int num;
			int num2 = default(int);
			if (0 == 0)
			{
				num = 0;
				if (num == 0)
				{
					if (0 == 0)
					{
						num2 = num;
					}
					goto IL_000b;
				}
				goto IL_002b;
			}
			goto IL_0031;
			IL_005a:
			int num3;
			if (num3 <= 0 || _0023jE == 11)
			{
				return num2;
			}
			goto IL_000b;
			IL_002b:
			int num4 = default(int);
			int num5 = num4;
			goto IL_002c;
			IL_000b:
			num = _0023jE;
			num5 = 11;
			if (num5 == 0)
			{
				goto IL_002c;
			}
			if (num != num5)
			{
				int num6 = _0023P._0023O(P_0, P_1, P_2);
				if (0 == 0)
				{
					num4 = num6;
				}
				num = P_1;
				goto IL_002b;
			}
			goto IL_0047;
			IL_0031:
			num3 = num2;
			if (5u != 0)
			{
				int num7 = num3 + num4;
				if (0 == 0)
				{
					num2 = num7;
				}
				int num8 = P_2 - num4;
				if (2u != 0)
				{
					P_2 = num8;
				}
				if (P_2 == 0)
				{
					return num2;
				}
				goto IL_0047;
			}
			goto IL_005a;
			IL_0047:
			if (_0023w())
			{
				goto IL_000b;
			}
			num3 = _0023P._0023N();
			goto IL_005a;
			IL_002c:
			int num9 = num + num5;
			if (0 == 0)
			{
				P_1 = num9;
			}
			goto IL_0031;
		}

		static _0023y()
		{
			do
			{
				int num = 29;
				while (true)
				{
					int[] array = new int[num];
					if (0 == 0)
					{
						RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_0023fE = array;
					if (false)
					{
						break;
					}
					int[] array2 = new int[29];
					if (4u != 0)
					{
						RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_0023gE = array2;
					int[] array3 = new int[30];
					if (0 == 0)
					{
						RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_0023hE = array3;
					num = 30;
					if (num != 0)
					{
						int[] array4 = new int[num];
						if (3u != 0)
						{
							RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						}
						_0023iE = array4;
						break;
					}
				}
			}
			while (false);
		}
	}

	internal sealed class _0023H
	{
		private byte[] _0023sE;

		private int _0023tE = 0;

		private int _0023uE = 0;

		private uint _0023Hv = 0u;

		private int _0023vE = 0;

		public int _0023z(int P_0)
		{
			if (_0023vE < P_0)
			{
				if (_0023tE == _0023uE)
				{
					if (0 == 0)
					{
						return -1;
					}
				}
				else
				{
					uint num = _0023Hv;
					byte[] array = _0023sE;
					int num2 = _0023tE;
					int num3;
					if (5u != 0)
					{
						num3 = num2;
					}
					_0023tE = num2 + 1;
					int num4 = array[num3] & 0xFF;
					byte[] array2 = _0023sE;
					int num5 = _0023tE;
					if (0 == 0)
					{
						num3 = num5;
					}
					_0023tE = num5 + 1;
					_0023Hv = num | (uint)((num4 | ((array2[num3] & 0xFF) << 8)) << _0023vE);
					_0023vE += 16;
				}
			}
			long num6 = _0023Hv;
			int num7 = 1;
			while (true)
			{
				int num8;
				if (0 == 0)
				{
					num7 <<= P_0;
					if (false)
					{
						break;
					}
				}
				else if (num8 == 0)
				{
					continue;
				}
				num7--;
				break;
			}
			return (int)(num6 & num7);
		}

		public void _0023A(int P_0)
		{
			while (true)
			{
				_0023Hv >>= P_0;
				while (0 == 0)
				{
					_0023vE -= P_0;
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		[SpecialName]
		public int _0023B()
		{
			return _0023vE;
		}

		[SpecialName]
		public int _0023C()
		{
			int num = _0023uE;
			int num2;
			while (true)
			{
				num2 = _0023tE;
				if (false)
				{
					break;
				}
				num -= num2;
				if (0 == 0)
				{
					num2 = _0023vE;
					break;
				}
			}
			do
			{
				num2 >>= 3;
			}
			while (false);
			return num + num2;
		}

		public void _0023D()
		{
			_0023Hv >>= _0023vE & 7;
			_0023vE &= -8;
		}

		[SpecialName]
		public bool _0023E()
		{
			return _0023tE == _0023uE;
		}

		public int _0023F(byte[] P_0, int P_1, int P_2)
		{
			int num = 0;
			int num2 = default(int);
			while (true)
			{
				if (0 == 0)
				{
					num2 = num;
				}
				while (true)
				{
					int num3 = _0023vE;
					int num8;
					if (5u != 0)
					{
						if (num3 > 0)
						{
							num = P_2;
							if (false)
							{
								break;
							}
							if (num > 0)
							{
								int num4 = P_1;
								int num5 = num4 + 1;
								if (0 == 0)
								{
									P_1 = num5;
								}
								P_0[num4] = (byte)_0023Hv;
								goto IL_001e;
							}
						}
						if (P_2 != 0)
						{
							int num6 = _0023uE - _0023tE;
							int num7;
							if (7u != 0)
							{
								num7 = num6;
							}
							if (P_2 > num7)
							{
								if (0 == 0)
								{
									P_2 = num7;
								}
							}
							Array.Copy(_0023sE, _0023tE, P_0, P_1, P_2);
							_0023tE += P_2;
							if (((uint)(_0023tE - _0023uE) & (true ? 1u : 0u)) != 0)
							{
								_0023Hv = _0023sE[_0023tE++] & 0xFFu;
								_0023vE = 8;
							}
							if (8 == 0)
							{
								goto IL_001e;
							}
							if (0 == 0)
							{
								num8 = num2;
								if (8 == 0)
								{
									goto IL_0068;
								}
								num3 = num8 + P_2;
								goto IL_00fc;
							}
						}
						num8 = num2;
						goto IL_0068;
					}
					goto IL_00fc;
					IL_001e:
					_0023Hv >>= 8;
					_0023vE -= 8;
					int num9 = P_2 - 1;
					if (0 == 0)
					{
						P_2 = num9;
					}
					int num10 = num2 + 1;
					if (5u != 0)
					{
						num2 = num10;
					}
					continue;
					IL_0068:
					return num8;
					IL_00fc:
					return num3;
				}
			}
		}

		public void _0023G(byte[] P_0, int P_1, int P_2)
		{
			int num2 = default(int);
			if (true)
			{
				if (_0023tE < _0023uE)
				{
					throw new InvalidOperationException();
				}
				int num = P_1 + P_2;
				if (0 == 0)
				{
					num2 = num;
				}
				if (0 > P_1 || P_1 > num2 || num2 > P_0.Length)
				{
					throw new ArgumentOutOfRangeException();
				}
				if ((P_2 & 1) == 0)
				{
					goto IL_006c;
				}
				uint num3 = _0023Hv;
				int num4 = P_1;
				int num5 = num4 + 1;
				if (uint.MaxValue != 0)
				{
					P_1 = num5;
				}
				_0023Hv = num3 | (uint)((P_0[num4] & 0xFF) << _0023vE);
			}
			_0023vE += 8;
			goto IL_006c;
			IL_006c:
			_0023sE = P_0;
			_0023tE = P_1;
			_0023uE = num2;
		}
	}

	internal sealed class _0023P
	{
		private byte[] _0023sE = new byte[32768];

		private int _0023wE = 0;

		private int _0023xE = 0;

		public void _0023I(int P_0)
		{
			while (true)
			{
				int num = _0023xE;
				int num2;
				if (3u != 0)
				{
					num2 = num;
				}
				_0023xE = num + 1;
				while (0 == 0)
				{
					if (num2 != 32768)
					{
						byte[] array = _0023sE;
						int num3 = _0023wE;
						if (6u != 0)
						{
							num2 = num3;
						}
						_0023wE = num3 + 1;
						array[num2] = (byte)P_0;
						if (0 == 0)
						{
							if (0 == 0)
							{
								_0023wE &= 32767;
								return;
							}
							continue;
						}
					}
					if (8 == 0)
					{
						break;
					}
					throw new InvalidOperationException();
				}
			}
		}

		private void _0023J(int P_0, int P_1, int P_2)
		{
			if (-1 == 0)
			{
				return;
			}
			int num4 = default(int);
			while (true)
			{
				int num = P_1;
				int num2 = num;
				do
				{
					num2--;
				}
				while (2 == 0);
				if (4u != 0)
				{
					P_1 = num2;
				}
				if (num > 0 && 5u != 0)
				{
					byte[] array = _0023sE;
					int num3 = _0023wE;
					if (0 == 0)
					{
						num4 = num3;
					}
					_0023wE = num3 + 1;
					int num5 = num4;
					byte[] array2 = _0023sE;
					int num6 = P_0;
					int num7 = num6 + 1;
					if (0 == 0)
					{
						P_0 = num7;
					}
					array[num5] = array2[num6];
					_0023wE &= 32767;
					int num8 = P_0;
					if (3u != 0)
					{
						num8 &= 0x7FFF;
					}
					if (7u != 0)
					{
						P_0 = num8;
					}
					continue;
				}
				break;
			}
		}

		public void _0023K(int P_0, int P_1)
		{
			int num = _0023xE + P_0;
			int num2;
			if (8u != 0)
			{
				num2 = num;
			}
			_0023xE = num;
			if (num2 > 32768)
			{
				throw new InvalidOperationException();
			}
			int num3 = (_0023wE - P_1) & 0x7FFF;
			int num4 = default(int);
			if (0 == 0)
			{
				num4 = num3;
			}
			int num5 = 32768 - P_0;
			int num6;
			if (2u != 0)
			{
				num6 = num5;
			}
			if (num4 <= num6 && _0023wE < num6)
			{
				if (P_0 <= P_1)
				{
					byte[] sourceArray = _0023sE;
					int sourceIndex = num4;
					byte[] destinationArray = _0023sE;
					int destinationIndex = _0023wE;
					int length = P_0;
					if (uint.MaxValue != 0)
					{
						Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
					}
					_0023wE += P_0;
					return;
				}
				while (P_0-- > 0)
				{
					byte[] array = _0023sE;
					int num7 = _0023wE;
					if (true)
					{
						num2 = num7;
					}
					_0023wE = num7 + 1;
					int num8 = num2;
					byte[] array2 = _0023sE;
					int num9 = num4;
					int num10 = num9 + 1;
					if (0 == 0)
					{
						num4 = num10;
					}
					array[num8] = array2[num9];
				}
			}
			else
			{
				_0023J(num4, P_0, P_1);
			}
		}

		public int _0023L(_0023H P_0, int P_1)
		{
			int val = P_1;
			if (0 == 0)
			{
				val = Math.Min(val, 32768 - _0023xE);
			}
			int num = Math.Min(val, P_0._0023C());
			do
			{
				if (3u != 0)
				{
					P_1 = num;
				}
				num = 32768;
			}
			while (num == 0);
			int num2 = num - _0023wE;
			int num3;
			if (4u != 0)
			{
				num3 = num2;
			}
			int num5 = default(int);
			do
			{
				if (P_1 > num3)
				{
					if (true)
					{
						int num4 = P_0._0023F(_0023sE, _0023wE, num3);
						if (0 == 0)
						{
							num5 = num4;
						}
						if (num5 != num3)
						{
							goto IL_008e;
						}
					}
					int num6 = num5 + P_0._0023F(_0023sE, 0, P_1 - num3);
					if (0 == 0)
					{
						num5 = num6;
					}
				}
				else
				{
					int num7 = P_0._0023F(_0023sE, _0023wE, P_1);
					if (7u != 0)
					{
						num5 = num7;
					}
				}
				goto IL_008e;
				IL_008e:
				_0023wE = (_0023wE + num5) & 0x7FFF;
			}
			while (false);
			_0023xE += num5;
			return num5;
		}

		public int _0023M()
		{
			return 32768 - _0023xE;
		}

		public int _0023N()
		{
			return _0023xE;
		}

		public int _0023O(byte[] P_0, int P_1, int P_2)
		{
			int num = _0023wE;
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = num;
			}
			int num4;
			int num5;
			if (P_2 > _0023xE)
			{
				int num3 = _0023xE;
				if (0 == 0)
				{
					P_2 = num3;
				}
			}
			else
			{
				num4 = _0023wE - _0023xE;
				num5 = P_2;
				if (false)
				{
					goto IL_0077;
				}
				int num6 = (num4 + num5) & 0x7FFF;
				if (7u != 0)
				{
					num2 = num6;
				}
			}
			goto IL_0041;
			IL_0075:
			num4 = P_1;
			int num7;
			num5 = num7;
			goto IL_0077;
			IL_0077:
			P_1 = num4 + num5;
			P_2 = num2;
			goto IL_007d;
			IL_0041:
			int num9;
			do
			{
				int num8 = P_2;
				if (2u != 0)
				{
					num9 = num8;
				}
			}
			while (3 == 0);
			int num10 = P_2 - num2;
			if (7u != 0)
			{
				num7 = num10;
			}
			while (num7 > 0)
			{
				byte[] sourceArray = _0023sE;
				int sourceIndex = 32768 - num7;
				int destinationIndex = P_1;
				if (7u != 0)
				{
					Array.Copy(sourceArray, sourceIndex, P_0, destinationIndex, num7);
				}
				if (false)
				{
					continue;
				}
				goto IL_0075;
			}
			goto IL_007d;
			IL_007d:
			Array.Copy(_0023sE, num2 - P_2, P_0, P_1, P_2);
			_0023xE -= num9;
			if (_0023xE < 0)
			{
				throw new InvalidOperationException();
			}
			if (3u != 0)
			{
				return num9;
			}
			goto IL_0041;
		}
	}

	internal sealed class _0023S
	{
		private short[] _00232k;

		public static readonly _0023S _0023yE;

		public static readonly _0023S _0023zE;

		static _0023S()
		{
			byte[] array = new byte[288];
			byte[] array2;
			if (6u != 0)
			{
				array2 = array;
			}
			int num;
			if (8u != 0)
			{
				num = 0;
			}
			if (uint.MaxValue != 0)
			{
				while (num < 144)
				{
					byte[] array3 = array2;
					int num2 = num;
					int num3 = num2 + 1;
					if (uint.MaxValue != 0)
					{
						num = num3;
					}
					array3[num2] = 8;
				}
				if (true)
				{
					while (num < 256)
					{
						byte[] array4 = array2;
						int num4 = num;
						int num5 = num4 + 1;
						if (3u != 0)
						{
							num = num5;
						}
						array4[num4] = 9;
					}
					goto IL_0060;
				}
				goto IL_0093;
			}
			goto IL_0078;
			IL_00a2:
			int num6;
			int num7;
			if (num6 >= num7)
			{
				if (8 == 0)
				{
					goto IL_0060;
				}
				_0023zE = new _0023S(array2);
				return;
			}
			array2[num++] = 5;
			goto IL_009f;
			IL_0078:
			while (num < 288)
			{
				byte[] array5 = array2;
				int num8 = num;
				int num9 = num8 + 1;
				if (0 == 0)
				{
					num = num9;
				}
				array5[num8] = 8;
			}
			_0023yE = new _0023S(array2);
			array2 = new byte[32];
			goto IL_0093;
			IL_0060:
			while (true)
			{
				num6 = num;
				num7 = 280;
				if (num7 == 0)
				{
					break;
				}
				if (num6 < num7)
				{
					byte[] array6 = array2;
					int num10 = num;
					int num11 = num10 + 1;
					if (0 == 0)
					{
						num = num11;
					}
					array6[num10] = 7;
					continue;
				}
				goto IL_0078;
			}
			goto IL_00a2;
			IL_009f:
			num6 = num;
			num7 = 32;
			goto IL_00a2;
			IL_0093:
			num = 0;
			goto IL_009f;
		}

		public _0023S(byte[] P_0)
		{
			_0023Q(P_0);
		}

		private void _0023Q(byte[] P_0)
		{
			int[] array = new int[16];
			int[] array2 = default(int[]);
			if (0 == 0)
			{
				array2 = array;
			}
			int[] array3 = new int[16];
			int[] array4 = default(int[]);
			if (0 == 0)
			{
				array4 = array3;
			}
			int num = default(int);
			if (0 == 0)
			{
				num = 0;
			}
			int num5 = default(int);
			int[] array6 = default(int[]);
			int num9 = default(int);
			int num10 = default(int);
			while (true)
			{
				int num2 = num;
				nint num3 = (nint)P_0.LongLength;
				if (6 == 0)
				{
					goto IL_007c;
				}
				if (num2 < (int)num3)
				{
					byte num4 = P_0[num];
					if (0 == 0)
					{
						num5 = num4;
					}
					if (num5 > 0)
					{
						int[] array5 = array2;
						if (0 == 0)
						{
							array6 = array5;
						}
						int num6 = num5;
						nint num7;
						if (uint.MaxValue != 0)
						{
							num7 = num6;
						}
						array5[num6] = array6[num7] + 1;
					}
					num++;
					continue;
				}
				int num8 = 0;
				num9 = 512;
				if (0 == 0)
				{
					num10 = 1;
					goto IL_00c3;
				}
				goto IL_01fc;
				IL_013f:
				int num11;
				int num12;
				int num13;
				int num14;
				int num15;
				int num16;
				if (num11 < num12)
				{
					_00232k[_0023X._0023W(num11)] = (short)((-num13 << 4) | num14);
					num2 = num13;
					num15 = 1;
					num3 = num15;
					num16 = num14;
					goto IL_012b;
				}
				num14--;
				goto IL_014b;
				IL_00c3:
				if (num10 <= 15)
				{
					array4[num10] = num8;
					num2 = num8;
					num3 = array2[num10];
					goto IL_007c;
				}
				_00232k = new short[num9];
				num13 = 512;
				num14 = 15;
				goto IL_014b;
				IL_014b:
				if (num14 >= 10)
				{
					goto IL_00e3;
				}
				int num17 = 0;
				goto IL_0213;
				IL_007c:
				int num18 = 16;
				int num19 = num10;
				if (8u != 0)
				{
					num8 = (int)(num2 + (num3 << num18 - num19));
					if (num10 >= 10)
					{
						int num20 = array4[num10] & 0x1FF80;
						int num21 = num8 & 0x1FF80;
						num9 += num21 - num20 >> 16 - num10;
					}
					num10++;
					goto IL_00c3;
				}
				goto IL_0130;
				IL_012b:
				num18 = num16 - 9;
				num19 = 31;
				goto IL_0130;
				IL_0213:
				if (num17 >= P_0.Length)
				{
					break;
				}
				int num22 = P_0[num17];
				if (num22 != 0)
				{
					num8 = array4[num22];
					int num23 = _0023X._0023W(num8);
					if (num22 <= 9)
					{
						while (true)
						{
							_00232k[num23] = (short)((num17 << 4) | num22);
							num23 += 1 << num22;
							if (false)
							{
								break;
							}
							if (num23 < 512)
							{
								continue;
							}
							goto IL_01fc;
						}
						goto IL_00e3;
					}
					int num24 = _00232k[num23 & 0x1FF];
					int num25 = 1 << (num24 & 0xF);
					num24 = -(num24 >> 4);
					while (true)
					{
						_00232k[num24 | (num23 >> 9)] = (short)((num17 << 4) | num22);
						num2 = num23;
						num15 = 1;
						num3 = num15;
						num16 = num22 & 0x1F;
						if (false)
						{
							break;
						}
						num23 = num2 + (num15 << num16);
						if (num23 < num25)
						{
							continue;
						}
						goto IL_01fc;
					}
					goto IL_012b;
				}
				goto IL_020d;
				IL_01fc:
				array4[num22] = num8 + (1 << 16 - num22);
				goto IL_020d;
				IL_0130:
				num13 = (int)(num2 + (num3 << (num18 & num19)));
				num11 += 128;
				goto IL_013f;
				IL_020d:
				num17++;
				goto IL_0213;
				IL_00e3:
				num12 = num8 & 0x1FF80;
				num8 -= array2[num14] << 16 - num14;
				int num26 = num8 & 0x1FF80;
				num11 = num26;
				goto IL_013f;
			}
		}

		public int _0023R(_0023H P_0)
		{
			int num = P_0._0023z(9);
			int num2 = num;
			int num3 = default(int);
			if (0 == 0)
			{
				num3 = num2;
			}
			int num9 = default(int);
			int num11 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num14;
				int num15;
				if (num >= 0)
				{
					short num4 = _00232k[num3];
					int num5 = num4;
					do
					{
						if (0 == 0)
						{
							num6 = num5;
						}
						num5 = 0;
					}
					while (num5 != 0);
					if (num4 >= num5)
					{
						int num7 = num6 & 0xF;
						if (0 == 0)
						{
							P_0._0023A(num7);
						}
						return num6 >> 4;
					}
					int num8 = -(num6 >> 4);
					if (0 == 0)
					{
						num9 = num8;
					}
					int num10 = num6 & 0xF;
					if (0 == 0)
					{
						num11 = num10;
					}
					int num12 = P_0._0023z(num11);
					int num13 = num12;
					if (0 == 0)
					{
						num3 = num13;
					}
					if (0 == 0)
					{
						if (num12 < 0)
						{
							num14 = P_0._0023B();
							num3 = P_0._0023z(num14);
							num15 = _00232k[num9 | (num3 >> 9)];
							goto IL_00a2;
						}
						num6 = _00232k[num9 | (num3 >> 9)];
						P_0._0023A(num6 & 0xF);
						num12 = num6;
					}
					num15 = num12 >> 4;
				}
				else
				{
					int num16 = P_0._0023B();
					num3 = P_0._0023z(num16);
					num6 = _00232k[num3];
					if (num6 < 0)
					{
						break;
					}
					num15 = num6 & 0xF;
					if (7u != 0)
					{
						if (0 == 0)
						{
							if (num15 > num16)
							{
								break;
							}
							P_0._0023A(num6 & 0xF);
							return num6 >> 4;
						}
						goto IL_00a2;
					}
				}
				return num15;
				IL_00a2:
				num6 = num15;
				if ((num6 & 0xF) <= num14)
				{
					P_0._0023A(num6 & 0xF);
					num = num6 >> 4;
					if (true)
					{
						return num;
					}
					continue;
				}
				return -1;
			}
			return -1;
		}
	}

	internal sealed class _0023V
	{
		private static readonly int[] _0023AE;

		private static readonly int[] _0023BE;

		private byte[] _0023CE;

		private byte[] _0023DE;

		private _0023S _0023aw;

		private int _0023jE;

		private int _0023EE;

		private int _0023FE;

		private int _0023GE;

		private int _0023HE;

		private int _0023IE;

		private byte _0023JE;

		private int _0023KE;

		private static readonly int[] _0023LE;

		public bool _0023w(_0023H P_0)
		{
			int num2 = default(int);
			while (true)
			{
				int num = _0023jE;
				if (0 == 0)
				{
					num2 = num;
				}
				int num3;
				int num5;
				int num6;
				int num7;
				int num9;
				int num10;
				int num8;
				switch (num2)
				{
				default:
					continue;
				case 0:
					_0023EE = P_0._0023z(5);
					num3 = _0023EE;
					if (3u != 0)
					{
						if (num3 < 0)
						{
							return false;
						}
						_0023EE += 257;
						if (8u != 0)
						{
							P_0._0023A(5);
						}
						_0023jE = 1;
						goto case 1;
					}
					goto IL_01e9;
				case 1:
					_0023FE = P_0._0023z(5);
					if (_0023FE < 0)
					{
						return false;
					}
					_0023FE++;
					if (0 == 0)
					{
						P_0._0023A(5);
					}
					_0023HE = _0023EE + _0023FE;
					_0023DE = new byte[_0023HE];
					_0023jE = 2;
					goto case 2;
				case 2:
					_0023GE = P_0._0023z(4);
					if (_0023GE < 0)
					{
						return false;
					}
					_0023GE += 4;
					if (2u != 0)
					{
						P_0._0023A(4);
					}
					_0023CE = new byte[19];
					_0023KE = 0;
					_0023jE = 3;
					goto case 3;
				case 3:
					if (_0023KE < _0023GE)
					{
						int num4 = P_0._0023z(3);
						if (4u != 0)
						{
							num5 = num4;
						}
						num6 = num5;
						num7 = 0;
						goto IL_0127;
					}
					_0023aw = new _0023S(_0023CE);
					_0023CE = null;
					_0023KE = 0;
					_0023jE = 4;
					goto case 4;
				case 4:
					while (true)
					{
						num9 = _0023aw._0023R(P_0);
						num10 = num9;
						if (-1 == 0)
						{
							break;
						}
						num8 = num10;
						if ((num9 & -16) == 0)
						{
							byte[] array = _0023DE;
							num2 = _0023KE++;
							array[num2] = (_0023JE = (byte)num8);
							num6 = _0023KE;
							num7 = _0023HE;
							if (0 == 0)
							{
								if (num6 == num7)
								{
									return true;
								}
								continue;
							}
							goto IL_0127;
						}
						goto IL_01e4;
					}
					break;
				case 5:
					{
						int num11 = _0023BE[_0023IE];
						int num12 = P_0._0023z(num11);
						if (num12 < 0)
						{
							return false;
						}
						P_0._0023A(num11);
						num12 += _0023AE[_0023IE];
						while (num12-- > 0)
						{
							byte[] array2 = _0023DE;
							num2 = _0023KE++;
							array2[num2] = _0023JE;
						}
						num9 = _0023KE;
						num10 = _0023HE;
						break;
					}
					IL_01e9:
					return (byte)num3 != 0;
					IL_01e4:
					if (num8 < 0)
					{
						num3 = 0;
						goto IL_01e9;
					}
					if (num8 >= 17)
					{
						_0023JE = 0;
					}
					_0023IE = num8 - 16;
					_0023jE = 5;
					goto case 5;
					IL_0127:
					if (num6 < num7)
					{
						return false;
					}
					if (7u != 0)
					{
						P_0._0023A(3);
					}
					_0023CE[_0023LE[_0023KE]] = (byte)num5;
					_0023KE++;
					goto case 3;
				}
				if (num9 == num10)
				{
					break;
				}
				_0023jE = 4;
			}
			return true;
		}

		public _0023S _0023T()
		{
			byte[] array = new byte[_0023EE];
			byte[] array2 = default(byte[]);
			if (0 == 0)
			{
				array2 = array;
			}
			byte[] sourceArray = _0023DE;
			byte[] destinationArray = array2;
			int length = _0023EE;
			if (0 == 0)
			{
				Array.Copy(sourceArray, 0, destinationArray, 0, length);
			}
			return new _0023S(array2);
		}

		public _0023S _0023U()
		{
			byte[] array = new byte[_0023FE];
			byte[] array2;
			if (4u != 0)
			{
				array2 = array;
			}
			byte[] sourceArray = _0023DE;
			int sourceIndex = _0023EE;
			int length = _0023FE;
			if (4u != 0)
			{
				Array.Copy(sourceArray, sourceIndex, array2, 0, length);
			}
			return new _0023S(array2);
		}

		static _0023V()
		{
			while (true)
			{
				int[] array = new int[3];
				if (0 == 0)
				{
					RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				_0023AE = array;
				while (0 == 0)
				{
					int num = 3;
					if (num != 0)
					{
						int[] array2 = new int[num];
						if (8u != 0)
						{
							RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						}
						_0023BE = array2;
						if (false)
						{
							continue;
						}
						num = 19;
					}
					int[] array3 = new int[num];
					if (0 == 0)
					{
						RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_0023LE = array3;
					return;
				}
			}
		}
	}

	internal sealed class _0023X
	{
		private static readonly int[] _0023LE;

		private static readonly byte[] _0023ME;

		private static readonly short[] _0023NE;

		private static readonly byte[] _0023OE;

		private static readonly short[] _0023PE;

		private static readonly byte[] _0023QE;

		public static short _0023W(int P_0)
		{
			return (short)((_0023ME[P_0 & 0xF] << 12) | (_0023ME[(P_0 >> 4) & 0xF] << 8) | (_0023ME[(P_0 >> 8) & 0xF] << 4) | _0023ME[P_0 >> 12]);
		}

		static _0023X()
		{
			while (true)
			{
				int[] array = new int[19];
				if (2u != 0)
				{
					RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				_0023LE = array;
				while (true)
				{
					IL_001a:
					byte[] array2 = new byte[16];
					if (5u != 0)
					{
						RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_0023ME = array2;
					_0023NE = new short[286];
					_0023OE = new byte[286];
					int num;
					if (0 == 0)
					{
						if (3u != 0)
						{
							num = 0;
						}
						goto IL_0083;
					}
					goto IL_00a2;
					IL_0071:
					byte[] array3 = _0023OE;
					int num2 = num;
					int num3 = num2 + 1;
					if (uint.MaxValue != 0)
					{
						num = num3;
					}
					array3[num2] = 8;
					goto IL_0083;
					IL_00a2:
					byte[] array4 = _0023OE;
					int num4 = num;
					int num5 = num4 + 1;
					if (8u != 0)
					{
						num = num5;
					}
					array4[num4] = 9;
					goto IL_00b5;
					IL_0083:
					if (num < 144)
					{
						_0023NE[num] = _0023W(48 + num << 8);
						goto IL_0071;
					}
					goto IL_00b5;
					IL_00b5:
					if (num < 256)
					{
						_0023NE[num] = _0023W(256 + num << 7);
						goto IL_00a2;
					}
					while (true)
					{
						int num6 = num;
						while (num6 >= 280)
						{
							while (num < 286)
							{
								_0023NE[num] = _0023W(-88 + num << 8);
								_0023OE[num++] = 8;
							}
							_0023PE = new short[30];
							_0023QE = new byte[30];
							if (false)
							{
								goto end_IL_00ed;
							}
							num = 0;
							while (true)
							{
								if (num < 30)
								{
									_0023PE[num] = _0023W(num << 11);
									if (2 == 0)
									{
										break;
									}
									_0023QE[num] = 5;
									num6 = num;
									if (3 == 0)
									{
										goto IL_00ee;
									}
									num = num6 + 1;
									continue;
								}
								return;
							}
							goto IL_001a;
							IL_00ee:;
						}
						_0023NE[num] = _0023W(-256 + num << 9);
						if (7 == 0)
						{
							goto end_IL_001a;
						}
						byte[] array5 = _0023OE;
						int num7 = num;
						int num8 = num7 + 1;
						if (3u != 0)
						{
							num = num8;
						}
						array5[num7] = 7;
						continue;
						end_IL_00ed:
						break;
					}
					goto IL_0071;
					continue;
					end_IL_001a:
					break;
				}
			}
		}
	}

	internal sealed class _00230 : MemoryStream
	{
		public int _0023Y()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int _0023Z()
		{
			return _0023Y() | (_0023Y() << 16);
		}

		public _00230(byte[] P_0)
			: base(P_0, writable: false)
		{
		}
	}

	private static bool _0023s(Assembly P_0, Assembly P_1)
	{
		byte[]? publicKey = P_0.GetName().GetPublicKey();
		byte[] array = default(byte[]);
		if (0 == 0)
		{
			array = publicKey;
		}
		byte[]? publicKey2 = P_1.GetName().GetPublicKey();
		byte[] array2 = default(byte[]);
		if (0 == 0)
		{
			array2 = publicKey2;
		}
		int num3 = default(int);
		while (true)
		{
			int num = ((array2 == null) ? 1 : 0);
			int num2;
			if (true)
			{
				num2 = ((array == null) ? 1 : 0);
				goto IL_0029;
			}
			goto IL_004d;
			IL_0029:
			if (num != num2)
			{
				num = 0;
				if (num == 0)
				{
					return (byte)num != 0;
				}
				goto IL_003d;
			}
			if (array2 == null)
			{
				break;
			}
			if (true)
			{
				num3 = 0;
			}
			goto IL_0051;
			IL_004d:
			if (6u != 0)
			{
				num3 = num;
			}
			goto IL_0051;
			IL_003d:
			num2 = array[num3];
			if (false)
			{
				goto IL_0029;
			}
			if (num != num2)
			{
				return false;
			}
			if (false)
			{
				continue;
			}
			num = num3 + 1;
			goto IL_004d;
			IL_0051:
			if (num3 >= array2.Length)
			{
				break;
			}
			num = array2[num3];
			goto IL_003d;
		}
		return true;
	}

	public static byte[] _0023t(byte[] P_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly assembly = default(Assembly);
		if (0 == 0)
		{
			assembly = callingAssembly;
		}
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Assembly assembly2 = default(Assembly);
		if (0 == 0)
		{
			assembly2 = executingAssembly;
		}
		if ((object)assembly != assembly2 && !_0023s(assembly2, assembly))
		{
			return null;
		}
		_00230 _0023 = new _00230(P_0);
		_00230 _00232;
		if (uint.MaxValue != 0)
		{
			_00232 = _0023;
		}
		byte[] array = new byte[0];
		byte[] array2 = default(byte[]);
		if (0 == 0)
		{
			array2 = array;
		}
		int num = _00232._0023Z();
		int num2 = default(int);
		if (0 == 0)
		{
			num2 = num;
		}
		int num7;
		int num8;
		int num9 = default(int);
		int num10 = default(int);
		if (num2 == 67324752)
		{
			short num3 = (short)_00232._0023Y();
			short num4 = default(short);
			if (0 == 0)
			{
				num4 = num3;
			}
			int num5 = _00232._0023Y();
			int num6 = _00232._0023Y();
			if (num2 != 67324752 || num4 != 20 || num5 != 0 || num6 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			_00232._0023Z();
			_00232._0023Z();
			num7 = _00232._0023Z();
		}
		else
		{
			num8 = num2 >> 24;
			if (2 == 0)
			{
				goto IL_00e7;
			}
			num2 -= num8 << 24;
			if (num2 != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 != 1)
			{
				goto IL_01db;
			}
			num7 = _00232._0023Z();
			if (true)
			{
				num9 = num7;
				if (false)
				{
					goto IL_00e2;
				}
				array2 = new byte[num9];
				num10 = 0;
				goto IL_01d5;
			}
		}
		int num11 = _00232._0023Z();
		int num12 = _00232._0023Y();
		int num13 = _00232._0023Y();
		if (num12 > 0)
		{
			byte[] buffer = new byte[num12];
			_00232.Read(buffer, 0, num12);
		}
		goto IL_00e2;
		IL_00e2:
		if (num13 > 0)
		{
			goto IL_00e7;
		}
		goto IL_00fc;
		IL_0285:
		byte[] array3;
		byte[] array4;
		using (_0023o _0023o2 = new _0023o())
		{
			using ICryptoTransform cryptoTransform = _0023o2._0023l(array3, array4, true);
			byte[] array5 = cryptoTransform.TransformFinalBlock(P_0, 4, P_0.Length - 4);
			array2 = _0023t(array5);
		}
		goto IL_02d9;
		IL_01d5:
		if (num10 >= num9)
		{
			goto IL_01db;
		}
		int num14 = _00232._0023Z();
		int num15 = default(int);
		int num16;
		if (7u != 0)
		{
			num15 = _00232._0023Z();
			num16 = num14;
			goto IL_01a3;
		}
		goto IL_0285;
		IL_02d9:
		_00232.Close();
		_00232 = null;
		return array2;
		IL_00fc:
		byte[] array6 = new byte[_00232.Length - _00232.Position];
		_00232.Read(array6, 0, array6.Length);
		_0023y _0023y = new _0023y(array6);
		array2 = new byte[num11];
		_0023y._0023x(array2, 0, array2.Length);
		array6 = null;
		goto IL_02d9;
		IL_01a3:
		byte[] array7 = new byte[num16];
		_00232.Read(array7, 0, array7.Length);
		_0023y _0023y2 = new _0023y(array7);
		_0023y2._0023x(array2, num10, num15);
		num10 += num15;
		goto IL_01d5;
		IL_01db:
		if (num8 == 2)
		{
			byte[] array8 = new byte[8] { 248, 77, 238, 126, 116, 253, 83, 146 };
			byte[] array9 = new byte[8] { 45, 244, 152, 120, 170, 147, 74, 189 };
			using _0023r _0023r2 = new _0023r();
			using ICryptoTransform cryptoTransform2 = _0023r2._0023q(array8, array9, true);
			byte[] array10 = cryptoTransform2.TransformFinalBlock(P_0, 4, P_0.Length - 4);
			array2 = _0023t(array10);
		}
		if (num8 == 3)
		{
			num16 = 16;
			if (num16 == 0)
			{
				goto IL_01a3;
			}
			byte[] array11 = new byte[num16];
			RuntimeHelpers.InitializeArray(array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			array3 = array11;
			array4 = new byte[16]
			{
				2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
				2, 2, 2, 2, 2, 2
			};
			goto IL_0285;
		}
		goto IL_02d9;
		IL_00e7:
		byte[] buffer2 = new byte[num13];
		_00232.Read(buffer2, 0, num13);
		goto IL_00fc;
	}
}
