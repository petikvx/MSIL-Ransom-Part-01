using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using ns15;

namespace Mysqlx.Expr;

internal sealed class Array : IMessage, IMessage<Array>, IEquatable<Array>, IDeepCloneable<Array>
{
	private static readonly MessageParser<Array> messageParser_0 = new MessageParser<Array>(() => new Array());

	public const int int_0 = 1;

	private static readonly FieldCodec<Expr> fieldCodec_0 = FieldCodec.ForMessage(10u, Expr.Parser);

	private readonly RepeatedField<Expr> repeatedField_0 = new RepeatedField<Expr>();

	[DebuggerNonUserCode]
	public static MessageParser<Array> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[7];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Expr> Value => repeatedField_0;

	[DebuggerNonUserCode]
	public Array()
	{
	}

	[DebuggerNonUserCode]
	public Array(Array other)
		: this()
	{
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public Array Clone()
	{
		return new Array(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Array>)this).Equals(obj as Array);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Array>.Equals(Array other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return true;
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		return 1 ^ repeatedField_0.GetHashCode();
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		repeatedField_0.WriteTo(output, fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return 0 + repeatedField_0.CalculateSize(fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Array other)
	{
		if (other != null)
		{
			repeatedField_0.Add(other.repeatedField_0);
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
			}
			else
			{
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
			}
		}
	}
}
