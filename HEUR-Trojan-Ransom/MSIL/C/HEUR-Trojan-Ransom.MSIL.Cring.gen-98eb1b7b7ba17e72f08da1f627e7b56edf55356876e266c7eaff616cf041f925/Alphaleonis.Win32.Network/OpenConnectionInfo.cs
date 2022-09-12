using System;
using System.Globalization;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class OpenConnectionInfo
{
	private string _netName;

	[Obsolete("Use HostName")]
	public string Host { get; private set; }

	public string HostName { get; private set; }

	public long Id { get; private set; }

	public ShareType ShareType { get; private set; }

	public long TotalOpenFiles { get; private set; }

	public long TotalUsers { get; private set; }

	[Obsolete("Use ConnectedTime property.")]
	public long ConnectedSeconds { get; private set; }

	public TimeSpan ConnectedTime { get; private set; }

	public string UserName { get; private set; }

	public string NetName
	{
		get
		{
			return _netName;
		}
		set
		{
			_netName = value?.ReplaceIgnoreCase(Path.LongPathUncPrefix, string.Empty).Replace(Path.UncPrefix, string.Empty).Trim('[', ']');
		}
	}

	internal OpenConnectionInfo(string hostName, NativeMethods.CONNECTION_INFO_1 connectionInfo)
	{
		HostName = hostName;
		Id = connectionInfo.coni1_id;
		ShareType = connectionInfo.coni1_type;
		TotalOpenFiles = connectionInfo.coni1_num_opens;
		TotalUsers = connectionInfo.coni1_num_users;
		ConnectedTime = TimeSpan.FromSeconds(connectionInfo.coni1_time);
		UserName = connectionInfo.coni1_username;
		NetName = connectionInfo.oni1_netname;
	}

	public override string ToString()
	{
		return Id.ToString(CultureInfo.InvariantCulture);
	}
}
