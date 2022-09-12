using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Session;

internal sealed class AuthenticateStart : IMessage<AuthenticateStart>, IEquatable<AuthenticateStart>, IDeepCloneable<AuthenticateStart>, IMessage
{
	private static readonly MessageParser<AuthenticateStart> _parser = new MessageParser<AuthenticateStart>((Func<AuthenticateStart>)(() => new AuthenticateStart()));

	private UnknownFieldSet _unknownFields;

	public const int MechNameFieldNumber = 1;

	private string mechName_ = "";

	public const int AuthDataFieldNumber = 2;

	private ByteString authData_ = ByteString.get_Empty();

	public const int InitialResponseFieldNumber = 3;

	private ByteString initialResponse_ = ByteString.get_Empty();

	[DebuggerNonUserCode]
	public static MessageParser<AuthenticateStart> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxSessionReflection.Descriptor.get_MessageTypes()[0];

	[DebuggerNonUserCode]
	MessageDescriptor Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string MechName
	{
		get
		{
			return mechName_;
		}
		set
		{
			mechName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString AuthData
	{
		get
		{
			return authData_;
		}
		set
		{
			authData_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public ByteString InitialResponse
	{
		get
		{
			return initialResponse_;
		}
		set
		{
			initialResponse_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public AuthenticateStart()
	{
	}

	[DebuggerNonUserCode]
	public AuthenticateStart(AuthenticateStart other)
		: this()
	{
		mechName_ = other.mechName_;
		authData_ = other.authData_;
		initialResponse_ = other.initialResponse_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public AuthenticateStart Clone()
	{
		return new AuthenticateStart(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AuthenticateStart);
	}

	[DebuggerNonUserCode]
	public bool Equals(AuthenticateStart other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MechName != other.MechName)
		{
			return false;
		}
		if (AuthData != other.AuthData)
		{
			return false;
		}
		if (InitialResponse != other.InitialResponse)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (MechName.Length != 0)
		{
			num ^= MechName.GetHashCode();
		}
		if (AuthData.get_Length() != 0)
		{
			num ^= ((object)AuthData).GetHashCode();
		}
		if (InitialResponse.get_Length() != 0)
		{
			num ^= ((object)InitialResponse).GetHashCode();
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
		if (MechName.Length != 0)
		{
			output.WriteRawTag((byte)10);
			output.WriteString(MechName);
		}
		if (AuthData.get_Length() != 0)
		{
			output.WriteRawTag((byte)18);
			output.WriteBytes(AuthData);
		}
		if (InitialResponse.get_Length() != 0)
		{
			output.WriteRawTag((byte)26);
			output.WriteBytes(InitialResponse);
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
		if (MechName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MechName);
		}
		if (AuthData.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AuthData);
		}
		if (InitialResponse.get_Length() != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(InitialResponse);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(AuthenticateStart other)
	{
		if (other != null)
		{
			if (other.MechName.Length != 0)
			{
				MechName = other.MechName;
			}
			if (other.AuthData.get_Length() != 0)
			{
				AuthData = other.AuthData;
			}
			if (other.InitialResponse.get_Length() != 0)
			{
				InitialResponse = other.InitialResponse;
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
			case 26u:
				InitialResponse = input.ReadBytes();
				break;
			case 18u:
				AuthData = input.ReadBytes();
				break;
			case 10u:
				MechName = input.ReadString();
				break;
			}
		}
	}
}
