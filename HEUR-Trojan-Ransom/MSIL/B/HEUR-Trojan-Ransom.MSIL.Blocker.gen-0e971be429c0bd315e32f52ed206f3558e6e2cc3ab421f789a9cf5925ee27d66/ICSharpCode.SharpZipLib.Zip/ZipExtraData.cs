using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public sealed class ZipExtraData : IDisposable
{
	private byte[] FkHggXbLDEqQxMvZHZhQJzSzgSPtA;

	private int OsWMtULSrBGOjJmDEkoBUguTlMpT;

	private MemoryStream uWZipDmeejnJDqxIhmqUikKqhZCX;

	private int GUmyaPFORRwgsYGDLpLPxCKYcFxM;

	private int RGOrWVvLfTCeMIFQOFOWTKgCufBl;

	public int CurrentReadIndex => OsWMtULSrBGOjJmDEkoBUguTlMpT;

	public int Length => FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length;

	public int UnreadCount
	{
		get
		{
			if (RGOrWVvLfTCeMIFQOFOWTKgCufBl > FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length || RGOrWVvLfTCeMIFQOFOWTKgCufBl < 4)
			{
				throw new ZipException("Find must be called before calling a Read method");
			}
			return RGOrWVvLfTCeMIFQOFOWTKgCufBl + GUmyaPFORRwgsYGDLpLPxCKYcFxM - OsWMtULSrBGOjJmDEkoBUguTlMpT;
		}
	}

	public int ValueLength => GUmyaPFORRwgsYGDLpLPxCKYcFxM;

	public ZipExtraData()
	{
		Clear();
	}

	public ZipExtraData(byte[] data)
	{
		if (data == null)
		{
			FkHggXbLDEqQxMvZHZhQJzSzgSPtA = new byte[0];
		}
		else
		{
			FkHggXbLDEqQxMvZHZhQJzSzgSPtA = data;
		}
	}

	public void AddData(byte data)
	{
		uWZipDmeejnJDqxIhmqUikKqhZCX.WriteByte(data);
	}

	public void AddData(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		uWZipDmeejnJDqxIhmqUikKqhZCX.Write(data, 0, data.Length);
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
		if (headerID > 65535 || headerID < 0)
		{
			throw new ArgumentOutOfRangeException("headerID");
		}
		int num = ((fieldData != null) ? fieldData.Length : 0);
		if (num <= 65535)
		{
			int num2 = FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length + num + 4;
			if (Find(headerID))
			{
				num2 -= ValueLength + 4;
			}
			if (num2 <= 65535)
			{
				Delete(headerID);
				byte[] array = new byte[num2];
				FkHggXbLDEqQxMvZHZhQJzSzgSPtA.CopyTo(array, 0);
				int index = FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length;
				FkHggXbLDEqQxMvZHZhQJzSzgSPtA = array;
				fCQmoTmSbgvfAOURxZohRWmHqnmF(ref index, headerID);
				fCQmoTmSbgvfAOURxZohRWmHqnmF(ref index, num);
				fieldData?.CopyTo(array, index);
				return;
			}
			throw new ZipException("Data exceeds maximum length");
		}
		throw new ArgumentOutOfRangeException("fieldData", "exceeds maximum length");
	}

	public void AddLeInt(int toAdd)
	{
		AddLeShort((short)toAdd);
		AddLeShort((short)(toAdd >> 16));
	}

	public void AddLeLong(long toAdd)
	{
		AddLeInt((int)(toAdd & 0xFFFFFFFFL));
		AddLeInt((int)(toAdd >> 32));
	}

	public void AddLeShort(int toAdd)
	{
		uWZipDmeejnJDqxIhmqUikKqhZCX.WriteByte((byte)toAdd);
		uWZipDmeejnJDqxIhmqUikKqhZCX.WriteByte((byte)(toAdd >> 8));
	}

	public void AddNewEntry(int headerID)
	{
		byte[] fieldData = uWZipDmeejnJDqxIhmqUikKqhZCX.ToArray();
		uWZipDmeejnJDqxIhmqUikKqhZCX = null;
		AddEntry(headerID, fieldData);
	}

	public void Clear()
	{
		if (FkHggXbLDEqQxMvZHZhQJzSzgSPtA == null || FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length != 0)
		{
			FkHggXbLDEqQxMvZHZhQJzSzgSPtA = new byte[0];
		}
	}

	private static ITaggedData IAXsuoPgSBwGwJpoBvTVJwTMYIxB(short short_0, byte[] data, int offset, int count)
	{
		ITaggedData taggedData = null;
		taggedData = short_0 switch
		{
			10 => new NTTaggedData(), 
			21589 => new ExtendedUnixData(), 
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
			int num = RGOrWVvLfTCeMIFQOFOWTKgCufBl - 4;
			byte[] array = new byte[FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length - (ValueLength + 4)];
			Array.Copy(FkHggXbLDEqQxMvZHZhQJzSzgSPtA, 0, array, 0, num);
			int num2 = num + ValueLength + 4;
			Array.Copy(FkHggXbLDEqQxMvZHZhQJzSzgSPtA, num2, array, num, FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length - num2);
			FkHggXbLDEqQxMvZHZhQJzSzgSPtA = array;
		}
		return result;
	}

	public void Dispose()
	{
		if (uWZipDmeejnJDqxIhmqUikKqhZCX != null)
		{
			uWZipDmeejnJDqxIhmqUikKqhZCX.Close();
		}
	}

	public bool Find(int headerID)
	{
		RGOrWVvLfTCeMIFQOFOWTKgCufBl = FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length;
		GUmyaPFORRwgsYGDLpLPxCKYcFxM = 0;
		OsWMtULSrBGOjJmDEkoBUguTlMpT = 0;
		int num = RGOrWVvLfTCeMIFQOFOWTKgCufBl;
		int num2 = headerID - 1;
		while (num2 != headerID && OsWMtULSrBGOjJmDEkoBUguTlMpT < FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length - 3)
		{
			num2 = vvONuIMozGkVPZCuQkhFTZIXNYFt();
			num = vvONuIMozGkVPZCuQkhFTZIXNYFt();
			if (num2 != headerID)
			{
				OsWMtULSrBGOjJmDEkoBUguTlMpT += num;
			}
		}
		bool result;
		if (result = num2 == headerID && OsWMtULSrBGOjJmDEkoBUguTlMpT + num <= FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length)
		{
			RGOrWVvLfTCeMIFQOFOWTKgCufBl = OsWMtULSrBGOjJmDEkoBUguTlMpT;
			GUmyaPFORRwgsYGDLpLPxCKYcFxM = num;
		}
		return result;
	}

	private ITaggedData AGdECZVsUSaAlIDUsDZAHGDXJqnQ(short short_0)
	{
		ITaggedData result = null;
		if (Find(short_0))
		{
			result = IAXsuoPgSBwGwJpoBvTVJwTMYIxB(short_0, FkHggXbLDEqQxMvZHZhQJzSzgSPtA, RGOrWVvLfTCeMIFQOFOWTKgCufBl, GUmyaPFORRwgsYGDLpLPxCKYcFxM);
		}
		return result;
	}

	public byte[] GetEntryData()
	{
		if (Length > 65535)
		{
			throw new ZipException("Data exceeds maximum length");
		}
		return (byte[])FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Clone();
	}

	public Stream GetStreamForTag(int int_0)
	{
		Stream result = null;
		if (Find(int_0))
		{
			result = new MemoryStream(FkHggXbLDEqQxMvZHZhQJzSzgSPtA, OsWMtULSrBGOjJmDEkoBUguTlMpT, GUmyaPFORRwgsYGDLpLPxCKYcFxM, writable: false);
		}
		return result;
	}

	public int ReadByte()
	{
		int result = -1;
		if (OsWMtULSrBGOjJmDEkoBUguTlMpT < FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length && RGOrWVvLfTCeMIFQOFOWTKgCufBl + GUmyaPFORRwgsYGDLpLPxCKYcFxM > OsWMtULSrBGOjJmDEkoBUguTlMpT)
		{
			result = FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT];
			OsWMtULSrBGOjJmDEkoBUguTlMpT++;
		}
		return result;
	}

	private void spzfQGHhgkgnZOEAkCXqggwJpPCMB(int length)
	{
		if (RGOrWVvLfTCeMIFQOFOWTKgCufBl <= FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length && RGOrWVvLfTCeMIFQOFOWTKgCufBl >= 4)
		{
			if (OsWMtULSrBGOjJmDEkoBUguTlMpT > RGOrWVvLfTCeMIFQOFOWTKgCufBl + GUmyaPFORRwgsYGDLpLPxCKYcFxM - length)
			{
				throw new ZipException("End of extra data");
			}
			return;
		}
		throw new ZipException("Find must be called before calling a Read method");
	}

	public int ReadInt()
	{
		spzfQGHhgkgnZOEAkCXqggwJpPCMB(4);
		int result = FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT] + (FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT + 1] << 8) + (FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT + 2] << 16) + (FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT + 3] << 24);
		OsWMtULSrBGOjJmDEkoBUguTlMpT += 4;
		return result;
	}

	public long ReadLong()
	{
		spzfQGHhgkgnZOEAkCXqggwJpPCMB(8);
		return (ReadInt() & 0xFFFFFFFFL) | ((long)ReadInt() << 32);
	}

	public int ReadShort()
	{
		spzfQGHhgkgnZOEAkCXqggwJpPCMB(2);
		int result = FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT] + (FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT + 1] << 8);
		OsWMtULSrBGOjJmDEkoBUguTlMpT += 2;
		return result;
	}

	private int vvONuIMozGkVPZCuQkhFTZIXNYFt()
	{
		if (OsWMtULSrBGOjJmDEkoBUguTlMpT > FkHggXbLDEqQxMvZHZhQJzSzgSPtA.Length - 2)
		{
			throw new ZipException("End of extra data");
		}
		int result = FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT] + (FkHggXbLDEqQxMvZHZhQJzSzgSPtA[OsWMtULSrBGOjJmDEkoBUguTlMpT + 1] << 8);
		OsWMtULSrBGOjJmDEkoBUguTlMpT += 2;
		return result;
	}

	private void fCQmoTmSbgvfAOURxZohRWmHqnmF(ref int index, int source)
	{
		FkHggXbLDEqQxMvZHZhQJzSzgSPtA[index] = (byte)source;
		FkHggXbLDEqQxMvZHZhQJzSzgSPtA[index + 1] = (byte)(source >> 8);
		index += 2;
	}

	public void Skip(int amount)
	{
		spzfQGHhgkgnZOEAkCXqggwJpPCMB(amount);
		OsWMtULSrBGOjJmDEkoBUguTlMpT += amount;
	}

	public void StartNewEntry()
	{
		uWZipDmeejnJDqxIhmqUikKqhZCX = new MemoryStream();
	}
}
