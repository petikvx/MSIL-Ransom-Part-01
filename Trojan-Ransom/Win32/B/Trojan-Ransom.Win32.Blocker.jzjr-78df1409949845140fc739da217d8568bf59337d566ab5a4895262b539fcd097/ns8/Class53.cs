using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns7;

namespace ns8;

internal static class Class53
{
	private sealed class Class54 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");

		private readonly CultureInfo cultureInfo_1;

		private readonly Mutex mutex_0;

		public Class54(string mutexName)
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

		void IDisposable.Dispose()
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

	static Class53()
	{
		string_1 = "{CA3D9371-DEE3-452C-95B3-67B91E478690}".Substring(1, 8);
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
		return new Class54(string_4);
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

	private static IsolatedStorageFileStream smethod_2(string string_5, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new IsolatedStorageFileStream(string_5, fileMode_0, fileAccess_0, FileShare.None, isolatedStorageFile_0);
	}

	private static void smethod_3(string string_5)
	{
		try
		{
			isolatedStorageFile_0.DeleteFile(string_5);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	private static void smethod_4(string string_5, long long_0)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = smethod_2(string_5, FileMode.OpenOrCreate, FileAccess.ReadWrite);
		isolatedStorageFileStream.Position = long_0 + 8L;
		isolatedStorageFileStream.Position = long_0;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = long_0;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	public static void smethod_5(uint uint_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			smethod_4(string_2, uint_0 * 8);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static string smethod_6(string string_5)
	{
		byte[] bytes = encoding_0.GetBytes(string_5);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = hashAlgorithm_0.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(string_3, path);
			text = text2 + ".bin";
			string string_6 = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = smethod_2(string_6, FileMode.CreateNew, FileAccess.Write);
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

	public static void smethod_7(string string_5)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			string string_6 = smethod_6(string_5);
			smethod_4(string_6, 0L);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static ulong[] smethod_8(string string_5)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_5, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, isolatedStorageFile_0))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	public static Class52 smethod_9()
	{
		using (smethod_0())
		{
			Class52 result = smethod_12();
			smethod_13();
			return result;
		}
	}

	public static Class52 smethod_10()
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

	private static Class52 smethod_12()
	{
		ulong[] staticFeatureCounts = smethod_8(Class53.string_2);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(string_3 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(string_3, text);
				ulong[] array = smethod_8(string_);
				string string_2 = Path.Combine(string_3, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_2(string_2, FileMode.Open, FileAccess.Read);
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
		return new Class52(staticFeatureCounts, dictionary);
	}

	private static void smethod_13()
	{
		smethod_3(Class53.string_2);
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(string_3 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(string_3, text);
				smethod_3(string_);
				string string_2 = Path.Combine(string_3, fileNameWithoutExtension + ".txt");
				smethod_3(string_2);
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
