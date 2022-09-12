using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class58
{
	private class e941e0c1
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public e941e0c1 e941e0c1_0;

		void object.Finalize()
		{
			try
			{
				if (intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intptr_0);
					intptr_0 = IntPtr.Zero;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public e941e0c1 method_0()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			return e941e0c1_0;
		}
	}

	private List<Struct3[]> a50f2478 = new List<Struct3[]>();

	private uint uint_0;

	private e941e0c1 e941e0c1_0;

	[SpecialName]
	public Struct3 method_0(uint uint_1)
	{
		if (uint_1 > uint_0)
		{
			return Struct3.struct3_0;
		}
		uint index = uint_1 >> 6;
		return a50f2478[(int)index][uint_1 & 0x3F];
	}

	[SpecialName]
	public void b53f41f9(uint uint_1, Struct3 struct3_0)
	{
		if (uint_1 <= uint_0)
		{
			uint index = uint_1 >> 6;
			a50f2478[(int)index][uint_1 & 0x3F] = struct3_0;
		}
	}

	public void method_1(uint uint_1)
	{
		if (uint_1 > int.MaxValue)
		{
			throw new StackOverflowException();
		}
		uint num = uint_1 >> 6;
		if (num >= a50f2478.Count)
		{
			do
			{
				a50f2478.Add(new Struct3[64]);
			}
			while (num >= a50f2478.Count);
		}
		else if (num < a50f2478.Count - 2)
		{
			do
			{
				a50f2478.RemoveAt(a50f2478.Count - 1);
			}
			while (num < a50f2478.Count - 2);
		}
		uint num2 = (uint_1 & 0x3F) + 1;
		Struct3[] array = a50f2478[(int)num];
		while (num2 < array.Length && array[num2].c9550f69() != null)
		{
			array[num2++] = Struct3.struct3_0;
		}
		if (num2 == array.Length && num + 1 < a50f2478.Count)
		{
			num2 = 0u;
			array = a50f2478[(int)(num + 1)];
			while (num2 < array.Length && array[num2].c9550f69() != null)
			{
				array[num2++] = Struct3.struct3_0;
			}
		}
		uint_0 = uint_1;
		method_2();
	}

	private void method_2()
	{
		while (e941e0c1_0 != null && e941e0c1_0.uint_0 > uint_0)
		{
			e941e0c1_0 = e941e0c1_0.method_0();
		}
	}

	public IntPtr method_3(uint uint_1, uint uint_2)
	{
		e941e0c1 e941e0c = new e941e0c1
		{
			uint_0 = uint_1,
			intptr_0 = Marshal.AllocHGlobal((int)uint_2)
		};
		e941e0c1 e941e0c2 = e941e0c1_0;
		while (e941e0c2 != null && e941e0c2.e941e0c1_0 != null && e941e0c2.e941e0c1_0.uint_0 >= uint_1)
		{
			e941e0c2 = e941e0c2.e941e0c1_0;
		}
		if (e941e0c2 == null)
		{
			e941e0c1_0 = e941e0c;
		}
		else
		{
			e941e0c.e941e0c1_0 = e941e0c2.e941e0c1_0;
			e941e0c2.e941e0c1_0 = e941e0c;
		}
		return e941e0c.intptr_0;
	}

	public void cf3316d6()
	{
		for (e941e0c1 e941e0c = e941e0c1_0; e941e0c != null; e941e0c = e941e0c.method_0())
		{
		}
		e941e0c1_0 = null;
	}

	void object.Finalize()
	{
		try
		{
			cf3316d6();
		}
		finally
		{
			base.Finalize();
		}
	}

	public void method_4(uint uint_1, Struct2 struct2_0, Type type_0)
	{
		if (uint_1 > uint_0)
		{
			throw new ExecutionEngineException();
		}
		Struct3[] array = a50f2478[(int)(uint_1 >> 6)];
		uint num = uint_1 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].method_7(struct2_0);
			Class61.smethod_0(struct2_0, type_0);
		}
		else
		{
			array[num].method_8(struct2_0, type_0);
		}
	}
}
