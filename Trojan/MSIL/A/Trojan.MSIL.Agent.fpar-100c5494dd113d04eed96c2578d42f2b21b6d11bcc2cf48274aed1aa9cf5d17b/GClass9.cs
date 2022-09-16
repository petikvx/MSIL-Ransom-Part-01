using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NanoCore;
using NanoCore.ClientPluginHost;

public sealed class GClass9 : IClientUIHost
{
	public GClass3 gclass3_0;

	public GClass9(GClass3 gclass3_1)
	{
		gclass3_0 = gclass3_1;
	}

	public void Invoke(ClientInvokeDelegate clientInvokeDelegate_0, object object_0)
	{
		if (clientInvokeDelegate_0 == null)
		{
			Class8.smethod_85(gclass3_0, new Exception("One or more parameters are null."), "Invoke");
		}
		else if (((Control)Class8.clientLoaderForm_0).get_InvokeRequired())
		{
			((Control)Class8.clientLoaderForm_0).Invoke((Delegate)(object)clientInvokeDelegate_0, new object[1] { RuntimeHelpers.GetObjectValue(object_0) });
		}
		else
		{
			clientInvokeDelegate_0.Invoke(RuntimeHelpers.GetObjectValue(object_0));
		}
	}
}
