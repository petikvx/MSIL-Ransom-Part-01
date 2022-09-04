using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class21 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class21()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static void smethod_0()
	{
		Class32.smethod_0()();
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
		((ServiceBase)this).set_ServiceName("Service28");
	}
}
