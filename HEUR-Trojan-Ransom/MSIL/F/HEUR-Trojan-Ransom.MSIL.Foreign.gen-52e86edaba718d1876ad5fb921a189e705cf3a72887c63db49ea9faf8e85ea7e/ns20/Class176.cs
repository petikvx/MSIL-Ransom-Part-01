using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns26;
using ns6;

namespace ns20;

internal sealed class Class176
{
	private readonly List<Class178> list_0 = new List<Class178>();

	private readonly List<Class177> list_1 = new List<Class177>();

	private readonly DataTable dataTable_0;

	internal Dictionary<string, int> dictionary_0;

	internal Dictionary<int, int> dictionary_1;

	[CompilerGenerated]
	private string string_0;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public IList<Class178> Columns => list_0;

	public IList<Class177> Rows => list_1;

	public Class176()
	{
		dictionary_0 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		dictionary_1 = new Dictionary<int, int>();
	}

	public Class176(string string_1)
		: this()
	{
		Name = string_1;
	}

	public Class176(DataTable dataTable_1)
		: this()
	{
		dataTable_0 = dataTable_1;
		int num = 0;
		foreach (DataColumn column in dataTable_1.Columns)
		{
			Columns.Add(new Class178
			{
				Name = column.ColumnName,
				Type = column.DataType
			});
			dictionary_0.Add(column.ColumnName, num++);
			dictionary_1[Columns.Count - 1] = Columns.Count - 1;
		}
		foreach (DataRow row in dataTable_1.Rows)
		{
			Class177 @class = new Class177(this);
			for (num = 0; num < Columns.Count; num++)
			{
				@class[num] = row[num];
			}
			Rows.Add(@class);
		}
	}

	internal Class178 method_0(string string_1, Type type_0)
	{
		Class178 @class = new Class178
		{
			Name = string_1,
			Type = type_0
		};
		list_0.Add(@class);
		dictionary_0.Add(string_1, list_0.Count - 1);
		dictionary_1[list_0.Count - 1] = list_0.Count - 1;
		return @class;
	}

	internal int method_1(string string_1)
	{
		int result = -1;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (string.Compare(list_0[i].Name, string_1, StringComparison.OrdinalIgnoreCase) == 0)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	internal void method_2(string string_1)
	{
		int num = method_1(string_1);
		if (num == -1)
		{
			throw new InvalidOperationException();
		}
		list_0.RemoveAt(num);
		for (int i = num; i < Columns.Count; i++)
		{
			dictionary_1[i] += 1;
		}
	}

	internal bool method_3(string string_1)
	{
		return method_1(string_1) >= 0;
	}

	internal Class177 method_4()
	{
		Class177 @class = new Class177(this);
		list_1.Add(@class);
		return @class;
	}

	internal Class177 method_5()
	{
		return new Class177(this);
	}

	internal DataTable method_6()
	{
		if (dataTable_0 != null)
		{
			return dataTable_0;
		}
		DataTable dataTable = new DataTable(Name);
		foreach (Class178 column in Columns)
		{
			dataTable.Columns.Add(column.Name, column.Type);
		}
		foreach (Class177 row in Rows)
		{
			DataRow dataRow = dataTable.NewRow();
			for (int i = 0; i < dataTable.Columns.Count; i++)
			{
				dataRow[i] = ((row[i] == null) ? DBNull.Value : row[i]);
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	static Class176()
	{
		Strings.CreateGetStringDelegate(typeof(Class176));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399420), getString_0(107399415)).Replace(getString_0(107399378), getString_0(107399373)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399368)))
		{
			throw new SecurityException(getString_0(107399343));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
