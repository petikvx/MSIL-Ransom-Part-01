using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class26 : ServiceBase
{
	internal delegate byte[] Delegate4(string string_0);

	private IContainer icontainer_0;

	public Class26()
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
		icontainer_0 = new Container();
		((ServiceBase)this).set_ServiceName("Service32");
	}
}
