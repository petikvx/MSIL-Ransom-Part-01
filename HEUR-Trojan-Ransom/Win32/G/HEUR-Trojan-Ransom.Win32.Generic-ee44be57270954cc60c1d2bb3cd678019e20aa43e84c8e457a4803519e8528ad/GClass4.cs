using System;
using System.IO;
using System.Net;

public sealed class GClass4 : GClass0
{
	private ushort ushort_0;

	private ushort ushort_1;

	private ushort ushort_2;

	private string string_2;

	public ushort UInt16_0 => ushort_0;

	public ushort UInt16_1 => ushort_1;

	public ushort UInt16_2 => ushort_2;

	public new string String_0 => string_2;

	internal GClass4(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[2];
		byte[] array2 = default(byte[]);
		while (true)
		{
			int num = 1973681195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x669808F3u) % 6u)
				{
				case 5u:
				{
					ushort_1 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array2, 0));
					byte[] array3 = new byte[2];
					memoryStream_0.Read(array3, 0, 2);
					ushort_2 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array3, 0));
					num = ((int)num2 * -430599062) ^ 0x6D294847;
					continue;
				}
				case 4u:
					memoryStream_0.Read(array, 0, 2);
					ushort_0 = (ushort)IPAddress.NetworkToHostOrder((short)BitConverter.ToUInt16(array, 0));
					num = (int)(num2 * 856135049) ^ -90740974;
					continue;
				case 2u:
					string_2 = GClass0.smethod_0(ref memoryStream_0);
					num = (int)((num2 * 2103999457) ^ 0x459B381E);
					continue;
				case 1u:
					array2 = new byte[2];
					memoryStream_0.Read(array2, 0, 2);
					num = (int)((num2 * 1428334020) ^ 0x320F834E);
					continue;
				case 0u:
					break;
				default:
					string_0 = "Service Location: \r\nPriority: " + ushort_0 + "\r\nWeight: " + ushort_1 + "\r\nPort: " + ushort_2 + "\r\nHostName: " + string_2 + "\r\n";
					return;
				}
				break;
			}
		}
	}
}
