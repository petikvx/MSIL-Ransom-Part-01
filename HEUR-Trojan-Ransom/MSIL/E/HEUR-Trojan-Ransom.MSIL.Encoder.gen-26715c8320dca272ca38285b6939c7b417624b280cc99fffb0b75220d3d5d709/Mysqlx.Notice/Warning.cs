using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Notice;

internal sealed class Warning : IMessage<Warning>, IEquatable<Warning>, IDeepCloneable<Warning>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum Level
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("NOTE")]
			Note,
			[OriginalName("WARNING")]
			Warning,
			[OriginalName("ERROR")]
			Error
		}
	}

	private static readonly MessageParser<Warning> _parser = new MessageParser<Warning>((Func<Warning>)(() => new Warning()));

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private Types.Level level_;

	public const int CodeFieldNumber = 2;

	private uint code_;

	public const int MsgFieldNumber = 3;

	private string msg_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Warning> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxNoticeReflection.Descriptor.get_MessageTypes()[1];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Level Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	public uint Code
	{
		get
		{
			return code_;
		}
		set
		{
			code_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Warning()
	{
	}

	[DebuggerNonUserCode]
	public Warning(Warning other)
		: this()
	{
		level_ = other.level_;
		code_ = other.code_;
		msg_ = other.msg_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Warning Clone()
	{
		return new Warning(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Warning);
	}

	[DebuggerNonUserCode]
	public bool Equals(Warning other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteEnum((int)Level);
		}
		if (Code != 0)
		{
			output.WriteRawTag((byte)16);
			output.WriteUInt32(Code);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag((byte)26);
			output.WriteString(Msg);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Level);
		}
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Code);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Warning other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
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
			case 26u:
				Msg = input.ReadString();
				break;
			case 16u:
				Code = input.ReadUInt32();
				break;
			case 8u:
				level_ = (Types.Level)input.ReadEnum();
				break;
			}
		}
	}
}
