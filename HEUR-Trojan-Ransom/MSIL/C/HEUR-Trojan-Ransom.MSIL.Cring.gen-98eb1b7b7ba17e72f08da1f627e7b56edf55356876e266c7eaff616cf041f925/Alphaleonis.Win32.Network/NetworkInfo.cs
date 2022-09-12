using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Alphaleonis.Win32.Network;

public class NetworkInfo
{
	private readonly INetwork _network;

	public NetworkCategory Category => _network.GetCategory();

	public IEnumerable<NetworkConnectionInfo> Connections
	{
		get
		{
			foreach (object networkConnection in _network.GetNetworkConnections())
			{
				yield return new NetworkConnectionInfo((INetworkConnection)networkConnection);
			}
		}
	}

	public DateTime ConnectionTime => ConnectionTimeUtc.ToLocalTime();

	public DateTime ConnectionTimeUtc
	{
		get
		{
			_network.GetTimeCreatedAndConnected(out var _, out var _, out var pdwLowDateTimeConnected, out var pdwHighDateTimeConnected);
			return DateTime.FromFileTimeUtc((long)(((ulong)pdwHighDateTimeConnected << 32) | pdwLowDateTimeConnected));
		}
	}

	public ConnectivityStates Connectivity => _network.GetConnectivity();

	public DateTime CreationTime => CreationTimeUtc.ToLocalTime();

	public DateTime CreationTimeUtc
	{
		get
		{
			_network.GetTimeCreatedAndConnected(out var pdwLowDateTimeCreated, out var pdwHighDateTimeCreated, out var _, out var _);
			return DateTime.FromFileTimeUtc((long)(((ulong)pdwHighDateTimeCreated << 32) | pdwLowDateTimeCreated));
		}
	}

	public string Description => _network.GetDescription();

	public DomainType DomainType => _network.GetDomainType();

	public bool IsConnected => _network.IsConnected;

	public bool IsConnectedToInternet => _network.IsConnectedToInternet;

	public string Name => _network.GetName();

	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID")]
	public Guid NetworkId => _network.GetNetworkId();

	internal NetworkInfo(INetwork network)
	{
		_network = network;
	}

	public override string ToString()
	{
		string text = ((Utils.IsNullOrWhiteSpace(Description) || object.Equals(Name, Description)) ? string.Empty : (" (" + Description + ")"));
		if (Name == null)
		{
			return GetType().Name;
		}
		return string.Format(CultureInfo.CurrentCulture, "{0}{1}, {2}", new object[3] { Name, text, Category });
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			NetworkInfo networkInfo = obj as NetworkInfo;
			if (null != networkInfo && object.Equals(NetworkId, networkInfo.NetworkId))
			{
				return object.Equals(Category, networkInfo.Category);
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return NetworkId.GetHashCode() + Category.GetHashCode();
	}

	public static bool operator ==(NetworkInfo left, NetworkInfo right)
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

	public static bool operator !=(NetworkInfo left, NetworkInfo right)
	{
		return !(left == right);
	}
}
