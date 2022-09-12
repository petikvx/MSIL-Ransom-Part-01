using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class FunctionCall : IMessage<FunctionCall>, IEquatable<FunctionCall>, IDeepCloneable<FunctionCall>, IMessage
{
	private static readonly MessageParser<FunctionCall> _parser = new MessageParser<FunctionCall>((Func<FunctionCall>)(() => new FunctionCall()));

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private Identifier name_;

	public const int ParamFieldNumber = 2;

	private static readonly FieldCodec<Expr> _repeated_param_codec = FieldCodec.ForMessage<Expr>(18u, Expr.Parser);

	private readonly RepeatedField<Expr> param_ = new RepeatedField<Expr>();

	[DebuggerNonUserCode]
	public static MessageParser<FunctionCall> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.get_MessageTypes()[4];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Identifier Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Expr> Param => param_;

	[DebuggerNonUserCode]
	public FunctionCall()
	{
	}

	[DebuggerNonUserCode]
	public FunctionCall(FunctionCall other)
		: this()
	{
		name_ = ((other.name_ != null) ? other.name_.Clone() : null);
		param_ = other.param_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FunctionCall Clone()
	{
		return new FunctionCall(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FunctionCall);
	}

	[DebuggerNonUserCode]
	public bool Equals(FunctionCall other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Name, other.Name))
		{
			return false;
		}
		if (!param_.Equals(other.param_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (name_ != null)
		{
			num ^= Name.GetHashCode();
		}
		num ^= ((object)param_).GetHashCode();
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
		if (name_ != null)
		{
			output.WriteRawTag((byte)10);
			output.WriteMessage((IMessage)(object)Name);
		}
		param_.WriteTo(output, _repeated_param_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (name_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Name);
		}
		num += param_.CalculateSize(_repeated_param_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FunctionCall other)
	{
		if (other == null)
		{
			return;
		}
		if (other.name_ != null)
		{
			if (name_ == null)
			{
				name_ = new Identifier();
			}
			Name.MergeFrom(other.Name);
		}
		param_.Add((IEnumerable<Expr>)other.param_);
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
				param_.AddEntriesFrom(input, _repeated_param_codec);
				break;
			case 10u:
				if (name_ == null)
				{
					name_ = new Identifier();
				}
				input.ReadMessage((IMessage)(object)name_);
				break;
			}
		}
	}
}
