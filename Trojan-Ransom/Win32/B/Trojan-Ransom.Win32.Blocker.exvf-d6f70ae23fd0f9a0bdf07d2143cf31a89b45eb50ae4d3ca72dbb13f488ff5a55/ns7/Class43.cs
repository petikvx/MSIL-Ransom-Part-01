using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns9;

namespace ns7;

internal static class Class43
{
	private sealed class Class44 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");

		private readonly CultureInfo cultureInfo_1;

		private readonly Mutex mutex_0;

		public Class44(string string_0)
		{
			cultureInfo_1 = Thread.CurrentThread.CurrentUICulture;
			Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
			if (string_0.Length > 260)
			{
				string_0 = string_0.Remove(261);
			}
			string_0 = string_0.Replace(Path.DirectorySeparatorChar, '_');
			mutex_0 = new Mutex(initiallyOwned: false, string_0);
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

	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly IsolatedStorageFile isolatedStorageFile_0;

	private static readonly Encoding encoding_0;

	private static readonly HashAlgorithm hashAlgorithm_0;

	static Class43()
	{
		string_0 = "{B947E357-A1C3-4DEF-A636-1EFF4DE22A3B}".Substring(1, 8);
		string_1 = Path.Combine(string_0, "Usages.bin");
		string_2 = Path.Combine(string_0, "D");
		string_3 = Path.Combine(string_0, "l");
		encoding_0 = Encoding.UTF8;
		hashAlgorithm_0 = new MD5CryptoServiceProvider();
		isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		isolatedStorageFile_0.CreateDirectory(string_0);
		isolatedStorageFile_0.CreateDirectory(string_2);
	}

	private static IDisposable smethod_0()
	{
		return new Class44(string_3);
	}

	private static IsolatedStorageFileStream smethod_1(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new IsolatedStorageFileStream(string_4, fileMode_0, fileAccess_0, FileShare.None, isolatedStorageFile_0);
	}

	private static void smethod_2(string string_4)
	{
		try
		{
			isolatedStorageFile_0.DeleteFile(string_4);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	private static void smethod_3(string string_4, long long_0)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = smethod_1(string_4, FileMode.OpenOrCreate, FileAccess.ReadWrite);
		isolatedStorageFileStream.Position = long_0 + 8L;
		isolatedStorageFileStream.Position = long_0;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = long_0;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	public static void smethod_4(uint uint_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			smethod_3(string_1, uint_0 * 8);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static string smethod_5(string string_4)
	{
		byte[] bytes = encoding_0.GetBytes(string_4);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = hashAlgorithm_0.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(string_2, path);
			text = text2 + ".bin";
			string string_5 = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = smethod_1(string_5, FileMode.CreateNew, FileAccess.Write);
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
			text = Path.Combine(string_2, text + ".bin");
		}
		return text;
	}

	public static void smethod_6(string string_4)
	{
		IDisposable disposable = null;
		try
		{
			disposable = smethod_0();
			string string_5 = smethod_5(string_4);
			smethod_3(string_5, 0L);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	private static ulong[] smethod_7(string string_4)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_4, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, isolatedStorageFile_0))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	public static Class42 smethod_8()
	{
		using (smethod_0())
		{
			Class42 result = smethod_11();
			smethod_12();
			return result;
		}
	}

	public static Class42 smethod_9()
	{
		using (smethod_0())
		{
			return smethod_11();
		}
	}

	public static void smethod_10()
	{
		using (smethod_0())
		{
			smethod_12();
		}
	}

	private static Class42 smethod_11()
	{
		ulong[] ulong_ = smethod_7(string_1);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(Class43.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class43.string_2, text);
				ulong[] array = smethod_7(string_);
				string string_2 = Path.Combine(Class43.string_2, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_1(string_2, FileMode.Open, FileAccess.Read);
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
		return new Class42(ulong_, dictionary);
	}

	private static void smethod_12()
	{
		smethod_2(string_1);
		try
		{
			string[] fileNames = isolatedStorageFile_0.GetFileNames(Class43.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class43.string_2, text);
				smethod_2(string_);
				string string_2 = Path.Combine(Class43.string_2, fileNameWithoutExtension + ".txt");
				smethod_2(string_2);
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		try
		{
			isolatedStorageFile_0.DeleteDirectory(Class43.string_2);
		}
		catch (IsolatedStorageException)
		{
		}
		isolatedStorageFile_0.CreateDirectory(Class43.string_2);
	}
}
