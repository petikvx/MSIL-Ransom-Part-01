using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class10 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class10()
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
	internal static Class22.Delegate2 smethod_0()
	{
		return Class49.delegate2_0;
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
		((ServiceBase)this).set_ServiceName("Service18");
	}
}
