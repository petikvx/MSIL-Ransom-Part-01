using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "PAdubEM2nFWGXXuxhJdhOOXdd04UH";

	public string string_1 = "Q06cBVEadUWkmz26zenVHh3gp2qN8";

	public string string_2 = "3YUld6VRl67FarpZ6og1h2BUZ8s6L";

	public string string_3 = "d3CDalq37dcuRqympYdZTdZC6ZqKq";

	public string string_4 = "OfCMXuedq8ZoN751XX2KuAR7dgqaq";

	public string string_5 = "GQkl3m8PjL2rfoYWAGfB2s8i826LV";

	private IContainer icontainer_0 = null;

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
