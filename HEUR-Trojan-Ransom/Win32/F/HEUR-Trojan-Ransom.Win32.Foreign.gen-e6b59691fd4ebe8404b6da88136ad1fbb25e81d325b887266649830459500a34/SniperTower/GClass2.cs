using System.ComponentModel;

namespace SniperTower;

public class GClass2 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "iWy6xbpPXU2lNsOCbUFoTDRDGaAQy";

	public string string_1 = "rrtWbJNoyUlA03UyFXHyplmJSBT7E";

	public string string_2 = "lpVLRKRNMQTZDlqcIFK6Uqm3x5ZDv";

	public string string_3 = "NPd0HVbY0bsrhBzsxYqmctpCq4kL1";

	public string string_4 = "bI7MEq0k26YDMHjY3jduL8QZfqXmm";

	public string string_5 = "MZTFDRMfdVVE2WITCYn2huFtDobug";

	private IContainer icontainer_0 = null;

	public GClass2()
	{
		method_0();
	}

	public GClass2(IContainer icontainer_1)
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
