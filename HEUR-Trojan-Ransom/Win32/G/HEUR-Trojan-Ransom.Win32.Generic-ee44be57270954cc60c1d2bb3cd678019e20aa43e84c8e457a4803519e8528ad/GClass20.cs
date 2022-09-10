using System;
using System.IO;
using System.Net;

public sealed class GClass20 : GClass0
{
	private short short_0;

	private string string_2;

	public short Int16_0 => short_0;

	public new string String_0 => string_2;

	internal GClass20(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		while (true)
		{
			int num = -191064390;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8ED1BD48u) % 4u)
				{
				case 2u:
					memoryStream_0.Read(array, 0, 2);
					short_0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(array, 0));
					num = ((int)num2 * -788162327) ^ 0x7FD09587;
					continue;
				case 1u:
					string_2 = GClass0.smethod_0(ref memoryStream_0);
					string_0 = "MX Preference: " + short_0 + ", Mail Exchanger: " + string_2;
					num = ((int)num2 * -1063771863) ^ 0x3948F066;
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
