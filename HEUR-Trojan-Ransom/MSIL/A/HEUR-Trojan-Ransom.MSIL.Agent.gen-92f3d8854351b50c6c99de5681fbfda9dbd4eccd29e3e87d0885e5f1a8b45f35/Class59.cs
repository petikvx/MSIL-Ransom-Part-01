using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class59
{
	private class Class60
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public Class60 class60_0;

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

		public Class60 method_0()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			return class60_0;
		}
	}

	private List<facef383[]> afa349cd = new List<facef383[]>();

	private uint uint_0;

	private Class60 class60_0;

	[SpecialName]
	public facef383 a9bb6dff(uint uint_1)
	{
		if (uint_1 > uint_0)
		{
			return facef383.facef383_0;
		}
		uint index = uint_1 >> 6;
		return afa349cd[(int)index][uint_1 & 0x3F];
	}

	[SpecialName]
	public void method_0(uint uint_1, facef383 facef383_0)
	{
		if (uint_1 <= uint_0)
		{
			uint index = uint_1 >> 6;
			afa349cd[(int)index][uint_1 & 0x3F] = facef383_0;
		}
	}

	public void a85b6a89(uint uint_1)
	{
		if (uint_1 > int.MaxValue)
		{
			throw new StackOverflowException();
		}
		uint num = uint_1 >> 6;
		if (num >= afa349cd.Count)
		{
			do
			{
				afa349cd.Add(new facef383[64]);
			}
			while (num >= afa349cd.Count);
		}
		else if (num < afa349cd.Count - 2)
		{
			do
			{
				afa349cd.RemoveAt(afa349cd.Count - 1);
			}
			while (num < afa349cd.Count - 2);
		}
		uint num2 = (uint_1 & 0x3F) + 1;
		facef383[] array = afa349cd[(int)num];
		while (num2 < array.Length && array[num2].method_8() != null)
		{
			array[num2++] = facef383.facef383_0;
		}
		if (num2 == array.Length && num + 1 < afa349cd.Count)
		{
			num2 = 0u;
			array = afa349cd[(int)(num + 1)];
			while (num2 < array.Length && array[num2].method_8() != null)
			{
				array[num2++] = facef383.facef383_0;
			}
		}
		uint_0 = uint_1;
		method_1();
	}

	private void method_1()
	{
		while (class60_0 != null && class60_0.uint_0 > uint_0)
		{
			class60_0 = class60_0.method_0();
		}
	}

	public IntPtr method_2(uint uint_1, uint uint_2)
	{
		Class60 @class = new Class60
		{
			uint_0 = uint_1,
			intptr_0 = Marshal.AllocHGlobal((int)uint_2)
		};
		Class60 class2 = class60_0;
		while (class2 != null && class2.class60_0 != null && class2.class60_0.uint_0 >= uint_1)
		{
			class2 = class2.class60_0;
		}
		if (class2 == null)
		{
			class60_0 = @class;
		}
		else
		{
			@class.class60_0 = class2.class60_0;
			class2.class60_0 = @class;
		}
		return @class.intptr_0;
	}

	public void e2eab9a3()
	{
		for (Class60 @class = class60_0; @class != null; @class = @class.method_0())
		{
		}
		class60_0 = null;
	}

	void object.Finalize()
	{
		try
		{
			e2eab9a3();
		}
		finally
		{
			base.Finalize();
		}
	}

	public void method_3(uint uint_1, Struct0 struct0_0, Type type_0)
	{
		if (uint_1 > uint_0)
		{
			throw new ExecutionEngineException();
		}
		facef383[] array = afa349cd[(int)(uint_1 >> 6)];
		uint num = uint_1 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].method_10(struct0_0);
			Class63.smethod_0(struct0_0, type_0);
		}
		else
		{
			array[num].f62210d6(struct0_0, type_0);
		}
	}
}
