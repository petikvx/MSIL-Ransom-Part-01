using System;
using System.IO;
using System.Text;

namespace NAudio.SoundFont;

internal sealed class PresetBuilder : StructureBuilder<Preset>
{
	private Preset lastPreset;

	public override int Length => 38;

	public Preset[] Presets => data.ToArray();

	public override Preset Read(BinaryReader br)
	{
		Preset preset = new Preset();
		string text = Encoding.UTF8.GetString(br.ReadBytes(20), 0, 20);
		if (text.IndexOf('\0') >= 0)
		{
			text = text.Substring(0, text.IndexOf('\0'));
		}
		preset.Name = text;
		preset.PatchNumber = br.ReadUInt16();
		preset.Bank = br.ReadUInt16();
		preset.startPresetZoneIndex = br.ReadUInt16();
		preset.library = br.ReadUInt32();
		preset.genre = br.ReadUInt32();
		preset.morphology = br.ReadUInt32();
		if (lastPreset != null)
		{
			lastPreset.endPresetZoneIndex = (ushort)(preset.startPresetZoneIndex - 1);
		}
		data.Add(preset);
		lastPreset = preset;
		return preset;
	}

	public override void Write(BinaryWriter bw, Preset preset)
	{
	}

	public void LoadZones(Zone[] presetZones)
	{
		for (int i = 0; i < data.Count - 1; i++)
		{
			Preset preset = data[i];
			preset.Zones = new Zone[preset.endPresetZoneIndex - preset.startPresetZoneIndex + 1];
			Array.Copy(presetZones, preset.startPresetZoneIndex, preset.Zones, 0, preset.Zones.Length);
		}
		data.RemoveAt(data.Count - 1);
	}
}
