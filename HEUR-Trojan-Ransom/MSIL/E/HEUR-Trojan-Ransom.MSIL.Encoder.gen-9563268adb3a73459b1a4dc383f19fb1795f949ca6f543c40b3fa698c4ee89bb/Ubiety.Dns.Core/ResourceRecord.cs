using System;
using Ubiety.Dns.Core.Common;
using Ubiety.Dns.Core.Records;

namespace Ubiety.Dns.Core;

public class ResourceRecord
{
	private uint _ttl;

	public string Name { get; }

	public RecordType Type { get; }

	public OperationClass Class { get; }

	public uint Ttl
	{
		get
		{
			return (uint)Math.Max(0L, _ttl - TimeLived);
		}
		private set
		{
			_ttl = value;
		}
	}

	public ushort RecordLength { get; }

	public Record Record { get; }

	public int TimeLived { get; set; }

	protected ResourceRecord(RecordReader rr)
	{
		TimeLived = 0;
		Name = rr.ReadDomainName();
		Type = (RecordType)rr.ReadUInt16();
		Class = (OperationClass)rr.ReadUInt16();
		Ttl = rr.ReadUInt32();
		RecordLength = rr.ReadUInt16();
		Record = rr.ReadRecord(Type);
		Record.ResourceRecord = this;
	}

	public override string ToString()
	{
		return string.Format("{0,-32} {1}\t{2}\t{3}\t{4}", Name, Ttl, Class, Type, Record);
	}
}
