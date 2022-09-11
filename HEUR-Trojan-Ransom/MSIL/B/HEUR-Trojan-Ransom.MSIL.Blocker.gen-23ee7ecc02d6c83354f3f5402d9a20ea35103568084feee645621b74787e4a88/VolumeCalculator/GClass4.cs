using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "rlxF3uLkVkZciHuBKLTjWWRO7TzRu";

	public string string_1 = "pa3w4JsACFSJ5vif3YjmKkffz1ABX";

	public string string_2 = "GnVhaFuNzd74f4t1OYtvct8etb16J";

	public string string_3 = "KeyvNihNWXLwbPlkRTcoxZcYWmAnZ";

	public string string_4 = "sVXpoSp2InBNriXcx6RHXP1YNc6HP";

	public string string_5 = "4nYMyh671h7on5uIlkSAauEuK7A3h";

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
