using System;
using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class30 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class30()
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
		Class45.random_0 = new Random(Class5.int_0);
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
		((ServiceBase)this).set_ServiceName("Service36");
	}
}
