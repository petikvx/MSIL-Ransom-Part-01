using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using ns2;
using ns5;

namespace ns0;

internal static class Class0
{
	public struct Struct2
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = 0u;
		}

		public void method_1()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void method_4()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_5()
		{
			return uint_0 < 7;
		}

		static Struct2()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
			GClass1.smethod_7();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal Struct9[] struct9_0;

		static Struct3()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct4
	{
		internal byte[] byte_0;

		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;

		internal Stream stream_0;

		static Struct4()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			return uint_0;
		}
		return 3u;
	}

	static Class0()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static IntPtr smethod_1(ref GCHandle gchandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return Class7.smethod_8(ref gchandle_0, 358, 348);
			}
		}
	}

	internal static Process[] smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 43:
				return Class7.smethod_12(1007, 985);
			}
		}
	}

	internal static Assembly smethod_3(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return Class9.smethod_10(type_0, 645, 644);
			}
		}
	}
}
