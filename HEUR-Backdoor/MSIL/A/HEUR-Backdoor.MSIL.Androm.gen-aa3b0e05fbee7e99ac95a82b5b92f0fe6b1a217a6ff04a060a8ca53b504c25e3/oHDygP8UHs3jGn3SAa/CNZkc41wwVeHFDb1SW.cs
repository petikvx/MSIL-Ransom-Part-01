using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using B8a4sdh0sLI4RjtGdC;
using EhdA9I4ntZdCXaNotex;
using F1SaJPCRBc44bki9gQ;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using T7eunHzmke0yeryayX;
using ak0qdeo99dgZVDnXPK;
using qMQcVeHXkHfWBuhbcf;
using zePRmk5xC0EA78jVWF;

namespace oHDygP8UHs3jGn3SAa;

internal class CNZkc41wwVeHFDb1SW
{
	private static readonly object sHW4gWlJR8;

	private static readonly int Crh4KoNeFe;

	private static readonly int FJu4RISY42;

	private static readonly MemoryStream itc46mltot;

	private static readonly MemoryStream HYH49kGgU9;

	private static readonly byte ghK4rSdXJr;

	internal static CNZkc41wwVeHFDb1SW cjM4tQcVeX;

	static CNZkc41wwVeHFDb1SW()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		H8Z41gUK3I();
		itc46mltot = HYHkGgLU9VhKSdXJrJ.o2lJbidVQ8;
		HYH49kGgU9 = HYHkGgLU9VhKSdXJrJ.o2lJbidVQ8;
		Crh4KoNeFe = int.MaxValue;
		FJu4RISY42 = int.MinValue;
		itc46mltot = new MemoryStream(0);
		HYH49kGgU9 = new MemoryStream(0);
		sHW4gWlJR8 = new object();
	}

	public CNZkc41wwVeHFDb1SW()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		base._002Ector();
	}

	private static string foI4i4PQlB(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		int num2 = 1;
		if (kd54k5kZq4() != null)
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
			if (kd54k5kZq4() == null)
			{
				goto IL_003d;
			}
		}
		goto IL_004d;
		IL_004d:
		return text;
	}

	private static byte[] Iju4nG75aa(Assembly assembly_0)
	{
		try
		{
			string fullName = assembly_0.FullName;
			int num = fullName.IndexOf(sD2Wk4DskFhChtylq3.vXpe4HnnoY(56));
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
			num = yfK4x4dK8G(fullName, Omv4UWN6Ye(90));
			int num3 = 1;
			if (!NGf48rv3mS())
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
			if (!NGf48rv3mS())
			{
				goto IL_008b;
			}
			goto IL_00ea;
			IL_00ae:
			if (fullName[num] != 'N')
			{
				s = fullName.Substring(num, 16);
				num3 = 0;
				if (!NGf48rv3mS())
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
			return A298DkXyP9eOXGyIFk.tkgJQv7bXc;
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
			return A298DkXyP9eOXGyIFk.tkgJQv7bXc;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] ISR4qshJYV(Stream stream_0)
	{
		lock (sHW4gWlJR8)
		{
			return Woh4w0BS1C(97L, stream_0);
		}
	}

	internal static byte[] NIU4jCRtQE(long long_0, Stream stream_0)
	{
		try
		{
			return ISR4qshJYV(stream_0);
		}
		catch
		{
			return (byte[])C4n4ZPwHtf(97L, stream_0);
		}
	}

	internal static byte[] Woh4w0BS1C(long long_0, object object_0)
	{
		Stream stream = (Stream)UdH4F7uGRH(object_0);
		Stream stream2 = stream;
		int num = 13;
		if (kd54k5kZq4() != null)
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
				if (Crh4KoNeFe == int.MaxValue)
				{
					itc46mltot.Capacity = (int)stream.Length;
				}
				else
				{
					itc46mltot.Capacity = Crh4KoNeFe;
				}
				goto IL_0050;
			case 26:
				num5 = 1000;
				array = (byte[])bsd4A0sLI4(1000);
				goto IL_00b4;
			case 25:
				array5 = vh9qcIfnyaOGhbJs2Z.RsdJA0GleH(cryptoTransform.OutputBlockSize);
				goto case 24;
			case 24:
				array6 = vh9qcIfnyaOGhbJs2Z.RsdJA0GleH(qkD4MQ8Y1u(cryptoTransform));
				goto case 6;
			case 6:
				num4 = (int)QXU4EsnkJo(stream);
				goto case 23;
			case 16:
			{
				stream.Read(array6, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array6, 0, inputBlockSize, array5, 0);
				itc46mltot.Write(array5, 0, count);
				goto case 19;
			}
			case 19:
				num4 += inputBlockSize;
				num = 5;
				if (!NGf48rv3mS())
				{
					continue;
				}
				goto case 23;
			case 23:
			{
				if (num4 + inputBlockSize < wUS4bZIM8a(stream))
				{
					goto case 16;
				}
				stream.Read(array6, 0, (int)(stream.Length - num4));
				byte[] array7 = cryptoTransform.TransformFinalBlock(array6, 0, (int)(wUS4bZIM8a(stream) - num4));
				itc46mltot.Write(array7, 0, (int)(nuint)sY1uHXPUsnkJoZUSZI.BY1JM8NERt(array7));
				stream2 = itc46mltot;
				stream2.Position = 0L;
				memoryStream = itc46mltot;
				goto IL_01b6;
			}
			case 22:
				YhK4BL7BOL(stream, array4, 0, 8);
				goto case 17;
			case 17:
				dESCryptoServiceProvider.IV = array4;
				num6 = 3;
				goto case 3;
			case 3:
				array3 = vh9qcIfnyaOGhbJs2Z.RsdJA0GleH(8);
				YhK4BL7BOL(stream, array3, 0, 8);
				flag = true;
				array2 = array3;
				num = 0;
				if (NGf48rv3mS())
				{
					continue;
				}
				goto IL_008d;
			case 21:
				num = 1;
				if (kd54k5kZq4() != null)
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
				array4 = vh9qcIfnyaOGhbJs2Z.RsdJA0GleH(8);
				num = 22;
				if (NGf48rv3mS())
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
				array3 = (byte[])Rci4GOciah(T354OGUvEX());
				goto IL_02ec;
			case 5:
				if (itc46mltot == null)
				{
					goto case 28;
				}
				goto IL_0050;
			case 2:
				flag = false;
				num = 10;
				if (NGf48rv3mS())
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
				Hjt4QGdCkB(HYH49kGgU9, array, 0, num3);
				goto IL_00ab;
			default:
				num2 = 0;
				goto IL_02b4;
			case 18:
				memoryStream = HYH49kGgU9;
				goto IL_0401;
			case 20:
				stream.Read(array8, 0, (int)(nuint)sY1uHXPUsnkJoZUSZI.BY1JM8NERt(array8));
				return array8;
			case 27:
				{
					return memoryStream.ToArray();
				}
				IL_02b4:
				if (num2 >= (int)(nuint)sY1uHXPUsnkJoZUSZI.BY1JM8NERt(array2))
				{
					goto case 10;
				}
				if (array2[num2] == 0)
				{
					goto case 15;
				}
				num = 2;
				if (kd54k5kZq4() != null)
				{
					continue;
				}
				goto case 2;
				IL_00b4:
				num3 = deflateStream.Read(array, 0, num5);
				if (num3 > 0)
				{
					num = 1;
					if (kd54k5kZq4() == null)
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
					if (HYH49kGgU9 == null)
					{
						if (FJu4RISY42 == int.MinValue)
						{
							HYH49kGgU9.Capacity = (int)stream2.Length * 2;
						}
						else
						{
							HYH49kGgU9.Capacity = FJu4RISY42;
						}
					}
					HYH49kGgU9.Position = 0L;
					deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
					goto case 26;
				}
				goto IL_0401;
				IL_0050:
				Am04TOefib(itc46mltot, 0L);
				cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				num = 25;
				if (NGf48rv3mS())
				{
					continue;
				}
				goto IL_008d;
				IL_0401:
				if (memoryStream == null)
				{
					array8 = vh9qcIfnyaOGhbJs2Z.RsdJA0GleH((int)checked((nint)unchecked(stream.Length - QXU4EsnkJo(stream))));
					goto case 20;
				}
				goto case 27;
			}
			break;
		}
		memoryStream = HYHkGgLU9VhKSdXJrJ.o2lJbidVQ8;
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
		if (kd54k5kZq4() != null)
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

	internal static void H8Z41gUK3I()
	{
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
	}

	internal static bool NGf48rv3mS()
	{
		return cjM4tQcVeX == null;
	}

	internal static CNZkc41wwVeHFDb1SW kd54k5kZq4()
	{
		return cjM4tQcVeX;
	}

	internal static object Omv4UWN6Ye(int int_0)
	{
		return sD2Wk4DskFhChtylq3.vXpe4HnnoY(int_0);
	}

	internal static int yfK4x4dK8G(object object_0, object object_1)
	{
		return ((string)object_0).IndexOf((string)object_1);
	}

	internal static object C4n4ZPwHtf(long long_0, object object_0)
	{
		return Woh4w0BS1C(long_0, object_0);
	}

	internal static object UdH4F7uGRH(object object_0)
	{
		return PiBqdVIvB0XKeZaUwW.UcEJgwsV0S(object_0);
	}

	internal static int YhK4BL7BOL(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static object T354OGUvEX()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object Rci4GOciah(object object_0)
	{
		return Iju4nG75aa((Assembly)object_0);
	}

	internal static void Am04TOefib(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static int qkD4MQ8Y1u(object object_0)
	{
		return ((ICryptoTransform)object_0).InputBlockSize;
	}

	internal static long QXU4EsnkJo(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static long wUS4bZIM8a(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object bsd4A0sLI4(int int_0)
	{
		return vh9qcIfnyaOGhbJs2Z.RsdJA0GleH(int_0);
	}

	internal static void Hjt4QGdCkB(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}
}
