using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class23 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class23()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static void Main()
	{
		Class21.smethod_0();
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
		((ServiceBase)this).set_ServiceName("Service3");
	}
}
