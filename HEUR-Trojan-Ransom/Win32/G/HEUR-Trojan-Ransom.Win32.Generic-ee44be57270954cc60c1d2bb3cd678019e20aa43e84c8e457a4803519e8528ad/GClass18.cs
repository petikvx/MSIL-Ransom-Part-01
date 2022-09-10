using System;
using System.IO;
using System.Net;
using System.Text;

public sealed class GClass18 : GClass0
{
	private string string_2;

	private string string_3;

	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	private int int_0;

	public new string String_0 => string_2;

	public new string String_1 => string_3;

	public uint UInt32_0 => uint_0;

	public uint UInt32_1 => uint_1;

	public uint UInt32_2 => uint_2;

	public uint UInt32_3 => uint_3;

	public int Int32_0 => int_0;

	internal GClass18(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = -2046570092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD2468E0u) % 29u)
				{
				case 28u:
					stringBuilder.Append("\r\n");
					num = ((int)num2 * -626605670) ^ -2033697383;
					continue;
				case 26u:
					uint_1 = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array2, 0));
					num = (int)(num2 * 1501826646) ^ -1156596444;
					continue;
				case 25u:
					stringBuilder.Append("\r\n");
					memoryStream_0.Read(array5, 0, 4);
					int_0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array5, 0));
					num = ((int)num2 * -390802723) ^ -1550344287;
					continue;
				case 23u:
					stringBuilder.Append("Refresh Interval: ");
					num = ((int)num2 * -365091506) ^ -157779467;
					continue;
				case 22u:
					string_3 = GClass0.smethod_0(ref memoryStream_0);
					num = (int)((num2 * 647902849) ^ 0x4DE7E1B);
					continue;
				case 21u:
					stringBuilder.Append(uint_3);
					num = ((int)num2 * -374175865) ^ 0x59A84D4F;
					continue;
				case 20u:
					stringBuilder.Append(uint_2);
					stringBuilder.Append("\r\n");
					num = ((int)num2 * -222013356) ^ 0x343A4560;
					continue;
				case 19u:
					string_0 = stringBuilder.ToString();
					num = ((int)num2 * -2061899900) ^ 0x66A9890F;
					continue;
				case 18u:
					stringBuilder.Append(uint_1);
					num = ((int)num2 * -1449745401) ^ 0x52C4C3CB;
					continue;
				case 17u:
					stringBuilder.Append("Retry Interval: ");
					num = (int)((num2 * 787337225) ^ 0x5DD0BAE1);
					continue;
				case 16u:
					string_2 = GClass0.smethod_0(ref memoryStream_0);
					stringBuilder.Append("Primary NameServer: ");
					stringBuilder.Append(string_2);
					num = ((int)num2 * -1257135705) ^ 0x59AA22FE;
					continue;
				case 15u:
					stringBuilder.Append("\r\n");
					num = ((int)num2 * -910316746) ^ 0x7DC9C35B;
					continue;
				case 14u:
					stringBuilder.Append(string_3);
					num = (int)((num2 * 116359153) ^ 0x3094D0A4);
					continue;
				case 13u:
					array2 = new byte[4];
					num = (int)(num2 * 883630785) ^ -1116087950;
					continue;
				case 12u:
					memoryStream_0.Read(array4, 0, 4);
					num = (int)(num2 * 764534766) ^ -2051813981;
					continue;
				case 11u:
					uint_0 = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array4, 0));
					stringBuilder.Append("Serial: ");
					stringBuilder.Append(uint_0);
					num = (int)((num2 * 251186539) ^ 0x7B5FCCBB);
					continue;
				case 10u:
					array5 = new byte[4];
					num = ((int)num2 * -54762650) ^ 0x2EED3B02;
					continue;
				case 9u:
					stringBuilder.Append("\r\n");
					array4 = new byte[4];
					num = (int)((num2 * 734271831) ^ 0x41BEAA37);
					continue;
				case 8u:
					stringBuilder.Append(int_0);
					stringBuilder.Append("\r\n");
					num = (int)((num2 * 1543695131) ^ 0x452EC4C4);
					continue;
				case 7u:
					array3 = new byte[4];
					array = new byte[4];
					num = (int)(num2 * 1878475586) ^ -751694135;
					continue;
				case 6u:
					stringBuilder.Append("TTL: ");
					num = ((int)num2 * -796061116) ^ 0x3D3454E0;
					continue;
				case 5u:
					memoryStream_0.Read(array3, 0, 4);
					uint_2 = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array3, 0));
					num = (int)(num2 * 1745109342) ^ -1489229218;
					continue;
				case 4u:
					stringBuilder.Append("\r\n");
					num = (int)(num2 * 1813160289) ^ -1536445857;
					continue;
				case 3u:
					stringBuilder.Append("Responsible Person: ");
					num = (int)(num2 * 962355868) ^ -1940222375;
					continue;
				case 2u:
					memoryStream_0.Read(array2, 0, 4);
					num = (int)(num2 * 1854403368) ^ -1780651431;
					continue;
				case 1u:
					memoryStream_0.Read(array, 0, 4);
					uint_3 = (uint)IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array, 0));
					num = (int)(num2 * 635066183) ^ -430915229;
					continue;
				case 0u:
					stringBuilder.Append("Expire: ");
					num = (int)((num2 * 646100161) ^ 0x6CD38EF0);
					continue;
				default:
					return;
				case 24u:
					break;
				case 27u:
					return;
				}
				break;
			}
		}
	}
}
