using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class64
{
	private class e0ceb48b
	{
		public uint f40f4cf5;

		public IntPtr intptr_0;

		public e0ceb48b bdaa02ef;

		protected override void bbd6d667()
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

		public e0ceb48b a470806e()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			return bdaa02ef;
		}
	}

	private List<ebd9b488[]> list_0 = new List<ebd9b488[]>();

	private uint a4b8b731;

	private e0ceb48b e0ceb48b_0;

	[SpecialName]
	public ebd9b488 method_0(uint uint_0)
	{
		if (uint_0 > a4b8b731)
		{
			return ebd9b488.ebd9b488_0;
		}
		uint index = uint_0 >> 6;
		return list_0[(int)index][uint_0 & 0x3F];
	}

	[SpecialName]
	public void method_1(uint uint_0, ebd9b488 ebd9b488_0)
	{
		if (uint_0 <= a4b8b731)
		{
			uint index = uint_0 >> 6;
			list_0[(int)index][uint_0 & 0x3F] = ebd9b488_0;
		}
	}

	public void method_2(uint uint_0)
	{
		if (uint_0 > int.MaxValue)
		{
			throw new StackOverflowException();
		}
		uint num = uint_0 >> 6;
		if (num >= list_0.Count)
		{
			do
			{
				list_0.Add(new ebd9b488[64]);
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
		uint num2 = (uint_0 & 0x3F) + 1;
		ebd9b488[] array = list_0[(int)num];
		while (num2 < array.Length && array[num2].ec0d6773() != null)
		{
			array[num2++] = ebd9b488.ebd9b488_0;
		}
		if (num2 == array.Length && num + 1 < list_0.Count)
		{
			num2 = 0u;
			array = list_0[(int)(num + 1)];
			while (num2 < array.Length && array[num2].ec0d6773() != null)
			{
				array[num2++] = ebd9b488.ebd9b488_0;
			}
		}
		a4b8b731 = uint_0;
		d661f7ad();
	}

	private void d661f7ad()
	{
		while (e0ceb48b_0 != null && e0ceb48b_0.f40f4cf5 > a4b8b731)
		{
			e0ceb48b_0 = e0ceb48b_0.a470806e();
		}
	}

	public IntPtr method_3(uint uint_0, uint uint_1)
	{
		e0ceb48b e0ceb48b = new e0ceb48b
		{
			f40f4cf5 = uint_0,
			intptr_0 = Marshal.AllocHGlobal((int)uint_1)
		};
		e0ceb48b bdaa02ef = e0ceb48b_0;
		while (bdaa02ef != null && bdaa02ef.bdaa02ef != null && bdaa02ef.bdaa02ef.f40f4cf5 >= uint_0)
		{
			bdaa02ef = bdaa02ef.bdaa02ef;
		}
		if (bdaa02ef == null)
		{
			e0ceb48b_0 = e0ceb48b;
		}
		else
		{
			e0ceb48b.bdaa02ef = bdaa02ef.bdaa02ef;
			bdaa02ef.bdaa02ef = e0ceb48b;
		}
		return e0ceb48b.intptr_0;
	}

	public void method_4()
	{
		for (e0ceb48b e0ceb48b = e0ceb48b_0; e0ceb48b != null; e0ceb48b = e0ceb48b.a470806e())
		{
		}
		e0ceb48b_0 = null;
	}

	protected override void bbd6d667()
	{
		try
		{
			method_4();
		}
		finally
		{
			base.Finalize();
		}
	}

	public void method_5(uint uint_0, f06aee96 f06aee96_0, Type type_0)
	{
		if (uint_0 > a4b8b731)
		{
			throw new ExecutionEngineException();
		}
		ebd9b488[] array = list_0[(int)(uint_0 >> 6)];
		uint num = uint_0 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].d86faad8(f06aee96_0);
			bc2a451.smethod_0(f06aee96_0, type_0);
		}
		else
		{
			array[num].method_4(f06aee96_0, type_0);
		}
	}
}
