using System;
using System.Xml;

namespace Renci.SshNet.NetConf;

internal interface INetConfSession : IDisposable, ISubsystemSession
{
	XmlDocument ServerCapabilities { get; }

	XmlDocument ClientCapabilities { get; }

	XmlDocument SendReceiveRpc(XmlDocument rpc, bool automaticMessageIdHandling);
}
