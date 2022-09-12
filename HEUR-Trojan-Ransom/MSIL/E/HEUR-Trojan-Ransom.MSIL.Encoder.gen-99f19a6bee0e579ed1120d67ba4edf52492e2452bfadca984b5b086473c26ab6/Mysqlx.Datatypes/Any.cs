using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Datatypes;

internal sealed class Any : IMessage<Any>, IEquatable<Any>, IDeepCloneable<Any>, IMessage
{
	[DebuggerNonUserCode]
	public static class Types
	{
		public enum Type
		{
			[OriginalName("NONE")]
			None,
			[OriginalName("SCALAR")]
			Scalar,
			[OriginalName("OBJECT")]
			Object,
			[OriginalName("ARRAY")]
			Array
		}
	}

	private static readonly MessageParser<Any> _parser = new MessageParser<Any>(() => new Any());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Types.Type type_;

	public const int ScalarFieldNumber = 2;

	private Scalar scalar_;

	public const int ObjFieldNumber = 3;

	private Object obj_;

	public const int ArrayFieldNumber = 4;

	private Array array_;

	[DebuggerNonUserCode]
	public static MessageParser<Any> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxDatatypesReflection.Descriptor.MessageTypes[3];

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
	public Scalar Scalar
	{
		get
		{
			return scalar_;
		}
		set
		{
			scalar_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Object Obj
	{
		get
		{
			return obj_;
		}
		set
		{
			obj_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Array Array
	{
		get
		{
			return array_;
		}
		set
		{
			array_ = value;
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
		type_ = other.type_;
		scalar_ = ((other.scalar_ != null) ? other.scalar_.Clone() : null);
		obj_ = ((other.obj_ != null) ? other.obj_.Clone() : null);
		array_ = ((other.array_ != null) ? other.array_.Clone() : null);
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
		if (Type != other.Type)
		{
			return false;
		}
		if (!object.Equals(Scalar, other.Scalar))
		{
			return false;
		}
		if (!object.Equals(Obj, other.Obj))
		{
			return false;
		}
		if (!object.Equals(Array, other.Array))
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
		if (scalar_ != null)
		{
			num ^= Scalar.GetHashCode();
		}
		if (obj_ != null)
		{
			num ^= Obj.GetHashCode();
		}
		if (array_ != null)
		{
			num ^= Array.GetHashCode();
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (scalar_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Scalar);
		}
		if (obj_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Obj);
		}
		if (array_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Array);
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
		if (scalar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scalar);
		}
		if (obj_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Obj);
		}
		if (array_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Array);
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
		if (other == null)
		{
			return;
		}
		if (other.Type != 0)
		{
			Type = other.Type;
		}
		if (other.scalar_ != null)
		{
			if (scalar_ == null)
			{
				scalar_ = new Scalar();
			}
			Scalar.MergeFrom(other.Scalar);
		}
		if (other.obj_ != null)
		{
			if (obj_ == null)
			{
				obj_ = new Object();
			}
			Obj.MergeFrom(other.Obj);
		}
		if (other.array_ != null)
		{
			if (array_ == null)
			{
				array_ = new Array();
			}
			Array.MergeFrom(other.Array);
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
			case 18u:
				if (scalar_ == null)
				{
					scalar_ = new Scalar();
				}
				input.ReadMessage(scalar_);
				break;
			case 8u:
				type_ = (Types.Type)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 34u:
				if (array_ == null)
				{
					array_ = new Array();
				}
				input.ReadMessage(array_);
				break;
			case 26u:
				if (obj_ == null)
				{
					obj_ = new Object();
				}
				input.ReadMessage(obj_);
				break;
			}
		}
	}
}
