using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace SQLiteWrapper;

public sealed class SQLiteBase
{
	public enum SQLiteDataTypes
	{
		const_0 = 1,
		FLOAT,
		TEXT,
		BLOB,
		NULL
	}

	private const int int_0 = 0;

	private const int int_1 = 100;

	private const int int_2 = 101;

	private IntPtr intptr_0;

	public SQLiteBase()
	{
		intptr_0 = IntPtr.Zero;
	}

	public SQLiteBase(string baseName)
	{
		OpenDatabase(baseName);
	}

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr intptr_1, uint uint_0, uint uint_1);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_open(IntPtr intptr_1, ref IntPtr intptr_2);

	[DllImport("sqlite3")]
	private static extern int sqlite3_close(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_exec(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, ref IntPtr intptr_5);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr intptr_1, IntPtr intptr_2, int int_3, ref IntPtr intptr_3, ref IntPtr intptr_4);

	[DllImport("sqlite3")]
	private static extern int sqlite3_step(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_count(IntPtr intptr_1);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_type(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_int(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern double sqlite3_column_double(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr intptr_1, int int_3);

	[DllImport("sqlite3")]
	private static extern int sqlite3_finalize(IntPtr intptr_1);

	public void OpenDatabase(string baseName)
	{
		if (sqlite3_open(method_2(baseName), ref intptr_0) != 0)
		{
			intptr_0 = IntPtr.Zero;
			throw new Exception("Error with opening database " + baseName + "!");
		}
	}

	public void CloseDatabase()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			sqlite3_close(intptr_0);
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
		IntPtr intptr_ = default(IntPtr);
		sqlite3_exec(intptr_0, method_2(query), IntPtr.Zero, IntPtr.Zero, ref intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + query + "\"!\n" + method_3(sqlite3_errmsg(intptr_)));
		}
	}

	public DataTable ExecuteQuery(string query)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		sqlite3_prepare_v2(intptr_0, method_2(query), method_4(method_2(query)), ref intptr_, ref intptr_2);
		DataTable dataTable_ = new DataTable();
		for (int num = method_0(intptr_, ref dataTable_); num == 100; num = method_1(intptr_, ref dataTable_))
		{
		}
		sqlite3_finalize(intptr_);
		return dataTable_;
	}

	private int method_0(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		dataTable_0 = new DataTable("resultTable");
		int num = sqlite3_step(intptr_1);
		checked
		{
			if (num == 100)
			{
				int num2 = sqlite3_column_count(intptr_1);
				string text = "";
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					text = method_3(sqlite3_column_name(intptr_1, i));
					switch (sqlite3_column_type(intptr_1, i))
					{
					default:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
						break;
					case 1:
						dataTable_0.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = sqlite3_column_int(intptr_1, i);
						break;
					case 2:
						dataTable_0.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = sqlite3_column_double(intptr_1, i);
						break;
					case 3:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = method_3(sqlite3_column_text(intptr_1, i));
						break;
					case 4:
						dataTable_0.Columns.Add(text, Type.GetType("System.String"));
						array[i] = method_3(sqlite3_column_blob(intptr_1, i));
						break;
					}
				}
				dataTable_0.Rows.Add(array);
			}
			return sqlite3_step(intptr_1);
		}
	}

	private int method_1(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		int num = sqlite3_column_count(intptr_1);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				switch (sqlite3_column_type(intptr_1, i))
				{
				default:
					array[i] = "";
					break;
				case 1:
					array[i] = sqlite3_column_int(intptr_1, i);
					break;
				case 2:
					array[i] = sqlite3_column_double(intptr_1, i);
					break;
				case 3:
					array[i] = method_3(sqlite3_column_text(intptr_1, i));
					break;
				case 4:
					array[i] = method_3(sqlite3_column_blob(intptr_1, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
			return sqlite3_step(intptr_1);
		}
	}

	private IntPtr method_2(string string_0)
	{
		if (string_0 == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(string_0);
		uint uint_ = checked((uint)(bytes.Length + 1));
		IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, uint_);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}

	private string method_3(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = method_4(intptr_1);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(intptr_1, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int method_4(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(intptr_1);
	}
}
