using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public static class UsageCountStore
{
	private sealed class Class34 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0;

		internal CultureInfo cultureInfo_1;

		internal Mutex mutex_0;

		public Class34(string string_0)
		{
			try
			{
				CultureInfo cultureInfo = (cultureInfo_1 = Thread.CurrentThread.CurrentUICulture);
				Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
				if (PoweredBy.smethod_0(string_0, 619, 571) > 260)
				{
					string_0 = StackFrameHelper.smethod_2(string_0, 261, 609, 534);
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

		static Class34()
		{
			DESCryptoIndirector.smethod_0();
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
		DESCryptoIndirector.smethod_0();
		try
		{
			string_0 = "{E8999F69-FF1B-4846-9283-897940EB0660}".Substring(1, 8);
			string_1 = ReportSender.smethod_0(string_0, "Usages.bin", 556, 584);
			string_2 = ReportSender.smethod_0(string_0, "D", 18, 118);
			string_3 = ReportSender.smethod_0(string_0, "l", 208, 180);
			encoding_0 = Class20.smethod_2(390, 488);
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
			return new Class34(string_3);
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
				Class29.smethod_5(isolatedStorageFileStream, long_0 + 8L, 824, 811);
				Class29.smethod_5(isolatedStorageFileStream, long_0, 673, 690);
				num = ConfirmFeatureUsageReportingForm.smethod_2(new BinaryReader(isolatedStorageFileStream), 187, 188);
				num++;
				Class29.smethod_5(isolatedStorageFileStream, long_0, 719, 732);
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
		byte[] array = default(byte[]);
		string text = default(string);
		byte[] array2 = default(byte[]);
		Guid guid = default(Guid);
		string o = default(string);
		string o2 = default(string);
		string text2 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		try
		{
			array = Win32.smethod_12(encoding_0, string_4, 545, 591);
			text = Convert.ToBase64String(array).Replace('\\', '@');
			if (PoweredBy.smethod_0(text, 590, 542) > 50)
			{
				array2 = hashAlgorithm_0.ComputeHash(array);
				guid = new Guid(array2);
				o = guid.ToString().Substring(0, 18);
				o2 = ReportSender.smethod_0(string_2, o, 278, 370);
				text = ReportSender.smethod_0(o2, ".bin", 499, 400);
				text2 = ReportSender.smethod_0(o2, ".txt", 232, 139);
				isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = smethod_1(text2, FileMode.CreateNew, FileAccess.Write);
					SendingReportFeedbackEventArgs.smethod_2(isolatedStorageFileStream, array, 0, array.Length, 816, 793);
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
			StackFrameHelper.CreateException9(exception, array, text, array2, o, o2, text2, isolatedStorageFileStream, guid, string_4);
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
				array = new byte[ReportExceptionEventArgs.smethod_1(isolatedStorageFileStream, 423, 403)];
				SimpleZip.Class11.smethod_0(isolatedStorageFileStream, array, 0, array.Length, 21, 81);
				array2 = new ulong[array.Length / 8];
				DoNotPruneTypeAttribute.smethod_1(array, 0, array2, 0, array.Length, 907, 957);
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
				fileNames = isolatedStorageFile_0.GetFileNames(ReportSender.smethod_0(string_2, "\\*.bin", 251, 152));
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					text2 = Path.GetFileNameWithoutExtension(text);
					text3 = ReportSender.smethod_0(string_2, text, 564, 592);
					array2 = smethod_5(text3);
					text4 = ReportSender.smethod_0(string_2, ReportSender.smethod_0(text2, ".txt", 877, 782), 741, 641);
					isolatedStorageFileStream = null;
					try
					{
						isolatedStorageFileStream = smethod_1(text4, FileMode.Open, FileAccess.Read);
						array3 = new byte[ReportExceptionEventArgs.smethod_1(isolatedStorageFileStream, 699, 655)];
						SimpleZip.Class11.smethod_0(isolatedStorageFileStream, array3, 0, array3.Length, 577, 517);
						text2 = Class20.smethod_4(encoding_0, array3, 993, 962);
					}
					catch (FileNotFoundException)
					{
						text2 = Class20.smethod_4(encoding_0, UsageCounts.smethod_1(text2.Replace('@', '\\'), 905, 957), 651, 680);
					}
					finally
					{
						if (isolatedStorageFileStream != null)
						{
							SendingReportFeedbackEventArgs.smethod_1(isolatedStorageFileStream, 758, 651);
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
				fileNames = isolatedStorageFile_0.GetFileNames(ReportSender.smethod_0(string_2, "\\*.bin", 141, 238));
				for (i = 0; i < fileNames.Length; i++)
				{
					text = fileNames[i];
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					text2 = ReportSender.smethod_0(string_2, text, 242, 150);
					smethod_2(text2);
					text3 = ReportSender.smethod_0(string_2, ReportSender.smethod_0(fileNameWithoutExtension, ".txt", 512, 611), 627, 535);
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
