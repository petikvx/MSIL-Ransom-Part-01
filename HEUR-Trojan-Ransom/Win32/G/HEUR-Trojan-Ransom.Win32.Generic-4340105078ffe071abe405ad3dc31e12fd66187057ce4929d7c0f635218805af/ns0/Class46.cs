using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class46 : ServiceBase
{
	internal static int int_0 = Class10.smethod_0()(Class40.smethod_0(), Class4.int_0);

	internal IContainer icontainer_0;

	public Class46()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
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
		IContainer container = (icontainer_0 = new Container());
		((ServiceBase)this).set_ServiceName("Service50");
	}
}
