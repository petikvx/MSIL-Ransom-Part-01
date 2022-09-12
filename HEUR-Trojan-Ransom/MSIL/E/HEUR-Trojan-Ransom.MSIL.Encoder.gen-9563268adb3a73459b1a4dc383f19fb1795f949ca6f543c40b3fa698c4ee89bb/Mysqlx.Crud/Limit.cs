using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Crud;

internal sealed class Limit : IMessage<Limit>, IEquatable<Limit>, IDeepCloneable<Limit>, IMessage
{
	private static readonly MessageParser<Limit> _parser = new MessageParser<Limit>(() => new Limit());

	private UnknownFieldSet _unknownFields;

	public const int RowCountFieldNumber = 1;

	private ulong rowCount_;

	public const int OffsetFieldNumber = 2;

	private ulong offset_;

	[DebuggerNonUserCode]
	public static MessageParser<Limit> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ulong RowCount
	{
		get
		{
			return rowCount_;
		}
		set
		{
			rowCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ulong Offset
	{
		get
		{
			return offset_;
		}
		set
		{
			offset_ = value;
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
		rowCount_ = other.rowCount_;
		offset_ = other.offset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Limit Clone()
	{
		return new Limit(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Limit);
	}

	[DebuggerNonUserCode]
	public bool Equals(Limit other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
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
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
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
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
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
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
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
