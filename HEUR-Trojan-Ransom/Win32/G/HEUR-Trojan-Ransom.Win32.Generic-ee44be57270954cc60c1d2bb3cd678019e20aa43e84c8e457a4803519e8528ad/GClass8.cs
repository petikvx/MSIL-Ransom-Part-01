using System;
using System.IO;
using System.Net;

public sealed class GClass8 : GClass0
{
	private ushort ushort_0;

	private string string_2;

	private short short_0;

	public ushort UInt16_0 => ushort_0;

	public new string String_0 => string_2;

	public short Int16_0 => short_0;

	internal GClass8(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		while (true)
		{
			int num = -1663696952;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB5EFC305u) % 6u)
				{
				case 5u:
					string_2 = GClass0.smethod_0(ref memoryStream_0);
					num = (int)(num2 * 1367913441) ^ -479535277;
					continue;
				case 3u:
					short_0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 0));
					num = (int)((num2 * 744915587) ^ 0x54B885F6);
					continue;
				case 1u:
					memoryStream_0.Read(array, 0, 2);
					ushort_0 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = ((int)num2 * -1635491783) ^ 0x217EC23F;
					continue;
				case 0u:
					string_0 = "Name: " + string_2 + ", Port: " + ushort_0 + ", Type: " + short_0;
					num = (int)(num2 * 1285470892) ^ -1162038595;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}
}
