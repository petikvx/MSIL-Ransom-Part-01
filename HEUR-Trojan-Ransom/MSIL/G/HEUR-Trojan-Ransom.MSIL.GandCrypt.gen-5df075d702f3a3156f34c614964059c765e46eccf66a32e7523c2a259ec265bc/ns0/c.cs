using System.ComponentModel;

namespace ns0;

public class c : Component
{
	private IContainer icontainer_0;

	public static byte[] byte_0 = new byte[16]
	{
		16, 2, 20, 6, 18, 5, 19, 13, 1, 17,
		3, 11, 4, 8, 7, 10
	};

	public c()
	{
		method_0();
	}

	public c(IContainer icontainer_1)
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
