using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Connection;

internal sealed class CapabilitiesSet : IMessage<CapabilitiesSet>, IEquatable<CapabilitiesSet>, IDeepCloneable<CapabilitiesSet>, IMessage
{
	private static readonly MessageParser<CapabilitiesSet> _parser = new MessageParser<CapabilitiesSet>((Func<CapabilitiesSet>)(() => new CapabilitiesSet()));

	public const int CapabilitiesFieldNumber = 1;

	private Capabilities capabilities_;

	[DebuggerNonUserCode]
	public static MessageParser<CapabilitiesSet> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.get_MessageTypes()[3];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Capabilities Capabilities
	{
		get
		{
			return capabilities_;
		}
		set
		{
			capabilities_ = value;
		}
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet()
	{
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet(CapabilitiesSet other)
		: this()
	{
		Capabilities = ((other.capabilities_ != null) ? other.Capabilities.Clone() : null);
	}

	[DebuggerNonUserCode]
	public CapabilitiesSet Clone()
	{
		return new CapabilitiesSet(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CapabilitiesSet);
	}

	[DebuggerNonUserCode]
	public bool Equals(CapabilitiesSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Capabilities, other.Capabilities))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (capabilities_ != null)
		{
			num ^= Capabilities.GetHashCode();
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
		if (capabilities_ != null)
		{
			output.WriteRawTag((byte)10);
			output.WriteMessage((IMessage)(object)Capabilities);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (capabilities_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize((IMessage)(object)Capabilities);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(CapabilitiesSet other)
	{
		if (other != null && other.capabilities_ != null)
		{
			if (capabilities_ == null)
			{
				capabilities_ = new Capabilities();
			}
			Capabilities.MergeFrom(other.Capabilities);
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
				input.SkipLastField();
				continue;
			}
			if (capabilities_ == null)
			{
				capabilities_ = new Capabilities();
			}
			input.ReadMessage((IMessage)(object)capabilities_);
		}
	}
}
