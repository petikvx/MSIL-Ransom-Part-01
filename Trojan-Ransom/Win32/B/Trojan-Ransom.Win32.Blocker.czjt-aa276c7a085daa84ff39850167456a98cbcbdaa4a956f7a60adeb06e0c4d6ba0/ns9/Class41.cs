using System;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ns9;

internal static class Class41
{
	internal sealed class Class42 : IDisposable
	{
		private static readonly CultureInfo cultureInfo_0 = CultureInfo.GetCultureInfo("en-US");

		private readonly CultureInfo cultureInfo_1;

		private readonly Mutex mutex_0;

		public Class42(string string_0)
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

		void IDisposable.Dispose()
		{
			mutex_0.ReleaseMutex();
			mutex_0.Close();
			Thread.CurrentThread.CurrentUICulture = cultureInfo_1;
		}
	}

	private static readonly string string_0;

	internal static readonly string string_1;

	internal static readonly string string_2;

	internal static readonly string string_3;

	internal static readonly IsolatedStorageFile isolatedStorageFile_0;

	internal static readonly Encoding encoding_0;

	internal static readonly HashAlgorithm hashAlgorithm_0;

	static Class41()
	{
		string_0 = "{FDC54A6F-5294-4961-88B8-331D8BE2D74A}".Substring(1, 8);
		string_1 = Path.Combine(string_0, "Usages.bin");
		string_2 = Path.Combine(string_0, "D");
		string_3 = Path.Combine(string_0, "l");
		encoding_0 = Encoding.UTF8;
		hashAlgorithm_0 = new MD5CryptoServiceProvider();
		isolatedStorageFile_0 = IsolatedStorageFile.GetUserStoreForAssembly();
		isolatedStorageFile_0.CreateDirectory(string_0);
		isolatedStorageFile_0.CreateDirectory(string_2);
	}
}
