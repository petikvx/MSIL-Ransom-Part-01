using System;
using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class27 : ServiceBase
{
	private IContainer icontainer_0;

	public Class27()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static Class20.Delegate1 smethod_0()
	{
		return (Class20.Delegate1)Delegate.CreateDelegate(typeof(Class20.Delegate1), Class33.smethod_0(), smethod_1());
	}

	internal static string smethod_1()
	{
		return Class17.smethod_0("a66d6964c6");
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
		((ServiceBase)this).set_ServiceName("Service33");
	}
}
