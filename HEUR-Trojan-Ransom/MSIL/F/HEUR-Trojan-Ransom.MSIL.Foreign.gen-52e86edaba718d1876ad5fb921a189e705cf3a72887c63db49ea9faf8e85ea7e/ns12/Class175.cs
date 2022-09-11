using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns14;
using ns2;
using ns21;
using ns7;

namespace ns12;

internal sealed class Class175
{
	private Class143 class143_0;

	private bool[] bool_0;

	private Dictionary<string, int> dictionary_0;

	private Dictionary<string, int> dictionary_1;

	private int int_0;

	private bool bool_1;

	private bool bool_2;

	private int int_1;

	private readonly int int_2;

	private bool bool_3;

	private List<Interface0[]> list_0;

	[CompilerGenerated]
	private readonly bool bool_4;

	[CompilerGenerated]
	private Class145[] class145_0;

	[CompilerGenerated]
	private Interface0[] interface0_0;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private int int_5;

	[NonSerialized]
	internal static GetString getString_0;

	public bool HasRows
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
	}

	public int Size
	{
		get
		{
			Class145[] fields = Fields;
			if (fields == null)
			{
				return 0;
			}
			return fields.Length;
		}
	}

	public Class145[] Fields
	{
		[CompilerGenerated]
		get
		{
			return class145_0;
		}
		[CompilerGenerated]
		private set
		{
			class145_0 = value;
		}
	}

	public Interface0[] Values
	{
		[CompilerGenerated]
		get
		{
			return interface0_0;
		}
		[CompilerGenerated]
		private set
		{
			interface0_0 = value;
		}
	}

	public bool IsOutputParameters
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public int AffectedRows
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		private set
		{
			int_3 = value;
		}
	}

	public long InsertedId
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		private set
		{
			long_0 = value;
		}
	}

	public int TotalRows
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		private set
		{
			int_4 = value;
		}
	}

	public int SkippedRows
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
		[CompilerGenerated]
		private set
		{
			int_5 = value;
		}
	}

	public bool Cached
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			if (bool_3 && list_0 == null)
			{
				list_0 = new List<Interface0[]>();
			}
		}
	}

	public Interface0 this[int int_6]
	{
		get
		{
			if (int_0 < 0)
			{
				throw new MySqlException(Class121.AttemptToAccessBeforeRead);
			}
			bool_0[int_6] = true;
			if (bool_2 && int_6 != int_1)
			{
				if (int_6 < int_1)
				{
					throw new MySqlException(Class121.ReadingPriorColumnUsingSeqAccess);
				}
				while (int_1 < int_6 - 1)
				{
					class143_0.method_8(Values[++int_1]);
				}
				Values[int_6] = class143_0.method_7(int_6, Fields[int_6], Values[int_6]);
				int_1 = int_6;
			}
			return Values[int_6];
		}
	}

	public Class175(int int_6, long long_1)
	{
		AffectedRows = int_6;
		InsertedId = long_1;
		bool_1 = true;
	}

	public Class175(Class143 class143_1, int int_6, int int_7)
	{
		AffectedRows = -1;
		InsertedId = -1L;
		class143_0 = class143_1;
		int_2 = int_6;
		int_0 = -1;
		method_10(int_7);
		IsOutputParameters = method_9();
		bool_4 = method_1();
		bool_1 = !HasRows;
	}

	public int method_0(string string_0)
	{
		if (dictionary_0.TryGetValue(string_0, out var value))
		{
			return value;
		}
		if (!dictionary_1.TryGetValue(string_0, out value))
		{
			throw new IndexOutOfRangeException(string.Format(Class121.CouldNotFindColumnName, string_0));
		}
		return value;
	}

	private bool method_1()
	{
		bool num = class143_0.vmethod_7(int_2, Size);
		if (num)
		{
			TotalRows++;
		}
		return num;
	}

	public bool method_2(CommandBehavior commandBehavior_0)
	{
		if (bool_1)
		{
			if (Cached)
			{
				return method_3(commandBehavior_0);
			}
			return false;
		}
		if ((commandBehavior_0 & CommandBehavior.SingleRow) != 0 && int_0 == 0)
		{
			return false;
		}
		bool_2 = (commandBehavior_0 & CommandBehavior.SequentialAccess) != 0;
		int_1 = -1;
		if (int_0 >= 0)
		{
			bool flag = false;
			try
			{
				flag = method_1();
			}
			catch (MySqlException ex)
			{
				if (ex.IsQueryAborted)
				{
					bool_1 = true;
				}
				throw;
			}
			if (!flag)
			{
				bool_1 = true;
				return false;
			}
		}
		if (!bool_2)
		{
			method_11(bool_6: false);
		}
		int_0++;
		return true;
	}

	private bool method_3(CommandBehavior commandBehavior_0)
	{
		if ((commandBehavior_0 & CommandBehavior.SingleRow) != 0 && int_0 == 0)
		{
			return false;
		}
		if (int_0 == TotalRows - 1)
		{
			return false;
		}
		int_0++;
		Values = list_0[int_0];
		return true;
	}

	public void method_4()
	{
		if (!bool_1)
		{
			if (HasRows && int_0 == -1)
			{
				SkippedRows++;
			}
			try
			{
				while (class143_0.IsOpen && class143_0.vmethod_8())
				{
					TotalRows++;
					SkippedRows++;
				}
			}
			catch (IOException)
			{
			}
			bool_1 = true;
		}
		else if (class143_0 == null)
		{
			method_5();
		}
		class143_0 = null;
		if (Cached)
		{
			method_6();
		}
	}

	private void method_5()
	{
		SkippedRows = TotalRows - int_0 - 1;
	}

	private void method_6()
	{
		if (Cached)
		{
			int_0 = -1;
			AffectedRows = -1;
			InsertedId = -1L;
			SkippedRows = 0;
		}
	}

	public bool method_7(int int_6)
	{
		return bool_0[int_6];
	}

	public void method_8(int int_6, Interface0 interface0_1)
	{
		Values[int_6] = interface0_1;
	}

	private bool method_9()
	{
		if (class143_0.method_2(Enum38.flag_8))
		{
			return true;
		}
		if (Fields.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < Fields.Length)
			{
				if (!Fields[num].string_1.StartsWith(getString_0(107354196), StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private void method_10(int int_6)
	{
		Fields = class143_0.method_6(int_6);
		Values = new Interface0[int_6];
		bool_0 = new bool[int_6];
		dictionary_0 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		dictionary_1 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		for (int i = 0; i < Fields.Length; i++)
		{
			string string_ = Fields[i].string_1;
			if (!dictionary_0.ContainsKey(string_))
			{
				dictionary_0.Add(string_, i);
			}
			if (!dictionary_1.ContainsKey(string_))
			{
				dictionary_1.Add(string_, i);
			}
			Values[i] = Fields[i].method_3();
		}
	}

	private void method_11(bool bool_6)
	{
		for (int i = 0; i < Size; i++)
		{
			Values[i] = class143_0.method_7(i, Fields[i], Values[i]);
		}
		if (Cached)
		{
			list_0.Add((Interface0[])Values.Clone());
		}
		if (bool_6)
		{
			bool num = class143_0.vmethod_7(int_2, Fields.Length);
			int_0 = 0;
			if (num)
			{
				throw new MySqlException(Class121.MoreThanOneOPRow);
			}
		}
	}

	static Class175()
	{
		Strings.CreateGetStringDelegate(typeof(Class175));
	}
}
