using System;
using System.Globalization;

namespace Ubiety.Dns.Core.Records;

public sealed class RecordKx : Record, IComparable, IEquatable<RecordKx>
{
	public ushort Preference { get; }

	public string Exchanger { get; }

	public RecordKx(RecordReader rr)
	{
		Preference = rr.ReadUInt16();
		Exchanger = rr.ReadDomainName();
	}

	public static bool operator <(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) < 0;
	}

	public static bool operator >(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) > 0;
	}

	public static bool operator <=(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) <= 0;
	}

	public static bool operator >=(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) >= 0;
	}

	public static bool operator ==(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) == 0;
	}

	public static bool operator !=(RecordKx x, RecordKx y)
	{
		return CompareTo(x, y) != 0;
	}

	public int CompareTo(object obj)
	{
		return CompareTo(this, (RecordKx)obj);
	}

	public bool Equals(RecordKx other)
	{
		if (other == null)
		{
			return false;
		}
		return CompareTo(other) == 0;
	}

	public override string ToString()
	{
		return $"{Preference} {Exchanger}";
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
		return this == obj || Equals(obj as RecordKx);
	}

	public override int GetHashCode()
	{
		int num = 13;
		num = 0x1429 ^ Preference;
		int num2 = ((!string.IsNullOrEmpty(Exchanger)) ? Exchanger.GetHashCode() : 0);
		return (num * 397) ^ num2;
	}

	private static int CompareTo(RecordKx x, RecordKx y)
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
		return string.Compare(x.Exchanger, y.Exchanger, ignoreCase: true, CultureInfo.InvariantCulture);
	}
}
