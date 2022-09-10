using System;
using System.IO;
using System.Net;
using System.Text;

public sealed class GClass23 : GClass0
{
	private string string_2;

	private GEnum8 genum8_0;

	private ushort ushort_0;

	private ushort ushort_1;

	private byte[] byte_0;

	private byte[] byte_1;

	private DateTime dateTime_0;

	public new string String_0 => string_2;

	public GEnum8 GEnum8_0 => genum8_0;

	public ushort UInt16_0 => ushort_0;

	public ushort UInt16_1 => ushort_1;

	public byte[] Byte_0 => byte_0;

	public byte[] Byte_1 => byte_1;

	public DateTime DateTime_0 => dateTime_0;

	public GClass23(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public GClass23(string string_3, string string_4, GEnum8 genum8_1, ushort ushort_2, ushort ushort_3, byte[] byte_2, byte[] byte_3, DateTime dateTime_1)
	{
		base.GClass24_0 = new GClass24(string_3, GEnum2.TSIG, GEnum4.ANY, 0);
		string_2 = string_4;
		genum8_0 = genum8_1;
		ushort_0 = ushort_2;
		ushort_1 = ushort_3;
		byte_0 = byte_2;
		byte_1 = byte_3;
		dateTime_0 = dateTime_1;
		if (byte_2 == null)
		{
			byte_0 = new byte[0];
		}
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		byte[] array2 = new byte[4];
		string_2 = GClass0.smethod_0(ref memoryStream_0);
		long long_2 = default(long);
		long long_ = default(long);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 142553631;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x63E7261Bu) % 17u)
				{
				case 16u:
					dateTime_0 = Class10.smethod_3(long_2, long_);
					memoryStream_0.Read(array, 0, array.Length);
					ushort_0 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					memoryStream_0.Read(array, 0, array.Length);
					num = (int)((num2 * 1742447695) ^ 0x2A718F20);
					continue;
				case 15u:
				{
					memoryStream_0.Read(array, 0, array.Length);
					num4 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					int num5;
					int num6;
					if (num4 > 0)
					{
						num5 = -1623065685;
						num6 = -1623065685;
					}
					else
					{
						num5 = -684403033;
						num6 = -684403033;
					}
					num = num5 ^ (int)(num2 * 602308100);
					continue;
				}
				case 14u:
					byte_0 = new byte[num4];
					num = ((int)num2 * -324659204) ^ 0x2616D363;
					continue;
				case 12u:
					byte_0 = null;
					num = 1590832485;
					continue;
				case 11u:
					memoryStream_0.Read(array, 0, array.Length);
					num = ((int)num2 * -479542519) ^ 0x20F49878;
					continue;
				case 10u:
					long_2 = (uint)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(array2, 0));
					num = ((int)num2 * -12808397) ^ -95785031;
					continue;
				case 9u:
					num = (int)((num2 * 326518537) ^ 0x58EB122F);
					continue;
				case 8u:
					memoryStream_0.Read(array, 0, array.Length);
					ushort_1 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = (int)(num2 * 1286014525) ^ -724087505;
					continue;
				case 7u:
					memoryStream_0.Read(byte_0, 0, num4);
					num = ((int)num2 * -26414871) ^ 0x5D87DEB9;
					continue;
				case 6u:
					long_ = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					memoryStream_0.Read(array2, 0, array2.Length);
					num = ((int)num2 * -1312653671) ^ 0x5FD1C3F8;
					continue;
				case 5u:
					num3 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = (int)((num2 * 720282666) ^ 0x1325DD3C);
					continue;
				case 4u:
					byte_1 = new byte[num3];
					num = ((int)num2 * -1687120125) ^ 0x281C9955;
					continue;
				case 3u:
					memoryStream_0.Read(array, 0, array.Length);
					num = (int)(num2 * 733425141) ^ -2046735456;
					continue;
				case 1u:
					genum8_0 = (GEnum8)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = (int)((num2 * 1240901401) ^ 0x182187E2);
					continue;
				case 0u:
					memoryStream_0.Read(byte_1, 0, num3);
					num = (int)(num2 * 1476175075) ^ -822561752;
					continue;
				case 2u:
					break;
				default:
					string_0 = ToString();
					return;
				}
				break;
			}
		}
	}

	public override byte[] imethod_2()
	{
		MemoryStream memoryStream = new MemoryStream();
		int int_ = default(int);
		long position = default(long);
		long long_ = default(long);
		byte[] array = default(byte[]);
		long num5 = default(long);
		while (true)
		{
			int num = -1458934905;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAB34DCFAu) % 18u)
				{
				case 17u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)byte_0.Length) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)(num2 * 1905646230) ^ -1834238610;
					continue;
				case 16u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)int_) >> 16));
					num = (int)(num2 * 1406869408) ^ -1077111265;
					continue;
				case 15u:
					array = base.GClass24_0.method_1();
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -1575705507) ^ -1963511027;
					continue;
				case 14u:
					position = memoryStream.Position;
					num = ((int)num2 * -1504674949) ^ -1484606966;
					continue;
				case 12u:
					memoryStream.Write(byte_0, 0, byte_0.Length);
					num = (int)(num2 * 2143772790) ^ -120560388;
					continue;
				case 11u:
					Class10.smethod_2(dateTime_0.ToUniversalTime(), out int_, out long_);
					num = ((int)num2 * -731967591) ^ -511310911;
					continue;
				case 10u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_1) >> 16));
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((int)genum8_0) >> 16));
					memoryStream.Write(array, 0, array.Length);
					num = (int)(num2 * 848327366) ^ -116387713;
					continue;
				case 9u:
					memoryStream.Write(array, 0, array.Length);
					num = (int)((num2 * 573547058) ^ 0x5A9943F1);
					continue;
				case 7u:
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((uint)(IPAddress.HostToNetworkOrder((uint)long_) >> 32));
					num = (int)(num2 * 416858777) ^ -1388314264;
					continue;
				case 6u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(ushort_0) >> 16));
					num = (int)((num2 * 1414025954) ^ 0x5FBCF6CF);
					continue;
				case 5u:
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)num5) >> 16));
					num = (int)((num2 * 2001195382) ^ 0x2A9C866C);
					continue;
				case 4u:
					array = Class10.smethod_0(string_2, bool_0: false);
					num = (int)(num2 * 591866510) ^ -54408861;
					continue;
				case 3u:
					memoryStream.Write(array, 0, array.Length);
					num = ((int)num2 * -411173519) ^ -1837343209;
					continue;
				case 2u:
					num5 = memoryStream.Position - position;
					memoryStream.Seek(position - 2L, SeekOrigin.Begin);
					num = -1756583425;
					continue;
				case 1u:
					memoryStream.Write(array, 0, array.Length);
					array = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder(byte_1.Length) >> 16));
					memoryStream.Write(array, 0, array.Length);
					memoryStream.Write(byte_1, 0, byte_1.Length);
					num = (int)((num2 * 749214063) ^ 0x1495F52D);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (byte_0.Length != 0)
					{
						num3 = 1626463254;
						num4 = 1626463254;
					}
					else
					{
						num3 = 824364462;
						num4 = 824364462;
					}
					num = num3 ^ (int)(num2 * 537247595);
					continue;
				}
				case 13u:
					break;
				default:
					memoryStream.Write(array, 0, array.Length);
					return memoryStream.ToArray();
				}
				break;
			}
		}
	}

	public override string imethod_1()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string_2);
		while (true)
		{
			int num = 1965094123;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8121BD8u) % 20u)
				{
				case 19u:
					stringBuilder.Append(" ");
					stringBuilder.Append(byte_1.Length);
					stringBuilder.Append(" ");
					stringBuilder.Append(Convert.ToBase64String(Byte_1));
					num = (int)((num2 * 112368815) ^ 0x2F994975);
					continue;
				case 18u:
					stringBuilder.Append(byte_0.Length);
					stringBuilder.Append(" ");
					num = 1962982924;
					continue;
				case 17u:
					stringBuilder.Append("<invalid BADTIME other data>");
					num = ((int)num2 * -2071286816) ^ 0xE3DB8C9;
					continue;
				case 16u:
					stringBuilder.Append(" ");
					num = ((int)num2 * -1398267018) ^ 0x438E610A;
					continue;
				case 15u:
					stringBuilder.Append(" ");
					num = ((int)num2 * -72502015) ^ 0x755B8993;
					continue;
				case 14u:
					stringBuilder.Append(" ");
					num = ((int)num2 * -104789258) ^ -1735136685;
					continue;
				case 11u:
					stringBuilder.Append(ushort_0);
					num = (int)((num2 * 363272792) ^ 0x3891FFF7);
					continue;
				case 10u:
				{
					stringBuilder.Append(genum8_0);
					stringBuilder.Append(" ");
					int num7;
					int num8;
					if (byte_0 == null)
					{
						num7 = -1309362106;
						num8 = -1309362106;
					}
					else
					{
						num7 = -498438462;
						num8 = -498438462;
					}
					num = num7 ^ (int)(num2 * 1798153982);
					continue;
				}
				case 9u:
				{
					long long_ = ((long)(byte_0[0] & 0xFF) << 40) + ((long)(byte_0[1] & 0xFF) << 32) + ((byte_0[2] & 0xFF) << 24) + ((byte_0[3] & 0xFF) << 16) + ((byte_0[4] & 0xFF) << 8) + (byte_0[5] & 0xFF);
					stringBuilder.Append("<server time: ");
					stringBuilder.Append(Class10.smethod_4(long_));
					num = 1758339061;
					continue;
				}
				case 8u:
					stringBuilder.Append(dateTime_0);
					num = (int)((num2 * 68442262) ^ 0xE4A8C3A);
					continue;
				case 7u:
					stringBuilder.Append("<");
					stringBuilder.Append(Convert.ToBase64String(byte_0));
					stringBuilder.Append(">");
					num = 933544144;
					continue;
				case 6u:
					stringBuilder.Append(0);
					num = ((int)num2 * -680308597) ^ 0x2F864435;
					continue;
				case 5u:
					stringBuilder.Append(">");
					num = (int)((num2 * 413626461) ^ 0x6062D94D);
					continue;
				case 4u:
					num = (int)((num2 * 715965342) ^ 0x61E97538);
					continue;
				case 3u:
					num = (int)((num2 * 855601226) ^ 0xC6A14FE);
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (byte_0.Length == 6)
					{
						num5 = 932954779;
						num6 = 932954779;
					}
					else
					{
						num5 = 1863877347;
						num6 = 1863877347;
					}
					num = num5 ^ (int)(num2 * 1097376785);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1170975581) ^ 0x63262723;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (genum8_0 == GEnum8.BADTIME)
					{
						num3 = -2079479250;
						num4 = -2079479250;
					}
					else
					{
						num3 = -120319633;
						num4 = -120319633;
					}
					num = num3 ^ (int)(num2 * 1481804746);
					continue;
				}
				case 13u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}
}
