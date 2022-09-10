using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace WY9_Tray.Tiny.UDP;

public class TinyServer : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private ProtocolType _Protocol;

	private IPAddress _ClientAddress;

	private int _ClientPort;

	private byte[] _data;

	private EncodingType _Encode;

	[Browsable(true)]
	[Description("The server protocol to use. Currently only UDP is supported.")]
	[Category("TinyServer")]
	public ProtocolType Protocol
	{
		get
		{
			return _Protocol;
		}
		set
		{
			if (value != ProtocolType.Udp)
			{
				throw new ProtocolNotSupportedException();
			}
			_Protocol = value;
		}
	}

	[Category("TinyServer")]
	[Browsable(true)]
	[Description("The client IPEndPoint.")]
	public IPEndPoint Client
	{
		get
		{
			return new IPEndPoint(_ClientAddress, _ClientPort);
		}
		set
		{
			_ClientAddress = value.Address;
			_ClientPort = value.Port;
		}
	}

	[Category("TinyServer")]
	[Description("The client IP Address.")]
	[Browsable(true)]
	public IPAddress ClientAddress
	{
		get
		{
			return _ClientAddress;
		}
		set
		{
			_ClientAddress = value;
		}
	}

	[Category("TinyServer")]
	[Description("The client port number.")]
	[Browsable(true)]
	public int ClientPort
	{
		get
		{
			return _ClientPort;
		}
		set
		{
			_ClientPort = value;
		}
	}

	[Browsable(true)]
	[Category("TinyServer")]
	[Description("Text encoding to use for sent messages.")]
	public EncodingType Encode
	{
		get
		{
			return _Encode;
		}
		set
		{
			_Encode = value;
		}
	}

	public TinyServer(IContainer Container)
		: this()
	{
		Container.Add(this);
	}

	public TinyServer()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		_Protocol = ProtocolType.Udp;
		_ClientAddress = IPAddress.Any;
		_ClientPort = 0;
		_data = new byte[0];
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
	}

	public void SendMessage(string message)
	{
		switch (Encode)
		{
		default:
			throw new BadEncodingException();
		case EncodingType.Default:
			_data = Encoding.Default.GetBytes(message);
			break;
		case EncodingType.ASCII:
			_data = Encoding.ASCII.GetBytes(message);
			break;
		case EncodingType.Unicode:
			_data = Encoding.Unicode.GetBytes(message);
			break;
		case EncodingType.UTF7:
			_data = Encoding.UTF7.GetBytes(message);
			break;
		case EncodingType.UTF8:
			_data = Encoding.UTF8.GetBytes(message);
			break;
		}
		try
		{
			ProtocolType protocol = Protocol;
			if (protocol == ProtocolType.Udp)
			{
				SendUDPMessage(_data);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
	}

	private object SendUDPMessage(byte[] _data)
	{
		UdpClient udpClient = default(UdpClient);
		int num;
		try
		{
			udpClient = new UdpClient();
			num = 0;
			udpClient.Connect(Client);
			num = udpClient.Send(_data, _data.Length);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
		finally
		{
			udpClient?.Close();
		}
		return num;
	}
}
