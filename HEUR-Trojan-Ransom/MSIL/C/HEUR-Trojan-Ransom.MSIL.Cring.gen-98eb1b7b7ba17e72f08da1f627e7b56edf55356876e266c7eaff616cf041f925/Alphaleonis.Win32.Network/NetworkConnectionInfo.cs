using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Alphaleonis.Win32.Network;

public class NetworkConnectionInfo
{
	private readonly INetworkConnection _networkConnection;

	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
	public Guid ConnectionId => _networkConnection.GetConnectionId();

	public ConnectivityStates Connectivity => _networkConnection.GetConnectivity();

	public DomainType DomainType => _networkConnection.GetDomainType();

	public bool IsConnected => _networkConnection.IsConnected;

	public bool IsConnectedToInternet => _networkConnection.IsConnectedToInternet;

	public NetworkInfo NetworkInfo => new NetworkInfo(_networkConnection.GetNetwork());

	public NetworkInterface NetworkInterface
	{
		get
		{
			Guid adapterId = _networkConnection.GetAdapterId();
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			int num = 0;
			NetworkInterface networkInterface;
			while (true)
			{
				if (num < allNetworkInterfaces.Length)
				{
					networkInterface = allNetworkInterfaces[num];
					if (object.Equals(objB: new Guid(networkInterface.Id), objA: adapterId))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return networkInterface;
		}
	}

	internal NetworkConnectionInfo(INetworkConnection networkConnection)
	{
		_networkConnection = networkConnection;
	}

	public override string ToString()
	{
		if (null != NetworkInfo && NetworkInterface != null)
		{
			return string.Format(CultureInfo.CurrentCulture, "{0} {1}", new object[2] { NetworkInfo.Name, NetworkInterface.Name });
		}
		return GetType().Name;
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			NetworkConnectionInfo networkConnectionInfo = obj as NetworkConnectionInfo;
			if (null != networkConnectionInfo && networkConnectionInfo.NetworkInfo == NetworkInfo && networkConnectionInfo.NetworkInterface == NetworkInterface && object.Equals(networkConnectionInfo.NetworkInfo.NetworkId, NetworkInfo.NetworkId))
			{
				return object.Equals(networkConnectionInfo.NetworkInterface.Id, NetworkInterface.Id);
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((null != NetworkInfo) ? NetworkInfo.GetHashCode() : 0) + ((NetworkInterface != null) ? NetworkInterface.GetHashCode() : 0);
	}

	public static bool operator ==(NetworkConnectionInfo left, NetworkConnectionInfo right)
	{
		if ((object)left == null && (object)right == null)
		{
			return true;
		}
		if ((object)left != null && (object)right != null)
		{
			return left.Equals(right);
		}
		return false;
	}

	public static bool operator !=(NetworkConnectionInfo left, NetworkConnectionInfo right)
	{
		return !(left == right);
	}
}
