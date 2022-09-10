using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns3;

namespace ns4;

internal static class Class49
{
	private sealed class Class50 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");

		private readonly CultureInfo cultureInfo_1;

		private readonly Mutex mutex_0;

		public Class50(string mutexName)
		{
			cultureInfo_1 = Thread.CurrentThread.CurrentUICulture;
			Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
			if (mutexName.Length > 260)
			{
				mutexName = mutexName.Remove(261);
			}
			mutexName = mutexName.Replace(Path.DirectorySeparatorChar, '_');
			mutex_0 = new Mutex(initiallyOwned: false, mutexName);
			try
			{
				mutex_0.WaitOne();
			}
			catch (AbandonedMutexException)
			{
			}
		}

		public void Dispose()
		{
			mutex_0.ReleaseMutex();
			mutex_0.Close();
			Thread.CurrentThread.CurrentUICulture = cultureInfo_1;
		}
	}

	private const string string_0 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly string string_4;

	private static readonly IsolatedStorageFile isolatedStorageFile_0;

	private static readonly Encoding encoding_0;

	private static readonly HashAlgorithm hashAlgorithm_0;

	static Class49()
	{
		string_1 = "{F0C71864-193B-4207-B969-A15E8EDFFBBB}".Substring(1, 8);
		string_2 = Path.Combine(string_1, "Usages.bin");
		string_3 = Path.Combine(string_1, "D");
		string_4 = Path.Combine(string_1, "l");
		encoding_0 = Encoding.UTF8;
		hashAlgorithm_0 = new MD5CryptoServiceProvider();
		isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		isolatedStorageFile_0.CreateDirectory(string_1);
		isolatedStorageFile_0.CreateDirectory(string_3);
	}

	private static IDisposable smethod_0()
	{
		return new Class50(string_4);
	}

	private static IsolatedStorageFileStream smethod_1()
	{
		try
		{
			IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_4, FileMode.Create, FileAccess.Read, FileShare.None);
			byte[] bytes = Encoding.UTF8.GetBytes(Process.GetCurrentProcess().Id.ToString());
			isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
			return isolatedStorageFileStream;
		}
		catch (IOException)
		{
			return null;
		}
	}

	private static IsolatedStorageFileStream smethod_2(string relativeFile, FileMode mode, FileAccess access)
	{
		return new IsolatedStorageFileStream(relativeFile, mode, access, FileShare.None, isolatedStorageFile_0);
	}

	private static void smethod_3(string relativeFile)
	{
		try
		{
			isolatedStorageFile_0.DeleteFile(relativeFile);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	private static void smethod_4(string usageFile, long countPosition)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = smethod_2(usageFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
		isolatedStorageFileStream.Position = countPosition + 8L;
		isolatedStorageFileStream.Position = countPosition;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = countPosition;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	public static void smethod_5(uint featureId)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			smethod_4(string_2, featureId * 8);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static string smethod_6(string featureName)
	{
		byte[] bytes = encoding_0.GetBytes(featureName);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = hashAlgorithm_0.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(string_3, path);
			text = text2 + ".bin";
			string relativeFile = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = smethod_2(relativeFile, FileMode.CreateNew, FileAccess.Write);
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
			text = Path.Combine(string_3, text + ".bin");
		}
		return text;
	}

	public static void smethod_7(string featureName)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			string usageFile = smethod_6(featureName);
			smethod_4(usageFile, 0L);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static ulong[] smethod_8(string fileName)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, isolatedStorageFile_0))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	public static Class48 smethod_9()
	{
		using (smethod_0())
		{
			Class48 result = smethod_12();
			smethod_13();
			return result;
		}
	}

	public static Class48 smethod_10()
	{
		using (smethod_0())
		{
			return smethod_12();
		}
	}

	public static void smethod_11()
	{
		using (smethod_0())
		{
			smethod_13();
		}
	}

	private static Class48 smethod_12()
	{
		ulong[] staticFeatureCounts = smethod_8(string_2);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(string_3 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string fileName = Path.Combine(string_3, text);
				ulong[] array = smethod_8(fileName);
				string relativeFile = Path.Combine(string_3, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_2(relativeFile, FileMode.Open, FileAccess.Read);
					byte[] array2 = new byte[isolatedStorageFileStream.Length];
					isolatedStorageFileStream.Read(array2, 0, array2.Length);
					text2 = encoding_0.GetString(array2);
				}
				catch (FileNotFoundException)
				{
					text2 = encoding_0.GetString(Convert.FromBase64String(text2.Replace('@', '\\')));
				}
				finally
				{
					isolatedStorageFileStream?.Close();
				}
				dictionary[text2] = array[0];
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		return new Class48(staticFeatureCounts, dictionary);
	}

	private static void smethod_13()
	{
		smethod_3(string_2);
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(string_3 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string relativeFile = Path.Combine(string_3, text);
				smethod_3(relativeFile);
				string relativeFile2 = Path.Combine(string_3, fileNameWithoutExtension + ".txt");
				smethod_3(relativeFile2);
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		try
		{
			isolatedStorageFile_0.DeleteDirectory(string_3);
		}
		catch (IsolatedStorageException)
		{
		}
		isolatedStorageFile_0.CreateDirectory(string_3);
	}
}
