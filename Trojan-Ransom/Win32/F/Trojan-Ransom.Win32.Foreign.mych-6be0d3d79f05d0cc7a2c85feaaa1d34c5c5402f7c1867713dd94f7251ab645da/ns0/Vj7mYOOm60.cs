using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

public class Vj7mYOOm60
{
	public enum zO2qrIyrkH5j61
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

	private IntPtr cmpBUeNhC6HB183;

	public Vj7mYOOm60()
	{
		cmpBUeNhC6HB183 = IntPtr.Zero;
	}

	public Vj7mYOOm60(string baseName)
	{
		lwvyGEf5CYJMH0s258(baseName);
	}

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr str);

	[DllImport("sqlite3")]
	private static extern int sqlite3_open(IntPtr fileName, out IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_close(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, out IntPtr errorr);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, out IntPtr statement, out IntPtr tail);

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
	private static extern IntPtr sqlite3_column_bytes(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_finalize(IntPtr handle);

	public void lwvyGEf5CYJMH0s258(string baseName)
	{
		if (sqlite3_open(nSqtQtf5aGP8265(baseName), out cmpBUeNhC6HB183) != 0)
		{
			cmpBUeNhC6HB183 = IntPtr.Zero;
			throw new Exception("Error with opening database " + baseName + "!");
		}
	}

	public void nkOLMgK5nyCC259()
	{
		if (cmpBUeNhC6HB183 != IntPtr.Zero)
		{
			sqlite3_close(cmpBUeNhC6HB183);
		}
	}

	public ArrayList IuYGkw61UYtj260()
	{
		string query = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
		DataTable dataTable = YA9dAq7Z32xA262(query);
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

	public void method_0(string query)
	{
		sqlite3_exec(cmpBUeNhC6HB183, nSqtQtf5aGP8265(query), IntPtr.Zero, IntPtr.Zero, out var errorr);
		if (errorr != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + query + "\"!\n" + method_1(sqlite3_errmsg(errorr)));
		}
	}

	public DataTable YA9dAq7Z32xA262(string query)
	{
		sqlite3_prepare_v2(cmpBUeNhC6HB183, nSqtQtf5aGP8265(query), y3xneyThrwLS268(nSqtQtf5aGP8265(query)), out var statement, out var _);
		DataTable table = new DataTable();
		for (int num = DiofBYxoQuE4263(statement, ref table); num == 100; num = YhES5B0MlwHJ264(statement, ref table))
		{
		}
		sqlite3_finalize(statement);
		return table;
	}

	private int DiofBYxoQuE4263(IntPtr statement, ref DataTable table)
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
					text = method_1(sqlite3_column_name(statement, i));
					num3 = sqlite3_column_type(statement, i);
					int num5 = num3;
					if (num5 == Conversion.Fix(1))
					{
						table.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = sqlite3_column_int(statement, i);
					}
					else if (num5 == Conversion.Fix(2))
					{
						table.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = sqlite3_column_double(statement, i);
					}
					else if (num5 == Conversion.Fix(3))
					{
						table.Columns.Add(text, Type.GetType("System.String"));
						array[i] = method_1(sqlite3_column_text(statement, i));
					}
					else if (num5 == Conversion.Fix(4))
					{
						table.Columns.Add(text, Type.GetType("System.Array"));
						int siz = (int)sqlite3_column_bytes(statement, i);
						array[i] = LfUr2Ke7AESI267(sqlite3_column_blob(statement, i), siz);
					}
					else
					{
						table.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
					}
				}
				table.Rows.Add(array);
			}
			return sqlite3_step(statement);
		}
	}

	private int YhES5B0MlwHJ264(IntPtr statement, ref DataTable table)
	{
		checked
		{
			int result = default(int);
			try
			{
				int num = sqlite3_column_count(statement);
				int num2 = 0;
				object[] array = new object[num - 1 + 1];
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					num2 = sqlite3_column_type(statement, i);
					int num4 = num2;
					if (num4 == Conversion.Fix(1))
					{
						array[i] = sqlite3_column_int(statement, i);
					}
					else if (num4 == Conversion.Fix(2))
					{
						array[i] = sqlite3_column_double(statement, i);
					}
					else if (num4 == Conversion.Fix(3))
					{
						array[i] = method_1(sqlite3_column_text(statement, i));
					}
					else if (num4 == Conversion.Fix(4))
					{
						int siz = (int)sqlite3_column_bytes(statement, i);
						array[i] = LfUr2Ke7AESI267(sqlite3_column_blob(statement, i), siz);
					}
					else
					{
						array[i] = "";
					}
				}
				table.Rows.Add(array);
				result = sqlite3_step(statement);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private IntPtr nSqtQtf5aGP8265(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(str);
		checked
		{
			int num = bytes.Length + 1;
			IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, (uint)num);
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			Marshal.WriteByte(intPtr, bytes.Length, 0);
			return intPtr;
		}
	}

	private string method_1(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = y3xneyThrwLS268(ptr);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(ptr, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private Array LfUr2Ke7AESI267(IntPtr ptr, int siz)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		_ = Encoding.UTF8;
		y3xneyThrwLS268(ptr);
		byte[] array = new byte[checked(siz - 1 + 1)];
		Marshal.Copy(ptr, array, 0, siz);
		return array;
	}

	private int y3xneyThrwLS268(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(ptr);
	}
}
