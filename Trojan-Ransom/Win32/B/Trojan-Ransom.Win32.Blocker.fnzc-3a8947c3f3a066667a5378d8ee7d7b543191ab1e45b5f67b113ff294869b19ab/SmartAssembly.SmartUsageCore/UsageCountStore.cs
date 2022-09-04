using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ExampleApp;
using SmartAssembly.Attributes;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public static class UsageCountStore
{
	private sealed class Class36 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0;

		internal CultureInfo cultureInfo_1;

		internal Mutex mutex_0;

		public Class36(string string_0)
		{
			try
			{
				CultureInfo cultureInfo = (cultureInfo_1 = Thread.CurrentThread.CurrentUICulture);
				Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
				if (Class3.smethod_1(string_0, 219, 179) > 260)
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

		[SecuritySafeCritical]
		static Class36()
		{
			Class32.smethod_1();
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

	[SecuritySafeCritical]
	static UsageCountStore()
	{
		Class32.smethod_1();
		try
		{
			string_0 = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{8188F18B-DD19-48CB-888D-E596F7B0AB27}", 1, 8, 691, 753);
			string_1 = SendingReportFeedbackEventArgs1.smethod_0(string_0, "Usages.bin", 907, 922);
			string_2 = SendingReportFeedbackEventArgs1.smethod_0(string_0, "D", 384, 401);
			string_3 = SendingReportFeedbackEventArgs1.smethod_0(string_0, "l", 456, 473);
			encoding_0 = EntryPoint.smethod_0(176, 195);
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
			return new Class36(string_3);
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
				Class20.smethod_0(isolatedStorageFileStream, long_0 + 8L, 346, 322);
				Class20.smethod_0(isolatedStorageFileStream, long_0, 107, 115);
				num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
				num++;
				Class20.smethod_0(isolatedStorageFileStream, long_0, 767, 743);
				PoweredByAttribute.smethod_0(new BinaryWriter(isolatedStorageFileStream), num, 634, 615);
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
		byte[] array = default(byte[]);
		string text = default(string);
		byte[] array2 = default(byte[]);
		Guid guid = default(Guid);
		string text2 = default(string);
		string o = default(string);
		string text3 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		try
		{
			array = SimpleZip.Stream0.smethod_0(encoding_0, string_4, 50, 75);
			text = Convert.ToBase64String(array).Replace('\\', '@');
			if (Class3.smethod_1(text, 330, 290) > 50)
			{
				array2 = hashAlgorithm_0.ComputeHash(array);
				guid = new Guid(array2);
				text2 = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0(guid.ToString(), 0, 18, 253, 191);
				o = SendingReportFeedbackEventArgs1.smethod_0(string_2, text2, 882, 867);
				text = Class35.smethod_8(o, ".bin", 468, 442);
				text3 = Class35.smethod_8(o, ".txt", 789, 891);
				isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_1(text3, FileMode.CreateNew, FileAccess.Write);
					StackFrameHelper.smethod_0(isolatedStorageFileStream, array, 0, array.Length, 163, 207);
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
			StackFrameHelper.CreateException9(exception, array, text, array2, text2, o, text3, isolatedStorageFileStream, guid, string_4);
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
				array = new byte[Attribute0.smethod_0(isolatedStorageFileStream, 705, 682)];
				SimpleZip.Class5.smethod_0(isolatedStorageFileStream, array, 0, array.Length, 815, 880);
				array2 = new ulong[array.Length / 8];
				Class31.smethod_0(array, 0, array2, 0, array.Length, 607, 622);
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
				fileNames = isolatedStorageFile_0.GetFileNames(Class35.smethod_8(string_2, "\\*.bin", 409, 503));
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					text2 = Path.GetFileNameWithoutExtension(text);
					text3 = SendingReportFeedbackEventArgs1.smethod_0(string_2, text, 582, 599);
					array2 = smethod_5(text3);
					text4 = SendingReportFeedbackEventArgs1.smethod_0(string_2, Class35.smethod_8(text2, ".txt", 659, 765), 213, 196);
					isolatedStorageFileStream = null;
					try
					{
						isolatedStorageFileStream = smethod_1(text4, FileMode.Open, FileAccess.Read);
						array3 = new byte[Attribute0.smethod_0(isolatedStorageFileStream, 336, 315)];
						SimpleZip.Class5.smethod_0(isolatedStorageFileStream, array3, 0, array3.Length, 384, 479);
						text2 = encoding_0.GetString(array3);
					}
					catch (FileNotFoundException)
					{
						text2 = encoding_0.GetString(Class16.smethod_10(text2.Replace('@', '\\'), 467, 443));
					}
					finally
					{
						if (isolatedStorageFileStream != null)
						{
							UnhandledExceptionHandlerWithoutUI.smethod_1(isolatedStorageFileStream, 588, 612);
						}
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
				fileNames = isolatedStorageFile_0.GetFileNames(Class35.smethod_8(string_2, "\\*.bin", 111, 1));
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					text2 = SendingReportFeedbackEventArgs1.smethod_0(string_2, text, 98, 115);
					smethod_2(text2);
					text3 = SendingReportFeedbackEventArgs1.smethod_0(string_2, Class35.smethod_8(fileNameWithoutExtension, ".txt", 881, 799), 274, 259);
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
