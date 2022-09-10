using System.IO;

public sealed class GClass6 : GClass0
{
	private string string_2;

	public new string String_0 => string_2;

	internal GClass6(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = method_1(ref memoryStream_0);
		while (true)
		{
			int num = -601979805;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE63CC5D4u) % 3u)
				{
				case 1u:
					goto IL_000f;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000f:
				string_0 = "X.25  X.121 Address: " + string_2;
				num = (int)(num2 * 680840727) ^ -1453699602;
			}
		}
	}
}
