using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal class Class1
{
	private enum Enum0
	{
		const_0
	}

	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int Int32_0 => 24;
	}

	private enum Enum1
	{
		const_0 = 0x400
	}

	public static void smethod_0(int int_0)
	{
		int[] array = Delegate91.smethod_0(int_0);
		foreach (int int_ in array)
		{
			using Process object_ = Delegate79.smethod_0(int_);
			Delegate83.smethod_0(object_);
		}
		using Process object_2 = Delegate79.smethod_0(int_0);
		Delegate83.smethod_0(object_2);
	}

	public static int smethod_1(int int_0)
	{
		int result = 0;
		int num = Delegate92.smethod_0(Enum1.const_0, bool_0: false, int_0);
		if (num != 0)
		{
			try
			{
				Struct0 struct0_ = default(Struct0);
				int int_ = 0;
				if (-1 != Delegate93.smethod_0(num, Enum0.const_0, ref struct0_, struct0_.Int32_0, ref int_))
				{
					return struct0_.int_5;
				}
				return result;
			}
			finally
			{
				Delegate94.smethod_0(num);
			}
		}
		return result;
	}

	public static int[] smethod_2(int int_0)
	{
		ArrayList object_ = Delegate95.smethod_0();
		Process[] array = Delegate56.smethod_0();
		foreach (Process object_2 in array)
		{
			int num = Delegate81.smethod_0(object_2);
			Delegate84.smethod_0(object_2);
			if (int_0 == Delegate94.smethod_1(num))
			{
				Delegate96.smethod_0(object_, num);
				Delegate97.smethod_0(object_, Delegate91.smethod_0(num));
			}
		}
		return (int[])Delegate99.smethod_0(object_, Delegate98.smethod_0(typeof(int).TypeHandle));
	}

	[DllImport("KERNEL32.DLL")]
	private static extern int OpenProcess(Enum1 enum1_0, bool bool_0, int int_0);

	[DllImport("KERNEL32.DLL")]
	private static extern int CloseHandle(int int_0);

	[DllImport("NTDLL.DLL")]
	private static extern int NtQueryInformationProcess(int int_0, Enum0 enum0_0, ref Struct0 struct0_0, int int_1, ref int int_2);
}
