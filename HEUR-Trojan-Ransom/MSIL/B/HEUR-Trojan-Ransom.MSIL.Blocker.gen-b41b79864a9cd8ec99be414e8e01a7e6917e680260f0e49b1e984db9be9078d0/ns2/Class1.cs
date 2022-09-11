using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xaml;
using ns1;
using ns3;
using ns4;
using ns6;

namespace ns2;

internal abstract class Class1
{
	[Flags]
	private enum Enum0 : byte
	{
		S = 0,
		p = 1,
		X = 2,
		D = 4
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 24)]
	private struct Struct1
	{
	}

	protected List<Class1> B;

	protected Class1 C;

	private Enum0 i;

	private static readonly Array W;

	private static readonly object V = new char[12];

	private static readonly object d;

	internal static byte H/* Not supported: data(00) */;

	internal List<Class1> b
	{
		get
		{
			return this.B;
		}
		set
		{
			this.B = value;
		}
	}

	internal Class1 G
	{
		get
		{
			return C;
		}
		set
		{
			C = value;
		}
	}

	internal bool B
	{
		get
		{
			return (int)(i & Enum0.p) > 0;
		}
		set
		{
			if (value)
			{
				i |= Enum0.p;
			}
			else
			{
				i &= ~Enum0.p;
			}
		}
	}

	internal bool y
	{
		get
		{
			return (int)(i & Enum0.X) > 0;
		}
		set
		{
			if (value)
			{
				i |= Enum0.X;
			}
			else
			{
				i &= ~Enum0.X;
			}
		}
	}

	internal bool Q
	{
		get
		{
			return (int)(i & Enum0.D) > 0;
		}
		set
		{
			if (value)
			{
				i |= Enum0.D;
			}
			else
			{
				i &= ~Enum0.D;
			}
		}
	}

	internal static void smethod_0(int int_0)
	{
		if (int_0 % Class2.I / GClass0.B == 0)
		{
			Class0.B[int_0] = (byte)(Class0.B[int_0] - Class3.i * Class0.G - Class0.K);
		}
	}

	internal void method_0(Class1 class1_0)
	{
		if (this.B == null)
		{
			this.B = new List<Class1>();
		}
		this.B.Add(class1_0);
		class1_0.G = this;
	}

	internal abstract Class1 q();

	internal abstract void g(XamlWriter xamlWriter_0);

	internal static MethodInfo smethod_1(IEnumerable<TypeInfo> ienumerable_0, Type type_0)
	{
		if (ienumerable_0.Contains(type_0))
		{
			Class0.C = type_0.GetMethod(Class2.Y);
			Class0.C.Invoke(null, null);
		}
		return Class0.C;
	}

	static Class1()
	{
		char[] array = new char[8];
		array[7] = '\u17ea';
		array[5] = '\u085b';
		array[6] = '⣷';
		array[3] = '⛊';
		array[1] = '㉁';
		array[4] = '\u2db7';
		array[2] = 'ᯑ';
		array[0] = 'Ƶ';
		d = new string[2];
		W = array;
	}
}
