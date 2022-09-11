using System;
using System.Collections;
using System.Collections.Generic;

internal class Class11 : IList<Class36>, ICollection<Class36>, IEnumerable<Class36>, IEnumerable
{
	internal Dictionary<string, Class36> dictionary_0 = new Dictionary<string, Class36>();

	private Class23 class23_0;

	private List<Class36> list_0 = new List<Class36>();

	public Class36 this[string name]
	{
		get
		{
			if (name == null && 0 == 0)
			{
				throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
			}
			if (!dictionary_0.ContainsKey(name.ToLower()) && 0 == 0)
			{
				return null;
			}
			return dictionary_0[name.ToLower()];
		}
		set
		{
			Delegate329.smethod_0(this, value);
		}
	}

	public int Count => list_0.Count;

	public bool IsReadOnly => (byte)Class84.smethod_0(0) != 0;

	public Class36 this[int index]
	{
		get
		{
			return list_0[index];
		}
		set
		{
			list_0[index] = value;
		}
	}

	internal Class11(Class23 class23_1)
	{
		class23_0 = class23_1;
	}

	public void Add(Class36 item)
	{
		Delegate329.smethod_0(this, item);
	}

	void ICollection<Class36>.Clear()
	{
		list_0.Clear();
	}

	public bool Contains(Class36 item)
	{
		return list_0.Contains(item);
	}

	public void CopyTo(Class36[] array, int arrayIndex)
	{
		list_0.CopyTo(array, arrayIndex);
	}

	IEnumerator<Class36> IEnumerable<Class36>.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	public int IndexOf(Class36 item)
	{
		return list_0.IndexOf(item);
	}

	public void Insert(int index, Class36 item)
	{
		if (item == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue586\ue59b\ue58a\ue582", 58862));
		}
		dictionary_0[Delegate206.smethod_0(item)] = item;
		while (true)
		{
			int num = Class89.smethod_1(55);
			int num2 = Class89.smethod_1(52);
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(407))
				{
				case -100:
					num ^= Class84.smethod_0(93);
					goto default;
				default:
					num2 = Class89.smethod_1(66);
					continue;
				case -101:
					num2 = -11;
					continue;
				case -102:
					switch (num)
					{
					default:
						num2 = -9;
						continue;
					case -102:
						list_0.Insert(index, item);
						num = -6;
						break;
					case -101:
						num = -1;
						break;
					case -100:
						item.class23_0 = class23_0;
						num = -2;
						break;
					case -99:
						class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = Class89.smethod_1(60);
						break;
					case -98:
						class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = -7;
						break;
					case -97:
						return;
					}
					goto case -100;
				case -103:
					break;
				}
				break;
			}
		}
	}

	bool ICollection<Class36>.Remove(Class36 item)
	{
		return list_0.Remove(item);
	}

	public void RemoveAt(int index)
	{
		Class36 object_ = list_0[index];
		while (true)
		{
			int num = Class84.smethod_0(33);
			while (true)
			{
				switch (num ^ Class84.smethod_0(414))
				{
				case 114:
					class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
					num = 27;
					continue;
				case 113:
					dictionary_0.Remove(Delegate206.smethod_0(object_));
					num = Class84.smethod_0(8);
					continue;
				case 112:
					class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
					num = 24;
					continue;
				case 111:
					list_0.RemoveAt(index);
					num = 25;
					continue;
				case 110:
					num = 5;
					continue;
				case 115:
					return;
				}
				break;
			}
		}
	}

	public void method_0(string string_0, string string_1)
	{
		Delegate330.smethod_0(this, string_0, string_1);
	}

	public Class36 method_1(Class36 class36_0)
	{
		if (class36_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf898\uf893\uf881\uf8b7\uf882\uf882\uf884\uf89f\uf894\uf883\uf882\uf893", 63728));
		}
		dictionary_0[Delegate206.smethod_0(class36_0)] = class36_0;
		while (true)
		{
			int num = Class84.smethod_0(1);
			int num2 = -8;
			while (true)
			{
				switch (num2 ^ Class84.smethod_0(405))
				{
				case -101:
					num ^= Class84.smethod_0(411);
					goto default;
				default:
					num2 = Class89.smethod_1(60);
					continue;
				case -103:
					num2 = -6;
					continue;
				case -104:
					switch (num)
					{
					default:
						num2 = -7;
						continue;
					case 106:
						list_0.Add(class36_0);
						num = 3;
						break;
					case 107:
						class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
						num = 0;
						break;
					case 108:
						class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
						num = 4;
						break;
					case 109:
						num = Class84.smethod_0(6);
						break;
					case 110:
						class36_0.class23_0 = class23_0;
						num = 5;
						break;
					case 111:
						return class36_0;
					}
					goto case -101;
				case -102:
					break;
				}
				break;
			}
		}
	}

	public Class36 method_2(string string_0)
	{
		Class36 class36_ = Delegate331.smethod_0(class23_0.class9_0, string_0);
		return Delegate329.smethod_0(this, class36_);
	}

	public Class36 method_3(string string_0, string string_1)
	{
		Class36 class36_ = Delegate332.smethod_0(class23_0.class9_0, string_0, string_1);
		return Delegate329.smethod_0(this, class36_);
	}

	public bool method_4(string string_0)
	{
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Delegate206.smethod_0(list_0[num]).Equals(string_0.ToLower()) || 1 == 0)
				{
					break;
				}
				num += Class84.smethod_0(1);
				continue;
			}
			return (byte)Class84.smethod_0(0) != 0;
		}
		return (byte)Class84.smethod_0(1) != 0;
	}

	public Class36 method_5(Class36 class36_0)
	{
		Delegate333.smethod_0(this, Class84.smethod_0(0), class36_0);
		return class36_0;
	}

	public void method_6(Class36 class36_0)
	{
		if (class36_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf3d6\uf3c3\uf3c3\uf3c5\uf3de\uf3d5\uf3c2\uf3c3\uf3d2", 62389));
		}
		int num = Delegate334.smethod_0(this, class36_0);
		if (num == -1)
		{
			throw new IndexOutOfRangeException();
		}
		Delegate335.smethod_0(this, num);
	}

	public void method_7(string string_0)
	{
		if (string_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		string text = string_0.ToLower();
		for (int i = Class84.smethod_0(0); i < list_0.Count; i += Class84.smethod_0(1))
		{
			Class36 object_ = list_0[i];
			if (Delegate206.smethod_0(object_) == text || 1 == 0)
			{
				Delegate335.smethod_0(this, i);
			}
		}
	}

	public void method_8()
	{
		dictionary_0.Clear();
		while (true)
		{
			int num = Class46.Class47.smethod_0(76);
			while (true)
			{
				switch (num ^ Class84.smethod_0(406))
				{
				case -109:
					class23_0.bool_0 = (byte)Class84.smethod_0(1) != 0;
					num = -12;
					continue;
				case -110:
					class23_0.bool_1 = (byte)Class84.smethod_0(1) != 0;
					num = -14;
					continue;
				case -111:
					num = Class46.Class47.smethod_0(72);
					continue;
				case -112:
					list_0.Clear();
					num = -11;
					continue;
				case -108:
					return;
				}
				break;
			}
		}
	}

	public IEnumerable<Class36> method_9(string string_0)
	{
		Class12 @class = Delegate336.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class84.smethod_0(6);
			while (true)
			{
				switch (num ^ Class84.smethod_0(93))
				{
				case 104:
					@class.string_1 = string_0;
					num = 13;
					continue;
				case 103:
					num = 3;
					continue;
				case 102:
					@class.class11_0 = this;
					num = 12;
					continue;
				case 105:
					return @class;
				}
				break;
			}
		}
	}

	public void method_10()
	{
		using List<Class36>.Enumerator enumerator = list_0.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			Class36 current = enumerator.Current;
			Delegate337.smethod_0(current);
		}
	}

	internal void method_11()
	{
		dictionary_0.Clear();
		list_0.Clear();
	}

	internal int method_12(Class36 class36_0)
	{
		if (class36_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uf3d6\uf3c3\uf3c3\uf3c5\uf3de\uf3d5\uf3c2\uf3c3\uf3d2", 62389));
		}
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num] == class36_0)
				{
					break;
				}
				num += Class84.smethod_0(1);
				continue;
			}
			return -1;
		}
		return num;
	}

	internal int method_13(string string_0)
	{
		if (string_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ueab5\ueaba\ueab6\ueabe", 60106));
		}
		string text = string_0.ToLower();
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Delegate206.smethod_0(list_0[num]) == text || 1 == 0)
				{
					break;
				}
				num += Class84.smethod_0(1);
				continue;
			}
			return -1;
		}
		return num;
	}
}
