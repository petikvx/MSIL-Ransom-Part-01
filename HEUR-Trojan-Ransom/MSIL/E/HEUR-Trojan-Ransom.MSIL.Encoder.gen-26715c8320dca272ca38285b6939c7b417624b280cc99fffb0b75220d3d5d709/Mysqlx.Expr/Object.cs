using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Expr;

internal sealed class Object : IMessage<Object>, IEquatable<Object>, IDeepCloneable<Object>, IMessage
{
	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class ObjectField : IMessage<ObjectField>, IEquatable<ObjectField>, IDeepCloneable<ObjectField>, IMessage
		{
			private static readonly MessageParser<ObjectField> _parser = new MessageParser<ObjectField>((Func<ObjectField>)(() => new ObjectField()));

			private UnknownFieldSet _unknownFields;

			public const int KeyFieldNumber = 1;

			private string key_ = "";

			public const int ValueFieldNumber = 2;

			private Expr value_;

			[DebuggerNonUserCode]
			public static MessageParser<ObjectField> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Object.Descriptor.get_NestedTypes()[0];

			[DebuggerNonUserCode]
			MessageDescriptor Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public string Key
			{
				get
				{
					return key_;
				}
				set
				{
					key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				}
			}

			[DebuggerNonUserCode]
			public Expr Value
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
			public ObjectField()
			{
			}

			[DebuggerNonUserCode]
			public ObjectField(ObjectField other)
				: this()
			{
				key_ = other.key_;
				value_ = ((other.value_ != null) ? other.value_.Clone() : null);
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public ObjectField Clone()
			{
				return new ObjectField(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as ObjectField);
			}

			[DebuggerNonUserCode]
			public bool Equals(ObjectField other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Key != other.Key)
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
				if (Key.Length != 0)
				{
					num ^= Key.GetHashCode();
				}
				if (value_ != null)
				{
					num ^= Value.GetHashCode();
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
				if (Key.Length != 0)
				{
					output.WriteRawTag((byte)10);
					output.WriteString(Key);
				}
				if (value_ != null)
				{
					output.WriteRawTag((byte)18);
					output.WriteMessage((IMessage)(object)Value);
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
				if (Key.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(Key);
				}
				if (value_ != null)
				{
					num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Value);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(ObjectField other)
			{
				if (other == null)
				{
					return;
				}
				if (other.Key.Length != 0)
				{
					Key = other.Key;
				}
				if (other.value_ != null)
				{
					if (value_ == null)
					{
						value_ = new Expr();
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
							value_ = new Expr();
						}
						input.ReadMessage((IMessage)(object)value_);
						break;
					case 10u:
						Key = input.ReadString();
						break;
					}
				}
			}
		}
	}

	private static readonly MessageParser<Object> _parser = new MessageParser<Object>((Func<Object>)(() => new Object()));

	private UnknownFieldSet _unknownFields;

	public const int FldFieldNumber = 1;

	private static readonly FieldCodec<Types.ObjectField> _repeated_fld_codec = FieldCodec.ForMessage<Types.ObjectField>(10u, Types.ObjectField.Parser);

	private readonly RepeatedField<Types.ObjectField> fld_ = new RepeatedField<Types.ObjectField>();

	[DebuggerNonUserCode]
	public static MessageParser<Object> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxExprReflection.Descriptor.get_MessageTypes()[6];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Types.ObjectField> Fld => fld_;

	[DebuggerNonUserCode]
	public Object()
	{
	}

	[DebuggerNonUserCode]
	public Object(Object other)
		: this()
	{
		fld_ = other.fld_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Object Clone()
	{
		return new Object(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Object);
	}

	[DebuggerNonUserCode]
	public bool Equals(Object other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fld_.Equals(other.fld_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ ((object)fld_).GetHashCode();
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
		fld_.WriteTo(output, _repeated_fld_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + fld_.CalculateSize(_repeated_fld_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Object other)
	{
		if (other != null)
		{
			fld_.Add((IEnumerable<Types.ObjectField>)other.fld_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				fld_.AddEntriesFrom(input, _repeated_fld_codec);
			}
		}
	}
}
