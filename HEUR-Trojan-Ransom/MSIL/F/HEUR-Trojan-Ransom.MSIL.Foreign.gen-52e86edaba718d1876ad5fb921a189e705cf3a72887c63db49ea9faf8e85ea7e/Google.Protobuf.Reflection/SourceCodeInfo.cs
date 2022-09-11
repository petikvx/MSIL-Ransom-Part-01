using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Collections;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class SourceCodeInfo : IMessage, IMessage<SourceCodeInfo>, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
{
	[DebuggerNonUserCode]
	public static class Types
	{
		internal sealed class Location : IMessage, IMessage<Location>, IEquatable<Location>, IDeepCloneable<Location>
		{
			private static readonly MessageParser<Location> _parser;

			private UnknownFieldSet _unknownFields;

			public const int PathFieldNumber = 1;

			private static readonly FieldCodec<int> _repeated_path_codec;

			private readonly RepeatedField<int> path_ = new RepeatedField<int>();

			public const int SpanFieldNumber = 2;

			private static readonly FieldCodec<int> _repeated_span_codec;

			private readonly RepeatedField<int> span_ = new RepeatedField<int>();

			public const int LeadingCommentsFieldNumber = 3;

			private string leadingComments_ = getString_0(107400409);

			public const int TrailingCommentsFieldNumber = 4;

			private string trailingComments_ = getString_0(107400409);

			public const int LeadingDetachedCommentsFieldNumber = 6;

			private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

			private readonly RepeatedField<string> leadingDetachedComments_ = new RepeatedField<string>();

			[NonSerialized]
			internal static GetString getString_0;

			[DebuggerNonUserCode]
			public static MessageParser<Location> Parser => _parser;

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor => SourceCodeInfo.Descriptor.NestedTypes[0];

			[DebuggerNonUserCode]
			MessageDescriptor IMessage.Descriptor => Descriptor;

			[DebuggerNonUserCode]
			public RepeatedField<int> Path => path_;

			[DebuggerNonUserCode]
			public RepeatedField<int> Span => span_;

			[DebuggerNonUserCode]
			public string LeadingComments
			{
				get
				{
					return leadingComments_;
				}
				set
				{
					leadingComments_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395362));
				}
			}

			[DebuggerNonUserCode]
			public string TrailingComments
			{
				get
				{
					return trailingComments_;
				}
				set
				{
					trailingComments_ = ProtoPreconditions.CheckNotNull(value, getString_0(107395362));
				}
			}

			[DebuggerNonUserCode]
			public RepeatedField<string> LeadingDetachedComments => leadingDetachedComments_;

			[DebuggerNonUserCode]
			public Location()
			{
			}

			[DebuggerNonUserCode]
			public Location(Location other)
				: this()
			{
				path_ = other.path_.Clone();
				span_ = other.span_.Clone();
				leadingComments_ = other.leadingComments_;
				trailingComments_ = other.trailingComments_;
				leadingDetachedComments_ = other.leadingDetachedComments_.Clone();
				_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			}

			[DebuggerNonUserCode]
			public Location Clone()
			{
				return new Location(this);
			}

			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return Equals(other as Location);
			}

			[DebuggerNonUserCode]
			public bool Equals(Location other)
			{
				if (other == null)
				{
					return false;
				}
				if (other == this)
				{
					return true;
				}
				if (!path_.Equals(other.path_))
				{
					return false;
				}
				if (!span_.Equals(other.span_))
				{
					return false;
				}
				if (LeadingComments != other.LeadingComments)
				{
					return false;
				}
				if (TrailingComments != other.TrailingComments)
				{
					return false;
				}
				if (!leadingDetachedComments_.Equals(other.leadingDetachedComments_))
				{
					return false;
				}
				return object.Equals(_unknownFields, other._unknownFields);
			}

			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				int num = 1;
				num = 1 ^ path_.GetHashCode();
				num ^= span_.GetHashCode();
				if (LeadingComments.Length != 0)
				{
					num ^= LeadingComments.GetHashCode();
				}
				if (TrailingComments.Length != 0)
				{
					num ^= TrailingComments.GetHashCode();
				}
				num ^= leadingDetachedComments_.GetHashCode();
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
				path_.WriteTo(output, _repeated_path_codec);
				span_.WriteTo(output, _repeated_span_codec);
				if (LeadingComments.Length != 0)
				{
					output.WriteRawTag(26);
					output.WriteString(LeadingComments);
				}
				if (TrailingComments.Length != 0)
				{
					output.WriteRawTag(34);
					output.WriteString(TrailingComments);
				}
				leadingDetachedComments_.WriteTo(output, _repeated_leadingDetachedComments_codec);
				if (_unknownFields != null)
				{
					_unknownFields.WriteTo(output);
				}
			}

			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				int num = 0;
				num = 0 + path_.CalculateSize(_repeated_path_codec);
				num += span_.CalculateSize(_repeated_span_codec);
				if (LeadingComments.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(LeadingComments);
				}
				if (TrailingComments.Length != 0)
				{
					num += 1 + CodedOutputStream.ComputeStringSize(TrailingComments);
				}
				num += leadingDetachedComments_.CalculateSize(_repeated_leadingDetachedComments_codec);
				if (_unknownFields != null)
				{
					num += _unknownFields.CalculateSize();
				}
				return num;
			}

			[DebuggerNonUserCode]
			public void MergeFrom(Location other)
			{
				if (other != null)
				{
					path_.Add(other.path_);
					span_.Add(other.span_);
					if (other.LeadingComments.Length != 0)
					{
						LeadingComments = other.LeadingComments;
					}
					if (other.TrailingComments.Length != 0)
					{
						TrailingComments = other.TrailingComments;
					}
					leadingDetachedComments_.Add(other.leadingDetachedComments_);
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
					case 8u:
					case 10u:
						path_.AddEntriesFrom(input, _repeated_path_codec);
						break;
					case 26u:
						LeadingComments = input.ReadString();
						break;
					case 16u:
					case 18u:
						span_.AddEntriesFrom(input, _repeated_span_codec);
						break;
					default:
						_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
						break;
					case 50u:
						leadingDetachedComments_.AddEntriesFrom(input, _repeated_leadingDetachedComments_codec);
						break;
					case 34u:
						TrailingComments = input.ReadString();
						break;
					}
				}
			}

			static Location()
			{
				Strings.CreateGetStringDelegate(typeof(Location));
				_parser = new MessageParser<Location>(() => new Location());
				_repeated_path_codec = FieldCodec.ForInt32(10u);
				_repeated_span_codec = FieldCodec.ForInt32(18u);
				_repeated_leadingDetachedComments_codec = FieldCodec.ForString(50u);
			}
		}

		[NonSerialized]
		internal static GetString getString_0;

		static Types()
		{
			Strings.CreateGetStringDelegate(typeof(Types));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400571), getString_0(107400566)).Replace(getString_0(107400529), getString_0(107400524)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400519)))
			{
				throw new SecurityException(getString_0(107400494));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	private static readonly MessageParser<SourceCodeInfo> _parser;

	private UnknownFieldSet _unknownFields;

	public const int LocationFieldNumber = 1;

	private static readonly FieldCodec<Types.Location> _repeated_location_codec;

	private readonly RepeatedField<Types.Location> location_ = new RepeatedField<Types.Location>();

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<SourceCodeInfo> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DescriptorReflection.Descriptor.MessageTypes[19];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public RepeatedField<Types.Location> Location => location_;

	[DebuggerNonUserCode]
	public SourceCodeInfo()
	{
	}

	[DebuggerNonUserCode]
	public SourceCodeInfo(SourceCodeInfo other)
		: this()
	{
		location_ = other.location_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public SourceCodeInfo Clone()
	{
		return new SourceCodeInfo(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SourceCodeInfo);
	}

	[DebuggerNonUserCode]
	public bool Equals(SourceCodeInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!location_.Equals(other.location_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		num = 1 ^ location_.GetHashCode();
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
		location_.WriteTo(output, _repeated_location_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		num = 0 + location_.CalculateSize(_repeated_location_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(SourceCodeInfo other)
	{
		if (other != null)
		{
			location_.Add(other.location_);
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
				location_.AddEntriesFrom(input, _repeated_location_codec);
			}
		}
	}

	static SourceCodeInfo()
	{
		Strings.CreateGetStringDelegate(typeof(SourceCodeInfo));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107400570), getString_0(107400565)).Replace(getString_0(107400528), getString_0(107400523)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107400518)))
		{
			throw new SecurityException(getString_0(107400493));
		}
		_parser = new MessageParser<SourceCodeInfo>(() => new SourceCodeInfo());
		_repeated_location_codec = FieldCodec.ForMessage(10u, Types.Location.Parser);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
