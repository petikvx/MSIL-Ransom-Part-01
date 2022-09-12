using System;
using Alphaleonis.Win32.Filesystem;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class ServerStatisticsInfo
{
	[NonSerialized]
	private DateTime _dateTimeNowUtc;

	[NonSerialized]
	private NativeMethods.STAT_SERVER_0 _serverStat;

	public int AccessPermissionErrors => (int)_serverStat.sts0_permerrors;

	public TimeSpan AverageResponseTime => TimeSpan.FromMilliseconds(_serverStat.sts0_avresponse);

	public int BufferAllocationFailed => (int)_serverStat.sts0_bigbufneed;

	public int BufferRequestFailed => (int)_serverStat.sts0_reqbufneed;

	public long BytesReceived => Alphaleonis.Win32.Filesystem.NativeMethods.ToLong(_serverStat.sts0_bytesrcvd_high, _serverStat.sts0_bytesrcvd_low);

	public string BytesReceivedUnitSize => Utils.UnitSizeToText(BytesReceived);

	public long BytesSent => Alphaleonis.Win32.Filesystem.NativeMethods.ToLong(_serverStat.sts0_bytessent_high, _serverStat.sts0_bytessent_low);

	public string BytesSentUnitSize => Utils.UnitSizeToText(BytesSent);

	public int DevicesOpened => (int)_serverStat.sts0_devopens;

	public int FilesOpened => (int)_serverStat.sts0_fopens;

	public string HostName { get; private set; }

	public int JobsQueued => (int)_serverStat.sts0_jobsqueued;

	public int PasswordViolations => (int)_serverStat.sts0_pwerrors;

	public int SessionsFailed => (int)_serverStat.sts0_serrorout;

	public int SessionsStarted => (int)_serverStat.sts0_sopens;

	public int SessionsTimedOut => (int)_serverStat.sts0_stimedout;

	public DateTime StatisticsStartTime => StatisticsStartTimeUtc.ToLocalTime();

	public DateTime StatisticsStartTimeUtc => new DateTime((_dateTimeNowUtc - new DateTime(_serverStat.sts0_start, DateTimeKind.Utc)).Ticks, DateTimeKind.Utc);

	public int SystemErrors => (int)_serverStat.sts0_syserrors;

	public ServerStatisticsInfo()
		: this(Environment.MachineName, null)
	{
	}

	public ServerStatisticsInfo(string hostName)
		: this(hostName, null)
	{
	}

	internal ServerStatisticsInfo(string hostName, NativeMethods.STAT_SERVER_0? serverStat)
	{
		HostName = ((!Utils.IsNullOrWhiteSpace(hostName)) ? hostName : Environment.MachineName);
		if (serverStat.HasValue)
		{
			_dateTimeNowUtc = DateTime.UtcNow;
			_serverStat = serverStat.Value;
		}
		else
		{
			Refresh();
		}
	}

	public void Refresh()
	{
		_dateTimeNowUtc = DateTime.UtcNow;
		_serverStat = Host.GetNetStatisticsNative<NativeMethods.STAT_SERVER_0>(isServer: true, HostName);
	}

	public override string ToString()
	{
		return HostName;
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			ServerStatisticsInfo serverStatisticsInfo = obj as ServerStatisticsInfo;
			if (null != serverStatisticsInfo && serverStatisticsInfo.HostName != null && serverStatisticsInfo.HostName.Equals(HostName, StringComparison.OrdinalIgnoreCase))
			{
				return serverStatisticsInfo.StatisticsStartTimeUtc.Equals(StatisticsStartTimeUtc);
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (HostName == null)
		{
			return 0;
		}
		return HostName.GetHashCode();
	}

	public static bool operator ==(ServerStatisticsInfo left, ServerStatisticsInfo right)
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

	public static bool operator !=(ServerStatisticsInfo left, ServerStatisticsInfo right)
	{
		return !(left == right);
	}
}
