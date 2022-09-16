using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using CywHuCRSJ9Nc0dmtm00;
using FieDyIYvBAAQ2RL6nq;
using Hk5mQDzNwF2uhvmw1b;
using KO6NaAb4Qh1B7KtU6P;
using SRo1MyRyNCF0HMnMeRy;
using YWVhRKsR8Vq8J5QWrp;
using fpQR03J5sc7Q22Xtvi;
using mqTn2KRuHaeVC7qZfAP;
using v6Nf27OCZWJ1AwbvJ3;

namespace ACOVXNuRhOUrWxigRt;

internal class ajyaamTDLVqY4QEdvS
{
	private static readonly object rbIRhOHwFM;

	private static readonly int tJdRkNyEWG;

	private static readonly int ta4RiZXErS;

	private static readonly MemoryStream ForRyWxMGI;

	private static readonly MemoryStream VWmRef0kJm;

	private static readonly byte RHWR46JIrf;

	internal static ajyaamTDLVqY4QEdvS rxWRwVhRKR;

	static ajyaamTDLVqY4QEdvS()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		DxhRThLDWA();
		ForRyWxMGI = VWmf0k6Jm7HW6JIrfT.JmcF8EQOC8;
		VWmRef0kJm = VWmf0k6Jm7HW6JIrfT.JmcF8EQOC8;
		tJdRkNyEWG = int.MaxValue;
		ta4RiZXErS = int.MinValue;
		ForRyWxMGI = new MemoryStream(0);
		VWmRef0kJm = new MemoryStream(0);
		rbIRhOHwFM = new object();
	}

	public ajyaamTDLVqY4QEdvS()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		base._002Ector();
	}

	private static string YueRq7pJPF(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		int num2 = 1;
		if (n9ORDvIOIR() != null)
		{
			goto IL_0020;
		}
		goto IL_003d;
		IL_003d:
		switch (num2)
		{
		case 1:
			break;
		default:
			goto IL_004d;
		}
		goto IL_0020;
		IL_0020:
		if (num >= 0)
		{
			text = text.Substring(0, num);
			num2 = 0;
			if (n9ORDvIOIR() == null)
			{
				goto IL_003d;
			}
		}
		goto IL_004d;
		IL_004d:
		return text;
	}

	private static byte[] t6ORS68bSu(Assembly assembly_0)
	{
		try
		{
			string fullName = assembly_0.FullName;
			int num = fullName.IndexOf(oxfevuxb8f51pPM8uj.ADIaRIoIY4(56));
			if (num < 0)
			{
				goto IL_0051;
			}
			goto IL_00d9;
			IL_00d9:
			if (num >= 0)
			{
				goto IL_00c0;
			}
			int num2 = 6;
			goto IL_0100;
			IL_0051:
			num = gBER0Xe2O2(fullName, SEqREHl231(90));
			int num3 = 1;
			if (!YNnRukPcym())
			{
				goto IL_0071;
			}
			goto IL_008b;
			IL_00c0:
			num += 15;
			if (fullName[num] != 'n')
			{
				num2 = 5;
				goto IL_00ae;
			}
			goto IL_0109;
			IL_0071:
			string s = default(string);
			long value = long.Parse(s, NumberStyles.HexNumber);
			num3 = 2;
			if (!YNnRukPcym())
			{
				goto IL_008b;
			}
			goto IL_00ea;
			IL_00ae:
			if (fullName[num] != 'N')
			{
				s = fullName.Substring(num, 16);
				num3 = 0;
				if (!YNnRukPcym())
				{
					num3 = num2;
				}
				goto IL_008b;
			}
			goto IL_0109;
			IL_00ea:
			byte[] bytes = BitConverter.GetBytes(value);
			Array.Reverse((Array)bytes);
			return bytes;
			IL_0109:
			return TS8A8ejYQdH6yKw4Hx.kXdFce3E44;
			IL_008b:
			switch (num3)
			{
			case 3:
				break;
			default:
				goto IL_0071;
			case 5:
				goto IL_00ae;
			case 4:
				goto IL_00c0;
			case 1:
				goto IL_00d9;
			case 2:
				goto IL_00ea;
			case 6:
				goto IL_0100;
			}
			goto IL_0051;
			IL_0100:
			return TS8A8ejYQdH6yKw4Hx.kXdFce3E44;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] O9eRr9KwO0(Stream stream_0)
	{
		lock (rbIRhOHwFM)
		{
			return BFXRIjeE2L(97L, stream_0);
		}
	}

	internal static byte[] ilvRtPhKkE(long long_0, Stream stream_0)
	{
		try
		{
			return O9eRr9KwO0(stream_0);
		}
		catch
		{
			return (byte[])GWuRLMNwHU(97L, stream_0);
		}
	}

	internal static byte[] BFXRIjeE2L(long long_0, object object_0)
	{
		Stream stream = (Stream)EtLRAAkIv5(object_0);
		Stream stream2 = stream;
		int num = 13;
		if (n9ORDvIOIR() != null)
		{
			goto IL_0346;
		}
		goto IL_037c;
		IL_037c:
		int num5 = default(int);
		byte[] array = default(byte[]);
		byte[] array5 = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		byte[] array6 = default(byte[]);
		int num4 = default(int);
		int inputBlockSize = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array4 = default(byte[]);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		ushort num7 = default(ushort);
		int num2 = default(int);
		int num3 = default(int);
		byte[] array8 = default(byte[]);
		DeflateStream deflateStream = default(DeflateStream);
		while (true)
		{
			switch (num)
			{
			case 28:
				if (tJdRkNyEWG == int.MaxValue)
				{
					ForRyWxMGI.Capacity = (int)stream.Length;
				}
				else
				{
					ForRyWxMGI.Capacity = tJdRkNyEWG;
				}
				goto IL_0050;
			case 26:
				num5 = 1000;
				array = (byte[])y27RPCZWJ1(1000);
				goto IL_00b4;
			case 25:
				array5 = sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ(cryptoTransform.OutputBlockSize);
				goto case 24;
			case 24:
				array6 = sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ(KDoRX9VwoS(cryptoTransform));
				goto case 6;
			case 6:
				num4 = (int)Ql4RGHJZ4I(stream);
				goto case 23;
			case 16:
			{
				stream.Read(array6, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array6, 0, inputBlockSize, array5, 0);
				ForRyWxMGI.Write(array5, 0, count);
				goto case 19;
			}
			case 19:
				num4 += inputBlockSize;
				num = 5;
				if (!YNnRukPcym())
				{
					continue;
				}
				goto case 23;
			case 23:
			{
				if (num4 + inputBlockSize < uoGR8wY06N(stream))
				{
					goto case 16;
				}
				stream.Read(array6, 0, (int)(stream.Length - num4));
				byte[] array7 = cryptoTransform.TransformFinalBlock(array6, 0, (int)(uoGR8wY06N(stream) - num4));
				ForRyWxMGI.Write(array7, 0, (int)(nuint)gwoSslp4HJZ4I0oGwY.Dc1FXrLfjM(array7));
				stream2 = ForRyWxMGI;
				stream2.Position = 0L;
				memoryStream = ForRyWxMGI;
				goto IL_01b6;
			}
			case 22:
				L55R2GckFi(stream, array4, 0, 8);
				goto case 17;
			case 17:
				dESCryptoServiceProvider.IV = array4;
				num6 = 3;
				goto case 3;
			case 3:
				array3 = sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ(8);
				L55R2GckFi(stream, array3, 0, 8);
				flag = true;
				array2 = array3;
				num = 0;
				if (YNnRukPcym())
				{
					continue;
				}
				goto IL_008d;
			case 21:
				num = 1;
				if (n9ORDvIOIR() != null)
				{
					continue;
				}
				goto case 9;
			case 9:
			case 11:
				num7 = (ushort)stream.ReadByte();
				num7 = (ushort)(~num7);
				if ((num7 & 2) == 0)
				{
					goto IL_01b6;
				}
				dESCryptoServiceProvider = new DESCryptoServiceProvider();
				goto case 8;
			case 8:
				array4 = sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ(8);
				num = 22;
				if (YNnRukPcym())
				{
					continue;
				}
				goto IL_008d;
			case 15:
				num2++;
				goto IL_02b4;
			case 10:
			case 14:
				if (flag)
				{
					num6 = 12;
					goto case 12;
				}
				goto IL_02ec;
			case 12:
				array3 = (byte[])dmwR1nt877(CfpRfaRNKT());
				goto IL_02ec;
			case 5:
				if (ForRyWxMGI == null)
				{
					goto case 28;
				}
				goto IL_0050;
			case 2:
				flag = false;
				num = 10;
				if (YNnRukPcym())
				{
					continue;
				}
				goto case 8;
			case 13:
				break;
			case 4:
				goto IL_0335;
			case 7:
				goto IL_0346;
			case 1:
				wwbRcvJ3aO(VWmRef0kJm, array, 0, num3);
				goto IL_00ab;
			default:
				num2 = 0;
				goto IL_02b4;
			case 18:
				memoryStream = VWmRef0kJm;
				goto IL_0401;
			case 20:
				stream.Read(array8, 0, (int)(nuint)gwoSslp4HJZ4I0oGwY.Dc1FXrLfjM(array8));
				return array8;
			case 27:
				{
					return memoryStream.ToArray();
				}
				IL_02b4:
				if (num2 >= (int)(nuint)gwoSslp4HJZ4I0oGwY.Dc1FXrLfjM(array2))
				{
					goto case 10;
				}
				if (array2[num2] == 0)
				{
					goto case 15;
				}
				num = 2;
				if (n9ORDvIOIR() != null)
				{
					continue;
				}
				goto case 2;
				IL_00b4:
				num3 = deflateStream.Read(array, 0, num5);
				if (num3 > 0)
				{
					num = 1;
					if (n9ORDvIOIR() == null)
					{
						continue;
					}
					goto IL_008d;
				}
				goto IL_00ab;
				IL_02ec:
				dESCryptoServiceProvider.Key = array3;
				goto case 5;
				IL_00ab:
				if (num3 >= num5)
				{
					goto IL_00b4;
				}
				goto case 18;
				IL_01b6:
				if ((num7 & 8u) != 0)
				{
					if (VWmRef0kJm == null)
					{
						if (ta4RiZXErS == int.MinValue)
						{
							VWmRef0kJm.Capacity = (int)stream2.Length * 2;
						}
						else
						{
							VWmRef0kJm.Capacity = ta4RiZXErS;
						}
					}
					VWmRef0kJm.Position = 0L;
					deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
					goto case 26;
				}
				goto IL_0401;
				IL_0050:
				p94R36xiaE(ForRyWxMGI, 0L);
				cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				num = 25;
				if (YNnRukPcym())
				{
					continue;
				}
				goto IL_008d;
				IL_0401:
				if (memoryStream == null)
				{
					array8 = sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ((int)checked((nint)unchecked(stream.Length - Ql4RGHJZ4I(stream))));
					goto case 20;
				}
				goto case 27;
			}
			break;
		}
		memoryStream = VWmf0k6Jm7HW6JIrfT.JmcF8EQOC8;
		int num8 = 1;
		goto IL_0330;
		IL_0346:
		num8++;
		goto IL_0330;
		IL_0330:
		if (num8 < 4)
		{
			goto IL_0335;
		}
		num = 9;
		if (n9ORDvIOIR() != null)
		{
			goto IL_008d;
		}
		goto IL_037c;
		IL_008d:
		num = num6;
		goto IL_037c;
		IL_0335:
		stream.ReadByte();
		num6 = 7;
		goto IL_0346;
	}

	internal static void DxhRThLDWA()
	{
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
	}

	internal static bool YNnRukPcym()
	{
		return rxWRwVhRKR == null;
	}

	internal static ajyaamTDLVqY4QEdvS n9ORDvIOIR()
	{
		return rxWRwVhRKR;
	}

	internal static object SEqREHl231(int int_0)
	{
		return oxfevuxb8f51pPM8uj.ADIaRIoIY4(int_0);
	}

	internal static int gBER0Xe2O2(object object_0, object object_1)
	{
		return ((string)object_0).IndexOf((string)object_1);
	}

	internal static object GWuRLMNwHU(long long_0, object object_0)
	{
		return BFXRIjeE2L(long_0, object_0);
	}

	internal static object EtLRAAkIv5(object object_0)
	{
		return LR0g5Ao9mgyWXwonQ3.aDLFhUMHJ1(object_0);
	}

	internal static int L55R2GckFi(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object CfpRfaRNKT()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object dmwR1nt877(object object_0)
	{
		return t6ORS68bSu((Assembly)object_0);
	}

	internal static void p94R36xiaE(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static int KDoRX9VwoS(object object_0)
	{
		return ((ICryptoTransform)object_0).InputBlockSize;
	}

	internal static long Ql4RGHJZ4I(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static long uoGR8wY06N(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object y27RPCZWJ1(int int_0)
	{
		return sZKQDO7XmPL5Ok6iZR.L5aFPkucsZ(int_0);
	}

	internal static void wwbRcvJ3aO(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}
}
