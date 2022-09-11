using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace Mysqlx.Resultset;

internal sealed class Row : IMessage, IMessage<Row>, IEquatable<Row>, IDeepCloneable<Row>
{
	private static readonly MessageParser<Row> messageParser_0;

	public const int int_0 = 1;

	private static readonly FieldCodec<ByteString> fieldCodec_0;

	private readonly RepeatedField<ByteString> repeatedField_0 = new RepeatedField<ByteString>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Row> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class21.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<ByteString> Field => repeatedField_0;

	[DebuggerNonUserCode]
	public Row()
	{
	}

	[DebuggerNonUserCode]
	public Row(Row other)
		: this()
	{
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public Row Clone()
	{
		return new Row(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Row>)this).Equals(obj as Row);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Row>.Equals(Row other)
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
	public void MergeFrom(Row other)
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

	static Row()
	{
		Strings.CreateGetStringDelegate(typeof(Row));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397074), getString_0(107397069)).Replace(getString_0(107397032), getString_0(107397027)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397022)))
		{
			throw new SecurityException(getString_0(107396997));
		}
		messageParser_0 = new MessageParser<Row>(() => new Row());
		fieldCodec_0 = FieldCodec.ForBytes(10u);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
