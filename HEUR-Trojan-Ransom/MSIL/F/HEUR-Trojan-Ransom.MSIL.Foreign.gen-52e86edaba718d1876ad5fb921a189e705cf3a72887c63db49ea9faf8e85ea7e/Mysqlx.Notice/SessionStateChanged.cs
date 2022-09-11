using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace Mysqlx.Notice;

internal sealed class SessionStateChanged : IMessage, IMessage<SessionStateChanged>, IEquatable<SessionStateChanged>, IDeepCloneable<SessionStateChanged>
{
	[DebuggerNonUserCode]
	internal static class Class25
	{
		public enum Enum8
		{
			[OriginalName("NONE")]
			const_0 = 0,
			[OriginalName("CURRENT_SCHEMA")]
			const_1 = 1,
			[OriginalName("ACCOUNT_EXPIRED")]
			const_2 = 2,
			[OriginalName("GENERATED_INSERT_ID")]
			const_3 = 3,
			[OriginalName("ROWS_AFFECTED")]
			const_4 = 4,
			[OriginalName("ROWS_FOUND")]
			const_5 = 5,
			[OriginalName("ROWS_MATCHED")]
			const_6 = 6,
			[OriginalName("TRX_COMMITTED")]
			const_7 = 7,
			[OriginalName("TRX_ROLLEDBACK")]
			const_8 = 9,
			[OriginalName("PRODUCED_MESSAGE")]
			const_9 = 10,
			[OriginalName("CLIENT_ID_ASSIGNED")]
			const_10 = 11,
			[OriginalName("GENERATED_DOCUMENT_IDS")]
			const_11 = 12
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Class25()
		{
			Strings.CreateGetStringDelegate(typeof(Class25));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397127), getString_0(107397122)).Replace(getString_0(107397085), getString_0(107397080)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397075)))
			{
				throw new SecurityException(getString_0(107397050));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<SessionStateChanged> messageParser_0 = new MessageParser<SessionStateChanged>(() => new SessionStateChanged());

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private Class25.Enum8 enum8_0;

	public const int int_1 = 2;

	private static readonly FieldCodec<Scalar> fieldCodec_0 = FieldCodec.ForMessage(18u, Scalar.Parser);

	private readonly RepeatedField<Scalar> repeatedField_0 = new RepeatedField<Scalar>();

	[DebuggerNonUserCode]
	public static MessageParser<SessionStateChanged> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class22.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public Class25.Enum8 Param
	{
		get
		{
			return enum8_0;
		}
		set
		{
			enum8_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<Scalar> Value => repeatedField_0;

	[DebuggerNonUserCode]
	public SessionStateChanged()
	{
	}

	[DebuggerNonUserCode]
	public SessionStateChanged(SessionStateChanged other)
		: this()
	{
		enum8_0 = other.enum8_0;
		repeatedField_0 = other.repeatedField_0.Clone();
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public SessionStateChanged Clone()
	{
		return new SessionStateChanged(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<SessionStateChanged>)this).Equals(obj as SessionStateChanged);
	}

	[DebuggerNonUserCode]
	bool IEquatable<SessionStateChanged>.Equals(SessionStateChanged other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Param != other.Param)
		{
			return false;
		}
		if (!repeatedField_0.Equals(other.repeatedField_0))
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Param != 0)
		{
			num ^= Param.GetHashCode();
		}
		num ^= repeatedField_0.GetHashCode();
		if (unknownFieldSet_0 != null)
		{
			num ^= unknownFieldSet_0.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	string object.ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		if (Param != 0)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Param);
		}
		repeatedField_0.WriteTo(output, fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Param != 0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Param);
		}
		num += repeatedField_0.CalculateSize(fieldCodec_0);
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SessionStateChanged other)
	{
		if (other != null)
		{
			if (other.Param != 0)
			{
				Param = other.Param;
			}
			repeatedField_0.Add(other.repeatedField_0);
			unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
				unknownFieldSet_0 = UnknownFieldSet.MergeFieldFrom(unknownFieldSet_0, input);
				break;
			case 18u:
				repeatedField_0.AddEntriesFrom(input, fieldCodec_0);
				break;
			case 8u:
				enum8_0 = (Class25.Enum8)input.ReadEnum();
				break;
			}
		}
	}
}
