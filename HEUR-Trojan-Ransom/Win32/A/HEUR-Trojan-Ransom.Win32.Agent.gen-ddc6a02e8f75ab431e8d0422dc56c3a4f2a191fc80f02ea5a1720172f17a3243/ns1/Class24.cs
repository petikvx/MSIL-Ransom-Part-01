using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;

namespace ns1;

internal sealed class Class24 : IDisposable, IEnumerable<Class5>, IEnumerable
{
	private IntPtr intptr_0 = IntPtr.Zero;

	private Dictionary<Class4, List<Class5>> dictionary_0;

	private List<Class4> list_0;

	public List<Class5> this[Class3.Enum1 enum1_0]
	{
		get
		{
			return dictionary_0[new Class4(enum1_0)];
		}
		set
		{
			dictionary_0[new Class4(enum1_0)] = value;
		}
	}

	public List<Class5> this[string string_0]
	{
		get
		{
			return dictionary_0[new Class4(string_0)];
		}
		set
		{
			dictionary_0[new Class4(string_0)] = value;
		}
	}

	[SpecialName]
	public Dictionary<Class4, List<Class5>> method_0()
	{
		return dictionary_0;
	}

	public void method_1()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Class3.FreeLibrary(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	public void method_2(string string_0)
	{
		method_1();
		list_0 = new List<Class4>();
		dictionary_0 = new Dictionary<Class4, List<Class5>>();
		intptr_0 = Class3.LoadLibraryEx(string_0, IntPtr.Zero, 3u);
		if (IntPtr.Zero == intptr_0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class3.EnumResourceTypesW(intptr_0, method_3, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	private bool method_3(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
	{
		Class4 item = new Class4(intptr_2);
		list_0.Add(item);
		if (!Class3.EnumResourceNamesW(intptr_1, intptr_2, method_4, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	private bool method_4(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!Class3.EnumResourceLanguagesW(intptr_1, intptr_2, intptr_3, method_6, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	protected Class5 method_5(IntPtr intptr_1, IntPtr intptr_2, Class4 class4_0, Class4 class4_1, ushort ushort_0, int int_0)
	{
		if (class4_0.method_3())
		{
			switch (class4_0.method_2())
			{
			case Class3.Enum1.const_12:
				return new Class10(intptr_1, intptr_2, class4_0, class4_1, ushort_0, int_0);
			case Class3.Enum1.const_13:
				return new Class6(intptr_1, intptr_2, class4_0, class4_1, ushort_0, int_0);
			case Class3.Enum1.const_5:
				return new Class12(intptr_1, intptr_2, class4_0, class4_1, ushort_0, int_0);
			}
		}
		return new Class11(intptr_1, intptr_2, class4_0, class4_1, ushort_0, int_0);
	}

	private bool method_6(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, ushort ushort_0, IntPtr intptr_4)
	{
		List<Class5> value = null;
		Class4 @class = new Class4(intptr_2);
		if (!dictionary_0.TryGetValue(@class, out value))
		{
			value = new List<Class5>();
			dictionary_0[@class] = value;
		}
		Class4 class4_ = new Class4(intptr_3);
		IntPtr intptr_5 = Class3.FindResourceExW(intptr_1, intptr_2, intptr_3, ushort_0);
		IntPtr intptr_6 = Class3.LoadResource(intptr_1, intptr_5);
		int int_ = Class3.SizeofResource(intptr_1, intptr_5);
		value.Add(method_5(intptr_1, intptr_6, @class, class4_, ushort_0, int_));
		return true;
	}

	void IDisposable.Dispose()
	{
		method_1();
	}

	IEnumerator<Class5> IEnumerable<Class5>.GetEnumerator()
	{
		//yield-return decompiler failed: Method not found
		Class25 @class = new Class25(0);
		@class.class24_0 = this;
		return @class;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Class5>)this).GetEnumerator();
	}
}
