using System.IO;

internal sealed class Class55
{
	public static Class54 smethod_0(string string_0, string string_1)
	{
		if (!File.Exists(string_0))
		{
			return null;
		}
		string text = Path.GetTempFileName() + ".dat";
		File.Copy(string_0, text);
		Class54 @class = new Class54(text);
		@class.method_4(string_1);
		File.Delete(text);
		if (@class.method_1() == 65536)
		{
			return null;
		}
		return @class;
	}
}
