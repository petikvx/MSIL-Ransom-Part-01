using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

[StandardModule]
internal sealed class Class17
{
	public delegate bool Delegate0([In] bool KillOnExit);

	[CompilerGenerated]
	internal class Class18
	{
		[CompilerGenerated]
		internal class Class19
		{
			public int int_0;

			public int int_1;

			public Class18 class18_0;

			[SpecialName]
			[CompilerGenerated]
			public void method_0()
			{
				Thread.CurrentThread.IsBackground = true;
				if (yfYkSKxi2E3pN3ihoM())
				{
				}
				Class20.Struct0 struct0_ = default(Class20.Struct0);
				uint uint_ = default(uint);
				int num = default(int);
				switch (3)
				{
				case 0:
				case 3:
					struct0_ = class18_0.struct0_0;
					goto default;
				default:
					uint_ = checked((uint)int_0);
					num = int_1;
					break;
				case 4:
					break;
				}
				Class21.smethod_68(num, struct0_, uint_);
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_1()
			{
				Class21.smethod_140(checked((int)class18_0.struct0_0.uint_0));
			}

			internal static bool rsokpfj9A8EbY4lkxA()
			{
				return true;
			}

			internal static bool yfYkSKxi2E3pN3ihoM()
			{
				return false;
			}
		}

		public Class20.Struct0 struct0_0;
	}

	private static T smethod_0<T>(string string_0, string string_1)
	{
		Conversion.Int((object)false);
		Conversion.Int((object)false);
		Conversion.Int((object)true);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class21.GetProcAddress(Class21.LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	internal static T smethod_1<T>(string string_0, string string_1)
	{
		IntPtr procAddress = Class21.GetProcAddress(Class21.smethod_49(string_0), string_1);
		object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
		return (T)delegateForFunctionPointer;
	}
}
