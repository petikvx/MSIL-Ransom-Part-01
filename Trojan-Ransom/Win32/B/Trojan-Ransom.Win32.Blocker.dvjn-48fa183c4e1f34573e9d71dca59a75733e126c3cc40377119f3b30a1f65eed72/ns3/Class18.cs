using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

[StandardModule]
internal sealed class Class18
{
	public delegate bool Delegate0([In] bool KillOnExit);

	[CompilerGenerated]
	internal class Class19
	{
		[CompilerGenerated]
		internal class Class20
		{
			public int int_0;

			public int int_1;

			public Class19 class19_0;

			[SpecialName]
			[CompilerGenerated]
			public void method_0()
			{
				Thread.CurrentThread.IsBackground = true;
				Class21.Struct0 struct0_ = class19_0.struct0_0;
				uint uint_ = checked((uint)int_0);
				int num = int_1;
				Class12.smethod_34(uint_, num, struct0_);
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_1()
			{
				Class12.smethod_127(checked((int)class19_0.struct0_0.uint_0));
			}

			internal static bool jI5hyjo7Vx0Gg5NToT()
			{
				return true;
			}

			internal static bool B8EXCdwU1njXMx8LSn()
			{
				return false;
			}
		}

		public Class21.Struct0 struct0_0;
	}

	private static T smethod_0<T>(string string_0, string string_1)
	{
		Conversion.Int((object)false);
		Conversion.Int((object)false);
		Conversion.Int((object)true);
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class12.GetProcAddress(Class12.LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	internal static T smethod_1<T>(string string_0, string string_1)
	{
		IntPtr procAddress = Class12.GetProcAddress(Class12.smethod_109(string_0), string_1);
		object delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(T));
		return (T)delegateForFunctionPointer;
	}
}
