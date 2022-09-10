using System;
using System.IO;
using System.Net;
using System.Text;

public sealed class GClass12 : GClass0
{
	private byte byte_0;

	private byte byte_1;

	private byte byte_2;

	private byte byte_3;

	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private char[] char_0 = new char[2] { 'N', 'S' };

	private char[] char_1 = new char[2] { 'E', 'W' };

	public byte Byte_0 => byte_0;

	public byte Byte_1 => byte_1;

	public byte Byte_2 => byte_2;

	public byte Byte_3 => byte_3;

	public uint UInt32_0 => uint_0;

	public uint UInt32_1 => uint_1;

	public uint UInt32_2 => uint_2;

	internal GClass12(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[4];
		byte[] array2 = new byte[4];
		StringBuilder stringBuilder = default(StringBuilder);
		byte[] array3 = default(byte[]);
		while (true)
		{
			int num = 1565936427;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3ABF2B55u) % 22u)
				{
				case 21u:
					stringBuilder.Append("\r\n");
					num = ((int)num2 * -1638965729) ^ 0x20A4D6A4;
					continue;
				case 20u:
					stringBuilder.Append("\r\n");
					num = (int)((num2 * 1771331920) ^ 0x5E68BAF0);
					continue;
				case 19u:
					stringBuilder.Append(" m\r\n");
					num = (int)((num2 * 1857186472) ^ 0x635318DE);
					continue;
				case 18u:
					stringBuilder.Append("Horizontal Precision: ");
					stringBuilder.Append(method_3(byte_2));
					stringBuilder.Append(" m\r\n");
					num = ((int)num2 * -221642194) ^ 0x2E40009C;
					continue;
				case 17u:
					stringBuilder.Append(method_3(byte_3));
					stringBuilder.Append(" m\r\n");
					num = (int)((num2 * 778940597) ^ 0x34880C5A);
					continue;
				case 16u:
					memoryStream_0.Read(array3, 0, array3.Length);
					num = (int)(num2 * 1676330763) ^ -87953534;
					continue;
				case 15u:
					stringBuilder = new StringBuilder();
					stringBuilder.Append("Version: ");
					stringBuilder.Append(byte_0);
					stringBuilder.Append("\r\n");
					num = ((int)num2 * -666709419) ^ 0x4CD1CCB5;
					continue;
				case 13u:
					stringBuilder.Append(method_3(byte_1));
					stringBuilder.Append(" m\r\n");
					num = ((int)num2 * -1093928331) ^ -2046949914;
					continue;
				case 12u:
					array3 = new byte[4];
					byte_0 = (byte)memoryStream_0.ReadByte();
					byte_1 = (byte)memoryStream_0.ReadByte();
					byte_2 = (byte)memoryStream_0.ReadByte();
					num = ((int)num2 * -211061633) ^ 0xD7F8E4F;
					continue;
				case 11u:
					string_0 = stringBuilder.ToString();
					num = (int)(num2 * 413686504) ^ -1239654507;
					continue;
				case 10u:
					stringBuilder.Append("Altitude: ");
					stringBuilder.Append((double)(uint_2 - 10000000) / 100.0);
					num = (int)((num2 * 622804054) ^ 0x4FFE4058);
					continue;
				case 9u:
					stringBuilder.Append("Vertical Precision: ");
					num = ((int)num2 * -724539449) ^ -1073423745;
					continue;
				case 8u:
					stringBuilder.Append(method_2(uint_0, char_0));
					num = ((int)num2 * -2085053125) ^ 0x5DFA7AFB;
					continue;
				case 7u:
					stringBuilder.Append("Longitude: ");
					num = ((int)num2 * -1642768503) ^ -805392975;
					continue;
				case 6u:
					byte_3 = (byte)memoryStream_0.ReadByte();
					memoryStream_0.Read(array, 0, array.Length);
					uint_0 = (uint)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(array, 0));
					num = ((int)num2 * -1330346108) ^ -265558753;
					continue;
				case 5u:
					uint_2 = (uint)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(array3, 0));
					num = ((int)num2 * -1089573489) ^ -682311585;
					continue;
				case 3u:
					stringBuilder.Append(method_2(uint_1, char_1));
					num = (int)((num2 * 1253059073) ^ 0x35F761B1);
					continue;
				case 2u:
					stringBuilder.Append("Latitude: ");
					num = (int)(num2 * 1704974941) ^ -49999759;
					continue;
				case 1u:
					stringBuilder.Append("Size: ");
					num = (int)(num2 * 1901338396) ^ -337686940;
					continue;
				case 0u:
					memoryStream_0.Read(array2, 0, array2.Length);
					uint_1 = (uint)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(array2, 0));
					num = (int)((num2 * 1068991614) ^ 0x54C2CED3);
					continue;
				default:
					return;
				case 14u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private string method_2(uint uint_3, char[] char_2)
	{
		if (uint_3 < 2147483648u)
		{
			goto IL_0177;
		}
		goto IL_01cb;
		IL_01cb:
		uint_3 -= 2147483648u;
		int num = -924041149;
		goto IL_017c;
		IL_017c:
		object[] array = default(object[]);
		char c = default(char);
		uint num5 = default(uint);
		uint num6 = default(uint);
		uint num4 = default(uint);
		uint num3 = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCD340ED8u) % 15u)
			{
			case 14u:
				array[1] = " deg, ";
				num = (int)((num2 * 1241818747) ^ 0x1FB67ADC);
				continue;
			case 12u:
				uint_3 = 2147483648u - uint_3;
				c = char_2[1];
				num = (int)((num2 * 459951712) ^ 0x42683864);
				continue;
			case 11u:
				array[0] = num5;
				num = (int)(num2 * 2099175170) ^ -2100721873;
				continue;
			case 10u:
				num6 = uint_3 % 1000u;
				num = -1309370407;
				continue;
			case 9u:
				array[6] = num6;
				num = ((int)num2 * -515786560) ^ -1043357296;
				continue;
			case 8u:
				array[3] = " min ";
				num = (int)((num2 * 484852501) ^ 0x266E66B2);
				continue;
			case 7u:
				array[4] = num4;
				num = ((int)num2 * -885550241) ^ 0xE299E0E;
				continue;
			case 6u:
				array[7] = " sec ";
				array[8] = c;
				num = ((int)num2 * -95595012) ^ 0x226313C6;
				continue;
			case 5u:
				uint_3 /= 1000u;
				num4 = uint_3 % 60u;
				uint_3 /= 60u;
				num3 = uint_3 % 60u;
				num5 = uint_3 / 60u;
				array = new object[9];
				num = (int)(num2 * 279951705) ^ -2112586247;
				continue;
			case 4u:
				c = char_2[0];
				num = (int)(num2 * 1676396161) ^ -118261793;
				continue;
			case 3u:
				array[2] = num3;
				num = ((int)num2 * -1969082208) ^ -1509362628;
				continue;
			case 1u:
				array[5] = ".";
				num = ((int)num2 * -660279564) ^ -190672950;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_01cb;
			default:
				return string.Concat(array);
			}
			break;
		}
		goto IL_0177;
		IL_0177:
		num = -831124185;
		goto IL_017c;
	}

	private double method_3(byte byte_4)
	{
		double num = (byte_4 & 0xF0) >> 4;
		int num2 = byte_4 & 0xF;
		while (true)
		{
			int num3 = -1739713898;
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num3 ^ 0xC2164C15u) % 6u)
				{
				case 5u:
				{
					int num5;
					if (num2 == 0)
					{
						num3 = -1992208613;
						num5 = -1992208613;
					}
					else
					{
						num3 = -2099657055;
						num5 = -2099657055;
					}
					continue;
				}
				case 4u:
					num *= 10.0;
					num3 = -969480130;
					continue;
				case 3u:
					num2--;
					num3 = (int)(num4 * 1496712574) ^ -469546724;
					continue;
				case 1u:
					num3 = (int)(num4 * 1430788163) ^ -629020289;
					continue;
				case 0u:
					break;
				default:
					return num / 100.0;
				}
				break;
			}
		}
	}
}
