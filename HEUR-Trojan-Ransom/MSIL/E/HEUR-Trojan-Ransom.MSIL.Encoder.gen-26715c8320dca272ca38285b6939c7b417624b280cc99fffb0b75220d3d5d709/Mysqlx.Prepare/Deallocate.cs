using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Prepare;

internal sealed class Deallocate : IMessage<Deallocate>, IEquatable<Deallocate>, IDeepCloneable<Deallocate>, IMessage
{
	private static readonly MessageParser<Deallocate> _parser = new MessageParser<Deallocate>((Func<Deallocate>)(() => new Deallocate()));

	private UnknownFieldSet _unknownFields;

	public const int StmtIdFieldNumber = 1;

	private uint stmtId_;

	[DebuggerNonUserCode]
	public static MessageParser<Deallocate> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxPrepareReflection.Descriptor.get_MessageTypes()[2];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint StmtId
	{
		get
		{
			return stmtId_;
		}
		set
		{
			stmtId_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Deallocate()
	{
	}

	[DebuggerNonUserCode]
	public Deallocate(Deallocate other)
		: this()
	{
		stmtId_ = other.stmtId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Deallocate Clone()
	{
		return new Deallocate(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Deallocate);
	}

	[DebuggerNonUserCode]
	public bool Equals(Deallocate other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StmtId != other.StmtId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (StmtId != 0)
		{
			num ^= StmtId.GetHashCode();
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
		if (StmtId != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteUInt32(StmtId);
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
		if (StmtId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StmtId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Deallocate other)
	{
		if (other != null)
		{
			if (other.StmtId != 0)
			{
				StmtId = other.StmtId;
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
				StmtId = input.ReadUInt32();
			}
		}
	}
}
