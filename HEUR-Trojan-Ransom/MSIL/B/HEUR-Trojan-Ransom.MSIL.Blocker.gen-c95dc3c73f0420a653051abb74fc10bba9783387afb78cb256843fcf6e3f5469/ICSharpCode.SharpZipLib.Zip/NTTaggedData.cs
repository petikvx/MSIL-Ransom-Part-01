using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class NTTaggedData : ITaggedData
{
	private DateTime EQCAYqQsPwzqciqGFwRXUwXpJGbx = DateTime.FromFileTime(0L);

	private DateTime xUfvxqQzWcjmkYNIVAYqRdxHkraF = DateTime.FromFileTime(0L);

	private DateTime ZcLPupbnpLGbchGOLBunbaaDSrUyb = DateTime.FromFileTime(0L);

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
			EQCAYqQsPwzqciqGFwRXUwXpJGbx = value;
		}
	}

	public DateTime LastAccessTime
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
			xUfvxqQzWcjmkYNIVAYqRdxHkraF = value;
		}
	}

	public DateTime LastModificationTime
	{
		get
		{
			return ZcLPupbnpLGbchGOLBunbaaDSrUyb;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			ZcLPupbnpLGbchGOLBunbaaDSrUyb = value;
		}
	}

	public short TagID => 10;

	public byte[] GetData()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(memoryStream);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.HTFIeiABiJBGNjpOAGEOJylRFbQe = false;
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.lJPoAtXdrFCOCsGHnNwvsEhvMLQc(0);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(1);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.NfkIrBJfWhAdtBUKBIQbCGiMHmIPb(24);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.zrvRjCepzmFfdmryVYArtolNkSHy(ZcLPupbnpLGbchGOLBunbaaDSrUyb.ToFileTime());
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.zrvRjCepzmFfdmryVYArtolNkSHy(xUfvxqQzWcjmkYNIVAYqRdxHkraF.ToFileTime());
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.zrvRjCepzmFfdmryVYArtolNkSHy(EQCAYqQsPwzqciqGFwRXUwXpJGbx.ToFileTime());
		return memoryStream.ToArray();
	}

	public static bool IsValidValue(DateTime value)
	{
		bool result = true;
		try
		{
			value.ToFileTimeUtc();
			return result;
		}
		catch
		{
			return false;
		}
	}

	public void SetData(byte[] data, int index, int count)
	{
		using MemoryStream stream = new MemoryStream(data, index, count, writable: false);
		using CfcHHULxLwXWsXVCpmxHEpDxPQAF cfcHHULxLwXWsXVCpmxHEpDxPQAF = new CfcHHULxLwXWsXVCpmxHEpDxPQAF(stream);
		cfcHHULxLwXWsXVCpmxHEpDxPQAF.qCqCmGPNlORNVsCsMzEbsQnhcNgIA();
		while (cfcHHULxLwXWsXVCpmxHEpDxPQAF.Position < cfcHHULxLwXWsXVCpmxHEpDxPQAF.Length)
		{
			int num = cfcHHULxLwXWsXVCpmxHEpDxPQAF.pemcXlQRWARdCRweuWeqNyeeMNBA();
			int num2 = cfcHHULxLwXWsXVCpmxHEpDxPQAF.pemcXlQRWARdCRweuWeqNyeeMNBA();
			if (num != 1)
			{
				cfcHHULxLwXWsXVCpmxHEpDxPQAF.Seek(num2, SeekOrigin.Current);
				continue;
			}
			if (num2 >= 24)
			{
				long fileTime = cfcHHULxLwXWsXVCpmxHEpDxPQAF.XBoMohwlbiIKOrBkHamgPzBMPWzo();
				ZcLPupbnpLGbchGOLBunbaaDSrUyb = DateTime.FromFileTime(fileTime);
				long fileTime2 = cfcHHULxLwXWsXVCpmxHEpDxPQAF.XBoMohwlbiIKOrBkHamgPzBMPWzo();
				xUfvxqQzWcjmkYNIVAYqRdxHkraF = DateTime.FromFileTime(fileTime2);
				long fileTime3 = cfcHHULxLwXWsXVCpmxHEpDxPQAF.XBoMohwlbiIKOrBkHamgPzBMPWzo();
				EQCAYqQsPwzqciqGFwRXUwXpJGbx = DateTime.FromFileTime(fileTime3);
			}
			break;
		}
	}
}
