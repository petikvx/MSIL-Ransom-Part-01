using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class GClass27 : GClass25
{
	private GClass26 gclass26_0 = new GClass26();

	private GInterface0[] ginterface0_0;

	private GInterface0[] ginterface0_1;

	private int int_0;

	public GClass26 GClass26_0 => gclass26_0;

	public GInterface0[] GInterface0_0 => ginterface0_0;

	public GInterface0[] GInterface0_1 => ginterface0_1;

	public int Int32_0 => int_0;

	private GClass26 method_0(ref MemoryStream memoryStream_0)
	{
		GClass26 gClass = new GClass26();
		gClass.String_0 = GClass0.smethod_0(ref memoryStream_0);
		return gClass;
	}

	internal void method_1(byte[] byte_0, ProtocolType protocolType_0)
	{
		MemoryStream memoryStream_ = new MemoryStream(byte_0);
		byte[] array = new byte[2];
		byte[] array4 = default(byte[]);
		int num3 = default(int);
		byte[] array6 = default(byte[]);
		int num5 = default(int);
		byte[] array3 = default(byte[]);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		byte[] array5 = default(byte[]);
		ushort num4 = default(ushort);
		while (true)
		{
			int num = 1505675246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFCEBC61u) % 33u)
				{
				case 32u:
					gclass26_0 = method_0(ref memoryStream_);
					memoryStream_.Read(array4, 0, 2);
					num = (int)(num2 * 1653216695) ^ -1381878847;
					continue;
				case 31u:
					num = ((int)num2 * -299584925) ^ 0x20134C82;
					continue;
				case 30u:
					num = (int)((num2 * 1326914171) ^ 0x1B9BEA7D);
					continue;
				case 29u:
				{
					int num8;
					if (num3 < ushort_4)
					{
						num = 2034494290;
						num8 = 2034494290;
					}
					else
					{
						num = 206767347;
						num8 = 206767347;
					}
					continue;
				}
				case 28u:
					genum4_0 = (GEnum4)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array6, 0));
					num5 = 0;
					num = ((int)num2 * -2047821996) ^ -1577883860;
					continue;
				case 27u:
					genum6_0 = (GEnum6)(ushort_1 & 0x7800u);
					num = ((int)num2 * -266940025) ^ 0x41E10365;
					continue;
				case 26u:
					memoryStream_.Read(array3, 0, 2);
					num = ((int)num2 * -587722294) ^ 0x54B7BADB;
					continue;
				case 25u:
					num6 = 0;
					num = ((int)num2 * -89648049) ^ 0x3985AADF;
					continue;
				case 24u:
					ushort_2 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array2, 0));
					ushort_3 = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array7, 0));
					ushort_4 = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array3, 0));
					num = ((int)num2 * -168047022) ^ -1701096208;
					continue;
				case 23u:
					ushort_1 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					genum5_0 = (GEnum5)(ushort_1 & 0x8000u);
					num = ((int)num2 * -796850784) ^ 0x498EDF40;
					continue;
				case 22u:
					ushort_0 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array8, 0));
					num = (int)((num2 * 1136407461) ^ 0x698D5940);
					continue;
				case 21u:
					array2 = new byte[2];
					array7 = new byte[2];
					num = ((int)num2 * -1613363473) ^ -529829187;
					continue;
				case 20u:
					list_0.Add(Class9.smethod_0(ref memoryStream_));
					num6++;
					num = 500422637;
					continue;
				case 19u:
					memoryStream_.Read(array5, 0, 2);
					num = ((int)num2 * -376075949) ^ 0x59FE4246;
					continue;
				case 18u:
					array5 = new byte[2];
					num = ((int)num2 * -269346627) ^ -1165423238;
					continue;
				case 17u:
					genum7_0 = (GEnum7)(ushort_1 & 0x7F0u);
					genum8_0 = (GEnum8)(ushort_1 & 0xFu);
					num = (int)((num2 * 1400811413) ^ 0x15229721);
					continue;
				case 16u:
					list_0 = new List<GInterface0>();
					ginterface0_0 = new GClass0[ushort_3];
					ginterface0_1 = new GClass0[ushort_4];
					num = (int)(num2 * 1570531536) ^ -1640188841;
					continue;
				case 15u:
					array4 = new byte[2];
					array6 = new byte[2];
					int_0 = byte_0.Length;
					memoryStream_.Read(array8, 0, 2);
					num = ((int)num2 * -256317114) ^ -2136777591;
					continue;
				case 14u:
					array8 = new byte[2];
					num = ((int)num2 * -1107238072) ^ 0x7E39A890;
					continue;
				case 13u:
					num3++;
					num = ((int)num2 * -945129438) ^ 0x22FC6E87;
					continue;
				case 12u:
				{
					int num9;
					if (num5 >= ushort_3)
					{
						num = 658955830;
						num9 = 658955830;
					}
					else
					{
						num = 547309221;
						num9 = 547309221;
					}
					continue;
				}
				case 10u:
					memoryStream_.Read(array7, 0, 2);
					num = ((int)num2 * -253605472) ^ 0x33758B92;
					continue;
				case 9u:
				{
					int num7;
					if (num6 >= num4)
					{
						num = 1782787194;
						num7 = 1782787194;
					}
					else
					{
						num = 72164084;
						num7 = 72164084;
					}
					continue;
				}
				case 8u:
					memoryStream_.Read(array6, 0, 2);
					num = (int)(num2 * 1865939380) ^ -5905824;
					continue;
				case 7u:
					ginterface0_0[num5] = Class9.smethod_0(ref memoryStream_);
					num5++;
					num = 1300672669;
					continue;
				case 6u:
					num4 = (ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array5, 0));
					num = (int)(num2 * 454279339) ^ -103540675;
					continue;
				case 4u:
					ginterface0_1[num3] = Class9.smethod_0(ref memoryStream_);
					num = 794975751;
					continue;
				case 3u:
					genum2_0 = (GEnum2)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array4, 0));
					num = (int)((num2 * 1253256186) ^ 0x1EA25F55);
					continue;
				case 2u:
					array3 = new byte[2];
					num = ((int)num2 * -1362240415) ^ -2093833844;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 454239637) ^ -417251160;
					continue;
				case 0u:
					memoryStream_.Read(array, 0, 2);
					memoryStream_.Read(array2, 0, 2);
					num = (int)((num2 * 11569662) ^ 0x10D425D7);
					continue;
				default:
					return;
				case 5u:
					break;
				case 11u:
					return;
				}
				break;
			}
		}
	}
}
