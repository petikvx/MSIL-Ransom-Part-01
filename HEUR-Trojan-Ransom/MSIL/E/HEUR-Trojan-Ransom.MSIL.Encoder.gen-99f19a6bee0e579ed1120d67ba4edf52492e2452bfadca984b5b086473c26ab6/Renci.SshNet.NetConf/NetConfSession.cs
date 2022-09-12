using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using Renci.SshNet.Common;

namespace Renci.SshNet.NetConf;

internal class NetConfSession : SubsystemSession, IDisposable, ISubsystemSession, INetConfSession
{
	private const string Prompt = "]]>]]>";

	private readonly StringBuilder _data = new StringBuilder();

	private bool _usingFramingProtocol;

	private EventWaitHandle _serverCapabilitiesConfirmed = new AutoResetEvent(initialState: false);

	private EventWaitHandle _rpcReplyReceived = new AutoResetEvent(initialState: false);

	private StringBuilder _rpcReply = new StringBuilder();

	private int _messageId;

	public XmlDocument ServerCapabilities { get; private set; }

	public XmlDocument ClientCapabilities { get; private set; }

	public NetConfSession(ISession session, int operationTimeout)
		: base(session, "netconf", operationTimeout)
	{
		ClientCapabilities = new XmlDocument();
		ClientCapabilities.LoadXml("<?xml version=\"1.0\" encoding=\"UTF-8\"?><hello xmlns=\"urn:ietf:params:xml:ns:netconf:base:1.0\"><capabilities><capability>urn:ietf:params:netconf:base:1.0</capability></capabilities></hello>");
	}

	public XmlDocument SendReceiveRpc(XmlDocument rpc, bool automaticMessageIdHandling)
	{
		_data.Clear();
		XmlNamespaceManager xmlNamespaceManager = null;
		if (automaticMessageIdHandling)
		{
			_messageId++;
			xmlNamespaceManager = new XmlNamespaceManager(rpc.NameTable);
			xmlNamespaceManager.AddNamespace("nc", "urn:ietf:params:xml:ns:netconf:base:1.0");
			rpc.SelectSingleNode("/nc:rpc/@message-id", xmlNamespaceManager)!.Value = _messageId.ToString(CultureInfo.InvariantCulture);
		}
		_rpcReply = new StringBuilder();
		_rpcReplyReceived.Reset();
		XmlDocument xmlDocument = new XmlDocument();
		if (_usingFramingProtocol)
		{
			StringBuilder stringBuilder = new StringBuilder(rpc.InnerXml.Length + 10);
			stringBuilder.AppendFormat("\n#{0}\n", rpc.InnerXml.Length);
			stringBuilder.Append(rpc.InnerXml);
			stringBuilder.Append("\n##\n");
			SendData(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
			WaitOnHandle(_rpcReplyReceived, base.OperationTimeout);
			xmlDocument.LoadXml(_rpcReply.ToString());
		}
		else
		{
			SendData(Encoding.UTF8.GetBytes(rpc.InnerXml + "]]>]]>"));
			WaitOnHandle(_rpcReplyReceived, base.OperationTimeout);
			xmlDocument.LoadXml(_rpcReply.ToString());
		}
		if (automaticMessageIdHandling && rpc.SelectSingleNode("/nc:rpc/@message-id", xmlNamespaceManager)!.Value != _messageId.ToString(CultureInfo.InvariantCulture))
		{
			throw new NetConfServerException("The rpc message id does not match the rpc-reply message id.");
		}
		return xmlDocument;
	}

	protected override void OnChannelOpen()
	{
		_data.Clear();
		string s = string.Format("{0}{1}", ClientCapabilities.InnerXml, "]]>]]>");
		SendData(Encoding.UTF8.GetBytes(s));
		WaitOnHandle(_serverCapabilitiesConfirmed, base.OperationTimeout);
	}

	protected override void OnDataReceived(byte[] data)
	{
		string @string = Encoding.UTF8.GetString(data);
		if (ServerCapabilities == null)
		{
			_data.Append(@string);
			if (@string.Contains("]]>]]>"))
			{
				try
				{
					@string = _data.ToString();
					_data.Clear();
					ServerCapabilities = new XmlDocument();
					ServerCapabilities.LoadXml(@string.Replace("]]>]]>", ""));
				}
				catch (XmlException innerException)
				{
					throw new NetConfServerException("Server capabilities received are not well formed XML", innerException);
				}
				XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(ServerCapabilities.NameTable);
				xmlNamespaceManager.AddNamespace("nc", "urn:ietf:params:xml:ns:netconf:base:1.0");
				_usingFramingProtocol = ServerCapabilities.SelectSingleNode("/nc:hello/nc:capabilities/nc:capability[text()='urn:ietf:params:netconf:base:1.1']", xmlNamespaceManager) != null;
				_serverCapabilitiesConfirmed.Set();
			}
		}
		else if (_usingFramingProtocol)
		{
			int num = 0;
			while (true)
			{
				Match match = Regex.Match(@string.Substring(num), "\\n#(?<length>\\d+)\\n");
				if (!match.Success)
				{
					break;
				}
				int num2 = Convert.ToInt32(match.Groups["length"].Value);
				_rpcReply.Append(@string, num + match.Index + match.Length, num2);
				num += match.Index + match.Length + num2;
			}
			if (Regex.IsMatch(@string.Substring(num), "\\n##\\n"))
			{
				_rpcReplyReceived.Set();
			}
		}
		else
		{
			_data.Append(@string);
			if (@string.Contains("]]>]]>"))
			{
				@string = _data.ToString();
				_data.Clear();
				_rpcReply.Append(@string.Replace("]]>]]>", ""));
				_rpcReplyReceived.Set();
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			if (_serverCapabilitiesConfirmed != null)
			{
				_serverCapabilitiesConfirmed.Dispose();
				_serverCapabilitiesConfirmed = null;
			}
			if (_rpcReplyReceived != null)
			{
				_rpcReplyReceived.Dispose();
				_rpcReplyReceived = null;
			}
		}
	}
}
