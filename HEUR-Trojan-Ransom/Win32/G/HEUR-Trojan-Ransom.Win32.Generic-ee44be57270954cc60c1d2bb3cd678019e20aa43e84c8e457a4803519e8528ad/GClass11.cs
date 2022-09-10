using System.IO;

public sealed class GClass11 : GClass0
{
	private string string_2;

	private string string_3;

	public new string String_0 => string_2;

	public new string String_1 => string_3;

	internal GClass11(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = method_1(ref memoryStream_0);
		string_3 = method_1(ref memoryStream_0);
		string_0 = "CPU: " + string_2 + ", OS: " + string_3;
	}
}
