using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public sealed class Timestamp : IMessage<Timestamp>, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, IMessage, ICustomDiagnosticMessage
{
	private static readonly MessageParser<Timestamp> _parser = new MessageParser<Timestamp>(() => new Timestamp());

	private UnknownFieldSet _unknownFields;

	public const int SecondsFieldNumber = 1;

	private long seconds_;

	public const int NanosFieldNumber = 2;

	private int nanos_;

	private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private const long BclSecondsAtUnixEpoch = 62135596800L;

	internal const long UnixSecondsAtBclMaxValue = 253402300799L;

	internal const long UnixSecondsAtBclMinValue = -62135596800L;

	internal const int MaxNanos = 999999999;

	[DebuggerNonUserCode]
	public static MessageParser<Timestamp> Parser => _parser;

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TimestampReflection.Descriptor.MessageTypes[0];

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
	public Timestamp()
	{
	}

	[DebuggerNonUserCode]
	public Timestamp(Timestamp other)
		: this()
	{
		seconds_ = other.seconds_;
		nanos_ = other.nanos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	public Timestamp Clone()
	{
		return new Timestamp(this);
	}

	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as Timestamp);
	}

	[DebuggerNonUserCode]
	public bool Equals(Timestamp other)
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
	public void MergeFrom(Timestamp other)
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

	private static bool IsNormalized(long seconds, int nanoseconds)
	{
		if (nanoseconds >= 0 && nanoseconds <= 999999999 && seconds >= -62135596800L)
		{
			return seconds <= 253402300799L;
		}
		return false;
	}

	public static Duration operator -(Timestamp lhs, Timestamp rhs)
	{
		ProtoPreconditions.CheckNotNull(lhs, "lhs");
		ProtoPreconditions.CheckNotNull(rhs, "rhs");
		return checked(Duration.Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
	}

	public static Timestamp operator +(Timestamp lhs, Duration rhs)
	{
		ProtoPreconditions.CheckNotNull(lhs, "lhs");
		ProtoPreconditions.CheckNotNull(rhs, "rhs");
		return checked(Normalize(lhs.Seconds + rhs.Seconds, lhs.Nanos + rhs.Nanos));
	}

	public static Timestamp operator -(Timestamp lhs, Duration rhs)
	{
		ProtoPreconditions.CheckNotNull(lhs, "lhs");
		ProtoPreconditions.CheckNotNull(rhs, "rhs");
		return checked(Normalize(lhs.Seconds - rhs.Seconds, lhs.Nanos - rhs.Nanos));
	}

	public DateTime ToDateTime()
	{
		if (!IsNormalized(Seconds, Nanos))
		{
			throw new InvalidOperationException("Timestamp contains invalid values: Seconds={Seconds}; Nanos={Nanos}");
		}
		DateTime unixEpoch = UnixEpoch;
		return unixEpoch.AddSeconds(Seconds).AddTicks(Nanos / 100);
	}

	public DateTimeOffset ToDateTimeOffset()
	{
		return new DateTimeOffset(ToDateTime(), TimeSpan.Zero);
	}

	public static Timestamp FromDateTime(DateTime dateTime)
	{
		if (dateTime.Kind != DateTimeKind.Utc)
		{
			throw new ArgumentException("Conversion from DateTime to Timestamp requires the DateTime kind to be Utc", "dateTime");
		}
		long num = dateTime.Ticks / 10000000L;
		int nanos = (int)(dateTime.Ticks % 10000000L) * 100;
		return new Timestamp
		{
			Seconds = num - 62135596800L,
			Nanos = nanos
		};
	}

	public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset)
	{
		return FromDateTime(dateTimeOffset.UtcDateTime);
	}

	internal static Timestamp Normalize(long seconds, int nanoseconds)
	{
		int num = nanoseconds / 1000000000;
		seconds += num;
		nanoseconds -= num * 1000000000;
		if (nanoseconds < 0)
		{
			nanoseconds += 1000000000;
			seconds--;
		}
		return new Timestamp
		{
			Seconds = seconds,
			Nanos = nanoseconds
		};
	}

	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
	{
		if (IsNormalized(seconds, nanoseconds))
		{
			DateTime unixEpoch = UnixEpoch;
			DateTime dateTime = unixEpoch.AddSeconds(seconds);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('"');
			stringBuilder.Append(dateTime.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss", CultureInfo.InvariantCulture));
			Duration.AppendNanoseconds(stringBuilder, nanoseconds);
			stringBuilder.Append("Z\"");
			return stringBuilder.ToString();
		}
		if (!diagnosticOnly)
		{
			throw new InvalidOperationException("Non-normalized timestamp value");
		}
		return string.Format(CultureInfo.InvariantCulture, "{{ \"@warning\": \"Invalid Timestamp\", \"seconds\": \"{0}\", \"nanos\": {1} }}", new object[2] { seconds, nanoseconds });
	}

	public string ToDiagnosticString()
	{
		return ToJson(Seconds, Nanos, diagnosticOnly: true);
	}
}
