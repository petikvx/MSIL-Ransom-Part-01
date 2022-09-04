using System;
using System.Collections.Generic;
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
	private sealed class Class33 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0;

		private readonly CultureInfo cultureInfo_1;

		internal Mutex mutex_0;

		public Class33(string string_0)
		{
			try
			{
				cultureInfo_1 = Thread.CurrentThread.CurrentUICulture;
				Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
				if (string_0.Length > 260)
				{
					string_0 = string_0.Remove(261);
				}
				string_0 = string_0.Replace(Path.DirectorySeparatorChar, '_');
				Mutex mutex = (mutex_0 = new Mutex(initiallyOwned: false, string_0));
				try
				{
					mutex_0.WaitOne();
				}
				catch (AbandonedMutexException)
				{
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, string_0);
				throw;
			}
		}

		public void Dispose()
		{
			try
			{
				mutex_0.ReleaseMutex();
				mutex_0.Close();
				Thread.CurrentThread.CurrentUICulture = cultureInfo_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class33()
		{
			try
			{
				cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly IsolatedStorageFile isolatedStorageFile_0;

	private static readonly Encoding encoding_0;

	private static readonly HashAlgorithm hashAlgorithm_0;

	static UsageCountStore()
	{
		try
		{
			string_0 = "{5073F953-287E-4137-ADF6-D4C5C7821FA6}".Substring(1, 8);
			string_1 = Path.Combine(string_0, "Usages.bin");
			string_2 = Path.Combine(string_0, "D");
			string_3 = Path.Combine(string_0, "l");
			encoding_0 = Encoding.UTF8;
			hashAlgorithm_0 = new MD5CryptoServiceProvider();
			isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
			isolatedStorageFile_0.CreateDirectory(string_0);
			isolatedStorageFile_0.CreateDirectory(string_2);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static IDisposable smethod_0()
	{
		try
		{
			return new Class33(string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static IsolatedStorageFileStream smethod_1(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		try
		{
			return new IsolatedStorageFileStream(string_4, fileMode_0, fileAccess_0, FileShare.None, isolatedStorageFile_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, string_4, fileMode_0, fileAccess_0);
			throw;
		}
	}

	private static void smethod_2(string string_4)
	{
		try
		{
			try
			{
				isolatedStorageFile_0.DeleteFile(string_4);
			}
			catch (IsolatedStorageException)
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, string_4);
			throw;
		}
	}

	private static void smethod_3(string string_4, long long_0)
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		ulong num = default(ulong);
		try
		{
			isolatedStorageFileStream = smethod_1(string_4, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			try
			{
				isolatedStorageFileStream.Position = long_0 + 8L;
				isolatedStorageFileStream.Position = long_0;
				num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
				num++;
				isolatedStorageFileStream.Position = long_0;
				new BinaryWriter(isolatedStorageFileStream).Write(num);
			}
			finally
			{
				((IDisposable)isolatedStorageFileStream)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, isolatedStorageFileStream, num, string_4, long_0);
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
				disposable = smethod_0();
				smethod_3(string_1, featureId * 8);
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

	private static string smethod_4(string string_4)
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
			bytes = encoding_0.GetBytes(string_4);
			text = Convert.ToBase64String(bytes).Replace('\\', '@');
			if (text.Length > 50)
			{
				array = hashAlgorithm_0.ComputeHash(bytes);
				guid = new Guid(array);
				text2 = guid.ToString().Substring(0, 18);
				text3 = Path.Combine(string_2, text2);
				text = text3 + ".bin";
				text4 = text3 + ".txt";
				isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_1(text4, FileMode.CreateNew, FileAccess.Write);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, bytes, text, array, text2, text3, text4, isolatedStorageFileStream, guid, string_4);
			throw;
		}
	}

	public static void IncrementUsage(string featureName)
	{
		IDisposable disposable = default(IDisposable);
		string text = default(string);
		try
		{
			disposable = null;
			try
			{
				disposable = smethod_0();
				text = smethod_4(featureName);
				smethod_3(text, 0L);
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
			StackFrameHelper.CreateException3(exception, disposable, text, featureName);
			throw;
		}
	}

	private static ulong[] smethod_5(string string_4)
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		byte[] array = default(byte[]);
		ulong[] array2 = default(ulong[]);
		try
		{
			isolatedStorageFileStream = new IsolatedStorageFileStream(string_4, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, isolatedStorageFile_0);
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
			StackFrameHelper.CreateException4(exception, array2, isolatedStorageFileStream, array, string_4);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCountsAndReset()
	{
		IDisposable disposable = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		UsageCounts usageCounts2 = default(UsageCounts);
		try
		{
			disposable = smethod_0();
			try
			{
				usageCounts = smethod_6();
				smethod_7();
				usageCounts2 = usageCounts;
				return usageCounts2;
			}
			finally
			{
				disposable?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, usageCounts, usageCounts2, disposable);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCounts()
	{
		IDisposable disposable = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		try
		{
			disposable = smethod_0();
			try
			{
				usageCounts = smethod_6();
				return usageCounts;
			}
			finally
			{
				disposable?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageCounts, disposable);
			throw;
		}
	}

	public static void Reset()
	{
		IDisposable disposable = default(IDisposable);
		try
		{
			disposable = smethod_0();
			try
			{
				smethod_7();
			}
			finally
			{
				disposable?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, disposable);
			throw;
		}
	}

	private static UsageCounts smethod_6()
	{
		ulong[] array = default(ulong[]);
		Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
		string[] fileNames = default(string[]);
		int i = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		ulong[] array2 = default(ulong[]);
		string text4 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		byte[] array3 = default(byte[]);
		try
		{
			array = smethod_5(string_1);
			dictionary = new Dictionary<string, ulong>();
			try
			{
				fileNames = isolatedStorageFile_0.GetFileNames(string_2 + "\\*.bin");
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					text2 = Path.GetFileNameWithoutExtension(text);
					text3 = Path.Combine(string_2, text);
					array2 = smethod_5(text3);
					text4 = Path.Combine(string_2, text2 + ".txt");
					isolatedStorageFileStream = null;
					try
					{
						isolatedStorageFileStream = smethod_1(text4, FileMode.Open, FileAccess.Read);
						array3 = new byte[isolatedStorageFileStream.Length];
						isolatedStorageFileStream.Read(array3, 0, array3.Length);
						text2 = encoding_0.GetString(array3);
					}
					catch (FileNotFoundException)
					{
						text2 = encoding_0.GetString(Convert.FromBase64String(text2.Replace('@', '\\')));
					}
					finally
					{
						isolatedStorageFileStream?.Close();
					}
					dictionary[text2] = array2[0];
				}
			}
			catch (DirectoryNotFoundException)
			{
			}
			return new UsageCounts(array, dictionary);
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				array, dictionary, text, text2, text3, array2, text4, isolatedStorageFileStream, array3, fileNames,
				i
			});
			throw;
		}
	}

	private static void smethod_7()
	{
		string[] fileNames = default(string[]);
		int i = default(int);
		string text = default(string);
		string fileNameWithoutExtension = default(string);
		string text2 = default(string);
		string text3 = default(string);
		try
		{
			smethod_2(string_1);
			try
			{
				fileNames = isolatedStorageFile_0.GetFileNames(string_2 + "\\*.bin");
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					text2 = Path.Combine(string_2, text);
					smethod_2(text2);
					text3 = Path.Combine(string_2, fileNameWithoutExtension + ".txt");
					smethod_2(text3);
				}
			}
			catch (DirectoryNotFoundException)
			{
			}
			try
			{
				isolatedStorageFile_0.DeleteDirectory(string_2);
			}
			catch (IsolatedStorageException)
			{
			}
			isolatedStorageFile_0.CreateDirectory(string_2);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, text, fileNameWithoutExtension, text2, text3, fileNames, i);
			throw;
		}
	}
}
