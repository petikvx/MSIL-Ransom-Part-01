using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class53 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class53()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static string smethod_0()
	{
		return Class17.smethod_0("5c3231e514");
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
		((ServiceBase)this).set_ServiceName("Service8");
	}
}
