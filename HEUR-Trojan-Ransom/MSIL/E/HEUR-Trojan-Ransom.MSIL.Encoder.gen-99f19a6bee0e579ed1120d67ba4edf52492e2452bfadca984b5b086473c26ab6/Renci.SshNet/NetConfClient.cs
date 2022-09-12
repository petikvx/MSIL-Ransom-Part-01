using System;
using System.Xml;
using Renci.SshNet.NetConf;

namespace Renci.SshNet;

public class NetConfClient : BaseClient
{
	private int _operationTimeout;

	private INetConfSession _netConfSession;

	public TimeSpan OperationTimeout
	{
		get
		{
			return TimeSpan.FromMilliseconds(_operationTimeout);
		}
		set
		{
			double totalMilliseconds = value.TotalMilliseconds;
			if (totalMilliseconds < -1.0 || totalMilliseconds > 2147483647.0)
			{
				throw new ArgumentOutOfRangeException("timeout", "The timeout must represent a value between -1 and Int32.MaxValue, inclusive.");
			}
			_operationTimeout = (int)totalMilliseconds;
		}
	}

	public XmlDocument ServerCapabilities => _netConfSession.ServerCapabilities;

	public XmlDocument ClientCapabilities => _netConfSession.ClientCapabilities;

	public bool AutomaticMessageIdHandling { get; set; }

	public NetConfClient(ConnectionInfo connectionInfo)
		: this(connectionInfo, ownsConnectionInfo: false)
	{
	}

	public NetConfClient(string host, int port, string username, string password)
		: this(new PasswordConnectionInfo(host, port, username, password), ownsConnectionInfo: true)
	{
	}

	public NetConfClient(string host, string username, string password)
		: this(host, ConnectionInfo.DefaultPort, username, password)
	{
	}

	public NetConfClient(string host, int port, string username, params PrivateKeyFile[] keyFiles)
		: this(new PrivateKeyConnectionInfo(host, port, username, keyFiles), ownsConnectionInfo: true)
	{
	}

	public NetConfClient(string host, string username, params PrivateKeyFile[] keyFiles)
		: this(host, ConnectionInfo.DefaultPort, username, keyFiles)
	{
	}

	private NetConfClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo)
		: this(connectionInfo, ownsConnectionInfo, new ServiceFactory())
	{
	}

	internal NetConfClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo, IServiceFactory serviceFactory)
		: base(connectionInfo, ownsConnectionInfo, serviceFactory)
	{
		_operationTimeout = Renci.SshNet.Session.Infinite;
		AutomaticMessageIdHandling = true;
	}

	public XmlDocument SendReceiveRpc(XmlDocument rpc)
	{
		return _netConfSession.SendReceiveRpc(rpc, AutomaticMessageIdHandling);
	}

	public XmlDocument SendReceiveRpc(string xml)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		return SendReceiveRpc(xmlDocument);
	}

	public XmlDocument SendCloseRpc()
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml("<?xml version=\"1.0\" encoding=\"UTF-8\"?><rpc message-id=\"6666\" xmlns=\"urn:ietf:params:xml:ns:netconf:base:1.0\"><close-session/></rpc>");
		return _netConfSession.SendReceiveRpc(xmlDocument, AutomaticMessageIdHandling);
	}

	protected override void OnConnected()
	{
		base.OnConnected();
		_netConfSession = base.ServiceFactory.CreateNetConfSession(base.Session, _operationTimeout);
		_netConfSession.Connect();
	}

	protected override void OnDisconnecting()
	{
		base.OnDisconnecting();
		_netConfSession.Disconnect();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && _netConfSession != null)
		{
			_netConfSession.Dispose();
			_netConfSession = null;
		}
	}
}
