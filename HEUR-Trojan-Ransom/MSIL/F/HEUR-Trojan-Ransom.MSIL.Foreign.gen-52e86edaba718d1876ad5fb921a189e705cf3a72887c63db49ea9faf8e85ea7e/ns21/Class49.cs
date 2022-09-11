using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ns12;
using ns22;
using ns8;

namespace ns21;

internal abstract class Class49<T> : Class48, IEnumerable, IDisposable, IEnumerator, IEnumerable<T>, IEnumerator<T>
{
	protected int int_0;

	protected List<T> list_2 = new List<T>();

	protected bool bool_2;

	private Dictionary<string, int> dictionary_0 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

	internal List<Class47> list_3;

	[CompilerGenerated]
	private int int_1;

	protected Dictionary<string, int> NameMap => dictionary_0;

	public int PageSize
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	T IEnumerator<T>.Current
	{
		get
		{
			if (int_0 == list_2.Count)
			{
				throw new InvalidOperationException(string.Format(Class122.NoDataAtIndex, int_0));
			}
			return list_2[int_0];
		}
	}

	object IEnumerator.Current => System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent;

	internal Class49(Class79 class79_1)
		: base(class79_1)
	{
		method_1();
		PageSize = 20;
		int_0 = -1;
	}

	protected void method_1()
	{
		list_3 = new List<Class47>();
		if (bool_0)
		{
			list_3 = base.Protocol.vmethod_3();
			if (list_3.Count == 0)
			{
				bool_0 = false;
			}
			for (int i = 0; i < list_3.Count; i++)
			{
				dictionary_0.Add(list_3[i].ColumnLabel ?? list_3[i].ColumnName, i);
			}
		}
		else
		{
			base.Protocol.vmethod_4(this);
		}
	}

	public ReadOnlyCollection<T> method_2()
	{
		while (method_6())
		{
		}
		return list_2.AsReadOnly();
	}

	internal void method_3()
	{
		if (!bool_2)
		{
			while (vmethod_1(bool_3: true) != null)
			{
			}
			bool_2 = true;
		}
	}

	public T method_4()
	{
		if (!method_5())
		{
			return default(T);
		}
		return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent;
	}

	public bool method_5()
	{
		int_0++;
		if (int_0 >= list_2.Count)
		{
			if (bool_2)
			{
				return false;
			}
			if (!method_6())
			{
				bool_2 = true;
				return false;
			}
		}
		return true;
	}

	protected abstract T vmethod_1(bool bool_3);

	private bool method_6()
	{
		if (bool_2)
		{
			return false;
		}
		int num = 0;
		for (int i = 0; i < PageSize; i++)
		{
			T val = vmethod_1(bool_3: false);
			if (val != null)
			{
				list_2.Add(val);
				num++;
				continue;
			}
			bool_2 = !bool_0;
			class79_0.class48_0 = null;
			break;
		}
		return num > 0;
	}

	bool IEnumerator.MoveNext()
	{
		return method_5();
	}

	void IEnumerator.Reset()
	{
		int_0 = 0;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return this;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this;
	}

	protected override void vmethod_0()
	{
		method_2();
	}

	void IDisposable.Dispose()
	{
	}
}
