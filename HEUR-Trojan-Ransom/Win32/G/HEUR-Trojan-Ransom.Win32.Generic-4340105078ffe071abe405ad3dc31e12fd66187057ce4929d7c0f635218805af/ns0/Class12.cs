using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class12 : ServiceBase
{
	private IContainer icontainer_0;

	public Class12()
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
	internal static int smethod_0()
	{
		return Class39.smethod_0().Length - 1;
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
		((ServiceBase)this).set_ServiceName("Service2");
	}
}
