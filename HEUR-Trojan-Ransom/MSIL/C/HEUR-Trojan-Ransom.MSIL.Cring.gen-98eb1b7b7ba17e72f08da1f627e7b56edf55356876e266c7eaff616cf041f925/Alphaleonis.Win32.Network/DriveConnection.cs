using System;
using System.Net;

namespace Alphaleonis.Win32.Network;

public sealed class DriveConnection : IDisposable
{
	public string LocalName { get; private set; }

	public string Share { get; private set; }

	public DriveConnection(string remoteName)
	{
		Share = remoteName;
		LocalName = Host.ConnectDisconnectCore(new Host.ConnectDisconnectArguments
		{
			RemoteName = Share,
			IsDeviceMap = true
		});
	}

	public DriveConnection(string remoteName, string userName, string password, bool prompt)
	{
		Share = remoteName;
		LocalName = Host.ConnectDisconnectCore(new Host.ConnectDisconnectArguments
		{
			RemoteName = Share,
			UserName = userName,
			Password = password,
			Prompt = prompt,
			IsDeviceMap = true
		});
	}

	public DriveConnection(string remoteName, NetworkCredential credentials, bool prompt)
	{
		Share = remoteName;
		LocalName = Host.ConnectDisconnectCore(new Host.ConnectDisconnectArguments
		{
			RemoteName = Share,
			Credential = credentials,
			Prompt = prompt,
			IsDeviceMap = true
		});
	}

	~DriveConnection()
	{
		Dispose(isDisposing: false);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(isDisposing: true);
	}

	private void Dispose(bool isDisposing)
	{
		if (isDisposing && !Utils.IsNullOrWhiteSpace(LocalName))
		{
			Host.ConnectDisconnectArguments arguments = default(Host.ConnectDisconnectArguments);
			arguments.LocalName = LocalName;
			arguments.Prompt = true;
			arguments.IsDeviceMap = true;
			arguments.IsDisconnect = true;
			Host.ConnectDisconnectCore(arguments);
			LocalName = null;
		}
	}

	public override string ToString()
	{
		return LocalName;
	}
}
