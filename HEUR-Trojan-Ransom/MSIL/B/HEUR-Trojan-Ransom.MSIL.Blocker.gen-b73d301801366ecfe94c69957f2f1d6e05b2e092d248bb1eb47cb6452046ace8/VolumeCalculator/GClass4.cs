using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "wdYW7yY76Smp3elGoF4HNGhXxkgQl";

	public string string_1 = "1fxfUHWgUBOWNZgR5Gsc1b8n08c6Z";

	public string string_2 = "uH0tHyny4bv0QAMcgq3qjnSeyQTf5";

	public string string_3 = "vIzRRmiKvpGNnqkNRWCprS7Q5EKtN";

	public string string_4 = "8gAapIMev6sKF0Mha0bxdA8Kr1ZO1";

	public string string_5 = "IqKr1b3tFhWWCiRAWmXisXSxLSbh1";

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
