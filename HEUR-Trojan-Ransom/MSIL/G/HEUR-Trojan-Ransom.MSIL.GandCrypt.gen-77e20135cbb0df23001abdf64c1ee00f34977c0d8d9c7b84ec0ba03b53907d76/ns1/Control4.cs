using System;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal sealed class Control4 : Control
{
	public static void smethod_0()
	{
		new AutoResetEvent(initialState: false).WaitOne(10000, exitContext: false);
		Control3.appDomain_0 = AppDomain.CurrentDomain;
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		byte[] byte_ = c.byte_0;
		Control0.smethod_0(byte_0, byte_);
		return byte_0;
	}
}
