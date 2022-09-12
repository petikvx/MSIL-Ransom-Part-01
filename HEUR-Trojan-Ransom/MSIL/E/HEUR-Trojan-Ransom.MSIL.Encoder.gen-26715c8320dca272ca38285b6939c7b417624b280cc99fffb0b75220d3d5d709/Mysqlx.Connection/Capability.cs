using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;

namespace Mysqlx.Connection;

internal sealed class Capability : IMessage<Capability>, IEquatable<Capability>, IDeepCloneable<Capability>, IMessage
{
	private static readonly MessageParser<Capability> _parser = new MessageParser<Capability>((Func<Capability>)(() => new Capability()));

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int ValueFieldNumber = 2;

	private Any value_;

	[DebuggerNonUserCode]
	public static MessageParser<Capability> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Any Value
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
	public Capability()
	{
	}

	[DebuggerNonUserCode]
	public Capability(Capability other)
		: this()
	{
		name_ = other.name_;
		Value = ((other.value_ != null) ? other.Value.Clone() : null);
	}

	[DebuggerNonUserCode]
	public Capability Clone()
	{
		return new Capability(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Capability);
	}

	[DebuggerNonUserCode]
	public bool Equals(Capability other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag((byte)10);
			output.WriteString(Name);
		}
		if (value_ != null)
		{
			output.WriteRawTag((byte)18);
			output.WriteMessage((IMessage)(object)Value);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Value);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Capability other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				value_ = new Any();
			}
			Value.MergeFrom(other.Value);
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
				input.SkipLastField();
				break;
			case 18u:
				if (value_ == null)
				{
					value_ = new Any();
				}
				input.ReadMessage((IMessage)(object)value_);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
