using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class SoundFont
{
	private InfoChunk info;

	private PresetsChunk presetsChunk;

	private SampleDataChunk sampleData;

	[NonSerialized]
	internal static GetString _000E;

	public InfoChunk FileInfo => info;

	public Preset[] Presets => presetsChunk.Presets;

	public Instrument[] Instruments => presetsChunk.Instruments;

	public SampleHeader[] SampleHeaders => presetsChunk.SampleHeaders;

	public byte[] SampleData => sampleData.SampleData;

	public SoundFont(string fileName)
		: this(new FileStream(fileName, FileMode.Open, FileAccess.Read))
	{
	}

	public SoundFont(Stream sfFile)
	{
		using (sfFile)
		{
			RiffChunk topLevelChunk = RiffChunk.GetTopLevelChunk(new BinaryReader(sfFile));
			if (topLevelChunk.ChunkID == _000E(107393503))
			{
				string text = topLevelChunk.ReadChunkID();
				if (text != _000E(107393494))
				{
					throw new InvalidDataException(string.Format(_000E(107393453), text));
				}
				RiffChunk nextSubChunk = topLevelChunk.GetNextSubChunk();
				if (nextSubChunk.ChunkID == _000E(107393424))
				{
					info = new InfoChunk(nextSubChunk);
					RiffChunk nextSubChunk2 = topLevelChunk.GetNextSubChunk();
					sampleData = new SampleDataChunk(nextSubChunk2);
					nextSubChunk2 = topLevelChunk.GetNextSubChunk();
					presetsChunk = new PresetsChunk(nextSubChunk2);
					return;
				}
				throw new InvalidDataException(string.Format(_000E(107393415), nextSubChunk.ChunkID));
			}
			throw new InvalidDataException(_000E(107393410));
		}
	}

	public override string ToString()
	{
		return string.Format(_000E(107393357), info, presetsChunk);
	}

	static SoundFont()
	{
		Strings.CreateGetStringDelegate(typeof(SoundFont));
	}
}
