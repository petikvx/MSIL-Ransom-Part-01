using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class MidiMessage
{
	private int rawData;

	[NonSerialized]
	internal static GetString _000F;

	public int RawData => rawData;

	public MidiMessage(int status, int data1, int data2)
	{
		rawData = status + (data1 << 8) + (data2 << 16);
	}

	public MidiMessage(int rawData)
	{
		this.rawData = rawData;
	}

	public static MidiMessage StartNote(int note, int volume, int channel)
	{
		ValidateNoteParameters(note, volume, channel);
		return new MidiMessage(144 + channel - 1, note, volume);
	}

	private static void ValidateNoteParameters(int note, int volume, int channel)
	{
		ValidateChannel(channel);
		if (note < 0 || note > 127)
		{
			throw new ArgumentOutOfRangeException(_000F(107413065), _000F(107413056));
		}
		if (volume < 0 || volume > 127)
		{
			throw new ArgumentOutOfRangeException(_000F(107413003), _000F(107412994));
		}
	}

	private static void ValidateChannel(int channel)
	{
		if (channel < 1 || channel > 16)
		{
			throw new ArgumentOutOfRangeException(_000F(107413425), channel, string.Format(_000F(107414407), channel));
		}
	}

	public static MidiMessage StopNote(int note, int volume, int channel)
	{
		ValidateNoteParameters(note, volume, channel);
		return new MidiMessage(128 + channel - 1, note, volume);
	}

	public static MidiMessage ChangePatch(int patch, int channel)
	{
		ValidateChannel(channel);
		return new MidiMessage(192 + channel - 1, patch, 0);
	}

	public static MidiMessage ChangeControl(int controller, int value, int channel)
	{
		ValidateChannel(channel);
		return new MidiMessage(176 + channel - 1, controller, value);
	}

	static MidiMessage()
	{
		Strings.CreateGetStringDelegate(typeof(MidiMessage));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _000F(107399232), _000F(107399195)), _000F(107399190), _000F(107399185)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _000F(107399212)))
		{
			return;
		}
		throw new SecurityException(_000F(107399155));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
