using System;
using System.IO;
using System.Threading;

namespace PHP_Bot.RS.Bots;

internal class Nexus
{
	private string dir;

	public bool isDone = false;

	public string GetDirectory => dir;

	public bool UsesNexus => File.Exists(dir);

	public Nexus()
	{
		Thread thread = new Thread(FileFinder);
		thread.Start();
	}

	private void FileFinder()
	{
		Search(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		Search(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		Search(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		isDone = true;
	}

	private void Search(string pathName)
	{
		try
		{
			string[] files = Directory.GetFiles(pathName);
			string[] array = files;
			foreach (string text in array)
			{
				if (text.Replace("\\", "/").EndsWith("config/data.db"))
				{
					dir = text;
				}
			}
			string[] directories = Directory.GetDirectories(pathName);
			array = directories;
			foreach (string pathName2 in array)
			{
				Search(pathName2);
			}
		}
		catch
		{
		}
	}
}
