using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Notice;

internal sealed class SessionVariableChanged : IMessage<SessionVariableChanged>, IEquatable<SessionVariableChanged>, IDeepCloneable<SessionVariableChanged>, IMessage
{
	private static readonly MessageParser<SessionVariableChanged> _parser = new MessageParser<SessionVariableChanged>(() => new SessionVariableChanged());

	private UnknownFieldSet _unknownFields;

	public const int ParamFieldNumber = 1;

	private string param_ = "";

	public const int ValueFieldNumber = 2;

	private Scalar value_;

	[DebuggerNonUserCode]
	public static MessageParser<SessionVariableChanged> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxNoticeReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Scalar Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged()
	{
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged(SessionVariableChanged other)
		: this()
	{
		param_ = other.param_;
		Value = ((other.value_ != null) ? other.Value.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged Clone()
	{
		return new SessionVariableChanged(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SessionVariableChanged);
	}

	[DebuggerNonUserCode]
	public bool Equals(SessionVariableChanged other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Param != other.Param)
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Param.Length != 0)
		{
			num ^= Param.GetHashCode();
		}
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
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
		if (Param.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Param);
		}
		if (value_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Value);
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
		if (Param.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Param);
		}
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SessionVariableChanged other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Param.Length != 0)
		{
			Param = other.Param;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				value_ = new Scalar();
			}
			Value.MergeFrom(other.Value);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (value_ == null)
				{
					value_ = new Scalar();
				}
				input.ReadMessage(value_);
				break;
			case 10u:
				Param = input.ReadString();
				break;
			}
		}
	}
}
