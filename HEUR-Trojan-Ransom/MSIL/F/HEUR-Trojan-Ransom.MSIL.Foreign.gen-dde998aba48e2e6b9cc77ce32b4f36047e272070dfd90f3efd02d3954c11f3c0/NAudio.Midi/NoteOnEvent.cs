using System;
using System.IO;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class NoteOnEvent : NoteEvent
{
	private NoteEvent offEvent;

	[NonSerialized]
	internal static GetString _001C;

	public NoteEvent OffEvent
	{
		get
		{
			return offEvent;
		}
		set
		{
			if (!MidiEvent.IsNoteOff(value))
			{
				throw new ArgumentException(_001C(107412382));
			}
			if (value.NoteNumber != NoteNumber)
			{
				throw new ArgumentException(_001C(107412353));
			}
			if (value.Channel != Channel)
			{
				throw new ArgumentException(_001C(107412288));
			}
			offEvent = value;
		}
	}

	public override int NoteNumber
	{
		get
		{
			return base.NoteNumber;
		}
		set
		{
			base.NoteNumber = value;
			if (OffEvent != null)
			{
				OffEvent.NoteNumber = NoteNumber;
			}
		}
	}

	public override int Channel
	{
		get
		{
			return base.Channel;
		}
		set
		{
			base.Channel = value;
			if (OffEvent != null)
			{
				OffEvent.Channel = Channel;
			}
		}
	}

	public int NoteLength
	{
		get
		{
			return (int)(offEvent.AbsoluteTime - base.AbsoluteTime);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException(_001C(107412227));
			}
			offEvent.AbsoluteTime = base.AbsoluteTime + value;
		}
	}

	public NoteOnEvent(BinaryReader br)
		: base(br)
	{
	}

	public NoteOnEvent(long absoluteTime, int channel, int noteNumber, int velocity, int duration)
		: base(absoluteTime, channel, MidiCommandCode.NoteOn, noteNumber, velocity)
	{
		OffEvent = new NoteEvent(absoluteTime, channel, MidiCommandCode.NoteOff, noteNumber, 0);
		NoteLength = duration;
	}

	public override MidiEvent Clone()
	{
		return new NoteOnEvent(base.AbsoluteTime, Channel, NoteNumber, base.Velocity, NoteLength);
	}

	public override string ToString()
	{
		if (base.Velocity == 0 && OffEvent == null)
		{
			return string.Format(_001C(107411638), base.ToString());
		}
		return string.Format(_001C(107411649), base.ToString(), (OffEvent == null) ? _001C(107411600) : NoteLength.ToString());
	}

	static NoteOnEvent()
	{
		Strings.CreateGetStringDelegate(typeof(NoteOnEvent));
	}
}
