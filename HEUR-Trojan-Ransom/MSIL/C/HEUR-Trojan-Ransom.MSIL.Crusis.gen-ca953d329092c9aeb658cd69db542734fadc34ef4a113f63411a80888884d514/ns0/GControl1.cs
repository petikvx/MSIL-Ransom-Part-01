using System.ComponentModel;
using System.Windows.Forms;
using ns1;

namespace ns0;

public class GControl1 : UserControl
{
	private IContainer icontainer_0;

	public GControl1()
	{
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(bool_0);
	}

	public static void smethod_0()
	{
		Control3.appDomain_0.AssemblyResolve += Class4.smethod_0;
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
	}
}
