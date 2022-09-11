using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using ns2;

namespace Mysqlx.Crud;

internal sealed class Limit : IMessage, IMessage<Limit>, IEquatable<Limit>, IDeepCloneable<Limit>
{
	private static readonly MessageParser<Limit> messageParser_0 = new MessageParser<Limit>(() => new Limit());

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private ulong ulong_0;

	public const int int_1 = 2;

	private ulong ulong_1;

	[DebuggerNonUserCode]
	public static MessageParser<Limit> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class32.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ulong RowCount
	{
		get
		{
			return ulong_0;
		}
		set
		{
			ulong_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public ulong Offset
	{
		get
		{
			return ulong_1;
		}
		set
		{
			ulong_1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Limit()
	{
	}

	[DebuggerNonUserCode]
	public Limit(Limit other)
		: this()
	{
		ulong_0 = other.ulong_0;
		ulong_1 = other.ulong_1;
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public Limit Clone()
	{
		return new Limit(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Limit>)this).Equals(obj as Limit);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Limit>.Equals(Limit other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RowCount != other.RowCount)
		{
			return false;
		}
		if (Offset != other.Offset)
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (RowCount != 0L)
		{
			num ^= RowCount.GetHashCode();
		}
		if (Offset != 0L)
		{
			num ^= Offset.GetHashCode();
		}
		if (unknownFieldSet_0 != null)
		{
			num ^= unknownFieldSet_0.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (RowCount != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RowCount);
		}
		if (Offset != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Offset);
		}
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (RowCount != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RowCount);
		}
		if (Offset != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Offset);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Limit other)
	{
		if (other != null)
		{
			if (other.RowCount != 0L)
			{
				RowCount = other.RowCount;
			}
			if (other.Offset != 0L)
			{
				Offset = other.Offset;
			}
			unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 16u:
				Offset = input.ReadUInt64();
				break;
			case 8u:
				RowCount = input.ReadUInt64();
				break;
			}
		}
	}
}
