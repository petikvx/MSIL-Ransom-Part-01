using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Connection;

internal sealed class Compression : IMessage<Compression>, IEquatable<Compression>, IDeepCloneable<Compression>, IMessage
{
	private static readonly MessageParser<Compression> _parser = new MessageParser<Compression>(() => new Compression());

	public const int UncompressedSizeFieldNumber = 1;

	private ulong uncompressedSize_;

	public const int ServerMessagesFieldNumber = 2;

	private ServerMessages.Types.Type serverMessages_;

	public const int ClientMessagesFieldNumber = 3;

	private ClientMessages.Types.Type clientMessages_;

	public const int PayloadFieldNumber = 4;

	private ByteString payload_ = ByteString.Empty;

	[DebuggerNonUserCode]
	public static MessageParser<Compression> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxConnectionReflection.Descriptor.MessageTypes[5];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ulong UncompressedSize
	{
		get
		{
			return uncompressedSize_;
		}
		set
		{
			uncompressedSize_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ServerMessages.Types.Type ServerMessages
	{
		get
		{
			return serverMessages_;
		}
		set
		{
			serverMessages_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ClientMessages.Types.Type ClientMessages
	{
		get
		{
			return clientMessages_;
		}
		set
		{
			clientMessages_ = value;
		}
	}

	[DebuggerNonUserCode]
	public ByteString Payload
	{
		get
		{
			return payload_;
		}
		set
		{
			payload_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Compression()
	{
	}

	[DebuggerNonUserCode]
	public Compression(Compression other)
		: this()
	{
		uncompressedSize_ = other.uncompressedSize_;
		serverMessages_ = other.serverMessages_;
		clientMessages_ = other.clientMessages_;
		payload_ = other.payload_;
	}

	[DebuggerNonUserCode]
	public Compression Clone()
	{
		return new Compression(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Compression);
	}

	[DebuggerNonUserCode]
	public bool Equals(Compression other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UncompressedSize != other.UncompressedSize)
		{
			return false;
		}
		if (ServerMessages != other.ServerMessages)
		{
			return false;
		}
		if (ClientMessages != other.ClientMessages)
		{
			return false;
		}
		if (Payload != other.Payload)
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (UncompressedSize != 0L)
		{
			num ^= UncompressedSize.GetHashCode();
		}
		if (ServerMessages != 0)
		{
			num ^= ServerMessages.GetHashCode();
		}
		if (ClientMessages != 0)
		{
			num ^= ClientMessages.GetHashCode();
		}
		if (Payload.Length != 0)
		{
			num ^= Payload.GetHashCode();
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
		if (UncompressedSize != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(UncompressedSize);
		}
		if (ServerMessages != 0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ServerMessages);
		}
		if (ClientMessages != 0)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ClientMessages);
		}
		if (Payload.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(Payload);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (UncompressedSize != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(UncompressedSize);
		}
		if (ServerMessages != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ServerMessages);
		}
		if (ClientMessages != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ClientMessages);
		}
		if (Payload.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Payload);
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Compression other)
	{
		if (other != null)
		{
			if (other.UncompressedSize != 0L)
			{
				UncompressedSize = other.UncompressedSize;
			}
			if (other.ServerMessages != 0)
			{
				ServerMessages = other.ServerMessages;
			}
			if (other.ClientMessages != 0)
			{
				ClientMessages = other.ClientMessages;
			}
			if (other.Payload.Length != 0)
			{
				Payload = other.Payload;
			}
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
			case 16u:
				serverMessages_ = (ServerMessages.Types.Type)input.ReadEnum();
				break;
			case 8u:
				UncompressedSize = input.ReadUInt64();
				break;
			default:
				input.SkipLastField();
				break;
			case 34u:
				Payload = input.ReadBytes();
				break;
			case 24u:
				clientMessages_ = (ClientMessages.Types.Type)input.ReadEnum();
				break;
			}
		}
	}
}
