using System;
using System.Globalization;

namespace Ubiety.Dns.Core.Records.Mail;

public sealed class RecordMx : Record, IComparable, IEquatable<RecordMx>
{
	public ushort Preference { get; }

	public string Exchange { get; }

	public RecordMx(RecordReader rr)
	{
		Preference = rr.ReadUInt16();
		Exchange = rr.ReadDomainName();
	}

	public static bool operator <(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) < 0;
	}

	public static bool operator >(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) > 0;
	}

	public static bool operator <=(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) <= 0;
	}

	public static bool operator >=(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) >= 0;
	}

	public static bool operator ==(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) == 0;
	}

	public static bool operator !=(RecordMx x, RecordMx y)
	{
		return CompareTo(x, y) != 0;
	}

	public int CompareTo(object obj)
	{
		return CompareTo(this, obj as RecordMx);
	}

	public bool Equals(RecordMx other)
	{
		if ((object)other == null)
		{
			return false;
		}
		return CompareTo(this, other) == 0;
	}

	public override string ToString()
	{
		return $"{Preference} {Exchange}";
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (GetType() != obj.GetType())
		{
			return false;
		}
		return this == obj || Equals(obj as RecordMx);
	}

	public override int GetHashCode()
	{
		return Exchange.GetHashCode();
	}

	private static int CompareTo(RecordMx x, RecordMx y)
	{
		if (y == null)
		{
			return -1;
		}
		if (x.Preference > y.Preference)
		{
			return 1;
		}
		if (x.Preference < y.Preference)
		{
			return -1;
		}
		return string.Compare(x.Exchange, y.Exchange, ignoreCase: true, CultureInfo.InvariantCulture);
	}
}
