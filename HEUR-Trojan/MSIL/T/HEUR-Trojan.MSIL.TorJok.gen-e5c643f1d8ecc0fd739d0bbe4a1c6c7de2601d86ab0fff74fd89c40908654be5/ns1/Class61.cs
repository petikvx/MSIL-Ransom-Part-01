using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ns14;
using ns4;
using ns5;

namespace ns1;

internal class Class61 : Class60
{
	protected internal string string_0 = "";

	protected internal string string_1 = null;

	protected internal StringDictionary stringDictionary_0 = null;

	protected internal string string_2 = "";

	protected internal string string_3 = "";

	protected internal string string_4 = null;

	public Class61(Socket socket_2, Delegate7 delegate7_1)
		: base(socket_2, delegate7_1)
	{
	}

	public override void vmethod_0()
	{
		try
		{
			Class6.smethod_230((Class60)this).BeginReceive(Class6.smethod_547((Class60)this), 0, Class6.smethod_547((Class60)this).Length, SocketFlags.None, method_7, Class6.smethod_230((Class60)this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected virtual void vmethod_1(string string_5)
	{
		stringDictionary_0 = Class6.smethod_91(string_5, this);
		if (Class6.smethod_517(this) == null || !Class6.smethod_517(this).ContainsKey("Host"))
		{
			method_5();
			return;
		}
		string hostName;
		int port;
		if (Class6.smethod_42(this).ToUpper().Equals("CONNECT"))
		{
			int num = Class6.smethod_106(this).IndexOf(":");
			if (num >= 0)
			{
				hostName = Class6.smethod_106(this).Substring(0, num);
				port = ((Class6.smethod_106(this).Length <= num + 1) ? 443 : int.Parse(Class6.smethod_106(this).Substring(num + 1)));
			}
			else
			{
				hostName = Class6.smethod_106(this);
				port = 443;
			}
		}
		else
		{
			int num = Class6.smethod_517(this)["Host"]!.IndexOf(":");
			if (num > 0)
			{
				hostName = Class6.smethod_517(this)["Host"]!.Substring(0, num);
				port = int.Parse(Class6.smethod_517(this)["Host"]!.Substring(num + 1));
			}
			else
			{
				hostName = Class6.smethod_517(this)["Host"];
				port = 80;
			}
			if (Class6.smethod_42(this).ToUpper().Equals("POST"))
			{
				int num2 = string_5.IndexOf("\r\n\r\n");
				string_4 = string_5.Substring(num2 + 4);
			}
		}
		try
		{
			IPEndPoint iPEndPoint = new IPEndPoint(Dns.Resolve(hostName).AddressList[0], port);
			Class6.smethod_603((Class60)this, new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp));
			if (Class6.smethod_517(this).ContainsKey("Proxy-Connection") && Class6.smethod_517(this)["Proxy-Connection"]!.ToLower().Equals("keep-alive"))
			{
				Class6.smethod_357((Class60)this).SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);
			}
			Class6.smethod_357((Class60)this).BeginConnect(iPEndPoint, method_9, Class6.smethod_357((Class60)this));
		}
		catch
		{
			method_5();
		}
	}

	protected internal void method_5()
	{
		string text = "HTTP/1.1 400 Bad Request\r\nConnection: close\r\nContent-Type: text/html\r\n\r\n<html><head><title>400 Bad Request</title></head><body><div align=\"center\"><table border=\"0\" cellspacing=\"3\" cellpadding=\"3\" bgcolor=\"#C0C0C0\"><tr><td><table border=\"0\" width=\"500\" cellspacing=\"3\" cellpadding=\"3\"><tr><td bgcolor=\"#B2B2B2\"><p align=\"center\"><strong><font size=\"2\" face=\"Verdana\">400 Bad Request</font></strong></p></td></tr><tr><td bgcolor=\"#D1D1D1\"><font size=\"2\" face=\"Verdana\"> The proxy server could not understand the HTTP request!<br><br> Please contact your network administrator about this problem.</font></td></tr></table></center></td></tr></table></div></body></html>";
		try
		{
			Class6.smethod_230((Class60)this).BeginSend(Encoding.ASCII.GetBytes(text), 0, text.Length, SocketFlags.None, method_8, Class6.smethod_230((Class60)this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	public override string ToString()
	{
		return method_6(bool_0: false);
	}

	public string method_6(bool bool_0)
	{
		string text;
		try
		{
			text = ((Class6.smethod_357((Class60)this) != null && Class6.smethod_357((Class60)this).RemoteEndPoint != null) ? ("HTTP connection from " + ((IPEndPoint)Class6.smethod_230((Class60)this).RemoteEndPoint).Address.ToString() + " to " + ((IPEndPoint)Class6.smethod_357((Class60)this).RemoteEndPoint).Address.ToString() + " on port " + ((IPEndPoint)Class6.smethod_357((Class60)this).RemoteEndPoint).Port) : ("Incoming HTTP connection from " + ((IPEndPoint)Class6.smethod_230((Class60)this).RemoteEndPoint).Address.ToString()));
			if (Class6.smethod_517(this) != null && Class6.smethod_517(this).ContainsKey("Host") && Class6.smethod_106(this) != null)
			{
				text = text + "\r\n requested URL: http://" + Class6.smethod_517(this)["Host"] + Class6.smethod_106(this);
			}
		}
		catch
		{
			text = "HTTP Connection";
		}
		return text;
	}

	protected void method_7(IAsyncResult iasyncResult_0)
	{
		int num;
		try
		{
			num = Class6.smethod_230((Class60)this).EndReceive(iasyncResult_0);
		}
		catch
		{
			num = -1;
		}
		if (num <= 0)
		{
			System_002EIDisposable_002EDispose();
			return;
		}
		Class6.smethod_194(this, Class6.smethod_219(this) + Encoding.ASCII.GetString(Class6.smethod_547((Class60)this), 0, num));
		if (Class6.smethod_277(this, Class6.smethod_219(this)))
		{
			vmethod_1(Class6.smethod_219(this));
			return;
		}
		try
		{
			Class6.smethod_230((Class60)this).BeginReceive(Class6.smethod_547((Class60)this), 0, Class6.smethod_547((Class60)this).Length, SocketFlags.None, method_7, Class6.smethod_230((Class60)this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_8(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_230((Class60)this).EndSend(iasyncResult_0);
		}
		catch
		{
		}
		System_002EIDisposable_002EDispose();
	}

	protected void method_9(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_357((Class60)this).EndConnect(iasyncResult_0);
			if (Class6.smethod_42(this).ToUpper().Equals("CONNECT"))
			{
				string text = Class6.smethod_477(this) + " 200 Connection established\r\nProxy-Agent: Mentalis Proxy Server\r\n\r\n";
				Class6.smethod_230((Class60)this).BeginSend(Encoding.ASCII.GetBytes(text), 0, text.Length, SocketFlags.None, method_11, Class6.smethod_230((Class60)this));
			}
			else
			{
				string text = Class6.smethod_349(this);
				Class6.smethod_357((Class60)this).BeginSend(Encoding.ASCII.GetBytes(text), 0, text.Length, SocketFlags.None, method_10, Class6.smethod_357((Class60)this));
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_10(IAsyncResult iasyncResult_0)
	{
		try
		{
			if (Class6.smethod_357((Class60)this).EndSend(iasyncResult_0) == -1)
			{
				System_002EIDisposable_002EDispose();
			}
			else
			{
				method_0();
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_11(IAsyncResult iasyncResult_0)
	{
		try
		{
			if (Class6.smethod_230((Class60)this).EndSend(iasyncResult_0) == -1)
			{
				System_002EIDisposable_002EDispose();
			}
			else
			{
				method_0();
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}
}
