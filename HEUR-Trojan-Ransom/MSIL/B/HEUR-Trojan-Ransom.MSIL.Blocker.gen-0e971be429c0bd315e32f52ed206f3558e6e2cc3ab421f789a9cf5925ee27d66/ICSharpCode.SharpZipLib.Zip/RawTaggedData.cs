using System;

namespace ICSharpCode.SharpZipLib.Zip;

public class RawTaggedData : ITaggedData
{
	private byte[] FkHggXbLDEqQxMvZHZhQJzSzgSPtA;

	protected short tag_;

	public byte[] Data
	{
		get
		{
			return FkHggXbLDEqQxMvZHZhQJzSzgSPtA;
		}
		set
		{
			FkHggXbLDEqQxMvZHZhQJzSzgSPtA = value;
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
		return FkHggXbLDEqQxMvZHZhQJzSzgSPtA;
	}

	public void SetData(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		FkHggXbLDEqQxMvZHZhQJzSzgSPtA = new byte[count];
		Array.Copy(data, offset, FkHggXbLDEqQxMvZHZhQJzSzgSPtA, 0, count);
	}
}
