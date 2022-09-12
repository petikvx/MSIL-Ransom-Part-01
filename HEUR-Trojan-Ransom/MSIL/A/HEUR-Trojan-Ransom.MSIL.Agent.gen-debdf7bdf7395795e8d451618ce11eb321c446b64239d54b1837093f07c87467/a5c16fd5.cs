using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class a5c16fd5
{
	private class Class51
	{
		public uint uint_0;

		public IntPtr cf55b98c;

		public Class51 a63277b;

		void object.Finalize()
		{
			try
			{
				if (cf55b98c != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(cf55b98c);
					cf55b98c = IntPtr.Zero;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public Class51 f015bbca()
		{
			if (cf55b98c != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(cf55b98c);
				cf55b98c = IntPtr.Zero;
			}
			return a63277b;
		}
	}

	private List<Struct2[]> list_0 = new List<Struct2[]>();

	private uint uint_0;

	private Class51 edd6c4d8;

	[SpecialName]
	public Struct2 a59d7f30(uint uint_1)
	{
		if (uint_1 > uint_0)
		{
			return Struct2.struct2_0;
		}
		uint index = uint_1 >> 6;
		return list_0[(int)index][uint_1 & 0x3F];
	}

	[SpecialName]
	public void d1cb88cf(uint uint_1, Struct2 struct2_0)
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
		while (num2 < array.Length && array[num2].method_6() != null)
		{
			array[num2++] = Struct2.struct2_0;
		}
		if (num2 == array.Length && num + 1 < list_0.Count)
		{
			num2 = 0u;
			array = list_0[(int)(num + 1)];
			while (num2 < array.Length && array[num2].method_6() != null)
			{
				array[num2++] = Struct2.struct2_0;
			}
		}
		uint_0 = uint_1;
		method_1();
	}

	private void method_1()
	{
		while (edd6c4d8 != null && edd6c4d8.uint_0 > uint_0)
		{
			edd6c4d8 = edd6c4d8.f015bbca();
		}
	}

	public IntPtr method_2(uint uint_1, uint uint_2)
	{
		Class51 @class = new Class51
		{
			uint_0 = uint_1,
			cf55b98c = Marshal.AllocHGlobal((int)uint_2)
		};
		Class51 a63277b = edd6c4d8;
		while (a63277b != null && a63277b.a63277b != null && a63277b.a63277b.uint_0 >= uint_1)
		{
			a63277b = a63277b.a63277b;
		}
		if (a63277b == null)
		{
			edd6c4d8 = @class;
		}
		else
		{
			@class.a63277b = a63277b.a63277b;
			a63277b.a63277b = @class;
		}
		return @class.cf55b98c;
	}

	public void method_3()
	{
		for (Class51 @class = edd6c4d8; @class != null; @class = @class.f015bbca())
		{
		}
		edd6c4d8 = null;
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

	public void c4cba08f(uint uint_1, fe387972 fe387972_0, Type type_0)
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
			array[num].cd3aa414(fe387972_0);
			Class55.dae92d78(fe387972_0, type_0);
		}
		else
		{
			array[num].bbd4063(fe387972_0, type_0);
		}
	}
}
