using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace MI_CSRSS;

public class SQLiteBase
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
