using System;
using System.Collections;
using System.Runtime.InteropServices;
using ns2;

namespace ns1;

internal sealed class Class13 : Class8, IEnumerator, IEnumerable
{
	internal GInterface3 ginterface3_0;

	internal Enum1 enum1_0;

	internal Guid guid_0;

	internal Guid guid_1;

	internal GInterface0 ginterface0_0;

	private Class12 class12_0;

	object IEnumerator.Current => class12_0;

	internal Class13(GInterface3 ginterface3_1, Enum1 enum1_1, ref Guid guid_2, ref Guid guid_3)
	{
		guid_0 = default(Guid);
		guid_1 = default(Guid);
		ginterface3_0 = ginterface3_1;
		enum1_0 = enum1_1;
		guid_0 = guid_2;
		guid_1 = guid_3;
		ginterface0_0 = ginterface3_1.EnumItems(enum1_1, ref guid_2, ref guid_3, 0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Reset();
		return this;
	}

	public void Reset()
	{
		ginterface0_0.Reset();
	}

	bool IEnumerator.MoveNext()
	{
		int rgelt = default(int);
		int pceltFetched = default(int);
		if (ginterface0_0.Next(1, ref rgelt, ref pceltFetched) != 0)
		{
			return false;
		}
		if (rgelt != 0)
		{
			class12_0 = new Class12();
			Class12 @class = class12_0;
			GInterface3 gInterface = ginterface3_0;
			Enum1 @enum = enum1_0;
			ref Guid reference = ref guid_0;
			ref Guid reference2 = ref guid_1;
			IntPtr intPtr = default(IntPtr);
			IntPtr intptr_ = intPtr;
			intPtr = new IntPtr(rgelt);
			string string_ = Class34.smethod_142(intptr_, (Class8)this);
			Class34.smethod_65(ref reference, ref reference2, string_, @class, gInterface, @enum);
			intPtr = new IntPtr(rgelt);
			Marshal.FreeCoTaskMem(intPtr);
		}
		return true;
	}
}
