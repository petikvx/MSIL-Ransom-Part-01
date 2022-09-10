using System.IO;

public sealed class GClass7 : GClass0, GInterface0
{
	private string string_2;

	public new string String_0 => string_2;

	internal GClass7(GClass24 gclass24_1)
		: base(gclass24_1)
	{
	}

	public override void imethod_0(ref MemoryStream memoryStream_0)
	{
		string_2 = memoryStream_0.ReadByte() + "." + memoryStream_0.ReadByte() + "." + memoryStream_0.ReadByte() + "." + memoryStream_0.ReadByte();
		string_0 = "Address: " + string_2;
	}
}
