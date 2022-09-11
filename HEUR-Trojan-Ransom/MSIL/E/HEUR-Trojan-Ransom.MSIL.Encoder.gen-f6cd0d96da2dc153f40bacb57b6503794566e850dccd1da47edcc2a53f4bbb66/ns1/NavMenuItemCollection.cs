using System;
using System.Collections;
using System.Collections.Generic;

namespace ns1;

public sealed class NavMenuItemCollection : IList, ICollection, IEnumerable
{
	private List<NavMenuItem> list_0;

	internal NavMenu navMenu_0;

	public int Count => list_0.Count;

	public bool IsSynchronized => true;

	public object SyncRoot => this;

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

	public NavMenuItem this[int int_0]
	{
		get
		{
			if (int_0 < 0 || int_0 >= list_0.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return list_0[int_0];
		}
		set
		{
			if (int_0 < 0 || int_0 >= list_0.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			list_0[int_0] = value;
			value.method_12(navMenu_0);
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
			if (value is NavMenuItem)
			{
				this[index] = (NavMenuItem)value;
			}
		}
	}

	public NavMenuItemCollection(NavMenu navMenu_1)
	{
		NavMenu navMenu = (navMenu_0 = navMenu_1);
		list_0 = new List<NavMenuItem>();
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

	public NavMenuItem rnFZcz2CddRS7pR55HBjrxd3HoT5fCazH4QRMIOOo9jv2iKKHoFbZBY2NYkLCbIt0Gr2MKLcK2AGwJ6ZbRRE5ZlNLMdjJXRqW1iCuqyjnlTcmt0N4GOmglnpI9xn8ne4eO5TBAlI(NavMenuItem navMenuItem_0)
	{
		list_0.Add(navMenuItem_0);
		navMenuItem_0.method_12(navMenu_0);
		return navMenuItem_0;
	}

	public bool method_0(NavMenuItem navMenuItem_0)
	{
		return list_0.Contains(navMenuItem_0);
	}

	public int method_1(NavMenuItem navMenuItem_0)
	{
		checked
		{
			int num = list_0.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (list_0[num2] == navMenuItem_0)
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

	public void method_2(int int_0, NavMenuItem navMenuItem_0)
	{
		if (int_0 < 0 || int_0 >= list_0.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		list_0.Insert(int_0, navMenuItem_0);
		navMenuItem_0.method_12(navMenu_0);
	}

	public void method_3(NavMenuItem navMenuItem_0)
	{
		list_0.Remove(navMenuItem_0);
	}

	int IList.Add(object value)
	{
		if (value is NavMenuItem)
		{
			return method_1(rnFZcz2CddRS7pR55HBjrxd3HoT5fCazH4QRMIOOo9jv2iKKHoFbZBY2NYkLCbIt0Gr2MKLcK2AGwJ6ZbRRE5ZlNLMdjJXRqW1iCuqyjnlTcmt0N4GOmglnpI9xn8ne4eO5TBAlI((NavMenuItem)value));
		}
		return -1;
	}

	bool IList.Contains(object value)
	{
		if (value is NavMenuItem)
		{
			return method_0((NavMenuItem)value);
		}
		return false;
	}

	int IList.IndexOf(object value)
	{
		if (value is NavMenuItem)
		{
			return method_1((NavMenuItem)value);
		}
		return -1;
	}

	void IList.Insert(int index, object value)
	{
		if (value is NavMenuItem)
		{
			method_2(index, (NavMenuItem)value);
		}
	}

	void IList.Remove(object value)
	{
		if (value is NavMenuItem)
		{
			method_3((NavMenuItem)value);
		}
	}

	public void vmethod_2(int int_0)
	{
		if (int_0 < 0 || int_0 >= list_0.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		method_3(list_0[int_0]);
	}

	public void vmethod_3()
	{
		list_0.Clear();
	}
}
