using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Mysqlx.Session;

internal sealed class AuthenticateOk : IMessage<AuthenticateOk>, IEquatable<AuthenticateOk>, IDeepCloneable<AuthenticateOk>, IMessage
{
	private static readonly MessageParser<AuthenticateOk> _parser = new MessageParser<AuthenticateOk>(() => new AuthenticateOk());

	private UnknownFieldSet _unknownFields;

	public const int AuthDataFieldNumber = 1;

	private ByteString authData_ = ByteString.Empty;

	[DebuggerNonUserCode]
	public static MessageParser<AuthenticateOk> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxSessionReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public ByteString AuthData
	{
		get
		{
			return authData_;
		}
		set
		{
			authData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public AuthenticateOk()
	{
	}

	[DebuggerNonUserCode]
	public AuthenticateOk(AuthenticateOk other)
		: this()
	{
		authData_ = other.authData_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public AuthenticateOk Clone()
	{
		return new AuthenticateOk(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AuthenticateOk);
	}

	[DebuggerNonUserCode]
	public bool Equals(AuthenticateOk other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AuthData != other.AuthData)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (AuthData.Length != 0)
		{
			num ^= AuthData.GetHashCode();
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
		if (AuthData.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(AuthData);
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
		if (AuthData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AuthData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(AuthenticateOk other)
	{
		if (other != null)
		{
			if (other.AuthData.Length != 0)
			{
				AuthData = other.AuthData;
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				AuthData = input.ReadBytes();
			}
		}
	}
}
