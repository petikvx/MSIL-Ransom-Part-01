using System;
using System.Collections;
using System.Collections.Generic;

namespace ns1;

public class NavMenuSubItemCollection : IList, ICollection, IEnumerable
{
	private List<NavMenuSubItem> list_0;

	internal NavMenuItem navMenuItem_0;

	public int Count => list_0.Count;

	public bool IsSynchronized => true;

	public object SyncRoot => this;

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

	public NavMenuSubItem this[int int_0]
	{
		get
		{
			if (int_0 < 0 || int_0 >= list_0.Count)
			{
				throw new ArgumentOutOfRangeException(" ");
			}
			return list_0[int_0];
		}
		set
		{
			if (int_0 < 0 || int_0 >= list_0.Count)
			{
				throw new ArgumentOutOfRangeException(" ");
			}
			list_0[int_0] = value;
			value.method_12(navMenuItem_0);
		}
	}

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			if (value is NavMenuSubItem)
			{
				this[index] = (NavMenuSubItem)value;
			}
		}
	}

	public NavMenuSubItemCollection()
	{
		list_0 = new List<NavMenuSubItem>();
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

	public NavMenuSubItem method_0(NavMenuSubItem navMenuSubItem_0)
	{
		list_0.Add(navMenuSubItem_0);
		navMenuSubItem_0.method_12(navMenuItem_0);
		return navMenuSubItem_0;
	}

	public bool method_1(NavMenuSubItem navMenuSubItem_0)
	{
		return list_0.Contains(navMenuSubItem_0);
	}

	public int method_2(NavMenuSubItem navMenuSubItem_0)
	{
		checked
		{
			int num = list_0.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (list_0[num2] == navMenuSubItem_0)
					{
						break;
					}
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
	}

	public void method_3(int int_0, NavMenuSubItem navMenuSubItem_0)
	{
		if (int_0 < 0 || int_0 >= list_0.Count)
		{
			throw new ArgumentOutOfRangeException(" ");
		}
		list_0.Insert(int_0, navMenuSubItem_0);
		navMenuSubItem_0.method_12(navMenuItem_0);
	}

	public void method_4(NavMenuSubItem navMenuSubItem_0)
	{
		list_0.Remove(navMenuSubItem_0);
	}

	int IList.Add(object value)
	{
		if (value is NavMenuSubItem)
		{
			return method_2(method_0((NavMenuSubItem)value));
		}
		return -1;
	}

	bool IList.Contains(object value)
	{
		if (value is NavMenuSubItem)
		{
			return method_1((NavMenuSubItem)value);
		}
		return false;
	}

	int IList.IndexOf(object value)
	{
		if (value is NavMenuSubItem)
		{
			return method_2((NavMenuSubItem)value);
		}
		return -1;
	}

	void IList.Insert(int index, object value)
	{
		if (value is NavMenuSubItem)
		{
			method_3(index, (NavMenuSubItem)value);
		}
	}

	void IList.Remove(object value)
	{
		if (value is NavMenuSubItem)
		{
			method_4((NavMenuSubItem)value);
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

	internal void method_5(NavMenuItem navMenuItem_1)
	{
		NavMenuItem navMenuItem = (navMenuItem_0 = navMenuItem_1);
		try
		{
			foreach (NavMenuSubItem item in list_0)
			{
				item.method_12(navMenuItem_0);
			}
		}
		finally
		{
			((IDisposable)default(List<NavMenuSubItem>.Enumerator)).Dispose();
		}
	}
}
