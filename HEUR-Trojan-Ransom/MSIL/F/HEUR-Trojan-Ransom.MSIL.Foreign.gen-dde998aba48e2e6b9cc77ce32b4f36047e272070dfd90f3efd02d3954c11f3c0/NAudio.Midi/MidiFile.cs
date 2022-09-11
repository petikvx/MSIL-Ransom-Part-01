using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Midi;

public sealed class MidiFile
{
	private MidiEventCollection events;

	private ushort fileFormat;

	private ushort deltaTicksPerQuarterNote;

	private bool strictChecking;

	[NonSerialized]
	internal static GetString _009C;

	public int FileFormat => fileFormat;

	public MidiEventCollection Events => events;

	public int Tracks => events.Tracks;

	public int DeltaTicksPerQuarterNote => deltaTicksPerQuarterNote;

	public MidiFile(string filename)
		: this(filename, strictChecking: true)
	{
	}

	public MidiFile(string filename, bool strictChecking)
	{
		this.strictChecking = strictChecking;
		BinaryReader binaryReader = new BinaryReader(File.OpenRead(filename));
		using (binaryReader)
		{
			if (Encoding.UTF8.GetString(binaryReader.ReadBytes(4)) != _009C(107413624))
			{
				throw new FormatException(_009C(107413583));
			}
			uint num = SwapUInt32(binaryReader.ReadUInt32());
			if (num != 6)
			{
				throw new FormatException(_009C(107413562));
			}
			fileFormat = SwapUInt16(binaryReader.ReadUInt16());
			int num2 = SwapUInt16(binaryReader.ReadUInt16());
			deltaTicksPerQuarterNote = SwapUInt16(binaryReader.ReadUInt16());
			events = new MidiEventCollection((fileFormat != 0) ? 1 : 0, deltaTicksPerQuarterNote);
			for (int i = 0; i < num2; i++)
			{
				events.AddTrack();
			}
			long num3 = 0L;
			for (int j = 0; j < num2; j++)
			{
				if (fileFormat == 1)
				{
					num3 = 0L;
				}
				if (Encoding.UTF8.GetString(binaryReader.ReadBytes(4)) != _009C(107413489))
				{
					throw new FormatException(_009C(107413480));
				}
				num = SwapUInt32(binaryReader.ReadUInt32());
				long position = binaryReader.BaseStream.Position;
				MidiEvent midiEvent = null;
				List<NoteOnEvent> list = new List<NoteOnEvent>();
				while (binaryReader.BaseStream.Position < position + num)
				{
					midiEvent = MidiEvent.ReadNextEvent(binaryReader, midiEvent);
					num3 = (midiEvent.AbsoluteTime = num3 + midiEvent.DeltaTime);
					events[j].Add(midiEvent);
					if (midiEvent.CommandCode == MidiCommandCode.NoteOn)
					{
						NoteEvent noteEvent = (NoteEvent)midiEvent;
						if (noteEvent.Velocity > 0)
						{
							list.Add((NoteOnEvent)noteEvent);
						}
						else
						{
							FindNoteOn(noteEvent, list);
						}
					}
					else if (midiEvent.CommandCode == MidiCommandCode.NoteOff)
					{
						FindNoteOn((NoteEvent)midiEvent, list);
					}
					else if (midiEvent.CommandCode == MidiCommandCode.MetaEvent && ((MetaEvent)midiEvent).MetaEventType == MetaEventType.EndTrack && strictChecking && binaryReader.BaseStream.Position < position + num)
					{
						throw new FormatException(string.Format(_009C(107413451), j));
					}
				}
				if (list.Count > 0 && strictChecking)
				{
					throw new FormatException(string.Format(_009C(107413918), list.Count, fileFormat));
				}
				if (binaryReader.BaseStream.Position != position + num)
				{
					throw new FormatException(string.Format(_009C(107413853), num, position, binaryReader.BaseStream.Position));
				}
			}
		}
	}

	private void FindNoteOn(NoteEvent offEvent, List<NoteOnEvent> outstandingNoteOns)
	{
		bool flag = false;
		foreach (NoteOnEvent outstandingNoteOn in outstandingNoteOns)
		{
			if (outstandingNoteOn.Channel == offEvent.Channel && outstandingNoteOn.NoteNumber == offEvent.NoteNumber)
			{
				outstandingNoteOn.OffEvent = offEvent;
				outstandingNoteOns.Remove(outstandingNoteOn);
				flag = true;
				break;
			}
		}
		if (!flag && strictChecking)
		{
			throw new FormatException(string.Format(_009C(107413816), offEvent));
		}
	}

	private static uint SwapUInt32(uint i)
	{
		return ((i & 0xFF000000u) >> 24) | ((i & 0xFF0000) >> 8) | ((i & 0xFF00) << 8) | ((i & 0xFF) << 24);
	}

	private static ushort SwapUInt16(ushort i)
	{
		return (ushort)(((i & 0xFF00) >> 8) | ((i & 0xFF) << 8));
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(_009C(107413743), fileFormat, Tracks, deltaTicksPerQuarterNote);
		for (int i = 0; i < Tracks; i++)
		{
			foreach (MidiEvent item in events[i])
			{
				stringBuilder.AppendFormat(_009C(107395710), item);
			}
		}
		return stringBuilder.ToString();
	}

	public static void Export(string filename, MidiEventCollection events)
	{
		if (events.MidiFileType == 0 && events.Tracks > 1)
		{
			throw new ArgumentException(_009C(107413694));
		}
		using BinaryWriter binaryWriter = new BinaryWriter(File.Create(filename));
		binaryWriter.Write(Encoding.UTF8.GetBytes(_009C(107413624)));
		binaryWriter.Write(SwapUInt32(6u));
		binaryWriter.Write(SwapUInt16((ushort)events.MidiFileType));
		binaryWriter.Write(SwapUInt16((ushort)events.Tracks));
		binaryWriter.Write(SwapUInt16((ushort)events.DeltaTicksPerQuarterNote));
		for (int i = 0; i < events.Tracks; i++)
		{
			IList<MidiEvent> list = events[i];
			binaryWriter.Write(Encoding.UTF8.GetBytes(_009C(107413489)));
			long position = binaryWriter.BaseStream.Position;
			binaryWriter.Write(SwapUInt32(0u));
			long absoluteTime = events.StartAbsoluteTime;
			MergeSort.Sort(list, new MidiEventComparer());
			_ = list.Count;
			_ = 0;
			foreach (MidiEvent item in list)
			{
				item.Export(ref absoluteTime, binaryWriter);
			}
			uint num = (uint)((int)(binaryWriter.BaseStream.Position - position) - 4);
			binaryWriter.BaseStream.Position = position;
			binaryWriter.Write(SwapUInt32(num));
			binaryWriter.BaseStream.Position += num;
		}
	}

	static MidiFile()
	{
		Strings.CreateGetStringDelegate(typeof(MidiFile));
	}
}
