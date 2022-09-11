using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class PitchWheelChangeEvent : MidiEvent
{
	private int pitch;

	[NonSerialized]
	internal static GetString _0081;

	public int Pitch
	{
		get
		{
			return pitch;
		}
		set
		{
			if (value < 0 || value >= 16384)
			{
				throw new ArgumentOutOfRangeException(_0081(107392499), _0081(107409099));
			}
			pitch = value;
		}
	}

	public PitchWheelChangeEvent(BinaryReader br)
	{
		byte b = br.ReadByte();
		byte b2 = br.ReadByte();
		if ((b & 0x80u) != 0)
		{
			throw new FormatException(_0081(107409698));
		}
		if ((b2 & 0x80u) != 0)
		{
			throw new FormatException(_0081(107409653));
		}
		pitch = b + (b2 << 7);
	}

	public PitchWheelChangeEvent(long absoluteTime, int channel, int pitchWheel)
		: base(absoluteTime, channel, MidiCommandCode.PitchWheelChange)
	{
		Pitch = pitchWheel;
	}

	public override string ToString()
	{
		return string.Format(_0081(107409128), base.ToString(), pitch, pitch - 8192);
	}

	public override int GetAsShortMessage()
	{
		return base.GetAsShortMessage() + ((pitch & 0x7F) << 8) + (((pitch >> 7) & 0x7F) << 16);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write((byte)((uint)pitch & 0x7Fu));
		writer.Write((byte)((uint)(pitch >> 7) & 0x7Fu));
	}

	static PitchWheelChangeEvent()
	{
		Strings.CreateGetStringDelegate(typeof(PitchWheelChangeEvent));
	}
}
