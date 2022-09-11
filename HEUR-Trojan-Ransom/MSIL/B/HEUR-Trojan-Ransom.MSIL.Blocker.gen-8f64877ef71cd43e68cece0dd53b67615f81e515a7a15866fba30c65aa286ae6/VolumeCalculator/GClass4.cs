using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "CjLOHWOV4jMPHHemEjVuFTL8wGYbM";

	public string string_1 = "CxdG81Ic5lzvptoTnlDcAChCuTjUL";

	public string string_2 = "Uw5s5p5F4JVRrY6RLRmATDc2wh8tQ";

	public string string_3 = "ITAqDnjbsd4dMESN0Uhlkvq05f3He";

	public string string_4 = "pJp0fvddEQiJyIjRnGpLraLLCosRZ";

	public string string_5 = "tnTPxwYCxDymDbyoAsBLvIOZ6886m";

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
