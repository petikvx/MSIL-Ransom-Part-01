using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 110)]
	private struct Struct1
	{
	}

	private const int int_0 = 32;

	private readonly DataColumn[] dataColumn_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[55];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static string smethod_0()
	{
		return "nvldumdx.Program";
	}

	internal void method_0(DataColumn[] dataColumn_1, bool bool_0)
	{
		int num = 0;
		while (true)
		{
			if (num < dataColumn_1.Length)
			{
				if (dataColumn_1[num] != null)
				{
					num++;
					continue;
				}
				throw Class5.smethod_0("column");
			}
			for (int i = 0; i < dataColumn_1.Length; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (dataColumn_1[i] == dataColumn_1[j])
					{
						throw Class5.smethod_1(dataColumn_1[i].ColumnName);
					}
				}
			}
			if (bool_0)
			{
				dataColumn_1 = new DataColumn[dataColumn_1.Length];
				for (int k = 0; k < dataColumn_1.Length; k++)
				{
					dataColumn_0[k] = dataColumn_1[k];
				}
			}
			else
			{
				dataColumn_1 = dataColumn_1;
			}
			break;
		}
		method_1();
	}

	internal static byte[] smethod_1()
	{
		return Class1.smethod_0(Class0.smethod_0(), Class2.byte_0);
	}

	internal void method_1()
	{
		DataTable table = dataColumn_0[0].Table;
		if (table == null)
		{
			throw Class5.smethod_3();
		}
		int num = 1;
		while (true)
		{
			if (num < dataColumn_0.Length)
			{
				if (dataColumn_0[num].Table != null)
				{
					if (dataColumn_0[num].Table != table)
					{
						break;
					}
					num++;
					continue;
				}
				throw Class5.smethod_3();
			}
			return;
		}
		throw Class5.smethod_2();
	}

	[SecuritySafeCritical]
	static Class4()
	{
		char[] array = new char[8];
		array[7] = '㨗';
		array[2] = 'ឳ';
		array[6] = 'ˌ';
		array[0] = '⪀';
		array[5] = '\u0ccf';
		array[1] = '൮';
		array[3] = 'ប';
		array[4] = 'ኲ';
		object_1 = new string[4];
		object_0 = array;
	}
}
