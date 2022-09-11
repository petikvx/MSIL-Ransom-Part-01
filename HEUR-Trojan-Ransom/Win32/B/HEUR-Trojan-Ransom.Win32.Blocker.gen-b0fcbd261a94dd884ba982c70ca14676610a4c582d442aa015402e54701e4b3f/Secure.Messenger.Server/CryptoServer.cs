using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Secure.Messenger.Shared;

namespace Secure.Messenger.Server;

public class CryptoServer
{
	private AutoResetEvent _serverStarted;

	public event EventHandler<EventArgs<string>> ReceivedData
	{
		[CompilerGenerated]
		add
		{
			EventHandler<EventArgs<string>> eventHandler = this.ReceivedData;
			EventHandler<EventArgs<string>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)CryptoServer.smethod_0((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.ReceivedData, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<EventArgs<string>> eventHandler = this.ReceivedData;
			EventHandler<EventArgs<string>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)CryptoServer.smethod_1((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.ReceivedData, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CryptoServer(AutoResetEvent serverStarted)
	{
		_serverStarted = serverStarted;
	}

	public void StartServer(IPAddress localIPAddress, int localPort)
	{
		TcpListener tcpListener = null;
		try
		{
			tcpListener = CryptoServer.smethod_2(localIPAddress, localPort);
			CryptoServer.smethod_3(tcpListener);
			CryptoServer.smethod_4((EventWaitHandle)_serverStarted);
		}
		catch (Exception exception_)
		{
			this.ReceivedData.SafeInvoke(this, new EventArgs<string>(CryptoServer.smethod_6("From Server : Network Error : ", CryptoServer.smethod_5(exception_))));
			return;
		}
		NetworkStream networkStream = null;
		while (!CryptoServer.smethod_10(tcpListener))
		{
			TcpClient tcpClient_ = CryptoServer.smethod_7(tcpListener);
			networkStream = CryptoServer.smethod_8(tcpClient_);
			MessageData messageData = CryptoHelper.ReceiveData(networkStream);
			if (messageData == null)
			{
				this.ReceivedData.SafeInvoke(this, new EventArgs<string>("From Server : Deserialisation Error"));
			}
			else if (CryptoServer.smethod_9(messageData.MessageBody, "Connection Message 123"))
			{
				this.ReceivedData.SafeInvoke(this, new EventArgs<string>(messageData.MessageBody));
			}
		}
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static TcpListener smethod_2(IPAddress ipaddress_0, int int_0)
	{
		return new TcpListener(ipaddress_0, int_0);
	}

	static void smethod_3(TcpListener tcpListener_0)
	{
		tcpListener_0.Start();
	}

	static bool smethod_4(EventWaitHandle eventWaitHandle_0)
	{
		return eventWaitHandle_0.Set();
	}

	static string smethod_5(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_6(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static TcpClient smethod_7(TcpListener tcpListener_0)
	{
		return tcpListener_0.AcceptTcpClient();
	}

	static NetworkStream smethod_8(TcpClient tcpClient_0)
	{
		return tcpClient_0.GetStream();
	}

	static bool smethod_9(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	static bool smethod_10(TcpListener tcpListener_0)
	{
		return tcpListener_0.Pending();
	}
}
