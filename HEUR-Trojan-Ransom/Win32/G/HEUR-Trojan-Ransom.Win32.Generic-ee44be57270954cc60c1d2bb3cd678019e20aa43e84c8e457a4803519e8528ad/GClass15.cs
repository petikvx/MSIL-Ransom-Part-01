using System.IO;

public sealed class GClass15 : GClass0
{
	private string string_2;

	private string string_3;

	public new string String_0 => string_2;

	public new string String_1 => string_3;

	internal GClass15(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = GClass0.smethod_0(ref memoryStream_0);
		while (true)
		{
			int num = -1173151445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFB64809Cu) % 4u)
				{
				case 3u:
					string_3 = GClass0.smethod_0(ref memoryStream_0);
					num = (int)(num2 * 1625331345) ^ -2042734469;
					continue;
				case 0u:
					string_0 = "Responsible MailBox: " + string_2 + ", Error MailBox: " + string_3;
					num = (int)(num2 * 1629309433) ^ -5916651;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
