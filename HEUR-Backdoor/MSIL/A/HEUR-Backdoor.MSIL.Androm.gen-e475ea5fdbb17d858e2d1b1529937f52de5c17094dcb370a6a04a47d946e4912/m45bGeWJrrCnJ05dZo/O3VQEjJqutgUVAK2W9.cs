using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using KtA0r3gEdKFWUcPWC3;
using MINtA4ayoVqQZ0VprF;
using OyfHrs96YBnkeHQJdZ;
using Pj91rV27dKBAsuQFb5U;
using Uec0JMb7n52kpI42Mp;
using WEVFYJ2WPuik8y16vgG;
using Wfvgghw2YyREWGElPq;
using piO3af2M2LrtQb05a7e;
using wTupX4rMVhdmxdCq3d;

namespace m45bGeWJrrCnJ05dZo;

internal class O3VQEjJqutgUVAK2W9
{
	private static readonly object EV52nmb4f8;

	private static readonly int hpc2yDvP9N;

	private static readonly int UwI23NtA4y;

	private static readonly MemoryStream eVq2UQZ0Vp;

	private static readonly MemoryStream TFa2KTk9HV;

	private static readonly byte K4F2NrjXv7;

	private static O3VQEjJqutgUVAK2W9 G0Y2OfSrPy;

	static O3VQEjJqutgUVAK2W9()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		eVq2UQZ0Vp = EV5mb4Hf8EpcDvP9NX.SyeIPLGJqB;
		TFa2KTk9HV = EV5mb4Hf8EpcDvP9NX.SyeIPLGJqB;
		hpc2yDvP9N = int.MaxValue;
		UwI23NtA4y = int.MinValue;
		eVq2UQZ0Vp = new MemoryStream(0);
		TFa2KTk9HV = new MemoryStream(0);
		EV52nmb4f8 = new object();
	}

	public O3VQEjJqutgUVAK2W9()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		base._002Ector();
	}

	private static string An02fg2pRU(Assembly assembly_0)
	{
		string text = (string)v0i2mvxMVj(assembly_0);
		int num = text.IndexOf(',');
		int num2;
		if (num >= 0)
		{
			num2 = 0;
			if (lUR2EneZrq() != null)
			{
				goto IL_0025;
			}
			goto IL_0031;
		}
		goto IL_004d;
		IL_004d:
		return text;
		IL_0031:
		switch (num2)
		{
		case 1:
			goto IL_0041;
		}
		goto IL_0025;
		IL_0025:
		num2 = 1;
		if (!rWv2pj4FU4())
		{
			goto IL_0031;
		}
		goto IL_0041;
		IL_0041:
		text = text.Substring(0, num);
		goto IL_004d;
	}

	private static byte[] iSt2T7QCeS(Assembly assembly_0)
	{
		try
		{
			string fullName = assembly_0.FullName;
			int num = 1;
			if (!rWv2pj4FU4())
			{
				goto IL_0091;
			}
			goto IL_00b7;
			IL_00b7:
			int num2 = default(int);
			long value = default(long);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					num2 = Q2w28uVZRa(fullName, msD26dSkHy(106));
					goto IL_002e;
				default:
					num2 += 15;
					if (fullName[num2] != 'n')
					{
						break;
					}
					goto case 6;
				case 1:
					num2 = Q2w28uVZRa(fullName, A2IykMCm48qOE9ZWAc.VCEIRVFYJP(72));
					if (num2 < 0)
					{
						goto case 4;
					}
					goto IL_002e;
				case 2:
				{
					byte[] bytes = BitConverter.GetBytes(value);
					Array.Reverse((Array)bytes);
					return bytes;
				}
				case 3:
					return OMiM3pRvNhBFH15mY7.ekrIjTpEPR;
				case 6:
					{
						return OMiM3pRvNhBFH15mY7.ekrIjTpEPR;
					}
					IL_002e:
					if (num2 >= 0)
					{
						goto default;
					}
					num3 = 3;
					goto case 3;
				}
				if (fullName[num2] == 'N')
				{
					num = 6;
					if (lUR2EneZrq() != null)
					{
						break;
					}
					continue;
				}
				string s = fullName.Substring(num2, 16);
				value = long.Parse(s, NumberStyles.HexNumber);
				num = 2;
				if (!rWv2pj4FU4())
				{
					break;
				}
			}
			goto IL_0091;
			IL_0091:
			num = num3;
			goto IL_00b7;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] qrZ2ojRiEI(Stream stream_0)
	{
		lock (EV52nmb4f8)
		{
			return is82YLjbV7(97L, stream_0);
		}
	}

	internal static byte[] GMZ2q5hytC(long long_0, Stream stream_0)
	{
		try
		{
			return qrZ2ojRiEI(stream_0);
		}
		catch
		{
			return is82YLjbV7(97L, stream_0);
		}
	}

	internal static byte[] is82YLjbV7(long long_0, object object_0)
	{
		Stream stream = (Stream)cuj2DUNJb4(object_0);
		Stream stream2 = stream;
		int num2 = default(int);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		byte[] array = default(byte[]);
		byte[] array8 = default(byte[]);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		int num8 = default(int);
		int inputBlockSize = default(int);
		byte[] array7 = default(byte[]);
		byte[] array5 = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		byte[] array4 = default(byte[]);
		while (true)
		{
			MemoryStream memoryStream = EV5mb4Hf8EpcDvP9NX.SyeIPLGJqB;
			int num = 1;
			while (true)
			{
				if (num < 4)
				{
					JcH24lVwTO(stream);
					num2 = 7;
				}
				else
				{
					while (true)
					{
						IL_03dc:
						ushort num3 = (ushort)stream.ReadByte();
						num3 = (ushort)(~num3);
						int num4 = 6;
						if (lUR2EneZrq() != null)
						{
							goto IL_01e4;
						}
						goto IL_035e;
						IL_035e:
						while (true)
						{
							switch (num4)
							{
							case 7:
								break;
							case 28:
								G062sAUn8F(dESCryptoServiceProvider, array);
								if (eVq2UQZ0Vp == null)
								{
									if (hpc2yDvP9N == int.MaxValue)
									{
										num4 = 26;
										if (rWv2pj4FU4())
										{
											continue;
										}
										goto IL_01e4;
									}
									IIk2PEfvYY(eVq2UQZ0Vp, hpc2yDvP9N);
								}
								goto IL_006d;
							case 2:
								array8 = zE5IxecW1OHLF0xx97.ocNIJsOF66(cryptoTransform.InputBlockSize);
								num8 = (int)stream.Position;
								goto IL_00c0;
							case 9:
							case 16:
							{
								stream.Read(array8, 0, inputBlockSize);
								int count = cryptoTransform.TransformBlock(array8, 0, inputBlockSize, array7, 0);
								eVq2UQZ0Vp.Write(array7, 0, count);
								num4 = 1;
								if (!rWv2pj4FU4())
								{
									continue;
								}
								goto case 11;
							}
							case 11:
								num8 += inputBlockSize;
								goto IL_00c0;
							case 20:
								xBC2jJArdN(eVq2UQZ0Vp, array5, 0, (int)(nuint)qyS2W0IqAE(array5));
								stream2 = eVq2UQZ0Vp;
								stream2.Position = 0L;
								memoryStream = eVq2UQZ0Vp;
								goto IL_0177;
							case 8:
								if (TFa2KTk9HV == null)
								{
									if (UwI23NtA4y == int.MinValue)
									{
										goto case 14;
									}
									goto case 3;
								}
								goto case 18;
							case 14:
								TFa2KTk9HV.Capacity = (int)stream2.Length * 2;
								goto case 18;
							case 3:
								TFa2KTk9HV.Capacity = UwI23NtA4y;
								goto case 18;
							case 18:
								HMf2vY5OEE(TFa2KTk9HV, 0L);
								num4 = 15;
								if (lUR2EneZrq() == null)
								{
									continue;
								}
								goto IL_01e4;
							case 27:
								num4 = 13;
								if (lUR2EneZrq() == null)
								{
									continue;
								}
								goto case 9;
							case 26:
								eVq2UQZ0Vp.Capacity = (int)stream.Length;
								goto IL_006d;
							case 25:
								flag = false;
								goto IL_021c;
							case 22:
								if (array2[num5] == 0)
								{
									num5++;
									goto IL_023b;
								}
								num4 = 25;
								if (rWv2pj4FU4())
								{
									continue;
								}
								goto IL_01e4;
							case 21:
								num4 = 17;
								if (rWv2pj4FU4())
								{
									continue;
								}
								goto case 2;
							default:
								if (num7 < num6)
								{
									goto case 27;
								}
								goto case 19;
							case 19:
								num7 = deflateStream.Read(array4, 0, num6);
								if (num7 > 0)
								{
									xBC2jJArdN(TFa2KTk9HV, array4, 0, num7);
									num4 = 0;
									if (lUR2EneZrq() == null)
									{
										continue;
									}
								}
								goto default;
							case 15:
								deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
								num6 = 1000;
								array4 = zE5IxecW1OHLF0xx97.ocNIJsOF66(1000);
								goto case 19;
							case 12:
								num5 = 0;
								goto IL_023b;
							case 6:
							{
								if ((num3 & 2) == 0)
								{
									goto IL_0177;
								}
								dESCryptoServiceProvider = new DESCryptoServiceProvider();
								byte[] array3 = zE5IxecW1OHLF0xx97.ocNIJsOF66(8);
								stream.Read(array3, 0, 8);
								dESCryptoServiceProvider.IV = array3;
								num4 = 1;
								if (rWv2pj4FU4())
								{
									continue;
								}
								goto IL_01e4;
							}
							case 4:
								array = iSt2T7QCeS(Assembly.GetExecutingAssembly());
								goto case 28;
							case 1:
								array = (byte[])Y6o2M6nfev(8);
								stream.Read(array, 0, 8);
								flag = true;
								array2 = array;
								num4 = 12;
								if (rWv2pj4FU4())
								{
									continue;
								}
								goto IL_01e4;
							case 17:
							case 23:
								goto IL_03dc;
							case 10:
								goto end_IL_0401;
							case 13:
								memoryStream = TFa2KTk9HV;
								goto case 5;
							case 5:
								if (memoryStream == null)
								{
									byte[] array6 = zE5IxecW1OHLF0xx97.ocNIJsOF66((int)checked((nint)unchecked(stream.Length - U9X2BRKiyG(stream))));
									stream.Read(array6, 0, (int)(nuint)SJb5kwt9VTQAZ3FV54.Q3EIvWMiE7(array6));
									return array6;
								}
								goto case 24;
							case 24:
								{
									return memoryStream.ToArray();
								}
								IL_0177:
								if ((num3 & 8u) != 0)
								{
									num2 = 8;
									goto case 8;
								}
								goto case 5;
								IL_023b:
								if (num5 >= (int)(nuint)SJb5kwt9VTQAZ3FV54.Q3EIvWMiE7(array2))
								{
									goto IL_021c;
								}
								goto case 22;
								IL_021c:
								if (!flag)
								{
									goto case 28;
								}
								num4 = 4;
								if (rWv2pj4FU4())
								{
									continue;
								}
								goto IL_01e4;
								IL_006d:
								eVq2UQZ0Vp.Position = 0L;
								cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
								inputBlockSize = cryptoTransform.InputBlockSize;
								_ = cryptoTransform.OutputBlockSize;
								array7 = (byte[])Y6o2M6nfev(H3w25ZQygy(cryptoTransform));
								goto case 2;
								IL_00c0:
								if (num8 + inputBlockSize < vhI2JQssgv(stream))
								{
									goto case 9;
								}
								stream.Read(array8, 0, (int)(stream.Length - num8));
								array5 = cryptoTransform.TransformFinalBlock(array8, 0, (int)(stream.Length - num8));
								goto case 20;
							}
							break;
						}
						break;
						IL_01e4:
						num4 = num2;
						goto IL_035e;
					}
				}
				num++;
				continue;
				end_IL_0401:
				break;
			}
		}
	}

	internal static bool rWv2pj4FU4()
	{
		return G0Y2OfSrPy == null;
	}

	internal static O3VQEjJqutgUVAK2W9 lUR2EneZrq()
	{
		return G0Y2OfSrPy;
	}

	internal static object v0i2mvxMVj(object object_0)
	{
		return ((Assembly)object_0).FullName;
	}

	internal static int Q2w28uVZRa(object object_0, object object_1)
	{
		return ((string)object_0).IndexOf((string)object_1);
	}

	internal static object msD26dSkHy(int int_0)
	{
		return A2IykMCm48qOE9ZWAc.VCEIRVFYJP(int_0);
	}

	internal static object cuj2DUNJb4(object object_0)
	{
		return frMBbykn6MKspnMCMw.fYtIBuqW3t(object_0);
	}

	internal static int JcH24lVwTO(object object_0)
	{
		return ((Stream)object_0).ReadByte();
	}

	internal static object Y6o2M6nfev(int int_0)
	{
		return zE5IxecW1OHLF0xx97.ocNIJsOF66(int_0);
	}

	internal static void G062sAUn8F(object object_0, object object_1)
	{
		((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
	}

	internal static void IIk2PEfvYY(object object_0, int int_0)
	{
		((MemoryStream)object_0).Capacity = int_0;
	}

	internal static int H3w25ZQygy(object object_0)
	{
		return ((ICryptoTransform)object_0).OutputBlockSize;
	}

	internal static long vhI2JQssgv(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static UIntPtr qyS2W0IqAE(object object_0)
	{
		return SJb5kwt9VTQAZ3FV54.Q3EIvWMiE7((byte[])object_0);
	}

	internal static void xBC2jJArdN(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void HMf2vY5OEE(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long U9X2BRKiyG(object object_0)
	{
		return ((Stream)object_0).Position;
	}
}
