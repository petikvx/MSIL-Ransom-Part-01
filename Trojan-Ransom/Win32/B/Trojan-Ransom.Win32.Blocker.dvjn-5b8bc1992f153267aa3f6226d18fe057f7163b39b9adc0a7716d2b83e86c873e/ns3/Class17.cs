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
				Class20.Struct0 struct0_ = class18_0.struct0_0;
				uint uint_ = checked((uint)int_0);
				int num = int_1;
				Class58.smethod_73(uint_, num, struct0_);
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_1()
			{
				Class58.smethod_29(checked((int)class18_0.struct0_0.uint_0));
			}

			internal static bool L7qyXWp5N94WnHPWg6()
			{
				return true;
			}

			internal static bool HI5oE3hpH0fDAVwg9j()
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
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class58.GetProcAddress(Class58.LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	internal static T smethod_1<T>(string string_0, string string_1)
	{
		IntPtr procAddress = Class58.GetProcAddress(Class58.smethod_21(string_0), string_1);
		object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
		return (T)delegateForFunctionPointer;
	}
}
