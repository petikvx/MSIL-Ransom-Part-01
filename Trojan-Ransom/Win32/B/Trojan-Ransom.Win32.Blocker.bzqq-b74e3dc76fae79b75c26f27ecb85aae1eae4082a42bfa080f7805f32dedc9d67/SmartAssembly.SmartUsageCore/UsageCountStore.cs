using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public static class UsageCountStore
{
	private sealed class Class37 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0;

		internal CultureInfo cultureInfo_1;

		internal Mutex mutex_0;

		public Class37(string string_0)
		{
			CultureInfo o = default(CultureInfo);
			Mutex o2 = default(Mutex);
			try
			{
				try
				{
					o = (cultureInfo_1 = PoweredBy.smethod_1(DoNotObfuscateTypeAttribute.smethod_4(768, 843), 560, 530));
					AppRegistryKeys.smethod_2(DoNotObfuscateTypeAttribute.smethod_4(580, 527), cultureInfo_0, 257, 256);
					if (AppPathFinder.smethod_1(string_0, 213, 226) > 260)
					{
						string_0 = Class40.smethod_5(string_0, 261, 674, 767);
					}
					string_0 = SimpleZip.Class8.smethod_1(string_0, Path.DirectorySeparatorChar, '_', 1020, 909);
					o2 = (mutex_0 = new Mutex(initiallyOwned: false, string_0));
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
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException4(exception2, o, o2, this, string_0);
				throw;
			}
		}

		public void Dispose()
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				try
				{
					num = 3;
					SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_4(mutex_0, 427, 401);
					FeedbackControl.smethod_4(mutex_0, 391, 475);
					num = 1;
					DoNotObfuscateTypeAttribute.smethod_4(461, 390).CurrentUICulture = cultureInfo_1;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
				num2 = 0;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num, num2, this);
				throw;
			}
		}

		static Class37()
		{
			try
			{
				DoNotPruneAttribute.smethod_8();
				try
				{
					cultureInfo_0 = Form1.smethod_2("en-US", 59, 51);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException0(exception);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException0(exception2);
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
		int num = default(int);
		int num2 = default(int);
		try
		{
			DoNotPruneAttribute.smethod_8();
			try
			{
				num = 2;
				string_0 = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_5("{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 1, 8, 324, 307);
				num = 3;
				string_1 = Form0.smethod_1(string_0, "Usages.bin", 848, 867);
				string_2 = Form0.smethod_1(string_0, "D", 664, 683);
				num = 1;
				string_3 = Form0.smethod_1(string_0, "l", 1023, 972);
				num = 5;
				encoding_0 = Class33.smethod_0(355, 318);
				hashAlgorithm_0 = new MD5CryptoServiceProvider();
				isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
				isolatedStorageFile_0.CreateDirectory(string_0);
				num = 8;
				isolatedStorageFile_0.CreateDirectory(string_2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
			num2 = 2;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, num, num2);
			throw;
		}
	}

	private static IDisposable smethod_0()
	{
		IDisposable disposable = default(IDisposable);
		try
		{
			try
			{
				disposable = new Class37(string_3);
				return disposable;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, disposable);
			throw;
		}
	}

	private static IsolatedStorageFileStream smethod_1(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		try
		{
			try
			{
				isolatedStorageFileStream = new IsolatedStorageFileStream(string_4, fileMode_0, fileAccess_0, FileShare.None, isolatedStorageFile_0);
				return isolatedStorageFileStream;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, string_4, fileMode_0, fileAccess_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, isolatedStorageFileStream, string_4, fileMode_0, fileAccess_0);
			throw;
		}
	}

	private static void smethod_2(string string_4)
	{
		try
		{
			try
			{
				try
				{
					ReportSender1.smethod_6(isolatedStorageFile_0, string_4, 559, 519);
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, string_4);
			throw;
		}
	}

	private static void smethod_3(string string_4, long long_0)
	{
		int num = default(int);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		int num2 = default(int);
		ulong num3 = default(ulong);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				num = 1;
				isolatedStorageFileStream = smethod_1(string_4, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				try
				{
					num2 = 3;
					ReportExceptionEventArgs.smethod_0(isolatedStorageFileStream, long_0 + 8L, 677, 683);
					ReportExceptionEventArgs.smethod_0(isolatedStorageFileStream, long_0, 187, 181);
					num2 = 2;
					num3 = Class40.smethod_6(new BinaryReader(isolatedStorageFileStream), 54, 121);
					num3++;
					num2 = 5;
					ReportExceptionEventArgs.smethod_0(isolatedStorageFileStream, long_0, 655, 641);
					AppNameFinder.smethod_3(new BinaryWriter(isolatedStorageFileStream), num3, 477, 385);
				}
				finally
				{
					num4 = 5;
					((IDisposable)isolatedStorageFileStream)?.Dispose();
				}
				num5 = 3;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, isolatedStorageFileStream, num3, string_4, long_0);
				throw;
			}
			num6 = 3;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException9(exception2, isolatedStorageFileStream, num3, num, num2, num4, num5, num6, string_4, long_0);
			throw;
		}
	}

	public static void IncrementUsage(uint featureId)
	{
		IDisposable disposable = default(IDisposable);
		int num = default(int);
		try
		{
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
					num = 4;
					disposable?.Dispose();
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, disposable, featureId);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, disposable, num, featureId);
			throw;
		}
	}

	private static string smethod_4(string string_4)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		byte[] array2 = default(byte[]);
		Guid guid = default(Guid);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		string text5 = default(string);
		int num6 = default(int);
		try
		{
			try
			{
				num = 5;
				array = Class28.smethod_3(encoding_0, string_4, 118, 0);
				text = SimpleZip.Class8.smethod_1(Class28.smethod_6(array, 66, 57), '\\', '@', 475, 426);
				num = 1;
				if (AppPathFinder.smethod_1(text, 410, 429) > 50)
				{
					num = 9;
					array2 = ReportUsageAttribute.smethod_2(hashAlgorithm_0, array, 56, 111);
					guid = new Guid(array2);
					num = 0;
					text2 = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_5(guid.ToString(), 0, 18, 60, 75);
					num = 8;
					text3 = Form0.smethod_1(string_2, text2, 492, 479);
					text = Form0.smethod_1(text3, ".bin", 74, 120);
					num = 3;
					text4 = Form0.smethod_1(text3, ".txt", 335, 381);
					isolatedStorageFileStream = null;
					try
					{
						try
						{
							num2 = 0;
							isolatedStorageFileStream = smethod_1(text4, FileMode.CreateNew, FileAccess.Write);
							ReportSender1.smethod_1(isolatedStorageFileStream, array, 0, array.Length, 608, 542);
						}
						catch (IOException)
						{
						}
						num3 = 1;
					}
					finally
					{
						num4 = 4;
						isolatedStorageFileStream?.Close();
					}
				}
				else
				{
					num5 = 2;
					text = Path.Combine(string_2, text + ".bin");
					num5 = 4;
				}
				text5 = text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException9(exception, array, text, array2, text2, text3, text4, isolatedStorageFileStream, guid, string_4);
				throw;
			}
			num6 = 0;
			return text5;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[16]
			{
				array, text, array2, text2, text3, text4, isolatedStorageFileStream, guid, text5, num,
				num2, num3, num4, num5, num6, string_4
			});
			throw;
		}
	}

	public static void IncrementUsage(string featureName)
	{
		IDisposable disposable = default(IDisposable);
		string text = default(string);
		int num = default(int);
		try
		{
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
					num = 4;
					disposable?.Dispose();
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, disposable, text, featureName);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, disposable, text, num, featureName);
			throw;
		}
	}

	private static ulong[] smethod_5(string string_4)
	{
		int num = default(int);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		int num2 = default(int);
		byte[] array = default(byte[]);
		ulong[] array2 = default(ulong[]);
		int num3 = default(int);
		int num4 = default(int);
		ulong[] array3 = default(ulong[]);
		int num5 = default(int);
		try
		{
			try
			{
				num = 3;
				isolatedStorageFileStream = new IsolatedStorageFileStream(string_4, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, isolatedStorageFile_0);
				try
				{
					num2 = 4;
					array = new byte[Class5.smethod_2(isolatedStorageFileStream, 467, 506)];
					SecurityExceptionEventArgs.smethod_2(isolatedStorageFileStream, array, 0, array.Length, 660, 705);
					num2 = 3;
					array2 = new ulong[array.Length / 8];
					AppPathFinder.smethod_0(array, 0, array2, 0, array.Length, 569, 546);
				}
				finally
				{
					num3 = 2;
					((IDisposable)isolatedStorageFileStream)?.Dispose();
				}
				num4 = 3;
				array3 = array2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, array2, isolatedStorageFileStream, array, string_4);
				throw;
			}
			num5 = 4;
			return array3;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException10(exception2, array2, isolatedStorageFileStream, array, array3, num, num2, num3, num4, num5, string_4);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCountsAndReset()
	{
		IDisposable disposable = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		UsageCounts usageCounts2 = default(UsageCounts);
		int num = default(int);
		UsageCounts usageCounts3 = default(UsageCounts);
		try
		{
			try
			{
				disposable = smethod_0();
				try
				{
					usageCounts = smethod_6();
					smethod_7();
					usageCounts2 = usageCounts;
				}
				finally
				{
					num = 0;
					disposable?.Dispose();
				}
				usageCounts3 = usageCounts2;
				return usageCounts3;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, usageCounts, usageCounts2, disposable);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, usageCounts, usageCounts2, disposable, usageCounts3, num);
			throw;
		}
	}

	public static UsageCounts GetAllUsageCounts()
	{
		IDisposable disposable = default(IDisposable);
		UsageCounts usageCounts = default(UsageCounts);
		int num = default(int);
		UsageCounts usageCounts2 = default(UsageCounts);
		try
		{
			try
			{
				disposable = smethod_0();
				try
				{
					usageCounts = smethod_6();
				}
				finally
				{
					num = 5;
					disposable?.Dispose();
				}
				usageCounts2 = usageCounts;
				return usageCounts2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, usageCounts, disposable);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, usageCounts, disposable, usageCounts2, num);
			throw;
		}
	}

	public static void Reset()
	{
		IDisposable disposable = default(IDisposable);
		int num = default(int);
		try
		{
			try
			{
				disposable = smethod_0();
				try
				{
					smethod_7();
				}
				finally
				{
					num = 3;
					disposable?.Dispose();
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, disposable);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, disposable, num);
			throw;
		}
	}

	private static UsageCounts smethod_6()
	{
		int num = default(int);
		ulong[] array = default(ulong[]);
		Dictionary<string, ulong> dictionary = default(Dictionary<string, ulong>);
		int num2 = default(int);
		string[] array2 = default(string[]);
		int num3 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		ulong[] array3 = default(ulong[]);
		string text4 = default(string);
		IsolatedStorageFileStream isolatedStorageFileStream = default(IsolatedStorageFileStream);
		int num4 = default(int);
		byte[] array4 = default(byte[]);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		UsageCounts usageCounts = default(UsageCounts);
		object[] array5 = default(object[]);
		int num9 = default(int);
		try
		{
			try
			{
				num = 1;
				array = smethod_5(string_1);
				dictionary = new Dictionary<string, ulong>();
				try
				{
					num2 = 0;
					array2 = ConfirmFeatureUsageReportingForm_1.smethod_1(isolatedStorageFile_0, Form0.smethod_1(string_2, "\\*.bin", 122, 72), 112, 87);
					num2 = 1;
					num3 = 0;
					while (num3 < array2.Length)
					{
						text = array2[num3];
						text2 = DoNotPruneTypeAttribute.smethod_4(text, 520, 617);
						num2 = 2;
						text3 = Form0.smethod_1(string_2, text, 195, 240);
						array3 = smethod_5(text3);
						num2 = 9;
						text4 = Form0.smethod_1(string_2, Form0.smethod_1(text2, ".txt", 37, 23), 680, 667);
						num2 = 7;
						isolatedStorageFileStream = null;
						try
						{
							try
							{
								num4 = 1;
								isolatedStorageFileStream = smethod_1(text4, FileMode.Open, FileAccess.Read);
								array4 = new byte[Class5.smethod_2(isolatedStorageFileStream, 636, 597)];
								num4 = 5;
								SecurityExceptionEventArgs.smethod_2(isolatedStorageFileStream, array4, 0, array4.Length, 781, 856);
								num4 = 0;
								text2 = SendingReportFeedbackEventArgs1.smethod_1(encoding_0, array4, 1021, 964);
							}
							catch (FileNotFoundException)
							{
								text2 = SendingReportFeedbackEventArgs1.smethod_1(encoding_0, AppRegistryKeys.smethod_0(SimpleZip.Class8.smethod_1(text2, '@', '\\', 661, 740), 477, 501), 206, 247);
							}
							num5 = 2;
						}
						finally
						{
							num6 = 3;
							if (isolatedStorageFileStream != null)
							{
								Class22.smethod_4(isolatedStorageFileStream, 208, 246);
							}
						}
						num7 = 6;
						dictionary[text2] = array3[0];
						num3++;
						num7 = 3;
					}
					num7 = 0;
				}
				catch (DirectoryNotFoundException)
				{
				}
				num8 = 2;
				usageCounts = new UsageCounts(array, dictionary);
			}
			catch (Exception caughtException)
			{
				array5 = new object[11]
				{
					array, dictionary, text, text2, text3, array3, text4, isolatedStorageFileStream, array4, array2,
					num3
				};
				StackFrameHelper.CreateExceptionN(caughtException, array5);
				throw;
			}
			num9 = 4;
			return usageCounts;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[21]
			{
				array, dictionary, text, text2, text3, array3, text4, isolatedStorageFileStream, array4, array2,
				num3, array5, usageCounts, num, num2, num4, num5, num6, num7, num8,
				num9
			});
			throw;
		}
	}

	private static void smethod_7()
	{
		int num = default(int);
		int num2 = default(int);
		string[] array = default(string[]);
		int num3 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				num = 4;
				smethod_2(string_1);
				try
				{
					num2 = 5;
					array = ConfirmFeatureUsageReportingForm_1.smethod_1(isolatedStorageFile_0, Form0.smethod_1(string_2, "\\*.bin", 39, 21), 704, 743);
					num2 = 8;
					num3 = 0;
					num2 = 6;
					while (num3 < array.Length)
					{
						text = array[num3];
						text2 = DoNotPruneTypeAttribute.smethod_4(text, 956, 989);
						num2 = 10;
						text3 = Form0.smethod_1(string_2, text, 903, 948);
						smethod_2(text3);
						text4 = Form0.smethod_1(string_2, Form0.smethod_1(text2, ".txt", 833, 883), 943, 924);
						num2 = 2;
						smethod_2(text4);
						num3++;
						num2 = 6;
					}
				}
				catch (DirectoryNotFoundException)
				{
				}
				try
				{
					num4 = 3;
					isolatedStorageFile_0.DeleteDirectory(string_2);
				}
				catch (IsolatedStorageException)
				{
				}
				num5 = 3;
				isolatedStorageFile_0.CreateDirectory(string_2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, text, text2, text3, text4, array, num3);
				throw;
			}
			num6 = 4;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				text, text2, text3, text4, array, num3, num, num2, num4, num5,
				num6
			});
			throw;
		}
	}
}
