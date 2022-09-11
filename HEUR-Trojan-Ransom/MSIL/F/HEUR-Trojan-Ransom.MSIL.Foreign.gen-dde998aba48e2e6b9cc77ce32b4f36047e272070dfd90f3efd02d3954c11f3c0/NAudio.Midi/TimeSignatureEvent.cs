using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class TimeSignatureEvent : MetaEvent
{
	private byte numerator;

	private byte denominator;

	private byte ticksInMetronomeClick;

	private byte no32ndNotesInQuarterNote;

	[NonSerialized]
	internal static GetString _0091;

	public int Numerator => numerator;

	public int Denominator => denominator;

	public int TicksInMetronomeClick => ticksInMetronomeClick;

	public int No32ndNotesInQuarterNote => no32ndNotesInQuarterNote;

	public string TimeSignature
	{
		get
		{
			string arg = string.Format(_0091(107409261), denominator);
			switch (denominator)
			{
			case 1:
				arg = _0091(107409272);
				break;
			case 2:
				arg = _0091(107409235);
				break;
			case 3:
				arg = _0091(107409230);
				break;
			case 4:
				arg = _0091(107409225);
				break;
			case 5:
				arg = _0091(107409252);
				break;
			}
			return string.Format(_0091(107409247), numerator, arg);
		}
	}

	public TimeSignatureEvent(BinaryReader br, int length)
	{
		if (length != 4)
		{
			throw new FormatException(string.Format(_0091(107409330), length));
		}
		numerator = br.ReadByte();
		denominator = br.ReadByte();
		ticksInMetronomeClick = br.ReadByte();
		no32ndNotesInQuarterNote = br.ReadByte();
	}

	public TimeSignatureEvent(long absoluteTime, int numerator, int denominator, int ticksInMetronomeClick, int no32ndNotesInQuarterNote)
		: base(MetaEventType.TimeSignature, 4, absoluteTime)
	{
		this.numerator = (byte)numerator;
		this.denominator = (byte)denominator;
		this.ticksInMetronomeClick = (byte)ticksInMetronomeClick;
		this.no32ndNotesInQuarterNote = (byte)no32ndNotesInQuarterNote;
	}

	public override MidiEvent Clone()
	{
		return (TimeSignatureEvent)MemberwiseClone();
	}

	public override string ToString()
	{
		return string.Format(_0091(107409202), base.ToString(), TimeSignature, ticksInMetronomeClick, no32ndNotesInQuarterNote);
	}

	public override void Export(ref long absoluteTime, BinaryWriter writer)
	{
		base.Export(ref absoluteTime, writer);
		writer.Write(numerator);
		writer.Write(denominator);
		writer.Write(ticksInMetronomeClick);
		writer.Write(no32ndNotesInQuarterNote);
	}

	static TimeSignatureEvent()
	{
		Strings.CreateGetStringDelegate(typeof(TimeSignatureEvent));
	}
}
