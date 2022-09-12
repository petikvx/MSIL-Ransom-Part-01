using System.Collections.Generic;
using Ubiety.Dns.Core.Records;

namespace MySql.Data.Common;

internal class DnsSrvRecord : IComparer<DnsSrvRecord>
{
	internal int Port { get; }

	internal int Priority { get; }

	internal string Target { get; }

	internal int Weight { get; }

	internal DnsSrvRecord(int port, int priority, string target, int weight)
	{
		Port = port;
		Priority = priority;
		Target = target;
		Weight = weight;
	}

	internal DnsSrvRecord()
	{
	}

	internal DnsSrvRecord(RecordSrv recordSRV)
		: this(recordSRV.Port, recordSRV.Priority, recordSRV.Target, recordSRV.Weight)
	{
	}

	public int Compare(DnsSrvRecord x, DnsSrvRecord y)
	{
		int num = x.Priority.CompareTo(y.Priority);
		if (num != 0)
		{
			return num;
		}
		return y.Weight.CompareTo(x.Weight);
	}

	public static implicit operator DnsSrvRecord(RecordSrv recordSRV)
	{
		if (recordSRV == null)
		{
			return null;
		}
		recordSRV.Target = recordSRV.Target.TrimEnd(new char[1] { '.' });
		return new DnsSrvRecord(recordSRV);
	}
}
