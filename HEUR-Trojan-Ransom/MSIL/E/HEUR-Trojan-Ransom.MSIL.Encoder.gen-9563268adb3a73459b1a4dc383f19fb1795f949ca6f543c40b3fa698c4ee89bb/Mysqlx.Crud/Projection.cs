using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Expr;

namespace Mysqlx.Crud;

internal sealed class Projection : IMessage<Projection>, IEquatable<Projection>, IDeepCloneable<Projection>, IMessage
{
	private static readonly MessageParser<Projection> _parser = new MessageParser<Projection>(() => new Projection());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 1;

	private Mysqlx.Expr.Expr source_;

	public const int AliasFieldNumber = 2;

	private string alias_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<Projection> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MysqlxCrudReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Mysqlx.Expr.Expr Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	public string Alias
	{
		get
		{
			return alias_;
		}
		set
		{
			alias_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public Projection()
	{
	}

	[DebuggerNonUserCode]
	public Projection(Projection other)
		: this()
	{
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		alias_ = other.alias_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Projection Clone()
	{
		return new Projection(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Projection);
	}

	[DebuggerNonUserCode]
	public bool Equals(Projection other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (Alias != other.Alias)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (Alias.Length != 0)
		{
			num ^= Alias.GetHashCode();
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
		if (source_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Source);
		}
		if (Alias.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Alias);
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
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (Alias.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Alias);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Projection other)
	{
		if (other == null)
		{
			return;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				source_ = new Mysqlx.Expr.Expr();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.Alias.Length != 0)
		{
			Alias = other.Alias;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 18u:
				Alias = input.ReadString();
				break;
			case 10u:
				if (source_ == null)
				{
					source_ = new Mysqlx.Expr.Expr();
				}
				input.ReadMessage(source_);
				break;
			}
		}
	}
}
