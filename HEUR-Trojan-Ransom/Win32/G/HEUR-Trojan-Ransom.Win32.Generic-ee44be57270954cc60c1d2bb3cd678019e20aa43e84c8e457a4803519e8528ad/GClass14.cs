using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public sealed class GClass14 : GClass0
{
	private ProtocolType protocolType_0;

	private IPAddress ipaddress_0;

	private short[] short_0;

	public ProtocolType ProtocolType_0
	{
		get
		{
			return protocolType_0;
		}
		set
		{
			protocolType_0 = value;
		}
	}

	public IPAddress IPAddress_0
	{
		get
		{
			return ipaddress_0;
		}
		set
		{
			ipaddress_0 = value;
		}
	}

	public short[] Int16_0
	{
		get
		{
			return short_0;
		}
		set
		{
			short_0 = value;
		}
	}

	internal GClass14(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		int num = base.GClass24_0.Int16_0 - 4 - 1;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num];
		memoryStream_0.Read(array, 0, 4);
		while (true)
		{
			int num2 = 1360658498;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x67EA2BD5u) % 5u)
				{
				case 4u:
					string_0 = string.Concat(protocolType_0, ": ", GClass28.smethod_0(short_0, protocolType_0));
					num2 = ((int)num3 * -588340137) ^ 0x433085BA;
					continue;
				case 3u:
					ipaddress_0 = new IPAddress((uint)IPAddress.NetworkToHostOrder(BitConverter.ToUInt32(array, 0)));
					protocolType_0 = (ProtocolType)memoryStream_0.ReadByte();
					memoryStream_0.Read(array2, 0, array2.Length);
					num2 = (int)((num3 * 1228647427) ^ 0x2EEB66F3);
					continue;
				case 0u:
					short_0 = method_2(array2);
					num2 = (int)((num3 * 1172701826) ^ 0x524B0D2B);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private short[] method_2(byte[] byte_0)
	{
		short[] array = new short[1024];
		int num3 = default(int);
		byte b = default(byte);
		short[] array2 = default(short[]);
		int num6 = default(int);
		byte b2 = default(byte);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 318607975;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x475CAF6Eu) % 15u)
				{
				case 14u:
				{
					int num8;
					if (num3 >= byte_0.Length)
					{
						num = 1917546642;
						num8 = 1917546642;
					}
					else
					{
						num = 1375855461;
						num8 = 1375855461;
					}
					continue;
				}
				case 13u:
					num = ((int)num2 * -865130558) ^ 0x139A4FFC;
					continue;
				case 12u:
				{
					b = (byte)(b << 1);
					int num9;
					int num10;
					if ((0x80 & b) == 128)
					{
						num9 = -1873005821;
						num10 = -1873005821;
					}
					else
					{
						num9 = -1067404208;
						num10 = -1067404208;
					}
					num = num9 ^ ((int)num2 * -463026168);
					continue;
				}
				case 11u:
					array2 = new short[num6];
					Array.Copy(array, 0, array2, 0, num6);
					num = (int)((num2 * 381115160) ^ 0xC78E82D);
					continue;
				case 10u:
					b2 = (byte)(b2 - 1);
					num = 1248316330;
					continue;
				case 9u:
					num3++;
					num = (int)(num2 * 660007250) ^ -1295593952;
					continue;
				case 8u:
				{
					int num7;
					if (b2 == byte.MaxValue)
					{
						num = 256537329;
						num7 = 256537329;
					}
					else
					{
						num = 916882290;
						num7 = 916882290;
					}
					continue;
				}
				case 7u:
					num6++;
					num = ((int)num2 * -2014072185) ^ 0x13988D7D;
					continue;
				case 6u:
					b = byte_0[num3];
					num4 = 0;
					b2 = 7;
					num = 1020066021;
					continue;
				case 3u:
					array[num6] = (short)num5;
					num = (int)(num2 * 966984041) ^ -1657330512;
					continue;
				case 2u:
					num = (int)(num2 * 1715605299) ^ -1397717836;
					continue;
				case 1u:
					num6 = 0;
					num3 = 0;
					num = ((int)num2 * -2126275580) ^ 0x646FD7D4;
					continue;
				case 0u:
					num5 = num3 * 8 + num4++ + 1;
					num = 732749633;
					continue;
				case 4u:
					break;
				default:
					return array2;
				}
				break;
			}
		}
	}
}
