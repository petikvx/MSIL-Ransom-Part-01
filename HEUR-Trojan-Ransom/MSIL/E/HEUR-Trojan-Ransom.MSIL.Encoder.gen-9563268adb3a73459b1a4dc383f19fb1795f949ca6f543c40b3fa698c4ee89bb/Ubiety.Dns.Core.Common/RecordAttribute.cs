using System;

namespace Ubiety.Dns.Core.Common;

[AttributeUsage(AttributeTargets.Field)]
public class RecordAttribute : Attribute
{
	public Type RecordType { get; }

	public RecordAttribute(Type record)
	{
		RecordType = record;
	}
}
