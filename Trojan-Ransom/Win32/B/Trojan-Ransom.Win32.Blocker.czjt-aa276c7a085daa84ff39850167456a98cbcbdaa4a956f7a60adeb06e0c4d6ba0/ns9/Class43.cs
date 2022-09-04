using System;
using System.Threading;
using ns1;
using ns3;
using ns5;
using ns7;

namespace ns9;

internal abstract class Class43
{
	internal sealed class Class45
	{
		public Class40 class40_0;

		public Class43 class43_0;

		public void method_0()
		{
			class43_0.method_1(class40_0);
		}
	}

	internal static bool bool_0;

	private Delegate3 delegate3_0;

	internal static readonly object object_0 = new object();

	internal void method_0(object sender, EventArgs e)
	{
		Class40 @class = Class24.smethod_54();
		if (!Class24.smethod_178(@class))
		{
			Class33 class2 = new Class33(@class);
			Class24.smethod_162((Class32)class2, (Delegate3)method_2);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class24.smethod_181();
			}
		}
	}

	protected abstract void vmethod_0(Class33 class33_0);

	protected abstract bool vmethod_1();

	private void method_1(Class40 class40_0)
	{
		Class33 @class = new Class33(class40_0);
		Class24.smethod_162((Class32)@class, (Delegate3)method_2);
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class24.smethod_172();
	}

	private void method_2(object sender, EventArgs4 e)
	{
		delegate3_0?.Invoke(sender, e);
	}
}
