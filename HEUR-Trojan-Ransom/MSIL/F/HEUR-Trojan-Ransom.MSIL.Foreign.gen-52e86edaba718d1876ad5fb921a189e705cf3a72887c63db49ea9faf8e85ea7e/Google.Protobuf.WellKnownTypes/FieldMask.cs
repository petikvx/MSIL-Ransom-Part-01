using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public sealed class FieldMask : IMessage, IMessage<FieldMask>, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, ICustomDiagnosticMessage
{
	private static readonly MessageParser<FieldMask> _parser;

	private UnknownFieldSet _unknownFields;

	public const int PathsFieldNumber = 1;

	private static readonly FieldCodec<string> _repeated_paths_codec;

	private readonly RepeatedField<string> paths_ = new RepeatedField<string>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<FieldMask> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldMaskReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<string> Paths => paths_;

	[DebuggerNonUserCode]
	public FieldMask()
	{
	}

	[DebuggerNonUserCode]
	public FieldMask(FieldMask other)
		: this()
	{
		paths_ = other.paths_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public FieldMask Clone()
	{
		return new FieldMask(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMask);
	}

	[DebuggerNonUserCode]
	public bool Equals(FieldMask other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!paths_.Equals(other.paths_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ paths_.GetHashCode();
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
		paths_.WriteTo(output, _repeated_paths_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + paths_.CalculateSize(_repeated_paths_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FieldMask other)
	{
		if (other != null)
		{
			paths_.Add(other.paths_);
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
				paths_.AddEntriesFrom(input, _repeated_paths_codec);
			}
		}
	}

	internal static string ToJson(IList<string> paths, bool diagnosticOnly)
	{
		string text = paths.FirstOrDefault((string p) => !ValidatePath(p));
		if (text == null)
		{
			StringWriter stringWriter = new StringWriter();
			JsonFormatter.WriteString(stringWriter, string.Join(getString_0(107406744), paths.Select(JsonFormatter.ToJsonName)));
			return stringWriter.ToString();
		}
		if (!diagnosticOnly)
		{
			throw new InvalidOperationException(string.Format(getString_0(107459504), text));
		}
		StringWriter stringWriter2 = new StringWriter();
		stringWriter2.Write(getString_0(107459565));
		JsonFormatter.Default.WriteList(stringWriter2, (IList)paths);
		stringWriter2.Write(getString_0(107367819));
		return stringWriter2.ToString();
	}

	private static bool ValidatePath(string input)
	{
		int num = 0;
		while (true)
		{
			if (num < input.Length)
			{
				char c = input[num];
				if (c < 'A' || c > 'Z')
				{
					if (c == '_' && num < input.Length - 1)
					{
						char c2 = input[num + 1];
						if (c2 < 'a' || c2 > 'z')
						{
							break;
						}
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public string ToDiagnosticString()
	{
		return ToJson(Paths, diagnosticOnly: true);
	}

	static FieldMask()
	{
		Strings.CreateGetStringDelegate(typeof(FieldMask));
		_parser = new MessageParser<FieldMask>(() => new FieldMask());
		_repeated_paths_codec = FieldCodec.ForString(10u);
	}
}
