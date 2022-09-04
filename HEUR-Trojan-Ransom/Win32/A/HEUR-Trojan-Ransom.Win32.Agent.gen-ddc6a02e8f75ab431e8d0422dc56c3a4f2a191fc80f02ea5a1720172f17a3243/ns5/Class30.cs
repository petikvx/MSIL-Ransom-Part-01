using System.ComponentModel;
using System.ServiceProcess;
using ns0;

namespace ns5;

internal sealed class Class30 : ServiceBase
{
	private IContainer icontainer_0;

	void ServiceBase.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void method_0()
	{
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanStop(false);
		((ServiceBase)this).set_ServiceName("winvsp");
	}

	public Class30()
	{
		method_0();
	}

	void ServiceBase.OnStart(string[] args)
	{
		Class0.smethod_1();
	}

	void ServiceBase.OnStop()
	{
	}
}
