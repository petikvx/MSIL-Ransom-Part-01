using System.IO;

public sealed class GClass16 : GClass0
{
	private string string_2;

	private string string_3;

	public new string String_0 => string_2;

	public new string String_1 => string_3;

	internal GClass16(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = method_1(ref memoryStream_0);
		while (true)
		{
			int num = 1693581137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x777E2CDCu) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 0u:
					break;
				default:
					string_0 = "ISDN Address: " + string_2 + ", SubAddress: " + string_3;
					return;
				}
				break;
				IL_000f:
				string_3 = method_1(ref memoryStream_0);
				num = (int)(num2 * 343035232) ^ -1988416517;
			}
		}
	}
}
