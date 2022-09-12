using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection;

internal sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>, IMessage
{
	private static readonly MessageParser<FileDescriptorSet> _parser = new MessageParser<FileDescriptorSet>(() => new FileDescriptorSet());

	private UnknownFieldSet _unknownFields;

	public const int FileFieldNumber = 1;

	private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec = FieldCodec.ForMessage(10u, FileDescriptorProto.Parser);

	private readonly RepeatedField<FileDescriptorProto> file_ = new RepeatedField<FileDescriptorProto>();

	[DebuggerNonUserCode]
	public static MessageParser<FileDescriptorSet> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<FileDescriptorProto> File => file_;

	[DebuggerNonUserCode]
	public FileDescriptorSet()
	{
	}

	[DebuggerNonUserCode]
	public FileDescriptorSet(FileDescriptorSet other)
		: this()
	{
		file_ = other.file_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FileDescriptorSet Clone()
	{
		return new FileDescriptorSet(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FileDescriptorSet);
	}

	[DebuggerNonUserCode]
	public bool Equals(FileDescriptorSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!file_.Equals(other.file_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ file_.GetHashCode();
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
		file_.WriteTo(output, _repeated_file_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + file_.CalculateSize(_repeated_file_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FileDescriptorSet other)
	{
		if (other != null)
		{
			file_.Add(other.file_);
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
				file_.AddEntriesFrom(input, _repeated_file_codec);
			}
		}
	}
}
