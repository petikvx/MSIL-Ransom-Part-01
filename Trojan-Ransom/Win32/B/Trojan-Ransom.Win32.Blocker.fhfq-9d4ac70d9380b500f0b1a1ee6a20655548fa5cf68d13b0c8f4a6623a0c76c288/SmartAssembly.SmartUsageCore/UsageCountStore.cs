using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace SmartAssembly.SmartUsageCore;

public static class UsageCountStore
{
	private sealed class DisposableMutex : IDisposable
	{
		private static readonly CultureInfo s_EnUSCulture = CultureInfo.GetCultureInfo("en-US");

		private readonly CultureInfo m_OldCultureInfo;

		private readonly Mutex m_Mutex;

		public DisposableMutex(string mutexName)
		{
			m_OldCultureInfo = Thread.CurrentThread.CurrentUICulture;
			Thread.CurrentThread.CurrentUICulture = s_EnUSCulture;
			if (mutexName.Length > 260)
			{
				mutexName = mutexName.Remove(261);
			}
			mutexName = mutexName.Replace(Path.DirectorySeparatorChar, '_');
			m_Mutex = new Mutex(initiallyOwned: false, mutexName);
			try
			{
				m_Mutex.WaitOne();
			}
			catch (AbandonedMutexException)
			{
			}
		}

		public void Dispose()
		{
			m_Mutex.ReleaseMutex();
			m_Mutex.Close();
			Thread.CurrentThread.CurrentUICulture = m_OldCultureInfo;
		}
	}

	private const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private static readonly string s_BuildHash;

	private static readonly string s_UsageFile;

	private static readonly string s_DynamicUsageFolder;

	private static readonly string s_UsageFileLock;

	private static readonly IsolatedStorageFile s_IsolatedStorage;

	private static readonly Encoding s_Encoding;

	private static readonly HashAlgorithm s_Hash;

	static UsageCountStore()
	{
		s_BuildHash = "{078128F1-08BA-4062-ABCE-8AFA40CA4995}".Substring(1, 8);
		s_UsageFile = Path.Combine(s_BuildHash, "Usages.bin");
		s_DynamicUsageFolder = Path.Combine(s_BuildHash, "D");
		s_UsageFileLock = Path.Combine(s_BuildHash, "l");
		s_Encoding = Encoding.UTF8;
		s_Hash = new MD5CryptoServiceProvider();
		s_IsolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();
		s_IsolatedStorage.CreateDirectory(s_BuildHash);
		s_IsolatedStorage.CreateDirectory(s_DynamicUsageFolder);
	}

	private static IDisposable GetGlobalUsageCountFileLock()
	{
		return new DisposableMutex(s_UsageFileLock);
	}

	private static IsolatedStorageFileStream TryOpenLockFile()
	{
		try
		{
			IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(s_UsageFileLock, FileMode.Create, FileAccess.Read, FileShare.None);
			byte[] bytes = Encoding.UTF8.GetBytes(Process.GetCurrentProcess().Id.ToString());
			isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
			return isolatedStorageFileStream;
		}
		catch (IOException)
		{
			return null;
		}
	}

	private static IsolatedStorageFileStream OpenIsolatedFile(string relativeFile, FileMode mode, FileAccess access)
	{
		return new IsolatedStorageFileStream(relativeFile, mode, access, FileShare.None, s_IsolatedStorage);
	}

	private static void DeleteIsolatedFile(string relativeFile)
	{
		try
		{
			s_IsolatedStorage.DeleteFile(relativeFile);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	private static void IncrementCount(string usageFile, long countPosition)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = OpenIsolatedFile(usageFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
		isolatedStorageFileStream.Position = countPosition + 8L;
		isolatedStorageFileStream.Position = countPosition;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = countPosition;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	public static void IncrementUsage(uint featureId)
	{
		IDisposable disposable = null;
		try
		{
			disposable = GetGlobalUsageCountFileLock();
			IncrementCount(s_UsageFile, featureId * 8);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static string GetDynamicFeatureUsageFilename(string featureName)
	{
		byte[] bytes = s_Encoding.GetBytes(featureName);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = s_Hash.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(s_DynamicUsageFolder, path);
			text = text2 + ".bin";
			string relativeFile = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = OpenIsolatedFile(relativeFile, FileMode.CreateNew, FileAccess.Write);
				isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
			}
			catch (IOException)
			{
			}
			finally
			{
				isolatedStorageFileStream?.Close();
			}
		}
		else
		{
			text = Path.Combine(s_DynamicUsageFolder, text + ".bin");
		}
		return text;
	}

	public static void IncrementUsage(string featureName)
	{
		IDisposable disposable = null;
		try
		{
			disposable = GetGlobalUsageCountFileLock();
			string dynamicFeatureUsageFilename = GetDynamicFeatureUsageFilename(featureName);
			IncrementCount(dynamicFeatureUsageFilename, 0L);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static ulong[] GetUsageCountsFromFile(string fileName)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, s_IsolatedStorage))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	public static UsageCounts GetAllUsageCountsAndReset()
	{
		using (GetGlobalUsageCountFileLock())
		{
			UsageCounts result = UnprotectedGetAllUsageCounts();
			UnprotectedReset();
			return result;
		}
	}

	public static UsageCounts GetAllUsageCounts()
	{
		using (GetGlobalUsageCountFileLock())
		{
			return UnprotectedGetAllUsageCounts();
		}
	}

	public static void Reset()
	{
		using (GetGlobalUsageCountFileLock())
		{
			UnprotectedReset();
		}
	}

	private static UsageCounts UnprotectedGetAllUsageCounts()
	{
		ulong[] usageCountsFromFile = GetUsageCountsFromFile(s_UsageFile);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = s_IsolatedStorage.GetFileNames(s_DynamicUsageFolder + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string fileName = Path.Combine(s_DynamicUsageFolder, text);
				ulong[] usageCountsFromFile2 = GetUsageCountsFromFile(fileName);
				string relativeFile = Path.Combine(s_DynamicUsageFolder, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = OpenIsolatedFile(relativeFile, FileMode.Open, FileAccess.Read);
					byte[] array = new byte[isolatedStorageFileStream.Length];
					isolatedStorageFileStream.Read(array, 0, array.Length);
					text2 = s_Encoding.GetString(array);
				}
				catch (FileNotFoundException)
				{
					text2 = s_Encoding.GetString(Convert.FromBase64String(text2.Replace('@', '\\')));
				}
				finally
				{
					isolatedStorageFileStream?.Close();
				}
				dictionary[text2] = usageCountsFromFile2[0];
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		return new UsageCounts(usageCountsFromFile, dictionary);
	}

	private static void UnprotectedReset()
	{
		DeleteIsolatedFile(s_UsageFile);
		try
		{
			string[] fileNames = s_IsolatedStorage.GetFileNames(s_DynamicUsageFolder + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string relativeFile = Path.Combine(s_DynamicUsageFolder, text);
				DeleteIsolatedFile(relativeFile);
				string relativeFile2 = Path.Combine(s_DynamicUsageFolder, fileNameWithoutExtension + ".txt");
				DeleteIsolatedFile(relativeFile2);
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		try
		{
			s_IsolatedStorage.DeleteDirectory(s_DynamicUsageFolder);
		}
		catch (IsolatedStorageException)
		{
		}
		s_IsolatedStorage.CreateDirectory(s_DynamicUsageFolder);
	}
}
