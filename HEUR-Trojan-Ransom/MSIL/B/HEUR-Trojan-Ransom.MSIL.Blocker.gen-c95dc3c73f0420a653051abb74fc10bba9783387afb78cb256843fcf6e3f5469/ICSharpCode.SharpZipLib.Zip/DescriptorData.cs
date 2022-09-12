namespace ICSharpCode.SharpZipLib.Zip;

public class DescriptorData
{
	private long BuLbOZizrmgGUyFrOevBAjsAfsbMA;

	private long ZfAHQcAyQpQiDLhOPFrQSOafCJTkA;

	private long gOPGBDvMAQDMSIGaZoAfsWDPWdme;

	public long CompressedSize
	{
		get
		{
			return BuLbOZizrmgGUyFrOevBAjsAfsbMA;
		}
		set
		{
			BuLbOZizrmgGUyFrOevBAjsAfsbMA = value;
		}
	}

	public long Crc
	{
		get
		{
			return ZfAHQcAyQpQiDLhOPFrQSOafCJTkA;
		}
		set
		{
			ZfAHQcAyQpQiDLhOPFrQSOafCJTkA = value & 0xFFFFFFFFL;
		}
	}

	public long Size
	{
		get
		{
			return gOPGBDvMAQDMSIGaZoAfsWDPWdme;
		}
		set
		{
			gOPGBDvMAQDMSIGaZoAfsWDPWdme = value;
		}
	}
}
