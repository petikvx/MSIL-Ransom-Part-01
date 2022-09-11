using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

internal sealed class SmpteOffsetEvent : MetaEvent
{
	private byte hours;

	private byte minutes;

	private byte seconds;

	private byte frames;

	private byte subFrames;

	[NonSerialized]
	internal static GetString _009A;

	public int Hours => hours;

	public int Minutes => minutes;

	public int Seconds => seconds;

	public int Frames => frames;

	public int SubFrames => subFrames;

	public SmpteOffsetEvent(byte hours, byte minutes, byte seconds, byte frames, byte subFrames)
	{
		this.hours = hours;
		this.minutes = minutes;
		this.seconds = seconds;
		this.frames = frames;
		this.subFrames = subFrames;
	}

	public SmpteOffsetEvent(BinaryReader br, int length)
	{
		if (length != 5)
		{
			throw new FormatException(string.Format(_009A(107408996), length));
		}
		hours = br.ReadByte();
		minutes = br.ReadByte();
		seconds = br.ReadByte();
		frames = br.ReadByte();
		subFrames = br.ReadByte();
	}

	public override MidiEvent Clone()
	{
		return (SmpteOffsetEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_009A(107408931), base.ToString(), hours, minutes, seconds, frames, subFrames);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(hours);
		writer.Write(minutes);
		writer.Write(seconds);
		writer.Write(frames);
		writer.Write(subFrames);
	}

	static SmpteOffsetEvent()
	{
		Strings.CreateGetStringDelegate(typeof(SmpteOffsetEvent));
	}
}
