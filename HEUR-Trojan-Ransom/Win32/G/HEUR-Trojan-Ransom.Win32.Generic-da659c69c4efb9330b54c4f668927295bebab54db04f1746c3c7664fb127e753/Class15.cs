using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

internal class Class15
{
	public enum Enum0
	{
		const_0 = 4,
		const_1 = 2,
		const_2 = 1,
		const_3 = 5,
		const_4 = 3
	}

	private const int int_0 = 101;

	private const int int_1 = 0;

	private const int int_2 = 100;

	private IntPtr intptr_0;

	public Class15()
	{
		intptr_0 = IntPtr.Zero;
	}

	public Class15(string string_0)
	{
		method_5(string_0);
	}

	public void method_0()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			sqlite3_close(intptr_0);
		}
	}

	public void method_1(string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		sqlite3_exec(intptr_0, method_9(string_0), IntPtr.Zero, IntPtr.Zero, ref intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + string_0 + "\"!\n" + method_6(sqlite3_errmsg(intptr_)));
		}
	}

	public DataTable method_2(string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		sqlite3_prepare_v2(intptr_0, method_9(string_0), method_3(method_9(string_0)), ref intptr_2, ref intptr_);
		DataTable dataTable_ = new DataTable();
		for (int num = method_7(intptr_2, ref dataTable_); num == 100; num = method_8(intptr_2, ref dataTable_))
		{
		}
		sqlite3_finalize(intptr_2);
		return dataTable_;
	}

	private int method_3(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(intptr_1);
	}

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	public ArrayList method_4()
	{
		IEnumerator enumerator = null;
		string string_ = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
		DataTable dataTable = method_2(string_);
		ArrayList arrayList = new ArrayList();
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

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr intptr_1, uint uint_0, uint uint_1);

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr intptr_1);

	public void method_5(string string_0)
	{
		if (sqlite3_open(method_9(string_0), ref intptr_0) != 0)
		{
			intptr_0 = IntPtr.Zero;
			throw new Exception("Error with opening database " + string_0 + "!");
		}
	}

	private string method_6(IntPtr intptr_1)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = method_3(intptr_1);
		byte[] array = new byte[num - 1 + 1];
		Marshal.Copy(intptr_1, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int method_7(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		dataTable_0 = new DataTable("resultTable");
		if (sqlite3_step(intptr_1) == 100)
		{
			int num = sqlite3_column_count(intptr_1);
			string text = "";
			object[] array = new object[num - 1 + 1];
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				text = method_6(sqlite3_column_name(intptr_1, i));
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
					array[i] = method_6(sqlite3_column_text(intptr_1, i));
					break;
				case 4:
					dataTable_0.Columns.Add(text, Type.GetType("System.String"));
					array[i] = method_6(sqlite3_column_blob(intptr_1, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
		}
		return sqlite3_step(intptr_1);
	}

	private int method_8(IntPtr intptr_1, ref DataTable dataTable_0)
	{
		int num = sqlite3_column_count(intptr_1);
		object[] array = new object[num - 1 + 1];
		int num2 = num - 1;
		for (int i = 0; i <= num2; i++)
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
				array[i] = method_6(sqlite3_column_text(intptr_1, i));
				break;
			case 4:
				array[i] = method_6(sqlite3_column_blob(intptr_1, i));
				break;
			}
		}
		dataTable_0.Rows.Add(array);
		return sqlite3_step(intptr_1);
	}

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_close(IntPtr intptr_1);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_count(IntPtr intptr_1);

	[DllImport("mozsqlite3")]
	private static extern double sqlite3_column_double(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_int(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_type(IntPtr intptr_1, int int_3);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr intptr_1);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_exec(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, ref IntPtr intptr_5);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_finalize(IntPtr intptr_1);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_open(IntPtr intptr_1, ref IntPtr intptr_2);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr intptr_1, IntPtr intptr_2, int int_3, ref IntPtr intptr_3, ref IntPtr intptr_4);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_step(IntPtr intptr_1);

	private IntPtr method_9(string string_0)
	{
		if (string_0 == null)
		{
			return IntPtr.Zero;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		uint uint_ = (uint)(bytes.Length + 1);
		IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, uint_);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}
}
