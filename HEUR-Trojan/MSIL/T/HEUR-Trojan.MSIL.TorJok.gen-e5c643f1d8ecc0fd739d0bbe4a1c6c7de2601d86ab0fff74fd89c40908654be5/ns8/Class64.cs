using System;
using System.Net;
using System.Net.Sockets;
using ns0;
using ns1;
using ns14;
using ns5;

namespace ns8;

internal class Class64 : Class63
{
	public Class64(IPAddress ipaddress_1, int int_1)
		: base(int_1, ipaddress_1)
	{
	}

	public override void vmethod_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			Socket socket = Class6.smethod_161((Class63)this).EndAccept(iasyncResult_0);
			if (socket != null)
			{
				Class61 @class = new Class61(socket, base.method_0);
				Class6.smethod_399((Class63)this, (Class60)@class);
				@class.vmethod_0();
			}
		}
		catch
		{
		}
		try
		{
			Class6.smethod_161((Class63)this).BeginAccept(vmethod_0, Class6.smethod_161((Class63)this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	public override string ToString()
	{
		return "HTTP service on " + Class6.smethod_244((Class63)this).ToString() + ":" + Class6.smethod_72((Class63)this);
	}
}
