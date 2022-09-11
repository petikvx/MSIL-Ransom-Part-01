using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "uAN4PofyFaNYILbcphRhhLJcefDES";

	public string string_1 = "wVRe6VDLEmbUv4gGZRAzb4T7bSb3E";

	public string string_2 = "1vTXRSvxRA4ZSHNyK2BWHkLeofulY";

	public string string_3 = "FcmLhPr1C1l1zj2GOXgH1HKPEVADE";

	public string string_4 = "ShYtBNgYwvuCd5wTOcqMvPE0DF7FN";

	public string string_5 = "jE8mmaSCBYWFoIbo3GZJt2QPCueVF";

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
