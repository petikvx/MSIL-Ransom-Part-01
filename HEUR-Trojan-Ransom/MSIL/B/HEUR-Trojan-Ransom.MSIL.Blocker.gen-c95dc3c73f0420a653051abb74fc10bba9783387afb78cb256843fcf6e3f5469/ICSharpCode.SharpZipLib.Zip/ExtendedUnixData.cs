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

	private DateTime EQCAYqQsPwzqciqGFwRXUwXpJGbx = new DateTime(1970, 1, 1);

	private Flags smDlfoHFNRiyWFaBecxtcaTFLrrdb;

	private DateTime xUfvxqQzWcjmkYNIVAYqRdxHkraF = new DateTime(1970, 1, 1);

	private DateTime AbVTqFDrZEMhbcRCzvrliQXhNGsp = new DateTime(1970, 1, 1);

	public DateTime AccessTime
	{
		get
		{
			return xUfvxqQzWcjmkYNIVAYqRdxHkraF;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			smDlfoHFNRiyWFaBecxtcaTFLrrdb |= Flags.AccessTime;
			xUfvxqQzWcjmkYNIVAYqRdxHkraF = value;
		}
	}

	public DateTime CreateTime
	{
		get
		{
			return EQCAYqQsPwzqciqGFwRXUwXpJGbx;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			smDlfoHFNRiyWFaBecxtcaTFLrrdb |= Flags.CreateTime;
			EQCAYqQsPwzqciqGFwRXUwXpJGbx = value;
		}
	}

	private Flags BTChQPxVIAxpeGoSdgifcafBBftvA
	{
		get
		{
			return smDlfoHFNRiyWFaBecxtcaTFLrrdb;
		}
		set
		{
			smDlfoHFNRiyWFaBecxtcaTFLrrdb = value;
		}
	}

	public DateTime ModificationTime
	{
		get
		{
			return AbVTqFDrZEMhbcRCzvrliQXhNGsp;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			smDlfoHFNRiyWFaBecxtcaTFLrrdb |= Flags.ModificationTime;
			AbVTqFDrZEMhbcRCzvrliQXhNGsp = value;
		}
	}

	public short TagID => 21589;

	public byte[] GetData()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(memoryStream);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.HTFIeiABiJBGNjpOAGEOJylRFbQe = false;
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.WriteByte((byte)smDlfoHFNRiyWFaBecxtcaTFLrrdb);
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.ModificationTime) != 0)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
			int value = (int)(AbVTqFDrZEMhbcRCzvrliQXhNGsp.ToUniversalTime() - dateTime.ToUniversalTime()).TotalSeconds;
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.lJPoAtXdrFCOCsGHnNwvsEhvMLQc(value);
		}
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.AccessTime) != 0)
		{
			DateTime dateTime2 = new DateTime(1970, 1, 1, 0, 0, 0);
			int value2 = (int)(xUfvxqQzWcjmkYNIVAYqRdxHkraF.ToUniversalTime() - dateTime2.ToUniversalTime()).TotalSeconds;
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.lJPoAtXdrFCOCsGHnNwvsEhvMLQc(value2);
		}
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.CreateTime) != 0)
		{
			DateTime dateTime3 = new DateTime(1970, 1, 1, 0, 0, 0);
			int value3 = (int)(EQCAYqQsPwzqciqGFwRXUwXpJGbx.ToUniversalTime() - dateTime3.ToUniversalTime()).TotalSeconds;
			cfcHHULxLwXWsXVCpmxHEpDxPQAF.lJPoAtXdrFCOCsGHnNwvsEhvMLQc(value3);
		}
		return memoryStream.ToArray();
	}

	public static bool IsValidValue(DateTime value)
	{
		if (value < new DateTime(1901, 12, 13, 20, 45, 52))
		{
			return value <= new DateTime(2038, 1, 19, 3, 14, 7);
		}
		return true;
	}

	public void SetData(byte[] data, int index, int count)
	{
		using MemoryStream stream = new MemoryStream(data, index, count, writable: false);
		using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(stream);
		smDlfoHFNRiyWFaBecxtcaTFLrrdb = (Flags)cfcHHULxLwXWsXVCpmxHEpDxPQAF.ReadByte();
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.ModificationTime) != 0 && count >= 5)
		{
			int seconds = cfcHHULxLwXWsXVCpmxHEpDxPQAF.qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
			AbVTqFDrZEMhbcRCzvrliQXhNGsp = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
		}
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.AccessTime) != 0)
		{
			int seconds2 = cfcHHULxLwXWsXVCpmxHEpDxPQAF.qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
			xUfvxqQzWcjmkYNIVAYqRdxHkraF = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds2, 0)).ToLocalTime();
		}
		if ((smDlfoHFNRiyWFaBecxtcaTFLrrdb & Flags.CreateTime) != 0)
		{
			int seconds3 = cfcHHULxLwXWsXVCpmxHEpDxPQAF.qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
			EQCAYqQsPwzqciqGFwRXUwXpJGbx = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds3, 0)).ToLocalTime();
		}
	}
}
