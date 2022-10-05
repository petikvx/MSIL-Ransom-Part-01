using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Hb57LptgoTXeni1jy1;
using VRZLoOihYAgUeYYq0tj;
using Yx8dWd5YmPuCncwtgZ;
using bhwnTuiXOFfLOnFMIru;
using chMGEKiS9VxBbyqusDt;

namespace E9WqClkF5flts6jpmr;

internal static class SkkFt8Pwx6X06cFEbh
{
	private enum QHtkkB1X9NtIjjGG8Z
	{

	}

	private sealed class gvRDdvxVxxrD5i4Zml
	{
		private Stream AbvqyHKt0;

		private byte[] YL0KgQVIT;

		internal static gvRDdvxVxxrD5i4Zml SxkTQg626krxuNX2pDI;

		public gvRDdvxVxxrD5i4Zml(Stream stream_0)
		{
			AbvqyHKt0 = stream_0;
			YL0KgQVIT = new byte[4];
		}

		public Stream KoA53PIQ9()
		{
			return AbvqyHKt0;
		}

		public short Ov3rFseaN()
		{
			DrZll7GQw(2);
			return (short)(YL0KgQVIT[0] | (YL0KgQVIT[1] << 8));
		}

		public int f8fZaNKGn()
		{
			DrZll7GQw(4);
			return YL0KgQVIT[0] | (YL0KgQVIT[1] << 8) | (YL0KgQVIT[2] << 16) | (YL0KgQVIT[3] << 24);
		}

		private void Tm2o5H34C()
		{
			throw new EndOfStreamException();
		}

		private void DrZll7GQw(int int_0)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 5;
			while (true)
			{
				IL_00e4:
				int num4;
				if (int_0 == 1)
				{
					num4 = 2;
					if (!j61GR56YFIJB6d3lQid())
					{
						goto IL_0030;
					}
					goto IL_007b;
				}
				goto IL_00aa;
				IL_001b:
				if (num < int_0)
				{
					num4 = 8;
					if (mEwNOV6kig6JQh9Gk6C() != null)
					{
						goto IL_0030;
					}
					goto IL_007b;
				}
				break;
				IL_00aa:
				num2 = Xgsy6f6QoopCWEyUaqf(AbvqyHKt0, YL0KgQVIT, num, int_0 - num);
				num4 = 1;
				if (j61GR56YFIJB6d3lQid())
				{
					goto IL_0060;
				}
				goto IL_007b;
				IL_007b:
				while (true)
				{
					switch (num4)
					{
					case 9:
						break;
					case 6:
						goto IL_001b;
					case 7:
						if (num2 == -1)
						{
							num4 = 0;
							if (j61GR56YFIJB6d3lQid())
							{
								continue;
							}
							goto default;
						}
						goto case 1;
					default:
						Tm2o5H34C();
						num4 = 1;
						if (mEwNOV6kig6JQh9Gk6C() == null)
						{
							continue;
						}
						goto IL_0030;
					case 4:
						goto IL_0060;
					case 2:
						num2 = YR50xZ6l3GpJH073GMI(AbvqyHKt0);
						goto case 7;
					case 8:
						goto IL_00aa;
					case 5:
						goto IL_00e4;
					case 1:
						YL0KgQVIT[0] = (byte)num2;
						return;
					case 3:
						return;
					}
					break;
				}
				goto IL_0014;
				IL_0060:
				if (num2 == 0)
				{
					Tm2o5H34C();
				}
				goto IL_0014;
				IL_0030:
				num4 = num3;
				goto IL_007b;
				IL_0014:
				num += num2;
				goto IL_001b;
			}
		}

		public void a486rsKkq()
		{
			Stream abvqyHKt = AbvqyHKt0;
			AbvqyHKt0 = null;
			int num = 1;
			if (!j61GR56YFIJB6d3lQid())
			{
				goto IL_0032;
			}
			goto IL_004b;
			IL_004b:
			do
			{
				IL_004b_2:
				switch (num)
				{
				case 2:
					break;
				case 1:
					if (abvqyHKt != null)
					{
						num = 2;
						if (mEwNOV6kig6JQh9Gk6C() != null)
						{
							goto IL_004b_2;
						}
						break;
					}
					goto default;
				default:
					YL0KgQVIT = null;
					return;
				}
				g9n3Kw6LKWubaS4xTDI(abvqyHKt);
				num = 0;
			}
			while (mEwNOV6kig6JQh9Gk6C() == null);
			goto IL_0032;
			IL_0032:
			int num2 = default(int);
			num = num2;
			goto IL_004b;
		}

		public byte[] nja0ewdOP(int int_0)
		{
			int num = 2;
			byte[] array = default(byte[]);
			int num3 = default(int);
			byte[] array2 = default(byte[]);
			int num4 = default(int);
			while (true)
			{
				int num2;
				if (int_0 >= 0)
				{
					array = new byte[int_0];
					num2 = 0;
					if (!j61GR56YFIJB6d3lQid())
					{
						goto IL_0073;
					}
				}
				else
				{
					num2 = 1;
					if (!j61GR56YFIJB6d3lQid())
					{
						goto IL_0073;
					}
				}
				goto IL_0078;
				IL_00c9:
				if (num3 == array.Length)
				{
					break;
				}
				array2 = new byte[num3];
				Buffer.BlockCopy(array, 0, array2, 0, num3);
				goto IL_00e7;
				IL_00e7:
				array = array2;
				num = 3;
				break;
				IL_0078:
				switch (num2)
				{
				case 9:
					break;
				case 4:
					goto IL_0039;
				case 5:
				case 6:
					goto IL_005b;
				default:
					goto IL_0073;
				case 2:
					continue;
				case 1:
					throw new ArgumentOutOfRangeException();
				case 8:
				case 10:
					goto IL_00c9;
				case 7:
					goto IL_00e7;
				case 3:
					goto end_IL_00ba;
				}
				goto IL_0025;
				IL_0073:
				num3 = 0;
				goto IL_005b;
				IL_005b:
				num4 = AbvqyHKt0.Read(array, num3, int_0);
				if (num4 != 0)
				{
					goto IL_0025;
				}
				goto IL_00c9;
				IL_0025:
				num3 += num4;
				num2 = 4;
				if (mEwNOV6kig6JQh9Gk6C() == null)
				{
					goto IL_0039;
				}
				goto IL_0078;
				IL_0039:
				int_0 -= num4;
				if (int_0 > 0)
				{
					num2 = 6;
					if (!j61GR56YFIJB6d3lQid())
					{
						num2 = num;
					}
					goto IL_0078;
				}
				goto IL_00c9;
				continue;
				end_IL_00ba:
				break;
			}
			return array;
		}

		internal static bool j61GR56YFIJB6d3lQid()
		{
			return SxkTQg626krxuNX2pDI == null;
		}

		internal static gvRDdvxVxxrD5i4Zml mEwNOV6kig6JQh9Gk6C()
		{
			return SxkTQg626krxuNX2pDI;
		}

		internal static int YR50xZ6l3GpJH073GMI(object object_0)
		{
			return ((Stream)object_0).ReadByte();
		}

		internal static int Xgsy6f6QoopCWEyUaqf(object object_0, object object_1, int int_0, int int_1)
		{
			return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static void g9n3Kw6LKWubaS4xTDI(object object_0)
		{
			((Stream)object_0).Close();
		}
	}

	private static byte[] tEDapc1Lb;

	private static gvRDdvxVxxrD5i4Zml QRCLV6yEM;

	private static QHtkkB1X9NtIjjGG8Z K3VSgkHlg;

	private static int R3UPxO05g;

	private static int gGok0fBEv;

	private static Dictionary<int, string> iUc1Zd3Wx;

	private static byte[] lO9xLhACt;

	private static int mVrgSlJy3;

	private static short cVoMf6bIO;

	private static SkkFt8Pwx6X06cFEbh wbCK3y6w7KWkbZEoRfj;

	static SkkFt8Pwx6X06cFEbh()
	{
		int num = 152786470;
		int num2 = -1516428278;
		iUc1Zd3Wx = new Dictionary<int, string>(58);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
		num3 = 0;
		StackFrame stackFrame = stackTrace.GetFrame(0);
		int int_ = 0;
		if (stackFrame == null)
		{
			stackTrace = new StackTrace();
			int_ = 1;
			stackFrame = (StackFrame)J3aP306ZdoRPqR3ZiCD(stackTrace, 1);
		}
		int num4 = ~(-(~(-(-(~(~(-(~(865725245 + num + num2))))))))) ^ -(~(~(-(~(-(~(-(~(-(~((1374936120 - num) ^ num2)))))))))));
		MethodBase methodBase = (MethodBase)((stackFrame != null) ? PJDjQM672a8dFkWXr7C(stackFrame) : null);
		if (stackFrame != null)
		{
			num4 ^= -(~(-(~(~(-(-(~(~(-(~((0x4EB38DD0 ^ num) + num2)))))))))));
		}
		Type type = (((object)methodBase != null) ? K0ITxp6tqaWuFxZ6n4V(methodBase) : null);
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			K3VSgkHlg = (QHtkkB1X9NtIjjGG8Z)4 | K3VSgkHlg;
			num4 ^= ((num + -1669213945) ^ num2) + num3;
		}
		else if ((object)type == null)
		{
			if (zYcyeO6colHEHHSuGwq(stackTrace, int_))
			{
				num4 ^= ~(-(~(-(-(~(~(-(~(1669190709 - num + num2))))))))) - num3;
				K3VSgkHlg = (QHtkkB1X9NtIjjGG8Z)16 | K3VSgkHlg;
			}
			else
			{
				K3VSgkHlg |= (QHtkkB1X9NtIjjGG8Z)1;
				num4 ^= -(~(-(~(-(~(-(~(~(-(~((num ^ -1400388240) - num2)))))))))));
			}
		}
		else
		{
			num4 ^= -(~(~(-(~(-(-(~(-(~(~(1669190712 - num + num2))))))))))) - num3;
			K3VSgkHlg |= (QHtkkB1X9NtIjjGG8Z)16;
		}
		mVrgSlJy3 += num4;
	}

	internal static string YvvCdqE7y(int int_0)
	{
		Dictionary<int, string> object_ = iUc1Zd3Wx;
		aJj66S6C5uSlpw1hPBv(object_);
		int num = 1;
		if (Rt0xgp6qdViNWI41BJr() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			try
			{
				if (!iUc1Zd3Wx.TryGetValue(int_0, out var value))
				{
					goto IL_0064;
				}
				string result = value;
				int num3 = 1;
				if (Rt0xgp6qdViNWI41BJr() == null)
				{
					goto IL_0051;
				}
				goto IL_007a;
				IL_0051:
				switch (num3)
				{
				case 2:
					break;
				default:
					return result;
				case 0:
					return result;
				case 1:
					return result;
				}
				goto IL_0064;
				IL_0064:
				result = (string)Paq0BY61P4kZ4hGZCim(int_0, bool_0: true);
				num3 = 0;
				if (EmW7at6H2RX6FtkmZEG())
				{
					goto IL_0051;
				}
				goto IL_007a;
				IL_007a:
				int num4 = default(int);
				num3 = num4;
				goto IL_0051;
			}
			finally
			{
				mnr56k6E2Xlh5ot6R5B(object_);
			}
		default:
		{
			string result = default(string);
			return result;
		}
		}
	}

	private static string u3ifrHWxD(int int_0, bool bool_0)
	{
		int num = 62;
		Assembly assembly = default(Assembly);
		Assembly assembly_ = default(Assembly);
		ushort num6 = default(ushort);
		uint num5 = default(uint);
		int num8 = default(int);
		short num9 = default(short);
		byte b = default(byte);
		byte[] array = default(byte[]);
		int num10 = default(int);
		bool flag = default(bool);
		int num17 = default(int);
		int num34 = default(int);
		bool flag4 = default(bool);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num25 = default(int);
		char[] array5 = default(char[]);
		int num24 = default(int);
		int num21 = default(int);
		bool flag2 = default(bool);
		Type type = default(Type);
		StackTrace stackTrace = default(StackTrace);
		int num23 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte b2 = default(byte);
		int num12 = default(int);
		int num20 = default(int);
		Stream manifestResourceStream = default(Stream);
		short num26 = default(short);
		bool flag3 = default(bool);
		int num29 = default(int);
		int c5LQJ9g3k = default(int);
		int num16 = default(int);
		byte b3 = default(byte);
		byte b4 = default(byte);
		int num18 = default(int);
		int num30 = default(int);
		int num32 = default(int);
		int num33 = default(int);
		int num22 = default(int);
		StackFrame stackFrame = default(StackFrame);
		MethodBase methodBase = default(MethodBase);
		AssemblyName object_ = default(AssemblyName);
		byte b5 = default(byte);
		int num7 = default(int);
		long num13 = default(long);
		int num11 = default(int);
		byte[] array8 = default(byte[]);
		char[] array9 = default(char[]);
		while (true)
		{
			int num2 = -1141735895;
			while (true)
			{
				int num3 = -1798762745 ^ num2;
				while (true)
				{
					string value = null;
					num = 9;
					while (true)
					{
						IL_0ef0:
						int num4;
						if (QRCLV6yEM == null)
						{
							assembly = (Assembly)nvAavU6JG85gXyODXRJ();
							assembly_ = (Assembly)juOmHP60EnQ4RkFlq95();
							num4 = 30;
							if (!EmW7at6H2RX6FtkmZEG())
							{
								goto IL_0c1d;
							}
							goto IL_0c21;
						}
						goto IL_0ec1;
						IL_044d:
						num6 = (ushort)(num5 >> 16);
						goto IL_0292;
						IL_0ec1:
						num7 = gGok0fBEv;
						goto IL_0ea6;
						IL_0ea6:
						if (R3UPxO05g != num2 + 1934204607 - num3)
						{
							num8 = int_0 ^ (num2 ^ 0xFDF009F ^ num3) ^ num7;
							num8 ^= 926366717 + num2 + num3;
							goto IL_0e92;
						}
						goto IL_0558;
						IL_00cb:
						num9 = (short)(QRCLV6yEM.Ov3rFseaN() ^ (-349330703 - num2 - num3) ^ num8);
						num4 = 19;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0c21;
						}
						goto IL_0e67;
						IL_0e92:
						Gh6ntN6R9nZvAcq6Wvc(QRCLV6yEM.KoA53PIQ9(), num8);
						goto IL_0e86;
						IL_0e86:
						if (tEDapc1Lb != null)
						{
							goto IL_0bcd;
						}
						goto IL_0e79;
						IL_0e79:
						if (cVoMf6bIO == -1)
						{
							goto IL_00cb;
						}
						goto IL_0e70;
						IL_0e70:
						num9 = cVoMf6bIO;
						goto IL_0e67;
						IL_0e67:
						if (num9 == 0)
						{
							goto IL_0035;
						}
						num4 = 100;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0c1d;
						}
						goto IL_0c21;
						IL_0292:
						b = (byte)num6;
						goto IL_0297;
						IL_0035:
						array = null;
						goto IL_0038;
						IL_0038:
						num10 = liSks8655N8ldCrUxfI(QRCLV6yEM) ^ num8 ^ ~(-(~(-(~(-(-(~(~(-(~((num2 + 299271008) ^ num3))))))))))) ^ num7;
						goto IL_0061;
						IL_0061:
						if (num10 != ((num2 ^ 0x6B36F0F9) | num3))
						{
							goto IL_0075;
						}
						num = 80;
						goto IL_0833;
						IL_0297:
						num6 = (ushort)(num6 >> 8);
						num4 = 20;
						if (!EmW7at6H2RX6FtkmZEG())
						{
							goto IL_0c1d;
						}
						goto IL_0c21;
						IL_0075:
						flag = (num10 & (-1261891833 ^ num2 ^ num3)) != 0;
						num4 = 23;
						if (EmW7at6H2RX6FtkmZEG())
						{
							goto IL_09cb;
						}
						goto IL_0c21;
						IL_0c21:
						while (true)
						{
							object obj;
							switch (num4)
							{
							case 90:
								break;
							case 29:
								goto IL_0038;
							case 97:
								goto IL_0061;
							case 124:
								goto IL_0075;
							case 43:
							case 136:
								assembly_ = assembly;
								num4 = 119;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 114:
							case 135:
								if (num17 < num10)
								{
									num4 = 82;
									if (Rt0xgp6qdViNWI41BJr() == null)
									{
										continue;
									}
									goto IL_00cb;
								}
								goto case 75;
							case 38:
								goto IL_00cb;
							case 75:
								num34 = R3UPxO05g - 12;
								num = 118;
								goto case 118;
							case 118:
								if (flag4)
								{
									goto case 112;
								}
								array6 = array4;
								num25 = num10;
								num4 = 98;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 112:
								num25 = array4[2] | (array4[0] << 16) | (array4[3] << 8) | (array4[1] << 24);
								goto case 79;
							case 79:
								array6 = new byte[num25];
								num4 = 0;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto default;
							default:
								QkmUQDPfC(array4, 4, array6);
								goto case 98;
							case 98:
								if (flag)
								{
									goto case 132;
								}
								goto case 57;
							case 132:
								if (num34 == (-1801353343 ^ num2) - num3)
								{
									goto case 63;
								}
								goto case 57;
							case 63:
								array5 = new char[num25];
								goto case 74;
							case 74:
								num24 = 0;
								num4 = 99;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 57:
								value = ((Encoding)BEFwem6MToHmYanDMb5()).GetString(array6, 0, array6.Length);
								goto case 55;
							case 55:
								num34 += num2 + 349311272 + num3 + (3 & num34) << 5;
								if (num34 != -347699215 - num2 - num3)
								{
									goto case 88;
								}
								goto case 125;
							case 88:
								num21 = (num10 + int_0) ^ ((num2 ^ 0x6B20A763) + num3) ^ (num34 & ((1934161402 + num2) ^ num3));
								num4 = 53;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto case 21;
							case 21:
								flag2 = (object)type == null;
								goto case 22;
							case 22:
								if (flag2)
								{
									if (zYcyeO6colHEHHSuGwq(stackTrace, num23))
									{
										num4 = 62;
										if (Rt0xgp6qdViNWI41BJr() != null)
										{
											continue;
										}
										goto case 131;
									}
									goto case 111;
								}
								goto case 6;
							case 131:
								flag2 = false;
								goto case 6;
							case 111:
								R3UPxO05g ^= (num2 ^ 0x6B35994C) + num3;
								num4 = 110;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto case 46;
							case 46:
							{
								byte[] array7 = array;
								array3 = QRCLV6yEM.nja0ewdOP(num10);
								array2 = array7;
								goto case 36;
							}
							case 36:
								b2 = array2[1];
								goto case 69;
							case 69:
								num12 = array3.Length;
								num4 = 14;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0292;
							case 1:
							case 101:
								goto IL_0292;
							case 8:
								goto IL_0297;
							case 6:
							case 7:
							case 110:
								if (flag2 == (stackTrace != null))
								{
									goto case 86;
								}
								goto case 5;
							case 86:
								R3UPxO05g ^= 32;
								goto case 5;
							case 5:
								R3UPxO05g ^= ((-349313423 - num2) ^ num3) | (num20 + 1);
								QRCLV6yEM = new gvRDdvxVxxrD5i4Zml(manifestResourceStream);
								goto case 130;
							case 130:
								num26 = (short)(QRCLV6yEM.Ov3rFseaN() ^ (short)(~(-(~(-(-(~(~(-(~(1934192033 + num2 - num3)))))))))));
								goto case 49;
							case 49:
								if (num26 == 0)
								{
									goto IL_0317;
								}
								goto case 52;
							case 24:
								goto IL_0317;
							case 52:
								tEDapc1Lb = QRCLV6yEM.nja0ewdOP(num26);
								num4 = 12;
								if (!EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto case 43;
							case 125:
								if (!flag3 && bool_0)
								{
									num4 = 17;
									if (Rt0xgp6qdViNWI41BJr() != null)
									{
										continue;
									}
									goto case 96;
								}
								goto case 83;
							case 96:
								value = (string)ToQcsL6dGkth5QjNkuv(value);
								iUc1Zd3Wx[int_0] = value;
								goto case 12;
							case 12:
								if (xgnZls6iv0HkQ8Oll9i(iUc1Zd3Wx) == 58)
								{
									num4 = 33;
									if (!EmW7at6H2RX6FtkmZEG())
									{
										continue;
									}
									goto case 106;
								}
								goto case 83;
							case 106:
								QRCLV6yEM.a486rsKkq();
								goto case 87;
							case 87:
								QRCLV6yEM = null;
								num4 = 134;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 133:
								num29 = (1934160690 + num2) ^ num3;
								goto case 68;
							case 68:
								c5LQJ9g3k = num16;
								num4 = 127;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 129:
								goto IL_0416;
							case 10:
								goto IL_0431;
							case 102:
								goto IL_044d;
							case 128:
								b3 = b4;
								goto case 64;
							case 64:
								num18++;
								goto IL_0464;
							case 3:
								goto IL_0464;
							case 84:
								goto IL_046a;
							case 127:
							{
								chMGEKiS9VxBbyqusDt.NuJoO3iaJZFFGxC648p<int> nuJoO3iaJZFFGxC648p = ((Yx8dWd5YmPuCncwtgZ.dj1vkPgAbnq1A43dIE<int>)new mvq4yTi7P4O9ZjTZST.esy6M3AS5DXcdCjApB((num2 ^ 0x6B36F0F9) | num3)
								{
									c5LQJ9g3k = c5LQJ9g3k
								}).dGj0rdbQKM();
								try
								{
									while (IMC1PL6fcjdCc5l27Cr(nuJoO3iaJZFFGxC648p))
									{
										int num27 = nuJoO3iaJZFFGxC648p.imethod_3();
										int num28 = 1;
										if (EmW7at6H2RX6FtkmZEG())
										{
											goto IL_04bb;
										}
										goto IL_04e1;
										IL_04bb:
										num16 ^= num27 - num29;
										num29 -= 3 + num16 >> 8;
										num28 = 0;
										if (!EmW7at6H2RX6FtkmZEG())
										{
											num28 = num30;
										}
										goto IL_04e1;
										IL_04e1:
										switch (num28)
										{
										case 1:
											break;
										default:
											continue;
										case 2:
											goto end_IL_04f2;
										}
										goto IL_04bb;
										continue;
										end_IL_04f2:
										break;
									}
								}
								finally
								{
									if (nuJoO3iaJZFFGxC648p != null)
									{
										int num31 = 0;
										if (!EmW7at6H2RX6FtkmZEG())
										{
											num31 = num32;
										}
										switch (num31)
										{
										default:
											nuJoO3iaJZFFGxC648p.Xm60KuQKVT();
											break;
										}
									}
								}
								goto case 47;
							}
							case 47:
								num33 = num16;
								goto case 44;
							case 44:
								num22 = (((-1742724614 - num2) ^ num3) + num33) ^ (-3878346 + num2 - num3);
								num4 = 71;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 122:
								goto IL_0558;
							case 73:
								goto IL_0560;
							case 28:
								goto IL_056f;
							case 121:
								stackTrace = new StackTrace();
								goto case 4;
							case 4:
								num23 = 1;
								goto case 42;
							case 42:
								stackFrame = stackTrace.GetFrame(num23);
								goto case 41;
							case 41:
								methodBase = stackFrame?.GetMethod();
								R3UPxO05g ^= num20 + (num2 ^ -1798762617 ^ num3);
								num4 = 120;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 120:
								if ((object)methodBase != null)
								{
									num4 = 76;
									if (Rt0xgp6qdViNWI41BJr() == null)
									{
										continue;
									}
									goto IL_00cb;
								}
								goto case 31;
							case 31:
								obj = null;
								goto IL_05f6;
							case 119:
								object_ = aANbKyJPF(assembly_);
								goto case 108;
							case 108:
								lO9xLhACt = (byte[])XOQUGF6Gc1UGUPSBvNx(object_);
								num7 = mVrgSlJy3;
								num7 ^= (-464036566 ^ num2) - num3;
								mVrgSlJy3 = 0;
								num4 = 16;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 116:
								stackTrace = new StackTrace(num20, fNeedFileInfo: false);
								num4 = 45;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 25:
							case 115:
								goto IL_0673;
							case 109:
								if (stackFrame == null)
								{
									goto case 103;
								}
								goto case 89;
							case 103:
								R3UPxO05g ^= -1933941330 - num2 + num3;
								num4 = 89;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 89:
								flag2 = (object)type == typeof(RuntimeMethodHandle);
								goto case 54;
							case 54:
								R3UPxO05g ^= num2 + 1934160805 - num3;
								if (!flag2)
								{
									goto case 21;
								}
								num = 7;
								goto case 6;
							case 105:
								array3[num18] = (byte)(b4 ^ b2 ^ (b3 + 3) ^ b);
								goto case 128;
							case 37:
							case 99:
								if (num24 >= num25)
								{
									value = new string(array5);
									goto case 55;
								}
								array5[num24] = (char)array6[num24];
								goto case 91;
							case 91:
								num24 = 1 + num24;
								num4 = 37;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0ec1;
							case 95:
								b5 = (byte)((b5 << 3) | (b5 >> 5));
								goto case 60;
							case 60:
								array4[num17] = (byte)(array4[num17] ^ b5);
								num4 = 51;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 94:
								num7 ^= (-327870228 ^ num2) - num3;
								num4 = 17;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 93:
								gGok0fBEv = num7;
								goto case 58;
							case 58:
								R3UPxO05g = (R3UPxO05g & ((-591983483 - num2) ^ num3)) ^ (num2 + 349317933 + num3);
								num4 = 66;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 92:
								num20 -= 2;
								num4 = 33;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 85:
								if (stackFrame == null)
								{
									num4 = 121;
									if (EmW7at6H2RX6FtkmZEG())
									{
										continue;
									}
									goto case 64;
								}
								goto case 41;
							case 82:
								b5 = lO9xLhACt[num17 & 7];
								goto case 95;
							case 81:
								num23 = num20;
								goto case 85;
							case 80:
								goto IL_0833;
							case 40:
								goto IL_0840;
							case 50:
								goto IL_0852;
							case 78:
								num20 = 2;
								num4 = 74;
								if (!EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto case 116;
							case 76:
								obj = K0ITxp6tqaWuFxZ6n4V(methodBase);
								goto IL_05f6;
							case 71:
								num7 ^= (-1799100875 ^ num2 ^ num3) + ~(-(~(-(-(~(~(-(~(-349311454 - num2 - num3)))))))));
								num7 ^= ~(-(~(-(-(~(~(-(~(num2 + 1590572091 + num3)))))))));
								num7 += num22;
								goto case 93;
							case 70:
								num18 = 0;
								goto IL_0464;
							case 67:
								R3UPxO05g = -1934116683 - num2 + num3;
								num4 = 107;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							case 66:
								if (((uint)K3VSgkHlg & (uint)(-(~(~(-(-(~(-(~(~(-(~((num2 ^ -1798762697) - num3))))))))))))) == 0)
								{
									goto case 67;
								}
								goto IL_0ea6;
							case 53:
							{
								StringBuilder stringBuilder = new StringBuilder();
								int num19 = -349311057 - num2 - num3;
								Mope1x6vfRUAPmcZlZF(stringBuilder, (char)(byte)num19);
								value = num21.ToString((string?)wkLiI069ivhPCMfua1s(stringBuilder));
								goto case 125;
							}
							case 51:
								num17++;
								goto case 114;
							case 45:
								R3UPxO05g ^= (1934167115 + num2 - num3) | num20;
								goto case 92;
							case 39:
								if (lO9xLhACt != null == (R3UPxO05g != ((-350849071 - num2) ^ num3)))
								{
									goto case 75;
								}
								num4 = 19;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 35:
								goto IL_09cb;
							case 33:
								stackFrame = (StackFrame)J3aP306ZdoRPqR3ZiCD(stackTrace, num20);
								goto case 81;
							case 32:
								num10 &= num2 ^ -1690898184 ^ num3;
								num4 = 46;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0c1d;
							case 30:
							{
								R3UPxO05g |= (-350854699 - num2) ^ num3;
								Assembly assembly2 = assembly;
								StringBuilder stringBuilder = new StringBuilder();
								int num19 = (-189534448 ^ num2) - num3;
								((StringBuilder)Mope1x6vfRUAPmcZlZF(stringBuilder, (char)num19)).Append((char)(num19 >> 16));
								num19 = -1396691708 - num2 + num3;
								Mope1x6vfRUAPmcZlZF(Mope1x6vfRUAPmcZlZF(stringBuilder, (char)(num19 >> 16)), (char)num19);
								num19 = (1397281537 + num2) ^ num3;
								((StringBuilder)Mope1x6vfRUAPmcZlZF(stringBuilder, (char)num19)).Append((char)(num19 >> 16));
								num19 = 187567969 - num2 - num3;
								Mope1x6vfRUAPmcZlZF(stringBuilder.Append((char)num19), (char)(num19 >> 16));
								num19 = (num2 ^ 0x6B36D0FA) + num3;
								stringBuilder.Append((char)num19);
								manifestResourceStream = assembly2.GetManifestResourceStream(stringBuilder.ToString());
								num = 78;
								goto case 78;
							}
							case 26:
								num6 = 0;
								goto case 70;
							case 23:
								num7 ^= num2 + 2112213829 + num3;
								goto case 94;
							case 20:
								b4 = array3[num18];
								num4 = 105;
								if (EmW7at6H2RX6FtkmZEG())
								{
									continue;
								}
								goto IL_0852;
							case 19:
								num17 = 0;
								goto case 114;
							case 17:
							{
								int num14 = num7;
								int num15 = num14;
								num16 = ((1934157658 + num2) ^ num3) * num15 % (-1906418968 - num2 + num3);
								goto case 133;
							}
							case 16:
								num13 = oI8Gw1iwafKTVJwRQKW.g8rNAnmot();
								goto case 13;
							case 13:
								num7 ^= (int)num13;
								goto case 23;
							case 14:
								b3 = (byte)((num12 + 11) ^ (b2 + 7));
								num5 = (uint)((array2[0] | (array2[2] << 8)) + (b3 << 3));
								goto case 26;
							case 56:
								goto IL_0bcd;
							case 59:
							case 100:
								array = (byte[])u7S2Zl6yH9kQKOaVA7s(QRCLV6yEM, num9);
								goto case 123;
							case 123:
								num11 = 0;
								goto case 34;
							case 15:
								array[num11] ^= (byte)(gGok0fBEv >> ((num11 & 3) << 3));
								goto case 113;
							case 113:
								num11++;
								goto case 34;
							case 34:
								if (num11 == array.Length)
								{
									goto IL_0038;
								}
								goto case 15;
							case 72:
								goto IL_0e67;
							case 117:
								goto IL_0e70;
							case 126:
								goto IL_0e79;
							case 48:
								goto IL_0e86;
							case 11:
								goto IL_0e92;
							case 107:
								goto IL_0ea6;
							case 2:
								goto IL_0ec1;
							case 9:
							case 65:
								goto IL_0ef0;
							case 27:
								goto end_IL_0ef0;
							case 61:
								goto end_IL_0ef9;
							case 62:
								goto end_IL_0f07;
							case 77:
								goto IL_0f1c;
							case 104:
								goto IL_0f20;
							case 134:
								tEDapc1Lb = null;
								goto case 18;
							case 18:
								lO9xLhACt = null;
								goto case 83;
							case 83:
								{
									return value;
								}
								IL_05f6:
								type = (Type)obj;
								num4 = 109;
								if (Rt0xgp6qdViNWI41BJr() == null)
								{
									continue;
								}
								goto IL_0c1d;
							}
							break;
						}
						goto IL_0035;
						IL_0bcd:
						array = tEDapc1Lb;
						goto IL_0038;
						IL_09cb:
						flag4 = (num10 & (724430679 - num2 - num3)) != 0;
						flag3 = (num10 & (-1798172503 + num2 + num3)) != 0;
						num4 = 32;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0464;
						}
						goto IL_0c21;
						IL_0833:
						array8 = (byte[])u7S2Zl6yH9kQKOaVA7s(QRCLV6yEM, 4);
						goto IL_0840;
						IL_0840:
						int_0 = (num2 + -1873378726 - num3) ^ num7;
						goto IL_0852;
						IL_0852:
						int_0 = (array8[2] | (array8[3] << 16) | (array8[0] << 8) | (array8[1] << 24)) ^ -int_0;
						goto IL_0673;
						IL_0673:
						if (!iUc1Zd3Wx.TryGetValue(int_0, out value))
						{
							num4 = 10;
							if (EmW7at6H2RX6FtkmZEG())
							{
								continue;
							}
							goto IL_0c21;
						}
						goto IL_0f1c;
						IL_0317:
						cVoMf6bIO = (short)(QRCLV6yEM.Ov3rFseaN() ^ (short)(-(~(~(-(-(~(-(~(~((-1934161692 - num2) ^ num3)))))))))));
						num4 = 43;
						if (!EmW7at6H2RX6FtkmZEG())
						{
							goto IL_0c1d;
						}
						goto IL_0c21;
						IL_0f1c:
						return value;
						IL_0558:
						array9 = new char[3];
						goto IL_0560;
						IL_0560:
						array9[0] = (char)((uint)num2 ^ 0x94C90F5Fu ^ (uint)num3);
						goto IL_056f;
						IL_056f:
						array9[1] = '0';
						num4 = 72;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0c21;
						}
						goto IL_0f20;
						IL_0f20:
						array9[2] = (char)(-1934160557 - num2 + num3);
						return new string(array9);
						IL_0464:
						if (num18 < num12)
						{
							goto IL_0416;
						}
						goto IL_046a;
						IL_046a:
						array4 = array3;
						num4 = 39;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0317;
						}
						goto IL_0c21;
						IL_0416:
						if ((num18 & 1) == 0)
						{
							goto IL_0431;
						}
						num4 = 1;
						if (Rt0xgp6qdViNWI41BJr() != null)
						{
							goto IL_0c1d;
						}
						goto IL_0c21;
						IL_0c1d:
						num4 = num;
						goto IL_0c21;
						IL_0431:
						num5 = (uint)((int)num5 * (349525158 + num2 + num3) + ((num2 ^ -1802473000) - num3));
						goto IL_044d;
						continue;
						end_IL_0ef0:
						break;
					}
					continue;
					end_IL_0ef9:
					break;
				}
				continue;
				end_IL_0f07:
				break;
			}
		}
	}

	private static AssemblyName aANbKyJPF(Assembly assembly_0)
	{
		try
		{
			return assembly_0.GetName();
		}
		catch
		{
			AssemblyName assemblyName = new AssemblyName(assembly_0.FullName);
			if (Rt0xgp6qdViNWI41BJr() != null)
			{
				return 0 switch
				{
					_ => assemblyName, 
				};
			}
			return assemblyName;
		}
	}

	private static byte[] zsSv9Esax(AssemblyName assemblyName_0)
	{
		byte[] array = (byte[])S0UGXI6Uwl4GR5bgOpf(assemblyName_0);
		if (array != null)
		{
			int num2 = default(int);
			while (array.Length == 0)
			{
				while (true)
				{
					array = null;
					int num = 0;
					if (!EmW7at6H2RX6FtkmZEG())
					{
						num = num2;
					}
					switch (num)
					{
					case 2:
						break;
					case 1:
						goto end_IL_000e;
					default:
						goto end_IL_0037;
					}
					continue;
					end_IL_000e:
					break;
				}
				continue;
				end_IL_0037:
				break;
			}
		}
		return array;
	}

	private static bool Cod8NlfFM(StackTrace stackTrace_0, int int_0)
	{
		int num = 9;
		Assembly assembly = default(Assembly);
		byte[] array = default(byte[]);
		while (true)
		{
			IL_01a7:
			StackFrame stackFrame = stackTrace_0.GetFrame(++int_0);
			int num2 = 8;
			if (Rt0xgp6qdViNWI41BJr() == null)
			{
				goto IL_0113;
			}
			goto IL_0158;
			IL_0158:
			Type type;
			while (true)
			{
				switch (num2)
				{
				case 17:
					break;
				case 7:
					goto IL_001e;
				case 16:
					goto IL_0049;
				case 12:
					goto IL_0069;
				case 1:
					goto IL_006d;
				case 3:
					goto IL_009e;
				case 4:
					goto IL_00a2;
				case 13:
					goto IL_00df;
				case 5:
					goto IL_00eb;
				case 2:
					goto IL_00f2;
				case 10:
					goto IL_0110;
				case 8:
					goto IL_0113;
				case 6:
					goto IL_0129;
				default:
					goto IL_0155;
				case 9:
					goto IL_01a7;
				case 11:
					return false;
				case 14:
					return true;
				case 15:
					return true;
				}
				break;
				IL_0129:
				MethodBase? method = stackFrame.GetMethod();
				if ((object)method == null)
				{
					goto IL_0110;
				}
				type = K0ITxp6tqaWuFxZ6n4V(method);
				if ((object)type == null)
				{
					num2 = 0;
					if (Rt0xgp6qdViNWI41BJr() == null)
					{
						continue;
					}
					goto IL_00d9;
				}
				goto IL_014e;
			}
			goto IL_000e;
			IL_0155:
			object obj = null;
			goto IL_00e0;
			IL_014e:
			obj = type.Assembly;
			goto IL_00e0;
			IL_0113:
			if (stackFrame == null)
			{
				goto IL_00df;
			}
			num2 = 6;
			if (Rt0xgp6qdViNWI41BJr() != null)
			{
				goto IL_00a2;
			}
			goto IL_0158;
			IL_006d:
			assembly = ((MemberInfo)PJDjQM672a8dFkWXr7C(stackFrame))?.DeclaringType?.Assembly;
			num2 = 1;
			if (Rt0xgp6qdViNWI41BJr() == null)
			{
				goto IL_009e;
			}
			goto IL_0158;
			IL_0110:
			obj = null;
			goto IL_00e0;
			IL_00df:
			obj = null;
			goto IL_00e0;
			IL_00e0:
			assembly = (Assembly)obj;
			num = 5;
			goto IL_00eb;
			IL_00eb:
			if ((object)assembly == null)
			{
				goto IL_0049;
			}
			goto IL_00f2;
			IL_00f2:
			AssemblyName object_ = aANbKyJPF(assembly);
			array = (byte[])XOQUGF6Gc1UGUPSBvNx(object_);
			if (array != null)
			{
				goto IL_000e;
			}
			goto IL_0049;
			IL_000e:
			if (array.Length == 8)
			{
				num = 7;
				goto IL_001e;
			}
			goto IL_0049;
			IL_009e:
			if ((object)assembly == null)
			{
				goto IL_0049;
			}
			goto IL_00a2;
			IL_001e:
			if (array[0] != 183 || array[7] != 137)
			{
				goto IL_0049;
			}
			num2 = 15;
			if (!EmW7at6H2RX6FtkmZEG())
			{
				goto IL_00d9;
			}
			goto IL_0158;
			IL_00a2:
			if ((object)assembly != typeof(SkkFt8Pwx6X06cFEbh).Assembly)
			{
				goto IL_0049;
			}
			num2 = 14;
			if (!EmW7at6H2RX6FtkmZEG())
			{
				goto IL_00d9;
			}
			goto IL_0158;
			IL_00d9:
			num2 = num;
			goto IL_0158;
			IL_0049:
			stackFrame = (StackFrame)J3aP306ZdoRPqR3ZiCD(stackTrace_0, ++int_0);
			num2 = 3;
			if (Rt0xgp6qdViNWI41BJr() == null)
			{
				goto IL_0069;
			}
			goto IL_0158;
			IL_0069:
			if (stackFrame != null)
			{
				goto IL_006d;
			}
			num2 = 11;
			if (!EmW7at6H2RX6FtkmZEG())
			{
				goto IL_00d9;
			}
			goto IL_0158;
		}
	}

	private static void QkmUQDPfC(byte[] byte_0, int int_0, byte[] byte_1)
	{
		int num = 14;
		int num6 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = 0;
			while (true)
			{
				int num3 = 0;
				while (true)
				{
					int num4 = 128;
					int num5 = byte_1.Length;
					while (true)
					{
						if (num2 >= num5)
						{
							return;
						}
						while (true)
						{
							if ((num4 <<= 1) == 256)
							{
								goto IL_0026;
							}
							goto IL_0095;
							IL_0095:
							int num7;
							if ((num3 & num4) != 0)
							{
								num6 = (byte_0[int_0] >> 2) + 3;
								num7 = 0;
								if (!EmW7at6H2RX6FtkmZEG())
								{
									goto IL_0036;
								}
								goto IL_003a;
							}
							goto IL_0100;
							IL_0100:
							byte_1[num2++] = byte_0[int_0++];
							break;
							IL_003a:
							switch (num7)
							{
							case 17:
								break;
							case 1:
								goto IL_0089;
							case 9:
								continue;
							default:
								num8 = ((byte_0[int_0] << 8) | byte_0[int_0 + 1]) & 0x3FF;
								int_0 += 2;
								goto case 6;
							case 6:
								num9 = num2 - num8;
								goto case 11;
							case 11:
								if (num9 >= 0)
								{
									goto case 10;
								}
								return;
							case 12:
								if (num2 >= num5)
								{
									goto end_IL_00a1;
								}
								byte_1[num2++] = byte_1[num9++];
								goto case 10;
							case 10:
							case 16:
								if (--num6 < 0)
								{
									goto end_IL_00a1;
								}
								goto case 12;
							case 2:
								goto IL_0100;
							case 4:
							case 7:
							case 8:
							case 15:
								goto end_IL_00a1;
							case 3:
								goto end_IL_0113;
							case 13:
								goto end_IL_011b;
							case 14:
								goto end_IL_0129;
							case 5:
								return;
							}
							goto IL_0026;
							IL_0089:
							num3 = byte_0[int_0++];
							goto IL_0095;
							IL_0026:
							num4 = 1;
							num7 = 1;
							if (Rt0xgp6qdViNWI41BJr() != null)
							{
								goto IL_0036;
							}
							goto IL_003a;
							IL_0036:
							num7 = num;
							goto IL_003a;
							continue;
							end_IL_00a1:
							break;
						}
						continue;
						end_IL_0113:
						break;
					}
					continue;
					end_IL_011b:
					break;
				}
				continue;
				end_IL_0129:
				break;
			}
		}
	}

	internal static object J3aP306ZdoRPqR3ZiCD(object object_0, int int_0)
	{
		return ((StackTrace)object_0).GetFrame(int_0);
	}

	internal static object PJDjQM672a8dFkWXr7C(object object_0)
	{
		return ((StackFrame)object_0).GetMethod();
	}

	internal static Type K0ITxp6tqaWuFxZ6n4V(object object_0)
	{
		return ((MemberInfo)object_0).DeclaringType;
	}

	internal static bool zYcyeO6colHEHHSuGwq(object object_0, int int_0)
	{
		return Cod8NlfFM((StackTrace)object_0, int_0);
	}

	internal static bool EmW7at6H2RX6FtkmZEG()
	{
		return wbCK3y6w7KWkbZEoRfj == null;
	}

	internal static SkkFt8Pwx6X06cFEbh Rt0xgp6qdViNWI41BJr()
	{
		return wbCK3y6w7KWkbZEoRfj;
	}

	internal static void aJj66S6C5uSlpw1hPBv(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static object Paq0BY61P4kZ4hGZCim(int int_0, bool bool_0)
	{
		return u3ifrHWxD(int_0, bool_0);
	}

	internal static void mnr56k6E2Xlh5ot6R5B(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static object nvAavU6JG85gXyODXRJ()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object juOmHP60EnQ4RkFlq95()
	{
		return Assembly.GetCallingAssembly();
	}

	internal static object Mope1x6vfRUAPmcZlZF(object object_0, char char_0)
	{
		return ((StringBuilder)object_0).Append(char_0);
	}

	internal static object XOQUGF6Gc1UGUPSBvNx(object object_0)
	{
		return zsSv9Esax((AssemblyName)object_0);
	}

	internal static bool IMC1PL6fcjdCc5l27Cr(object object_0)
	{
		return ((f14BwriGhFijfyY895M)object_0).imethod_0();
	}

	internal static void Gh6ntN6R9nZvAcq6Wvc(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static object u7S2Zl6yH9kQKOaVA7s(object object_0, int int_0)
	{
		return ((gvRDdvxVxxrD5i4Zml)object_0).nja0ewdOP(int_0);
	}

	internal static int liSks8655N8ldCrUxfI(object object_0)
	{
		return ((gvRDdvxVxxrD5i4Zml)object_0).f8fZaNKGn();
	}

	internal static object BEFwem6MToHmYanDMb5()
	{
		return Encoding.Unicode;
	}

	internal static object wkLiI069ivhPCMfua1s(object object_0)
	{
		return ((StringBuilder)object_0).ToString();
	}

	internal static object ToQcsL6dGkth5QjNkuv(object object_0)
	{
		return string.Intern((string)object_0);
	}

	internal static int xgnZls6iv0HkQ8Oll9i(object object_0)
	{
		return ((Dictionary<int, string>)object_0).Count;
	}

	internal static object S0UGXI6Uwl4GR5bgOpf(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}
}
