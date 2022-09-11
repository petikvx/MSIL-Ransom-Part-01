using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class KeySignatureEvent : MetaEvent
{
	private byte sharpsFlats;

	private byte majorMinor;

	[NonSerialized]
	internal static GetString _001D;

	public int SharpsFlats => sharpsFlats;

	public int MajorMinor => majorMinor;

	public KeySignatureEvent(BinaryReader br, int length)
	{
		if (length != 2)
		{
			throw new FormatException(_001D(107414043));
		}
		sharpsFlats = br.ReadByte();
		majorMinor = br.ReadByte();
	}

	public KeySignatureEvent(int sharpsFlats, int majorMinor, long absoluteTime)
		: base(MetaEventType.KeySignature, 2, absoluteTime)
	{
		this.sharpsFlats = (byte)sharpsFlats;
		this.majorMinor = (byte)majorMinor;
	}

	public override MidiEvent Clone()
	{
		return (KeySignatureEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_001D(107413970), base.ToString(), sharpsFlats, majorMinor);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(sharpsFlats);
		writer.Write(majorMinor);
	}

	static KeySignatureEvent()
	{
		Strings.CreateGetStringDelegate(typeof(KeySignatureEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001D(107399126), _001D(107399089)), _001D(107399084), _001D(107399079)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001D(107399106)))
		{
			return;
		}
		throw new SecurityException(_001D(107399049));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
