using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns2;

internal sealed class Class5
{
	[CompilerGenerated]
	internal sealed class Class6
	{
		public Class8.Struct0 struct0_0;

		public Class6(Class6 class6_0)
		{
			if (class6_0 != null)
			{
				struct0_0 = class6_0.struct0_0;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class Class7
	{
		public int int_0;

		public int int_1;

		public Class6 class6_0;

		public Class7(Class7 class7_0)
		{
			if (class7_0 != null)
			{
				int_0 = class7_0.int_0;
				int_1 = class7_0.int_1;
			}
		}

		[SpecialName]
		internal unsafe void method_0()
		{
			void* ptr = stackalloc byte[8];
			Thread.CurrentThread.IsBackground = true;
			Class8.Struct0 struct0_ = class6_0.struct0_0;
			*(uint*)ptr = checked((uint)int_0);
			*(int*)((byte*)ptr + 4) = int_1;
			Class13.smethod_21(*(uint*)ptr, struct0_, *(int*)((byte*)ptr + 4));
		}
	}

	internal static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class13.GetProcAddress(Class13.LoadLibraryA(ref string_0), string_1), typeof(T));
	}
}
