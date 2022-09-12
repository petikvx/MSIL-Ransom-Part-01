using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public class NTTaggedData : ITaggedData
{
	private DateTime NSiQFkJFNQZaFhuKImwwYZcvWuC = DateTime.FromFileTime(0L);

	private DateTime yfdkHFsfUBZPepPhIFPVjEyAKPbn = DateTime.FromFileTime(0L);

	private DateTime CKLCJQZNzkJYmngtEdlKCLtLMvFI = DateTime.FromFileTime(0L);

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
			NSiQFkJFNQZaFhuKImwwYZcvWuC = value;
		}
	}

	public DateTime LastAccessTime
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
			yfdkHFsfUBZPepPhIFPVjEyAKPbn = value;
		}
	}

	public DateTime LastModificationTime
	{
		get
		{
			return CKLCJQZNzkJYmngtEdlKCLtLMvFI;
		}
		set
		{
			if (!IsValidValue(value))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			CKLCJQZNzkJYmngtEdlKCLtLMvFI = value;
		}
	}

	public short TagID => 10;

	public byte[] GetData()
	{
		using MemoryStream memoryStream = new MemoryStream();
		using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(memoryStream);
		locxVjlCNZghquSrgFvmkfSoMwVu.MjVEoLBoHsdhPuAYZvVjarfKgyJMA = false;
		locxVjlCNZghquSrgFvmkfSoMwVu.izRGOUentiyqAkNhkfWOgEFeqnCxb(0);
		locxVjlCNZghquSrgFvmkfSoMwVu.WPwBCcZKsWTMxrdsFHKYotnEJfDC(1);
		locxVjlCNZghquSrgFvmkfSoMwVu.WPwBCcZKsWTMxrdsFHKYotnEJfDC(24);
		locxVjlCNZghquSrgFvmkfSoMwVu.oYvJtfMPzNFArZAFOTgGFwaIdqGL(CKLCJQZNzkJYmngtEdlKCLtLMvFI.ToFileTime());
		locxVjlCNZghquSrgFvmkfSoMwVu.oYvJtfMPzNFArZAFOTgGFwaIdqGL(yfdkHFsfUBZPepPhIFPVjEyAKPbn.ToFileTime());
		locxVjlCNZghquSrgFvmkfSoMwVu.oYvJtfMPzNFArZAFOTgGFwaIdqGL(NSiQFkJFNQZaFhuKImwwYZcvWuC.ToFileTime());
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
		using LocxVjlCNZghquSrgFvmkfSoMwVu locxVjlCNZghquSrgFvmkfSoMwVu = new LocxVjlCNZghquSrgFvmkfSoMwVu(stream);
		locxVjlCNZghquSrgFvmkfSoMwVu.zTghKbjLnrybPZXXRNKYIAuaCwjU();
		while (locxVjlCNZghquSrgFvmkfSoMwVu.Position < locxVjlCNZghquSrgFvmkfSoMwVu.Length)
		{
			int num = locxVjlCNZghquSrgFvmkfSoMwVu.mIgBSqdPFvczrfkRIhPZGUdDzdEWC();
			int num2 = locxVjlCNZghquSrgFvmkfSoMwVu.mIgBSqdPFvczrfkRIhPZGUdDzdEWC();
			if (num != 1)
			{
				locxVjlCNZghquSrgFvmkfSoMwVu.Seek(num2, SeekOrigin.Current);
				continue;
			}
			if (num2 >= 24)
			{
				long fileTime = locxVjlCNZghquSrgFvmkfSoMwVu.CNqoiQIsdDFiAWRRGzvBviEDffmN();
				CKLCJQZNzkJYmngtEdlKCLtLMvFI = DateTime.FromFileTime(fileTime);
				long fileTime2 = locxVjlCNZghquSrgFvmkfSoMwVu.CNqoiQIsdDFiAWRRGzvBviEDffmN();
				yfdkHFsfUBZPepPhIFPVjEyAKPbn = DateTime.FromFileTime(fileTime2);
				long fileTime3 = locxVjlCNZghquSrgFvmkfSoMwVu.CNqoiQIsdDFiAWRRGzvBviEDffmN();
				NSiQFkJFNQZaFhuKImwwYZcvWuC = DateTime.FromFileTime(fileTime3);
			}
			break;
		}
	}
}
