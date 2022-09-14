using System;
using System.Net;
using System.Net.Sockets;
using ns1;
using ns4;
using ns5;

namespace ns14;

internal sealed class Class53 : Socket
{
	internal object object_0;

	internal IPEndPoint ipendPoint_0 = null;

	internal Enum25 enum25_0 = Enum25.const_0;

	internal string string_0 = null;

	internal string string_1 = null;

	internal AsyncCallback asyncCallback_0 = null;

	internal Class52 class52_0;

	internal Exception exception_0 = null;

	internal int int_0;

	public Class53(AddressFamily addressFamily_0, SocketType socketType_0, ProtocolType protocolType_0)
		: this(addressFamily_0, socketType_0, protocolType_0, "")
	{
	}

	public Class53(AddressFamily addressFamily_0, SocketType socketType_0, ProtocolType protocolType_0, string string_2)
		: this(addressFamily_0, socketType_0, protocolType_0, string_2, "")
	{
	}

	public Class53(AddressFamily addressFamily_0, SocketType socketType_0, ProtocolType protocolType_0, string string_2, string string_3)
		: base(addressFamily_0, socketType_0, protocolType_0)
	{
		Class6.smethod_360(this, string_2);
		Class6.smethod_501(string_3, this);
		exception_0 = new InvalidOperationException();
	}

	internal void method_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			IPHostEntry iPHostEntry = Dns.EndResolve(iasyncResult_0);
			BeginConnect(new IPEndPoint(iPHostEntry.AddressList[0], Class6.smethod_468(this)), method_1, Class6.smethod_631(this));
		}
		catch (Exception exception_)
		{
			method_2(exception_);
		}
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			EndConnect(iasyncResult_0);
			method_2(null);
		}
		catch (Exception exception_)
		{
			method_2(exception_);
		}
	}

	internal void method_2(Exception exception_1)
	{
		if (exception_1 != null)
		{
			Close();
		}
		exception_0 = exception_1;
		Class6.smethod_254(Class6.smethod_515(this));
		if (asyncCallback_0 != null)
		{
			asyncCallback_0(Class6.smethod_515(this));
		}
	}
}
