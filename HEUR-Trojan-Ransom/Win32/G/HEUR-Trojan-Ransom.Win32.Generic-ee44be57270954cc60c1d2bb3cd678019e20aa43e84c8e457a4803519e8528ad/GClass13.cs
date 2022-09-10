using System.IO;
using System.Text;

public sealed class GClass13 : GClass0
{
	public enum GEnum3 : byte
	{
		E164 = 1,
		NSAP
	}

	private string string_2;

	private GEnum3 genum3_0;

	public new string String_0 => string_2;

	public GEnum3 GEnum3_0 => genum3_0;

	internal GClass13(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		byte[] array = new byte[base.GClass24_0.Int16_0 - 1];
		while (true)
		{
			int num = -757388114;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9C5A9D02u) % 5u)
				{
				case 4u:
					string_2 = Encoding.ASCII.GetString(array);
					string_0 = "Address: " + string_2 + ", Format: " + genum3_0;
					num = ((int)num2 * -389591985) ^ -234625841;
					continue;
				case 2u:
					memoryStream_0.Read(array, 0, base.GClass24_0.Int16_0 - 1);
					num = ((int)num2 * -613373551) ^ 0x1102D8F2;
					continue;
				case 1u:
					genum3_0 = (GEnum3)memoryStream_0.ReadByte();
					num = ((int)num2 * -434629577) ^ -686374519;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
