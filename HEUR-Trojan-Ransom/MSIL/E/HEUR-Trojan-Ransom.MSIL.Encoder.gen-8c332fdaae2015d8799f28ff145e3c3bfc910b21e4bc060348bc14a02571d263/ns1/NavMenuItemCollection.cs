using System;
using System.Collections;
using System.Collections.Generic;

namespace ns1;

public sealed class NavMenuItemCollection : IList, ICollection, IEnumerable
{
	private NavMenu navMenu_0;

	private List<NavMenuItem> list_0;

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
		navMenu_0 = navMenu_1;
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

	public NavMenuItem method_0(NavMenuItem navMenuItem_0)
	{
		list_0.Add(navMenuItem_0);
		navMenuItem_0.method_12(navMenu_0);
		return navMenuItem_0;
	}

	public bool method_1(NavMenuItem navMenuItem_0)
	{
		return list_0.Contains(navMenuItem_0);
	}

	public int method_2(NavMenuItem navMenuItem_0)
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

	public void method_3(int int_0, NavMenuItem pbp1fPqEgvgWsjCgWZ8kPwKL5rIlc7GnNI9hPcT6aC46gKofWs2TlooSPbRvQ8Yi1XO0L7llV6VwgR7CLI9gVX3m2UhNiTy6BbEJx9pCAgwiuoyBaEDzwiNb8KSc)
	{
		if (int_0 < 0 || int_0 >= list_0.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		list_0.Insert(int_0, pbp1fPqEgvgWsjCgWZ8kPwKL5rIlc7GnNI9hPcT6aC46gKofWs2TlooSPbRvQ8Yi1XO0L7llV6VwgR7CLI9gVX3m2UhNiTy6BbEJx9pCAgwiuoyBaEDzwiNb8KSc);
		pbp1fPqEgvgWsjCgWZ8kPwKL5rIlc7GnNI9hPcT6aC46gKofWs2TlooSPbRvQ8Yi1XO0L7llV6VwgR7CLI9gVX3m2UhNiTy6BbEJx9pCAgwiuoyBaEDzwiNb8KSc.method_12(navMenu_0);
	}

	public void method_4(NavMenuItem navMenuItem_0)
	{
		list_0.Remove(navMenuItem_0);
	}

	int IList.Add(object value)
	{
		if (value is NavMenuItem)
		{
			return method_2(method_0((NavMenuItem)value));
		}
		return -1;
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
		if (value is NavMenuItem)
		{
			return method_2((NavMenuItem)value);
		}
		return -1;
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
			throw new ArgumentOutOfRangeException("index");
		}
		method_4(list_0[int_0]);
	}

	public void vmethod_3()
	{
		list_0.Clear();
	}
}
