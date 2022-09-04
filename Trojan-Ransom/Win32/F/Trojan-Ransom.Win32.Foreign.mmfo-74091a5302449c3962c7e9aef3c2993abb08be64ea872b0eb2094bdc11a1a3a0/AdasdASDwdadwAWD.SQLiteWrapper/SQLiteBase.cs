using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace AdasdASDwdadwAWD.SQLiteWrapper;

public class SQLiteBase
{
	public enum SQLiteDataTypes
	{
		INT = 1,
		FLOAT,
		TEXT,
		BLOB,
		NULL
	}

	private const int SQL_OK = 0;

	private const int SQL_ROW = 100;

	private const int SQL_DONE = 101;

	private IntPtr database;

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr str);

	[DllImport("sqlite3")]
	private static extern int sqlite3_open(IntPtr fileName, ref IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_close(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, ref IntPtr error);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, ref IntPtr statement, ref IntPtr tail);

	[DllImport("sqlite3")]
	private static extern int sqlite3_step(IntPtr statement);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_count(IntPtr statement);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_type(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_int(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern double sqlite3_column_double(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_finalize(IntPtr handle);

	public SQLiteBase()
	{
		database = IntPtr.Zero;
	}

	public SQLiteBase(string baseName)
	{
		OpenDatabase(baseName);
	}

	public void OpenDatabase(string baseName)
	{
		if (sqlite3_open(StringToPointer(baseName), ref database) != 0)
		{
			database = IntPtr.Zero;
			throw new Exception("Error with opening database " + baseName + "!");
		}
	}

	public void CloseDatabase()
	{
		if (database != IntPtr.Zero)
		{
			sqlite3_close(database);
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return arrayList;
	}

	public void ExecuteNonQuery(string query)
	{
		IntPtr error = default(IntPtr);
		sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, ref error);
		if (error != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + query + "\"!\n" + PointerToString(sqlite3_errmsg(error)));
		}
	}

	public DataTable ExecuteQuery(string query)
	{
		IntPtr statement = default(IntPtr);
		IntPtr tail = default(IntPtr);
		sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), ref statement, ref tail);
		DataTable table = new DataTable();
		for (int num = ReadFirstRow(statement, ref table); num == 100; num = ReadNextRow(statement, ref table))
		{
		}
		sqlite3_finalize(statement);
		return table;
	}

	private int ReadFirstRow(IntPtr statement, ref DataTable table)
	{
		table = new DataTable("resultTable");
		int num = sqlite3_step(statement);
		checked
		{
			if (num == 100)
			{
				int num2 = sqlite3_column_count(statement);
				string text = "";
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
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
	}

	private int ReadNextRow(IntPtr statement, ref DataTable table)
	{
		int num = sqlite3_column_count(statement);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
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
	}

	private IntPtr StringToPointer(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(str);
		uint bytes2 = checked((uint)(bytes.Length + 1));
		IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, bytes2);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}

	private string PointerToString(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int pointerLenght = GetPointerLenght(ptr);
		byte[] array = new byte[checked(pointerLenght - 1 + 1)];
		Marshal.Copy(ptr, array, 0, pointerLenght);
		return uTF.GetString(array, 0, pointerLenght);
	}

	private int GetPointerLenght(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(ptr);
	}
}
