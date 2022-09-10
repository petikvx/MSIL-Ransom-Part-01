using System;
using System.IO;
using System.Net;

public sealed class GClass1 : GClass0
{
	private ushort ushort_0;

	private string string_2;

	public ushort UInt16_0 => ushort_0;

	public new string String_0 => string_2;

	internal GClass1(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		while (true)
		{
			int num = -1549750828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC411703Du) % 5u)
				{
				case 4u:
					memoryStream_0.Read(array, 0, 2);
					num = ((int)num2 * -1338420452) ^ 0x5B346E97;
					continue;
				case 2u:
					ushort_0 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = ((int)num2 * -2087752260) ^ -1823827092;
					continue;
				case 1u:
					string_2 = GClass0.smethod_0(ref memoryStream_0);
					string_0 = "Preference: " + ushort_0 + ", Intermediate Host: " + string_2;
					num = ((int)num2 * -107987260) ^ 0x5560FEF1;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
