using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Collections;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class MethodOptions : IMessage, IMessage<MethodOptions>, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>
{
	[DebuggerNonUserCode]
	public static class Types
	{
		internal enum IdempotencyLevel
		{
			[OriginalName("IDEMPOTENCY_UNKNOWN")]
			IdempotencyUnknown,
			[OriginalName("NO_SIDE_EFFECTS")]
			NoSideEffects,
			[OriginalName("IDEMPOTENT")]
			Idempotent
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Types()
		{
			Strings.CreateGetStringDelegate(typeof(Types));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400532), getString_0(107400527)).Replace(getString_0(107400490), getString_0(107400485)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400480)))
			{
				throw new SecurityException(getString_0(107400455));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<MethodOptions> _parser;

	private UnknownFieldSet _unknownFields;

	public const int DeprecatedFieldNumber = 33;

	private bool deprecated_;

	public const int IdempotencyLevelFieldNumber = 34;

	private Types.IdempotencyLevel idempotencyLevel_;

	public const int UninterpretedOptionFieldNumber = 999;

	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_ = new RepeatedField<UninterpretedOption>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<MethodOptions> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[17];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	internal CustomOptions CustomOptions { get; private set; } = CustomOptions.Empty;


	[DebuggerNonUserCode]
	public bool Deprecated
	{
		get
		{
			return deprecated_;
		}
		set
		{
			deprecated_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Types.IdempotencyLevel IdempotencyLevel
	{
		get
		{
			return idempotencyLevel_;
		}
		set
		{
			idempotencyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	public RepeatedField<UninterpretedOption> UninterpretedOption => uninterpretedOption_;

	[DebuggerNonUserCode]
	public MethodOptions()
	{
	}

	[DebuggerNonUserCode]
	public MethodOptions(MethodOptions other)
		: this()
	{
		deprecated_ = other.deprecated_;
		idempotencyLevel_ = other.idempotencyLevel_;
		uninterpretedOption_ = other.uninterpretedOption_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public MethodOptions Clone()
	{
		return new MethodOptions(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MethodOptions);
	}

	[DebuggerNonUserCode]
	public bool Equals(MethodOptions other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Deprecated != other.Deprecated)
		{
			return false;
		}
		if (IdempotencyLevel != other.IdempotencyLevel)
		{
			return false;
		}
		if (!uninterpretedOption_.Equals(other.uninterpretedOption_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Deprecated)
		{
			num ^= Deprecated.GetHashCode();
		}
		if (IdempotencyLevel != 0)
		{
			num ^= IdempotencyLevel.GetHashCode();
		}
		num ^= uninterpretedOption_.GetHashCode();
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
		if (Deprecated)
		{
			output.WriteRawTag(136, 2);
			output.WriteBool(Deprecated);
		}
		if (IdempotencyLevel != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteEnum((int)IdempotencyLevel);
		}
		uninterpretedOption_.WriteTo(output, _repeated_uninterpretedOption_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Deprecated)
		{
			num += 3;
		}
		if (IdempotencyLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IdempotencyLevel);
		}
		num += uninterpretedOption_.CalculateSize(_repeated_uninterpretedOption_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(MethodOptions other)
	{
		if (other != null)
		{
			if (other.Deprecated)
			{
				Deprecated = other.Deprecated;
			}
			if (other.IdempotencyLevel != 0)
			{
				IdempotencyLevel = other.IdempotencyLevel;
			}
			uninterpretedOption_.Add(other.uninterpretedOption_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				CustomOptions = CustomOptions.ReadOrSkipUnknownField(input);
				break;
			case 7994u:
				uninterpretedOption_.AddEntriesFrom(input, _repeated_uninterpretedOption_codec);
				break;
			case 272u:
				idempotencyLevel_ = (Types.IdempotencyLevel)input.ReadEnum();
				break;
			case 264u:
				Deprecated = input.ReadBool();
				break;
			}
		}
	}

	static MethodOptions()
	{
		Strings.CreateGetStringDelegate(typeof(MethodOptions));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400531), getString_0(107400526)).Replace(getString_0(107400489), getString_0(107400484)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400479)))
		{
			throw new SecurityException(getString_0(107400454));
		}
		_parser = new MessageParser<MethodOptions>(() => new MethodOptions());
		_repeated_uninterpretedOption_codec = FieldCodec.ForMessage(7994u, Google.Protobuf.Reflection.UninterpretedOption.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
