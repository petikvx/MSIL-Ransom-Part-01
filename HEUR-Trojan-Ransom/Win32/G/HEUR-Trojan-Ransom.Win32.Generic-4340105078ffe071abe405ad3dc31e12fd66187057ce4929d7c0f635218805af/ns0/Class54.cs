using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class54 : ServiceBase
{
	private IContainer icontainer_0;

	public Class54()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static int smethod_0()
	{
		return 5;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ServiceBase)this).set_ServiceName("Service9");
	}
}
