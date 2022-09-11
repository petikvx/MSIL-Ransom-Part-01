using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Value : IMessage, IMessage<Value>, IEquatable<Value>, IDeepCloneable<Value>
{
	public enum KindOneofCase
	{
		None,
		NullValue,
		NumberValue,
		StringValue,
		BoolValue,
		StructValue,
		ListValue
	}

	private static readonly MessageParser<Value> _parser;

	private UnknownFieldSet _unknownFields;

	public const int NullValueFieldNumber = 1;

	public const int NumberValueFieldNumber = 2;

	public const int StringValueFieldNumber = 3;

	public const int BoolValueFieldNumber = 4;

	public const int StructValueFieldNumber = 5;

	public const int ListValueFieldNumber = 6;

	private object kind_;

	private KindOneofCase kindCase_;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Value> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => StructReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public NullValue NullValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.NullValue)
			{
				return NullValue.NullValue;
			}
			return (NullValue)kind_;
		}
		set
		{
			kind_ = value;
			kindCase_ = KindOneofCase.NullValue;
		}
	}

	[DebuggerNonUserCode]
	public double NumberValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.NumberValue)
			{
				return 0.0;
			}
			return (double)kind_;
		}
		set
		{
			kind_ = value;
			kindCase_ = KindOneofCase.NumberValue;
		}
	}

	[DebuggerNonUserCode]
	public string StringValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.StringValue)
			{
				return getString_0(107399797);
			}
			return (string)kind_;
		}
		set
		{
			kind_ = ProtoPreconditions.CheckNotNull(value, getString_0(107394750));
			kindCase_ = KindOneofCase.StringValue;
		}
	}

	[DebuggerNonUserCode]
	public bool BoolValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.BoolValue)
			{
				return false;
			}
			return (bool)kind_;
		}
		set
		{
			kind_ = value;
			kindCase_ = KindOneofCase.BoolValue;
		}
	}

	[DebuggerNonUserCode]
	public Struct StructValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.StructValue)
			{
				return null;
			}
			return (Struct)kind_;
		}
		set
		{
			kind_ = value;
			kindCase_ = ((value != null) ? KindOneofCase.StructValue : KindOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	public ListValue ListValue
	{
		get
		{
			if (kindCase_ != KindOneofCase.ListValue)
			{
				return null;
			}
			return (ListValue)kind_;
		}
		set
		{
			kind_ = value;
			kindCase_ = ((value != null) ? KindOneofCase.ListValue : KindOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	public KindOneofCase KindCase => kindCase_;

	[DebuggerNonUserCode]
	public Value()
	{
	}

	[DebuggerNonUserCode]
	public Value(Value other)
		: this()
	{
		switch (other.KindCase)
		{
		case KindOneofCase.NullValue:
			NullValue = other.NullValue;
			break;
		case KindOneofCase.NumberValue:
			NumberValue = other.NumberValue;
			break;
		case KindOneofCase.StringValue:
			StringValue = other.StringValue;
			break;
		case KindOneofCase.BoolValue:
			BoolValue = other.BoolValue;
			break;
		case KindOneofCase.StructValue:
			StructValue = other.StructValue.Clone();
			break;
		case KindOneofCase.ListValue:
			ListValue = other.ListValue.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Value Clone()
	{
		return new Value(this);
	}

	[DebuggerNonUserCode]
	public void ClearKind()
	{
		kindCase_ = KindOneofCase.None;
		kind_ = null;
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Value);
	}

	[DebuggerNonUserCode]
	public bool Equals(Value other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NullValue != other.NullValue)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NumberValue, other.NumberValue))
		{
			return false;
		}
		if (StringValue != other.StringValue)
		{
			return false;
		}
		if (BoolValue != other.BoolValue)
		{
			return false;
		}
		if (!object.Equals(StructValue, other.StructValue))
		{
			return false;
		}
		if (!object.Equals(ListValue, other.ListValue))
		{
			return false;
		}
		if (KindCase != other.KindCase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (kindCase_ == KindOneofCase.NullValue)
		{
			num ^= NullValue.GetHashCode();
		}
		if (kindCase_ == KindOneofCase.NumberValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NumberValue);
		}
		if (kindCase_ == KindOneofCase.StringValue)
		{
			num ^= StringValue.GetHashCode();
		}
		if (kindCase_ == KindOneofCase.BoolValue)
		{
			num ^= BoolValue.GetHashCode();
		}
		if (kindCase_ == KindOneofCase.StructValue)
		{
			num ^= StructValue.GetHashCode();
		}
		if (kindCase_ == KindOneofCase.ListValue)
		{
			num ^= ListValue.GetHashCode();
		}
		num ^= (int)kindCase_;
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
		if (kindCase_ == KindOneofCase.NullValue)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)NullValue);
		}
		if (kindCase_ == KindOneofCase.NumberValue)
		{
			output.WriteRawTag(17);
			output.WriteDouble(NumberValue);
		}
		if (kindCase_ == KindOneofCase.StringValue)
		{
			output.WriteRawTag(26);
			output.WriteString(StringValue);
		}
		if (kindCase_ == KindOneofCase.BoolValue)
		{
			output.WriteRawTag(32);
			output.WriteBool(BoolValue);
		}
		if (kindCase_ == KindOneofCase.StructValue)
		{
			output.WriteRawTag(42);
			output.WriteMessage(StructValue);
		}
		if (kindCase_ == KindOneofCase.ListValue)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ListValue);
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
		if (kindCase_ == KindOneofCase.NullValue)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NullValue);
		}
		if (kindCase_ == KindOneofCase.NumberValue)
		{
			num += 9;
		}
		if (kindCase_ == KindOneofCase.StringValue)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StringValue);
		}
		if (kindCase_ == KindOneofCase.BoolValue)
		{
			num += 2;
		}
		if (kindCase_ == KindOneofCase.StructValue)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StructValue);
		}
		if (kindCase_ == KindOneofCase.ListValue)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ListValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Value other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KindCase)
		{
		case KindOneofCase.NullValue:
			NullValue = other.NullValue;
			break;
		case KindOneofCase.NumberValue:
			NumberValue = other.NumberValue;
			break;
		case KindOneofCase.StringValue:
			StringValue = other.StringValue;
			break;
		case KindOneofCase.BoolValue:
			BoolValue = other.BoolValue;
			break;
		case KindOneofCase.StructValue:
			if (StructValue == null)
			{
				StructValue = new Struct();
			}
			StructValue.MergeFrom(other.StructValue);
			break;
		case KindOneofCase.ListValue:
			if (ListValue == null)
			{
				ListValue = new ListValue();
			}
			ListValue.MergeFrom(other.ListValue);
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
			case 26u:
				StringValue = input.ReadString();
				break;
			case 17u:
				NumberValue = input.ReadDouble();
				break;
			case 8u:
				kind_ = input.ReadEnum();
				kindCase_ = KindOneofCase.NullValue;
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 50u:
			{
				ListValue listValue = new ListValue();
				if (kindCase_ == KindOneofCase.ListValue)
				{
					listValue.MergeFrom(ListValue);
				}
				input.ReadMessage(listValue);
				ListValue = listValue;
				break;
			}
			case 42u:
			{
				Struct @struct = new Struct();
				if (kindCase_ == KindOneofCase.StructValue)
				{
					@struct.MergeFrom(StructValue);
				}
				input.ReadMessage(@struct);
				StructValue = @struct;
				break;
			}
			case 32u:
				BoolValue = input.ReadBool();
				break;
			}
		}
	}

	public static Value ForString(string value)
	{
		ProtoPreconditions.CheckNotNull(value, getString_0(107394750));
		return new Value
		{
			StringValue = value
		};
	}

	public static Value ForNumber(double value)
	{
		return new Value
		{
			NumberValue = value
		};
	}

	public static Value ForBool(bool value)
	{
		return new Value
		{
			BoolValue = value
		};
	}

	public static Value ForNull()
	{
		return new Value
		{
			NullValue = NullValue.NullValue
		};
	}

	public static Value ForList(params Value[] values)
	{
		ProtoPreconditions.CheckNotNull(values, getString_0(107457183));
		return new Value
		{
			ListValue = new ListValue
			{
				Values = { (IEnumerable<Value>)values }
			}
		};
	}

	public static Value ForStruct(Struct value)
	{
		ProtoPreconditions.CheckNotNull(value, getString_0(107394750));
		return new Value
		{
			StructValue = value
		};
	}

	static Value()
	{
		Strings.CreateGetStringDelegate(typeof(Value));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399975), getString_0(107399970)).Replace(getString_0(107399933), getString_0(107399928)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399923)))
		{
			throw new SecurityException(getString_0(107399898));
		}
		_parser = new MessageParser<Value>(() => new Value());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
