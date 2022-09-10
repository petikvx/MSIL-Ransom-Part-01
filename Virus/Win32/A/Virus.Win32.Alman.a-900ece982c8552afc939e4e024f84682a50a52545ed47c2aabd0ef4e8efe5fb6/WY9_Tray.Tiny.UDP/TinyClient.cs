using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace WY9_Tray.Tiny.UDP;

public class TinyClient : Component
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private ProtocolType _Protocol;

	private Thread _ThreadReceive;

	private int _ClientPort;

	private string _Message;

	private byte[] _msgdata;

	private EncodingType _Encode;

	private UdpClient _UDPClient;

	private IPEndPoint _Server;

	private int _BytesReceived;

	private EventHandler BeforeReceiveEvent;

	private EventHandler AfterReceiveEvent;

	[Description("The encoding to use with received messages.")]
	[Category("TinyClient")]
	[Browsable(true)]
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

	[Category("TinyClient")]
	[Description("The number of bytes received by the client in the most recent message.")]
	[Browsable(true)]
	public int BytesReceived => _BytesReceived;

	[Browsable(true)]
	[Description("Read Only.  The message received by the client.")]
	[Category("TinyClient")]
	public string Message => _Message;

	[Browsable(true)]
	[Description("Read Only.  The message bytes() received by the client.")]
	[Category("TinyClient")]
	public byte[] Msgbytes => _msgdata;

	[Browsable(true)]
	[Category("TinyClient")]
	[Description("The server IPEndPoint.")]
	public IPEndPoint Server
	{
		get
		{
			return _Server;
		}
		set
		{
			_Server = value;
		}
	}

	[Description("The client port to check for inbound data.")]
	[Browsable(true)]
	[Category("TinyClient")]
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

	[Category("TinyClient")]
	[Description("The client protocol to use. Currently only UDP is supported.")]
	[Browsable(true)]
	public ProtocolType Protocol
	{
		get
		{
			return _Protocol;
		}
		set
		{
			_Protocol = value;
		}
	}

	[Category("TinyClient")]
	[Description("This event is fired right before an inbound message is received.")]
	[Browsable(true)]
	public event EventHandler BeforeReceive
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			BeforeReceiveEvent = (EventHandler)Delegate.Combine(BeforeReceiveEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			BeforeReceiveEvent = (EventHandler)Delegate.Remove(BeforeReceiveEvent, value);
		}
	}

	[Description("This event is fired immediatley after an inbound message is received.")]
	[Browsable(true)]
	[Category("TinyClient")]
	public event EventHandler AfterReceive
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			AfterReceiveEvent = (EventHandler)Delegate.Combine(AfterReceiveEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			AfterReceiveEvent = (EventHandler)Delegate.Remove(AfterReceiveEvent, value);
		}
	}

	public TinyClient(IContainer Container)
		: this()
	{
		Container.Add(this);
	}

	public TinyClient()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		_Protocol = ProtocolType.Udp;
		_ClientPort = 0;
		_Message = "";
		_Encode = EncodingType.Default;
		_Server = new IPEndPoint(IPAddress.Any, 0);
		_BytesReceived = 0;
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

	public void Receive()
	{
		_Message = "";
		BeforeReceiveEvent?.Invoke(this, new EventArgs());
		byte[] array;
		try
		{
			ProtocolType protocol = Protocol;
			if (protocol != ProtocolType.Udp)
			{
				throw new ProtocolNotSupportedException();
			}
			array = (_msgdata = _UDPClient.Receive(ref _Server));
			_BytesReceived = array.Length;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
		finally
		{
			if (_UDPClient != null)
			{
				InitializeThread();
			}
		}
		_Message = Encode switch
		{
			EncodingType.Default => Encoding.Default.GetString(array), 
			EncodingType.ASCII => Encoding.ASCII.GetString(array), 
			EncodingType.Unicode => Encoding.Unicode.GetString(array), 
			EncodingType.UTF7 => Encoding.UTF7.GetString(array), 
			EncodingType.UTF8 => Encoding.UTF8.GetString(array), 
			_ => throw new BadEncodingException(), 
		};
		if (_UDPClient != null)
		{
			AfterReceiveEvent?.Invoke(this, new EventArgs());
		}
	}

	private void InitializeClient()
	{
		ProtocolType protocol = Protocol;
		if (protocol == ProtocolType.Udp)
		{
			if (_UDPClient == null)
			{
				_UDPClient = new UdpClient(ClientPort);
			}
			return;
		}
		throw new ProtocolNotSupportedException();
	}

	private void InitializeThread()
	{
		try
		{
			_ThreadReceive = new Thread(Receive);
			_ThreadReceive.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
	}

	public void Start()
	{
		InitializeClient();
		InitializeThread();
	}

	public void Stop()
	{
		try
		{
			_ThreadReceive.Suspend();
			_ThreadReceive.Abort();
			if (_UDPClient != null)
			{
				_UDPClient.Close();
				_UDPClient = null;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw ex2;
		}
	}
}
