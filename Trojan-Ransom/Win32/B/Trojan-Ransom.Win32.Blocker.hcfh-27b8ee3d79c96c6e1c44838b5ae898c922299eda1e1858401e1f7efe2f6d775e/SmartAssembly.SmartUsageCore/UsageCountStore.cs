using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public static class UsageCountStore
{
	private sealed class DisposableMutex : IDisposable
	{
		private static readonly CultureInfo s_EnUSCulture;

		private readonly CultureInfo m_OldCultureInfo;

		private readonly Mutex m_Mutex;

		public DisposableMutex(string mutexName)
		{
			try
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
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, mutexName);
				throw;
			}
		}

		public void Dispose()
		{
			try
			{
				m_Mutex.ReleaseMutex();
				m_Mutex.Close();
				Thread.CurrentThread.CurrentUICulture = m_OldCultureInfo;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static DisposableMutex()
		{
			try
			{
				s_EnUSCulture = CultureInfo.GetCultureInfo("en-US");
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
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
		try
		{
			s_BuildHash = "{033897BF-7A25-4E84-A557-884D8EA9E0D8}".Substring(1, 8);
			s_UsageFile = Path.Combine(s_BuildHash, "Usages.bin");
			s_DynamicUsageFolder = Path.Combine(s_BuildHash, "D");
			s_UsageFileLock = Path.Combine(s_BuildHash, "l");
			s_Encoding = Encoding.UTF8;
			s_Hash = new MD5CryptoServiceProvider();
			s_IsolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();
			s_IsolatedStorage.CreateDirectory(s_BuildHash);
			s_IsolatedStorage.CreateDirectory(s_DynamicUsageFolder);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static IDisposable GetGlobalUsageCountFileLock()
	{
		try
		{
			return new DisposableMutex(s_UsageFileLock);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static IsolatedStorageFileStream TryOpenLockFile()
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		int id = default(int);
		byte[] bytes = default(byte[]);
		IsolatedStorageFileStream isolatedStorageFileStream2 = default(IsolatedStorageFileStream);
		try
		{
			try
			{
				isolatedStorageFileStream = new IsolatedStorageFileStream(s_UsageFileLock, FileMode.Create, FileAccess.Read, FileShare.None);
				Encoding uTF = Encoding.UTF8;
				id = Process.GetCurrentProcess().Id;
				bytes = uTF.GetBytes(id.ToString());
				isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
				isolatedStorageFileStream2 = isolatedStorageFileStream;
				return isolatedStorageFileStream2;
			}
			catch (IOException)
			{
				isolatedStorageFileStream2 = null;
				return isolatedStorageFileStream2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, isolatedStorageFileStream, bytes, isolatedStorageFileStream2, id);
			throw;
		}
	}

	private static IsolatedStorageFileStream OpenIsolatedFile(string relativeFile, FileMode mode, FileAccess access)
	{
		try
		{
			return new IsolatedStorageFileStream(relativeFile, mode, access, FileShare.None, s_IsolatedStorage);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, relativeFile, mode, access);
			throw;
		}
	}

	private static void DeleteIsolatedFile(string relativeFile)
	{
		try
		{
			try
			{
				s_IsolatedStorage.DeleteFile(relativeFile);
			}
			catch (IsolatedStorageException)
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, relativeFile);
			throw;
		}
	}

	private static void IncrementCount(string usageFile, long countPosition)
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		ulong num = default(ulong);
		try
		{
			isolatedStorageFileStream = OpenIsolatedFile(usageFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			try
			{
				isolatedStorageFileStream.Position = countPosition + 8L;
				isolatedStorageFileStream.Position = countPosition;
				num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
				num++;
				isolatedStorageFileStream.Position = countPosition;
				new BinaryWriter(isolatedStorageFileStream).Write(num);
			}
			finally
			{
				((IDisposable)isolatedStorageFileStream)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, isolatedStorageFileStream, num, usageFile, countPosition);
			throw;
		}
	}

	public static void IncrementUsage(uint featureId)
	{
		IDisposable disposable = default(IDisposable);
		try
		{
			disposable = null;
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, disposable, featureId);
			throw;
		}
	}

	private static string GetDynamicFeatureUsageFilename(string featureName)
	{
		byte[] bytes = default(byte[]);
		string text = default(string);
		byte[] array = default(byte[]);
		Guid guid = default(Guid);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		try
		{
			bytes = s_Encoding.GetBytes(featureName);
			text = Convert.ToBase64String(bytes).Replace('\\', '@');
			if (text.Length > 50)
			{
				array = s_Hash.ComputeHash(bytes);
				guid = new Guid(array);
				text2 = guid.ToString().Substring(0, 18);
				text3 = Path.Combine(s_DynamicUsageFolder, text2);
				text = text3 + ".bin";
				text4 = text3 + ".txt";
				isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = OpenIsolatedFile(text4, FileMode.CreateNew, FileAccess.Write);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, bytes, text, array, text2, text3, text4, isolatedStorageFileStream, guid, featureName);
			throw;
		}
	}

	public static void IncrementUsage(string featureName)
	{
		IDisposable disposable = default(IDisposable);
		string dynamicFeatureUsageFilename = default(string);
		try
		{
			disposable = null;
			try
			{
				disposable = GetGlobalUsageCountFileLock();
				dynamicFeatureUsageFilename = GetDynamicFeatureUsageFilename(featureName);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, disposable, dynamicFeatureUsageFilename, featureName);
			throw;
		}
	}

	private static ulong[] GetUsageCountsFromFile(string fileName)
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		byte[] array = default(byte[]);
		ulong[] array2 = default(ulong[]);
		try
		{
			isolatedStorageFileStream = new IsolatedStorageFileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, s_IsolatedStorage);
			try
			{
				array = new byte[isolatedStorageFileStream.Length];
				isolatedStorageFileStream.Read(array, 0, array.Length);
				array2 = new ulong[array.Length / 8];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			}
			finally
			{
				((IDisposable)isolatedStorageFileStream)?.Dispose();
			}
			return array2;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, array2, isolatedStorageFileStream, array, fileName);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCountsAndReset()
	{
		IDisposable globalUsageCountFileLock = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		UsageCounts usageCounts2 = default(UsageCounts);
		try
		{
			globalUsageCountFileLock = GetGlobalUsageCountFileLock();
			try
			{
				usageCounts = UnprotectedGetAllUsageCounts();
				UnprotectedReset();
				usageCounts2 = usageCounts;
				return usageCounts2;
			}
			finally
			{
				globalUsageCountFileLock?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, usageCounts, usageCounts2, globalUsageCountFileLock);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCounts()
	{
		IDisposable globalUsageCountFileLock = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		try
		{
			globalUsageCountFileLock = GetGlobalUsageCountFileLock();
			try
			{
				usageCounts = UnprotectedGetAllUsageCounts();
				return usageCounts;
			}
			finally
			{
				globalUsageCountFileLock?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageCounts, globalUsageCountFileLock);
			throw;
		}
	}

	public static void Reset()
	{
		IDisposable globalUsageCountFileLock = default(IDisposable);
		try
		{
			globalUsageCountFileLock = GetGlobalUsageCountFileLock();
			try
			{
				UnprotectedReset();
			}
			finally
			{
				globalUsageCountFileLock?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, globalUsageCountFileLock);
			throw;
		}
	}

	private static UsageCounts UnprotectedGetAllUsageCounts()
	{
		ulong[] usageCountsFromFile = default(ulong[]);
		Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
		string[] fileNames = default(string[]);
		int i = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		ulong[] usageCountsFromFile2 = default(ulong[]);
		string text4 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		byte[] array = default(byte[]);
		try
		{
			usageCountsFromFile = GetUsageCountsFromFile(s_UsageFile);
			dictionary = new Dictionary<string, ulong>();
			try
			{
				fileNames = s_IsolatedStorage.GetFileNames(s_DynamicUsageFolder + "\\*.bin");
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					text2 = Path.GetFileNameWithoutExtension(text);
					text3 = Path.Combine(s_DynamicUsageFolder, text);
					usageCountsFromFile2 = GetUsageCountsFromFile(text3);
					text4 = Path.Combine(s_DynamicUsageFolder, text2 + ".txt");
					isolatedStorageFileStream = null;
					try
					{
						isolatedStorageFileStream = OpenIsolatedFile(text4, FileMode.Open, FileAccess.Read);
						array = new byte[isolatedStorageFileStream.Length];
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
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				usageCountsFromFile, dictionary, text, text2, text3, usageCountsFromFile2, text4, isolatedStorageFileStream, array, fileNames,
				i
			});
			throw;
		}
	}

	private static void UnprotectedReset()
	{
		string[] fileNames = default(string[]);
		int i = default(int);
		string text = default(string);
		string fileNameWithoutExtension = default(string);
		string text2 = default(string);
		string text3 = default(string);
		try
		{
			DeleteIsolatedFile(s_UsageFile);
			try
			{
				fileNames = s_IsolatedStorage.GetFileNames(s_DynamicUsageFolder + "\\*.bin");
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					text2 = Path.Combine(s_DynamicUsageFolder, text);
					DeleteIsolatedFile(text2);
					text3 = Path.Combine(s_DynamicUsageFolder, fileNameWithoutExtension + ".txt");
					DeleteIsolatedFile(text3);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, text, fileNameWithoutExtension, text2, text3, fileNames, i);
			throw;
		}
	}
}
