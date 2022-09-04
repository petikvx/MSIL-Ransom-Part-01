using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class38 : ServiceBase
{
	private IContainer icontainer_0;

	public Class38()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	[SpecialName]
	internal static Class25.Delegate3 smethod_0()
	{
		return (Class25.Delegate3)Delegate.CreateDelegate(typeof(Class25.Delegate3), typeof(Convert).GetMethod(Class17.smethod_0("4b546f42797465"), new Type[1] { typeof(int) }));
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
		((ServiceBase)this).set_ServiceName("Service43");
	}
}
