using System.Collections;
using System.Collections.Generic;
using NAudio.Utils;

namespace NAudio.Midi;

public sealed class MidiEventCollection : IEnumerable, IEnumerable<IList<MidiEvent>>
{
	private int midiFileType;

	private List<IList<MidiEvent>> trackEvents;

	private int deltaTicksPerQuarterNote;

	private long startAbsoluteTime;

	public int Tracks => trackEvents.Count;

	public long StartAbsoluteTime
	{
		get
		{
			return startAbsoluteTime;
		}
		set
		{
			startAbsoluteTime = value;
		}
	}

	public int DeltaTicksPerQuarterNote => deltaTicksPerQuarterNote;

	public IList<MidiEvent> this[int trackNumber] => trackEvents[trackNumber];

	public int MidiFileType
	{
		get
		{
			return midiFileType;
		}
		set
		{
			if (midiFileType != value)
			{
				midiFileType = value;
				if (value == 0)
				{
					FlattenToOneTrack();
				}
				else
				{
					ExplodeToManyTracks();
				}
			}
		}
	}

	public MidiEventCollection(int midiFileType, int deltaTicksPerQuarterNote)
	{
		this.midiFileType = midiFileType;
		this.deltaTicksPerQuarterNote = deltaTicksPerQuarterNote;
		startAbsoluteTime = 0L;
		trackEvents = new List<IList<MidiEvent>>();
	}

	public IList<MidiEvent> GetTrackEvents(int trackNumber)
	{
		return trackEvents[trackNumber];
	}

	public IList<MidiEvent> AddTrack()
	{
		return AddTrack(null);
	}

	public IList<MidiEvent> AddTrack(IList<MidiEvent> initialEvents)
	{
		List<MidiEvent> list = new List<MidiEvent>();
		if (initialEvents != null)
		{
			list.AddRange(initialEvents);
		}
		trackEvents.Add(list);
		return list;
	}

	public void RemoveTrack(int track)
	{
		trackEvents.RemoveAt(track);
	}

	public void Clear()
	{
		trackEvents.Clear();
	}

	public void AddEvent(MidiEvent midiEvent, int originalTrack)
	{
		if (midiFileType == 0)
		{
			EnsureTracks(1);
			trackEvents[0].Add(midiEvent);
		}
		else if (originalTrack == 0)
		{
			switch (midiEvent.CommandCode)
			{
			case MidiCommandCode.NoteOff:
			case MidiCommandCode.NoteOn:
			case MidiCommandCode.KeyAfterTouch:
			case MidiCommandCode.ControlChange:
			case MidiCommandCode.PatchChange:
			case MidiCommandCode.ChannelAfterTouch:
			case MidiCommandCode.PitchWheelChange:
				EnsureTracks(midiEvent.Channel + 1);
				trackEvents[midiEvent.Channel].Add(midiEvent);
				break;
			default:
				EnsureTracks(1);
				trackEvents[0].Add(midiEvent);
				break;
			}
		}
		else
		{
			EnsureTracks(originalTrack + 1);
			trackEvents[originalTrack].Add(midiEvent);
		}
	}

	private void EnsureTracks(int count)
	{
		for (int i = trackEvents.Count; i < count; i++)
		{
			trackEvents.Add(new List<MidiEvent>());
		}
	}

	private void ExplodeToManyTracks()
	{
		IList<MidiEvent> list = trackEvents[0];
		Clear();
		foreach (MidiEvent item in list)
		{
			AddEvent(item, 0);
		}
		PrepareForExport();
	}

	private void FlattenToOneTrack()
	{
		bool flag = false;
		for (int i = 1; i < trackEvents.Count; i++)
		{
			foreach (MidiEvent item in trackEvents[i])
			{
				if (!MidiEvent.IsEndTrack(item))
				{
					trackEvents[0].Add(item);
					flag = true;
				}
			}
		}
		for (int num = trackEvents.Count - 1; num > 0; num--)
		{
			RemoveTrack(num);
		}
		if (flag)
		{
			PrepareForExport();
		}
	}

	public void PrepareForExport()
	{
		MidiEventComparer comparer = new MidiEventComparer();
		foreach (List<MidiEvent> trackEvent in trackEvents)
		{
			MergeSort.Sort(trackEvent, comparer);
			int num = 0;
			while (num < trackEvent.Count - 1)
			{
				if (MidiEvent.IsEndTrack(trackEvent[num]))
				{
					trackEvent.RemoveAt(num);
				}
				else
				{
					num++;
				}
			}
		}
		int num2 = 0;
		while (num2 < trackEvents.Count)
		{
			IList<MidiEvent> list2 = trackEvents[num2];
			if (list2.Count == 0)
			{
				RemoveTrack(num2);
				continue;
			}
			if (list2.Count == 1 && MidiEvent.IsEndTrack(list2[0]))
			{
				RemoveTrack(num2);
				continue;
			}
			if (!MidiEvent.IsEndTrack(list2[list2.Count - 1]))
			{
				list2.Add(new MetaEvent(MetaEventType.EndTrack, 0, list2[list2.Count - 1].AbsoluteTime));
			}
			num2++;
		}
	}

	public IEnumerator<IList<MidiEvent>> GetEnumerator()
	{
		return trackEvents.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return trackEvents.GetEnumerator();
	}
}
