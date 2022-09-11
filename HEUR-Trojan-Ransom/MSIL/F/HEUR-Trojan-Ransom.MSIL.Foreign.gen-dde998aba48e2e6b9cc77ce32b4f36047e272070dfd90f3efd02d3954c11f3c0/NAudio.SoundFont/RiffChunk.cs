using System;
using System.IO;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class RiffChunk
{
	private string chunkID;

	private uint chunkSize;

	private long dataOffset;

	private BinaryReader riffFile;

	[NonSerialized]
	internal static GetString _009E;

	public string ChunkID
	{
		get
		{
			return chunkID;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(_009E(107394170));
			}
			if (value.Length != 4)
			{
				throw new ArgumentException(_009E(107394137));
			}
			chunkID = value;
		}
	}

	public uint ChunkSize => chunkSize;

	public long DataOffset => dataOffset;

	public static RiffChunk GetTopLevelChunk(BinaryReader file)
	{
		RiffChunk riffChunk = new RiffChunk(file);
		riffChunk.ReadChunk();
		return riffChunk;
	}

	private RiffChunk(BinaryReader file)
	{
		riffFile = file;
		chunkID = _009E(107393919);
		chunkSize = 0u;
		dataOffset = 0L;
	}

	public string ReadChunkID()
	{
		byte[] array = riffFile.ReadBytes(4);
		if (array.Length != 4)
		{
			throw new InvalidDataException(_009E(107393910));
		}
		return ByteEncoding.Instance.GetString(array, 0, array.Length);
	}

	private void ReadChunk()
	{
		chunkID = ReadChunkID();
		chunkSize = riffFile.ReadUInt32();
		dataOffset = riffFile.BaseStream.Position;
	}

	public RiffChunk GetNextSubChunk()
	{
		if (riffFile.BaseStream.Position + 8 < dataOffset + chunkSize)
		{
			RiffChunk riffChunk = new RiffChunk(riffFile);
			riffChunk.ReadChunk();
			return riffChunk;
		}
		return null;
	}

	public byte[] GetData()
	{
		riffFile.BaseStream.Position = dataOffset;
		byte[] array = riffFile.ReadBytes((int)chunkSize);
		if (array.Length != chunkSize)
		{
			throw new InvalidDataException(string.Format(_009E(107393877), this, array.Length));
		}
		return array;
	}

	public string GetDataAsString()
	{
		byte[] data = GetData();
		if (data == null)
		{
			return null;
		}
		return ByteEncoding.Instance.GetString(data, 0, data.Length);
	}

	public T GetDataAsStructure<T>(StructureBuilder<T> s)
	{
		riffFile.BaseStream.Position = dataOffset;
		if (s.Length != chunkSize)
		{
			throw new InvalidDataException(string.Format(_009E(107393772), chunkSize, s.Length));
		}
		return s.Read(riffFile);
	}

	public T[] GetDataAsStructureArray<T>(StructureBuilder<T> s)
	{
		riffFile.BaseStream.Position = dataOffset;
		if ((long)chunkSize % (long)s.Length != 0L)
		{
			throw new InvalidDataException(string.Format(_009E(107394215), chunkSize, s.Length));
		}
		int num = (int)((long)chunkSize / (long)s.Length);
		T[] array = new T[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = s.Read(riffFile);
		}
		return array;
	}

	public override string ToString()
	{
		return string.Format(_009E(107394060), ChunkID, ChunkSize, DataOffset);
	}

	static RiffChunk()
	{
		Strings.CreateGetStringDelegate(typeof(RiffChunk));
	}
}
