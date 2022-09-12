using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Any : IMessage<Any>, IEquatable<Any>, IDeepCloneable<Any>, IMessage
{
	private static readonly MessageParser<Any> _parser = new MessageParser<Any>(() => new Any());

	private UnknownFieldSet _unknownFields;

	public const int TypeUrlFieldNumber = 1;

	private string typeUrl_ = "";

	public const int ValueFieldNumber = 2;

	private ByteString value_ = ByteString.Empty;

	private const string DefaultPrefix = "type.googleapis.com";

	[DebuggerNonUserCode]
	public static MessageParser<Any> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AnyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string TypeUrl
	{
		get
		{
			return typeUrl_;
		}
		set
		{
			typeUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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
	public Any()
	{
	}

	[DebuggerNonUserCode]
	public Any(Any other)
		: this()
	{
		typeUrl_ = other.typeUrl_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Any Clone()
	{
		return new Any(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Any);
	}

	[DebuggerNonUserCode]
	public bool Equals(Any other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TypeUrl != other.TypeUrl)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (TypeUrl.Length != 0)
		{
			num ^= TypeUrl.GetHashCode();
		}
		if (Value.Length != 0)
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
		if (TypeUrl.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(TypeUrl);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(Value);
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
		if (TypeUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TypeUrl);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Any other)
	{
		if (other != null)
		{
			if (other.TypeUrl.Length != 0)
			{
				TypeUrl = other.TypeUrl;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
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
			case 18u:
				Value = input.ReadBytes();
				break;
			case 10u:
				TypeUrl = input.ReadString();
				break;
			}
		}
	}

	private static string GetTypeUrl(MessageDescriptor descriptor, string prefix)
	{
		if (!prefix.EndsWith("/"))
		{
			return prefix + "/" + descriptor.FullName;
		}
		return prefix + descriptor.FullName;
	}

	public static string GetTypeName(string typeUrl)
	{
		ProtoPreconditions.CheckNotNull(typeUrl, "typeUrl");
		int num = typeUrl.LastIndexOf('/');
		if (num != -1)
		{
			return typeUrl.Substring(num + 1);
		}
		return "";
	}

	public T Unpack<T>() where T : IMessage, new()
	{
		T val = new T();
		if (GetTypeName(TypeUrl) != val.Descriptor.FullName)
		{
			throw new InvalidProtocolBufferException($"Full type name for {val.Descriptor.Name} is {val.Descriptor.FullName}; Any message's type url is {TypeUrl}");
		}
		val.MergeFrom(Value);
		return val;
	}

	public bool TryUnpack<T>(out T result) where T : IMessage, new()
	{
		T val = new T();
		if (GetTypeName(TypeUrl) != val.Descriptor.FullName)
		{
			result = default(T);
			return false;
		}
		val.MergeFrom(Value);
		result = val;
		return true;
	}

	public static Any Pack(IMessage message)
	{
		return Pack(message, "type.googleapis.com");
	}

	public static Any Pack(IMessage message, string typeUrlPrefix)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(typeUrlPrefix, "typeUrlPrefix");
		return new Any
		{
			TypeUrl = GetTypeUrl(message.Descriptor, typeUrlPrefix),
			Value = message.ToByteString()
		};
	}
}
