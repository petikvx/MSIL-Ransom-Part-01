using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Duration : IMessage, IMessage<Duration>, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
{
	private static readonly MessageParser<Duration> _parser;

	private UnknownFieldSet _unknownFields;

	public const int SecondsFieldNumber = 1;

	private long seconds_;

	public const int NanosFieldNumber = 2;

	private int nanos_;

	public const int NanosecondsPerSecond = 1000000000;

	public const int NanosecondsPerTick = 100;

	public const long MaxSeconds = 315576000000L;

	public const long MinSeconds = -315576000000L;

	internal const int MaxNanoseconds = 999999999;

	internal const int MinNanoseconds = -999999999;

	[NonSerialized]
	internal static GetString getString_0;

	[DebuggerNonUserCode]
	public static MessageParser<Duration> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DurationReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	public long Seconds
	{
		get
		{
			return seconds_;
		}
		set
		{
			seconds_ = value;
		}
	}

	[DebuggerNonUserCode]
	public int Nanos
	{
		get
		{
			return nanos_;
		}
		set
		{
			nanos_ = value;
		}
	}

	[DebuggerNonUserCode]
	public Duration()
	{
	}

	[DebuggerNonUserCode]
	public Duration(Duration other)
		: this()
	{
		seconds_ = other.seconds_;
		nanos_ = other.nanos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Duration Clone()
	{
		return new Duration(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Duration);
	}

	[DebuggerNonUserCode]
	public bool Equals(Duration other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Seconds != other.Seconds)
		{
			return false;
		}
		if (Nanos != other.Nanos)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Seconds != 0L)
		{
			num ^= Seconds.GetHashCode();
		}
		if (Nanos != 0)
		{
			num ^= Nanos.GetHashCode();
		}
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
		if (Seconds != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Seconds);
		}
		if (Nanos != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Nanos);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Seconds != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Seconds);
		}
		if (Nanos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Nanos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	public void MergeFrom(Duration other)
	{
		if (other != null)
		{
			if (other.Seconds != 0L)
			{
				Seconds = other.Seconds;
			}
			if (other.Nanos != 0)
			{
				Nanos = other.Nanos;
			}
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
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 16u:
				Nanos = input.ReadInt32();
				break;
			case 8u:
				Seconds = input.ReadInt64();
				break;
			}
		}
	}

	internal static bool IsNormalized(long seconds, int nanoseconds)
	{
		if (seconds >= -315576000000L && seconds <= 315576000000L && nanoseconds >= -999999999 && nanoseconds <= 999999999)
		{
			return Math.Sign(seconds) * Math.Sign(nanoseconds) != -1;
		}
		return false;
	}

	public TimeSpan ToTimeSpan()
	{
		if (!IsNormalized(Seconds, Nanos))
		{
			throw new InvalidOperationException(getString_0(107460442));
		}
		checked
		{
			return TimeSpan.FromTicks(Seconds * 10000000L + unchecked(Nanos / 100));
		}
	}

	public static Duration FromTimeSpan(TimeSpan timeSpan)
	{
		long ticks = timeSpan.Ticks;
		long seconds = ticks / 10000000L;
		checked
		{
			int nanos = (int)unchecked(ticks % 10000000L) * 100;
			return new Duration
			{
				Seconds = seconds,
				Nanos = nanos
			};
		}
	}

	public static Duration operator -(Duration value)
	{
		ProtoPreconditions.CheckNotNull(value, getString_0(107394705));
		return checked(Normalize(-value.Seconds, -value.Nanos));
	}

	public static Duration operator +(Duration lhs, Duration rhs)
	{
		ProtoPreconditions.CheckNotNull(lhs, getString_0(107459869));
		ProtoPreconditions.CheckNotNull(rhs, getString_0(107459864));
		return checked(Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
	}

	public static Duration operator -(Duration lhs, Duration rhs)
	{
		ProtoPreconditions.CheckNotNull(lhs, getString_0(107459869));
		ProtoPreconditions.CheckNotNull(rhs, getString_0(107459864));
		return checked(Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
	}

	internal static Duration Normalize(long seconds, int nanoseconds)
	{
		int num = nanoseconds / 1000000000;
		seconds += num;
		nanoseconds -= num * 1000000000;
		if (seconds < 0L && nanoseconds > 0)
		{
			seconds++;
			nanoseconds -= 1000000000;
		}
		else if (seconds > 0L && nanoseconds < 0)
		{
			seconds--;
			nanoseconds += 1000000000;
		}
		return new Duration
		{
			Seconds = seconds,
			Nanos = nanoseconds
		};
	}

	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
	{
		if (IsNormalized(seconds, nanoseconds))
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('"');
			if (seconds == 0L && nanoseconds < 0)
			{
				stringBuilder.Append('-');
			}
			stringBuilder.Append(seconds.ToString(getString_0(107359856), CultureInfo.InvariantCulture));
			AppendNanoseconds(stringBuilder, Math.Abs(nanoseconds));
			stringBuilder.Append(getString_0(107459827));
			return stringBuilder.ToString();
		}
		if (!diagnosticOnly)
		{
			throw new InvalidOperationException(getString_0(107459729));
		}
		return string.Format(CultureInfo.InvariantCulture, getString_0(107459822), new object[2] { seconds, nanoseconds });
	}

	public string ToDiagnosticString()
	{
		return ToJson(Seconds, Nanos, diagnosticOnly: true);
	}

	internal static void AppendNanoseconds(StringBuilder builder, int nanos)
	{
		if (nanos != 0)
		{
			builder.Append('.');
			if (nanos % 1000000 == 0)
			{
				builder.Append((nanos / 1000000).ToString(getString_0(107459688), CultureInfo.InvariantCulture));
			}
			else if (nanos % 1000 == 0)
			{
				builder.Append((nanos / 1000).ToString(getString_0(107459715), CultureInfo.InvariantCulture));
			}
			else
			{
				builder.Append(nanos.ToString(getString_0(107459710), CultureInfo.InvariantCulture));
			}
		}
	}

	static Duration()
	{
		Strings.CreateGetStringDelegate(typeof(Duration));
		_parser = new MessageParser<Duration>(() => new Duration());
	}
}
