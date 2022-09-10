using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns2;

namespace ns1;

internal sealed class Class16 : IEnumerable<Class15>
{
	internal struct Struct10
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	internal struct Struct11
	{
		public int int_0;

		public int int_1;
	}

	internal struct Struct12
	{
		public int int_0;

		public Struct11 struct11_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal struct Struct13
	{
		public short short_0;

		public short short_1;

		public short short_2;

		public short short_3;

		public short short_4;

		public short short_5;

		public short short_6;

		public short short_7;
	}

	internal readonly Guid guid_0;

	internal Class14 class14_0;

	internal List<Class15> list_0;

	[SpecialName]
	internal Struct13 struct13_0;

	[SpecialName]
	internal Struct11 struct11_0;

	public Class16()
	{
		ref readonly Guid reference = ref guid_0;
		reference = new Guid("{E161255A-37C3-11D2-BCAA-00C04FD929DB}");
		class14_0 = new Class14();
		list_0 = new List<Class15>();
	}

	IEnumerator<Class15> IEnumerable<Class15>.GetEnumerator()
	{
		Class34.smethod_132(this);
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Class34.smethod_132(this);
		return list_0.GetEnumerator();
	}
}
