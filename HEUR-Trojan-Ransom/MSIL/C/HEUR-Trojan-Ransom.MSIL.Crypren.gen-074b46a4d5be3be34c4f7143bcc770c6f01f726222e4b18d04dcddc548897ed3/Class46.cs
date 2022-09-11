using System;
using System.Collections;

internal class Class46 : IEnumerable
{
	public class Class47 : IEnumerator
	{
		private int int_0;

		private ArrayList arrayList_0;

		public Class39 Class39_0 => (Class39)arrayList_0[int_0];

		object IEnumerator.Current => Delegate528.smethod_0(this);

		internal Class47(ArrayList arrayList_1)
		{
			arrayList_0 = arrayList_1;
			int_0 = -1;
		}

		public bool MoveNext()
		{
			int_0 += Class84.smethod_0(1);
			return int_0 < arrayList_0.Count;
		}

		public void Reset()
		{
			int_0 = -1;
		}

		internal static int smethod_0(int int_1)
		{
			return int_1 switch
			{
				65 => -7, 
				67 => -121, 
				70 => -127, 
				72 => -9, 
				73 => -122, 
				75 => -3, 
				76 => -10, 
				77 => -123, 
				79 => -18, 
				82 => -24, 
				_ => -1, 
			};
		}
	}

	private Class44 class44_0;

	private ArrayList arrayList_0 = new ArrayList();

	public Class44 Class44_0 => class44_0;

	public int Int32_0 => arrayList_0.Count;

	public Class39 this[int index] => arrayList_0[index] as Class39;

	internal Class46(Class44 class44_1)
	{
		class44_0 = class44_1;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return Delegate524.smethod_0(this);
	}

	public void method_0(Class39 class39_0)
	{
		if (class39_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue883\ue888\ue89a\ue8ab\ue89f\ue88c\ue88a\ue880\ue888\ue883\ue899", 59492));
		}
		arrayList_0.Add(class39_0);
	}

	public Class47 method_1()
	{
		return Delegate525.smethod_0(arrayList_0);
	}

	public void method_2(Class39 class39_0)
	{
		if (class39_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\ue883\ue888\ue89a\ue8ab\ue89f\ue88c\ue88a\ue880\ue888\ue883\ue899", 59492));
		}
		arrayList_0.Insert(Class84.smethod_0(0), class39_0);
	}

	public void method_3(Class39 class39_0)
	{
		if (class39_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uea98\uea8c\uea9f\uea99\uea93\uea9b\uea90\uea8a", 60018));
		}
		int num = Delegate526.smethod_0(this, class39_0);
		if (num == -1)
		{
			throw new IndexOutOfRangeException();
		}
		Delegate527.smethod_0(this, num);
	}

	public void method_4()
	{
		arrayList_0.Clear();
	}

	public void method_5(int int_0)
	{
		arrayList_0.RemoveAt(int_0);
	}

	internal void method_6()
	{
		arrayList_0.Clear();
	}

	internal int method_7(Class39 class39_0)
	{
		if (class39_0 == null && 0 == 0)
		{
			throw new ArgumentNullException(Class86.smethod_0("\uea98\uea8c\uea9f\uea99\uea93\uea9b\uea90\uea8a", 60018));
		}
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < arrayList_0.Count)
			{
				if (arrayList_0[num] == class39_0)
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
