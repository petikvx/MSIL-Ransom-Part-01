using System;
using System.Collections;
using System.Collections.Generic;

namespace ns0;

public sealed class NavMenuItemCollection : IList, ICollection, IEnumerable
{
	internal NavMenu navMenu_0;

	internal List<NavMenuItem> list_0;

	public int Count => list_0.Count;

	public bool IsSynchronized => true;

	public object SyncRoot => this;

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

	public NavMenuItem this[int int_0]
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	object IList.this[int index]
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public NavMenuItemCollection(NavMenu navMenu_1)
	{
	}

	public void vmethod_0(Array array_0, int int_0)
	{
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				array_0.SetValue(list_0[i], int_0 + i);
			}
		}
	}

	public IEnumerator vmethod_1()
	{
		return list_0.GetEnumerator();
	}

	public NavMenuItem method_0(NavMenuItem navMenuItem_0)
	{
		return null;
	}

	public bool method_1(NavMenuItem navMenuItem_0)
	{
		return list_0.Contains(navMenuItem_0);
	}

	public int method_2(NavMenuItem navMenuItem_0)
	{
		return -1;
	}

	public void method_3(int int_0, NavMenuItem navMenuItem_0)
	{
	}

	public void method_4(NavMenuItem navMenuItem_0)
	{
		list_0.Remove(navMenuItem_0);
	}

	int IList.Add(object value)
	{
		return 0;
	}

	bool IList.Contains(object value)
	{
		if (value is NavMenuItem)
		{
			return method_1((NavMenuItem)value);
		}
		return false;
	}

	int IList.IndexOf(object value)
	{
		return 0;
	}

	void IList.Insert(int index, object value)
	{
		if (value is NavMenuItem)
		{
			method_3(index, (NavMenuItem)value);
		}
	}

	void IList.Remove(object value)
	{
		if (value is NavMenuItem)
		{
			method_4((NavMenuItem)value);
		}
	}

	public void vmethod_2(int int_0)
	{
		if (int_0 < 0 || int_0 >= list_0.Count)
		{
			throw new ArgumentOutOfRangeException(" ");
		}
		method_4(list_0[int_0]);
	}

	public void vmethod_3()
	{
		list_0.Clear();
	}
}
