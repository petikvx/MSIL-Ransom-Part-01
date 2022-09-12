using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class55
{
	private class d4be077a
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public d4be077a d4be077a_0;

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

		public d4be077a method_0()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			return d4be077a_0;
		}
	}

	private List<feeb32c3[]> list_0 = new List<feeb32c3[]>();

	private uint uint_0;

	private d4be077a c563c0c7;

	[SpecialName]
	public feeb32c3 ff4c393f(uint uint_1)
	{
		if (uint_1 > uint_0)
		{
			return feeb32c3.feeb32c3_0;
		}
		uint index = uint_1 >> 6;
		return list_0[(int)index][uint_1 & 0x3F];
	}

	[SpecialName]
	public void method_0(uint uint_1, feeb32c3 feeb32c3_0)
	{
		if (uint_1 <= uint_0)
		{
			uint index = uint_1 >> 6;
			list_0[(int)index][uint_1 & 0x3F] = feeb32c3_0;
		}
	}

	public void method_1(uint uint_1)
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
				list_0.Add(new feeb32c3[64]);
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
		feeb32c3[] array = list_0[(int)num];
		while (num2 < array.Length && array[num2].cc3408c2() != null)
		{
			array[num2++] = feeb32c3.feeb32c3_0;
		}
		if (num2 == array.Length && num + 1 < list_0.Count)
		{
			num2 = 0u;
			array = list_0[(int)(num + 1)];
			while (num2 < array.Length && array[num2].cc3408c2() != null)
			{
				array[num2++] = feeb32c3.feeb32c3_0;
			}
		}
		uint_0 = uint_1;
		c75dbe94();
	}

	private void c75dbe94()
	{
		while (c563c0c7 != null && c563c0c7.uint_0 > uint_0)
		{
			c563c0c7 = c563c0c7.method_0();
		}
	}

	public IntPtr method_2(uint uint_1, uint uint_2)
	{
		d4be077a d4be077a = new d4be077a
		{
			uint_0 = uint_1,
			intptr_0 = Marshal.AllocHGlobal((int)uint_2)
		};
		d4be077a d4be077a_ = c563c0c7;
		while (d4be077a_ != null && d4be077a_.d4be077a_0 != null && d4be077a_.d4be077a_0.uint_0 >= uint_1)
		{
			d4be077a_ = d4be077a_.d4be077a_0;
		}
		if (d4be077a_ == null)
		{
			c563c0c7 = d4be077a;
		}
		else
		{
			d4be077a.d4be077a_0 = d4be077a_.d4be077a_0;
			d4be077a_.d4be077a_0 = d4be077a;
		}
		return d4be077a.intptr_0;
	}

	public void method_3()
	{
		for (d4be077a d4be077a = c563c0c7; d4be077a != null; d4be077a = d4be077a.method_0())
		{
		}
		c563c0c7 = null;
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
		feeb32c3[] array = list_0[(int)(uint_1 >> 6)];
		uint num = uint_1 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].d1bfa3d3(struct1_0);
			Class59.smethod_0(struct1_0, type_0);
		}
		else
		{
			array[num].method_8(struct1_0, type_0);
		}
	}
}
