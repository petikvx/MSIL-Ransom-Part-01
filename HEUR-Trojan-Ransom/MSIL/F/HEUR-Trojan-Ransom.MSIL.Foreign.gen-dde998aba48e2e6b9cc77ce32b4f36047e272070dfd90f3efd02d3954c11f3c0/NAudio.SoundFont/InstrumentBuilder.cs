using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

internal sealed class InstrumentBuilder : StructureBuilder<Instrument>
{
	private Instrument lastInstrument;

	[NonSerialized]
	internal static GetString _0002;

	public override int Length => 22;

	public Instrument[] Instruments => data.ToArray();

	public override Instrument Read(BinaryReader br)
	{
		Instrument instrument = new Instrument();
		string text = Encoding.UTF8.GetString(br.ReadBytes(20), 0, 20);
		if (text.IndexOf('\0') >= 0)
		{
			text = text.Substring(0, text.IndexOf('\0'));
		}
		instrument.Name = text;
		instrument.startInstrumentZoneIndex = br.ReadUInt16();
		if (lastInstrument != null)
		{
			lastInstrument.endInstrumentZoneIndex = (ushort)(instrument.startInstrumentZoneIndex - 1);
		}
		data.Add(instrument);
		lastInstrument = instrument;
		return instrument;
	}

	public override void Write(BinaryWriter bw, Instrument instrument)
	{
	}

	public void LoadZones(Zone[] zones)
	{
		for (int i = 0; i < data.Count - 1; i++)
		{
			Instrument instrument = data[i];
			instrument.Zones = new Zone[instrument.endInstrumentZoneIndex - instrument.startInstrumentZoneIndex + 1];
			Array.Copy(zones, instrument.startInstrumentZoneIndex, instrument.Zones, 0, instrument.Zones.Length);
		}
		data.RemoveAt(data.Count - 1);
	}

	static InstrumentBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(InstrumentBuilder));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0002(107397371), _0002(107397334)), _0002(107397329), _0002(107397324)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0002(107397351)))
		{
			return;
		}
		throw new SecurityException(_0002(107397294));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
