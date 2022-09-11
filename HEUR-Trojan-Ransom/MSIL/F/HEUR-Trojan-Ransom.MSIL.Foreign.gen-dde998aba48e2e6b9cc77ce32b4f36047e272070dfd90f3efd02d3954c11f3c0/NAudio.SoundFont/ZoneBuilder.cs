using System;
using System.IO;

namespace NAudio.SoundFont;

internal sealed class ZoneBuilder : StructureBuilder<Zone>
{
	private Zone lastZone;

	public Zone[] Zones => data.ToArray();

	public override int Length => 4;

	public override Zone Read(BinaryReader br)
	{
		Zone zone = new Zone();
		zone.generatorIndex = br.ReadUInt16();
		zone.modulatorIndex = br.ReadUInt16();
		if (lastZone != null)
		{
			lastZone.generatorCount = (ushort)(zone.generatorIndex - lastZone.generatorIndex);
			lastZone.modulatorCount = (ushort)(zone.modulatorIndex - lastZone.modulatorIndex);
		}
		data.Add(zone);
		lastZone = zone;
		return zone;
	}

	public override void Write(BinaryWriter bw, Zone zone)
	{
	}

	public void Load(Modulator[] modulators, Generator[] generators)
	{
		for (int i = 0; i < data.Count - 1; i++)
		{
			Zone zone = data[i];
			zone.Generators = new Generator[zone.generatorCount];
			Array.Copy(generators, zone.generatorIndex, zone.Generators, 0, zone.generatorCount);
			zone.Modulators = new Modulator[zone.modulatorCount];
			Array.Copy(modulators, zone.modulatorIndex, zone.Modulators, 0, zone.modulatorCount);
		}
		data.RemoveAt(data.Count - 1);
	}
}
