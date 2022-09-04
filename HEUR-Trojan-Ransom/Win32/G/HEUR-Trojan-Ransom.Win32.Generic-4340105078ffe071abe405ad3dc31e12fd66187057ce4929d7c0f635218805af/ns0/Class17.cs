using System.ComponentModel;
using System.ServiceProcess;
using System.Text;

namespace ns0;

internal sealed class Class17 : ServiceBase
{
	internal IContainer icontainer_0;

	public Class17()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	public static string smethod_0(string string_0)
	{
		byte[] array = Class31.smethod_0(string_0);
		for (int i = 0; i <= array.Length - 1; i++)
		{
			array[i] = Class52.smethod_0(string_0, i);
		}
		return Encoding.UTF8.GetString(array, 1, array.Length - (int)array[0] % 5 - 1);
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
		((ServiceBase)this).set_ServiceName("Service24");
	}
}
