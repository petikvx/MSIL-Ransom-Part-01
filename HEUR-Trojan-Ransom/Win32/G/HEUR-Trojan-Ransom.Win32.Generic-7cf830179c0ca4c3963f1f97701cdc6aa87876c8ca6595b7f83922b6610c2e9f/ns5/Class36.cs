using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns2;
using ns4;
using ns7;

namespace ns5;

internal sealed class Class36 : IEnumerable<Class0>, IDisposable, IEnumerable
{
	private IntPtr intptr_0 = IntPtr.Zero;

	private Dictionary<Class40, List<Class0>> dictionary_0;

	private List<Class40> list_0;

	public List<Class0> this[Class38.Enum6 enum6_0]
	{
		get
		{
			return dictionary_0[new Class40(enum6_0)];
		}
		set
		{
			dictionary_0[new Class40(enum6_0)] = value;
		}
	}

	public List<Class0> this[string string_0]
	{
		get
		{
			return dictionary_0[new Class40(string_0)];
		}
		set
		{
			dictionary_0[new Class40(string_0)] = value;
		}
	}

	[SpecialName]
	public Dictionary<Class40, List<Class0>> method_0()
	{
		return dictionary_0;
	}

	public void method_1()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Class38.FreeLibrary(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	public void method_2(string string_0)
	{
		method_1();
		list_0 = new List<Class40>();
		dictionary_0 = new Dictionary<Class40, List<Class0>>();
		intptr_0 = Class38.LoadLibraryEx(string_0, IntPtr.Zero, 3u);
		if (IntPtr.Zero == intptr_0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class38.EnumResourceTypesW(intptr_0, method_3, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	private bool method_3(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3)
	{
		Class40 item = new Class40(intptr_2);
		list_0.Add(item);
		if (!Class38.EnumResourceNamesW(intptr_1, intptr_2, method_4, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	private bool method_4(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!Class38.EnumResourceLanguagesW(intptr_1, intptr_2, intptr_3, method_6, IntPtr.Zero))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		return true;
	}

	protected Class0 method_5(IntPtr intptr_1, IntPtr intptr_2, Class40 class40_0, Class40 class40_1, ushort ushort_0, int int_0)
	{
		if (class40_0.method_3())
		{
			switch (class40_0.method_2())
			{
			case Class38.Enum6.const_12:
				return new Class6(intptr_1, intptr_2, class40_0, class40_1, ushort_0, int_0);
			case Class38.Enum6.const_13:
				return new Class1(intptr_1, intptr_2, class40_0, class40_1, ushort_0, int_0);
			case Class38.Enum6.const_5:
				return new Class2(intptr_1, intptr_2, class40_0, class40_1, ushort_0, int_0);
			}
		}
		return new Class7(intptr_1, intptr_2, class40_0, class40_1, ushort_0, int_0);
	}

	private bool method_6(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, ushort ushort_0, IntPtr intptr_4)
	{
		List<Class0> value = null;
		Class40 @class = new Class40(intptr_2);
		if (!dictionary_0.TryGetValue(@class, out value))
		{
			value = new List<Class0>();
			dictionary_0[@class] = value;
		}
		Class40 class40_ = new Class40(intptr_3);
		IntPtr intptr_5 = Class38.FindResourceExW(intptr_1, intptr_2, intptr_3, ushort_0);
		IntPtr intptr_6 = Class38.LoadResource(intptr_1, intptr_5);
		int int_ = Class38.SizeofResource(intptr_1, intptr_5);
		value.Add(method_5(intptr_1, intptr_6, @class, class40_, ushort_0, int_));
		return true;
	}

	void IDisposable.Dispose()
	{
		method_1();
	}

	IEnumerator<Class0> IEnumerable<Class0>.GetEnumerator()
	{
		//yield-return decompiler failed: Method not found
		Class37 @class = new Class37(0);
		@class.class36_0 = this;
		return @class;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Class0>)this).GetEnumerator();
	}
}
