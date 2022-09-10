using System.IO;

public sealed class GClass19 : GClass0
{
	private string string_2;

	private string string_3;

	public new string String_0 => string_2;

	public new string String_1 => string_3;

	internal GClass19(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = GClass0.smethod_0(ref memoryStream_0);
		while (true)
		{
			int num = -136458323;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6514B92u) % 4u)
				{
				case 3u:
					string_3 = GClass0.smethod_0(ref memoryStream_0);
					num = ((int)num2 * -1303229914) ^ -100664211;
					continue;
				case 1u:
					string_0 = string_2 + ", " + string_3;
					num = (int)((num2 * 1176089965) ^ 0x26AF925D);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
