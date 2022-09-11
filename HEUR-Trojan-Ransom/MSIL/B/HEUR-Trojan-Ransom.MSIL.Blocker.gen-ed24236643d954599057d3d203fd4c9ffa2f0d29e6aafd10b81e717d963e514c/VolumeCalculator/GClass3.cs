using System.ComponentModel;
using System.Drawing;
using System.Resources;

namespace VolumeCalculator;

public class GClass3 : Component
{
	private IContainer icontainer_0 = null;

	public static Bitmap smethod_0(string string_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(string_0, typeof(GClass3).Assembly);
		return (Bitmap)resourceManager.GetObject(string_0);
	}

	public GClass3()
	{
		method_0();
	}

	public GClass3(IContainer icontainer_1)
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
