using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.FileFormats.Wav;

internal sealed class WaveFileChunkReader
{
	private WaveFormat waveFormat;

	private long dataChunkPosition;

	private long dataChunkLength;

	private List<RiffChunk> riffChunks;

	private readonly bool strictMode;

	private bool isRf64;

	private readonly bool storeAllChunks;

	private long riffSize;

	[NonSerialized]
	internal static GetString _0008;

	public WaveFormat WaveFormat => waveFormat;

	public long DataChunkPosition => dataChunkPosition;

	public long DataChunkLength => dataChunkLength;

	public List<RiffChunk> RiffChunks => riffChunks;

	public WaveFileChunkReader()
	{
		storeAllChunks = true;
		strictMode = false;
	}

	public void ReadWaveHeader(Stream stream)
	{
		dataChunkPosition = -1L;
		waveFormat = null;
		riffChunks = new List<RiffChunk>();
		dataChunkLength = 0L;
		BinaryReader binaryReader = new BinaryReader(stream);
		ReadRiffHeader(binaryReader);
		riffSize = binaryReader.ReadUInt32();
		if (binaryReader.ReadInt32() != ChunkIdentifier.ChunkIdentifierToInt32(_0008(107390075)))
		{
			throw new FormatException(_0008(107404474));
		}
		if (isRf64)
		{
			ReadDs64Chunk(binaryReader);
		}
		int num = ChunkIdentifier.ChunkIdentifierToInt32(_0008(107390057));
		int num2 = ChunkIdentifier.ChunkIdentifierToInt32(_0008(107390098));
		long num3 = Math.Min(riffSize + 8, stream.Length);
		while (stream.Position <= num3 - 8)
		{
			int num4 = binaryReader.ReadInt32();
			uint num5 = binaryReader.ReadUInt32();
			if (num4 == num)
			{
				dataChunkPosition = stream.Position;
				if (!isRf64)
				{
					dataChunkLength = num5;
				}
				stream.Position += num5;
				continue;
			}
			if (num4 == num2)
			{
				if (num5 > int.MaxValue)
				{
					throw new InvalidDataException(string.Format(_0008(107404941), int.MaxValue));
				}
				waveFormat = WaveFormat.FromFormatChunk(binaryReader, (int)num5);
				continue;
			}
			if (num5 > stream.Length - stream.Position)
			{
				if (!strictMode)
				{
				}
				break;
			}
			if (storeAllChunks)
			{
				if (num5 > int.MaxValue)
				{
					throw new InvalidDataException(string.Format(_0008(107404876), int.MaxValue));
				}
				riffChunks.Add(GetRiffChunk(stream, num4, (int)num5));
			}
			stream.Position += num5;
		}
		if (waveFormat == null)
		{
			throw new FormatException(_0008(107404775));
		}
		if (dataChunkPosition == -1)
		{
			throw new FormatException(_0008(107404754));
		}
	}

	private void ReadDs64Chunk(BinaryReader reader)
	{
		int num = ChunkIdentifier.ChunkIdentifierToInt32(_0008(107404157));
		if (reader.ReadInt32() != num)
		{
			throw new FormatException(_0008(107404180));
		}
		int num2 = reader.ReadInt32();
		riffSize = reader.ReadInt64();
		dataChunkLength = reader.ReadInt64();
		reader.ReadInt64();
		reader.ReadBytes(num2 - 24);
	}

	private static RiffChunk GetRiffChunk(Stream stream, int chunkIdentifier, int chunkLength)
	{
		return new RiffChunk(chunkIdentifier, chunkLength, stream.Position);
	}

	private void ReadRiffHeader(BinaryReader br)
	{
		int num = br.ReadInt32();
		if (num == ChunkIdentifier.ChunkIdentifierToInt32(_0008(107404119)))
		{
			isRf64 = true;
		}
		else if (num != ChunkIdentifier.ChunkIdentifierToInt32(_0008(107395991)))
		{
			throw new FormatException(_0008(107404110));
		}
	}

	static WaveFileChunkReader()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFileChunkReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0008(107399948), _0008(107399911)), _0008(107399906), _0008(107399901)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0008(107399928)))
		{
			return;
		}
		throw new SecurityException(_0008(107399871));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
