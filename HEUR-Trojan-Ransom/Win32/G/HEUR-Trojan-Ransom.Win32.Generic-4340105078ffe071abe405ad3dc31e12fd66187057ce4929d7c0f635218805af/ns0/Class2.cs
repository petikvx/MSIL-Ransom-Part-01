using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class2 : ServiceBase
{
	private static readonly string string_0 = Class53.smethod_0();

	internal IContainer icontainer_0;

	public Class2()
	{
		method_0();
	}

	[SpecialName]
	internal static string smethod_0()
	{
		return string_0;
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
		((ServiceBase)this).set_ServiceName("Service10");
	}
}
