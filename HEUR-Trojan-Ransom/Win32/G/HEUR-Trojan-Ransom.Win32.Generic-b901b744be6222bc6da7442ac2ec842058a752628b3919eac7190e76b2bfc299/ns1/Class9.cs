using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns2;

namespace ns1;

internal sealed class Class9 : Class8, IEnumerable<Class7>
{
	internal struct Struct3
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

	internal struct Struct4
	{
		public int int_0;

		public int int_1;
	}

	internal struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public Struct4 struct4_0;

		public Struct4 struct4_1;

		public Struct4 struct4_2;

		public Struct4 struct4_3;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;
	}

	internal struct Struct6
	{
		public int int_0;

		public int int_1;
	}

	internal struct Struct7
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;
	}

	internal struct Struct8
	{
		public int int_0;

		public Struct4 struct4_0;

		public int int_1;
	}

	internal struct Struct9
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct4 struct4_0;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;
	}

	internal List<Class7> list_0;

	[SpecialName]
	internal Struct3 struct3_0;

	[SpecialName]
	internal Struct4 struct4_0;

	public Class9()
	{
		list_0 = new List<Class7>();
	}

	IEnumerator<Class7> IEnumerable<Class7>.GetEnumerator()
	{
		Class34.smethod_34(this);
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Class34.smethod_34(this);
		return list_0.GetEnumerator();
	}
}
