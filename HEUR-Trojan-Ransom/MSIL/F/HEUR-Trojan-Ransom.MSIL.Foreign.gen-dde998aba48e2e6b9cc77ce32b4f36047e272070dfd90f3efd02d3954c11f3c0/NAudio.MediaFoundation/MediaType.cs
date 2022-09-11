using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public sealed class MediaType
{
	private readonly IMFMediaType mediaType;

	[NonSerialized]
	internal static GetString _001B;

	public int SampleRate
	{
		get
		{
			return GetUInt32(MediaFoundationAttributes.MF_MT_AUDIO_SAMPLES_PER_SECOND);
		}
		set
		{
			mediaType.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_SAMPLES_PER_SECOND, value);
		}
	}

	public int ChannelCount
	{
		get
		{
			return GetUInt32(MediaFoundationAttributes.MF_MT_AUDIO_NUM_CHANNELS);
		}
		set
		{
			mediaType.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_NUM_CHANNELS, value);
		}
	}

	public int BitsPerSample
	{
		get
		{
			return GetUInt32(MediaFoundationAttributes.MF_MT_AUDIO_BITS_PER_SAMPLE);
		}
		set
		{
			mediaType.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_BITS_PER_SAMPLE, value);
		}
	}

	public int AverageBytesPerSecond => GetUInt32(MediaFoundationAttributes.MF_MT_AUDIO_AVG_BYTES_PER_SECOND);

	public Guid SubType
	{
		get
		{
			return GetGuid(MediaFoundationAttributes.MF_MT_SUBTYPE);
		}
		set
		{
			mediaType.SetGUID(MediaFoundationAttributes.MF_MT_SUBTYPE, value);
		}
	}

	public Guid MajorType
	{
		get
		{
			return GetGuid(MediaFoundationAttributes.MF_MT_MAJOR_TYPE);
		}
		set
		{
			mediaType.SetGUID(MediaFoundationAttributes.MF_MT_MAJOR_TYPE, value);
		}
	}

	public IMFMediaType MediaFoundationObject => mediaType;

	public MediaType(IMFMediaType mediaType)
	{
		this.mediaType = mediaType;
	}

	public MediaType()
	{
		mediaType = MediaFoundationApi.CreateMediaType();
	}

	public MediaType(WaveFormat waveFormat)
	{
		mediaType = MediaFoundationApi.CreateMediaTypeFromWaveFormat(waveFormat);
	}

	private int GetUInt32(Guid key)
	{
		mediaType.GetUINT32(key, out var punValue);
		return punValue;
	}

	private Guid GetGuid(Guid key)
	{
		mediaType.GetGUID(key, out var pguidValue);
		return pguidValue;
	}

	public int TryGetUInt32(Guid key, int defaultValue = -1)
	{
		int punValue = defaultValue;
		try
		{
			mediaType.GetUINT32(key, out punValue);
			return punValue;
		}
		catch (COMException exception)
		{
			if (exception.GetHResult() != -1072875802)
			{
				if (exception.GetHResult() == -1072875843)
				{
					throw new ArgumentException(_001B(107404931));
				}
				throw;
			}
			return punValue;
		}
	}

	static MediaType()
	{
		Strings.CreateGetStringDelegate(typeof(MediaType));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001B(107399907), _001B(107399870)), _001B(107399865), _001B(107399860)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001B(107399887)))
		{
			return;
		}
		throw new SecurityException(_001B(107399830));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
