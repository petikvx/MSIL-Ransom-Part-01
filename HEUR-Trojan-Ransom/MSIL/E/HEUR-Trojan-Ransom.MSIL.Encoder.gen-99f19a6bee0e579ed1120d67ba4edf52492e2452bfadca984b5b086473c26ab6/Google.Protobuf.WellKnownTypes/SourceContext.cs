using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class SourceContext : IMessage<SourceContext>, IEquatable<SourceContext>, IDeepCloneable<SourceContext>, IMessage
{
	private static readonly MessageParser<SourceContext> _parser = new MessageParser<SourceContext>(() => new SourceContext());

	private UnknownFieldSet _unknownFields;

	public const int FileNameFieldNumber = 1;

	private string fileName_ = "";

	[DebuggerNonUserCode]
	public static MessageParser<SourceContext> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SourceContextReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string FileName
	{
		get
		{
			return fileName_;
		}
		set
		{
			fileName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	public SourceContext()
	{
	}

	[DebuggerNonUserCode]
	public SourceContext(SourceContext other)
		: this()
	{
		fileName_ = other.fileName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public SourceContext Clone()
	{
		return new SourceContext(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SourceContext);
	}

	[DebuggerNonUserCode]
	public bool Equals(SourceContext other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FileName != other.FileName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (FileName.Length != 0)
		{
			num ^= FileName.GetHashCode();
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
		if (FileName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(FileName);
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
		if (FileName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FileName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SourceContext other)
	{
		if (other != null)
		{
			if (other.FileName.Length != 0)
			{
				FileName = other.FileName;
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
				FileName = input.ReadString();
			}
		}
	}
}
