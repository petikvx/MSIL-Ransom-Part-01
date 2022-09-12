using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class c6a36180
{
	private class e801bc9a
	{
		public uint uint_0;

		public IntPtr fa17c08b;

		public e801bc9a e801bc9a_0;

		void object.Finalize()
		{
			try
			{
				if (fa17c08b != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(fa17c08b);
					fa17c08b = IntPtr.Zero;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public e801bc9a method_0()
		{
			if (fa17c08b != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(fa17c08b);
				fa17c08b = IntPtr.Zero;
			}
			return e801bc9a_0;
		}
	}

	private List<Struct2[]> list_0 = new List<Struct2[]>();

	private uint uint_0;

	private e801bc9a e801bc9a_0;

	[SpecialName]
	public Struct2 f113e6df(uint uint_1)
	{
		if (uint_1 > uint_0)
		{
			return Struct2.struct2_0;
		}
		uint index = uint_1 >> 6;
		return list_0[(int)index][uint_1 & 0x3F];
	}

	[SpecialName]
	public void f43586b2(uint uint_1, Struct2 struct2_0)
	{
		if (uint_1 <= uint_0)
		{
			uint index = uint_1 >> 6;
			list_0[(int)index][uint_1 & 0x3F] = struct2_0;
		}
	}

	public void method_0(uint uint_1)
	{
		if (uint_1 > int.MaxValue)
		{
			throw new StackOverflowException();
		}
		uint num = uint_1 >> 6;
		if (num >= list_0.Count)
		{
			do
			{
				list_0.Add(new Struct2[64]);
			}
			while (num >= list_0.Count);
		}
		else if (num < list_0.Count - 2)
		{
			do
			{
				list_0.RemoveAt(list_0.Count - 1);
			}
			while (num < list_0.Count - 2);
		}
		uint num2 = (uint_1 & 0x3F) + 1;
		Struct2[] array = list_0[(int)num];
		while (num2 < array.Length && array[num2].a90ed1e2() != null)
		{
			array[num2++] = Struct2.struct2_0;
		}
		if (num2 == array.Length && num + 1 < list_0.Count)
		{
			num2 = 0u;
			array = list_0[(int)(num + 1)];
			while (num2 < array.Length && array[num2].a90ed1e2() != null)
			{
				array[num2++] = Struct2.struct2_0;
			}
		}
		uint_0 = uint_1;
		method_1();
	}

	private void method_1()
	{
		while (e801bc9a_0 != null && e801bc9a_0.uint_0 > uint_0)
		{
			e801bc9a_0 = e801bc9a_0.method_0();
		}
	}

	public IntPtr method_2(uint uint_1, uint uint_2)
	{
		e801bc9a e801bc9a = new e801bc9a
		{
			uint_0 = uint_1,
			fa17c08b = Marshal.AllocHGlobal((int)uint_2)
		};
		e801bc9a e801bc9a2 = e801bc9a_0;
		while (e801bc9a2 != null && e801bc9a2.e801bc9a_0 != null && e801bc9a2.e801bc9a_0.uint_0 >= uint_1)
		{
			e801bc9a2 = e801bc9a2.e801bc9a_0;
		}
		if (e801bc9a2 == null)
		{
			e801bc9a_0 = e801bc9a;
		}
		else
		{
			e801bc9a.e801bc9a_0 = e801bc9a2.e801bc9a_0;
			e801bc9a2.e801bc9a_0 = e801bc9a;
		}
		return e801bc9a.fa17c08b;
	}

	public void method_3()
	{
		for (e801bc9a e801bc9a = e801bc9a_0; e801bc9a != null; e801bc9a = e801bc9a.method_0())
		{
		}
		e801bc9a_0 = null;
	}

	void object.Finalize()
	{
		try
		{
			method_3();
		}
		finally
		{
			base.Finalize();
		}
	}

	public void method_4(uint uint_1, Struct1 struct1_0, Type type_0)
	{
		if (uint_1 > uint_0)
		{
			throw new ExecutionEngineException();
		}
		Struct2[] array = list_0[(int)(uint_1 >> 6)];
		uint num = uint_1 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].method_8(struct1_0);
			Class57.c271ba87(struct1_0, type_0);
		}
		else
		{
			array[num].f1932236(struct1_0, type_0);
		}
	}
}
