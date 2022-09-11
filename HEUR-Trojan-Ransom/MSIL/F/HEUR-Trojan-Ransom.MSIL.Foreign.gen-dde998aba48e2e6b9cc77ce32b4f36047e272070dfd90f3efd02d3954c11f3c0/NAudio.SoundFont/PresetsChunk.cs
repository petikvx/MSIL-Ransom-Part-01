using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class PresetsChunk
{
	private PresetBuilder presetHeaders = new PresetBuilder();

	private ZoneBuilder presetZones = new ZoneBuilder();

	private ModulatorBuilder presetZoneModulators = new ModulatorBuilder();

	private GeneratorBuilder presetZoneGenerators = new GeneratorBuilder();

	private InstrumentBuilder instruments = new InstrumentBuilder();

	private ZoneBuilder instrumentZones = new ZoneBuilder();

	private ModulatorBuilder instrumentZoneModulators = new ModulatorBuilder();

	private GeneratorBuilder instrumentZoneGenerators = new GeneratorBuilder();

	private SampleHeaderBuilder sampleHeaders = new SampleHeaderBuilder();

	[NonSerialized]
	internal static GetString _008E;

	public Preset[] Presets => presetHeaders.Presets;

	public Instrument[] Instruments => instruments.Instruments;

	public SampleHeader[] SampleHeaders => sampleHeaders.SampleHeaders;

	internal PresetsChunk(RiffChunk chunk)
	{
		string text = chunk.ReadChunkID();
		if (text != _008E(107394661))
		{
			throw new InvalidDataException(string.Format(_008E(107394652), text));
		}
		RiffChunk nextSubChunk;
		while ((nextSubChunk = chunk.GetNextSubChunk()) != null)
		{
			string chunkID = nextSubChunk.ChunkID;
			switch (_003CPrivateImplementationDetails_003E1.ComputeStringHash(chunkID))
			{
			case 454631123u:
				if (!(chunkID == _008E(107394643)))
				{
					break;
				}
				goto IL_0407;
			case 1912422739u:
				if (!(chunkID == _008E(107394602)))
				{
					break;
				}
				goto IL_0407;
			case 2630176223u:
				if (!(chunkID == _008E(107394593)))
				{
					break;
				}
				goto IL_0419;
			case 4036048543u:
				if (!(chunkID == _008E(107394616)))
				{
					break;
				}
				goto IL_0419;
			case 11082205u:
				if (!(chunkID == _008E(107394607)))
				{
					break;
				}
				goto IL_042b;
			case 1458428061u:
				if (!(chunkID == _008E(107394566)))
				{
					break;
				}
				goto IL_042b;
			case 3289792331u:
				if (!(chunkID == _008E(107394557)))
				{
					break;
				}
				goto IL_043a;
			case 3673816331u:
				if (!(chunkID == _008E(107394580)))
				{
					break;
				}
				goto IL_043a;
			case 1475086809u:
				if (!(chunkID == _008E(107394539)))
				{
					break;
				}
				goto IL_0449;
			case 446289113u:
				if (!(chunkID == _008E(107394530)))
				{
					break;
				}
				goto IL_0449;
			case 2688549226u:
				if (!(chunkID == _008E(107394553)))
				{
					break;
				}
				goto IL_0458;
			case 1659751530u:
				if (!(chunkID == _008E(107394544)))
				{
					break;
				}
				goto IL_0458;
			case 2770221016u:
				if (!(chunkID == _008E(107394503)))
				{
					break;
				}
				goto IL_0467;
			case 2815087768u:
				if (!(chunkID == _008E(107394494)))
				{
					break;
				}
				goto IL_0467;
			case 835588718u:
				if (!(chunkID == _008E(107394517)))
				{
					break;
				}
				goto IL_0476;
			case 880558638u:
				if (!(chunkID == _008E(107394508)))
				{
					break;
				}
				goto IL_0476;
			case 4189059956u:
				if (!(chunkID == _008E(107393955)))
				{
					break;
				}
				goto IL_0485;
			case 3160262260u:
				{
					if (!(chunkID == _008E(107393978)))
					{
						break;
					}
					goto IL_0485;
				}
				IL_0485:
				nextSubChunk.GetDataAsStructureArray(sampleHeaders);
				continue;
				IL_0476:
				nextSubChunk.GetDataAsStructureArray(instrumentZoneGenerators);
				continue;
				IL_0467:
				nextSubChunk.GetDataAsStructureArray(instrumentZoneModulators);
				continue;
				IL_0458:
				nextSubChunk.GetDataAsStructureArray(instrumentZones);
				continue;
				IL_0449:
				nextSubChunk.GetDataAsStructureArray(instruments);
				continue;
				IL_043a:
				nextSubChunk.GetDataAsStructureArray(presetZoneGenerators);
				continue;
				IL_042b:
				nextSubChunk.GetDataAsStructureArray(presetZoneModulators);
				continue;
				IL_0419:
				nextSubChunk.GetDataAsStructureArray(presetZones);
				continue;
				IL_0407:
				nextSubChunk.GetDataAsStructureArray(presetHeaders);
				continue;
			}
			throw new InvalidDataException(string.Format(_008E(107395203), nextSubChunk.ChunkID));
		}
		instrumentZoneGenerators.Load(sampleHeaders.SampleHeaders);
		instrumentZones.Load(instrumentZoneModulators.Modulators, instrumentZoneGenerators.Generators);
		instruments.LoadZones(instrumentZones.Zones);
		presetZoneGenerators.Load(instruments.Instruments);
		presetZones.Load(presetZoneModulators.Modulators, presetZoneGenerators.Generators);
		presetHeaders.LoadZones(presetZones.Zones);
		sampleHeaders.RemoveEOS();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_008E(107393969));
		Preset[] presets = presetHeaders.Presets;
		foreach (Preset arg in presets)
		{
			stringBuilder.AppendFormat(_008E(107393944), arg);
		}
		stringBuilder.Append(_008E(107393935));
		Instrument[] array = instruments.Instruments;
		foreach (Instrument arg2 in array)
		{
			stringBuilder.AppendFormat(_008E(107393944), arg2);
		}
		return stringBuilder.ToString();
	}

	static PresetsChunk()
	{
		Strings.CreateGetStringDelegate(typeof(PresetsChunk));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008E(107397421), _008E(107397384)), _008E(107397379), _008E(107397374)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008E(107397401)))
		{
			return;
		}
		throw new SecurityException(_008E(107397344));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
