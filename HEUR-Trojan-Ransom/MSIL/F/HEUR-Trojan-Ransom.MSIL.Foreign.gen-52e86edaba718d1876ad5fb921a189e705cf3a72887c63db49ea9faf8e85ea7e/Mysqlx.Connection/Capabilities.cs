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
using ns14;

namespace Mysqlx.Connection;

internal sealed class Capabilities : IMessage, IMessage<Capabilities>, IEquatable<Capabilities>, IDeepCloneable<Capabilities>
{
	private static readonly MessageParser<Capabilities> messageParser_0;

	public const int int_0 = 1;

	private static readonly FieldCodec<Capability> fieldCodec_0;

	private readonly RepeatedField<Capability> repeatedField_0 = new RepeatedField<Capability>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Capabilities> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class36.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Capability> Capabilities_ => repeatedField_0;

	[DebuggerNonUserCode]
	public Capabilities()
	{
	}

	[DebuggerNonUserCode]
	public Capabilities(Capabilities other)
		: this()
	{
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public Capabilities Clone()
	{
		return new Capabilities(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<Capabilities>)this).Equals(obj as Capabilities);
	}

	[DebuggerNonUserCode]
	bool IEquatable<Capabilities>.Equals(Capabilities other)
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
	public void MergeFrom(Capabilities other)
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

	static Capabilities()
	{
		Strings.CreateGetStringDelegate(typeof(Capabilities));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397612), getString_0(107397607)).Replace(getString_0(107397570), getString_0(107397565)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397560)))
		{
			throw new SecurityException(getString_0(107397535));
		}
		messageParser_0 = new MessageParser<Capabilities>(() => new Capabilities());
		fieldCodec_0 = FieldCodec.ForMessage(10u, Capability.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
