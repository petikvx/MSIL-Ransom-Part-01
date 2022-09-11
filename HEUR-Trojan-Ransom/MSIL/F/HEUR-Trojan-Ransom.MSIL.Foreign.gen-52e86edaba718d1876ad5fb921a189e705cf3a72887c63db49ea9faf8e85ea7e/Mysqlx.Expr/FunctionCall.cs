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
using ns15;

namespace Mysqlx.Expr;

internal sealed class FunctionCall : IMessage, IMessage<FunctionCall>, IEquatable<FunctionCall>, IDeepCloneable<FunctionCall>
{
	private static readonly MessageParser<FunctionCall> messageParser_0;

	public const int int_0 = 1;

	private Identifier identifier_0;

	public const int int_1 = 2;

	private static readonly FieldCodec<Expr> fieldCodec_0;

	private readonly RepeatedField<Expr> repeatedField_0 = new RepeatedField<Expr>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<FunctionCall> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class26.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Identifier Name
	{
		get
		{
			return identifier_0;
		}
		set
		{
			identifier_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Expr> Param => repeatedField_0;

	[DebuggerNonUserCode]
	public FunctionCall()
	{
	}

	[DebuggerNonUserCode]
	public FunctionCall(FunctionCall other)
		: this()
	{
		Name = ((other.identifier_0 != null) ? other.Name.Clone() : null);
		repeatedField_0 = other.repeatedField_0.Clone();
	}

	[DebuggerNonUserCode]
	public FunctionCall Clone()
	{
		return new FunctionCall(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<FunctionCall>)this).Equals(obj as FunctionCall);
	}

	[DebuggerNonUserCode]
	bool IEquatable<FunctionCall>.Equals(FunctionCall other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Name, other.Name))
		{
			return false;
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
		int num = 1;
		if (identifier_0 != null)
		{
			num ^= Name.GetHashCode();
		}
		return num ^ repeatedField_0.GetHashCode();
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (identifier_0 != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Name);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (identifier_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Name);
		}
		return num + repeatedField_0.CalculateSize(fieldCodec_0);
	}

	[DebuggerNonUserCode]
	public void MergeFrom(FunctionCall other)
	{
		if (other == null)
		{
			return;
		}
		if (other.identifier_0 != null)
		{
			if (identifier_0 == null)
			{
				identifier_0 = new Identifier();
			}
			Name.MergeFrom(other.Name);
		}
		repeatedField_0.Add(other.repeatedField_0);
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
				input.SkipLastField();
				break;
			case 18u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 10u:
				if (identifier_0 == null)
				{
					identifier_0 = new Identifier();
				}
				input.ReadMessage(identifier_0);
				break;
			}
		}
	}

	static FunctionCall()
	{
		Strings.CreateGetStringDelegate(typeof(FunctionCall));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397217), getString_0(107397212)).Replace(getString_0(107397175), getString_0(107397170)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397165)))
		{
			throw new SecurityException(getString_0(107397140));
		}
		messageParser_0 = new MessageParser<FunctionCall>(() => new FunctionCall());
		fieldCodec_0 = FieldCodec.ForMessage(18u, Expr.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
