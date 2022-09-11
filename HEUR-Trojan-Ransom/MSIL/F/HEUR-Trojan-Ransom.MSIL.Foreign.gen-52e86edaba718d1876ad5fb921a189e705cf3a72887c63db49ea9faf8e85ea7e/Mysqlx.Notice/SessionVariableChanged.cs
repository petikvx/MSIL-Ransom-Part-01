using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Mysqlx.Datatypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;

namespace Mysqlx.Notice;

internal sealed class SessionVariableChanged : IMessage, IMessage<SessionVariableChanged>, IEquatable<SessionVariableChanged>, IDeepCloneable<SessionVariableChanged>
{
	private static readonly MessageParser<SessionVariableChanged> messageParser_0;

	private UnknownFieldSet unknownFieldSet_0;

	public const int int_0 = 1;

	private string string_0 = getString_0(107396940);

	public const int int_1 = 2;

	private Scalar scalar_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<SessionVariableChanged> Parser => messageParser_0;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => Class22.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public string Param
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = ProtoPreconditions.CheckNotNull(value, getString_0(107391893));
		}
	}

	[DebuggerNonUserCode]
	public Scalar Value
	{
		get
		{
			return scalar_0;
		}
		set
		{
			scalar_0 = value;
		}
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged()
	{
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged(SessionVariableChanged other)
		: this()
	{
		string_0 = other.string_0;
		Value = ((other.scalar_0 != null) ? other.Value.Clone() : null);
		unknownFieldSet_0 = UnknownFieldSet.Clone(other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	public SessionVariableChanged Clone()
	{
		return new SessionVariableChanged(this);
	}

	[DebuggerNonUserCode]
	bool object.Equals(object obj)
	{
		return ((IEquatable<SessionVariableChanged>)this).Equals(obj as SessionVariableChanged);
	}

	[DebuggerNonUserCode]
	bool IEquatable<SessionVariableChanged>.Equals(SessionVariableChanged other)
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
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(unknownFieldSet_0, other.unknownFieldSet_0);
	}

	[DebuggerNonUserCode]
	int object.GetHashCode()
	{
		int num = 1;
		if (Param.Length != 0)
		{
			num ^= Param.GetHashCode();
		}
		if (scalar_0 != null)
		{
			num ^= Value.GetHashCode();
		}
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
		if (Param.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Param);
		}
		if (scalar_0 != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Value);
		}
		if (unknownFieldSet_0 != null)
		{
			unknownFieldSet_0.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Param.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Param);
		}
		if (scalar_0 != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (unknownFieldSet_0 != null)
		{
			num += unknownFieldSet_0.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SessionVariableChanged other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Param.Length != 0)
		{
			Param = other.Param;
		}
		if (other.scalar_0 != null)
		{
			if (scalar_0 == null)
			{
				scalar_0 = new Scalar();
			}
			Value.MergeFrom(other.Value);
		}
		unknownFieldSet_0 = UnknownFieldSet.MergeFrom(unknownFieldSet_0, other.unknownFieldSet_0);
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
				if (scalar_0 == null)
				{
					scalar_0 = new Scalar();
				}
				input.ReadMessage(scalar_0);
				break;
			case 10u:
				Param = input.ReadString();
				break;
			}
		}
	}

	static SessionVariableChanged()
	{
		Strings.CreateGetStringDelegate(typeof(SessionVariableChanged));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397118), getString_0(107397113)).Replace(getString_0(107397076), getString_0(107397071)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397066)))
		{
			throw new SecurityException(getString_0(107397041));
		}
		messageParser_0 = new MessageParser<SessionVariableChanged>(() => new SessionVariableChanged());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
