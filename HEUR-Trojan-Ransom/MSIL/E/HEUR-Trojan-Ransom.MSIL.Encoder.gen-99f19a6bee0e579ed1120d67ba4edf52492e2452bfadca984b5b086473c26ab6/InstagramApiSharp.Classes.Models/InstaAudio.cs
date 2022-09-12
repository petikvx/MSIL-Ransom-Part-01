using System;

namespace InstagramApiSharp.Classes.Models;

public class InstaAudio
{
	private double _duration;

	public string AudioSource { get; set; }

	public double Duration
	{
		get
		{
			return _duration;
		}
		set
		{
			_duration = value;
			DurationTs = TimeSpan.FromMilliseconds(value);
		}
	}

	public TimeSpan DurationTs { get; set; }

	public float[] WaveformData { get; set; }

	public int WaveformSamplingFrequencyHz { get; set; }
}
