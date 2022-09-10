using System;
using System.IO;

namespace FC2ServerLauncher;

internal class CUtils
{
	public static string GetFarCry2PersonalFolder()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		folderPath += "\\My Games\\Far Cry 2";
		Directory.CreateDirectory(folderPath);
		return folderPath;
	}

	public static string GetFarCry2PersonalServerFolder()
	{
		string farCry2PersonalFolder = GetFarCry2PersonalFolder();
		farCry2PersonalFolder += "\\Server";
		Directory.CreateDirectory(farCry2PersonalFolder);
		return farCry2PersonalFolder;
	}

	public static string GetFarCry2PersonalUserMapsFolder()
	{
		string farCry2PersonalFolder = GetFarCry2PersonalFolder();
		farCry2PersonalFolder += "\\User Maps\\";
		Directory.CreateDirectory(farCry2PersonalFolder);
		return farCry2PersonalFolder;
	}

	public static string GetFarCry2PersonalLogsFolder()
	{
		string farCry2PersonalServerFolder = GetFarCry2PersonalServerFolder();
		farCry2PersonalServerFolder += "\\Logs\\";
		Directory.CreateDirectory(farCry2PersonalServerFolder);
		return farCry2PersonalServerFolder;
	}

	public static string GetMapExtension()
	{
		return "fc2map";
	}
}
