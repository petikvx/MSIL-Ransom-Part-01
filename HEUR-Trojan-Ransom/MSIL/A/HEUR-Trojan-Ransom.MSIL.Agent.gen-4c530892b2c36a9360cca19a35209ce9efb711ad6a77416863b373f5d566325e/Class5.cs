using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class5
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Rectangle rectangle_0;

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public Rectangle Rectangle_0
	{
		[CompilerGenerated]
		get
		{
			return rectangle_0;
		}
		[CompilerGenerated]
		private set
		{
			rectangle_0 = value;
		}
	}

	public Class5(int int_2, int int_3)
	{
		Int32_0 = int_2;
		Int32_1 = int_3;
		Rectangle_0 = default(Rectangle);
	}

	public Brush method_0()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		Brush val = Class5.smethod_0();
		Random random_ = Class5.smethod_1();
		Type type_ = Class5.smethod_2(typeof(Brushes).TypeHandle);
		PropertyInfo[] array = Class5.smethod_3(type_);
		int num = Class5.smethod_4(random_, array.Length);
		val = (Brush)Class5.smethod_5(array[num], (object)null, (object[])null);
		if (val == Class5.smethod_6() || val == Class5.smethod_7())
		{
			return method_0();
		}
		return val;
	}

	static Brush smethod_0()
	{
		return Brushes.get_Transparent();
	}

	static Random smethod_1()
	{
		return new Random();
	}

	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static PropertyInfo[] smethod_3(Type type_0)
	{
		return type_0.GetProperties();
	}

	static int smethod_4(Random random_0, int int_2)
	{
		return random_0.Next(int_2);
	}

	static object smethod_5(PropertyInfo propertyInfo_0, object object_0, object[] object_1)
	{
		return propertyInfo_0.GetValue(object_0, object_1);
	}

	static Brush smethod_6()
	{
		return Brushes.get_White();
	}

	static Brush smethod_7()
	{
		return Brushes.get_Black();
	}
}
