using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class TempoEvent : MetaEvent
{
	private int microsecondsPerQuarterNote;

	[NonSerialized]
	internal static GetString _008B;

	public int MicrosecondsPerQuarterNote
	{
		get
		{
			return microsecondsPerQuarterNote;
		}
		set
		{
			microsecondsPerQuarterNote = value;
		}
	}

	public double Tempo
	{
		get
		{
			return 60000000.0 / (double)microsecondsPerQuarterNote;
		}
		set
		{
			microsecondsPerQuarterNote = (int)(60000000.0 / value);
		}
	}

	public TempoEvent(BinaryReader br, int length)
	{
		if (length != 3)
		{
			throw new FormatException(_008B(107409377));
		}
		microsecondsPerQuarterNote = (br.ReadByte() << 16) + (br.ReadByte() << 8) + br.ReadByte();
	}

	public TempoEvent(int microsecondsPerQuarterNote, long absoluteTime)
		: base(MetaEventType.SetTempo, 3, absoluteTime)
	{
		this.microsecondsPerQuarterNote = microsecondsPerQuarterNote;
	}

	public override MidiEvent Clone()
	{
		return (TempoEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_008B(107409348), base.ToString(), microsecondsPerQuarterNote, 60000000 / microsecondsPerQuarterNote);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write((byte)((uint)(microsecondsPerQuarterNote >> 16) & 0xFFu));
		writer.Write((byte)((uint)(microsecondsPerQuarterNote >> 8) & 0xFFu));
		writer.Write((byte)((uint)microsecondsPerQuarterNote & 0xFFu));
	}

	static TempoEvent()
	{
		Strings.CreateGetStringDelegate(typeof(TempoEvent));
	}
}
