using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class14 : ServiceBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 25129)]
	private struct Struct2
	{
	}

	private IContainer icontainer_0;

	internal static byte byte_0/* Not supported: data(00) */;

	public Class14()
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
		return Class7.int_0 % Class15.smethod_0().Length;
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
		((ServiceBase)this).set_ServiceName("Service21");
	}
}
