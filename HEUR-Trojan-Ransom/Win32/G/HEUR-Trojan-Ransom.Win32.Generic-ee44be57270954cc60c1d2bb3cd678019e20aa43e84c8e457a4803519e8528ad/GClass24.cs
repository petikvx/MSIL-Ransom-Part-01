using System;
using System.IO;
using System.Net;

public class GClass24
{
	private string string_0;

	private GEnum2 genum2_0;

	private GEnum4 genum4_0;

	private int int_0;

	private short short_0;

	public string String_0 => string_0;

	public GEnum2 GEnum2_0 => genum2_0;

	public GEnum4 GEnum4_0 => genum4_0;

	public int Int32_0 => int_0;

	public short Int16_0 => short_0;

	public GClass24(string string_1, GEnum2 genum2_1, GEnum4 genum4_1, int int_1)
	{
		while (true)
		{
			int num = -341921692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC353A4BEu) % 4u)
				{
				case 3u:
					genum4_0 = genum4_1;
					int_0 = int_1;
					num = ((int)num2 * -2030267475) ^ 0x3262590C;
					continue;
				case 2u:
					string_0 = string_1;
					genum2_0 = genum2_1;
					num = ((int)num2 * -1374527328) ^ -133142599;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public GClass24()
	{
	}

	public void method_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		byte[] array2 = new byte[2];
		byte[] array3 = new byte[4];
		byte[] array4 = new byte[2];
		string_0 = GClass0.smethod_0(ref memoryStream_0);
		while (true)
		{
			int num = 349821964;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E1F2B0Bu) % 6u)
				{
				case 3u:
					memoryStream_0.Read(array4, 0, 2);
					genum2_0 = (GEnum2)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 0));
					genum4_0 = (GEnum4)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array2, 0));
					num = (int)(num2 * 2083352790) ^ -436251973;
					continue;
				case 2u:
					memoryStream_0.Read(array3, 0, 4);
					num = ((int)num2 * -376298882) ^ 0x592395F6;
					continue;
				case 1u:
					memoryStream_0.Read(array, 0, 2);
					memoryStream_0.Read(array2, 0, 2);
					num = ((int)num2 * -1890487775) ^ 0x645CF1FC;
					continue;
				case 0u:
					int_0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(array3, 0));
					num = (int)((num2 * 1792784765) ^ 0x6B44B378);
					continue;
				case 4u:
					break;
				default:
					short_0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array4, 0));
					return;
				}
				break;
			}
		}
	}

	internal byte[] method_1()
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = default(byte[]);
		while (true)
		{
			int num = -1062043560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FF37EA9u) % 6u)
				{
				case 4u:
					memoryStream.Write(bytes, 0, bytes.Length);
					bytes = BitConverter.GetBytes((uint)IPAddress.HostToNetworkOrder((ushort)int_0));
					memoryStream.Write(bytes, 0, bytes.Length);
					num = ((int)num2 * -1582022522) ^ 0x46AC7053;
					continue;
				case 3u:
					memoryStream.Write(bytes, 0, bytes.Length);
					bytes = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)genum2_0) >> 16));
					memoryStream.Write(bytes, 0, bytes.Length);
					num = ((int)num2 * -247742526) ^ 0x24BAA841;
					continue;
				case 2u:
					bytes = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((int)genum4_0) >> 16));
					num = ((int)num2 * -427700821) ^ -993392485;
					continue;
				case 1u:
					bytes = Class10.smethod_0(string_0, bool_0: false);
					num = (int)(num2 * 435917425) ^ -814260725;
					continue;
				case 5u:
					break;
				default:
					bytes = BitConverter.GetBytes((ushort)(IPAddress.HostToNetworkOrder((ushort)short_0) >> 16));
					memoryStream.Write(bytes, 0, bytes.Length);
					return memoryStream.ToArray();
				}
				break;
			}
		}
	}
}
