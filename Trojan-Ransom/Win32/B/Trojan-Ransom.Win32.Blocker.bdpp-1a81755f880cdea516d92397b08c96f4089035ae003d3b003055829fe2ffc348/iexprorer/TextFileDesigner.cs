using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace iexprorer;

internal sealed class TextFileDesigner
{
	public enum MenuItemConverter
	{
		valuesMap = 4,
		valuesSet = 2,
		activeGenerator = 1,
		propStorePosition = 5,
		lastLine = 3
	}

	private const int valuesMap = 101;

	private const int valuesSet = 0;

	private const int activeGenerator = 100;

	private IntPtr valuesMap;

	public TextFileDesigner()
	{
		valuesMap = IntPtr.Zero;
	}

	public TextFileDesigner(string string_0)
	{
		this.ResolveView(string_0);
	}

	public void ProcessPciture()
	{
		if (valuesMap != IntPtr.Zero)
		{
			sqlite3_close(valuesMap);
		}
	}

	public void ProcessPciture(string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		sqlite3_exec(valuesMap, this.ResolveView(string_0), IntPtr.Zero, IntPtr.Zero, ref intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + string_0 + "\"!\n" + this.ProcessPciture(sqlite3_errmsg(intptr_)));
		}
	}

	public DataTable ProcessPciture(string string_0)
	{
		IntPtr intptr_ = default(IntPtr);
		IntPtr intptr_2 = default(IntPtr);
		sqlite3_prepare_v2(valuesMap, this.ResolveView(string_0), this.ProcessPciture(this.ResolveView(string_0)), ref intptr_2, ref intptr_);
		DataTable dataTable_ = new DataTable();
		for (int num = ProcessPciture(intptr_2, ref dataTable_); num == 100; num = ResolveView(intptr_2, ref dataTable_))
		{
		}
		sqlite3_finalize(intptr_2);
		return dataTable_;
	}

	private int ProcessPciture(IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(intptr_0);
	}

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	public ArrayList ProcessPciture()
	{
		IEnumerator enumerator = null;
		string string_ = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
		DataTable dataTable = this.ProcessPciture(string_);
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
	private static extern IntPtr HeapAlloc(IntPtr intptr_0, uint uint_0, uint uint_1);

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr intptr_0);

	public void ResolveView(string string_0)
	{
		if (sqlite3_open(this.ResolveView(string_0), ref valuesMap) != 0)
		{
			valuesMap = IntPtr.Zero;
			throw new Exception("Error with opening database " + string_0 + "!");
		}
	}

	private string ProcessPciture(IntPtr intptr_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = this.ProcessPciture(intptr_0);
		byte[] array = new byte[num - 1 + 1];
		Marshal.Copy(intptr_0, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int ProcessPciture(IntPtr intptr_0, ref DataTable dataTable_0)
	{
		dataTable_0 = new DataTable("resultTable");
		if (sqlite3_step(intptr_0) == 100)
		{
			int num = sqlite3_column_count(intptr_0);
			string text = "";
			object[] array = new object[num - 1 + 1];
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				text = this.ProcessPciture(sqlite3_column_name(intptr_0, i));
				switch (sqlite3_column_type(intptr_0, i))
				{
				default:
					dataTable_0.Columns.Add(text, Type.GetType("System.String"));
					array[i] = "";
					break;
				case 1:
					dataTable_0.Columns.Add(text, Type.GetType("System.Int32"));
					array[i] = sqlite3_column_int(intptr_0, i);
					break;
				case 2:
					dataTable_0.Columns.Add(text, Type.GetType("System.Single"));
					array[i] = sqlite3_column_double(intptr_0, i);
					break;
				case 3:
					dataTable_0.Columns.Add(text, Type.GetType("System.String"));
					array[i] = this.ProcessPciture(sqlite3_column_text(intptr_0, i));
					break;
				case 4:
					dataTable_0.Columns.Add(text, Type.GetType("System.String"));
					array[i] = this.ProcessPciture(sqlite3_column_blob(intptr_0, i));
					break;
				}
			}
			dataTable_0.Rows.Add(array);
		}
		return sqlite3_step(intptr_0);
	}

	private int ResolveView(IntPtr intptr_0, ref DataTable dataTable_0)
	{
		int num = sqlite3_column_count(intptr_0);
		object[] array = new object[num - 1 + 1];
		int num2 = num - 1;
		for (int i = 0; i <= num2; i++)
		{
			switch (sqlite3_column_type(intptr_0, i))
			{
			default:
				array[i] = "";
				break;
			case 1:
				array[i] = sqlite3_column_int(intptr_0, i);
				break;
			case 2:
				array[i] = sqlite3_column_double(intptr_0, i);
				break;
			case 3:
				array[i] = this.ProcessPciture(sqlite3_column_text(intptr_0, i));
				break;
			case 4:
				array[i] = this.ProcessPciture(sqlite3_column_blob(intptr_0, i));
				break;
			}
		}
		dataTable_0.Rows.Add(array);
		return sqlite3_step(intptr_0);
	}

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_close(IntPtr intptr_0);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_count(IntPtr intptr_0);

	[DllImport("mozsqlite3")]
	private static extern double sqlite3_column_double(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_int(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_column_type(IntPtr intptr_0, int int_0);

	[DllImport("mozsqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr intptr_0);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_exec(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_finalize(IntPtr intptr_0);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_open(IntPtr intptr_0, ref IntPtr intptr_1);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr intptr_0, IntPtr intptr_1, int int_0, ref IntPtr intptr_2, ref IntPtr intptr_3);

	[DllImport("mozsqlite3")]
	private static extern int sqlite3_step(IntPtr intptr_0);

	private IntPtr ResolveView(string string_0)
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
