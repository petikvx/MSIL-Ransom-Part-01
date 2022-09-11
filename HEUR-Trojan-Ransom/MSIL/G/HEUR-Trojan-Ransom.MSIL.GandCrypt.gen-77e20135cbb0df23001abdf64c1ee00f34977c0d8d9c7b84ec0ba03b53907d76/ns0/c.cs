using System.ComponentModel;

namespace ns0;

public class c : Component
{
	private IContainer icontainer_0;

	public static byte[] byte_0 = new byte[16]
	{
		102, 8, 61, 72, 104, 84, 159, 31, 53, 52,
		175, 86, 63, 131, 167, 147
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
