using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using GD8Y7jMLuoEXknw0vY1;
using rNMhXfyrd2tSKJnPjg;

namespace wJDjjyMYp3BjGdXkEiH;

internal sealed class Xt0rZtMMyc257ciMNOG
{
	internal sealed class sToVpcMuiT8weUWME9p
	{
		private static readonly int[] GqZuthap4U = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		private static readonly int[] EbeuHTXy4K = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		private static readonly int[] FGXurxWuUZ = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		private static readonly int[] THcuhS2jaR = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		private int Ha7ukdDqWc;

		private int HmcuXYQDBH;

		private int KSPuRUD2Wg;

		private int cYDuWCY8Ih;

		private int I6WubmSwMX;

		private bool Gxpu15cODY;

		private VtJHX1MdhAp4eMQ2Lpd CyruwKe5Ru;

		private xthxXQM7CD8NL67cHdB u4Zuea5ZVa;

		private u255J0MKej5SPAQDuip IpSuxed8Tt;

		private Ou1aR1MJxt449v2lPkf aLRuVJEqBN;

		private Ou1aR1MJxt449v2lPkf YVyuiQvPcD;

		public sToVpcMuiT8weUWME9p(byte[] byte_0)
		{
			CyruwKe5Ru = new VtJHX1MdhAp4eMQ2Lpd();
			if (!a0htSMoerfXVGGmFkpk())
			{
				switch (3)
				{
				case 0:
				case 3:
					break;
				default:
					goto IL_0046;
				case 4:
					goto IL_004d;
				}
			}
			u4Zuea5ZVa = new xthxXQM7CD8NL67cHdB();
			goto IL_0046;
			IL_004d:
			CyruwKe5Ru.pxKuqQccht(byte_0, 0, byte_0.Length);
			return;
			IL_0046:
			Ha7ukdDqWc = 2;
			goto IL_004d;
		}

		private bool TmZuQcwJiW()
		{
			int num = u4Zuea5ZVa.r59unTvBwj();
			int num2 = 20;
			if (VKTqbnob9drg3i1j7pv())
			{
				int num4 = default(int);
				int num5 = default(int);
				int num3 = default(int);
				int ha7ukdDqWc = default(int);
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 28:
						Ha7ukdDqWc = 7;
						num2 = 14;
						if (!a0htSMoerfXVGGmFkpk())
						{
							continue;
						}
						goto case 1;
					case 16:
						Ha7ukdDqWc = 10;
						num4 = CyruwKe5Ru.yuduPGE8bg(HmcuXYQDBH);
						goto case 0;
					case 0:
						if (num4 < 0)
						{
							break;
						}
						CyruwKe5Ru.VTEuOsX0DI(HmcuXYQDBH);
						goto case 11;
					case 11:
						cYDuWCY8Ih += num4;
						goto IL_007a;
					case 17:
						num -= KSPuRUD2Wg;
						goto case 28;
					case 1:
						if (HmcuXYQDBH > 0)
						{
							goto case 16;
						}
						goto IL_007a;
					default:
						if (num5 >= 0)
						{
							CyruwKe5Ru.VTEuOsX0DI(HmcuXYQDBH);
							goto case 12;
						}
						return false;
					case 12:
						KSPuRUD2Wg += num5;
						goto case 23;
					case 23:
						Ha7ukdDqWc = 9;
						goto IL_00d7;
					case 10:
						goto IL_00d7;
					case 18:
						HmcuXYQDBH = THcuhS2jaR[num3];
						goto case 1;
					case 24:
						num5 = CyruwKe5Ru.yuduPGE8bg(HmcuXYQDBH);
						goto default;
					case 9:
						switch (ha7ukdDqWc)
						{
						case 10:
							break;
						case 9:
							goto IL_00d7;
						default:
							goto IL_0142;
						case 7:
							goto IL_0168;
						case 8:
							goto IL_01ce;
						}
						goto case 1;
					case 6:
					case 14:
					case 20:
						goto IL_0142;
					case 13:
						if (--num >= 258)
						{
							goto IL_0168;
						}
						goto case 4;
					case 3:
						goto IL_01ce;
					case 5:
						if (num3 < 0)
						{
							num2 = 29;
							if (!a0htSMoerfXVGGmFkpk())
							{
								continue;
							}
							goto case 29;
						}
						YVyuiQvPcD = null;
						goto case 26;
					case 4:
					case 25:
						return true;
					case 26:
						aLRuVJEqBN = null;
						goto case 22;
					case 22:
						Ha7ukdDqWc = 2;
						goto case 7;
					case 7:
						return true;
					case 2:
						break;
					case 29:
						return false;
					case 30:
						return true;
					case 8:
					case 15:
					case 19:
					case 21:
						{
							return result;
						}
						IL_0168:
						if (((num3 = aLRuVJEqBN.PQ3u2LUyxw(CyruwKe5Ru)) & -256) == 0)
						{
							u4Zuea5ZVa.a7SuBhMauL(num3);
							goto case 13;
						}
						if (num3 >= 257)
						{
							KSPuRUD2Wg = GqZuthap4U[num3 - 257];
							HmcuXYQDBH = EbeuHTXy4K[num3 - 257];
							goto IL_01ce;
						}
						goto case 5;
						IL_007a:
						u4Zuea5ZVa.DhguZ5n40d(KSPuRUD2Wg, cYDuWCY8Ih);
						goto case 17;
						IL_01ce:
						if (HmcuXYQDBH <= 0)
						{
							goto case 23;
						}
						Ha7ukdDqWc = 8;
						num2 = 24;
						if (VKTqbnob9drg3i1j7pv())
						{
							continue;
						}
						goto case 13;
						IL_0142:
						if (num >= 258)
						{
							ha7ukdDqWc = Ha7ukdDqWc;
							goto case 9;
						}
						goto case 30;
						IL_00d7:
						num3 = YVyuiQvPcD.PQ3u2LUyxw(CyruwKe5Ru);
						if (num3 >= 0)
						{
							cYDuWCY8Ih = FGXurxWuUZ[num3];
							goto case 18;
						}
						return false;
					}
					break;
				}
			}
			return false;
		}

		private bool rU1upXqMMh()
		{
			int num = Ha7ukdDqWc;
			int num2 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			bool result = default(bool);
			while (true)
			{
				IL_0125:
				int num3;
				switch (num)
				{
				case 6:
					if (!IpSuxed8Tt.BAFumtn809(CyruwKe5Ru))
					{
						goto IL_00e5;
					}
					aLRuVJEqBN = IpSuxed8Tt.M52uNhXL1N();
					YVyuiQvPcD = IpSuxed8Tt.T8WufbQMtF();
					goto IL_02bf;
				case 2:
					if (Gxpu15cODY)
					{
						goto IL_0175;
					}
					num2 = CyruwKe5Ru.yuduPGE8bg(3);
					if (num2 >= 0)
					{
						CyruwKe5Ru.VTEuOsX0DI(3);
						goto IL_0027;
					}
					goto IL_0184;
				case 3:
					num = (I6WubmSwMX = CyruwKe5Ru.yuduPGE8bg(16));
					goto IL_018b;
				case 4:
					num4 = CyruwKe5Ru.yuduPGE8bg(16);
					goto IL_01bd;
				case 5:
					num5 = u4Zuea5ZVa.TkUu4QdRhL(CyruwKe5Ru, I6WubmSwMX);
					goto IL_01ee;
				case 7:
				case 8:
				case 9:
				case 10:
					result = TmZuQcwJiW();
					break;
				default:
					goto IL_02cf;
				case 12:
					{
						result = false;
						break;
					}
					IL_0299:
					result = true;
					break;
					IL_0273:
					YVyuiQvPcD = Ou1aR1MJxt449v2lPkf.aKIulrlIxO;
					goto IL_027e;
					IL_00e5:
					result = false;
					num3 = 5;
					if (a0htSMoerfXVGGmFkpk())
					{
					}
					goto IL_0053;
					IL_0053:
					while (true)
					{
						switch (num3)
						{
						case 27:
							break;
						case 25:
							goto IL_002f;
						default:
							num3 = 15;
							if (!a0htSMoerfXVGGmFkpk())
							{
								continue;
							}
							goto IL_002f;
						case 1:
							goto IL_00e5;
						case 7:
							goto IL_0125;
						case 0:
							goto IL_0175;
						case 11:
							goto IL_0184;
						case 15:
							goto IL_018b;
						case 16:
							goto IL_01a1;
						case 17:
							goto IL_01a8;
						case 13:
							goto IL_01bd;
						case 19:
							goto IL_01ce;
						case 18:
							goto IL_01ee;
						case 4:
						case 23:
							goto IL_01fd;
						case 20:
							goto IL_0205;
						case 24:
							goto IL_0227;
						case 10:
							goto IL_0233;
						case 28:
							goto IL_0239;
						case 32:
							goto IL_0240;
						case 22:
							goto IL_0273;
						case 6:
							goto IL_027e;
						case 31:
							goto IL_0292;
						case 8:
						case 14:
							goto IL_0299;
						case 21:
							goto IL_02bf;
						case 29:
							goto IL_02cf;
						case 2:
						case 3:
						case 5:
						case 9:
						case 12:
						case 26:
						case 30:
						case 33:
							goto end_IL_0128;
						}
						break;
					}
					goto IL_0027;
					IL_02cf:
					result = false;
					break;
					IL_018b:
					if (num >= 0)
					{
						CyruwKe5Ru.VTEuOsX0DI(16);
						goto IL_01a8;
					}
					goto IL_0239;
					IL_027e:
					Ha7ukdDqWc = 7;
					goto IL_0299;
					IL_01a8:
					Ha7ukdDqWc = 4;
					goto case 4;
					IL_01bd:
					if (num4 >= 0)
					{
						CyruwKe5Ru.VTEuOsX0DI(16);
						goto IL_01ce;
					}
					goto IL_0227;
					IL_02bf:
					Ha7ukdDqWc = 7;
					goto case 7;
					IL_01ce:
					Ha7ukdDqWc = 5;
					goto case 5;
					IL_01ee:
					I6WubmSwMX -= num5;
					goto IL_01fd;
					IL_01fd:
					if (I6WubmSwMX != 0)
					{
						result = !CyruwKe5Ru.method_2();
						break;
					}
					goto IL_0205;
					IL_0205:
					Ha7ukdDqWc = 2;
					result = true;
					break;
					IL_0227:
					result = false;
					break;
					IL_0239:
					result = false;
					break;
					IL_0184:
					result = false;
					break;
					IL_0175:
					Ha7ukdDqWc = 12;
					goto IL_01a1;
					IL_01a1:
					result = false;
					break;
					IL_0027:
					if (((uint)num2 & (true ? 1u : 0u)) != 0)
					{
						goto IL_002f;
					}
					goto IL_0233;
					IL_002f:
					Gxpu15cODY = true;
					num3 = 10;
					if (a0htSMoerfXVGGmFkpk())
					{
					}
					goto IL_0053;
					IL_0233:
					num = num2 >> 1;
					goto IL_0240;
					IL_0240:
					switch (num)
					{
					case 0:
						CyruwKe5Ru.KKpujX4tkM();
						Ha7ukdDqWc = 3;
						goto IL_0299;
					case 1:
						break;
					case 2:
						goto IL_0287;
					default:
						goto IL_0299;
					}
					aLRuVJEqBN = Ou1aR1MJxt449v2lPkf.LTYuTfQBT4;
					goto IL_0273;
					IL_0287:
					IpSuxed8Tt = new u255J0MKej5SPAQDuip();
					goto IL_0292;
					IL_0292:
					Ha7ukdDqWc = 6;
					goto IL_0299;
					end_IL_0128:
					break;
				}
				break;
			}
			return result;
		}

		public int HWvuc58l7Q(byte[] byte_0, int int_0, int int_1)
		{
			int num = 0;
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				if (Ha7ukdDqWc != 11)
				{
					goto IL_0025;
				}
				goto IL_0092;
				IL_0092:
				if (rU1upXqMMh())
				{
					continue;
				}
				goto IL_007a;
				IL_007a:
				if (u4Zuea5ZVa.A7AuG13k98() <= 0)
				{
					break;
				}
				goto IL_006e;
				IL_006e:
				if (Ha7ukdDqWc != 11)
				{
					continue;
				}
				int num2 = 10;
				if (!VKTqbnob9drg3i1j7pv())
				{
					goto IL_0014;
				}
				goto IL_003b;
				IL_0025:
				num3 = u4Zuea5ZVa.s7GuIBStwl(byte_0, int_0, int_1);
				int_0 += num3;
				goto IL_0014;
				IL_003b:
				switch (num2)
				{
				case 1:
				case 6:
					break;
				case 4:
					goto IL_0025;
				case 3:
					goto IL_006e;
				case 8:
					goto IL_007a;
				case 2:
				case 5:
					int_1 -= num3;
					goto case 0;
				case 0:
					if (int_1 != 0)
					{
						goto IL_0092;
					}
					goto default;
				default:
					return num;
				case 10:
					goto end_IL_009a;
				case 9:
					return result;
				}
				goto IL_0014;
				IL_0014:
				num += num3;
				num2 = 5;
				if (!VKTqbnob9drg3i1j7pv())
				{
					goto IL_0025;
				}
				goto IL_003b;
				continue;
				end_IL_009a:
				break;
			}
			return num;
		}

		internal static bool VKTqbnob9drg3i1j7pv()
		{
			return true;
		}

		internal static bool a0htSMoerfXVGGmFkpk()
		{
			return false;
		}
	}

	internal sealed class VtJHX1MdhAp4eMQ2Lpd
	{
		private byte[] uZRuSyCACW;

		private int Ktwu6kNGsZ;

		private int P4uuocA391;

		private uint GfAuEuBom1;

		private int y4Iua6pXmM;

		public int yuduPGE8bg(int int_0)
		{
			if (y4Iua6pXmM < int_0)
			{
				if (Ktwu6kNGsZ == P4uuocA391)
				{
					return -1;
				}
				GfAuEuBom1 |= (uint)(((uZRuSyCACW[Ktwu6kNGsZ++] & 0xFF) | ((uZRuSyCACW[Ktwu6kNGsZ++] & 0xFF) << 8)) << y4Iua6pXmM);
				y4Iua6pXmM += 16;
			}
			return (int)(GfAuEuBom1 & ((1 << int_0) - 1));
		}

		public void VTEuOsX0DI(int int_0)
		{
			GfAuEuBom1 >>= int_0;
			y4Iua6pXmM -= int_0;
		}

		[SpecialName]
		public int method_0()
		{
			return y4Iua6pXmM;
		}

		[SpecialName]
		public int method_1()
		{
			return P4uuocA391 - Ktwu6kNGsZ + (y4Iua6pXmM >> 3);
		}

		public void KKpujX4tkM()
		{
			GfAuEuBom1 >>= y4Iua6pXmM & 7;
			y4Iua6pXmM &= -8;
		}

		[SpecialName]
		public bool method_2()
		{
			return Ktwu6kNGsZ == P4uuocA391;
		}

		public int fK6uChwYh8(byte[] byte_0, int int_0, int int_1)
		{
			int num = 0;
			int num2 = default(int);
			while (true)
			{
				if (y4Iua6pXmM > 0)
				{
					goto IL_005a;
				}
				goto IL_005e;
				IL_005e:
				if (int_1 == 0)
				{
					if (WoNrcGoOfebsQo8xZVA())
					{
						switch (0)
						{
						case 7:
							break;
						case 12:
							goto IL_0075;
						case 1:
						case 4:
							goto IL_0083;
						case 3:
							goto IL_0091;
						case 8:
							goto IL_0096;
						case 2:
							continue;
						case 0:
							return num;
						default:
							goto IL_00b7;
						case 6:
							goto IL_00bb;
						case 14:
							goto IL_00be;
						case 13:
							goto IL_00d2;
						case 10:
						case 11:
							goto IL_00e0;
						case 9:
							goto IL_0115;
						case 15:
							goto end_IL_009a;
						}
						goto IL_005a;
					}
					continue;
				}
				num2 = P4uuocA391 - Ktwu6kNGsZ;
				goto IL_00b7;
				IL_00be:
				Array.Copy(uZRuSyCACW, Ktwu6kNGsZ, byte_0, int_0, int_1);
				goto IL_00d2;
				IL_00e0:
				if (((Ktwu6kNGsZ - P4uuocA391) & 1) == 0)
				{
					break;
				}
				GfAuEuBom1 = uZRuSyCACW[Ktwu6kNGsZ++] & 0xFFu;
				goto IL_0115;
				IL_005a:
				if (int_1 <= 0)
				{
					goto IL_005e;
				}
				byte_0[int_0++] = (byte)GfAuEuBom1;
				goto IL_0075;
				IL_0115:
				y4Iua6pXmM = 8;
				break;
				IL_0075:
				GfAuEuBom1 >>= 8;
				goto IL_0083;
				IL_0083:
				y4Iua6pXmM -= 8;
				goto IL_0091;
				IL_0091:
				int_1--;
				goto IL_0096;
				IL_0096:
				num++;
				continue;
				IL_00d2:
				Ktwu6kNGsZ += int_1;
				goto IL_00e0;
				IL_00b7:
				if (int_1 > num2)
				{
					goto IL_00bb;
				}
				goto IL_00be;
				IL_00bb:
				int_1 = num2;
				goto IL_00be;
				continue;
				end_IL_009a:
				break;
			}
			return num + int_1;
		}

		public VtJHX1MdhAp4eMQ2Lpd()
		{
			while (true)
			{
				Ktwu6kNGsZ = 0;
				while (true)
				{
					P4uuocA391 = 0;
					if (TEok8Co3PlucBlIOcIj())
					{
					}
					switch (5)
					{
					case 2:
						continue;
					case 1:
						break;
					case 5:
						GfAuEuBom1 = 0u;
						goto default;
					default:
						y4Iua6pXmM = 0;
						goto case 0;
					case 0:
					case 4:
						base._002Ector();
						return;
					case 7:
						return;
					}
					break;
				}
			}
		}

		public void pxKuqQccht(byte[] byte_0, int int_0, int int_1)
		{
			if (Ktwu6kNGsZ >= P4uuocA391)
			{
				int num = int_0 + int_1;
				while (true)
				{
					IL_0095:
					if (0 <= int_0 && int_0 <= num)
					{
						while (num <= byte_0.Length)
						{
							if (((uint)int_1 & (true ? 1u : 0u)) != 0)
							{
								while (true)
								{
									GfAuEuBom1 |= (uint)((byte_0[int_0++] & 0xFF) << y4Iua6pXmM);
									if (!WoNrcGoOfebsQo8xZVA())
									{
										break;
									}
									switch (8)
									{
									case 1:
										goto end_IL_0028;
									case 3:
										goto IL_0095;
									case 0:
										goto end_IL_0095;
									case 8:
										y4Iua6pXmM += 8;
										goto IL_00b2;
									case 4:
									case 6:
										goto IL_00b2;
									case 5:
									case 7:
										goto IL_00b9;
									case 10:
										goto IL_00c0;
									case 9:
										goto end_IL_008d;
									}
									continue;
									end_IL_0028:
									break;
								}
								continue;
							}
							goto IL_00b2;
							IL_00b9:
							Ktwu6kNGsZ = int_0;
							goto IL_00c0;
							IL_00c0:
							P4uuocA391 = num;
							return;
							IL_00b2:
							uZRuSyCACW = byte_0;
							goto IL_00b9;
							continue;
							end_IL_008d:
							break;
						}
					}
					throw new ArgumentOutOfRangeException();
					continue;
					end_IL_0095:
					break;
				}
			}
			throw new InvalidOperationException();
		}

		internal static bool WoNrcGoOfebsQo8xZVA()
		{
			return true;
		}

		internal static bool TEok8Co3PlucBlIOcIj()
		{
			return false;
		}
	}

	internal sealed class xthxXQM7CD8NL67cHdB
	{
		private byte[] Cbou8mHp1f = new byte[32768];

		private int nhFuFI14un = 0;

		private int Imxug3Hspe = 0;

		public void a7SuBhMauL(int int_0)
		{
			int num = Imxug3Hspe++;
			int num2 = 2;
			if (!NhROAHo0dtH3kYZWdcm())
			{
			}
			do
			{
				switch (num2)
				{
				case 0:
				case 2:
					if (num != 32768)
					{
						goto IL_0028;
					}
					goto default;
				default:
					throw new InvalidOperationException();
				case 4:
					break;
				}
				break;
				IL_0028:
				byte[] cbou8mHp1f = Cbou8mHp1f;
				num = nhFuFI14un++;
				cbou8mHp1f[num] = (byte)int_0;
				num2 = 4;
			}
			while (!NhROAHo0dtH3kYZWdcm());
			nhFuFI14un &= 32767;
		}

		private void osMu0TN7ck(int int_0, int int_1, int int_2)
		{
			while (int_1-- > 0)
			{
				Cbou8mHp1f[nhFuFI14un++] = Cbou8mHp1f[int_0++];
				nhFuFI14un &= 32767;
				int_0 &= 0x7FFF;
			}
		}

		public void DhguZ5n40d(int int_0, int int_1)
		{
			int num = (Imxug3Hspe += int_0);
			int num2 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num3;
				if (num <= 32768)
				{
					num2 = (nhFuFI14un - int_1) & 0x7FFF;
				}
				else
				{
					num3 = 10;
					if (qR93yKocrSH3AZiIKCn())
					{
						goto IL_007a;
					}
				}
				goto IL_00b1;
				IL_010d:
				while (int_0-- > 0)
				{
					Cbou8mHp1f[nhFuFI14un++] = Cbou8mHp1f[num2++];
				}
				return;
				IL_0118:
				osMu0TN7ck(num2, int_0, int_1);
				return;
				IL_00b1:
				num4 = 32768 - int_0;
				num3 = 3;
				if (!qR93yKocrSH3AZiIKCn())
				{
					goto IL_0071;
				}
				goto IL_007a;
				IL_007a:
				switch (num3)
				{
				case 9:
					break;
				default:
					goto IL_0035;
				case 6:
					goto IL_003c;
				case 3:
					goto IL_0071;
				case 1:
					goto IL_00b1;
				case 4:
					continue;
				case 0:
					return;
				case 7:
				case 8:
					goto IL_010d;
				case 10:
					goto end_IL_00d7;
				case 11:
					return;
				}
				goto IL_0029;
				IL_0071:
				if (num2 <= num4)
				{
					goto IL_0029;
				}
				goto IL_0118;
				IL_0029:
				if (nhFuFI14un < num4)
				{
					goto IL_0035;
				}
				goto IL_0118;
				IL_0035:
				if (int_0 <= int_1)
				{
					goto IL_003c;
				}
				goto IL_010d;
				IL_003c:
				Array.Copy(Cbou8mHp1f, num2, Cbou8mHp1f, nhFuFI14un, int_0);
				nhFuFI14un += int_0;
				num3 = 0;
				if (!qR93yKocrSH3AZiIKCn())
				{
					break;
				}
				goto IL_007a;
				continue;
				end_IL_00d7:
				break;
			}
			throw new InvalidOperationException();
		}

		public int TkUu4QdRhL(VtJHX1MdhAp4eMQ2Lpd vtJHX1MdhAp4eMQ2Lpd_0, int int_0)
		{
			int_0 = Math.Min(Math.Min(int_0, 32768 - Imxug3Hspe), vtJHX1MdhAp4eMQ2Lpd_0.method_1());
			while (true)
			{
				int num = 32768 - nhFuFI14un;
				while (true)
				{
					int num2;
					if (int_0 <= num)
					{
						num2 = vtJHX1MdhAp4eMQ2Lpd_0.fK6uChwYh8(Cbou8mHp1f, nhFuFI14un, int_0);
						if (!NhROAHo0dtH3kYZWdcm())
						{
							switch (8)
							{
							case 1:
								break;
							case 7:
								goto end_IL_0074;
							case 9:
								goto IL_008c;
							case 3:
							case 5:
								goto IL_00a0;
							default:
								goto IL_00a4;
							case 2:
							case 6:
							case 8:
								goto IL_00b7;
							case 4:
								goto IL_00cb;
							case 10:
								goto IL_00d9;
							}
							continue;
						}
						goto IL_00d9;
					}
					goto IL_008c;
					IL_00cb:
					Imxug3Hspe += num2;
					goto IL_00d9;
					IL_00d9:
					return num2;
					IL_008c:
					num2 = vtJHX1MdhAp4eMQ2Lpd_0.fK6uChwYh8(Cbou8mHp1f, nhFuFI14un, num);
					goto IL_00a0;
					IL_00a0:
					if (num2 == num)
					{
						goto IL_00a4;
					}
					goto IL_00b7;
					IL_00a4:
					num2 += vtJHX1MdhAp4eMQ2Lpd_0.fK6uChwYh8(Cbou8mHp1f, 0, int_0 - num);
					goto IL_00b7;
					IL_00b7:
					nhFuFI14un = (nhFuFI14un + num2) & 0x7FFF;
					goto IL_00cb;
					continue;
					end_IL_0074:
					break;
				}
			}
		}

		public int r59unTvBwj()
		{
			return 32768 - Imxug3Hspe;
		}

		public int A7AuG13k98()
		{
			return Imxug3Hspe;
		}

		public int s7GuIBStwl(byte[] byte_0, int int_0, int int_1)
		{
			int num = nhFuFI14un;
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				if (int_1 <= Imxug3Hspe)
				{
					num = (nhFuFI14un - Imxug3Hspe + int_1) & 0x7FFF;
					goto IL_0022;
				}
				int num2 = 11;
				if (NhROAHo0dtH3kYZWdcm())
				{
				}
				goto IL_0085;
				IL_004b:
				int_1 = num;
				num2 = 1;
				if (NhROAHo0dtH3kYZWdcm())
				{
				}
				goto IL_0085;
				IL_0085:
				switch (num2)
				{
				case 3:
				case 8:
				case 10:
					break;
				case 4:
					goto IL_0024;
				default:
					goto IL_0028;
				case 1:
				case 7:
					goto IL_002c;
				case 6:
					goto IL_004b;
				case 11:
					int_1 = Imxug3Hspe;
					break;
				case 0:
					continue;
				case 2:
					Imxug3Hspe -= num3;
					goto case 9;
				case 9:
					if (Imxug3Hspe >= 0)
					{
						return num3;
					}
					goto case 12;
				case 12:
					throw new InvalidOperationException();
				}
				goto IL_0022;
				IL_0022:
				num3 = int_1;
				goto IL_0024;
				IL_0024:
				num4 = int_1 - num;
				goto IL_0028;
				IL_0028:
				if (num4 <= 0)
				{
					goto IL_002c;
				}
				Array.Copy(Cbou8mHp1f, 32768 - num4, byte_0, int_0, num4);
				int_0 += num4;
				goto IL_004b;
				IL_002c:
				Array.Copy(Cbou8mHp1f, num - int_1, byte_0, int_0, int_1);
				num2 = 2;
				if (NhROAHo0dtH3kYZWdcm())
				{
					goto IL_0024;
				}
				goto IL_0085;
			}
		}

		internal static bool qR93yKocrSH3AZiIKCn()
		{
			return true;
		}

		internal static bool NhROAHo0dtH3kYZWdcm()
		{
			return false;
		}
	}

	internal sealed class Ou1aR1MJxt449v2lPkf
	{
		private short[] Nwlu9qnc5W;

		public static readonly Ou1aR1MJxt449v2lPkf LTYuTfQBT4;

		public static readonly Ou1aR1MJxt449v2lPkf aKIulrlIxO;

		static Ou1aR1MJxt449v2lPkf()
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			LTYuTfQBT4 = new Ou1aR1MJxt449v2lPkf(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			aKIulrlIxO = new Ou1aR1MJxt449v2lPkf(array);
		}

		public Ou1aR1MJxt449v2lPkf(byte[] byte_0)
		{
			aXRusTIptX(byte_0);
		}

		private void aXRusTIptX(byte[] byte_0)
		{
			int[] array = new int[16];
			int num2 = default(int);
			int num15 = default(int);
			int num8 = default(int);
			int num7 = default(int);
			int num18 = default(int);
			int num17 = default(int);
			int num14 = default(int);
			int num16 = default(int);
			int num13 = default(int);
			int num10 = default(int);
			int num9 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num6 = default(int);
			while (true)
			{
				int[] array2 = new int[16];
				while (true)
				{
					int num = 0;
					while (true)
					{
						IL_02fb:
						if (num < byte_0.Length)
						{
							num2 = byte_0[num];
							if (num2 <= 0)
							{
								goto IL_0029;
							}
						}
						else
						{
							while (true)
							{
								IL_02f5:
								int num3 = 0;
								while (true)
								{
									IL_02da:
									int num4 = 512;
									int num5 = 28;
									if (!XM0iAioJXOrMJClENqH())
									{
									}
									while (true)
									{
										switch (num5)
										{
										case 11:
											break;
										case 7:
											goto IL_0029;
										case 36:
											if (num15 < byte_0.Length)
											{
												num8 = byte_0[num15];
												if (num8 != 0)
												{
													num3 = array2[num8];
													goto case 19;
												}
												goto case 10;
											}
											return;
										case 19:
											num7 = zUU4DbMUWSR8IFUqDO7.JfrdrO4OwG(num3);
											num5 = 6;
											if (UNUpmdoGRrbqQAjTmPH())
											{
												continue;
											}
											goto case 16;
										default:
											num18 = num3 & 0x1FF80;
											goto case 22;
										case 22:
											num17 = num18;
											goto case 15;
										case 15:
										case 25:
											if (num17 >= num14)
											{
												goto case 12;
											}
											Nwlu9qnc5W[zUU4DbMUWSR8IFUqDO7.JfrdrO4OwG(num17)] = (short)((-num16 << 4) | num13);
											goto case 0;
										case 12:
											num13--;
											goto IL_007e;
										case 16:
										case 35:
											num3 -= array[num13] << 16 - num13;
											goto default;
										case 34:
											num15 = 0;
											goto case 36;
										case 10:
										case 33:
											num15++;
											goto case 36;
										case 5:
											num17 += 128;
											num5 = 15;
											if (!XM0iAioJXOrMJClENqH())
											{
												continue;
											}
											goto case 0;
										case 0:
											num16 += 1 << num13 - 9;
											goto case 5;
										case 21:
											num7 += 1 << num8;
											if (num7 < 512)
											{
												goto case 32;
											}
											goto case 30;
										case 32:
											Nwlu9qnc5W[num7] = (short)((num15 << 4) | num8);
											goto case 21;
										case 30:
											array2[num8] = num3 + (1 << 16 - num8);
											goto case 10;
										case 31:
											Nwlu9qnc5W = new short[num4];
											num16 = 512;
											goto case 8;
										case 8:
											num13 = 15;
											goto IL_007e;
										case 28:
											num10 = 1;
											goto case 14;
										case 9:
											num3 += array[num10] << 16 - num10;
											goto case 23;
										case 23:
											if (num10 < 10)
											{
												goto IL_0164;
											}
											goto case 18;
										case 14:
											if (num10 <= 15)
											{
												array2[num10] = num3;
												goto case 9;
											}
											num5 = 31;
											if (UNUpmdoGRrbqQAjTmPH())
											{
												continue;
											}
											goto IL_02fb;
										case 18:
											num9 = array2[num10] & 0x1FF80;
											num5 = 1;
											if (UNUpmdoGRrbqQAjTmPH())
											{
												continue;
											}
											goto IL_02da;
										case 24:
											num11 = -(num11 >> 4);
											goto IL_01ac;
										case 20:
											if (num7 >= num12)
											{
												goto case 30;
											}
											goto IL_01ac;
										case 6:
											if (num8 <= 9)
											{
												goto case 32;
											}
											num11 = Nwlu9qnc5W[num7 & 0x1FF];
											num12 = 1 << (num11 & 0xF);
											goto case 24;
										case 4:
											num4 += num6 - num9 >> 16 - num10;
											goto IL_0164;
										case 2:
											num7 += 1 << num8;
											goto case 20;
										case 1:
											num6 = num3 & 0x1FF80;
											num5 = 4;
											if (!XM0iAioJXOrMJClENqH())
											{
											}
											continue;
										case 27:
											goto IL_02da;
										case 29:
											goto IL_02f5;
										case 17:
											goto IL_02fb;
										case 26:
											goto end_IL_02fb;
										case 13:
											goto end_IL_0307;
											IL_007e:
											if (num13 >= 10)
											{
												num14 = num3 & 0x1FF80;
												goto case 16;
											}
											goto case 34;
											IL_01ac:
											Nwlu9qnc5W[num11 | (num7 >> 9)] = (short)((num15 << 4) | num8);
											num5 = 2;
											if (!XM0iAioJXOrMJClENqH())
											{
												continue;
											}
											goto case 30;
											IL_0164:
											num10++;
											goto case 14;
										}
										break;
									}
									break;
								}
								break;
							}
						}
						int[] array3;
						int[] array4 = (array3 = array);
						int num19 = num2;
						nint num20 = num19;
						array4[num19] = array3[num20] + 1;
						goto IL_0029;
						IL_0029:
						num++;
						continue;
						end_IL_02fb:
						break;
					}
					continue;
					end_IL_0307:
					break;
				}
			}
		}

		public int PQ3u2LUyxw(VtJHX1MdhAp4eMQ2Lpd vtJHX1MdhAp4eMQ2Lpd_0)
		{
			int num;
			if ((num = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(9)) >= 0)
			{
				goto IL_002a;
			}
			int num2 = vtJHX1MdhAp4eMQ2Lpd_0.method_0();
			goto IL_00ee;
			IL_011c:
			int num3 = default(int);
			num = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(num3);
			goto IL_0137;
			IL_002a:
			int num4;
			int num5 = default(int);
			if ((num4 = Nwlu9qnc5W[num]) < 0)
			{
				num5 = -(num4 >> 4);
				goto IL_0040;
			}
			goto IL_0127;
			IL_0137:
			num4 = Nwlu9qnc5W[num5 | (num >> 9)];
			if ((num4 & 0xF) > num3)
			{
				return -1;
			}
			goto IL_014e;
			IL_0040:
			int int_ = num4 & 0xF;
			if ((num = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(int_)) >= 0)
			{
				num4 = Nwlu9qnc5W[num5 | (num >> 9)];
				goto IL_0065;
			}
			num3 = vtJHX1MdhAp4eMQ2Lpd_0.method_0();
			goto IL_011c;
			IL_014e:
			vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(num4 & 0xF);
			goto IL_0158;
			IL_0065:
			vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(num4 & 0xF);
			int num6 = 19;
			if (!XM0iAioJXOrMJClENqH())
			{
			}
			goto IL_007b;
			IL_007b:
			switch (num6)
			{
			case 8:
				break;
			case 3:
			case 4:
				goto IL_0040;
			case 1:
			case 5:
				goto IL_0065;
			case 11:
				goto IL_00d6;
			case 7:
				goto IL_00e5;
			case 15:
				goto IL_00ee;
			case 6:
				vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(num4 & 0xF);
				return num4 >> 4;
			case 0:
				goto IL_011c;
			case 16:
				goto IL_0127;
			case 9:
				goto IL_0131;
			default:
				goto IL_0137;
			case 14:
				goto IL_014e;
			case 2:
				goto IL_0158;
			case 19:
				return num4 >> 4;
			case 10:
			case 12:
			case 13:
			case 18:
			case 20:
				goto IL_0170;
			}
			goto IL_002a;
			IL_0170:
			int result = default(int);
			return result;
			IL_00ee:
			num = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(num2);
			num4 = Nwlu9qnc5W[num];
			goto IL_00e5;
			IL_00e5:
			if (num4 >= 0)
			{
				goto IL_00d6;
			}
			goto IL_016c;
			IL_00d6:
			if ((num4 & 0xF) > num2)
			{
				goto IL_016c;
			}
			num6 = 6;
			if (!XM0iAioJXOrMJClENqH())
			{
				goto IL_007b;
			}
			goto IL_0170;
			IL_0127:
			vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(num4 & 0xF);
			goto IL_0131;
			IL_016c:
			return -1;
			IL_0131:
			return num4 >> 4;
			IL_0158:
			return num4 >> 4;
		}

		internal static bool UNUpmdoGRrbqQAjTmPH()
		{
			return true;
		}

		internal static bool XM0iAioJXOrMJClENqH()
		{
			return false;
		}
	}

	internal sealed class u255J0MKej5SPAQDuip
	{
		private static readonly int[] cKHu5H87WK = new int[3] { 3, 3, 11 };

		private static readonly int[] upquD43f3c = new int[3] { 2, 3, 7 };

		private byte[] ibTu3diovL;

		private byte[] whZuvO6kyk;

		private Ou1aR1MJxt449v2lPkf nsHuyk6dVN;

		private int S3juzuynY1;

		private int LpTdLGmdb5;

		private int BcMdMPbhGf;

		private int ReOdYtOvy2;

		private int sAZduS3N0y;

		private int OSoddECgJH;

		private byte B4Dd73UqjT;

		private int BfqdJisbl3;

		private static readonly int[] lPKdKmlSCJ = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};

		public bool BAFumtn809(VtJHX1MdhAp4eMQ2Lpd vtJHX1MdhAp4eMQ2Lpd_0)
		{
			bool result = default(bool);
			int num4 = default(int);
			int int_ = default(int);
			int num5 = default(int);
			while (true)
			{
				int num = S3juzuynY1;
				while (true)
				{
					int num3;
					switch (num)
					{
					case 3:
						goto IL_0045;
					case 1:
						goto IL_0075;
					case 2:
						ReOdYtOvy2 = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(4);
						if (ReOdYtOvy2 >= 0)
						{
							ReOdYtOvy2 += 4;
							goto IL_00f5;
						}
						goto IL_0384;
					case 4:
						goto IL_0297;
					case 5:
						goto IL_02d2;
					case 0:
						{
							LpTdLGmdb5 = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(5);
							goto IL_012d;
						}
						IL_0045:
						while (BfqdJisbl3 < ReOdYtOvy2)
						{
							int num2 = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(3);
							if (num2 >= 0)
							{
								vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(3);
								ibTu3diovL[lPKdKmlSCJ[BfqdJisbl3]] = (byte)num2;
								BfqdJisbl3++;
								continue;
							}
							goto IL_0058;
						}
						nsHuyk6dVN = new Ou1aR1MJxt449v2lPkf(ibTu3diovL);
						goto IL_0247;
						IL_00fc:
						ibTu3diovL = new byte[19];
						num3 = 22;
						if (fcmjbFoQb3saGficDPn())
						{
							goto IL_0166;
						}
						goto IL_02c0;
						IL_0058:
						result = false;
						num3 = 5;
						if (WAGKOvoLaepmxUeyrXl())
						{
						}
						goto IL_0166;
						IL_0166:
						switch (num3)
						{
						case 29:
							break;
						default:
							goto IL_0045;
						case 33:
							goto IL_006e;
						case 10:
							goto IL_0075;
						case 2:
							goto IL_0082;
						case 28:
							goto IL_00b6;
						case 24:
							goto IL_00f5;
						case 25:
							goto IL_00fc;
						case 22:
							BfqdJisbl3 = 0;
							goto case 8;
						case 8:
							S3juzuynY1 = 3;
							goto IL_0045;
						case 17:
							goto IL_012d;
						case 14:
							goto IL_015a;
						case 19:
							goto IL_0214;
						case 18:
							goto IL_0247;
						case 15:
							goto IL_024e;
						case 16:
							goto IL_0255;
						case 36:
							goto IL_0297;
						case 1:
							goto IL_02ab;
						case 3:
							goto IL_02b9;
						case 13:
						case 30:
							goto IL_02c0;
						case 31:
							goto IL_02d2;
						case 38:
							continue;
						case 20:
							if (num4 >= 0)
							{
								vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(int_);
								num4 += cKHu5H87WK[OSoddECgJH];
								goto case 34;
							}
							goto case 37;
						case 34:
							while (num4-- > 0)
							{
								whZuvO6kyk[BfqdJisbl3++] = B4Dd73UqjT;
							}
							goto case 7;
						case 7:
							if (BfqdJisbl3 == sAZduS3N0y)
							{
								goto case 27;
							}
							S3juzuynY1 = 4;
							break;
						case 6:
							result = false;
							goto IL_039a;
						case 32:
							goto IL_0384;
						case 27:
							result = true;
							goto IL_039a;
						case 4:
							goto IL_038c;
						case 37:
							result = false;
							goto IL_039a;
						case 39:
							goto IL_0394;
						case 0:
						case 5:
						case 9:
						case 11:
						case 12:
						case 21:
						case 23:
						case 40:
							goto IL_039a;
						}
						break;
						IL_0247:
						ibTu3diovL = null;
						goto IL_024e;
						IL_024e:
						BfqdJisbl3 = 0;
						goto IL_0255;
						IL_0255:
						S3juzuynY1 = 4;
						goto IL_0297;
						IL_0297:
						while (((num5 = nsHuyk6dVN.PQ3u2LUyxw(vtJHX1MdhAp4eMQ2Lpd_0)) & -16) == 0)
						{
							byte[] array = whZuvO6kyk;
							num = BfqdJisbl3++;
							array[num] = (B4Dd73UqjT = (byte)num5);
							if (BfqdJisbl3 != sAZduS3N0y)
							{
								continue;
							}
							goto IL_038c;
						}
						goto IL_02ab;
						IL_02ab:
						if (num5 >= 0)
						{
							if (num5 >= 17)
							{
								goto IL_02b9;
							}
							goto IL_02c0;
						}
						goto IL_0394;
						IL_02c0:
						OSoddECgJH = num5 - 16;
						S3juzuynY1 = 5;
						goto IL_02d2;
						IL_02b9:
						B4Dd73UqjT = 0;
						goto IL_02c0;
						IL_0394:
						result = false;
						goto IL_039a;
						IL_038c:
						result = true;
						goto IL_039a;
						IL_012d:
						if (LpTdLGmdb5 < 0)
						{
							num3 = 6;
							if (!fcmjbFoQb3saGficDPn())
							{
								goto IL_00b6;
							}
							goto IL_0166;
						}
						LpTdLGmdb5 += 257;
						goto IL_015a;
						IL_02d2:
						int_ = upquD43f3c[OSoddECgJH];
						goto IL_0214;
						IL_0214:
						num4 = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(int_);
						num3 = 20;
						if (fcmjbFoQb3saGficDPn())
						{
							goto IL_0166;
						}
						goto IL_039a;
						IL_015a:
						vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(5);
						goto IL_006e;
						IL_006e:
						S3juzuynY1 = 1;
						goto IL_0075;
						IL_0075:
						BcMdMPbhGf = vtJHX1MdhAp4eMQ2Lpd_0.yuduPGE8bg(5);
						goto IL_0082;
						IL_0082:
						if (BcMdMPbhGf >= 0)
						{
							BcMdMPbhGf++;
							vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(5);
							sAZduS3N0y = LpTdLGmdb5 + BcMdMPbhGf;
							goto IL_00b6;
						}
						result = false;
						goto IL_039a;
						IL_0384:
						result = false;
						goto IL_039a;
						IL_00b6:
						whZuvO6kyk = new byte[sAZduS3N0y];
						S3juzuynY1 = 2;
						goto case 2;
						IL_039a:
						return result;
						IL_00f5:
						vtJHX1MdhAp4eMQ2Lpd_0.VTEuOsX0DI(4);
						goto IL_00fc;
					}
					break;
				}
			}
		}

		public Ou1aR1MJxt449v2lPkf M52uNhXL1N()
		{
			byte[] array = new byte[LpTdLGmdb5];
			Array.Copy(whZuvO6kyk, 0, array, 0, LpTdLGmdb5);
			return new Ou1aR1MJxt449v2lPkf(array);
		}

		public Ou1aR1MJxt449v2lPkf T8WufbQMtF()
		{
			byte[] array = new byte[BcMdMPbhGf];
			Array.Copy(whZuvO6kyk, LpTdLGmdb5, array, 0, BcMdMPbhGf);
			return new Ou1aR1MJxt449v2lPkf(array);
		}

		internal static bool fcmjbFoQb3saGficDPn()
		{
			return true;
		}

		internal static bool WAGKOvoLaepmxUeyrXl()
		{
			return false;
		}
	}

	internal sealed class Fvwt6WMA4AehyjZtv0x
	{
		private int NRgdpWfekS = 16;

		private long yOEdcmgrZO = 0L;

		private DomFIaMccHiGtualwJl chmdtebj5q;

		private Qatc8MMpIgjbgXZC0ov rGUdH8y7Ap;

		public Fvwt6WMA4AehyjZtv0x()
		{
			chmdtebj5q = new DomFIaMccHiGtualwJl();
			rGUdH8y7Ap = new Qatc8MMpIgjbgXZC0ov(chmdtebj5q);
		}

		[SpecialName]
		public long method_0()
		{
			return yOEdcmgrZO;
		}

		public void hNFdA5XGLb()
		{
			NRgdpWfekS |= 12;
		}

		[SpecialName]
		public bool method_1()
		{
			if (NRgdpWfekS == 30)
			{
				if (!ti94fJovHYWIKkrbe1X())
				{
					switch (2)
					{
					case 0:
					case 2:
						break;
					default:
					{
						bool result = default(bool);
						return result;
					}
					}
				}
				return chmdtebj5q.method_1();
			}
			return false;
		}

		[SpecialName]
		public bool method_2()
		{
			return rGUdH8y7Ap.IZQ7YHi0dv();
		}

		public void AcZdUjcRuT(byte[] byte_0)
		{
			rGUdH8y7Ap.hAI7MYGYSg(byte_0);
		}

		public int tcfdQwFslH(byte[] byte_0)
		{
			int num = 0;
			int num2 = byte_0.Length;
			int num3;
			int num4 = default(int);
			int num5 = default(int);
			while (true)
			{
				num3 = num2;
				if (zf25xRogXMqUhjls1BW())
				{
					switch (16)
					{
					case 0:
						break;
					case 4:
						goto IL_0066;
					case 11:
						goto IL_006b;
					case 8:
						goto IL_0080;
					case 13:
						goto IL_0093;
					case 2:
						goto IL_00bc;
					default:
						goto IL_00d2;
					case 6:
					case 9:
						goto IL_00f3;
					case 3:
						goto IL_00f8;
					case 1:
						goto IL_00fc;
					case 5:
						goto IL_0110;
					case 7:
					case 14:
						goto IL_011b;
					case 12:
					case 16:
					case 17:
						goto IL_0123;
					case 10:
						goto IL_0138;
					}
					continue;
				}
				goto IL_00bc;
				IL_0066:
				num += num4;
				goto IL_006b;
				IL_00bc:
				if (NRgdpWfekS == 16)
				{
					goto IL_0138;
				}
				if (NRgdpWfekS == 20)
				{
					goto IL_00d2;
				}
				if (NRgdpWfekS == 28)
				{
					goto IL_0110;
				}
				goto IL_0123;
				IL_0138:
				return num3 - num2;
				IL_006b:
				yOEdcmgrZO += num4;
				num2 -= num4;
				goto IL_0080;
				IL_00d2:
				num5 = 8 + (-chmdtebj5q.method_0() & 7);
				goto IL_00f8;
				IL_00f8:
				if (num5 > 0)
				{
					chmdtebj5q.hP671p90wq(2, 10);
					goto IL_00f3;
				}
				goto IL_00fc;
				IL_00fc:
				NRgdpWfekS = 16;
				goto IL_0123;
				IL_0093:
				if (!rGUdH8y7Ap.lDW7LwMdfI((NRgdpWfekS & 4) != 0, (NRgdpWfekS & 8) != 0))
				{
					goto IL_00bc;
				}
				goto IL_0123;
				IL_00f3:
				num5 -= 10;
				goto IL_00f8;
				IL_0080:
				if (num2 == 0 || NRgdpWfekS == 30)
				{
					break;
				}
				goto IL_0093;
				IL_0110:
				chmdtebj5q.d9A7b63tmZ();
				goto IL_011b;
				IL_011b:
				NRgdpWfekS = 30;
				goto IL_0123;
				IL_0123:
				num4 = chmdtebj5q.Dvm7wZ5pEr(byte_0, num, num2);
				goto IL_0066;
			}
			return num3 - num2;
		}

		internal static bool zf25xRogXMqUhjls1BW()
		{
			return true;
		}

		internal static bool ti94fJovHYWIKkrbe1X()
		{
			return false;
		}
	}

	internal sealed class zUU4DbMUWSR8IFUqDO7
	{
		public sealed class uC1CdoMQBSQMV2mLkiY
		{
			public short[] AY4dsUcVuM;

			public byte[] pmRd2PEKKj;

			public int jqSd9KAVme;

			public int slSdTgCICU;

			private short[] KqFdl6uf26;

			private int[] cN4dmm6M4Y;

			private int X37dNHP6yQ;

			private zUU4DbMUWSR8IFUqDO7 dksdfhTPnD;

			public uC1CdoMQBSQMV2mLkiY(zUU4DbMUWSR8IFUqDO7 zUU4DbMUWSR8IFUqDO7_0, int int_0, int int_1, int int_2)
			{
				dksdfhTPnD = zUU4DbMUWSR8IFUqDO7_0;
				jqSd9KAVme = int_1;
				X37dNHP6yQ = int_2;
				AY4dsUcVuM = new short[int_0];
				cN4dmm6M4Y = new int[int_2];
			}

			public void hCRdZ4AHUU(int int_0)
			{
				dksdfhTPnD.xqNdP8cnnw.hP671p90wq(KqFdl6uf26[int_0] & 0xFFFF, pmRd2PEKKj[int_0]);
			}

			public void XGBd48LbKv(short[] short_0, byte[] byte_0)
			{
				KqFdl6uf26 = short_0;
				pmRd2PEKKj = byte_0;
			}

			public void qeVdn0U0me()
			{
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				while (true)
				{
					int[] array = new int[X37dNHP6yQ];
					while (true)
					{
						int num = 0;
						int num2 = 3;
						if (gjesKTottFIxshhseRO())
						{
							while (true)
							{
								switch (num2)
								{
								case 3:
									KqFdl6uf26 = new short[AY4dsUcVuM.Length];
									num2 = 5;
									if (!AdbciDoiZX5DXKJlnjj())
									{
										continue;
									}
									goto IL_00ea;
								default:
									num2 = 6;
									if (gjesKTottFIxshhseRO())
									{
										continue;
									}
									break;
								case 12:
									break;
								case 7:
									goto end_IL_0077;
								case 5:
									num3 = 0;
									goto case 6;
								case 1:
									num3++;
									goto case 6;
								case 6:
								case 13:
									if (num3 < X37dNHP6yQ)
									{
										array[num3] = num;
										num += cN4dmm6M4Y[num3] << 15 - num3;
										goto case 1;
									}
									goto case 0;
								case 0:
									num4 = 0;
									goto IL_0108;
								case 10:
									goto IL_00d8;
								case 9:
									goto IL_00ea;
								case 2:
								case 11:
									goto IL_0104;
								case 4:
								case 8:
								case 14:
									goto IL_0108;
								}
								break;
							}
							continue;
						}
						goto IL_0108;
						IL_00d8:
						KqFdl6uf26[num4] = JfrdrO4OwG(array[num5 - 1]);
						goto IL_00ea;
						IL_00ea:
						int[] array2;
						int[] array3 = (array2 = array);
						int num6 = num5 - 1;
						nint num7 = num6;
						array3[num6] = array2[num7] + (1 << 16 - num5);
						goto IL_0104;
						IL_0104:
						num4++;
						goto IL_0108;
						IL_0108:
						if (num4 < slSdTgCICU)
						{
							num5 = pmRd2PEKKj[num4];
							if (num5 > 0)
							{
								goto IL_00d8;
							}
							goto IL_0104;
						}
						return;
						continue;
						end_IL_0077:
						break;
					}
				}
			}

			private void fWNdGxqihp(int[] int_0)
			{
				pmRd2PEKKj = new byte[AY4dsUcVuM.Length];
				int num8 = default(int);
				int num12 = default(int);
				int num7 = default(int);
				int num13 = default(int);
				int num6 = default(int);
				int num14 = default(int);
				int[] array4 = default(int[]);
				int num15 = default(int);
				int num16 = default(int);
				while (true)
				{
					int num = int_0.Length / 2;
					while (true)
					{
						int num2 = (num + 1) / 2;
						while (true)
						{
							int num3 = 0;
							while (true)
							{
								IL_02dd:
								int num4 = 0;
								int num5 = 9;
								if (!gjesKTottFIxshhseRO())
								{
									goto IL_012c;
								}
								goto IL_024f;
								IL_024f:
								int[] array;
								nint num10;
								while (true)
								{
									switch (num5)
									{
									case 32:
										if (num8 != 0)
										{
											num12 = cN4dmm6M4Y[num8 - 1];
											goto case 1;
										}
										return;
									case 28:
										if (int_0[num7 + 1] == -1)
										{
											num5 = 12;
											if (AdbciDoiZX5DXKJlnjj())
											{
											}
											continue;
										}
										goto case 1;
									case 15:
										num13 = 2 * num2;
										goto case 13;
									case 13:
										num8 = X37dNHP6yQ;
										goto case 32;
									case 1:
									case 17:
										if (num12 > 0)
										{
											num7 = 2 * int_0[num13++];
											goto case 28;
										}
										num8--;
										num5 = 32;
										if (gjesKTottFIxshhseRO())
										{
											continue;
										}
										goto case 15;
									case 31:
										break;
									case 4:
										goto IL_00a1;
									case 23:
										goto IL_00b1;
									case 24:
										goto IL_00b7;
									case 18:
										goto IL_00d8;
									case 0:
										goto IL_010b;
									case 9:
										goto IL_010f;
									case 6:
										goto IL_0120;
									case 3:
										goto IL_012c;
									case 11:
									case 14:
										goto IL_0133;
									case 25:
										goto IL_0144;
									case 27:
										goto IL_016a;
									case 26:
										num12--;
										goto case 1;
									case 5:
									case 22:
									{
										int[] array2 = (array = cN4dmm6M4Y);
										int num9 = X37dNHP6yQ - 1;
										num10 = num9;
										array2[num9] = array[num10] + num3;
										int[] array3 = (array = cN4dmm6M4Y);
										int num11 = X37dNHP6yQ - 2;
										num10 = num11;
										array3[num11] = array[num10] - num3;
										goto case 15;
									}
									case 19:
										goto IL_01e3;
									case 16:
										if (num3 > 0)
										{
											goto case 7;
										}
										goto case 2;
									case 7:
										if (num6 < X37dNHP6yQ - 1)
										{
											goto IL_0154;
										}
										goto case 2;
									case 2:
										if (num3 > 0)
										{
											goto IL_0144;
										}
										goto case 5;
									case 12:
										pmRd2PEKKj[int_0[num7]] = (byte)num8;
										goto case 26;
									case 8:
										num3 -= 1 << X37dNHP6yQ - 1 - num6;
										goto case 16;
									default:
										num5 = 30;
										if (!AdbciDoiZX5DXKJlnjj())
										{
											continue;
										}
										goto case 2;
									case 10:
										goto IL_02dd;
									case 20:
										goto end_IL_02dd;
									case 29:
										goto end_IL_02f4;
									case 21:
										goto end_IL_02fa;
									case 30:
										return;
									}
									break;
								}
								goto IL_0087;
								IL_01e3:
								pmRd2PEKKj[int_0[2 * num14]] = (byte)array4[num14];
								goto IL_00cd;
								IL_0087:
								num14 = num - 1;
								goto IL_012c;
								IL_012c:
								if (num14 >= 0)
								{
									if (int_0[2 * num14 + 1] != -1)
									{
										num15 = array4[num14] + 1;
										goto IL_00a1;
									}
									num16 = array4[num14];
									goto IL_00d8;
								}
								goto IL_0133;
								IL_0133:
								if (num3 != 0)
								{
									num6 = X37dNHP6yQ - 1;
									goto IL_0144;
								}
								return;
								IL_0120:
								array4[num - 1] = 0;
								goto IL_0087;
								IL_0144:
								while (cN4dmm6M4Y[--num6] == 0)
								{
								}
								goto IL_0154;
								IL_0154:
								int[] array5 = (array = cN4dmm6M4Y);
								int num17 = num6;
								num10 = num17;
								array5[num17] = array[num10] - 1;
								goto IL_016a;
								IL_016a:
								int[] array6 = (array = cN4dmm6M4Y);
								int num18 = ++num6;
								num10 = num18;
								array6[num18] = array[num10] + 1;
								num5 = 8;
								if (!gjesKTottFIxshhseRO())
								{
									goto end_IL_02f4;
								}
								goto IL_024f;
								IL_00d8:
								int[] array7 = (array = cN4dmm6M4Y);
								int num19 = num16 - 1;
								num10 = num19;
								array7[num19] = array[num10] + 1;
								num5 = 19;
								if (!gjesKTottFIxshhseRO())
								{
									goto IL_010f;
								}
								goto IL_024f;
								IL_010f:
								if (num4 < X37dNHP6yQ)
								{
									cN4dmm6M4Y[num4] = 0;
									goto IL_010b;
								}
								array4 = new int[num];
								goto IL_0120;
								IL_00a1:
								if (num15 > X37dNHP6yQ)
								{
									num15 = X37dNHP6yQ;
									goto IL_00b1;
								}
								goto IL_00b7;
								IL_010b:
								num4++;
								goto IL_010f;
								IL_00b1:
								num3++;
								goto IL_00b7;
								IL_00b7:
								array4[int_0[2 * num14]] = (array4[int_0[2 * num14 + 1]] = num15);
								goto IL_00cd;
								IL_00cd:
								num14--;
								goto IL_012c;
								continue;
								end_IL_02dd:
								break;
							}
							continue;
							end_IL_02f4:
							break;
						}
						continue;
						end_IL_02fa:
						break;
					}
				}
			}

			public void PkbdINUo3q()
			{
				int num = AY4dsUcVuM.Length;
				int num5 = default(int);
				int[] array2 = default(int[]);
				int num10 = default(int);
				int num11 = default(int);
				int[] array3 = default(int[]);
				int num7 = default(int);
				int num15 = default(int);
				int num14 = default(int);
				int num13 = default(int);
				int num16 = default(int);
				int num18 = default(int);
				int num12 = default(int);
				int num9 = default(int);
				int num17 = default(int);
				int num21 = default(int);
				while (true)
				{
					int[] array = new int[num];
					while (true)
					{
						IL_0230:
						int num2 = 0;
						int num3 = 0;
						while (true)
						{
							IL_022b:
							int num4 = 0;
							while (true)
							{
								IL_021e:
								int num6;
								if (num4 < num)
								{
									num5 = AY4dsUcVuM[num4];
									num6 = 33;
									if (AdbciDoiZX5DXKJlnjj())
									{
										break;
									}
									goto IL_010a;
								}
								goto IL_00c5;
								IL_0063:
								array2 = new int[4 * num2 - 2];
								goto IL_0070;
								IL_010a:
								while (true)
								{
									switch (num6)
									{
									case 10:
									case 18:
									case 41:
										if (num10 < num2)
										{
											num11 = array[num10];
											goto case 17;
										}
										goto default;
									case 17:
										array2[2 * num10] = num11;
										array2[2 * num10 + 1] = -1;
										num6 = 28;
										if (AdbciDoiZX5DXKJlnjj())
										{
										}
										continue;
									case 40:
										break;
									case 15:
										goto IL_0070;
									case 33:
										goto IL_008e;
									case 36:
										goto IL_00a3;
									case 25:
										goto IL_00ae;
									case 24:
									case 35:
										goto IL_00c5;
									case 28:
										array3[num10] = AY4dsUcVuM[num11] << 8;
										goto case 5;
									case 5:
										array[num10] = num10;
										goto case 1;
									case 1:
										num10++;
										goto case 10;
									case 19:
										num10 = 0;
										goto case 10;
									case 16:
										num7 = num2++;
										goto IL_01f3;
									case 43:
									{
										int num8;
										if (AY4dsUcVuM[array[num8 = (num7 - 1) / 2]] > num5)
										{
											array[num7] = array[num8];
											num7 = num8;
											goto IL_01f3;
										}
										goto case 7;
									}
									case 7:
										array[num7] = num4;
										goto case 14;
									case 14:
										num3 = num4;
										goto IL_0218;
									case 26:
										goto IL_0218;
									case 32:
									case 38:
										goto IL_021e;
									case 39:
										goto IL_022b;
									case 42:
										goto IL_0230;
									case 2:
										goto end_IL_021e;
									case 48:
										num15 = (array3[num14] = array3[num13] + array3[num16] - num18 + 1);
										goto case 13;
									case 13:
										num12 = 0;
										goto case 44;
									case 44:
										num9 = 1;
										goto case 46;
									case 47:
										if (array3[array[num9]] > array3[array[num9 + 1]])
										{
											num9++;
										}
										goto case 20;
									case 20:
										array[num12] = array[num9];
										num12 = num9;
										num9 = num12 * 2 + 1;
										goto case 46;
									case 46:
										if (num9 < num2)
										{
											if (num9 + 1 < num2)
											{
												goto case 47;
											}
											goto case 20;
										}
										goto case 8;
									case 8:
									case 34:
										while ((num9 = num12) > 0 && array3[array[num12 = (num9 - 1) / 2]] > num15)
										{
											array[num9] = array[num12];
										}
										array[num9] = num14;
										if (num2 > 1)
										{
											goto default;
										}
										goto case 49;
									case 3:
										num12 = 0;
										num9 = 1;
										goto case 21;
									case 27:
										num9++;
										goto case 6;
									case 6:
										array[num12] = array[num9];
										goto case 29;
									case 29:
									case 45:
										num12 = num9;
										goto case 4;
									case 4:
										num9 = num9 * 2 + 1;
										goto case 21;
									case 21:
									case 23:
										if (num9 < num2)
										{
											if (num9 + 1 < num2 && array3[array[num9]] > array3[array[num9 + 1]])
											{
												goto case 27;
											}
											goto case 6;
										}
										num15 = array3[num14];
										goto case 11;
									case 11:
									case 31:
										while ((num9 = num12) > 0 && array3[array[num12 = (num9 - 1) / 2]] > num15)
										{
											array[num9] = array[num12];
										}
										goto case 22;
									case 22:
										array[num9] = num14;
										goto case 37;
									case 37:
										num16 = array[0];
										goto case 9;
									case 9:
										num14 = num17++;
										array2[2 * num14] = num13;
										goto case 30;
									case 30:
										array2[2 * num14 + 1] = num16;
										goto case 0;
									case 0:
										num18 = Math.Min(array3[num13] & 0xFF, array3[num16] & 0xFF);
										goto case 48;
									default:
										num13 = array[0];
										num14 = array[--num2];
										goto case 3;
									case 49:
										{
											fWNdGxqihp(array2);
											return;
										}
										IL_01f3:
										if (num7 > 0)
										{
											goto case 43;
										}
										goto case 7;
									}
									break;
								}
								goto IL_0063;
								IL_00ae:
								int num19 = 0;
								goto IL_00b8;
								IL_00b8:
								int num20 = num19;
								array[num2++] = num20;
								goto IL_00c5;
								IL_00c5:
								if (num2 < 2)
								{
									if (num3 >= 2)
									{
										goto IL_00ae;
									}
									num19 = ++num3;
									goto IL_00b8;
								}
								slSdTgCICU = Math.Max(num3 + 1, jqSd9KAVme);
								goto IL_00a3;
								IL_0070:
								array3 = new int[2 * num2 - 1];
								num17 = num21;
								num6 = 19;
								if (!gjesKTottFIxshhseRO())
								{
									goto IL_008e;
								}
								goto IL_010a;
								IL_008e:
								if (num5 != 0)
								{
									num6 = 16;
									if (AdbciDoiZX5DXKJlnjj())
									{
									}
									goto IL_010a;
								}
								goto IL_0218;
								IL_0218:
								num4++;
								continue;
								IL_00a3:
								num21 = num2;
								goto IL_0063;
								continue;
								end_IL_021e:
								break;
							}
							break;
						}
						break;
					}
				}
			}

			public int o3Qd85hwqp()
			{
				int num = 0;
				int num2 = 0;
				while (num2 < AY4dsUcVuM.Length)
				{
					num += AY4dsUcVuM[num2] * pmRd2PEKKj[num2];
					if (gjesKTottFIxshhseRO())
					{
						switch (3)
						{
						case 1:
						case 3:
							num2++;
							continue;
						default:
							continue;
						case 5:
							break;
						}
					}
					break;
				}
				return num;
			}

			public void qVGdFMYuQw(uC1CdoMQBSQMV2mLkiY uC1CdoMQBSQMV2mLkiY_0)
			{
				int num = -1;
				int num2 = 0;
				int num6 = default(int);
				while (num2 < slSdTgCICU)
				{
					int num3 = 1;
					while (true)
					{
						IL_0105:
						int num4 = pmRd2PEKKj[num2];
						int num5;
						if (num4 != 0)
						{
							num5 = 6;
							num6 = 3;
							goto IL_00e6;
						}
						num5 = 138;
						int num7 = 16;
						if (!AdbciDoiZX5DXKJlnjj())
						{
							goto IL_0055;
						}
						goto IL_0119;
						IL_0166:
						short[] aY4dsUcVuM;
						(aY4dsUcVuM = uC1CdoMQBSQMV2mLkiY_0.AY4dsUcVuM)[16] = (short)(aY4dsUcVuM[16] + 1);
						break;
						IL_013c:
						short[] array = (aY4dsUcVuM = uC1CdoMQBSQMV2mLkiY_0.AY4dsUcVuM);
						int num8 = num;
						nint num9 = num8;
						array[num8] = (short)(aY4dsUcVuM[num9] + (short)num3);
						break;
						IL_00e6:
						if (num != num4)
						{
							goto IL_00b5;
						}
						goto IL_00cb;
						IL_00cb:
						num = num4;
						num2++;
						num7 = 4;
						if (AdbciDoiZX5DXKJlnjj())
						{
						}
						goto IL_0055;
						IL_0055:
						while (true)
						{
							switch (num7)
							{
							case 10:
								if (num == pmRd2PEKKj[num2])
								{
									num2++;
									if (++num3 < num5)
									{
										goto default;
									}
									goto IL_0119;
								}
								num7 = 8;
								if (!AdbciDoiZX5DXKJlnjj())
								{
								}
								continue;
							default:
								if (num2 < slSdTgCICU)
								{
									goto case 10;
								}
								goto IL_0119;
							case 16:
								num6 = 3;
								goto IL_00cb;
							case 5:
							case 18:
								break;
							case 11:
								goto IL_00c8;
							case 0:
							case 6:
							case 7:
								goto IL_00cb;
							case 13:
								goto IL_00e6;
							case 3:
								goto IL_0105;
							case 8:
								goto IL_0119;
							case 12:
								goto IL_013c;
							case 15:
								goto IL_0152;
							case 19:
								goto IL_0166;
							case 1:
							case 9:
							case 14:
							case 17:
							case 20:
								goto end_IL_0105;
							}
							break;
						}
						goto IL_00b5;
						IL_00b5:
						short[] array2 = (aY4dsUcVuM = uC1CdoMQBSQMV2mLkiY_0.AY4dsUcVuM);
						num9 = num4;
						array2[num4] = (short)(aY4dsUcVuM[num9] + 1);
						goto IL_00c8;
						IL_00c8:
						num3 = 0;
						goto IL_00cb;
						IL_0119:
						if (num3 < num6)
						{
							goto IL_013c;
						}
						if (num == 0)
						{
							if (num3 > 10)
							{
								(aY4dsUcVuM = uC1CdoMQBSQMV2mLkiY_0.AY4dsUcVuM)[18] = (short)(aY4dsUcVuM[18] + 1);
								break;
							}
							goto IL_0152;
						}
						goto IL_0166;
						IL_0152:
						(aY4dsUcVuM = uC1CdoMQBSQMV2mLkiY_0.AY4dsUcVuM)[17] = (short)(aY4dsUcVuM[17] + 1);
						break;
						continue;
						end_IL_0105:
						break;
					}
				}
			}

			public void QyldgKSf89(uC1CdoMQBSQMV2mLkiY uC1CdoMQBSQMV2mLkiY_0)
			{
				int num = -1;
				int num2 = 0;
				while (num2 < slSdTgCICU)
				{
					int num3 = 1;
					while (true)
					{
						IL_0138:
						int num4 = pmRd2PEKKj[num2];
						while (true)
						{
							IL_012f:
							int num5;
							if (num4 != 0)
							{
								num5 = 6;
								goto IL_0126;
							}
							goto IL_0102;
							IL_00c4:
							if (num != pmRd2PEKKj[num2])
							{
								goto IL_00de;
							}
							num2++;
							goto IL_00d5;
							IL_0126:
							int num6 = 3;
							int num7;
							if (num != num4)
							{
								num7 = 9;
								if (gjesKTottFIxshhseRO())
								{
									goto IL_0063;
								}
								goto IL_00eb;
							}
							goto IL_010b;
							IL_0159:
							dksdfhTPnD.xqNdP8cnnw.hP671p90wq(num3 - 3, 2);
							break;
							IL_010b:
							num = num4;
							num2++;
							goto IL_00eb;
							IL_00eb:
							if (num2 < slSdTgCICU)
							{
								goto IL_00c4;
							}
							goto IL_00de;
							IL_00de:
							if (num3 >= num6)
							{
								if (num != 0)
								{
									goto IL_0151;
								}
								if (num3 > 10)
								{
									uC1CdoMQBSQMV2mLkiY_0.hCRdZ4AHUU(18);
									num7 = 19;
									if (!gjesKTottFIxshhseRO())
									{
										break;
									}
									goto IL_0063;
								}
								uC1CdoMQBSQMV2mLkiY_0.hCRdZ4AHUU(17);
								goto IL_016f;
							}
							goto IL_018c;
							IL_00d5:
							if (++num3 >= num5)
							{
								goto IL_00de;
							}
							goto IL_00eb;
							IL_0151:
							uC1CdoMQBSQMV2mLkiY_0.hCRdZ4AHUU(16);
							goto IL_0159;
							IL_016f:
							dksdfhTPnD.xqNdP8cnnw.hP671p90wq(num3 - 3, 3);
							break;
							IL_0063:
							while (true)
							{
								switch (num7)
								{
								case 19:
									dksdfhTPnD.xqNdP8cnnw.hP671p90wq(num3 - 11, 7);
									num7 = 22;
									if (gjesKTottFIxshhseRO())
									{
										continue;
									}
									goto IL_00eb;
								case 4:
									goto IL_00d5;
								case 12:
									goto IL_00de;
								case 14:
								case 15:
									goto IL_00eb;
								case 9:
									uC1CdoMQBSQMV2mLkiY_0.hCRdZ4AHUU(num4);
									goto case 3;
								case 3:
								case 6:
									num3 = 0;
									goto IL_010b;
								case 17:
									goto IL_0102;
								case 7:
									goto IL_0126;
								case 8:
									goto IL_012f;
								case 0:
								case 1:
									goto IL_0138;
								case 10:
									goto IL_0151;
								case 11:
									goto IL_0159;
								case 16:
									goto IL_016f;
								case 18:
								case 21:
									goto IL_018c;
								case 2:
								case 5:
								case 20:
								case 22:
									goto end_IL_012f;
								}
								break;
							}
							goto IL_00c4;
							IL_018c:
							while (num3-- > 0)
							{
								uC1CdoMQBSQMV2mLkiY_0.hCRdZ4AHUU(num);
							}
							break;
							IL_0102:
							num5 = 138;
							num6 = 3;
							goto IL_010b;
							continue;
							end_IL_012f:
							break;
						}
						break;
					}
				}
			}

			internal static bool gjesKTottFIxshhseRO()
			{
				return true;
			}

			internal static bool AdbciDoiZX5DXKJlnjj()
			{
				return false;
			}
		}

		private static readonly int[] wFsdVjqeFI;

		private static readonly byte[] sSAdiFQuqL;

		private DomFIaMccHiGtualwJl xqNdP8cnnw;

		private uC1CdoMQBSQMV2mLkiY qscdOTObUY;

		private uC1CdoMQBSQMV2mLkiY KiLdjNw4W7;

		private uC1CdoMQBSQMV2mLkiY XI3dCN8Vm9;

		private short[] l3OdqSl2HX;

		private byte[] x5MdSLgDLr;

		private int kOKd6j1ecQ;

		private int pCUdoOV8C5;

		private static readonly short[] na2dEUDNd1;

		private static readonly byte[] KaRda1ISoP;

		private static readonly short[] PYrdBOdhxI;

		private static readonly byte[] F6Od0ly1i3;

		public static short JfrdrO4OwG(int int_0)
		{
			return (short)((sSAdiFQuqL[int_0 & 0xF] << 12) | (sSAdiFQuqL[(int_0 >> 4) & 0xF] << 8) | (sSAdiFQuqL[(int_0 >> 8) & 0xF] << 4) | sSAdiFQuqL[int_0 >> 12]);
		}

		static zUU4DbMUWSR8IFUqDO7()
		{
			wFsdVjqeFI = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			while (true)
			{
				sSAdiFQuqL = new byte[16]
				{
					0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
					5, 13, 3, 11, 7, 15
				};
				while (true)
				{
					na2dEUDNd1 = new short[286];
					KaRda1ISoP = new byte[286];
					while (true)
					{
						int num = 0;
						while (true)
						{
							int num2;
							if (num < 144)
							{
								na2dEUDNd1[num] = JfrdrO4OwG(48 + num << 8);
								num2 = 5;
								if (hZ5YPLoh9Arpu7G7FSr())
								{
								}
							}
							else
							{
								num2 = 10;
								if (hZ5YPLoh9Arpu7G7FSr())
								{
								}
							}
							while (true)
							{
								switch (num2)
								{
								case 16:
								case 19:
									do
									{
										if (num < 30)
										{
											PYrdBOdhxI[num] = JfrdrO4OwG(num << 11);
											num2 = 14;
											continue;
										}
										return;
									}
									while (!V3UL0BoHECgGpSibUcD());
									continue;
								case 14:
									F6Od0ly1i3[num] = 5;
									goto case 8;
								case 8:
									num++;
									goto case 16;
								case 3:
									num = 0;
									num2 = 16;
									if (V3UL0BoHECgGpSibUcD())
									{
										continue;
									}
									goto case 2;
								case 2:
								case 12:
									F6Od0ly1i3 = new byte[30];
									goto case 3;
								case 0:
								case 7:
								case 11:
									while (num < 286)
									{
										na2dEUDNd1[num] = JfrdrO4OwG(-88 + num << 8);
										KaRda1ISoP[num++] = 8;
									}
									PYrdBOdhxI = new short[30];
									goto case 2;
								case 9:
								case 10:
									if (num >= 256)
									{
										goto default;
									}
									na2dEUDNd1[num] = JfrdrO4OwG(256 + num << 7);
									num2 = 4;
									if (!hZ5YPLoh9Arpu7G7FSr())
									{
										continue;
									}
									break;
								default:
									while (num < 280)
									{
										na2dEUDNd1[num] = JfrdrO4OwG(-256 + num << 9);
										KaRda1ISoP[num++] = 7;
									}
									goto case 0;
								case 4:
									KaRda1ISoP[num++] = 9;
									goto case 9;
								case 5:
									KaRda1ISoP[num++] = 8;
									break;
								case 1:
								case 13:
									break;
								case 17:
									goto end_IL_01af;
								case 15:
									goto end_IL_01bc;
								case 18:
									goto end_IL_01c0;
								}
								break;
							}
							continue;
							end_IL_01af:
							break;
						}
						continue;
						end_IL_01bc:
						break;
					}
					continue;
					end_IL_01c0:
					break;
				}
			}
		}

		public zUU4DbMUWSR8IFUqDO7(DomFIaMccHiGtualwJl domFIaMccHiGtualwJl_0)
		{
			xqNdP8cnnw = domFIaMccHiGtualwJl_0;
			qscdOTObUY = new uC1CdoMQBSQMV2mLkiY(this, 286, 257, 15);
			KiLdjNw4W7 = new uC1CdoMQBSQMV2mLkiY(this, 30, 1, 15);
			XI3dCN8Vm9 = new uC1CdoMQBSQMV2mLkiY(this, 19, 4, 7);
			l3OdqSl2HX = new short[16384];
			x5MdSLgDLr = new byte[16384];
		}

		public void Sj7dh9LFhe()
		{
			kOKd6j1ecQ = 0;
			pCUdoOV8C5 = 0;
		}

		private int fVFdkNusru(int int_0)
		{
			if (int_0 == 255)
			{
				return 285;
			}
			int num = 257;
			while (int_0 >= 8)
			{
				num += 4;
				int_0 >>= 1;
			}
			return num + int_0;
		}

		private int MmTdXwfDpu(int int_0)
		{
			int num = 0;
			while (int_0 >= 4)
			{
				num += 2;
				int_0 >>= 1;
			}
			return num + int_0;
		}

		public void uF8dRD0uCa(int int_0)
		{
			XI3dCN8Vm9.qeVdn0U0me();
			qscdOTObUY.qeVdn0U0me();
			KiLdjNw4W7.qeVdn0U0me();
			xqNdP8cnnw.hP671p90wq(qscdOTObUY.slSdTgCICU - 257, 5);
			xqNdP8cnnw.hP671p90wq(KiLdjNw4W7.slSdTgCICU - 1, 5);
			xqNdP8cnnw.hP671p90wq(int_0 - 4, 4);
			for (int i = 0; i < int_0; i++)
			{
				xqNdP8cnnw.hP671p90wq(XI3dCN8Vm9.pmRd2PEKKj[wFsdVjqeFI[i]], 3);
			}
			qscdOTObUY.QyldgKSf89(XI3dCN8Vm9);
			KiLdjNw4W7.QyldgKSf89(XI3dCN8Vm9);
		}

		public void erEdWx2E7v()
		{
			int num = 0;
			while (num < kOKd6j1ecQ)
			{
				int num2 = x5MdSLgDLr[num] & 0xFF;
				while (true)
				{
					IL_00ed:
					int num3 = l3OdqSl2HX[num];
					while (true)
					{
						IL_00e4:
						if (num3-- != 0)
						{
							while (true)
							{
								IL_00ce:
								int num4 = fVFdkNusru(num2);
								qscdOTObUY.hCRdZ4AHUU(num4);
								while (true)
								{
									IL_00c1:
									int num5 = (num4 - 261) / 4;
									while (true)
									{
										IL_00ba:
										if (num5 > 0)
										{
											goto IL_0092;
										}
										goto IL_00af;
										IL_00af:
										while (true)
										{
											IL_00af_2:
											int num6 = MmTdXwfDpu(num3);
											while (true)
											{
												IL_0083:
												KiLdjNw4W7.hCRdZ4AHUU(num6);
												while (true)
												{
													num5 = num6 / 2 - 1;
													if (num5 <= 0)
													{
														break;
													}
													if (V3UL0BoHECgGpSibUcD())
													{
														switch (12)
														{
														case 1:
															break;
														case 7:
															goto IL_0083;
														case 3:
															goto IL_0092;
														case 14:
															goto IL_0097;
														default:
															goto IL_00af_2;
														case 4:
															goto IL_00ba;
														case 0:
															goto IL_00c1;
														case 2:
														case 6:
															goto IL_00ce;
														case 8:
															goto IL_00e4;
														case 13:
															goto IL_00ed;
														case 10:
														case 12:
															xqNdP8cnnw.hP671p90wq(num3 & ((1 << num5) - 1), num5);
															goto end_IL_0071;
														case 11:
															goto end_IL_0071;
														case 5:
															goto end_IL_00e4;
														case 15:
															goto end_IL_0125;
														}
														continue;
													}
													goto end_IL_00e4;
													continue;
													end_IL_0071:
													break;
												}
												break;
											}
											break;
										}
										break;
										IL_0092:
										if (num5 <= 5)
										{
											goto IL_0097;
										}
										goto IL_00af;
										IL_0097:
										xqNdP8cnnw.hP671p90wq(num2 & ((1 << num5) - 1), num5);
										goto IL_00af;
									}
									break;
								}
								break;
							}
						}
						else
						{
							qscdOTObUY.hCRdZ4AHUU(num2);
						}
						num++;
						break;
						continue;
						end_IL_00e4:
						break;
					}
					break;
				}
				continue;
				end_IL_0125:
				break;
			}
			qscdOTObUY.hCRdZ4AHUU(256);
		}

		public void YaqdbFXcXe(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			xqNdP8cnnw.hP671p90wq(bool_0 ? 1 : 0, 3);
			while (true)
			{
				xqNdP8cnnw.d9A7b63tmZ();
				int num = 4;
				if (!hZ5YPLoh9Arpu7G7FSr())
				{
				}
				while (true)
				{
					switch (num)
					{
					case 3:
					case 5:
						xqNdP8cnnw.TZY7WomD7Z(byte_0, int_0, int_1);
						num = 6;
						if (!hZ5YPLoh9Arpu7G7FSr())
						{
							continue;
						}
						goto case 1;
					case 1:
						xqNdP8cnnw.AZy7RZkGXn(~int_1);
						goto case 3;
					case 4:
						xqNdP8cnnw.AZy7RZkGXn(int_1);
						goto case 1;
					default:
						num = 1;
						if (!hZ5YPLoh9Arpu7G7FSr())
						{
							continue;
						}
						goto case 6;
					case 0:
					case 2:
						break;
					case 6:
						Sj7dh9LFhe();
						return;
					}
					break;
				}
			}
		}

		public void h9jd1vcrsS(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			short[] aY4dsUcVuM;
			(aY4dsUcVuM = qscdOTObUY.AY4dsUcVuM)[256] = (short)(aY4dsUcVuM[256] + 1);
			while (true)
			{
				qscdOTObUY.PkbdINUo3q();
				while (true)
				{
					KiLdjNw4W7.PkbdINUo3q();
					while (true)
					{
						qscdOTObUY.qVGdFMYuQw(XI3dCN8Vm9);
						KiLdjNw4W7.qVGdFMYuQw(XI3dCN8Vm9);
						while (true)
						{
							XI3dCN8Vm9.PkbdINUo3q();
							while (true)
							{
								int num = 4;
								int num2 = 18;
								while (true)
								{
									IL_01c0:
									if (num2 > num)
									{
										if (XI3dCN8Vm9.pmRd2PEKKj[wFsdVjqeFI[num2]] <= 0)
										{
											goto IL_003f;
										}
									}
									else
									{
										int num3 = 14 + num * 3 + XI3dCN8Vm9.o3Qd85hwqp() + qscdOTObUY.o3Qd85hwqp() + KiLdjNw4W7.o3Qd85hwqp() + pCUdoOV8C5;
										while (true)
										{
											IL_01b7:
											int num4 = pCUdoOV8C5;
											while (true)
											{
												IL_01b3:
												int num5 = 0;
												while (true)
												{
													IL_01a6:
													if (num5 < 286)
													{
														num4 += qscdOTObUY.AY4dsUcVuM[num5] * KaRda1ISoP[num5];
														goto IL_009b;
													}
													while (true)
													{
														int num6 = 0;
														while (true)
														{
															IL_0194:
															if (num6 < 30)
															{
																num4 += KiLdjNw4W7.AY4dsUcVuM[num6] * F6Od0ly1i3[num6];
																goto IL_00bc;
															}
															if (num3 >= num4)
															{
																goto IL_018b;
															}
															goto IL_018e;
															IL_00bc:
															num6++;
															continue;
															IL_018e:
															while (true)
															{
																if (int_0 >= 0)
																{
																	goto IL_0172;
																}
																goto IL_017e;
																IL_017e:
																if (num3 != num4)
																{
																	xqNdP8cnnw.hP671p90wq(4 + (bool_0 ? 1 : 0), 3);
																	if (!V3UL0BoHECgGpSibUcD())
																	{
																		break;
																	}
																	switch (10)
																	{
																	case 3:
																		break;
																	case 24:
																		goto IL_003f;
																	case 15:
																		goto IL_009b;
																	case 8:
																		goto IL_00bc;
																	case 1:
																		goto IL_0172;
																	case 5:
																		goto IL_018b;
																	case 22:
																		continue;
																	case 6:
																	case 14:
																		goto IL_0194;
																	default:
																		goto end_IL_018e;
																	case 4:
																	case 19:
																		goto IL_01a6;
																	case 17:
																		goto IL_01b3;
																	case 13:
																		goto IL_01b7;
																	case 2:
																		goto IL_01c0;
																	case 20:
																		goto end_IL_01c0;
																	case 23:
																		goto end_IL_01ce;
																	case 12:
																		goto end_IL_01d7;
																	case 7:
																		goto end_IL_01e4;
																	case 0:
																	case 11:
																		goto end_IL_0208;
																	case 16:
																		goto IL_0262;
																	case 18:
																		goto IL_0268;
																	case 21:
																		return;
																	case 10:
																	case 25:
																		uF8dRD0uCa(num);
																		erEdWx2E7v();
																		goto case 28;
																	case 26:
																		goto IL_0280;
																	case 27:
																		return;
																	case 28:
																		Sj7dh9LFhe();
																		return;
																	}
																	goto end_IL_01a2;
																}
																xqNdP8cnnw.hP671p90wq(2 + (bool_0 ? 1 : 0), 3);
																qscdOTObUY.XGBd48LbKv(na2dEUDNd1, KaRda1ISoP);
																KiLdjNw4W7.XGBd48LbKv(PYrdBOdhxI, F6Od0ly1i3);
																goto IL_0262;
																IL_0268:
																Sj7dh9LFhe();
																return;
																IL_0262:
																erEdWx2E7v();
																goto IL_0268;
																IL_0280:
																YaqdbFXcXe(byte_0, int_0, int_1, bool_0);
																return;
																IL_0172:
																if (int_1 + 4 >= num3 >> 3)
																{
																	goto IL_017e;
																}
																goto IL_0280;
																continue;
																end_IL_018e:
																break;
															}
															break;
															IL_018b:
															num3 = num4;
															goto IL_018e;
														}
														continue;
														end_IL_01a2:
														break;
													}
													break;
													IL_009b:
													num5++;
												}
												break;
											}
											break;
										}
									}
									num = num2 + 1;
									goto IL_003f;
									IL_003f:
									num2--;
									continue;
									end_IL_01c0:
									break;
								}
								continue;
								end_IL_01ce:
								break;
							}
							continue;
							end_IL_01d7:
							break;
						}
						continue;
						end_IL_01e4:
						break;
					}
					continue;
					end_IL_0208:
					break;
				}
			}
		}

		public bool aQ8dwJRRUQ()
		{
			return kOKd6j1ecQ >= 16384;
		}

		public bool lxddetEyx4(int int_0)
		{
			l3OdqSl2HX[kOKd6j1ecQ] = 0;
			while (true)
			{
				x5MdSLgDLr[kOKd6j1ecQ++] = (byte)int_0;
				while (true)
				{
					short[] aY4dsUcVuM;
					short[] array = (aY4dsUcVuM = qscdOTObUY.AY4dsUcVuM);
					nint num = int_0;
					array[int_0] = (short)(aY4dsUcVuM[num] + 1);
					if (V3UL0BoHECgGpSibUcD())
					{
						switch (4)
						{
						default:
							continue;
						case 0:
						case 3:
							break;
						case 4:
							return aQ8dwJRRUQ();
						}
					}
					break;
				}
			}
		}

		public bool fmUdx4g1la(int int_0, int int_1)
		{
			l3OdqSl2HX[kOKd6j1ecQ] = (short)int_0;
			x5MdSLgDLr[kOKd6j1ecQ++] = (byte)(int_1 - 3);
			int num = fVFdkNusru(int_1 - 3);
			short[] aY4dsUcVuM;
			short[] array = (aY4dsUcVuM = qscdOTObUY.AY4dsUcVuM);
			nint num2 = num;
			array[num] = (short)(aY4dsUcVuM[num2] + 1);
			if (num >= 265 && num < 285)
			{
				pCUdoOV8C5 += (num - 261) / 4;
			}
			int num3 = MmTdXwfDpu(int_0 - 1);
			short[] array2 = (aY4dsUcVuM = KiLdjNw4W7.AY4dsUcVuM);
			num2 = num3;
			array2[num3] = (short)(aY4dsUcVuM[num2] + 1);
			if (num3 >= 4)
			{
				pCUdoOV8C5 += num3 / 2 - 1;
			}
			return aQ8dwJRRUQ();
		}

		internal static bool V3UL0BoHECgGpSibUcD()
		{
			return true;
		}

		internal static bool hZ5YPLoh9Arpu7G7FSr()
		{
			return false;
		}
	}

	internal sealed class Qatc8MMpIgjbgXZC0ov
	{
		private int lur7urJLrp;

		private short[] tMQ7dInq1J;

		private short[] reV77hnFKn;

		private int eyx7JIgkTK;

		private int jhK7KyfdHc;

		private bool vHT7Aa2NwG;

		private int hWG7U8M2Ch;

		private int hVW7QjAbKW;

		private int RYM7pWKUam;

		private byte[] t6Z7cx9piJ;

		private byte[] jii7tN8HbD;

		private int uw67HPSbI2;

		private int Mm57rn4kMb;

		private int FFe7hNpwxu;

		private DomFIaMccHiGtualwJl yRM7kIcufZ;

		private zUU4DbMUWSR8IFUqDO7 JqW7XQjEHX;

		public Qatc8MMpIgjbgXZC0ov(DomFIaMccHiGtualwJl domFIaMccHiGtualwJl_0)
		{
			yRM7kIcufZ = domFIaMccHiGtualwJl_0;
			while (true)
			{
				JqW7XQjEHX = new zUU4DbMUWSR8IFUqDO7(domFIaMccHiGtualwJl_0);
				while (true)
				{
					IL_004e:
					t6Z7cx9piJ = new byte[65536];
					while (true)
					{
						tMQ7dInq1J = new short[32768];
						if (!dOv8bZoIDt8StUdf5N8())
						{
							break;
						}
						switch (4)
						{
						case 0:
							goto IL_004e;
						case 1:
							goto end_IL_000f;
						case 3:
						case 4:
							reV77hnFKn = new short[32768];
							goto case 6;
						case 6:
						{
							int num = 1;
							hVW7QjAbKW = 1;
							hWG7U8M2Ch = 1;
							return;
						}
						}
						continue;
						end_IL_000f:
						break;
					}
					break;
				}
			}
		}

		private void hG0d5oU0nZ()
		{
			lur7urJLrp = (t6Z7cx9piJ[hVW7QjAbKW] << 5) ^ t6Z7cx9piJ[hVW7QjAbKW + 1];
		}

		private int mPgdDhwiu3()
		{
			int num = ((lur7urJLrp << 5) ^ t6Z7cx9piJ[hVW7QjAbKW + 2]) & 0x7FFF;
			short num2 = (reV77hnFKn[hVW7QjAbKW & 0x7FFF] = tMQ7dInq1J[num]);
			tMQ7dInq1J[num] = (short)hVW7QjAbKW;
			lur7urJLrp = num;
			return num2 & 0xFFFF;
		}

		private void MdAd3c2w6r()
		{
			Array.Copy(t6Z7cx9piJ, 32768, t6Z7cx9piJ, 0, 32768);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				eyx7JIgkTK -= 32768;
				hVW7QjAbKW -= 32768;
				if (dOv8bZoIDt8StUdf5N8())
				{
					switch (10)
					{
					case 2:
						break;
					case 1:
					case 10:
						goto IL_0088;
					case 5:
						goto IL_009a;
					case 6:
						goto IL_00ad;
					default:
						goto IL_00c8;
					case 3:
					case 8:
						goto IL_00cc;
					case 11:
						goto IL_00e7;
					case 9:
						goto IL_0102;
					case 4:
					case 7:
					case 12:
						goto IL_0106;
					}
					continue;
				}
				goto IL_0088;
				IL_00ad:
				tMQ7dInq1J[num] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
				goto IL_00c8;
				IL_0088:
				hWG7U8M2Ch -= 32768;
				goto IL_009a;
				IL_009a:
				num = 0;
				goto IL_00cc;
				IL_00cc:
				if (num < 32768)
				{
					num2 = tMQ7dInq1J[num] & 0xFFFF;
					goto IL_00ad;
				}
				num3 = 0;
				goto IL_0106;
				IL_00c8:
				num++;
				goto IL_00cc;
				IL_0106:
				if (num3 < 32768)
				{
					num4 = reV77hnFKn[num3] & 0xFFFF;
					goto IL_00e7;
				}
				break;
				IL_0102:
				num3++;
				goto IL_0106;
				IL_00e7:
				reV77hnFKn[num3] = (short)((num4 >= 32768) ? (num4 - 32768) : 0);
				goto IL_0102;
			}
		}

		public void DnJdv9w2Lk()
		{
			if (hVW7QjAbKW >= 65274)
			{
				goto IL_0117;
			}
			goto IL_011d;
			IL_011d:
			int num2 = default(int);
			while (true)
			{
				if (RYM7pWKUam < 262)
				{
					goto IL_00cf;
				}
				goto IL_00dd;
				IL_00dd:
				int num;
				if (RYM7pWKUam >= 3)
				{
					num = 12;
					if (!dYyZBtoDFves4gt71Ef())
					{
						goto IL_0027;
					}
					goto IL_00cf;
				}
				return;
				IL_0065:
				Array.Copy(jii7tN8HbD, Mm57rn4kMb, t6Z7cx9piJ, hVW7QjAbKW + RYM7pWKUam, num2);
				num = 6;
				if (!dYyZBtoDFves4gt71Ef())
				{
					goto IL_0027;
				}
				goto IL_012d;
				IL_0027:
				switch (num)
				{
				case 11:
					break;
				case 0:
				case 2:
					goto IL_00bf;
				case 10:
					goto IL_00cf;
				case 1:
					goto IL_00dd;
				case 6:
					Mm57rn4kMb += num2;
					goto default;
				default:
					uw67HPSbI2 += num2;
					goto case 8;
				case 8:
					RYM7pWKUam += num2;
					continue;
				case 9:
					goto end_IL_011d;
				case 4:
				case 5:
				case 7:
					continue;
				case 12:
					goto IL_012d;
				}
				goto IL_0065;
				IL_00cf:
				if (Mm57rn4kMb < FFe7hNpwxu)
				{
					num2 = 65536 - RYM7pWKUam - hVW7QjAbKW;
					if (num2 <= FFe7hNpwxu - Mm57rn4kMb)
					{
						goto IL_0065;
					}
					goto IL_00bf;
				}
				goto IL_00dd;
				IL_012d:
				hG0d5oU0nZ();
				return;
				IL_00bf:
				num2 = FFe7hNpwxu - Mm57rn4kMb;
				goto IL_0065;
				continue;
				end_IL_011d:
				break;
			}
			goto IL_0117;
			IL_0117:
			MdAd3c2w6r();
			goto IL_011d;
		}

		private bool xxCdynLn9W(int int_0)
		{
			int num = 128;
			int num2 = 128;
			int num9 = default(int);
			while (true)
			{
				short[] array = reV77hnFKn;
				while (true)
				{
					int num3 = hVW7QjAbKW;
					int num4 = hVW7QjAbKW + jhK7KyfdHc;
					while (true)
					{
						int num5 = Math.Max(jhK7KyfdHc, 2);
						int num6 = Math.Max(hVW7QjAbKW - 32506, 0);
						while (true)
						{
							int num7 = hVW7QjAbKW + 258 - 1;
							while (true)
							{
								byte b = t6Z7cx9piJ[num4 - 1];
								while (true)
								{
									IL_02b5:
									byte b2 = t6Z7cx9piJ[num4];
									while (true)
									{
										IL_02ae:
										if (num5 >= 8)
										{
											goto IL_0288;
										}
										goto IL_02a3;
										IL_02a3:
										while (true)
										{
											int num8;
											if (num2 > RYM7pWKUam)
											{
												num8 = 12;
												if (!dOv8bZoIDt8StUdf5N8())
												{
													goto IL_013e;
												}
												goto IL_01b7;
											}
											goto IL_0274;
											IL_0064:
											num3 = hVW7QjAbKW;
											num8 = 4;
											if (dYyZBtoDFves4gt71Ef())
											{
											}
											goto IL_01b7;
											IL_0274:
											if (t6Z7cx9piJ[int_0 + num5] != b2)
											{
												goto IL_0011;
											}
											goto IL_0257;
											IL_0257:
											if (t6Z7cx9piJ[int_0 + num5 - 1] != b)
											{
												goto IL_0011;
											}
											goto IL_023d;
											IL_023d:
											if (t6Z7cx9piJ[int_0] != t6Z7cx9piJ[num3] || t6Z7cx9piJ[int_0 + 1] != t6Z7cx9piJ[num3 + 1])
											{
												goto IL_0011;
											}
											num8 = 22;
											if (!dOv8bZoIDt8StUdf5N8())
											{
												break;
											}
											goto IL_01b7;
											IL_0011:
											if ((int_0 = array[int_0 & 0x7FFF] & 0xFFFF) > num6 && --num != 0)
											{
												goto IL_0274;
											}
											goto IL_032a;
											IL_033d:
											return jhK7KyfdHc >= 3;
											IL_01b7:
											switch (num8)
											{
											case 4:
												break;
											case 26:
												goto IL_0064;
											case 24:
												goto IL_007f;
											case 23:
												if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9] && t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9] && t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
												{
													goto case 3;
												}
												goto IL_0184;
											case 3:
												if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
												{
													goto case 17;
												}
												goto IL_0184;
											case 17:
												if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
												{
													goto case 14;
												}
												goto IL_0184;
											case 14:
												if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
												{
													goto IL_013e;
												}
												goto IL_0184;
											case 6:
												goto IL_013e;
											case 7:
												goto IL_0158;
											default:
												goto IL_015d;
											case 21:
												goto IL_0184;
											case 1:
												goto IL_018c;
											case 16:
												goto IL_01a0;
											case 22:
												num9 = int_0 + 2;
												goto case 19;
											case 19:
												num3 += 2;
												goto IL_015d;
											case 0:
												goto IL_023d;
											case 8:
											case 10:
												goto IL_0257;
											case 12:
												goto IL_026d;
											case 28:
												goto IL_0288;
											case 18:
												continue;
											case 5:
												goto IL_02ae;
											case 25:
												goto IL_02b5;
											case 15:
												goto end_IL_02a3;
											case 29:
												goto end_IL_02c3;
											case 9:
												goto end_IL_02d2;
											case 11:
												goto end_IL_02e4;
											case 13:
												goto end_IL_0308;
											case 2:
											case 27:
												goto IL_032a;
											case 30:
												goto IL_033d;
											}
											goto IL_0011;
											IL_026d:
											num2 = RYM7pWKUam;
											goto IL_0274;
											IL_013e:
											if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
											{
												goto IL_0158;
											}
											goto IL_0184;
											IL_0158:
											if (num3 < num7)
											{
												goto IL_015d;
											}
											goto IL_0184;
											IL_015d:
											if (t6Z7cx9piJ[++num3] == t6Z7cx9piJ[++num9])
											{
												num8 = 23;
												if (dOv8bZoIDt8StUdf5N8())
												{
													goto IL_01b7;
												}
											}
											goto IL_0184;
											IL_032a:
											jhK7KyfdHc = Math.Min(num5, RYM7pWKUam);
											goto IL_033d;
											IL_0184:
											if (num3 <= num4)
											{
												goto IL_0064;
											}
											goto IL_018c;
											IL_018c:
											eyx7JIgkTK = int_0;
											num4 = num3;
											num5 = num3 - hVW7QjAbKW;
											goto IL_01a0;
											IL_01a0:
											if (num5 < num2)
											{
												goto IL_007f;
											}
											goto IL_032a;
											IL_007f:
											b = t6Z7cx9piJ[num4 - 1];
											b2 = t6Z7cx9piJ[num4];
											goto IL_0064;
											continue;
											end_IL_02a3:
											break;
										}
										break;
										IL_0288:
										num >>= 2;
										goto IL_02a3;
									}
									break;
								}
								continue;
								end_IL_02c3:
								break;
							}
							continue;
							end_IL_02d2:
							break;
						}
						continue;
						end_IL_02e4:
						break;
					}
					continue;
					end_IL_0308:
					break;
				}
			}
		}

		private bool JiAdzjiqWR(bool bool_0, bool bool_1)
		{
			if (RYM7pWKUam < 262)
			{
				goto IL_03c1;
			}
			goto IL_03ce;
			IL_03ce:
			bool flag = default(bool);
			int num = default(int);
			bool result = default(bool);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			while (true)
			{
				if (RYM7pWKUam >= 262 || bool_0)
				{
					if (RYM7pWKUam == 0)
					{
						if (!vHT7Aa2NwG)
						{
							goto IL_00dc;
						}
						goto IL_0280;
					}
					if (hVW7QjAbKW >= 65274)
					{
						goto IL_03b2;
					}
					goto IL_03b8;
				}
				goto IL_03ed;
				IL_00dc:
				vHT7Aa2NwG = false;
				goto IL_00e3;
				IL_0139:
				flag = bool_1 && RYM7pWKUam == 0 && !vHT7Aa2NwG;
				JqW7XQjEHX.h9jd1vcrsS(t6Z7cx9piJ, hWG7U8M2Ch, num, flag);
				hWG7U8M2Ch += num;
				goto IL_017c;
				IL_00e3:
				JqW7XQjEHX.h9jd1vcrsS(t6Z7cx9piJ, hWG7U8M2Ch, hVW7QjAbKW - hWG7U8M2Ch, bool_1);
				int num2 = 1;
				if (dYyZBtoDFves4gt71Ef())
				{
				}
				goto IL_02f0;
				IL_017c:
				result = !flag;
				num2 = 10;
				if (dYyZBtoDFves4gt71Ef())
				{
				}
				goto IL_02f0;
				IL_03b8:
				num3 = eyx7JIgkTK;
				goto IL_0396;
				IL_0396:
				num4 = jhK7KyfdHc;
				num2 = 20;
				if (!dOv8bZoIDt8StUdf5N8())
				{
					goto IL_01fa;
				}
				goto IL_02f0;
				IL_02f0:
				while (true)
				{
					switch (num2)
					{
					default:
						jhK7KyfdHc = 2;
						goto case 30;
					case 18:
						if (jhK7KyfdHc <= num4)
						{
							num2 = 8;
							if (dOv8bZoIDt8StUdf5N8())
							{
								continue;
							}
							goto case 13;
						}
						goto IL_007c;
					case 13:
						if (hVW7QjAbKW - eyx7JIgkTK > 4096)
						{
							goto default;
						}
						goto case 30;
					case 30:
						if (num4 >= 3)
						{
							goto case 18;
						}
						goto IL_007c;
					case 27:
						JqW7XQjEHX.lxddetEyx4(t6Z7cx9piJ[hVW7QjAbKW - 1] & 0xFF);
						goto case 2;
					case 2:
						vHT7Aa2NwG = true;
						goto case 3;
					case 3:
						hVW7QjAbKW++;
						RYM7pWKUam--;
						num2 = 23;
						if (dYyZBtoDFves4gt71Ef())
						{
						}
						continue;
					case 4:
					case 35:
						break;
					case 26:
						goto IL_00e3;
					case 34:
						goto IL_011c;
					case 31:
						goto IL_0133;
					case 11:
						goto IL_017c;
					case 28:
						RYM7pWKUam--;
						goto case 33;
					case 33:
						if (RYM7pWKUam >= 3)
						{
							num2 = 14;
							if (dYyZBtoDFves4gt71Ef())
							{
							}
							continue;
						}
						goto IL_0196;
					case 12:
						hVW7QjAbKW++;
						RYM7pWKUam--;
						goto case 22;
					case 22:
						vHT7Aa2NwG = false;
						goto IL_01fa;
					case 7:
						goto IL_01fa;
					case 23:
						goto IL_0201;
					case 24:
						if (hVW7QjAbKW - num5 > 32506 || !xxCdynLn9W(num5))
						{
							goto case 30;
						}
						goto case 9;
					case 9:
					case 15:
						if (jhK7KyfdHc > 5)
						{
							goto case 30;
						}
						num2 = 21;
						if (!dYyZBtoDFves4gt71Ef())
						{
							continue;
						}
						goto IL_03f1;
					case 21:
						if (jhK7KyfdHc == 3)
						{
							goto case 13;
						}
						goto case 30;
					case 20:
						if (RYM7pWKUam < 3)
						{
							goto case 30;
						}
						num5 = mPgdDhwiu3();
						goto case 6;
					case 6:
						if (num5 == 0)
						{
							goto case 30;
						}
						goto case 24;
					case 16:
						goto IL_0280;
					case 14:
						mPgdDhwiu3();
						goto IL_0196;
					case 8:
						JqW7XQjEHX.fmUdx4g1la(hVW7QjAbKW - 1 - num3, num4);
						num4 -= 2;
						goto IL_019e;
					case 1:
						hWG7U8M2Ch = hVW7QjAbKW;
						num2 = 5;
						if (!dYyZBtoDFves4gt71Ef())
						{
							continue;
						}
						goto IL_017c;
					case 25:
						goto IL_0396;
					case 19:
						goto IL_03b2;
					case 29:
						goto IL_03b8;
					case 37:
						goto end_IL_03ce;
					case 5:
						result = false;
						goto IL_03f1;
					case 17:
						goto IL_03e9;
					case 38:
						goto IL_03ed;
					case 0:
					case 10:
					case 32:
						goto IL_03f1;
						IL_007c:
						if (vHT7Aa2NwG)
						{
							goto case 27;
						}
						goto case 2;
						IL_0196:
						if (--num4 > 0)
						{
							goto IL_019e;
						}
						goto case 12;
						IL_019e:
						hVW7QjAbKW++;
						goto case 28;
					}
					break;
				}
				goto IL_00dc;
				IL_03ed:
				result = true;
				goto IL_03f1;
				IL_03b2:
				MdAd3c2w6r();
				goto IL_03b8;
				IL_0280:
				JqW7XQjEHX.lxddetEyx4(t6Z7cx9piJ[hVW7QjAbKW - 1] & 0xFF);
				goto IL_00dc;
				IL_01fa:
				jhK7KyfdHc = 2;
				goto IL_0201;
				IL_0201:
				if (!JqW7XQjEHX.aQ8dwJRRUQ())
				{
					continue;
				}
				goto IL_011c;
				IL_011c:
				num = hVW7QjAbKW - hWG7U8M2Ch;
				if (vHT7Aa2NwG)
				{
					goto IL_0133;
				}
				goto IL_0139;
				IL_0133:
				num--;
				goto IL_0139;
				continue;
				end_IL_03ce:
				break;
			}
			goto IL_03c1;
			IL_03e9:
			result = false;
			goto IL_03f1;
			IL_03f1:
			return result;
			IL_03c1:
			if (bool_0)
			{
				goto IL_03ce;
			}
			goto IL_03e9;
		}

		public bool lDW7LwMdfI(bool bool_0, bool bool_1)
		{
			bool flag;
			do
			{
				DnJdv9w2Lk();
				bool bool_2 = bool_0 && Mm57rn4kMb == FFe7hNpwxu;
				flag = JiAdzjiqWR(bool_2, bool_1);
			}
			while (yRM7kIcufZ.method_1() && flag);
			return flag;
		}

		public void hAI7MYGYSg(byte[] byte_0)
		{
			jii7tN8HbD = byte_0;
			Mm57rn4kMb = 0;
			FFe7hNpwxu = byte_0.Length;
		}

		public bool IZQ7YHi0dv()
		{
			return FFe7hNpwxu == Mm57rn4kMb;
		}

		internal static bool dOv8bZoIDt8StUdf5N8()
		{
			return true;
		}

		internal static bool dYyZBtoDFves4gt71Ef()
		{
			return false;
		}
	}

	internal sealed class DomFIaMccHiGtualwJl
	{
		protected byte[] eob7ebDfiE;

		private int nBs7xXRSY1;

		private int YZq7VRAwPK;

		private uint Mgb7iMEe3o;

		private int Wmt7PjpXIn;

		public void AZy7RZkGXn(int int_0)
		{
			eob7ebDfiE[YZq7VRAwPK++] = (byte)int_0;
			eob7ebDfiE[YZq7VRAwPK++] = (byte)(int_0 >> 8);
		}

		public void TZY7WomD7Z(byte[] byte_0, int int_0, int int_1)
		{
			Array.Copy(byte_0, int_0, eob7ebDfiE, YZq7VRAwPK, int_1);
			YZq7VRAwPK += int_1;
		}

		[SpecialName]
		public int method_0()
		{
			return Wmt7PjpXIn;
		}

		public void d9A7b63tmZ()
		{
			if (Wmt7PjpXIn > 0)
			{
				eob7ebDfiE[YZq7VRAwPK++] = (byte)Mgb7iMEe3o;
				if (Wmt7PjpXIn > 8)
				{
					eob7ebDfiE[YZq7VRAwPK++] = (byte)(Mgb7iMEe3o >> 8);
				}
			}
			Mgb7iMEe3o = 0u;
			Wmt7PjpXIn = 0;
		}

		public void hP671p90wq(int int_0, int int_1)
		{
			Mgb7iMEe3o |= (uint)(int_0 << Wmt7PjpXIn);
			if (lUdob7ojUbWDtMgkiCa())
			{
				switch (6)
				{
				case 6:
					Wmt7PjpXIn += int_1;
					break;
				case 1:
				case 5:
					break;
				case 2:
				case 3:
					goto IL_0066;
				default:
					goto IL_0085;
				case 4:
					goto IL_00a6;
				case 7:
					goto IL_00b5;
				}
			}
			if (Wmt7PjpXIn < 16)
			{
				return;
			}
			goto IL_0066;
			IL_00a6:
			Mgb7iMEe3o >>= 16;
			goto IL_00b5;
			IL_00b5:
			Wmt7PjpXIn -= 16;
			return;
			IL_0085:
			eob7ebDfiE[YZq7VRAwPK++] = (byte)(Mgb7iMEe3o >> 8);
			goto IL_00a6;
			IL_0066:
			eob7ebDfiE[YZq7VRAwPK++] = (byte)Mgb7iMEe3o;
			goto IL_0085;
		}

		[SpecialName]
		public bool method_1()
		{
			return YZq7VRAwPK == 0;
		}

		public int Dvm7wZ5pEr(byte[] byte_0, int int_0, int int_1)
		{
			if (Wmt7PjpXIn >= 8)
			{
				goto IL_0071;
			}
			goto IL_00ac;
			IL_00ac:
			while (true)
			{
				IL_00ac_2:
				if (int_1 > YZq7VRAwPK - nBs7xXRSY1)
				{
					int num = 9;
					if (!pvDwiVoxuXfsrOB74nL())
					{
					}
					while (true)
					{
						switch (num)
						{
						case 9:
							int_1 = YZq7VRAwPK - nBs7xXRSY1;
							num = 8;
							if (lUdob7ojUbWDtMgkiCa())
							{
								continue;
							}
							goto IL_010a;
						case 3:
							break;
						case 1:
						case 10:
							goto IL_0090;
						case 0:
						case 2:
							goto IL_00ac_2;
						case 8:
							Array.Copy(eob7ebDfiE, nBs7xXRSY1, byte_0, int_0, int_1);
							goto default;
						default:
							nBs7xXRSY1 = 0;
							goto case 5;
						case 5:
							YZq7VRAwPK = 0;
							goto IL_010a;
						case 7:
							goto IL_00fc;
						case 6:
						case 11:
							goto IL_010a;
						}
						break;
					}
					break;
				}
				Array.Copy(eob7ebDfiE, nBs7xXRSY1, byte_0, int_0, int_1);
				goto IL_00fc;
				IL_00fc:
				nBs7xXRSY1 += int_1;
				goto IL_010a;
				IL_010a:
				return int_1;
			}
			goto IL_0071;
			IL_0071:
			eob7ebDfiE[YZq7VRAwPK++] = (byte)Mgb7iMEe3o;
			goto IL_0090;
			IL_0090:
			Mgb7iMEe3o >>= 8;
			Wmt7PjpXIn -= 8;
			goto IL_00ac;
		}

		public DomFIaMccHiGtualwJl()
		{
			if (pvDwiVoxuXfsrOB74nL())
			{
			}
			switch (6)
			{
			case 6:
				eob7ebDfiE = new byte[65536];
				goto case 2;
			case 2:
				nBs7xXRSY1 = 0;
				goto case 1;
			case 1:
				YZq7VRAwPK = 0;
				goto case 3;
			case 3:
				Mgb7iMEe3o = 0u;
				goto default;
			default:
				Wmt7PjpXIn = 0;
				break;
			case 5:
			case 7:
				break;
			case 8:
				return;
			}
			base._002Ector();
		}

		internal static bool lUdob7ojUbWDtMgkiCa()
		{
			return true;
		}

		internal static bool pvDwiVoxuXfsrOB74nL()
		{
			return false;
		}
	}

	internal sealed class puC0seMtrjr1eq8RIgU : MemoryStream
	{
		public void voY7O19OsW(int int_0)
		{
			WriteByte((byte)((uint)int_0 & 0xFFu));
			WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
		}

		public void dpF7jpILEd(int int_0)
		{
			voY7O19OsW(int_0);
			voY7O19OsW(int_0 >> 16);
		}

		public int c027C4l374()
		{
			return ReadByte() | (ReadByte() << 8);
		}

		public int v7t7qPuBiA()
		{
			return c027C4l374() | (c027C4l374() << 16);
		}

		public puC0seMtrjr1eq8RIgU()
		{
		}

		public puC0seMtrjr1eq8RIgU(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}

		internal static bool IyVbxdodD0vjOufsuFa()
		{
			return true;
		}

		internal static bool i9PLJyoVRFTHTi6H6wL()
		{
			return false;
		}
	}

	public static string Vb4uUTvmHL;

	private static bool K3tu7VwBSD(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	public static byte[] M9AuJbZsh2(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !K3tu7VwBSD(executingAssembly, callingAssembly))
		{
			return null;
		}
		puC0seMtrjr1eq8RIgU puC0seMtrjr1eq8RIgU = new puC0seMtrjr1eq8RIgU(byte_0);
		byte[] array = new byte[0];
		int num = puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
		if (num == 67324752)
		{
			short num2 = (short)puC0seMtrjr1eq8RIgU.c027C4l374();
			int num3 = puC0seMtrjr1eq8RIgU.c027C4l374();
			int num4 = puC0seMtrjr1eq8RIgU.c027C4l374();
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
			puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
			puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
			int num5 = puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
			int num6 = puC0seMtrjr1eq8RIgU.c027C4l374();
			int num7 = puC0seMtrjr1eq8RIgU.c027C4l374();
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				puC0seMtrjr1eq8RIgU.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				puC0seMtrjr1eq8RIgU.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[puC0seMtrjr1eq8RIgU.Length - puC0seMtrjr1eq8RIgU.Position];
			puC0seMtrjr1eq8RIgU.Read(array2, 0, array2.Length);
			sToVpcMuiT8weUWME9p sToVpcMuiT8weUWME9p = new sToVpcMuiT8weUWME9p(array2);
			array = new byte[num5];
			sToVpcMuiT8weUWME9p.HWvuc58l7Q(array, 0, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
					num11 = puC0seMtrjr1eq8RIgU.v7t7qPuBiA();
					byte[] array3 = new byte[num10];
					puC0seMtrjr1eq8RIgU.Read(array3, 0, array3.Length);
					sToVpcMuiT8weUWME9p sToVpcMuiT8weUWME9p2 = new sToVpcMuiT8weUWME9p(array3);
					sToVpcMuiT8weUWME9p2.HWvuc58l7Q(array, i, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 114, 158, 252, 134, 30, 110, 252, 252 };
				byte[] byte_2 = new byte[8] { 186, 58, 221, 118, 74, 189, 111, 165 };
				using yWhI73z2LAuciQik9u yWhI73z2LAuciQik9u = new yWhI73z2LAuciQik9u();
				using ICryptoTransform cryptoTransform = yWhI73z2LAuciQik9u.a6huMcxQkZ(byte_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = M9AuJbZsh2(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Ku8swevkBXkJd4SrW2 ku8swevkBXkJd4SrW = new Ku8swevkBXkJd4SrW2();
				using ICryptoTransform cryptoTransform2 = ku8swevkBXkJd4SrW.U8pYvL3heZ(byte_4, byte_5, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = M9AuJbZsh2(byte_6);
			}
		}
		puC0seMtrjr1eq8RIgU.Close();
		puC0seMtrjr1eq8RIgU = null;
		return array;
	}

	public static byte[] jrYuK431T8(byte[] byte_0)
	{
		return HlnuA14bZe(byte_0, 1, null, null);
	}

	private static byte[] HlnuA14bZe(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			puC0seMtrjr1eq8RIgU puC0seMtrjr1eq8RIgU = new puC0seMtrjr1eq8RIgU();
			switch (int_0)
			{
			case 0:
			{
				Fvwt6WMA4AehyjZtv0x fvwt6WMA4AehyjZtv0x2 = new Fvwt6WMA4AehyjZtv0x();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
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
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_0.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(67324752);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(20);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(8);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num3);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num5);
				long position3 = puC0seMtrjr1eq8RIgU.Position;
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(0);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(byte_0.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				puC0seMtrjr1eq8RIgU.voY7O19OsW(bytes.Length);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.Write(bytes, 0, bytes.Length);
				fvwt6WMA4AehyjZtv0x2.AcZdUjcRuT(byte_0);
				while (!fvwt6WMA4AehyjZtv0x2.method_2())
				{
					byte[] array9 = new byte[512];
					int num8 = fvwt6WMA4AehyjZtv0x2.tcfdQwFslH(array9);
					if (num8 <= 0)
					{
						break;
					}
					puC0seMtrjr1eq8RIgU.Write(array9, 0, num8);
				}
				fvwt6WMA4AehyjZtv0x2.hNFdA5XGLb();
				while (!fvwt6WMA4AehyjZtv0x2.method_1())
				{
					byte[] array10 = new byte[512];
					int num9 = fvwt6WMA4AehyjZtv0x2.tcfdQwFslH(array10);
					if (num9 <= 0)
					{
						break;
					}
					puC0seMtrjr1eq8RIgU.Write(array10, 0, num9);
				}
				long num10 = fvwt6WMA4AehyjZtv0x2.method_0();
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(33639248);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(20);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(20);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(8);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num3);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num5);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num10);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(byte_0.Length);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(bytes.Length);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(0);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(0);
				puC0seMtrjr1eq8RIgU.Write(bytes, 0, bytes.Length);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(101010256);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(1);
				puC0seMtrjr1eq8RIgU.voY7O19OsW(1);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(46 + bytes.Length);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)(30 + bytes.Length + num10));
				puC0seMtrjr1eq8RIgU.voY7O19OsW(0);
				puC0seMtrjr1eq8RIgU.Seek(position3, SeekOrigin.Begin);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)num10);
				break;
			}
			case 1:
			{
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(25000571);
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(byte_0.Length);
				byte[] array5;
				for (int i = 0; i < byte_0.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
					Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
					long position = puC0seMtrjr1eq8RIgU.Position;
					puC0seMtrjr1eq8RIgU.dpF7jpILEd(0);
					puC0seMtrjr1eq8RIgU.dpF7jpILEd(array5.Length);
					Fvwt6WMA4AehyjZtv0x fvwt6WMA4AehyjZtv0x = new Fvwt6WMA4AehyjZtv0x();
					fvwt6WMA4AehyjZtv0x.AcZdUjcRuT(array5);
					while (!fvwt6WMA4AehyjZtv0x.method_2())
					{
						byte[] array6 = new byte[512];
						int num = fvwt6WMA4AehyjZtv0x.tcfdQwFslH(array6);
						if (num <= 0)
						{
							break;
						}
						puC0seMtrjr1eq8RIgU.Write(array6, 0, num);
					}
					fvwt6WMA4AehyjZtv0x.hNFdA5XGLb();
					while (!fvwt6WMA4AehyjZtv0x.method_1())
					{
						byte[] array7 = new byte[512];
						int num2 = fvwt6WMA4AehyjZtv0x.tcfdQwFslH(array7);
						if (num2 <= 0)
						{
							break;
						}
						puC0seMtrjr1eq8RIgU.Write(array7, 0, num2);
					}
					long position2 = puC0seMtrjr1eq8RIgU.Position;
					puC0seMtrjr1eq8RIgU.Position = position;
					puC0seMtrjr1eq8RIgU.dpF7jpILEd((int)fvwt6WMA4AehyjZtv0x.method_0());
					puC0seMtrjr1eq8RIgU.Position = position2;
				}
				break;
			}
			case 2:
			{
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(41777787);
				byte[] array3 = HlnuA14bZe(byte_0, 1, null, null);
				using (yWhI73z2LAuciQik9u yWhI73z2LAuciQik9u = new yWhI73z2LAuciQik9u())
				{
					using ICryptoTransform cryptoTransform2 = yWhI73z2LAuciQik9u.a6huMcxQkZ(byte_1, byte_2, bool_0: false);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					puC0seMtrjr1eq8RIgU.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				puC0seMtrjr1eq8RIgU.dpF7jpILEd(58555003);
				byte[] array = HlnuA14bZe(byte_0, 1, null, null);
				using (Ku8swevkBXkJd4SrW2 ku8swevkBXkJd4SrW = new Ku8swevkBXkJd4SrW2())
				{
					using ICryptoTransform cryptoTransform = ku8swevkBXkJd4SrW.U8pYvL3heZ(byte_1, byte_2, bool_0: false);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					puC0seMtrjr1eq8RIgU.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			puC0seMtrjr1eq8RIgU.Flush();
			puC0seMtrjr1eq8RIgU.Close();
			return puC0seMtrjr1eq8RIgU.ToArray();
		}
		catch (Exception ex)
		{
			Vb4uUTvmHL = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	internal static bool dQI9RGoNdSZKofa7gvS()
	{
		return true;
	}

	internal static bool BKXbH1oUf4AIeqBIlpe()
	{
		return false;
	}
}
