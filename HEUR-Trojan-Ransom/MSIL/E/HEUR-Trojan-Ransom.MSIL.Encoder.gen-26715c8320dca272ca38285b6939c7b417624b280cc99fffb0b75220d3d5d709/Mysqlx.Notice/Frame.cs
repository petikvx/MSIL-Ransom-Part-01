using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Notice;

internal sealed class Frame : IMessage<Frame>, IEquatable<Frame>, IDeepCloneable<Frame>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		public enum Scope
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("GLOBAL")]
			Global,
			[OriginalName("LOCAL")]
			Local
		}

		public enum Type
		{
			[OriginalName("NONE_Type")]
			NoneType,
			[OriginalName("WARNING")]
			Warning,
			[OriginalName("SESSION_VARIABLE_CHANGED")]
			SessionVariableChanged,
			[OriginalName("SESSION_STATE_CHANGED")]
			SessionStateChanged
		}
	}

	private static readonly MessageParser<Frame> _parser = new MessageParser<Frame>((Func<Frame>)(() => new Frame()));

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private uint type_;

	public const int ScopeFieldNumber = 2;

	private Types.Scope scope_;

	public const int PayloadFieldNumber = 3;

	private ByteString payload_ = ByteString.get_Empty();

	[DebuggerNonUserCode]
	public static MessageParser<Frame> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxNoticeReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.Scope Scope
	{
		get
		{
			return scope_;
		}
		set
		{
			scope_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ByteString Payload
	{
		get
		{
			return payload_;
		}
		set
		{
			payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Frame()
	{
	}

	[DebuggerNonUserCode]
	public Frame(Frame other)
		: this()
	{
		type_ = other.type_;
		scope_ = other.scope_;
		payload_ = other.payload_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Frame Clone()
	{
		return new Frame(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Frame);
	}

	[DebuggerNonUserCode]
	public bool Equals(Frame other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Scope != other.Scope)
		{
			return false;
		}
		if (Payload != other.Payload)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Scope != 0)
		{
			num ^= Scope.GetHashCode();
		}
		if (Payload.get_Length() != 0)
		{
			num ^= ((object)Payload).GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag((byte)8);
			output.WriteUInt32(Type);
		}
		if (Scope != 0)
		{
			output.WriteRawTag((byte)16);
			output.WriteEnum((int)Scope);
		}
		if (Payload.get_Length() != 0)
		{
			output.WriteRawTag((byte)26);
			output.WriteBytes(Payload);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (Scope != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Scope);
		}
		if (Payload.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Payload);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Frame other)
	{
		if (other != null)
		{
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Scope != 0)
			{
				Scope = other.Scope;
			}
			if (other.Payload.get_Length() != 0)
			{
				Payload = other.Payload;
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
				Payload = input.ReadBytes();
				break;
			case 16u:
				scope_ = (Types.Scope)input.ReadEnum();
				break;
			case 8u:
				Type = input.ReadUInt32();
				break;
			}
		}
	}
}
