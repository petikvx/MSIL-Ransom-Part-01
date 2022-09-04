using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class31 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class31()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static byte[] smethod_0(string string_0)
	{
		return SoapHexBinary.Parse(string_0).get_Value();
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
		((ServiceBase)this).set_ServiceName("Service37");
	}
}
