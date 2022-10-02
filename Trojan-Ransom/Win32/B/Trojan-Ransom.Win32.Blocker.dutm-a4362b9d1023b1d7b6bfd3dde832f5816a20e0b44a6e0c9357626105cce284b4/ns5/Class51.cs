using System;
using System.Threading;
using ns6;
using ns7;
using ns8;

namespace ns5;

internal abstract class Class51
{
	internal sealed class Class53
	{
		public Class48 class48_0;

		public Class51 class51_0;

		public void method_0()
		{
			class51_0.method_1(class48_0);
		}
	}

	internal static bool bool_0;

	private Delegate3 delegate3_0;

	internal static readonly object object_0 = new object();

	internal void method_0(object sender, EventArgs e)
	{
		Class48 @class = Class29.smethod_167();
		if (!Class29.smethod_87(@class))
		{
			Class41 class2 = new Class41(@class);
			Class29.smethod_65((Class40)class2, (Delegate3)method_2);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class29.smethod_186();
			}
		}
	}

	protected abstract void vmethod_0(Class41 class41_0);

	protected abstract bool vmethod_1();

	private void method_1(Class48 class48_0)
	{
		Class41 @class = new Class41(class48_0);
		Class29.smethod_65((Class40)@class, (Delegate3)method_2);
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class29.smethod_61();
	}

	private void method_2(object sender, EventArgs4 e)
	{
		delegate3_0?.Invoke(sender, e);
	}
}
