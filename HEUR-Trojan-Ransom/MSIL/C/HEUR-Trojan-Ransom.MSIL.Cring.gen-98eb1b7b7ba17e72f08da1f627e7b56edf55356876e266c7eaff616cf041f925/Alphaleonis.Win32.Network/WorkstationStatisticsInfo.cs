using System;
using System.Diagnostics.CodeAnalysis;

namespace Alphaleonis.Win32.Network;

[Serializable]
public sealed class WorkstationStatisticsInfo
{
	[NonSerialized]
	private NativeMethods.STAT_WORKSTATION_0 _workstationStat;

	public long BytesReceived => _workstationStat.BytesReceived;

	public string BytesReceivedUnitSize => Utils.UnitSizeToText(BytesReceived);

	public long BytesTransmitted => _workstationStat.BytesTransmitted;

	public string BytesTransmittedUnitSize => Utils.UnitSizeToText(BytesTransmitted);

	public long CacheReadBytesRequested => _workstationStat.CacheReadBytesRequested;

	public string CacheReadBytesRequestedUnitSize => Utils.UnitSizeToText(CacheReadBytesRequested);

	public long CacheWriteBytesRequested => _workstationStat.CacheWriteBytesRequested;

	public string CacheWriteBytesRequestedUnitSize => Utils.UnitSizeToText(CacheWriteBytesRequested);

	public int CoreConnects => (int)_workstationStat.CoreConnects;

	public int CurrentCommands => (int)_workstationStat.CurrentCommands;

	public int FailedCompletionOperations => (int)_workstationStat.FailedCompletionOperations;

	public int FailedSessions => (int)_workstationStat.FailedSessions;

	public int FailedUseCount => (int)_workstationStat.FailedUseCount;

	public string HostName { get; private set; }

	public int InitiallyFailedOperations => (int)_workstationStat.InitiallyFailedOperations;

	public int HungSessions => (int)_workstationStat.HungSessions;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lanman")]
	public int Lanman20Connects => (int)_workstationStat.Lanman20Connects;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lanman")]
	public int Lanman21Connects => (int)_workstationStat.Lanman21Connects;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lanman")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Nt")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Nt")]
	public int LanmanNtConnects => (int)_workstationStat.LanmanNtConnects;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int LargeReadSmbs => (int)_workstationStat.LargeReadSmbs;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int LargeWriteSmbs => (int)_workstationStat.LargeWriteSmbs;

	public int NetworkErrors => (int)_workstationStat.NetworkErrors;

	public long NetworkReadBytesRequested => _workstationStat.NetworkReadBytesRequested;

	public string NetworkReadBytesRequestedUnitSize => Utils.UnitSizeToText(NetworkReadBytesRequested);

	public long NetworkWriteBytesRequested => _workstationStat.NetworkWriteBytesRequested;

	public string NetworkWriteBytesRequestedUnitSize => Utils.UnitSizeToText(NetworkWriteBytesRequested);

	public long NonPagingReadBytesRequested => _workstationStat.NonPagingReadBytesRequested;

	public string NonPagingReadBytesRequestedUnitSize => Utils.UnitSizeToText(NonPagingReadBytesRequested);

	public long NonPagingWriteBytesRequested => _workstationStat.NonPagingWriteBytesRequested;

	public string NonPagingWriteBytesRequestedUnitSize => Utils.UnitSizeToText(NonPagingWriteBytesRequested);

	public long PagingReadBytesRequested => _workstationStat.PagingReadBytesRequested;

	public string PagingReadBytesRequestedUnitSize => Utils.UnitSizeToText(PagingReadBytesRequested);

	public long PagingWriteBytesRequested => _workstationStat.PagingWriteBytesRequested;

	public string PagingWriteBytesRequestedUnitSize => Utils.UnitSizeToText(PagingWriteBytesRequested);

	public int RandomReadOperations => (int)_workstationStat.RandomReadOperations;

	public int RandomWriteOperations => (int)_workstationStat.RandomWriteOperations;

	public int RawReadsDenied => (int)_workstationStat.RawReadsDenied;

	public int RawWritesDenied => (int)_workstationStat.RawWritesDenied;

	public int ReadOperations => (int)_workstationStat.ReadOperations;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int ReadSmbs => (int)_workstationStat.ReadSmbs;

	public int Reconnects => (int)_workstationStat.Reconnects;

	public int ServerDisconnects => (int)_workstationStat.ServerDisconnects;

	public int Sessions => (int)_workstationStat.Sessions;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int SmallReadSmbs => (int)_workstationStat.SmallReadSmbs;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int SmallWriteSmbs => (int)_workstationStat.SmallWriteSmbs;

	public DateTime StatisticsStartTime => StatisticsStartTimeUtc.ToLocalTime();

	public DateTime StatisticsStartTimeUtc => DateTime.FromFileTimeUtc(_workstationStat.StatisticsStartTime);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public long SmbsReceived => _workstationStat.SmbsReceived;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public long SmbsTransmitted => _workstationStat.SmbsTransmitted;

	public int UseCount => (int)_workstationStat.UseCount;

	public int WriteOperations => (int)_workstationStat.WriteOperations;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Smbs")]
	public int WriteSmbs => (int)_workstationStat.WriteSmbs;

	public WorkstationStatisticsInfo()
		: this(Environment.MachineName, null)
	{
	}

	public WorkstationStatisticsInfo(string hostName)
		: this(hostName, null)
	{
	}

	internal WorkstationStatisticsInfo(string hostName, NativeMethods.STAT_WORKSTATION_0? workstationStat)
	{
		HostName = ((!Utils.IsNullOrWhiteSpace(hostName)) ? hostName : Environment.MachineName);
		if (workstationStat.HasValue)
		{
			_workstationStat = workstationStat.Value;
		}
		else
		{
			Refresh();
		}
	}

	public void Refresh()
	{
		_workstationStat = Host.GetNetStatisticsNative<NativeMethods.STAT_WORKSTATION_0>(isServer: false, HostName);
	}

	public override string ToString()
	{
		return HostName;
	}

	public override bool Equals(object obj)
	{
		if (obj != null && (object)GetType() == obj.GetType())
		{
			WorkstationStatisticsInfo workstationStatisticsInfo = obj as WorkstationStatisticsInfo;
			if (null != workstationStatisticsInfo && workstationStatisticsInfo.HostName != null && workstationStatisticsInfo.HostName.Equals(HostName, StringComparison.OrdinalIgnoreCase))
			{
				return workstationStatisticsInfo.StatisticsStartTimeUtc.Equals(StatisticsStartTimeUtc);
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

	public static bool operator ==(WorkstationStatisticsInfo left, WorkstationStatisticsInfo right)
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

	public static bool operator !=(WorkstationStatisticsInfo left, WorkstationStatisticsInfo right)
	{
		return !(left == right);
	}
}
