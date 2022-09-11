using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class TrackSequenceNumberEvent : MetaEvent
{
	private ushort sequenceNumber;

	[NonSerialized]
	internal static GetString _0094;

	public TrackSequenceNumberEvent(ushort sequenceNumber)
	{
		this.sequenceNumber = sequenceNumber;
	}

	public TrackSequenceNumberEvent(BinaryReader br, int length)
	{
		if (length != 2)
		{
			throw new FormatException(_0094(107408627));
		}
		sequenceNumber = (ushort)((br.ReadByte() << 8) + br.ReadByte());
	}

	public override MidiEvent Clone()
	{
		return (TrackSequenceNumberEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_0094(107397701), base.ToString(), sequenceNumber);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write((byte)((uint)(sequenceNumber >> 8) & 0xFFu));
		writer.Write((byte)(sequenceNumber & 0xFFu));
	}

	static TrackSequenceNumberEvent()
	{
		Strings.CreateGetStringDelegate(typeof(TrackSequenceNumberEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0094(107399291), _0094(107399254)), _0094(107399249), _0094(107399244)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0094(107399271)))
		{
			return;
		}
		throw new SecurityException(_0094(107399214));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
