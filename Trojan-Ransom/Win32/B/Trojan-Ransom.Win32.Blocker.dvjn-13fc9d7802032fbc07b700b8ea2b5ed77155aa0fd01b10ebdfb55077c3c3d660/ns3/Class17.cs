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
				Class56.smethod_30(num, uint_, struct0_);
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_1()
			{
				Class56.smethod_121(checked((int)class18_0.struct0_0.uint_0));
			}

			internal static bool Gs3qt4CrJk5hQMi1lk()
			{
				return true;
			}

			internal static bool sYeQni4uwleYk073QI()
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
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class56.GetProcAddress(Class56.LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	internal static T smethod_1<T>(string string_0, string string_1)
	{
		IntPtr procAddress = Class56.GetProcAddress(Class56.smethod_111(string_0), string_1);
		object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
		return (T)delegateForFunctionPointer;
	}
}
