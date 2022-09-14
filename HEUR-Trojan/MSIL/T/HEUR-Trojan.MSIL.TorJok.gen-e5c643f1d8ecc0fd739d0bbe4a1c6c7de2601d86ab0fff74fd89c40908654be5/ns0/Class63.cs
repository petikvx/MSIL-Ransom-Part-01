using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using ns14;
using ns5;

namespace ns0;

internal abstract class Class63 : IDisposable
{
	internal int int_0;

	internal IPAddress ipaddress_0;

	internal Socket socket_0;

	internal ArrayList arrayList_0 = new ArrayList();

	internal bool bool_0 = false;

	public Class63(int int_1, IPAddress ipaddress_1)
	{
		Class6.smethod_284(this, int_1);
		Class6.smethod_269(ipaddress_1, this);
	}

	protected void method_0(Class60 class60_0)
	{
		Class6.smethod_256(this).Remove(class60_0);
	}

	void IDisposable.Dispose()
	{
		if (!Class6.smethod_225(this))
		{
			while (Class6.smethod_256(this).Count > 0)
			{
				((Class60)Class6.smethod_256(this)[0]).System_002EIDisposable_002EDispose();
			}
			try
			{
				Class6.smethod_161(this).Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
			if (Class6.smethod_161(this) != null)
			{
				Class6.smethod_161(this).Close();
			}
			bool_0 = true;
		}
	}

	~Class63()
	{
		System_002EIDisposable_002EDispose();
	}

	public abstract void vmethod_0(IAsyncResult iasyncResult_0);

	public abstract override string ToString();
}
