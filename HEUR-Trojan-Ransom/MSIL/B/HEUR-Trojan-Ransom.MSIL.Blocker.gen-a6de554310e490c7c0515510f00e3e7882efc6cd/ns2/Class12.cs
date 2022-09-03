using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns2;

internal sealed class Class12
{
	internal sealed class Class13
	{
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}

	[ComVisible(false)]
	internal sealed class Class14<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}
	}

	private static readonly Class14<Class11> class14_0 = new Class14<Class11>();

	private static readonly Class14<Class10> class14_1 = new Class14<Class10>();

	private static readonly Class14<User> class14_2 = new Class14<User>();

	private static readonly Class14<Class13> class14_3 = new Class14<Class13>();

	[SpecialName]
	internal static Class11 smethod_0()
	{
		return class14_0.method_0();
	}
}
