using System.IO;

namespace NAudio.SoundFont;

internal sealed class GeneratorBuilder : StructureBuilder<Generator>
{
	public override int Length => 4;

	public Generator[] Generators => data.ToArray();

	public override Generator Read(BinaryReader br)
	{
		Generator generator = new Generator();
		generator.GeneratorType = (GeneratorEnum)br.ReadUInt16();
		generator.UInt16Amount = br.ReadUInt16();
		data.Add(generator);
		return generator;
	}

	public override void Write(BinaryWriter bw, Generator o)
	{
	}

	public void Load(Instrument[] instruments)
	{
		Generator[] generators = Generators;
		foreach (Generator generator in generators)
		{
			if (generator.GeneratorType == GeneratorEnum.Instrument)
			{
				generator.Instrument = instruments[generator.UInt16Amount];
			}
		}
	}

	public void Load(SampleHeader[] sampleHeaders)
	{
		Generator[] generators = Generators;
		foreach (Generator generator in generators)
		{
			if (generator.GeneratorType == GeneratorEnum.SampleID)
			{
				generator.SampleHeader = sampleHeaders[generator.UInt16Amount];
			}
		}
	}
}
