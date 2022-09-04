using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal sealed class Class8
{
	internal sealed class Class9
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private static readonly int[] int_2;

		private static readonly int[] int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private bool bool_0;

		private Class10 class10_0;

		private Class11 class11_0;

		private Class13 class13_0;

		private Class12 class12_0;

		private Class12 class12_1;

		public Class9(byte[] CO_)
		{
			try
			{
				class10_0 = new Class10();
				class11_0 = new Class11();
				int_4 = 2;
				class10_0.method_7(CO_, 0, CO_.Length);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		static Class9()
		{
			try
			{
				while (true)
				{
					if (7u != 0 && 0 == 0)
					{
						int_0 = new int[29]
						{
							3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
							15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
							67, 83, 99, 115, 131, 163, 195, 227, 258
						};
						int_1 = new int[29]
						{
							0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
							1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
							4, 4, 4, 4, 5, 5, 5, 5, 0
						};
					}
					if (6u != 0)
					{
						if (0 == 0)
						{
							int_2 = new int[30]
							{
								1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
								33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
								1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
							};
						}
						int_3 = new int[30]
						{
							0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
							4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
							9, 9, 10, 10, 11, 11, 12, 12, 13, 13
						};
						if (4u != 0)
						{
							break;
						}
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_0(cO_);
				throw;
			}
		}

		private bool method_0()
		{
			int num = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num10 = default(int);
			try
			{
				num = class11_0.method_4();
				int num7;
				while (true)
				{
					int num2 = num;
					int num3 = 258;
					if (num3 != 0)
					{
						if (num2 >= num3)
						{
							num4 = int_4;
							goto IL_019b;
						}
						return true;
					}
					goto IL_019e;
					IL_001f:
					class11_0.method_2(int_6, int_7);
					if (false)
					{
						goto IL_00dd;
					}
					num -= int_6;
					if (8u != 0)
					{
						int_4 = 7;
						continue;
					}
					goto IL_019b;
					IL_0187:
					if (0 == 0)
					{
						if (int_5 <= 0)
						{
							goto IL_001f;
						}
						int_4 = 10;
						num5 = class10_0.method_0(int_5);
						if (num5 < 0)
						{
							return false;
						}
						class10_0.method_1(int_5);
					}
					int_7 += num5;
					goto IL_001f;
					IL_0112:
					num6 = class12_1.method_1(class10_0);
					if (num6 >= 0)
					{
						int_7 = int_2[num6];
						int_5 = int_3[num6];
						goto IL_0187;
					}
					num7 = 0;
					break;
					IL_019e:
					switch (num2 - num3)
					{
					case 0:
						break;
					case 1:
						goto IL_00dd;
					case 2:
						goto IL_0112;
					case 3:
						goto IL_0187;
					default:
						continue;
					}
					goto IL_009d;
					IL_009d:
					while (true)
					{
						int num8 = (num6 = class12_0.method_1(class10_0));
						int num9 = -256;
						while ((num8 & num9) != 0)
						{
							if (num6 >= 257)
							{
								goto end_IL_009d;
							}
							num8 = num6;
							num9 = 0;
							if (num9 != 0)
							{
								continue;
							}
							goto IL_01e1;
						}
						class11_0.method_0(num6);
						if (--num < 258)
						{
							return true;
						}
						continue;
						IL_01e1:
						if (num8 < num9)
						{
							return false;
						}
						class12_1 = null;
						class12_0 = null;
						int_4 = 2;
						return true;
						continue;
						end_IL_009d:
						break;
					}
					int_6 = int_0[num6 - 257];
					int_5 = int_1[num6 - 257];
					goto IL_00dd;
					IL_019b:
					num2 = num4;
					num3 = 7;
					goto IL_019e;
					IL_00dd:
					if (int_5 > 0)
					{
						int_4 = 8;
						num10 = class10_0.method_0(int_5);
						num7 = num10;
						if (3 == 0)
						{
							break;
						}
						if (num7 < 0)
						{
							if (4u != 0)
							{
								return false;
							}
							goto IL_009d;
						}
						class10_0.method_1(int_5);
						int_6 += num10;
					}
					int_4 = 9;
					goto IL_0112;
				}
				return (byte)num7 != 0;
			}
			catch (Exception cO_)
			{
				Class29.smethod_6(cO_, num, num6, num10, num5, num4, this);
				throw;
			}
		}

		private bool method_1()
		{
			int num = default(int);
			int num3 = default(int);
			int num7 = default(int);
			int num6 = default(int);
			try
			{
				num = int_4;
				int num2 = num - 2;
				while (true)
				{
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						if (!bool_0)
						{
							num3 = class10_0.method_0(3);
							if (num3 >= 0)
							{
								class10_0.method_1(3);
								num2 = num3;
								if (false)
								{
									break;
								}
								num4 = num2 & 1;
								goto IL_012e;
							}
							goto IL_021c;
						}
						int_4 = 12;
						num5 = 0;
						goto IL_01a2;
					case 1:
						num = (int_8 = class10_0.method_0(16));
						if (num >= 0)
						{
							class10_0.method_1(16);
							int_4 = 4;
							goto case 2;
						}
						return false;
					case 2:
						num7 = class10_0.method_0(16);
						if (false)
						{
							goto case 1;
						}
						if (num7 < 0)
						{
							return false;
						}
						class10_0.method_1(16);
						int_4 = 5;
						goto case 3;
					case 3:
						num6 = class11_0.method_3(class10_0, int_8);
						int_8 -= num6;
						if (int_8 == 0)
						{
							int_4 = 2;
							num4 = 1;
							if (num4 != 0)
							{
								return (byte)num4 != 0;
							}
							goto IL_012e;
						}
						return !class10_0.method_5();
					case 4:
						if (!class13_0.method_0(class10_0))
						{
							return false;
						}
						class12_0 = class13_0.method_1();
						class12_1 = class13_0.method_2();
						if (4u != 0)
						{
							int_4 = 7;
							goto case 5;
						}
						goto IL_020f;
					case 5:
					case 6:
					case 7:
					case 8:
					{
						bool result = method_0();
						if (2u != 0)
						{
							return result;
						}
						goto IL_020f;
					}
					default:
					{
						bool result = false;
						if (8u != 0)
						{
							return result;
						}
						goto IL_021c;
					}
					case 10:
						{
							return false;
						}
						IL_020f:
						return true;
						IL_021c:
						return false;
						IL_01a2:
						return (byte)num5 != 0;
						IL_012e:
						if (num4 != 0)
						{
							bool_0 = true;
						}
						num = num3 >> 1;
						num5 = num;
						if (false)
						{
							goto IL_01a2;
						}
						switch (num5)
						{
						case 0:
							class10_0.method_4();
							int_4 = 3;
							break;
						case 1:
							class12_0 = Class12.class12_0;
							class12_1 = Class12.class12_1;
							int_4 = 7;
							break;
						case 2:
							class13_0 = new Class13();
							int_4 = 6;
							break;
						}
						goto IL_020f;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num3, num7, num6, num, this);
				throw;
			}
		}

		public int method_2(byte[] CO_, int CO_, int CO_)
		{
			int num2 = default(int);
			int num5 = default(int);
			try
			{
				int num = 0;
				while (true)
				{
					num2 = num;
					while (true)
					{
						int num3 = int_4;
						while (true)
						{
							if (num3 == 11)
							{
								goto IL_0003;
							}
							int num4 = class11_0.method_6(CO_, CO_, CO_);
							while (true)
							{
								num5 = num4;
								num4 = CO_ + num5;
								if (5 == 0)
								{
									break;
								}
								if (2 == 0)
								{
									continue;
								}
								goto IL_0059;
							}
							goto IL_0025;
							IL_003c:
							if (CO_ == 0)
							{
								return num2;
							}
							goto IL_0003;
							IL_0030:
							int num6;
							int num7;
							num = num6 + num7;
							if (false)
							{
								goto end_IL_0067;
							}
							num2 = num;
							CO_ -= num5;
							goto IL_003c;
							IL_0059:
							CO_ = num4;
							num6 = num2;
							num7 = num5;
							goto IL_0030;
							IL_0003:
							num3 = (method_1() ? 1 : 0);
							if (false)
							{
								continue;
							}
							if (num3 != 0)
							{
								break;
							}
							num6 = class11_0.method_5();
							num7 = 0;
							if (num7 == 0)
							{
								if (num6 > num7)
								{
									num4 = int_4;
									goto IL_0025;
								}
								goto IL_0029;
							}
							goto IL_0030;
							IL_0025:
							if (num4 != 11)
							{
								break;
							}
							goto IL_0029;
							IL_0029:
							int result = num2;
							if (0 == 0)
							{
								return result;
							}
							goto IL_003c;
						}
						continue;
						end_IL_0067:
						break;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_6(cO_, num2, num5, this, CO_, CO_, CO_);
				throw;
			}
		}
	}

	internal sealed class Class10
	{
		private byte[] byte_0;

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public int method_0(int CO_)
		{
			int num3 = default(int);
			try
			{
				if (int_2 < CO_)
				{
					if (int_0 == int_1)
					{
						return -1;
					}
					uint num = uint_0;
					byte[] array = byte_0;
					int num2 = int_0;
					if (uint.MaxValue != 0)
					{
						num3 = num2;
					}
					int_0 = num2 + 1;
					int num4 = array[num3] & 0xFF;
					byte[] array2 = byte_0;
					num3 = int_0++;
					uint_0 = num | (uint)((num4 | ((array2[num3] & 0xFF) << 8)) << int_2);
					int_2 += 16;
				}
				return (int)(uint_0 & ((1 << CO_) - 1));
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num3, this, CO_);
				throw;
			}
		}

		public void method_1(int CO_)
		{
			try
			{
				if (uint.MaxValue != 0)
				{
					uint_0 >>= CO_;
					goto IL_0014;
				}
				goto IL_002c;
				IL_0014:
				if (0 == 0)
				{
					int_2 -= CO_;
				}
				goto IL_002c;
				IL_002c:
				if (0 == 0 && 0 == 0)
				{
					return;
				}
				goto IL_0014;
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			try
			{
				return int_2;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		[SpecialName]
		public int method_3()
		{
			try
			{
				int num = int_1 - int_0;
				do
				{
					if (-1 == 0)
					{
						continue;
					}
					int num2 = int_2;
					do
					{
						if (uint.MaxValue != 0)
						{
							num2 >>= 3;
						}
					}
					while (2 == 0);
					num += num2;
				}
				while (1 == 0);
				return num;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public void method_4()
		{
			try
			{
				uint_0 >>= int_2 & 7;
				int_2 &= -8;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			try
			{
				return int_0 == int_1;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public int method_6(byte[] CO_, int CO_, int CO_)
		{
			int num = default(int);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				num = 0;
				while (true)
				{
					int num2;
					int num3;
					if (int_2 > 0)
					{
						num2 = CO_;
						num3 = 0;
						goto IL_0019;
					}
					goto IL_001b;
					IL_0066:
					if (6 == 0)
					{
						break;
					}
					uint_0 >>= 8;
					int_2 -= 8;
					int num4 = CO_;
					if (7u != 0)
					{
						CO_ = num4 - 1;
						num++;
						continue;
					}
					goto IL_0056;
					IL_001b:
					int num5 = CO_;
					while (num5 == 0)
					{
						num5 = num;
						if (0 == 0)
						{
							return num5;
						}
					}
					num2 = int_1;
					num3 = int_0;
					if (1 == 0)
					{
						goto IL_0019;
					}
					num6 = num2 - num3;
					num4 = CO_;
					goto IL_0056;
					IL_0056:
					if (num4 > num6)
					{
						goto IL_0059;
					}
					goto IL_0061;
					IL_0061:
					if (5u != 0)
					{
						Array.Copy(byte_0, int_0, CO_, CO_, CO_);
						break;
					}
					goto IL_0059;
					IL_0019:
					if (num2 <= num3)
					{
						goto IL_001b;
					}
					CO_[CO_++] = (byte)uint_0;
					goto IL_0066;
					IL_0059:
					if (uint.MaxValue != 0)
					{
						CO_ = num6;
						goto IL_0061;
					}
					goto IL_0066;
				}
				int_0 += CO_;
				if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
				{
					byte[] array = byte_0;
					num7 = int_0++;
					uint_0 = array[num7] & 0xFFu;
					if (0 == 0)
					{
						int_2 = 8;
					}
				}
				return num + CO_;
			}
			catch (Exception cO_)
			{
				Class29.smethod_7(cO_, num, num6, num7, this, CO_, CO_, CO_);
				throw;
			}
		}

		public void method_7(byte[] CO_, int CO_, int CO_)
		{
			int num5 = default(int);
			try
			{
				int num;
				int num2;
				if (8u != 0)
				{
					num = int_0;
					num2 = int_1;
					goto IL_002c;
				}
				goto IL_0086;
				IL_0083:
				int num3;
				nint num4;
				if (num3 <= (int)num4)
				{
					goto IL_0086;
				}
				goto IL_0091;
				IL_0086:
				num3 = CO_ & 1;
				goto IL_007d;
				IL_007d:
				if (num3 != 0)
				{
					if (false)
					{
						goto IL_0091;
					}
					uint_0 |= (uint)((CO_[CO_++] & 0xFF) << int_2);
					int_2 += 8;
				}
				byte_0 = CO_;
				int_0 = CO_;
				if (8u != 0)
				{
					int_1 = num5;
					return;
				}
				goto IL_0035;
				IL_0091:
				throw new ArgumentOutOfRangeException();
				IL_002c:
				if (num >= num2)
				{
					num3 = CO_;
					num4 = CO_;
					if (8u != 0)
					{
						num5 = num3 + CO_;
						goto IL_0035;
					}
					goto IL_0083;
				}
				throw new InvalidOperationException();
				IL_0035:
				if (0 <= CO_)
				{
					num = CO_;
					num2 = num5;
					if (1 == 0)
					{
						goto IL_002c;
					}
					if (num <= num2)
					{
						num3 = num5;
						if (6 == 0)
						{
							goto IL_007d;
						}
						num4 = (nint)CO_.LongLength;
						goto IL_0083;
					}
				}
				goto IL_0091;
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num5, this, CO_, CO_, CO_);
				throw;
			}
		}
	}

	internal sealed class Class11
	{
		private byte[] byte_0 = new byte[32768];

		private int int_0 = 0;

		private int int_1 = 0;

		public void method_0(int CO_)
		{
			int num = default(int);
			try
			{
				num = int_1++;
				if (num == 32768)
				{
					throw new InvalidOperationException();
				}
				byte[] array = byte_0;
				num = int_0++;
				array[num] = (byte)CO_;
				int_0 &= 32767;
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num, this, CO_);
				throw;
			}
		}

		private void method_1(int CO_, int CO_, int CO_)
		{
			int num4 = default(int);
			try
			{
				do
				{
					IL_0061:
					if (false)
					{
						goto IL_0061;
					}
					if (2 == 0)
					{
						continue;
					}
					int num = CO_;
					int num2 = num - 1;
					if (7u != 0)
					{
						CO_ = num2;
						if (num <= 0)
						{
							continue;
						}
						byte[] array = byte_0;
						int num3 = int_0;
						if (0 == 0)
						{
							num4 = num3;
						}
						int_0 = num3 + 1;
						array[num4] = byte_0[CO_++];
						if (0 == 0)
						{
							int_0 &= 32767;
						}
						num = CO_;
						num2 = 32767;
					}
					CO_ = num & num2;
					goto IL_0061;
				}
				while (false);
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num4, this, CO_, CO_, CO_);
				throw;
			}
		}

		public void method_2(int CO_, int CO_)
		{
			int num = default(int);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				int num2;
				int num3;
				int num4;
				if (2u != 0)
				{
					if (0 == 0)
					{
						num = (int_1 += CO_);
						num2 = num;
						if (false)
						{
							goto IL_0070;
						}
						if (num2 > 32768)
						{
							throw new InvalidOperationException();
						}
						num3 = int_0 - CO_;
						num4 = 32767;
						goto IL_0081;
					}
					goto IL_008c;
				}
				goto IL_0095;
				IL_0070:
				int num5 = num2 - CO_;
				if (true)
				{
					num6 = num5;
				}
				num3 = num7;
				num4 = num6;
				if (false)
				{
					goto IL_0093;
				}
				if (1 == 0)
				{
					goto IL_0081;
				}
				if (num3 <= num4)
				{
					goto IL_008c;
				}
				goto IL_00c4;
				IL_008c:
				num3 = int_0;
				num4 = num6;
				goto IL_0093;
				IL_00c4:
				method_1(num7, CO_, CO_);
				return;
				IL_0093:
				if (num3 < num4)
				{
					goto IL_0095;
				}
				goto IL_00c4;
				IL_0081:
				num7 = num3 & num4;
				num2 = 32768;
				goto IL_0070;
				IL_0095:
				if (CO_ > CO_)
				{
					while (true)
					{
						num3 = CO_;
						num4 = num3 - 1;
						if (false)
						{
							break;
						}
						CO_ = num4;
						if (num3 > 0)
						{
							byte[] array = byte_0;
							num = int_0++;
							array[num] = byte_0[num7++];
							continue;
						}
						return;
					}
					goto IL_0081;
				}
				Array.Copy(byte_0, num7, byte_0, int_0, CO_);
				int_0 += CO_;
			}
			catch (Exception cO_)
			{
				Class29.smethod_6(cO_, num7, num6, num, this, CO_, CO_);
				throw;
			}
		}

		public int method_3(Class10 CO_, int CO_)
		{
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				int num = CO_;
				while (true)
				{
					CO_ = Math.Min(Math.Min(num, 32768 - int_1), CO_.method_3());
					while (true)
					{
						int num2 = 32768 - int_0;
						do
						{
							num3 = num2;
							num2 = CO_;
						}
						while (7 == 0);
						if (num2 <= num3)
						{
							goto IL_004a;
						}
						num4 = CO_.method_6(byte_0, int_0, num3);
						if (uint.MaxValue != 0 && num4 == num3)
						{
							num4 += CO_.method_6(byte_0, 0, CO_ - num3);
							if (1 == 0)
							{
								continue;
							}
						}
						goto IL_0061;
						IL_0061:
						int_0 = (int_0 + num4) & 0x7FFF;
						if (0 == 0)
						{
							int_1 += num4;
							return num4;
						}
						goto IL_004a;
						IL_004a:
						num = CO_.method_6(byte_0, int_0, CO_);
						if (3 == 0)
						{
							break;
						}
						num4 = num;
						goto IL_0061;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num4, num3, this, CO_, CO_);
				throw;
			}
		}

		public int method_4()
		{
			try
			{
				int result;
				do
				{
					int num = 32768;
					if (num != 0)
					{
						num -= int_1;
					}
					result = num;
				}
				while (false);
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public int method_5()
		{
			try
			{
				return int_1;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public int method_6(byte[] CO_, int CO_, int CO_)
		{
			int num = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				while (true)
				{
					num = int_0;
					int num2 = CO_;
					while (true)
					{
						int num3 = int_1;
						while (num2 <= num3)
						{
							if (0 == 0)
							{
								num2 = int_0 - int_1 + CO_;
								num3 = 32767;
								if (num3 == 0)
								{
									continue;
								}
								goto IL_0038;
							}
							goto IL_0095;
						}
						if (8u != 0)
						{
							CO_ = int_1;
							goto IL_003a;
						}
						goto IL_0044;
						IL_0076:
						Array.Copy(byte_0, num - CO_, CO_, CO_, CO_);
						goto IL_0087;
						IL_0087:
						int_1 -= num4;
						goto IL_0095;
						IL_0095:
						if (int_1 < 0)
						{
							throw new InvalidOperationException();
						}
						return num4;
						IL_0038:
						num = num2 & num3;
						goto IL_003a;
						IL_003a:
						num4 = CO_;
						num5 = CO_ - num;
						if (num5 > 0)
						{
							goto IL_0044;
						}
						goto IL_0076;
						IL_0044:
						if (0 == 0)
						{
							if (5 == 0)
							{
								break;
							}
							Array.Copy(byte_0, 32768 - num5, CO_, CO_, num5);
							num2 = CO_;
							if (6 == 0)
							{
								continue;
							}
							CO_ = num2 + num5;
							CO_ = num;
							goto IL_0076;
						}
						goto IL_0087;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_7(cO_, num, num4, num5, this, CO_, CO_, CO_);
				throw;
			}
		}
	}

	internal sealed class Class12
	{
		private short[] short_0;

		public static readonly Class12 class12_0;

		public static readonly Class12 class12_1;

		static Class12()
		{
			byte[] array = default(byte[]);
			int num2 = default(int);
			try
			{
				int num = 288;
				if (num != 0)
				{
					array = new byte[num];
					num = 0;
				}
				num2 = num;
				while (true)
				{
					if (0 == 0)
					{
						if (num2 >= 144)
						{
							goto IL_002d;
						}
						if (3 == 0)
						{
							goto IL_0035;
						}
						if (4u != 0)
						{
							array[num2++] = 8;
							continue;
						}
					}
					goto IL_0096;
					IL_0035:
					array[num2++] = 9;
					goto IL_002d;
					IL_0096:
					while (num2 < 32)
					{
						array[num2++] = 5;
					}
					class12_1 = new Class12(array);
					if (true)
					{
						break;
					}
					goto IL_0062;
					IL_005a:
					if (num2 < 280)
					{
						goto IL_0062;
					}
					int num3;
					while (true)
					{
						num3 = num2;
						while (num3 >= 288)
						{
							class12_0 = new Class12(array);
							num3 = 32;
							if (num3 != 0)
							{
								goto end_IL_008b;
							}
						}
						array[num2++] = 8;
						continue;
						end_IL_008b:
						break;
					}
					array = new byte[num3];
					num2 = 0;
					goto IL_0096;
					IL_0062:
					array[num2++] = 7;
					goto IL_005a;
					IL_002d:
					if (num2 < 256)
					{
						goto IL_0035;
					}
					goto IL_005a;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, array, num2);
				throw;
			}
		}

		public Class12(byte[] CO_)
		{
			try
			{
				method_0(CO_);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		private void method_0(byte[] CO_)
		{
			int[] array2 = default(int[]);
			int[] array3 = default(int[]);
			int i = default(int);
			int num = default(int);
			int[] array4 = default(int[]);
			nint num3 = default(nint);
			int num4 = default(int);
			int num5 = default(int);
			int j = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int k = default(int);
			int l = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			try
			{
				int[] array = new int[16];
				if (3u != 0)
				{
					array2 = array;
				}
				array3 = new int[16];
				for (i = 0; i < CO_.Length; i++)
				{
					num = CO_[i];
					if (num > 0)
					{
						int[] array5 = (array4 = array2);
						int num2 = num;
						if (6u != 0)
						{
							num3 = num2;
						}
						array5[num2] = array4[num3] + 1;
					}
				}
				num4 = 0;
				num5 = 512;
				for (j = 1; j <= 15; j++)
				{
					array3[j] = num4;
					num4 += array2[j] << 16 - j;
					if (j >= 10)
					{
						num6 = array3[j] & 0x1FF80;
						num7 = num4 & 0x1FF80;
						num5 += num7 - num6 >> 16 - j;
					}
				}
				short_0 = new short[num5];
				num8 = 512;
				for (num9 = 15; num9 >= 10; num9--)
				{
					num10 = num4 & 0x1FF80;
					num4 -= array2[num9] << 16 - num9;
					num11 = num4 & 0x1FF80;
					for (k = num11; k < num10; k += 128)
					{
						short_0[Class15.smethod_0(k)] = (short)((-num8 << 4) | num9);
						num8 += 1 << num9 - 9;
					}
				}
				for (l = 0; l < CO_.Length; l++)
				{
					num12 = CO_[l];
					if (num12 == 0)
					{
						continue;
					}
					num4 = array3[num12];
					num13 = Class15.smethod_0(num4);
					if (num12 <= 9)
					{
						do
						{
							short_0[num13] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < 512);
					}
					else
					{
						num14 = short_0[num13 & 0x1FF];
						num15 = 1 << (num14 & 0xF);
						num14 = -(num14 >> 4);
						do
						{
							short_0[num14 | (num13 >> 9)] = (short)((l << 4) | num12);
							num13 += 1 << num12;
						}
						while (num13 < num15);
					}
					array3[num12] = num4 + (1 << 16 - num12);
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_10(cO_, new object[23]
				{
					array2, array3, i, num, num4, num5, j, num6, num7, num8,
					num9, num10, num11, k, l, num12, num13, num14, num15, array4,
					num3, this, CO_
				});
				throw;
			}
		}

		public int method_1(Class10 CO_)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				if ((num = CO_.method_0(9)) >= 0)
				{
					if ((num2 = short_0[num]) >= 0)
					{
						CO_.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					num3 = -(num2 >> 4);
					num4 = num2 & 0xF;
					if ((num = CO_.method_0(num4)) >= 0)
					{
						num2 = short_0[num3 | (num >> 9)];
						CO_.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					num5 = CO_.method_2();
					num = CO_.method_0(num5);
					num2 = short_0[num3 | (num >> 9)];
					if ((num2 & 0xF) <= num5)
					{
						CO_.method_1(num2 & 0xF);
						return num2 >> 4;
					}
					return -1;
				}
				num6 = CO_.method_2();
				num = CO_.method_0(num6);
				num2 = short_0[num];
				if (num2 >= 0 && (num2 & 0xF) <= num6)
				{
					CO_.method_1(num2 & 0xF);
					return num2 >> 4;
				}
				return -1;
			}
			catch (Exception cO_)
			{
				Class29.smethod_8(cO_, num, num2, num3, num4, num5, num6, this, CO_);
				throw;
			}
		}
	}

	internal sealed class Class13
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private byte[] byte_0;

		private byte[] byte_1;

		private Class12 class12_0;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private byte byte_2;

		private int int_8;

		private static readonly int[] int_9;

		static Class13()
		{
			try
			{
				int_0 = new int[3] { 3, 3, 11 };
				int_1 = new int[3] { 2, 3, 7 };
				int_9 = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
			}
			catch (Exception cO_)
			{
				Class29.smethod_0(cO_);
				throw;
			}
		}

		public bool method_0(Class10 CO_)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			byte b = default(byte);
			int num8 = default(int);
			try
			{
				while (true)
				{
					num = int_2;
					int num4;
					int num5;
					switch (num)
					{
					case 5:
						num2 = int_1[int_7];
						num3 = CO_.method_0(num2);
						if (num3 >= 0)
						{
							CO_.method_1(num2);
							num3 += int_0[int_7];
							goto IL_008f;
						}
						return false;
					case 4:
						while (((num6 = class12_0.method_1(CO_)) & -16) == 0)
						{
							byte[] array2 = byte_1;
							num = int_8++;
							int num7 = num;
							b = (byte_2 = (byte)num6);
							array2[num7] = b;
							if (int_8 == int_6)
							{
								return true;
							}
						}
						if (num6 >= 0)
						{
							num4 = num6;
							num5 = 17;
							if (num5 != 0)
							{
								if (num4 >= num5)
								{
									byte_2 = 0;
								}
								int_7 = num6 - 16;
								int_2 = 5;
								goto case 5;
							}
							goto IL_0069;
						}
						return false;
					case 3:
						while (int_8 < int_5)
						{
							num8 = CO_.method_0(3);
							if (num8 >= 0)
							{
								CO_.method_1(3);
								byte_0[int_9[int_8]] = (byte)num8;
								int_8++;
								continue;
							}
							return false;
						}
						class12_0 = new Class12(byte_0);
						byte_0 = null;
						int_8 = 0;
						int_2 = 4;
						goto case 4;
					case 2:
						int_5 = CO_.method_0(4);
						if (int_5 >= 0)
						{
							int_5 += 4;
							CO_.method_1(4);
							byte_0 = new byte[19];
							int_8 = 0;
							int_2 = 3;
							goto case 3;
						}
						return false;
					case 1:
						if (0 == 0)
						{
							int_4 = CO_.method_0(5);
							if (int_4 >= 0)
							{
								int_4++;
								CO_.method_1(5);
								int_6 = int_3 + int_4;
								byte_1 = new byte[int_6];
								int_2 = 2;
								goto case 2;
							}
						}
						return false;
					case 0:
						{
							int_3 = CO_.method_0(5);
							if (int_3 >= 0)
							{
								int_3 += 257;
								CO_.method_1(5);
								int_2 = 1;
								goto case 1;
							}
							return false;
						}
						IL_008f:
						num4 = num3;
						num5 = num4;
						goto IL_0069;
						IL_0069:
						num3 = num5 - 1;
						if (num4 > 0)
						{
							byte[] array = byte_1;
							num = int_8++;
							array[num] = byte_2;
							goto IL_008f;
						}
						if (int_8 == int_6)
						{
							return true;
						}
						goto IL_00a6;
					}
					continue;
					IL_00a6:
					int_2 = 4;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_8(cO_, num8, num6, num2, num3, num, b, this, CO_);
				throw;
			}
		}

		public Class12 method_1()
		{
			byte[] array = default(byte[]);
			try
			{
				do
				{
					array = new byte[int_3];
				}
				while (false);
				Array.Copy(byte_1, 0, array, 0, int_3);
				return new Class12(array);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, array, this);
				throw;
			}
		}

		public Class12 method_2()
		{
			byte[] array2 = default(byte[]);
			try
			{
				byte[] array = new byte[int_4];
				if (4u != 0)
				{
					array2 = array;
				}
				Class12 result = default(Class12);
				if (6u != 0)
				{
					Array.Copy(byte_1, int_3, array2, 0, int_4);
					if (0 == 0)
					{
						return new Class12(array2);
					}
					return result;
				}
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, array2, this);
				throw;
			}
		}
	}

	internal sealed class Class14
	{
		private int int_0 = 16;

		private long long_0 = 0L;

		private Class18 class18_0;

		private Class17 class17_0;

		public Class14()
		{
			try
			{
				class18_0 = new Class18();
				class17_0 = new Class17(class18_0);
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		[SpecialName]
		public long method_0()
		{
			try
			{
				return long_0;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public void method_1()
		{
			try
			{
				if (true)
				{
					int_0 |= 12;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_2()
		{
			try
			{
				bool result;
				do
				{
					int num;
					if (int_0 != 30)
					{
						num = 0;
						if (num == 0)
						{
							result = (byte)num != 0;
							continue;
						}
					}
					else
					{
						num = (class18_0.method_5() ? 1 : 0);
					}
					result = (byte)num != 0;
					if (0 == 0)
					{
						return result;
					}
				}
				while (3 == 0);
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_3()
		{
			try
			{
				return class17_0.method_8();
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public void method_4(byte[] CO_)
		{
			try
			{
				class17_0.method_7(CO_);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		public int method_5(byte[] CO_)
		{
			int num2 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			int num7 = default(int);
			int num11 = default(int);
			try
			{
				int num = 0;
				while (true)
				{
					num2 = num;
					num = CO_.Length;
					while (true)
					{
						num3 = num;
						int num4 = num3;
						if (0 == 0)
						{
							num5 = num4;
						}
						while (true)
						{
							int num6 = class18_0.method_6(CO_, num2, num3);
							do
							{
								num7 = num6;
								num6 = num2 + num7;
							}
							while (false);
							num2 = num6;
							long_0 += num7;
							num3 -= num7;
							int num8 = num3;
							int num9;
							int num10;
							if (0 == 0)
							{
								if (num8 != 0 && int_0 != 30)
								{
									if (class17_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
									{
										continue;
									}
									if (int_0 != 16)
									{
										num9 = int_0;
										num10 = 20;
										if (num10 != 0)
										{
											if (num10 != 0)
											{
												if (num9 == num10)
												{
													if (true)
													{
														num9 = 8;
														num10 = -class18_0.method_2() & 7;
														goto IL_00e8;
													}
													goto IL_00f2;
												}
												num9 = int_0;
												num10 = 28;
											}
											if (num9 == num10)
											{
												class18_0.method_3();
												int_0 = 30;
											}
											continue;
										}
										goto IL_00e8;
									}
									return num5 - num3;
								}
								return num5 - num3;
							}
							goto IL_00e9;
							IL_00e9:
							num11 = num8;
							goto IL_00f2;
							IL_00e8:
							num8 = num9 + num10;
							goto IL_00e9;
							IL_00f2:
							while (num11 > 0)
							{
								class18_0.method_4(2, 10);
								num = num11 - 10;
								if (5 == 0)
								{
									goto end_IL_0028;
								}
								if (false)
								{
									goto end_IL_001f;
								}
								num11 = num;
							}
							int_0 = 16;
							continue;
							end_IL_0028:
							break;
						}
						continue;
						end_IL_001f:
						break;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_7(cO_, num2, num3, num5, num7, num11, this, CO_);
				throw;
			}
		}
	}

	internal sealed class Class15
	{
		public sealed class Class16
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private short[] short_1;

			private int[] int_2;

			private int int_3;

			private Class15 class15_0;

			public Class16(Class15 CO_, int CO_, int CO_, int CO_)
			{
				try
				{
					class15_0 = CO_;
					int_0 = CO_;
					int_3 = CO_;
					short_0 = new short[CO_];
					int_2 = new int[CO_];
				}
				catch (Exception cO_)
				{
					Class29.smethod_5(cO_, this, CO_, CO_, CO_, CO_);
					throw;
				}
			}

			public void method_0(int CO_)
			{
				try
				{
					do
					{
						if (uint.MaxValue != 0)
						{
							class15_0.class18_0.method_4(short_1[CO_] & 0xFFFF, byte_0[CO_]);
						}
					}
					while (false || false || -1 == 0);
				}
				catch (Exception cO_)
				{
					Class29.smethod_2(cO_, this, CO_);
					throw;
				}
			}

			public void method_1(short[] CO_, byte[] CO_)
			{
				try
				{
					while (true)
					{
						if (8u != 0 && 5u != 0)
						{
							short_1 = CO_;
							goto IL_0005;
						}
						goto IL_000f;
						IL_000f:
						if (2u != 0)
						{
							break;
						}
						goto IL_0005;
						IL_0005:
						if (false)
						{
							continue;
						}
						byte_0 = CO_;
						goto IL_000f;
					}
				}
				catch (Exception cO_)
				{
					Class29.smethod_3(cO_, this, CO_, CO_);
					throw;
				}
			}

			public void method_2()
			{
				int[] array = default(int[]);
				int num = default(int);
				int num2 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				int[] array2 = default(int[]);
				nint num9 = default(nint);
				try
				{
					while (true)
					{
						array = new int[int_3];
						num = 0;
						short_1 = new short[short_0.Length];
						num2 = 0;
						while (true)
						{
							if (3 == 0)
							{
								return;
							}
							int num3;
							int num4;
							int num5;
							if (num2 < int_3)
							{
								array[num2] = num;
								if (false)
								{
									break;
								}
								num3 = num;
								if (0 == 0)
								{
									num4 = int_2[num2] << 15 - num2;
									if (0 == 0)
									{
										num5 = num3 + num4;
										if (5u != 0)
										{
											num = num5;
											num2++;
											continue;
										}
										goto IL_0065;
									}
									goto IL_00a5;
								}
								goto IL_00af;
							}
							num6 = 0;
							if (7 == 0)
							{
								break;
							}
							goto IL_009e;
							IL_0065:
							if (num5 > 0)
							{
								short_1[num6] = smethod_0(array[num7 - 1]);
								int[] array3 = (array2 = array);
								int num8 = num7 - 1;
								num9 = num8;
								array3[num8] = array2[num9] + (1 << 16 - num7);
							}
							int num10 = num6;
							do
							{
								num10++;
							}
							while (6 == 0);
							num6 = num10;
							goto IL_009e;
							IL_00af:
							num7 = num3;
							num5 = num7;
							goto IL_0065;
							IL_009e:
							num3 = num6;
							num4 = int_1;
							goto IL_00a5;
							IL_00a5:
							if (num3 < num4)
							{
								num3 = byte_0[num6];
								goto IL_00af;
							}
							return;
						}
					}
				}
				catch (Exception cO_)
				{
					Class29.smethod_8(cO_, array, num, num2, num6, num7, array2, num9, this);
					throw;
				}
			}

			private void method_3(int[] CO_)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int[] array = default(int[]);
				int num7 = default(int);
				int[] array2 = default(int[]);
				nint num10 = default(nint);
				int num12 = default(int);
				int num13 = default(int);
				int num14 = default(int);
				int num16 = default(int);
				int num18 = default(int);
				int num21 = default(int);
				int num23 = default(int);
				int num24 = default(int);
				try
				{
					byte_0 = new byte[short_0.Length];
					num = CO_.Length / 2;
					num2 = (num + 1) / 2;
					num3 = 0;
					num4 = 0;
					while (true)
					{
						int num5;
						int num6;
						if (num4 < int_3)
						{
							int_2[num4] = 0;
							num5 = num4;
							num6 = 1;
							goto IL_0033;
						}
						if (3u != 0)
						{
							array = new int[num];
							array[num - 1] = 0;
							num7 = num - 1;
							goto IL_0135;
						}
						goto IL_021b;
						IL_0135:
						num5 = num7;
						num6 = 0;
						if (num6 != 0)
						{
							goto IL_0033;
						}
						if (num5 < num6)
						{
							if (num3 == 0)
							{
								break;
							}
							goto IL_0146;
						}
						int num8 = CO_[2 * num7 + 1];
						goto IL_01a0;
						IL_0059:
						int[] array3 = (array2 = int_2);
						int num9 = int_3 - 1;
						num10 = num9;
						array3[num9] = array2[num10] + num3;
						goto IL_021b;
						IL_021b:
						while (0 == 0)
						{
							int[] array4 = (array2 = int_2);
							int num11 = int_3 - 2;
							num10 = num11;
							array4[num11] = array2[num10] - num3;
							num12 = 2 * num2;
							if (false)
							{
								continue;
							}
							goto IL_00a1;
						}
						goto IL_0059;
						IL_00a1:
						num13 = int_3;
						while (true)
						{
							if (num13 == 0)
							{
								return;
							}
							num8 = int_2[num13 - 1];
							if (1 == 0)
							{
								break;
							}
							num14 = num8;
							int num15;
							while (true)
							{
								if (num14 > 0)
								{
									num15 = 2;
									if (num15 == 0)
									{
										break;
									}
									num16 = num15 * CO_[num12++];
									if (CO_[num16 + 1] == -1)
									{
										byte_0[CO_[num16]] = (byte)num13;
										num14--;
									}
									continue;
								}
								num15 = num13 - 1;
								break;
							}
							num13 = num15;
						}
						goto IL_01a0;
						IL_0146:
						int num17 = int_3;
						if (3u != 0)
						{
							num18 = num17 - 1;
							while (true)
							{
								if (int_2[--num18] != 0)
								{
									do
									{
										int[] array5 = (array2 = int_2);
										int num19 = num18;
										num10 = num19;
										array5[num19] = array2[num10] - 1;
										int[] array6 = (array2 = int_2);
										int num20 = ++num18;
										num10 = num20;
										array6[num20] = array2[num10] + 1;
										num3 -= 1 << int_3 - 1 - num18;
									}
									while (num3 > 0 && num18 < int_3 - 1);
									if (num3 <= 0)
									{
										break;
									}
								}
							}
							goto IL_0059;
						}
						goto IL_014f;
						IL_01a0:
						if (num8 == -1)
						{
							num21 = array[num7];
							int[] array7 = (array2 = int_2);
							int num22 = num21 - 1;
							num10 = num22;
							array7[num22] = array2[num10] + 1;
							byte_0[CO_[2 * num7]] = (byte)array[num7];
							goto IL_0187;
						}
						num17 = array[num7];
						goto IL_014f;
						IL_014f:
						num23 = num17 + 1;
						if (num23 > int_3)
						{
							if (false)
							{
								goto IL_0146;
							}
							num23 = int_3;
							num3++;
						}
						num24 = (array[CO_[2 * num7]] = (array[CO_[2 * num7 + 1]] = num23));
						goto IL_0187;
						IL_0033:
						num4 = num5 + num6;
						continue;
						IL_0187:
						num7--;
						goto IL_0135;
					}
				}
				catch (Exception cO_)
				{
					Class29.smethod_10(cO_, new object[18]
					{
						num, num2, num3, num4, array, num7, num23, num21, num18, num12,
						num13, num14, num16, num24, array2, num10, this, CO_
					});
					throw;
				}
			}

			public void method_4()
			{
				int num = default(int);
				int[] array = default(int[]);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num7 = default(int);
				int num6 = default(int);
				int num8 = default(int);
				int num9 = default(int);
				int num10 = default(int);
				int[] array2 = default(int[]);
				int[] array3 = default(int[]);
				int num13 = default(int);
				int num15 = default(int);
				int num16 = default(int);
				int num18 = default(int);
				int num19 = default(int);
				int num20 = default(int);
				int num21 = default(int);
				int num24 = default(int);
				int num26 = default(int);
				int num27 = default(int);
				try
				{
					num = short_0.Length;
					int num2 = num;
					if (0 == 0)
					{
						array = new int[num2];
						num3 = 0;
						num4 = 0;
						num5 = 0;
						goto IL_0027;
					}
					goto IL_0072;
					IL_003b:
					num5++;
					goto IL_0027;
					IL_0072:
					if (num2 <= 0 || short_0[array[num7 = (num6 - 1) / 2]] <= num8)
					{
						array[num6] = num5;
						num4 = num5;
						goto IL_003b;
					}
					array[num6] = array[num7];
					num6 = num7;
					goto IL_004a;
					IL_0027:
					if (num5 < num)
					{
						num8 = short_0[num5];
						if (num8 == 0)
						{
							goto IL_003b;
						}
						num6 = num3++;
						goto IL_004a;
					}
					while (num3 < 2)
					{
						num9 = ((num4 < 2) ? (++num4) : 0);
						array[num3++] = num9;
					}
					int_1 = Math.Max(num4 + 1, int_0);
					num10 = num3;
					array2 = new int[4 * num3 - 2];
					int num11 = 2;
					int num12 = num3;
					while (true)
					{
						array3 = new int[num11 * num12 - 1];
						num13 = num10;
						while (true)
						{
							int num14 = 0;
							while (true)
							{
								IL_0272:
								num15 = num14;
								while (true)
								{
									int num17;
									if (num15 < num3)
									{
										num16 = (array2[2 * num15] = array[num15]);
										array2[2 * num15 + 1] = -1;
										array3[num15] = short_0[num16] << 8;
										array[num15] = num15;
										num11 = num15;
										num12 = 1;
										if (num12 == 0)
										{
											goto end_IL_0276;
										}
										num17 = num11 + num12;
									}
									else
									{
										while (true)
										{
											num18 = array[0];
											num19 = array[--num3];
											num20 = 0;
											num21 = 1;
											while (true)
											{
												int num22 = num21;
												int num23 = num3;
												while (num22 < num23)
												{
													num17 = num21;
													if (false)
													{
														goto end_IL_024f;
													}
													num22 = num17 + 1;
													num23 = num3;
													if (false)
													{
														continue;
													}
													goto IL_010b;
												}
												break;
												IL_010b:
												if (num22 < num23 && array3[array[num21]] > array3[array[num21 + 1]])
												{
													num21++;
												}
												array[num20] = array[num21];
												num20 = num21;
												num21 = num21 * 2 + 1;
											}
											num24 = array3[num19];
											while (true)
											{
												int num25 = (num21 = num20);
												while (num25 <= 0 || array3[array[num20 = (num21 - 1) / 2]] <= num24)
												{
													array[num21] = num19;
													num26 = array[0];
													num19 = num13++;
													array2[2 * num19] = num18;
													array2[2 * num19 + 1] = num26;
													if (false)
													{
														goto end_IL_023b;
													}
													num27 = Math.Min(array3[num18] & 0xFF, array3[num26] & 0xFF);
													num24 = (array3[num19] = array3[num18] + array3[num26] - num27 + 1);
													num20 = 0;
													for (num21 = 1; num21 < num3; num21 = num20 * 2 + 1)
													{
														if (num21 + 1 < num3 && array3[array[num21]] > array3[array[num21 + 1]])
														{
															num21++;
														}
														array[num20] = array[num21];
														num20 = num21;
													}
													while (true)
													{
														num25 = (num21 = num20);
														if (4 == 0)
														{
															break;
														}
														if (num25 > 0 && array3[array[num20 = (num21 - 1) / 2]] > num24)
														{
															array[num21] = array[num20];
															continue;
														}
														goto IL_0242;
													}
												}
												array[num21] = array[num20];
												continue;
												end_IL_023b:
												break;
											}
											goto end_IL_0268;
											IL_0242:
											array[num21] = num19;
											num14 = num3;
											if (2u != 0)
											{
												if (num14 <= 1)
												{
													method_3(array2);
													return;
												}
												continue;
											}
											goto IL_0272;
											continue;
											end_IL_024f:
											break;
										}
									}
									num15 = num17;
									continue;
									end_IL_0268:
									break;
								}
								break;
							}
							continue;
							end_IL_0276:
							break;
						}
					}
					IL_004a:
					num2 = num6;
					goto IL_0072;
				}
				catch (Exception cO_)
				{
					Class29.smethod_10(cO_, new object[23]
					{
						num, array, num3, num4, num5, num8, num6, num7, num9, num10,
						array2, array3, num13, num15, num16, num18, num19, num20, num21, num24,
						num26, num27, this
					});
					throw;
				}
			}

			public int method_5()
			{
				int num2 = default(int);
				int num4 = default(int);
				try
				{
					if (-1 == 0)
					{
						goto IL_003c;
					}
					int num = 0;
					int num3;
					if (num == 0)
					{
						num2 = num;
						num3 = 0;
						if (num3 != 0)
						{
							goto IL_000f;
						}
						num4 = num3;
						goto IL_0039;
					}
					goto IL_003d;
					IL_003c:
					num = num2;
					goto IL_003d;
					IL_0039:
					num3 = num4;
					goto IL_0012;
					IL_0012:
					if (num3 < short_0.Length)
					{
						num3 = num2;
						goto IL_000f;
					}
					goto IL_003c;
					IL_000f:
					if (false)
					{
						goto IL_0012;
					}
					num2 = num3 + short_0[num4] * byte_0[num4];
					if (0 == 0)
					{
						num4++;
						goto IL_0039;
					}
					goto IL_003c;
					IL_003d:
					return num;
				}
				catch (Exception cO_)
				{
					Class29.smethod_3(cO_, num2, num4, this);
					throw;
				}
			}

			public void method_6(Class16 CO_)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				short[] array = default(short[]);
				nint num8 = default(nint);
				try
				{
					if (0 == 0)
					{
						num = -1;
					}
					num2 = 0;
					while (num2 < int_1)
					{
						num3 = 1;
						num4 = byte_0[num2];
						if (num4 == 0)
						{
							num5 = 138;
							if (0 == 0)
							{
								num6 = 3;
							}
						}
						else
						{
							num5 = 6;
							num6 = 3;
							if (num != num4)
							{
								short[] array2 = (array = CO_.short_0);
								int num7 = num4;
								num8 = num7;
								array2[num7] = (short)(array[num8] + 1);
								num3 = 0;
							}
						}
						num = num4;
						num2++;
						while (num2 < int_1 && num == byte_0[num2])
						{
							num2++;
							if (++num3 >= num5)
							{
								break;
							}
						}
						if (num3 < num6)
						{
							short[] array3 = (array = CO_.short_0);
							int num9 = num;
							num8 = num9;
							array3[num9] = (short)(array[num8] + (short)num3);
						}
						else if (num != 0)
						{
							(array = CO_.short_0)[16] = (short)(array[16] + 1);
						}
						else if (num3 <= 10)
						{
							(array = CO_.short_0)[17] = (short)(array[17] + 1);
						}
						else
						{
							(array = CO_.short_0)[18] = (short)(array[18] + 1);
						}
					}
				}
				catch (Exception cO_)
				{
					Class29.smethod_9(cO_, num5, num6, num3, num, num2, num4, array, num8, this, CO_);
					throw;
				}
			}

			public void method_7(Class16 CO_)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num7 = default(int);
				int num8 = default(int);
				try
				{
					num = -1;
					num2 = 0;
					if (0 == 0)
					{
						goto IL_00c4;
					}
					goto IL_010b;
					IL_010b:
					CO_.method_0(num3);
					if (uint.MaxValue != 0)
					{
						num4 = 0;
						goto IL_00fd;
					}
					return;
					IL_007f:
					int num5;
					int num6;
					if (num5 > num6)
					{
						CO_.method_0(18);
						class15_0.class18_0.method_4(num4 - 11, 7);
					}
					else
					{
						if (false)
						{
							goto IL_00c1;
						}
						CO_.method_0(17);
						class15_0.class18_0.method_4(num4 - 3, 3);
					}
					goto IL_00c4;
					IL_00fd:
					num = num3;
					num2++;
					while (num2 < int_1)
					{
						if (3u != 0)
						{
							if (num != byte_0[num2])
							{
								break;
							}
							num2++;
							if (++num4 >= num7)
							{
								break;
							}
							continue;
						}
						goto IL_00f4;
					}
					if (num4 >= num8)
					{
						if (num == 0)
						{
							num5 = num4;
							num6 = 10;
							goto IL_007f;
						}
						CO_.method_0(16);
						if (0 == 0)
						{
							class15_0.class18_0.method_4(num4 - 3, 2);
							goto IL_00c1;
						}
					}
					while (num4-- > 0)
					{
						CO_.method_0(num);
					}
					goto IL_00c4;
					IL_00c4:
					num5 = num2;
					num6 = int_1;
					if (false)
					{
						goto IL_007f;
					}
					if (num5 < num6)
					{
						num4 = 1;
						goto IL_00d3;
					}
					return;
					IL_00f4:
					num8 = 3;
					if (num == num3)
					{
						goto IL_00fd;
					}
					goto IL_010b;
					IL_00c1:
					if (0 == 0)
					{
						goto IL_00c4;
					}
					goto IL_00d3;
					IL_00d3:
					byte num9 = byte_0[num2];
					if (0 == 0)
					{
						num3 = num9;
					}
					if (num3 == 0)
					{
						num7 = 138;
						num8 = 3;
						goto IL_00fd;
					}
					num7 = 6;
					goto IL_00f4;
				}
				catch (Exception cO_)
				{
					Class29.smethod_8(cO_, num7, num8, num4, num, num2, num3, this, CO_);
					throw;
				}
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class18 class18_0;

		private Class16 class16_0;

		private Class16 class16_1;

		private Class16 class16_2;

		private short[] short_0;

		private byte[] byte_1;

		private int int_1;

		private int int_2;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		private static readonly short[] short_2;

		private static readonly byte[] byte_3;

		static Class15()
		{
			int num2 = default(int);
			try
			{
				int_0 = new int[19]
				{
					16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
					11, 4, 12, 3, 13, 2, 14, 1, 15
				};
				byte_0 = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				int num = 286;
				while (true)
				{
					short_1 = new short[num];
					byte_2 = new byte[286];
					while (true)
					{
						num2 = 0;
						while (true)
						{
							num = num2;
							if (7 == 0)
							{
								break;
							}
							int num3 = 144;
							if (num3 == 0)
							{
								goto IL_008e;
							}
							if (num >= num3)
							{
								goto IL_0088;
							}
							short_1[num2] = smethod_0(48 + num2 << 8);
							if (6u != 0)
							{
								byte_2[num2++] = 8;
								continue;
							}
							goto IL_0090;
							IL_008e:
							if (num < num3)
							{
								short_1[num2] = smethod_0(256 + num2 << 7);
								byte_2[num2++] = 9;
								goto IL_0088;
							}
							goto IL_0090;
							IL_0088:
							num = num2;
							num3 = 256;
							goto IL_008e;
						}
						break;
						IL_0090:
						if (1 == 0)
						{
							continue;
						}
						while (true)
						{
							if (num2 < 280)
							{
								short_1[num2] = smethod_0(-256 + num2 << 9);
								if (0 == 0)
								{
									byte_2[num2++] = 7;
									continue;
								}
								goto IL_0142;
							}
							goto IL_0120;
							IL_0142:
							while (true)
							{
								if (num2 < 30)
								{
									short_2[num2] = smethod_0(num2 << 11);
									if (false)
									{
										break;
									}
									byte_3[num2] = 5;
									num2++;
									continue;
								}
								return;
							}
							goto IL_0120;
							IL_0120:
							while (num2 < 286)
							{
								short_1[num2] = smethod_0(-88 + num2 << 8);
								byte_2[num2++] = 8;
							}
							short_2 = new short[30];
							byte_3 = new byte[30];
							num2 = 0;
							goto IL_0142;
						}
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, num2);
				throw;
			}
		}

		public Class15(Class18 CO_)
		{
			try
			{
				class18_0 = CO_;
				class16_0 = new Class16(this, 286, 257, 15);
				class16_1 = new Class16(this, 30, 1, 15);
				class16_2 = new Class16(this, 19, 4, 7);
				short_0 = new short[16384];
				byte_1 = new byte[16384];
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		public static short smethod_0(int CO_)
		{
			try
			{
				int num = byte_0[CO_ & 0xF];
				if (true)
				{
					num <<= 12;
				}
				int num3;
				if (0 == 0)
				{
					int num2 = byte_0[(CO_ >> 4) & 0xF];
					do
					{
						num2 <<= 8;
					}
					while (-1 == 0);
					num3 = num | num2;
					goto IL_0025;
				}
				goto IL_003f;
				IL_003f:
				num3 = (short)num;
				if (0 == 0 && 0 == 0)
				{
					return (short)num3;
				}
				goto IL_0025;
				IL_0025:
				num = num3 | (byte_0[(CO_ >> 8) & 0xF] << 4) | byte_0[CO_ >> 12];
				goto IL_003f;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, CO_);
				throw;
			}
		}

		public void method_0()
		{
			try
			{
				do
				{
					if (true)
					{
						int_1 = 0;
					}
				}
				while (false);
				int_2 = 0;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		private int method_1(int CO_)
		{
			int num2 = default(int);
			try
			{
				int result;
				do
				{
					if (2 == 0)
					{
						continue;
					}
					if (CO_ == 255)
					{
						result = 285;
						continue;
					}
					int num3;
					if (0 == 0)
					{
						int num = 257;
						while (true)
						{
							num2 = num;
							while (true)
							{
								num = CO_;
								if (false)
								{
									break;
								}
								if (num < 8)
								{
									goto end_IL_0039;
								}
								num2 += 4;
								num3 = CO_ >> 1;
								if (7u != 0)
								{
									CO_ = num3;
									continue;
								}
								goto IL_003d;
							}
							continue;
							end_IL_0039:
							break;
						}
					}
					num3 = num2;
					goto IL_003d;
					IL_003d:
					return num3 + CO_;
				}
				while (4 == 0);
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num2, this, CO_);
				throw;
			}
		}

		private int method_2(int CO_)
		{
			int num2 = default(int);
			try
			{
				if (false)
				{
					goto IL_000e;
				}
				int num = 0;
				if (num == 0)
				{
					num2 = num;
					goto IL_001b;
				}
				goto IL_001c;
				IL_001b:
				num = CO_;
				goto IL_001c;
				IL_001c:
				int num3 = 4;
				goto IL_0024;
				IL_000e:
				num = CO_;
				num3 = 1;
				if (num3 == 0)
				{
					goto IL_000c;
				}
				if (num3 != 0)
				{
					CO_ = num >> num3;
					goto IL_001b;
				}
				goto IL_0024;
				IL_0024:
				while (num < num3)
				{
					num = num2;
					num3 = CO_;
					if (0 == 0)
					{
						return num + num3;
					}
				}
				num = num2;
				num3 = 2;
				goto IL_000c;
				IL_000c:
				num2 = num + num3;
				goto IL_000e;
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num2, this, CO_);
				throw;
			}
		}

		public void method_3(int CO_)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					class16_2.method_2();
					class16_0.method_2();
					class16_1.method_2();
					if (2u != 0 && 8u != 0)
					{
						Class18 @class = class18_0;
						int cO_ = class16_0.int_1 - 257;
						if (0 == 0)
						{
							@class.method_4(cO_, 5);
						}
						do
						{
							class18_0.method_4(class16_1.int_1 - 1, 5);
							class18_0.method_4(CO_ - 4, 4);
							num = 0;
						}
						while (2 == 0);
						goto IL_004f;
					}
					goto IL_0053;
					IL_0051:
					int num2;
					int num3;
					if (num2 >= num3)
					{
						class16_0.method_7(class16_2);
						class16_1.method_7(class16_2);
						break;
					}
					goto IL_0053;
					IL_0053:
					if (2u != 0)
					{
						class18_0.method_4(class16_2.byte_0[int_0[num]], 3);
						if (false)
						{
							continue;
						}
						num2 = num;
						num3 = 1;
						if (num3 != 0)
						{
							num = num2 + num3;
							goto IL_004f;
						}
						goto IL_0051;
					}
					break;
					IL_004f:
					num2 = num;
					num3 = CO_;
					goto IL_0051;
				}
			}
			catch (Exception cO_2)
			{
				Class29.smethod_3(cO_2, num, this, CO_);
				throw;
			}
		}

		public void method_4()
		{
			int num = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num11 = default(int);
			try
			{
				if (8u != 0)
				{
					num = 0;
					goto IL_0042;
				}
				goto IL_00e2;
				IL_0042:
				int num2 = num;
				if (0 == 0)
				{
					if (num2 >= int_1)
					{
						class16_0.method_0(256);
						if (4u != 0)
						{
							return;
						}
						goto IL_000a;
					}
					num2 = byte_1[num] & 0xFF;
				}
				num3 = num2;
				num4 = short_0[num];
				int num5 = num4--;
				while (true)
				{
					if (num5 != 0)
					{
						num6 = method_1(num3);
						class16_0.method_0(num6);
						if (false)
						{
							break;
						}
						num5 = num6;
						if (false)
						{
							continue;
						}
						goto IL_00b6;
					}
					class16_0.method_0(num3);
					break;
				}
				goto IL_003b;
				IL_00e2:
				num7 = method_2(num4);
				goto IL_000a;
				IL_000a:
				class16_1.method_0(num7);
				int num8 = num7;
				int num9 = 2;
				goto IL_001a;
				IL_001a:
				int num10 = num8 / num9 - 1;
				if (0 == 0)
				{
					num11 = num10;
					num10 = num11;
				}
				if (num10 > 0)
				{
					class18_0.method_4(num4 & ((1 << num11) - 1), num11);
				}
				goto IL_003b;
				IL_00b6:
				num11 = (num5 - 261) / 4;
				if (num11 > 0 && num11 <= 5)
				{
					class18_0.method_4(num3 & ((1 << num11) - 1), num11);
				}
				goto IL_00e2;
				IL_003b:
				num8 = num;
				num9 = 1;
				if (num9 == 0)
				{
					goto IL_001a;
				}
				num = num8 + num9;
				goto IL_0042;
			}
			catch (Exception cO_)
			{
				Class29.smethod_7(cO_, num, num3, num4, num6, num11, num7, this);
				throw;
			}
		}

		public void method_5(byte[] CO_, int CO_, int CO_, bool CO_)
		{
			try
			{
				if (0 == 0)
				{
					class18_0.method_4(CO_ ? 1 : 0, 3);
				}
				class18_0.method_3();
				if (0 == 0)
				{
					class18_0.method_0(CO_);
					goto IL_0031;
				}
				goto IL_004c;
				IL_004c:
				if (0 == 0)
				{
					method_0();
					return;
				}
				goto IL_0031;
				IL_0031:
				class18_0.method_0(~CO_);
				class18_0.method_1(CO_, CO_, CO_);
				goto IL_004c;
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, this, CO_, CO_, CO_, CO_);
				throw;
			}
		}

		public void method_6(byte[] CO_, int CO_, int CO_, bool CO_)
		{
			short[] array = default(short[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int i = default(int);
			int j = default(int);
			try
			{
				(array = class16_0.short_0)[256] = (short)(array[256] + 1);
				class16_0.method_4();
				class16_1.method_4();
				class16_0.method_6(class16_2);
				class16_1.method_6(class16_2);
				class16_2.method_4();
				num = 4;
				for (num2 = 18; num2 > num; num2--)
				{
					if (class16_2.byte_0[int_0[num2]] > 0)
					{
						num = num2 + 1;
					}
				}
				num3 = 14 + num * 3 + class16_2.method_5() + class16_0.method_5() + class16_1.method_5() + int_2;
				num4 = int_2;
				for (i = 0; i < 286; i++)
				{
					num4 += class16_0.short_0[i] * byte_2[i];
				}
				for (j = 0; j < 30; j++)
				{
					num4 += class16_1.short_0[j] * byte_3[j];
				}
				if (num3 >= num4)
				{
					num3 = num4;
				}
				if (CO_ >= 0 && CO_ + 4 < num3 >> 3)
				{
					method_5(CO_, CO_, CO_, CO_);
				}
				else if (num3 == num4)
				{
					class18_0.method_4(2 + (CO_ ? 1 : 0), 3);
					class16_0.method_1(short_1, byte_2);
					class16_1.method_1(short_2, byte_3);
					method_4();
					method_0();
				}
				else
				{
					class18_0.method_4(4 + (CO_ ? 1 : 0), 3);
					method_3(num);
					method_4();
					method_0();
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_10(cO_, new object[12]
				{
					num, num2, num3, num4, i, j, array, this, CO_, CO_,
					CO_, CO_
				});
				throw;
			}
		}

		public bool method_7()
		{
			try
			{
				bool result;
				do
				{
					if (8u != 0)
					{
						bool num = int_1 < 16384;
						do
						{
							num = !num;
						}
						while (2 == 0);
						result = num;
					}
				}
				while ((5 == 0) ? true : false);
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public bool method_8(int CO_)
		{
			int num = default(int);
			short[] array2 = default(short[]);
			nint num2 = default(nint);
			try
			{
				short_0[int_1] = 0;
				byte[] array = byte_1;
				num = int_1++;
				array[num] = (byte)CO_;
				short[] array3 = (array2 = class16_0.short_0);
				num2 = CO_;
				array3[CO_] = (short)(array2[num2] + 1);
				return method_7();
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num, array2, num2, this, CO_);
				throw;
			}
		}

		public bool method_9(int CO_, int CO_)
		{
			int num = default(int);
			int num2 = default(int);
			short[] array2 = default(short[]);
			nint num4 = default(nint);
			int num5 = default(int);
			try
			{
				short_0[int_1] = (short)CO_;
				byte[] array = byte_1;
				num = int_1++;
				array[num] = (byte)(CO_ - 3);
				num2 = method_1(CO_ - 3);
				short[] array3 = (array2 = class16_0.short_0);
				int num3 = num2;
				num4 = num3;
				array3[num3] = (short)(array2[num4] + 1);
				if (num2 >= 265 && num2 < 285)
				{
					int_2 += (num2 - 261) / 4;
				}
				num5 = method_2(CO_ - 1);
				short[] array4 = (array2 = class16_1.short_0);
				int num6 = num5;
				num4 = num6;
				array4[num6] = (short)(array2[num4] + 1);
				if (num5 >= 4)
				{
					int_2 += num5 / 2 - 1;
				}
				return method_7();
			}
			catch (Exception cO_)
			{
				Class29.smethod_8(cO_, num2, num5, num, array2, num4, this, CO_, CO_);
				throw;
			}
		}
	}

	internal sealed class Class17
	{
		private int int_0;

		private short[] short_0;

		private short[] short_1;

		private int int_1;

		private int int_2;

		private bool bool_0;

		private int int_3;

		private int int_4;

		private int int_5;

		private byte[] byte_0;

		private byte[] byte_1;

		private int int_6;

		private int int_7;

		private int int_8;

		private Class18 class18_0;

		private Class15 class15_0;

		public Class17(Class18 CO_)
		{
			int num = default(int);
			try
			{
				class18_0 = CO_;
				class15_0 = new Class15(CO_);
				byte_0 = new byte[65536];
				short_0 = new short[32768];
				short_1 = new short[32768];
				num = (int_3 = (int_4 = 1));
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num, this, CO_);
				throw;
			}
		}

		private void method_0()
		{
			try
			{
				int_0 = (byte_0[int_4] << 5) ^ byte_0[int_4 + 1];
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		private int method_1()
		{
			int num3 = default(int);
			short num6 = default(short);
			try
			{
				do
				{
					int num = int_0;
					int num2 = 5;
					if (num2 != 0)
					{
						if (num2 == 0)
						{
							goto IL_0010;
						}
						num <<= num2;
						num2 = byte_0[int_4 + 2];
					}
					num ^= num2;
					num2 = 32767;
					goto IL_0010;
					IL_0010:
					num3 = num & num2;
					short[] array = short_1;
					int num4 = int_4 & 0x7FFF;
					short num5 = short_0[num3];
					if (6u != 0)
					{
						num6 = num5;
					}
					array[num4] = num5;
					short_0[num3] = (short)int_4;
				}
				while (false);
				int_0 = num3;
				return num6 & 0xFFFF;
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num6, num3, this);
				throw;
			}
		}

		private void method_2()
		{
			int i = default(int);
			int num = default(int);
			int num2 = default(int);
			int num5 = default(int);
			try
			{
				Array.Copy(byte_0, 32768, byte_0, 0, 32768);
				do
				{
					int_1 -= 32768;
					int_4 -= 32768;
					int_3 -= 32768;
				}
				while (false);
				for (i = 0; i < 32768; i++)
				{
					num = short_0[i] & 0xFFFF;
					short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = 32768;
					if (num4 != 0)
					{
						if (num3 >= num4)
						{
							break;
						}
						num5 = short_1[num2] & 0xFFFF;
						short_1[num2] = (short)((num5 >= 32768) ? (num5 - 32768) : 0);
						num3 = num2;
						num4 = 1;
					}
					num2 = num3 + num4;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, i, num, num2, num5, this);
				throw;
			}
		}

		public void method_3()
		{
			int num3 = default(int);
			try
			{
				int num = int_4;
				int num2 = 65274;
				if (num2 == 0)
				{
					goto IL_0024;
				}
				if (num >= num2)
				{
					method_2();
					if (false)
					{
						return;
					}
				}
				goto IL_00c2;
				IL_0026:
				Array.Copy(byte_1, int_7, byte_0, int_4 + int_5, num3);
				int_7 += num3;
				int_6 += num3;
				int_5 += num3;
				goto IL_00c2;
				IL_00c2:
				while (int_5 >= 262 || int_7 >= int_8)
				{
					if (0 == 0)
					{
						if (int_5 >= 3)
						{
							method_0();
						}
						return;
					}
				}
				num3 = 65536 - int_5 - int_4;
				if (num3 > int_8 - int_7)
				{
					num = int_8;
					num2 = int_7;
					goto IL_0024;
				}
				goto IL_0026;
				IL_0024:
				num3 = num - num2;
				goto IL_0026;
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, num3, this);
				throw;
			}
		}

		private bool method_4(int CO_)
		{
			int num = default(int);
			int num2 = default(int);
			short[] array = default(short[]);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num9 = default(int);
			byte b = default(byte);
			byte b2 = default(byte);
			int num10 = default(int);
			try
			{
				num = 128;
				num2 = 128;
				array = short_1;
				num3 = int_4;
				num4 = int_4 + int_2;
				num5 = Math.Max(int_2, 2);
				num6 = Math.Max(int_4 - 32506, 0);
				int num7 = int_4;
				int num8 = 258;
				if (num8 == 0)
				{
					goto IL_0097;
				}
				num9 = num7 + num8 - 1;
				b = byte_0[num4 - 1];
				b2 = byte_0[num4];
				if (num5 >= 8)
				{
					num >>= 2;
				}
				if (num2 > int_5)
				{
					num2 = int_5;
				}
				goto IL_0243;
				IL_0257:
				int_2 = Math.Min(num5, int_5);
				return int_2 >= 3;
				IL_0243:
				if (byte_0[CO_ + num5] == b2 && byte_0[CO_ + num5 - 1] == b && byte_0[CO_] == byte_0[num3] && byte_0[CO_ + 1] == byte_0[num3 + 1])
				{
					num10 = CO_ + 2;
					num3 += 2;
					while (byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && byte_0[++num3] == byte_0[++num10] && num3 < num9)
					{
					}
					if (num3 > num4)
					{
						int_1 = CO_;
						num4 = num3;
						num5 = num3 - int_4;
						if (num5 >= num2)
						{
							goto IL_0257;
						}
						b = byte_0[num4 - 1];
						b2 = byte_0[num4];
					}
					num3 = int_4;
				}
				if ((CO_ = array[CO_ & 0x7FFF] & 0xFFFF) > num6)
				{
					num7 = num;
					num8 = 1;
					goto IL_0097;
				}
				goto IL_0257;
				IL_0097:
				if ((num = num7 - num8) != 0)
				{
					goto IL_0243;
				}
				goto IL_0257;
			}
			catch (Exception cO_)
			{
				Class29.smethod_10(cO_, new object[13]
				{
					num, num2, array, num3, num10, num4, num5, num6, num9, b,
					b2, this, CO_
				});
				throw;
			}
		}

		private bool method_5(bool CO_, bool CO_)
		{
			int num3 = default(int);
			int num4 = default(int);
			int num7 = default(int);
			int num10 = default(int);
			bool flag = default(bool);
			try
			{
				if (int_5 < 262 && !CO_)
				{
					return false;
				}
				while (int_5 >= 262 || CO_)
				{
					int num = int_5;
					while (true)
					{
						if (num != 0)
						{
							int num2 = int_4;
							while (true)
							{
								if (num2 >= 65274)
								{
									method_2();
								}
								num3 = int_1;
								num4 = int_2;
								int num5 = int_5;
								int num6 = 3;
								int num8;
								int num9;
								while (true)
								{
									if (num5 >= num6)
									{
										num7 = method_1();
										while ((1 == 0 || (num7 != 0 && int_4 - num7 <= 32506 && method_4(num7) && int_2 <= 5)) && int_2 == 3 && int_4 - int_1 > 4096)
										{
											if (0 == 0)
											{
												int_2 = 2;
												break;
											}
										}
									}
									num = num4;
									if (4 == 0)
									{
										break;
									}
									if (num >= 3)
									{
										num8 = int_2;
										goto IL_00ab;
									}
									goto IL_01c9;
									IL_00ab:
									if (num8 <= num4)
									{
										class15_0.method_9(int_4 - 1 - num3, num4);
										num5 = num4;
										num6 = 2;
										if (num6 == 0)
										{
											continue;
										}
										num4 = num5 - num6;
										do
										{
											int_4++;
											int_5--;
											if (int_5 >= 3)
											{
												method_1();
											}
										}
										while (--num4 > 0);
										int_4++;
										int_5--;
										bool_0 = false;
										int_2 = 2;
										goto IL_0138;
									}
									goto IL_01c9;
									IL_0187:
									num10 = num8 - num9;
									goto IL_019e;
									IL_01c9:
									if (bool_0)
									{
										class15_0.method_8(byte_0[int_4 - 1] & 0xFF);
									}
									bool_0 = true;
									int_4++;
									int_5--;
									goto IL_0138;
									IL_0138:
									if (!class15_0.method_7())
									{
										goto end_IL_0272;
									}
									num10 = int_4 - int_3;
									if (bool_0)
									{
										num8 = num10;
										if (false)
										{
											goto IL_00ab;
										}
										num9 = 1;
										goto IL_0187;
									}
									goto IL_019e;
									IL_019e:
									flag = CO_ && int_5 == 0 && !bool_0;
									class15_0.method_6(byte_0, int_3, num10, flag);
									int_3 += num10;
									if (7 == 0)
									{
										goto IL_01c9;
									}
									num8 = (flag ? 1 : 0);
									num9 = 0;
									if (num9 != 0)
									{
										goto IL_0187;
									}
									goto IL_0251;
								}
								break;
								IL_0251:
								num2 = ((num8 == num9) ? 1 : 0);
								if (4u != 0)
								{
									return (byte)num2 != 0;
								}
							}
							continue;
						}
						if (bool_0)
						{
							class15_0.method_8(byte_0[int_4 - 1] & 0xFF);
						}
						bool_0 = false;
						class15_0.method_6(byte_0, int_3, int_4 - int_3, CO_);
						int_3 = int_4;
						return false;
						continue;
						end_IL_0272:
						break;
					}
				}
				return true;
			}
			catch (Exception cO_)
			{
				Class29.smethod_8(cO_, num3, num4, num7, num10, flag, this, CO_, CO_);
				throw;
			}
		}

		public bool method_6(bool CO_, bool CO_)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			try
			{
				bool result;
				while (true)
				{
					method_3();
					int num = (CO_ ? 1 : 0);
					if (0 == 0)
					{
						if (num != 0)
						{
							num = ((int_7 == int_8) ? 1 : 0);
						}
						else
						{
							if (false)
							{
								goto IL_000c;
							}
							num = 0;
						}
					}
					goto IL_002c;
					IL_002c:
					flag = (byte)num != 0;
					goto IL_000c;
					IL_000c:
					num = (method_5(flag, CO_) ? 1 : 0);
					if (0 == 0)
					{
						flag2 = (byte)num != 0;
						if (class18_0.method_5() && flag2)
						{
							continue;
						}
						num = (flag2 ? 1 : 0);
					}
					if (0 == 0)
					{
						result = (byte)num != 0;
						if (3u != 0)
						{
							break;
						}
						continue;
					}
					goto IL_002c;
				}
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, flag2, flag, this, CO_, CO_);
				throw;
			}
		}

		public void method_7(byte[] CO_)
		{
			try
			{
				do
				{
					byte_1 = CO_;
					int_7 = 0;
					int_8 = CO_.Length;
				}
				while (3 == 0);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		public bool method_8()
		{
			try
			{
				return int_8 == int_7;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}
	}

	internal sealed class Class18
	{
		protected byte[] byte_0 = new byte[65536];

		private int int_0 = 0;

		private int int_1 = 0;

		private uint uint_0 = 0u;

		private int int_2 = 0;

		public void method_0(int CO_)
		{
			int num = default(int);
			try
			{
				byte[] array = byte_0;
				num = int_1++;
				array[num] = (byte)CO_;
				byte[] array2 = byte_0;
				num = int_1++;
				array2[num] = (byte)(CO_ >> 8);
			}
			catch (Exception cO_)
			{
				Class29.smethod_3(cO_, num, this, CO_);
				throw;
			}
		}

		public void method_1(byte[] CO_, int CO_, int CO_)
		{
			try
			{
				byte[] destinationArray = byte_0;
				int destinationIndex = int_1;
				if (0 == 0)
				{
					Array.Copy(CO_, CO_, destinationArray, destinationIndex, CO_);
				}
				int_1 += CO_;
			}
			catch (Exception cO_)
			{
				Class29.smethod_4(cO_, this, CO_, CO_, CO_);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			try
			{
				return int_2;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public void method_3()
		{
			int num2 = default(int);
			try
			{
				int num = int_2;
				while (true)
				{
					if (false)
					{
						goto IL_0009;
					}
					if (num <= 0)
					{
						goto IL_003c;
					}
					byte[] array = byte_0;
					num2 = int_1++;
					array[num2] = (byte)uint_0;
					goto IL_0046;
					IL_0009:
					if (7 == 0)
					{
						continue;
					}
					if (num > 8)
					{
						goto IL_001b;
					}
					goto IL_003c;
					IL_001b:
					byte[] array2 = byte_0;
					num2 = int_1++;
					array2[num2] = (byte)(uint_0 >> 8);
					goto IL_003c;
					IL_003c:
					uint_0 = 0u;
					if (uint.MaxValue != 0)
					{
						int_2 = 0;
						if (0 == 0)
						{
							break;
						}
						goto IL_001b;
					}
					goto IL_0046;
					IL_0046:
					num = int_2;
					goto IL_0009;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, num2, this);
				throw;
			}
		}

		public void method_4(int CO_, int CO_)
		{
			int num = default(int);
			try
			{
				uint_0 |= (uint)(CO_ << int_2);
				int_2 += CO_;
				if (int_2 < 16)
				{
					return;
				}
				do
				{
					if (uint.MaxValue != 0)
					{
						byte[] array = byte_0;
						num = int_1++;
						array[num] = (byte)uint_0;
						byte[] array2 = byte_0;
						num = int_1++;
						array2[num] = (byte)(uint_0 >> 8);
						uint_0 >>= 16;
					}
				}
				while (8 == 0);
				int_2 -= 16;
			}
			catch (Exception cO_)
			{
				Class29.smethod_4(cO_, num, this, CO_, CO_);
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			try
			{
				bool result;
				do
				{
					result = int_1 == 0;
				}
				while (false);
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public int method_6(byte[] CO_, int CO_, int CO_)
		{
			int num = default(int);
			try
			{
				if (int_2 >= 8)
				{
					byte[] array = byte_0;
					num = int_1++;
					array[num] = (byte)uint_0;
					uint_0 >>= 8;
					int_2 -= 8;
				}
				if (CO_ > int_1 - int_0)
				{
					CO_ = int_1 - int_0;
					Array.Copy(byte_0, int_0, CO_, CO_, CO_);
					int_0 = 0;
					int_1 = 0;
				}
				else
				{
					Array.Copy(byte_0, int_0, CO_, CO_, CO_);
					int_0 += CO_;
				}
				return CO_;
			}
			catch (Exception cO_)
			{
				Class29.smethod_5(cO_, num, this, CO_, CO_, CO_);
				throw;
			}
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public Stream0()
		{
		}

		public Stream0(byte[] CO_)
			: base(CO_, writable: false)
		{
		}

		public void method_0(int CO_)
		{
			try
			{
				while (true)
				{
					if (uint.MaxValue != 0)
					{
						WriteByte((byte)((uint)CO_ & 0xFFu));
						goto IL_0005;
					}
					goto IL_001c;
					IL_0005:
					WriteByte((byte)((uint)(CO_ >> 8) & 0xFFu));
					goto IL_001c;
					IL_001c:
					if (0 == 0 && 0 == 0)
					{
						if (uint.MaxValue != 0)
						{
							break;
						}
						continue;
					}
					goto IL_0005;
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		public void method_1(int CO_)
		{
			try
			{
				do
				{
					method_0(CO_);
					method_0(CO_ >> 16);
				}
				while (false);
			}
			catch (Exception cO_)
			{
				Class29.smethod_2(cO_, this, CO_);
				throw;
			}
		}

		public int method_2()
		{
			try
			{
				if (4u != 0)
				{
					int num = ReadByte();
					do
					{
						int num2 = ReadByte();
						do
						{
							num2 <<= 8;
						}
						while (false);
						num |= num2;
					}
					while (false);
					return num;
				}
				int result;
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}

		public int method_3()
		{
			try
			{
				if (4u != 0)
				{
					int num = method_2();
					do
					{
						int num2 = method_2();
						do
						{
							num2 <<= 16;
						}
						while (false);
						num |= num2;
					}
					while (false);
					return num;
				}
				int result;
				return result;
			}
			catch (Exception cO_)
			{
				Class29.smethod_1(cO_, this);
				throw;
			}
		}
	}

	public static string string_0;

	private static bool smethod_0(Assembly CO_, Assembly CO_)
	{
		byte[] publicKey = default(byte[]);
		byte[] publicKey2 = default(byte[]);
		int num2 = default(int);
		try
		{
			while (true)
			{
				publicKey = CO_.GetName().GetPublicKey();
				while (true)
				{
					int num;
					if (0 == 0)
					{
						publicKey2 = CO_.GetName().GetPublicKey();
						num = ((publicKey2 == null) ? 1 : 0);
						if (0 == 0)
						{
							if (num != ((publicKey == null) ? 1 : 0))
							{
								return false;
							}
							goto IL_000e;
						}
						goto IL_0018;
					}
					goto IL_002f;
					IL_0029:
					if (num2 < publicKey2.Length)
					{
						num = publicKey2[num2];
						goto IL_0018;
					}
					goto IL_002f;
					IL_000e:
					if (publicKey2 != null)
					{
						num2 = 0;
						goto IL_0029;
					}
					goto IL_002f;
					IL_0018:
					if (uint.MaxValue != 0)
					{
						if (num == publicKey[num2])
						{
							if (false)
							{
								continue;
							}
							num2++;
							goto IL_0029;
						}
						if (4 == 0)
						{
							break;
						}
						num = 0;
					}
					return (byte)num != 0;
					IL_002f:
					bool result = true;
					if (0 == 0)
					{
						return result;
					}
					goto IL_000e;
				}
			}
		}
		catch (Exception cO_)
		{
			Class29.smethod_5(cO_, publicKey, publicKey2, num2, CO_, CO_);
			throw;
		}
	}

	public static byte[] smethod_1(byte[] CO_)
	{
		Assembly assembly = default(Assembly);
		Assembly executingAssembly = default(Assembly);
		Stream0 stream = default(Stream0);
		byte[] array = default(byte[]);
		int num2 = default(int);
		short num3 = default(short);
		int num4 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		Class9 @class = default(Class9);
		int num13 = default(int);
		Class9 class2 = default(Class9);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		Class7 class3 = default(Class7);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		byte[] array10 = default(byte[]);
		Class6 class4 = default(Class6);
		ICryptoTransform cryptoTransform2 = default(ICryptoTransform);
		byte[] array11 = default(byte[]);
		int num17 = default(int);
		byte[] array12 = default(byte[]);
		try
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			if (0 == 0)
			{
				assembly = callingAssembly;
			}
			executingAssembly = Assembly.GetExecutingAssembly();
			if ((object)assembly != executingAssembly && !smethod_0(executingAssembly, assembly))
			{
				return null;
			}
			stream = new Stream0(CO_);
			int num = 0;
			int num6;
			int num7;
			int num12;
			if (num == 0)
			{
				array = new byte[num];
				num2 = stream.method_3();
				if (num2 == 67324752)
				{
					num3 = (short)stream.method_2();
					num4 = stream.method_2();
					num5 = stream.method_2();
					if (num2 == 67324752)
					{
						num6 = num3;
						num7 = 20;
						if (num7 == 0)
						{
							goto IL_01e9;
						}
						if (num6 == num7 && num4 == 0 && num5 == 8)
						{
							stream.method_3();
							stream.method_3();
							stream.method_3();
							num8 = stream.method_3();
							num9 = stream.method_2();
							num10 = stream.method_2();
							if (num9 > 0)
							{
								array2 = new byte[num9];
								if (3 == 0)
								{
									byte[] result = default(byte[]);
									return result;
								}
								stream.Read(array2, 0, num9);
							}
							if (num10 > 0)
							{
								if (8 == 0)
								{
									goto IL_01bb;
								}
								array3 = new byte[num10];
								stream.Read(array3, 0, num10);
							}
							long num11 = stream.Length;
							if (2u != 0)
							{
								num11 -= stream.Position;
							}
							array4 = new byte[num11];
							num12 = stream.Read(array4, 0, array4.Length);
							if (5 == 0)
							{
								goto IL_027b;
							}
							@class = new Class9(array4);
							array = new byte[num8];
							num = @class.method_2(array, 0, array.Length);
							goto IL_02e1;
						}
					}
					throw new FormatException("Wrong Header Signature");
				}
				num13 = num2 >> 24;
				num2 -= num13 << 24;
				goto IL_01d8;
			}
			goto IL_02e1;
			IL_01d5:
			if (false)
			{
				goto IL_01d8;
			}
			num6 = num13;
			num7 = 2;
			goto IL_01e9;
			IL_02e1:
			array4 = null;
			goto IL_02e5;
			IL_01bb:
			class2.method_2(array, num14, num15);
			num14 += num15;
			goto IL_01cf;
			IL_01d8:
			if (num2 == 8223355)
			{
				if (num13 == 1)
				{
					num16 = stream.method_3();
					array = new byte[num16];
					num14 = 0;
					goto IL_01cf;
				}
				goto IL_01d5;
			}
			throw new FormatException("Unknown Header");
			IL_01e9:
			if (num6 == num7)
			{
				array5 = new byte[8] { 219, 109, 58, 152, 92, 192, 249, 64 };
				array6 = new byte[8] { 158, 184, 244, 36, 192, 36, 122, 248 };
				class3 = new Class7();
				try
				{
					cryptoTransform = class3.method_0(array5, array6, CO_: true);
					try
					{
						array7 = cryptoTransform.TransformFinalBlock(CO_, 4, CO_.Length - 4);
						array = smethod_1(array7);
					}
					finally
					{
						if (8u != 0)
						{
							cryptoTransform?.Dispose();
						}
					}
				}
				finally
				{
					((IDisposable)class3)?.Dispose();
				}
			}
			if (num13 == 3)
			{
				array8 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				num12 = 16;
				goto IL_027b;
			}
			goto IL_02e5;
			IL_02e5:
			stream.Close();
			stream = null;
			return array;
			IL_027b:
			byte[] array9 = new byte[num12];
			RuntimeHelpers.InitializeArray(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			array10 = array9;
			class4 = new Class6();
			try
			{
				cryptoTransform2 = class4.method_0(array8, array10, CO_: true);
				try
				{
					array11 = cryptoTransform2.TransformFinalBlock(CO_, 4, CO_.Length - 4);
					array = smethod_1(array11);
				}
				finally
				{
					cryptoTransform2?.Dispose();
				}
			}
			finally
			{
				((IDisposable)class4)?.Dispose();
			}
			goto IL_02e5;
			IL_01cf:
			if (num14 < num16)
			{
				num17 = stream.method_3();
				num15 = stream.method_3();
				array12 = new byte[num17];
				stream.Read(array12, 0, array12.Length);
				class2 = new Class9(array12);
				goto IL_01bb;
			}
			goto IL_01d5;
		}
		catch (Exception cO_)
		{
			Class29.smethod_10(cO_, new object[33]
			{
				assembly, executingAssembly, stream, array, num2, num3, num4, num5, num8, num9,
				num10, array2, array3, array4, @class, num13, num16, num14, num17, num15,
				class2, array12, array5, array6, class3, cryptoTransform, array7, array8, array10, class4,
				cryptoTransform2, array11, CO_
			});
			throw;
		}
	}

	public static byte[] smethod_2(byte[] CO_)
	{
		try
		{
			return smethod_3(CO_, 1, null, null);
		}
		catch (Exception cO_)
		{
			Class29.smethod_1(cO_, CO_);
			throw;
		}
	}

	private static byte[] smethod_3(byte[] CO_, int CO_, byte[] CO_, byte[] CO_)
	{
		Stream0 stream = default(Stream0);
		Class14 @class = default(Class14);
		DateTime now = default(DateTime);
		long num4 = default(long);
		uint[] array = default(uint[]);
		uint num5 = default(uint);
		uint num6 = default(uint);
		int num7 = default(int);
		int num8 = default(int);
		long position = default(long);
		byte[] bytes = default(byte[]);
		int num9 = default(int);
		byte[] array2 = default(byte[]);
		Class7 class2 = default(Class7);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		long position2 = default(long);
		Class14 class3 = default(Class14);
		long position3 = default(long);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num10 = default(int);
		long num11 = default(long);
		byte[] array7 = default(byte[]);
		int num12 = default(int);
		byte[] array8 = default(byte[]);
		int num13 = default(int);
		byte[] array9 = default(byte[]);
		int num14 = default(int);
		Class6 class4 = default(Class6);
		ICryptoTransform cryptoTransform2 = default(ICryptoTransform);
		byte[] array10 = default(byte[]);
		byte[] array11 = default(byte[]);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				stream = new Stream0();
				int num;
				int num2;
				if (CO_ == 0)
				{
					@class = new Class14();
					if (0 == 0)
					{
						now = DateTime.Now;
						num = (((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11);
						num2 = now.Minute;
						if (0 == 0)
						{
							int num3 = num | (num2 << 5) | (int)((uint)now.Second >> 1);
							while (true)
							{
								num4 = (uint)num3;
								array = new uint[256]
								{
									0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
									3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
									450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
									4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
									901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
									3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
									795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
									2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
									1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
									2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
									1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
									2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
									1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
									62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
									3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
									426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
									3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
									906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
									3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
									752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
									2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
									1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
									2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
									1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
									3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
									1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
								};
								num5 = uint.MaxValue;
								num6 = num5;
								num7 = 0;
								num8 = CO_.Length;
								while (true)
								{
									num3 = num8;
									if (false)
									{
										break;
									}
									if ((num8 = num3 - 1) < 0)
									{
										goto end_IL_00a0;
									}
									if (0 == 0)
									{
										num6 = array[(num6 ^ CO_[num7++]) & 0xFF] ^ (num6 >> 8);
										continue;
									}
									goto IL_02e1;
								}
								continue;
								end_IL_00a0:
								break;
							}
							num6 ^= num5;
							stream.method_1(67324752);
							stream.method_0(20);
							stream.method_0(0);
							stream.method_0(8);
							stream.method_1((int)num4);
							stream.method_1((int)num6);
							position = stream.Position;
							stream.method_1(0);
							stream.method_1(CO_.Length);
							bytes = Encoding.UTF8.GetBytes("{data}");
							stream.method_0(bytes.Length);
							stream.method_0(0);
							stream.Write(bytes, 0, bytes.Length);
							@class.method_4(CO_);
							goto IL_015d;
						}
						goto IL_017e;
					}
					goto IL_03ad;
				}
				if (CO_ == 1)
				{
					stream.method_1(25000571);
					if (4u != 0)
					{
						stream.method_1(CO_.Length);
						num9 = 0;
						goto IL_02f2;
					}
					goto IL_03be;
				}
				if (CO_ == 2)
				{
					stream.method_1(41777787);
					array2 = smethod_3(CO_, 1, null, null);
					class2 = new Class7();
					try
					{
						cryptoTransform = class2.method_0(CO_, CO_, CO_: false);
						try
						{
							array3 = cryptoTransform.TransformFinalBlock(array2, 0, array2.Length);
							stream.Write(array3, 0, array3.Length);
						}
						finally
						{
							cryptoTransform?.Dispose();
						}
					}
					finally
					{
						((IDisposable)class2)?.Dispose();
					}
				}
				else if (CO_ == 3)
				{
					stream.method_1(58555003);
					array4 = smethod_3(CO_, 1, null, null);
					goto IL_0459;
				}
				goto IL_04a5;
				IL_03be:
				stream.Position = position2;
				stream.method_1((int)class3.method_0());
				goto IL_02e1;
				IL_02e1:
				stream.Position = position3;
				num9 += array5.Length;
				goto IL_02f2;
				IL_0180:
				@class.method_1();
				while (!@class.method_2())
				{
					array6 = new byte[512];
					num10 = @class.method_5(array6);
					if (num10 <= 0)
					{
						break;
					}
					stream.Write(array6, 0, num10);
				}
				num11 = @class.method_0();
				stream.method_1(33639248);
				stream.method_0(20);
				stream.method_0(20);
				stream.method_0(0);
				stream.method_0(8);
				stream.method_1((int)num4);
				stream.method_1((int)num6);
				stream.method_1((int)num11);
				stream.method_1(CO_.Length);
				stream.method_0(bytes.Length);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_0(0);
				if (false)
				{
					goto IL_0459;
				}
				stream.method_0(0);
				stream.method_1(0);
				stream.method_1(0);
				stream.Write(bytes, 0, bytes.Length);
				stream.method_1(101010256);
				stream.method_0(0);
				stream.method_0(0);
				stream.method_0(1);
				stream.method_0(1);
				stream.method_1(46 + bytes.Length);
				if (5 == 0)
				{
					goto IL_033b;
				}
				stream.method_1((int)(30 + bytes.Length + num11));
				stream.method_0(0);
				stream.Seek(position, SeekOrigin.Begin);
				stream.method_1((int)num11);
				goto IL_04a5;
				IL_015d:
				if (!@class.method_3())
				{
					array7 = new byte[512];
					num12 = @class.method_5(array7);
					num = num12;
					num2 = 0;
					goto IL_017e;
				}
				goto IL_0180;
				IL_03ad:
				while (!class3.method_2())
				{
					array8 = new byte[512];
					num13 = class3.method_5(array8);
					if (num13 <= 0)
					{
						break;
					}
					stream.Write(array8, 0, num13);
				}
				position3 = stream.Position;
				goto IL_03be;
				IL_033b:
				class3 = new Class14();
				class3.method_4(array5);
				while (!class3.method_3())
				{
					array9 = new byte[512];
					num14 = class3.method_5(array9);
					if (num14 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num14);
				}
				class3.method_1();
				goto IL_03ad;
				IL_0459:
				class4 = new Class6();
				try
				{
					cryptoTransform2 = class4.method_0(CO_, CO_, CO_: false);
					try
					{
						array10 = cryptoTransform2.TransformFinalBlock(array4, 0, array4.Length);
						stream.Write(array10, 0, array10.Length);
					}
					finally
					{
						cryptoTransform2?.Dispose();
					}
				}
				finally
				{
					((IDisposable)class4)?.Dispose();
				}
				goto IL_04a5;
				IL_04a5:
				stream.Flush();
				stream.Close();
				array11 = stream.ToArray();
				return array11;
				IL_02f2:
				if (num9 < CO_.Length)
				{
					array5 = new byte[Math.Min(2097151, CO_.Length - num9)];
					Buffer.BlockCopy(CO_, num9, array5, 0, array5.Length);
					position2 = stream.Position;
					stream.method_1(0);
					stream.method_1(array5.Length);
					goto IL_033b;
				}
				goto IL_04a5;
				IL_017e:
				if (num > num2)
				{
					stream.Write(array7, 0, num12);
					goto IL_015d;
				}
				goto IL_0180;
			}
			catch (Exception ex)
			{
				ex2 = ex;
				string_0 = "ERR 2003: " + ex2.Message;
				throw;
			}
		}
		catch (Exception cO_)
		{
			Class29.smethod_10(cO_, new object[39]
			{
				stream, @class, now, num4, array, num5, num6, num7, num8, position,
				bytes, array7, num12, array6, num10, num11, num9, array5, position2, class3,
				array9, num14, array8, num13, position3, array2, class2, cryptoTransform, array3, array4,
				class4, cryptoTransform2, array10, ex2, array11, CO_, CO_, CO_, CO_
			});
			throw;
		}
	}
}
