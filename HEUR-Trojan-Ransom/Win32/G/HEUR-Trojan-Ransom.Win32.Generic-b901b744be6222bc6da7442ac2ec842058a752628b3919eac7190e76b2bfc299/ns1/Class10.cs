using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns2;

namespace ns1;

internal sealed class Class10 : Class8, IEnumerable<Class17>
{
	internal struct Struct14
	{
		public int int_0;

		public int int_1;
	}

	private struct Struct15
	{
		public int int_0;

		public int int_1;
	}

	internal struct Struct16
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct15 struct15_0;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;
	}

	internal List<Class17> list_0;

	[SpecialName]
	internal byte[] byte_0;

	public Class10()
	{
		list_0 = new List<Class17>();
	}

	IEnumerator<Class17> IEnumerable<Class17>.GetEnumerator()
	{
		Class34.smethod_12(this);
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Class34.smethod_12(this);
		return list_0.GetEnumerator();
	}
}
