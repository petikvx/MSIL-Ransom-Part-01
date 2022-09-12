using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Cursor;

internal sealed class Close : IMessage<Close>, IEquatable<Close>, IDeepCloneable<Close>, IMessage
{
	private static readonly MessageParser<Close> _parser = new MessageParser<Close>((Func<Close>)(() => new Close()));

	private UnknownFieldSet _unknownFields;

	public const int CursorIdFieldNumber = 1;

	private uint cursorId_;

	[DebuggerNonUserCode]
	public static MessageParser<Close> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCursorReflection.Descriptor.get_MessageTypes()[2];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

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
	public Close()
	{
	}

	[DebuggerNonUserCode]
	public Close(Close other)
		: this()
	{
		cursorId_ = other.cursorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Close Clone()
	{
		return new Close(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Close);
	}

	[DebuggerNonUserCode]
	public bool Equals(Close other)
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
		if (_unknownFields != null)
		{
			num ^= ((object)_unknownFields).GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString((IMessage)(object)this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (CursorId != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteUInt32(CursorId);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Close other)
	{
		if (other != null)
		{
			if (other.CursorId != 0)
			{
				CursorId = other.CursorId;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CursorId = input.ReadUInt32();
			}
		}
	}
}
