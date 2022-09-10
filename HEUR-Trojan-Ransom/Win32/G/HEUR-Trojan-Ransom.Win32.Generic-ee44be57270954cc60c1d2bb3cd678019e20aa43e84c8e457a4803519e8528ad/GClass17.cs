using System.IO;

public sealed class GClass17 : GClass0
{
	private string string_2;

	public new string String_0 => string_2;

	internal GClass17(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = method_1(ref memoryStream_0);
		string_0 = "text: " + string_2;
	}
}
