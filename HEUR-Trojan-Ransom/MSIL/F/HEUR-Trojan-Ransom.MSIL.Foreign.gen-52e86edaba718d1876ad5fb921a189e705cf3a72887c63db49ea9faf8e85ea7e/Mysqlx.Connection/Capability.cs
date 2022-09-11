using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace Mysqlx.Connection;

internal sealed class Capability : IMessage, IMessage<Capability>, IEquatable<Capability>, IDeepCloneable<Capability>
{
	private static readonly MessageParser<Capability> messageParser_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107397428);

	public const int int_1 = 2;

	private Any any_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Capability> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class36.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107392381));
		}
	}

	[DebuggerNonUserCode]
	public Any Value
	{
		get
		{
			return any_0;
		}
		set
		{
			any_0 = value;
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
		string_0 = other.string_0;
		Value = ((other.any_0 != null) ? other.Value.Clone() : null);
	}

	[DebuggerNonUserCode]
	public Capability Clone()
	{
		return new Capability(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Capability>)this).Equals(obj as Capability);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Capability>.Equals(Capability other)
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
	int object.GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (any_0 != null)
		{
			num ^= Value.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (any_0 != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Value);
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
		if (any_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
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
		if (other.any_0 != null)
		{
			if (any_0 == null)
			{
				any_0 = new Any();
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
				if (any_0 == null)
				{
					any_0 = new Any();
				}
				input.ReadMessage(any_0);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			}
		}
	}

	static Capability()
	{
		Strings.CreateGetStringDelegate(typeof(Capability));
		messageParser_0 = new MessageParser<Capability>(() => new Capability());
	}
}
