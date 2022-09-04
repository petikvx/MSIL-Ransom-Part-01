using System;
using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class52 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class52()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static byte smethod_0(string string_0, int int_0)
	{
		return Convert.ToByte(string_0.Substring(int_0 * 2, 2), 16);
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
		((ServiceBase)this).set_ServiceName("Service7");
	}
}
