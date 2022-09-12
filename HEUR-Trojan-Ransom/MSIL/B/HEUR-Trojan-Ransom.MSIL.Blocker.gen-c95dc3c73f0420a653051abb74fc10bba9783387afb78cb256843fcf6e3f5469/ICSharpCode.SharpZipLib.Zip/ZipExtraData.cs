using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public sealed class ZipExtraData : IDisposable
{
	private byte[] MvTGgyxVtRahEYkGOufOFZIafSFB;

	private int LgWDufnfRkkDngfkJbEskadOtucl;

	private MemoryStream dmXCBsWagEtxHZPriAllOsTvtaZQ;

	private int LQoGEcGjSseYilzyWBcuZVRVougz;

	private int GuSSNkHwRgvgGrzlFgExbKpJDJKbA;

	public int CurrentReadIndex => LgWDufnfRkkDngfkJbEskadOtucl;

	public int Length => MvTGgyxVtRahEYkGOufOFZIafSFB.Length;

	public int UnreadCount
	{
		get
		{
			if (GuSSNkHwRgvgGrzlFgExbKpJDJKbA > MvTGgyxVtRahEYkGOufOFZIafSFB.Length || GuSSNkHwRgvgGrzlFgExbKpJDJKbA < 4)
			{
				throw new ZipException("Find must be called before calling a Read method");
			}
			return GuSSNkHwRgvgGrzlFgExbKpJDJKbA + LQoGEcGjSseYilzyWBcuZVRVougz - LgWDufnfRkkDngfkJbEskadOtucl;
		}
	}

	public int ValueLength => LQoGEcGjSseYilzyWBcuZVRVougz;

	public ZipExtraData()
	{
		Clear();
	}

	public ZipExtraData(byte[] data)
	{
		if (data == null)
		{
			MvTGgyxVtRahEYkGOufOFZIafSFB = new byte[0];
		}
		else
		{
			MvTGgyxVtRahEYkGOufOFZIafSFB = data;
		}
	}

	public void AddData(byte data)
	{
		dmXCBsWagEtxHZPriAllOsTvtaZQ.WriteByte(data);
	}

	public void AddData(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		dmXCBsWagEtxHZPriAllOsTvtaZQ.Write(data, 0, data.Length);
	}

	public void AddEntry(ITaggedData taggedData)
	{
		if (taggedData == null)
		{
			throw new ArgumentNullException("taggedData");
		}
		AddEntry(taggedData.TagID, taggedData.GetData());
	}

	public void AddEntry(int headerID, byte[] fieldData)
	{
		if (headerID <= 65535 && headerID >= 0)
		{
			int num = ((fieldData != null) ? fieldData.Length : 0);
			if (num > 65535)
			{
				throw new ArgumentOutOfRangeException("fieldData", "exceeds maximum length");
			}
			int num2 = MvTGgyxVtRahEYkGOufOFZIafSFB.Length + num + 4;
			if (Find(headerID))
			{
				num2 -= ValueLength + 4;
			}
			if (num2 > 65535)
			{
				throw new ZipException("Data exceeds maximum length");
			}
			Delete(headerID);
			byte[] array = new byte[num2];
			MvTGgyxVtRahEYkGOufOFZIafSFB.CopyTo(array, 0);
			int index = MvTGgyxVtRahEYkGOufOFZIafSFB.Length;
			MvTGgyxVtRahEYkGOufOFZIafSFB = array;
			koSoIsCIvLEVUhvkmgYKdYnALLbu(ref index, headerID);
			koSoIsCIvLEVUhvkmgYKdYnALLbu(ref index, num);
			fieldData?.CopyTo(array, index);
			return;
		}
		throw new ArgumentOutOfRangeException("headerID");
	}

	public void AddLeInt(int toAdd)
	{
		((Stream)(object)this).WriteByte((byte)(short)toAdd);
		((Stream)(object)this).WriteByte((byte)(short)(toAdd >> 16));
	}

	public void AddLeLong(long toAdd)
	{
		AddLeInt((int)(toAdd & 0xFFFFFFFFL));
		AddLeInt((int)(toAdd >> 32));
	}

	public void AddLeShort(int toAdd)
	{
		dmXCBsWagEtxHZPriAllOsTvtaZQ.WriteByte((byte)toAdd);
		dmXCBsWagEtxHZPriAllOsTvtaZQ.WriteByte((byte)(toAdd >> 8));
	}

	public void AddNewEntry(int headerID)
	{
		byte[] fieldData = dmXCBsWagEtxHZPriAllOsTvtaZQ.ToArray();
		dmXCBsWagEtxHZPriAllOsTvtaZQ = null;
		AddEntry(headerID, fieldData);
	}

	public void Clear()
	{
		if (MvTGgyxVtRahEYkGOufOFZIafSFB == null || MvTGgyxVtRahEYkGOufOFZIafSFB.Length != 0)
		{
			MvTGgyxVtRahEYkGOufOFZIafSFB = new byte[0];
		}
	}

	private static ITaggedData HqBdQHGdysKSATiIQjwwUtfVbhJFb(short short_0, byte[] data, int offset, int count)
	{
		ITaggedData taggedData = null;
		taggedData = short_0 switch
		{
			21589 => new ExtendedUnixData(), 
			10 => new NTTaggedData(), 
			_ => new RawTaggedData(short_0), 
		};
		taggedData.SetData(data, offset, count);
		return taggedData;
	}

	public bool Delete(int headerID)
	{
		bool result = false;
		if (Find(headerID))
		{
			result = true;
			int num = GuSSNkHwRgvgGrzlFgExbKpJDJKbA - 4;
			byte[] array = new byte[MvTGgyxVtRahEYkGOufOFZIafSFB.Length - (ValueLength + 4)];
			Array.Copy(MvTGgyxVtRahEYkGOufOFZIafSFB, 0, array, 0, num);
			int num2 = num + ValueLength + 4;
			Array.Copy(MvTGgyxVtRahEYkGOufOFZIafSFB, num2, array, num, MvTGgyxVtRahEYkGOufOFZIafSFB.Length - num2);
			MvTGgyxVtRahEYkGOufOFZIafSFB = array;
		}
		return result;
	}

	public void Dispose()
	{
		if (dmXCBsWagEtxHZPriAllOsTvtaZQ != null)
		{
			dmXCBsWagEtxHZPriAllOsTvtaZQ.Close();
		}
	}

	public bool Find(int headerID)
	{
		GuSSNkHwRgvgGrzlFgExbKpJDJKbA = MvTGgyxVtRahEYkGOufOFZIafSFB.Length;
		LQoGEcGjSseYilzyWBcuZVRVougz = 0;
		LgWDufnfRkkDngfkJbEskadOtucl = 0;
		int num = GuSSNkHwRgvgGrzlFgExbKpJDJKbA;
		int num2 = headerID - 1;
		while (num2 != headerID && LgWDufnfRkkDngfkJbEskadOtucl < MvTGgyxVtRahEYkGOufOFZIafSFB.Length - 3)
		{
			num2 = cCWMeniBdlghVcHTNymqdfTYazOfA();
			num = cCWMeniBdlghVcHTNymqdfTYazOfA();
			if (num2 != headerID)
			{
				LgWDufnfRkkDngfkJbEskadOtucl += num;
			}
		}
		int num3;
		if (num2 == headerID)
		{
			num3 = ((LgWDufnfRkkDngfkJbEskadOtucl + num <= MvTGgyxVtRahEYkGOufOFZIafSFB.Length) ? 1 : 0);
			if (num3 != 0)
			{
				GuSSNkHwRgvgGrzlFgExbKpJDJKbA = LgWDufnfRkkDngfkJbEskadOtucl;
				LQoGEcGjSseYilzyWBcuZVRVougz = num;
			}
		}
		else
		{
			num3 = 0;
		}
		return (byte)num3 != 0;
	}

	private ITaggedData LtfLysrTUfNQdhJbxFCbBhUIeRybb(short short_0)
	{
		ITaggedData result = null;
		if (Find(short_0))
		{
			result = HqBdQHGdysKSATiIQjwwUtfVbhJFb(short_0, MvTGgyxVtRahEYkGOufOFZIafSFB, GuSSNkHwRgvgGrzlFgExbKpJDJKbA, LQoGEcGjSseYilzyWBcuZVRVougz);
		}
		return result;
	}

	public byte[] GetEntryData()
	{
		if (Length > 65535)
		{
			throw new ZipException("Data exceeds maximum length");
		}
		return (byte[])MvTGgyxVtRahEYkGOufOFZIafSFB.Clone();
	}

	public Stream GetStreamForTag(int int_0)
	{
		Stream result = null;
		if (Find(int_0))
		{
			result = new MemoryStream(MvTGgyxVtRahEYkGOufOFZIafSFB, LgWDufnfRkkDngfkJbEskadOtucl, LQoGEcGjSseYilzyWBcuZVRVougz, writable: false);
		}
		return result;
	}

	public int ReadByte()
	{
		int result = -1;
		if (LgWDufnfRkkDngfkJbEskadOtucl < MvTGgyxVtRahEYkGOufOFZIafSFB.Length && GuSSNkHwRgvgGrzlFgExbKpJDJKbA + LQoGEcGjSseYilzyWBcuZVRVougz > LgWDufnfRkkDngfkJbEskadOtucl)
		{
			result = MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl];
			LgWDufnfRkkDngfkJbEskadOtucl++;
		}
		return result;
	}

	private void fTvifvFaGNXRFbzjlMwXObqemjPe(int length)
	{
		if (GuSSNkHwRgvgGrzlFgExbKpJDJKbA <= MvTGgyxVtRahEYkGOufOFZIafSFB.Length && GuSSNkHwRgvgGrzlFgExbKpJDJKbA >= 4)
		{
			if (LgWDufnfRkkDngfkJbEskadOtucl > GuSSNkHwRgvgGrzlFgExbKpJDJKbA + LQoGEcGjSseYilzyWBcuZVRVougz - length)
			{
				throw new ZipException("End of extra data");
			}
			return;
		}
		throw new ZipException("Find must be called before calling a Read method");
	}

	public int ReadInt()
	{
		fTvifvFaGNXRFbzjlMwXObqemjPe(4);
		int result = MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl] + (MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl + 1] << 8) + (MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl + 2] << 16) + (MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl + 3] << 24);
		LgWDufnfRkkDngfkJbEskadOtucl += 4;
		return result;
	}

	public long ReadLong()
	{
		fTvifvFaGNXRFbzjlMwXObqemjPe(8);
		return (ReadInt() & 0xFFFFFFFFL) | ((long)ReadInt() << 32);
	}

	public int ReadShort()
	{
		fTvifvFaGNXRFbzjlMwXObqemjPe(2);
		int result = MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl] + (MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl + 1] << 8);
		LgWDufnfRkkDngfkJbEskadOtucl += 2;
		return result;
	}

	private int cCWMeniBdlghVcHTNymqdfTYazOfA()
	{
		if (LgWDufnfRkkDngfkJbEskadOtucl > MvTGgyxVtRahEYkGOufOFZIafSFB.Length - 2)
		{
			throw new ZipException("End of extra data");
		}
		int result = MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl] + (MvTGgyxVtRahEYkGOufOFZIafSFB[LgWDufnfRkkDngfkJbEskadOtucl + 1] << 8);
		LgWDufnfRkkDngfkJbEskadOtucl += 2;
		return result;
	}

	private void koSoIsCIvLEVUhvkmgYKdYnALLbu(ref int index, int source)
	{
		MvTGgyxVtRahEYkGOufOFZIafSFB[index] = (byte)source;
		MvTGgyxVtRahEYkGOufOFZIafSFB[index + 1] = (byte)(source >> 8);
		index += 2;
	}

	public void Skip(int amount)
	{
		fTvifvFaGNXRFbzjlMwXObqemjPe(amount);
		LgWDufnfRkkDngfkJbEskadOtucl += amount;
	}

	public void StartNewEntry()
	{
		dmXCBsWagEtxHZPriAllOsTvtaZQ = new MemoryStream();
	}
}
