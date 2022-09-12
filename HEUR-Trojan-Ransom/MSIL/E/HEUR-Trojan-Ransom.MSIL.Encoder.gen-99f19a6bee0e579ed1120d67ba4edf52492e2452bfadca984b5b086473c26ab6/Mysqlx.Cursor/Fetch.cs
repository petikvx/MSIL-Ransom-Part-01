using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Cursor;

internal sealed class Fetch : IMessage<Fetch>, IEquatable<Fetch>, IDeepCloneable<Fetch>, IMessage
{
	private static readonly MessageParser<Fetch> _parser = new MessageParser<Fetch>(() => new Fetch());

	private UnknownFieldSet _unknownFields;

	public const int CursorIdFieldNumber = 1;

	private uint cursorId_;

	public const int FetchRowsFieldNumber = 5;

	private ulong fetchRows_;

	[DebuggerNonUserCode]
	public static MessageParser<Fetch> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCursorReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint CursorId
	{
		get
		{
			return cursorId_;
		}
		set
		{
			cursorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ulong FetchRows
	{
		get
		{
			return fetchRows_;
		}
		set
		{
			fetchRows_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Fetch()
	{
	}

	[DebuggerNonUserCode]
	public Fetch(Fetch other)
		: this()
	{
		cursorId_ = other.cursorId_;
		fetchRows_ = other.fetchRows_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Fetch Clone()
	{
		return new Fetch(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Fetch);
	}

	[DebuggerNonUserCode]
	public bool Equals(Fetch other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CursorId != other.CursorId)
		{
			return false;
		}
		if (FetchRows != other.FetchRows)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (CursorId != 0)
		{
			num ^= CursorId.GetHashCode();
		}
		if (FetchRows != 0L)
		{
			num ^= FetchRows.GetHashCode();
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
		if (CursorId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CursorId);
		}
		if (FetchRows != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(FetchRows);
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
		if (CursorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CursorId);
		}
		if (FetchRows != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(FetchRows);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Fetch other)
	{
		if (other != null)
		{
			if (other.CursorId != 0)
			{
				CursorId = other.CursorId;
			}
			if (other.FetchRows != 0L)
			{
				FetchRows = other.FetchRows;
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
			case 40u:
				FetchRows = input.ReadUInt64();
				break;
			case 8u:
				CursorId = input.ReadUInt32();
				break;
			}
		}
	}
}
