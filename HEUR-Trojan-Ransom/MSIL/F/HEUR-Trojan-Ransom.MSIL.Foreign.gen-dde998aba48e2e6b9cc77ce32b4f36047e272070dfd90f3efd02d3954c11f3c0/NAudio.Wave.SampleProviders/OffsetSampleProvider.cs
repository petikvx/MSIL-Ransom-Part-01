using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

public sealed class OffsetSampleProvider : ISampleProvider
{
	private readonly ISampleProvider sourceProvider;

	private int phase;

	private int phasePos;

	private int delayBySamples;

	private int skipOverSamples;

	private int takeSamples;

	private int leadOutSamples;

	[NonSerialized]
	internal static GetString _0013;

	public int DelayBySamples
	{
		get
		{
			return delayBySamples;
		}
		set
		{
			if (phase != 0)
			{
				throw new InvalidOperationException(_0013(107384541));
			}
			if (value % WaveFormat.Channels != 0)
			{
				throw new ArgumentException(_0013(107384480));
			}
			delayBySamples = value;
		}
	}

	public TimeSpan DelayBy
	{
		get
		{
			return SamplesToTimeSpan(delayBySamples);
		}
		set
		{
			delayBySamples = TimeSpanToSamples(value);
		}
	}

	public int SkipOverSamples
	{
		get
		{
			return skipOverSamples;
		}
		set
		{
			if (phase != 0)
			{
				throw new InvalidOperationException(_0013(107383891));
			}
			if (value % WaveFormat.Channels != 0)
			{
				throw new ArgumentException(_0013(107383830));
			}
			skipOverSamples = value;
		}
	}

	public TimeSpan SkipOver
	{
		get
		{
			return SamplesToTimeSpan(skipOverSamples);
		}
		set
		{
			skipOverSamples = TimeSpanToSamples(value);
		}
	}

	public int TakeSamples
	{
		get
		{
			return takeSamples;
		}
		set
		{
			if (phase != 0)
			{
				throw new InvalidOperationException(_0013(107383721));
			}
			if (value % WaveFormat.Channels != 0)
			{
				throw new ArgumentException(_0013(107383664));
			}
			takeSamples = value;
		}
	}

	public TimeSpan Take
	{
		get
		{
			return SamplesToTimeSpan(takeSamples);
		}
		set
		{
			takeSamples = TimeSpanToSamples(value);
		}
	}

	public int LeadOutSamples
	{
		get
		{
			return leadOutSamples;
		}
		set
		{
			if (phase != 0)
			{
				throw new InvalidOperationException(_0013(107384103));
			}
			if (value % WaveFormat.Channels != 0)
			{
				throw new ArgumentException(_0013(107384042));
			}
			leadOutSamples = value;
		}
	}

	public TimeSpan LeadOut
	{
		get
		{
			return SamplesToTimeSpan(leadOutSamples);
		}
		set
		{
			leadOutSamples = TimeSpanToSamples(value);
		}
	}

	public WaveFormat WaveFormat => sourceProvider.WaveFormat;

	private int TimeSpanToSamples(TimeSpan time)
	{
		return (int)(time.TotalSeconds * (double)WaveFormat.SampleRate) * WaveFormat.Channels;
	}

	private TimeSpan SamplesToTimeSpan(int samples)
	{
		return TimeSpan.FromSeconds((double)(samples / WaveFormat.Channels) / (double)WaveFormat.SampleRate);
	}

	public OffsetSampleProvider(ISampleProvider sourceProvider)
	{
		this.sourceProvider = sourceProvider;
	}

	public int Read(float[] buffer, int offset, int count)
	{
		int num = 0;
		if (phase == 0)
		{
			phase++;
		}
		if (phase == 1)
		{
			int num2 = Math.Min(count, DelayBySamples - phasePos);
			for (int i = 0; i < num2; i++)
			{
				buffer[offset + i] = 0f;
			}
			phasePos += num2;
			num += num2;
			if (phasePos >= DelayBySamples)
			{
				phase++;
				phasePos = 0;
			}
		}
		if (phase == 2)
		{
			if (SkipOverSamples > 0)
			{
				float[] array = new float[WaveFormat.SampleRate * WaveFormat.Channels];
				int num3;
				for (int j = 0; j < SkipOverSamples; j += num3)
				{
					int count2 = Math.Min(SkipOverSamples - j, array.Length);
					num3 = sourceProvider.Read(array, 0, count2);
					if (num3 == 0)
					{
						break;
					}
				}
			}
			phase++;
			phasePos = 0;
		}
		if (phase == 3)
		{
			int num4 = count - num;
			if (takeSamples != 0)
			{
				num4 = Math.Min(num4, takeSamples - phasePos);
			}
			int num5 = sourceProvider.Read(buffer, offset + num, num4);
			phasePos += num5;
			num += num5;
			if (num5 < num4 || (takeSamples > 0 && phasePos >= takeSamples))
			{
				phase++;
				phasePos = 0;
			}
		}
		if (phase == 4)
		{
			int num6 = Math.Min(count - num, LeadOutSamples - phasePos);
			for (int k = 0; k < num6; k++)
			{
				buffer[offset + num + k] = 0f;
			}
			phasePos += num6;
			num += num6;
			if (phasePos >= LeadOutSamples)
			{
				phase++;
				phasePos = 0;
			}
		}
		return num;
	}

	static OffsetSampleProvider()
	{
		Strings.CreateGetStringDelegate(typeof(OffsetSampleProvider));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0013(107398610), _0013(107398573)), _0013(107398568), _0013(107398563)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0013(107398590)))
		{
			return;
		}
		throw new SecurityException(_0013(107398533));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
