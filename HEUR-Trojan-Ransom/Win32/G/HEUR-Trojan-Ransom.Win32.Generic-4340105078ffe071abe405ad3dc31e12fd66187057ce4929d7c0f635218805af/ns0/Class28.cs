using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class28 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class28()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static byte[] smethod_0()
	{
		Class7.int_0 = Class4.int_0;
		while (Class7.int_0 <= Class12.smethod_0())
		{
			Class39.smethod_0()[Class7.int_0] = (byte)Class37.smethod_0();
			Class7.int_0++;
		}
		return null;
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
		((ServiceBase)this).set_ServiceName("Service34");
	}
}
