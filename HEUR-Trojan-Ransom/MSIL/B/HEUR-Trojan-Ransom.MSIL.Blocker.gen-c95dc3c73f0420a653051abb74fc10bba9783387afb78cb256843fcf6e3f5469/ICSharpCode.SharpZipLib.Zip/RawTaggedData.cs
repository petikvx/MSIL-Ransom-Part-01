using System;

namespace ICSharpCode.SharpZipLib.Zip;

public class RawTaggedData : ITaggedData
{
	private byte[] MvTGgyxVtRahEYkGOufOFZIafSFB;

	protected short tag_;

	public byte[] Data
	{
		get
		{
			return MvTGgyxVtRahEYkGOufOFZIafSFB;
		}
		set
		{
			MvTGgyxVtRahEYkGOufOFZIafSFB = value;
		}
	}

	public short TagID
	{
		get
		{
			return tag_;
		}
		set
		{
			tag_ = value;
		}
	}

	public RawTaggedData(short short_0)
	{
		tag_ = short_0;
	}

	public byte[] GetData()
	{
		return MvTGgyxVtRahEYkGOufOFZIafSFB;
	}

	public void SetData(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		MvTGgyxVtRahEYkGOufOFZIafSFB = new byte[count];
		Array.Copy(data, offset, MvTGgyxVtRahEYkGOufOFZIafSFB, 0, count);
	}
}
