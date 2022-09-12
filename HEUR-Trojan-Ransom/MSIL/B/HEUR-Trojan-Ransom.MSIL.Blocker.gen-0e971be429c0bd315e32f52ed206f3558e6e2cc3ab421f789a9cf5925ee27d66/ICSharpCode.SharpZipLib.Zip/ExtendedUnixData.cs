using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class ExtendedUnixData : ITaggedData
{
	[Flags]
	public enum Flags : byte
	{
		AccessTime = 2,
		CreateTime = 4,
		ModificationTime = 1
	}

	private DateTime NSiQFkJFNQZaFhuKImwwYZcvWuC = new DateTime(1970, 1, 1);

	private Flags dzTqXRljLqSTQgcaresSKIEECCqT;

	private DateTime yfdkHFsfUBZPepPhIFPVjEyAKPbn = new DateTime(1970, 1, 1);

	private DateTime NpJEzytIZxFivTobqgqEOZOszzhF = new DateTime(1970, 1, 1);

	public DateTime AccessTime
	{
		get
		{
			return yfdkHFsfUBZPepPhIFPVjEyAKPbn;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			dzTqXRljLqSTQgcaresSKIEECCqT |= Flags.AccessTime;
			yfdkHFsfUBZPepPhIFPVjEyAKPbn = value;
		}
	}

	public DateTime CreateTime
	{
		get
		{
			return NSiQFkJFNQZaFhuKImwwYZcvWuC;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			dzTqXRljLqSTQgcaresSKIEECCqT |= Flags.CreateTime;
			NSiQFkJFNQZaFhuKImwwYZcvWuC = value;
		}
	}

	private Flags CcMCgcNEEzaBkejzqDbInGyGbYatA
	{
		get
		{
			return dzTqXRljLqSTQgcaresSKIEECCqT;
		}
		set
		{
			dzTqXRljLqSTQgcaresSKIEECCqT = value;
		}
	}

	public DateTime ModificationTime
	{
		get
		{
			return NpJEzytIZxFivTobqgqEOZOszzhF;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			dzTqXRljLqSTQgcaresSKIEECCqT |= Flags.ModificationTime;
			NpJEzytIZxFivTobqgqEOZOszzhF = value;
		}
	}

	public short TagID => 21589;

	public byte[] GetData()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(memoryStream);
		locxVjlCNZghquSrgFvmkfSoMwVu.MjVEoLBoHsdhPuAYZvVjarfKgyJMA = false;
		locxVjlCNZghquSrgFvmkfSoMwVu.WriteByte((byte)dzTqXRljLqSTQgcaresSKIEECCqT);
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.ModificationTime) != 0)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
			int value = (int)(NpJEzytIZxFivTobqgqEOZOszzhF.ToUniversalTime() - dateTime.ToUniversalTime()).TotalSeconds;
			locxVjlCNZghquSrgFvmkfSoMwVu.izRGOUentiyqAkNhkfWOgEFeqnCxb(value);
		}
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.AccessTime) != 0)
		{
			DateTime dateTime2 = new DateTime(1970, 1, 1, 0, 0, 0);
			int value2 = (int)(yfdkHFsfUBZPepPhIFPVjEyAKPbn.ToUniversalTime() - dateTime2.ToUniversalTime()).TotalSeconds;
			locxVjlCNZghquSrgFvmkfSoMwVu.izRGOUentiyqAkNhkfWOgEFeqnCxb(value2);
		}
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.CreateTime) != 0)
		{
			DateTime dateTime3 = new DateTime(1970, 1, 1, 0, 0, 0);
			int value3 = (int)(NSiQFkJFNQZaFhuKImwwYZcvWuC.ToUniversalTime() - dateTime3.ToUniversalTime()).TotalSeconds;
			locxVjlCNZghquSrgFvmkfSoMwVu.izRGOUentiyqAkNhkfWOgEFeqnCxb(value3);
		}
		return memoryStream.ToArray();
	}

	public static bool IsValidValue(DateTime value)
	{
		if (!(value < new DateTime(1901, 12, 13, 20, 45, 52)))
		{
			return true;
		}
		return value <= new DateTime(2038, 1, 19, 3, 14, 7);
	}

	public void SetData(byte[] data, int index, int count)
	{
		using MemoryStream stream = new MemoryStream(data, index, count, writable: false);
		using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(stream);
		dzTqXRljLqSTQgcaresSKIEECCqT = (Flags)locxVjlCNZghquSrgFvmkfSoMwVu.ReadByte();
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.ModificationTime) != 0 && count >= 5)
		{
			int seconds = locxVjlCNZghquSrgFvmkfSoMwVu.zTghKbjLnrybPZXXRNKYIAuaCwjU();
			NpJEzytIZxFivTobqgqEOZOszzhF = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
		}
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.AccessTime) != 0)
		{
			int seconds2 = locxVjlCNZghquSrgFvmkfSoMwVu.zTghKbjLnrybPZXXRNKYIAuaCwjU();
			yfdkHFsfUBZPepPhIFPVjEyAKPbn = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds2, 0)).ToLocalTime();
		}
		if ((dzTqXRljLqSTQgcaresSKIEECCqT & Flags.CreateTime) != 0)
		{
			int seconds3 = locxVjlCNZghquSrgFvmkfSoMwVu.zTghKbjLnrybPZXXRNKYIAuaCwjU();
			NSiQFkJFNQZaFhuKImwwYZcvWuC = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds3, 0)).ToLocalTime();
		}
	}
}
