using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Mysqlx.Datatypes;

internal sealed class Scalar : IMessage<Scalar>, IEquatable<Scalar>, IDeepCloneable<Scalar>, IMessage
{
	public enum DefaultOneOfOneofCase
	{
		None = 0,
		VSignedInt = 2,
		VUnsignedInt = 3,
		VOctets = 5,
		VDouble = 6,
		VFloat = 7,
		VBool = 8,
		VString = 9
	}

	[DebuggerNonUserCode]
	public static class Types
	{
		public enum Type
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("V_SINT")]
			VSint,
			[OriginalName("V_UINT")]
			VUint,
			[OriginalName("V_NULL")]
			VNull,
			[OriginalName("V_OCTETS")]
			VOctets,
			[OriginalName("V_DOUBLE")]
			VDouble,
			[OriginalName("V_FLOAT")]
			VFloat,
			[OriginalName("V_BOOL")]
			VBool,
			[OriginalName("V_STRING")]
			VString
		}

		public sealed class String : IMessage<String>, IEquatable<String>, IDeepCloneable<String>, IMessage
		{
			public enum StringPresentOneofCase
			{
				None,
				Value,
				Collation
			}

			private static readonly MessageParser<String> _parser = new MessageParser<String>(() => new String());

			private UnknownFieldSet _unknownFields;

			public const int ValueFieldNumber = 1;

			public const int CollationFieldNumber = 2;

			private object stringPresent_;

			private StringPresentOneofCase stringPresentCase_;

			[DebuggerNonUserCode]
			public static MessageParser<String> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Scalar.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public ByteString Value
			{
				get
				{
					if (stringPresentCase_ != StringPresentOneofCase.Value)
					{
						return ByteString.Empty;
					}
					return (ByteString)stringPresent_;
				}
				set
				{
					stringPresent_ = ProtoPreconditions.CheckNotNull(value, "value");
					stringPresentCase_ = StringPresentOneofCase.Value;
				}
			}

			[DebuggerNonUserCode]
			public ulong Collation
			{
				get
				{
					if (stringPresentCase_ != StringPresentOneofCase.Collation)
					{
						return 0uL;
					}
					return (ulong)stringPresent_;
				}
				set
				{
					stringPresent_ = value;
					stringPresentCase_ = StringPresentOneofCase.Collation;
				}
			}

			[DebuggerNonUserCode]
			public StringPresentOneofCase StringPresentCase => stringPresentCase_;

			[DebuggerNonUserCode]
			public String()
			{
			}

			[DebuggerNonUserCode]
			public String(String other)
				: this()
			{
				switch (other.StringPresentCase)
				{
				case StringPresentOneofCase.Collation:
					Collation = other.Collation;
					break;
				case StringPresentOneofCase.Value:
					Value = other.Value;
					break;
				}
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public String Clone()
			{
				return new String(this);
			}

			[DebuggerNonUserCode]
			public void ClearStringPresent()
			{
				stringPresentCase_ = StringPresentOneofCase.None;
				stringPresent_ = null;
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as String);
			}

			[DebuggerNonUserCode]
			public bool Equals(String other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Value != other.Value)
				{
					return false;
				}
				if (Collation != other.Collation)
				{
					return false;
				}
				if (StringPresentCase != other.StringPresentCase)
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (stringPresentCase_ == StringPresentOneofCase.Value)
				{
					num ^= Value.GetHashCode();
				}
				if (stringPresentCase_ == StringPresentOneofCase.Collation)
				{
					num ^= Collation.GetHashCode();
				}
				num ^= (int)stringPresentCase_;
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
				if (stringPresentCase_ == StringPresentOneofCase.Value)
				{
					output.WriteRawTag(10);
					output.WriteBytes(Value);
				}
				if (stringPresentCase_ == StringPresentOneofCase.Collation)
				{
					output.WriteRawTag(16);
					output.WriteUInt64(Collation);
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
				if (stringPresentCase_ == StringPresentOneofCase.Value)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(Value);
				}
				if (stringPresentCase_ == StringPresentOneofCase.Collation)
				{
					num += 1 + CodedOutputStream.ComputeUInt64Size(Collation);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(String other)
			{
				if (other != null)
				{
					switch (other.StringPresentCase)
					{
					case StringPresentOneofCase.Collation:
						Collation = other.Collation;
						break;
					case StringPresentOneofCase.Value:
						Value = other.Value;
						break;
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
						Collation = input.ReadUInt64();
						break;
					case 10u:
						Value = input.ReadBytes();
						break;
					}
				}
			}
		}

		public sealed class Octets : IMessage<Octets>, IEquatable<Octets>, IDeepCloneable<Octets>, IMessage
		{
			private static readonly MessageParser<Octets> _parser = new MessageParser<Octets>(() => new Octets());

			private UnknownFieldSet _unknownFields;

			public const int ValueFieldNumber = 1;

			private ByteString value_ = ByteString.Empty;

			public const int ContentTypeFieldNumber = 2;

			private uint contentType_;

			[DebuggerNonUserCode]
			public static MessageParser<Octets> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => Scalar.Descriptor.NestedTypes[1];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public ByteString Value
			{
				get
				{
					return value_;
				}
				set
				{
					value_ = ProtoPreconditions.CheckNotNull(value, "value");
				}
			}

			[DebuggerNonUserCode]
			public uint ContentType
			{
				get
				{
					return contentType_;
				}
				set
				{
					contentType_ = value;
				}
			}

			[DebuggerNonUserCode]
			public Octets()
			{
			}

			[DebuggerNonUserCode]
			public Octets(Octets other)
				: this()
			{
				value_ = other.value_;
				contentType_ = other.contentType_;
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public Octets Clone()
			{
				return new Octets(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as Octets);
			}

			[DebuggerNonUserCode]
			public bool Equals(Octets other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (Value != other.Value)
				{
					return false;
				}
				if (ContentType != other.ContentType)
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				if (Value.Length != 0)
				{
					num ^= Value.GetHashCode();
				}
				if (ContentType != 0)
				{
					num ^= ContentType.GetHashCode();
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
				if (Value.Length != 0)
				{
					output.WriteRawTag(10);
					output.WriteBytes(Value);
				}
				if (ContentType != 0)
				{
					output.WriteRawTag(16);
					output.WriteUInt32(ContentType);
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
				if (Value.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeBytesSize(Value);
				}
				if (ContentType != 0)
				{
					num += 1 + CodedOutputStream.ComputeUInt32Size(ContentType);
				}
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(Octets other)
			{
				if (other != null)
				{
					if (other.Value.Length != 0)
					{
						Value = other.Value;
					}
					if (other.ContentType != 0)
					{
						ContentType = other.ContentType;
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
						ContentType = input.ReadUInt32();
						break;
					case 10u:
						Value = input.ReadBytes();
						break;
					}
				}
			}
		}
	}

	private static readonly MessageParser<Scalar> _parser = new MessageParser<Scalar>(() => new Scalar());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Types.Type type_;

	public const int VSignedIntFieldNumber = 2;

	public const int VUnsignedIntFieldNumber = 3;

	public const int VOctetsFieldNumber = 5;

	public const int VDoubleFieldNumber = 6;

	public const int VFloatFieldNumber = 7;

	public const int VBoolFieldNumber = 8;

	public const int VStringFieldNumber = 9;

	private object defaultOneOf_;

	private DefaultOneOfOneofCase defaultOneOfCase_;

	[DebuggerNonUserCode]
	public static MessageParser<Scalar> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxDatatypesReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Types.Type Type
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
	public long VSignedInt
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VSignedInt)
			{
				return 0L;
			}
			return (long)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = DefaultOneOfOneofCase.VSignedInt;
		}
	}

	[DebuggerNonUserCode]
	public ulong VUnsignedInt
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VUnsignedInt)
			{
				return 0uL;
			}
			return (ulong)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = DefaultOneOfOneofCase.VUnsignedInt;
		}
	}

	[DebuggerNonUserCode]
	public Types.Octets VOctets
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VOctets)
			{
				return null;
			}
			return (Types.Octets)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = ((value != null) ? DefaultOneOfOneofCase.VOctets : DefaultOneOfOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	public double VDouble
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VDouble)
			{
				return 0.0;
			}
			return (double)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = DefaultOneOfOneofCase.VDouble;
		}
	}

	[DebuggerNonUserCode]
	public float VFloat
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VFloat)
			{
				return 0f;
			}
			return (float)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = DefaultOneOfOneofCase.VFloat;
		}
	}

	[DebuggerNonUserCode]
	public bool VBool
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VBool)
			{
				return false;
			}
			return (bool)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = DefaultOneOfOneofCase.VBool;
		}
	}

	[DebuggerNonUserCode]
	public Types.String VString
	{
		get
		{
			if (defaultOneOfCase_ != DefaultOneOfOneofCase.VString)
			{
				return null;
			}
			return (Types.String)defaultOneOf_;
		}
		set
		{
			defaultOneOf_ = value;
			defaultOneOfCase_ = ((value != null) ? DefaultOneOfOneofCase.VString : DefaultOneOfOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	public DefaultOneOfOneofCase DefaultOneOfCase => defaultOneOfCase_;

	[DebuggerNonUserCode]
	public Scalar()
	{
	}

	[DebuggerNonUserCode]
	public Scalar(Scalar other)
		: this()
	{
		type_ = other.type_;
		switch (other.DefaultOneOfCase)
		{
		case DefaultOneOfOneofCase.VSignedInt:
			VSignedInt = other.VSignedInt;
			break;
		case DefaultOneOfOneofCase.VUnsignedInt:
			VUnsignedInt = other.VUnsignedInt;
			break;
		case DefaultOneOfOneofCase.VOctets:
			VOctets = other.VOctets.Clone();
			break;
		case DefaultOneOfOneofCase.VDouble:
			VDouble = other.VDouble;
			break;
		case DefaultOneOfOneofCase.VFloat:
			VFloat = other.VFloat;
			break;
		case DefaultOneOfOneofCase.VBool:
			VBool = other.VBool;
			break;
		case DefaultOneOfOneofCase.VString:
			VString = other.VString.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Scalar Clone()
	{
		return new Scalar(this);
	}

	[DebuggerNonUserCode]
	public void ClearDefaultOneOf()
	{
		defaultOneOfCase_ = DefaultOneOfOneofCase.None;
		defaultOneOf_ = null;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Scalar);
	}

	[DebuggerNonUserCode]
	public bool Equals(Scalar other)
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
		if (VSignedInt != other.VSignedInt)
		{
			return false;
		}
		if (VUnsignedInt != other.VUnsignedInt)
		{
			return false;
		}
		if (!object.Equals(VOctets, other.VOctets))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(VDouble, other.VDouble))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VFloat, other.VFloat))
		{
			return false;
		}
		if (VBool != other.VBool)
		{
			return false;
		}
		if (!object.Equals(VString, other.VString))
		{
			return false;
		}
		if (DefaultOneOfCase != other.DefaultOneOfCase)
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
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VSignedInt)
		{
			num ^= VSignedInt.GetHashCode();
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VUnsignedInt)
		{
			num ^= VUnsignedInt.GetHashCode();
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VOctets)
		{
			num ^= VOctets.GetHashCode();
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VDouble)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(VDouble);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VFloat)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VFloat);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VBool)
		{
			num ^= VBool.GetHashCode();
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VString)
		{
			num ^= VString.GetHashCode();
		}
		num ^= (int)defaultOneOfCase_;
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VSignedInt)
		{
			output.WriteRawTag(16);
			output.WriteSInt64(VSignedInt);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VUnsignedInt)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(VUnsignedInt);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VOctets)
		{
			output.WriteRawTag(42);
			output.WriteMessage(VOctets);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VDouble)
		{
			output.WriteRawTag(49);
			output.WriteDouble(VDouble);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VFloat)
		{
			output.WriteRawTag(61);
			output.WriteFloat(VFloat);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VBool)
		{
			output.WriteRawTag(64);
			output.WriteBool(VBool);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VString)
		{
			output.WriteRawTag(74);
			output.WriteMessage(VString);
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
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VSignedInt)
		{
			num += 1 + CodedOutputStream.ComputeSInt64Size(VSignedInt);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VUnsignedInt)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(VUnsignedInt);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VOctets)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VOctets);
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VDouble)
		{
			num += 9;
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VFloat)
		{
			num += 5;
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VBool)
		{
			num += 2;
		}
		if (defaultOneOfCase_ == DefaultOneOfOneofCase.VString)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VString);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Scalar other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		switch (other.DefaultOneOfCase)
		{
		case DefaultOneOfOneofCase.VSignedInt:
			VSignedInt = other.VSignedInt;
			break;
		case DefaultOneOfOneofCase.VUnsignedInt:
			VUnsignedInt = other.VUnsignedInt;
			break;
		case DefaultOneOfOneofCase.VOctets:
			if (VOctets == null)
			{
				VOctets = new Types.Octets();
			}
			VOctets.MergeFrom(other.VOctets);
			break;
		case DefaultOneOfOneofCase.VDouble:
			VDouble = other.VDouble;
			break;
		case DefaultOneOfOneofCase.VFloat:
			VFloat = other.VFloat;
			break;
		case DefaultOneOfOneofCase.VBool:
			VBool = other.VBool;
			break;
		case DefaultOneOfOneofCase.VString:
			if (VString == null)
			{
				VString = new Types.String();
			}
			VString.MergeFrom(other.VString);
			break;
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
			case 16u:
				VSignedInt = input.ReadSInt64();
				break;
			case 8u:
				type_ = (Types.Type)input.ReadEnum();
				break;
			case 42u:
			{
				Types.Octets octets = new Types.Octets();
				if (defaultOneOfCase_ == DefaultOneOfOneofCase.VOctets)
				{
					octets.MergeFrom(VOctets);
				}
				input.ReadMessage(octets);
				VOctets = octets;
				break;
			}
			case 24u:
				VUnsignedInt = input.ReadUInt64();
				break;
			case 61u:
				VFloat = input.ReadFloat();
				break;
			case 49u:
				VDouble = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 74u:
			{
				Types.String @string = new Types.String();
				if (defaultOneOfCase_ == DefaultOneOfOneofCase.VString)
				{
					@string.MergeFrom(VString);
				}
				input.ReadMessage(@string);
				VString = @string;
				break;
			}
			case 64u:
				VBool = input.ReadBool();
				break;
			}
		}
	}
}
