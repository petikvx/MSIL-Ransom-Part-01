using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using ns14;
using ns4;
using ns5;

namespace ns12;

internal sealed class Class62 : Class61
{
	[CompilerGenerated]
	private Class83 class83_0;

	[SpecialName]
	[CompilerGenerated]
	private Class83 method_12()
	{
		return class83_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_13(Class83 class83_1)
	{
		class83_0 = class83_1;
	}

	public Class62(Class83 class83_1, Socket socket_2, Delegate7 delegate7_1)
		: base(socket_2, delegate7_1)
	{
		method_13(class83_1);
	}

	protected override void vmethod_1(string string_5)
	{
		stringDictionary_0 = Class6.smethod_91(string_5, (Class61)this);
		if (Class6.smethod_517((Class61)this) == null || !Class6.smethod_517((Class61)this).ContainsKey("Host"))
		{
			method_5();
			return;
		}
		string text;
		int int_;
		if (Class6.smethod_42((Class61)this).ToUpper().Equals("CONNECT"))
		{
			int num = Class6.smethod_106((Class61)this).IndexOf(":");
			if (num >= 0)
			{
				text = Class6.smethod_106((Class61)this).Substring(0, num);
				int_ = ((Class6.smethod_106((Class61)this).Length <= num + 1) ? 443 : int.Parse(Class6.smethod_106((Class61)this).Substring(num + 1)));
			}
			else
			{
				text = Class6.smethod_106((Class61)this);
				int_ = 443;
			}
		}
		else
		{
			int num = Class6.smethod_517((Class61)this)["Host"]!.IndexOf(":");
			if (num > 0)
			{
				text = Class6.smethod_517((Class61)this)["Host"]!.Substring(0, num);
				int_ = int.Parse(Class6.smethod_517((Class61)this)["Host"]!.Substring(num + 1));
			}
			else
			{
				text = Class6.smethod_517((Class61)this)["Host"];
				int_ = 80;
			}
			if (Class6.smethod_42((Class61)this).ToUpper().Equals("POST"))
			{
				int num2 = string_5.IndexOf("\r\n\r\n");
				string_4 = string_5.Substring(num2 + 4);
			}
		}
		try
		{
			Class6.smethod_603((Class60)this, (Socket)new Class53(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp));
			((Class53)Class6.smethod_357((Class60)this)).ipendPoint_0 = new IPEndPoint(method_12().method_6(), method_12().method_4());
			Class6.smethod_360((Class53)Class6.smethod_357((Class60)this), "username");
			Class53 class53_ = (Class53)Class6.smethod_357((Class60)this);
			string text2 = "password";
			Class6.smethod_501(text2, class53_);
			((Class53)Class6.smethod_357((Class60)this)).enum25_0 = Class6.smethod_261(method_12());
			if (Class6.smethod_517((Class61)this).ContainsKey("Proxy-Connection") && Class6.smethod_517((Class61)this)["Proxy-Connection"]!.ToLower().Equals("keep-alive"))
			{
				((Class53)Class6.smethod_357((Class60)this)).SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);
			}
			Class6.smethod_619((Class53)Class6.smethod_357((Class60)this), text, int_, (AsyncCallback)method_14, (object)Class6.smethod_357((Class60)this));
		}
		catch
		{
			method_5();
		}
	}

	private void method_14(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_81((Class53)Class6.smethod_357((Class60)this), iasyncResult_0);
			if (Class6.smethod_42((Class61)this).ToUpper().Equals("CONNECT"))
			{
				string text = Class6.smethod_477((Class61)this) + " 200 Connection established\r\nProxy-Agent: SocksWebProxy\r\n\r\n";
				Class6.smethod_230((Class60)this).BeginSend(Encoding.ASCII.GetBytes(text), 0, text.Length, SocketFlags.None, base.method_11, Class6.smethod_230((Class60)this));
			}
			else
			{
				string text = Class6.smethod_349((Class61)this);
				Class6.smethod_357((Class60)this).BeginSend(Encoding.ASCII.GetBytes(text), 0, text.Length, SocketFlags.None, base.method_10, Class6.smethod_357((Class60)this));
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}
}
