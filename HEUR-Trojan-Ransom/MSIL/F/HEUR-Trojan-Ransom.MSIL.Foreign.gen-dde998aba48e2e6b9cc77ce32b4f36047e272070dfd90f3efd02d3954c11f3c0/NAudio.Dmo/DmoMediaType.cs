using System;
using System.Runtime.InteropServices;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

public struct DmoMediaType
{
	private Guid majortype;

	private Guid subtype;

	private bool bFixedSizeSamples;

	private bool bTemporalCompression;

	private int lSampleSize;

	private Guid formattype;

	private IntPtr pUnk;

	private int cbFormat;

	private IntPtr pbFormat;

	[NonSerialized]
	internal static GetString _0096;

	public Guid MajorType => majortype;

	public string MajorTypeName => MediaTypes.GetMediaTypeName(majortype);

	public Guid SubType => subtype;

	public string SubTypeName
	{
		get
		{
			if (majortype == MediaTypes.MEDIATYPE_Audio)
			{
				return AudioMediaSubtypes.GetAudioSubtypeName(subtype);
			}
			return subtype.ToString();
		}
	}

	public bool FixedSizeSamples => bFixedSizeSamples;

	public int SampleSize => lSampleSize;

	public Guid FormatType => formattype;

	public string FormatTypeName
	{
		get
		{
			if (formattype == DmoMediaTypeGuids.FORMAT_None)
			{
				return _0096(107391079);
			}
			if (formattype == Guid.Empty)
			{
				return _0096(107391070);
			}
			if (formattype == DmoMediaTypeGuids.FORMAT_WaveFormatEx)
			{
				return _0096(107390517);
			}
			return FormatType.ToString();
		}
	}

	public WaveFormat GetWaveFormat()
	{
		if (formattype == DmoMediaTypeGuids.FORMAT_WaveFormatEx)
		{
			return WaveFormat.MarshalFromPtr(pbFormat);
		}
		throw new InvalidOperationException(_0096(107390532));
	}

	public void SetWaveFormat(WaveFormat waveFormat)
	{
		majortype = MediaTypes.MEDIATYPE_Audio;
		if (waveFormat is WaveFormatExtensible waveFormatExtensible)
		{
			subtype = waveFormatExtensible.SubFormat;
		}
		else
		{
			switch (waveFormat.Encoding)
			{
			case WaveFormatEncoding.Pcm:
				subtype = AudioMediaSubtypes.MEDIASUBTYPE_PCM;
				break;
			case WaveFormatEncoding.IeeeFloat:
				subtype = AudioMediaSubtypes.MEDIASUBTYPE_IEEE_FLOAT;
				break;
			case WaveFormatEncoding.MpegLayer3:
				subtype = AudioMediaSubtypes.WMMEDIASUBTYPE_MP3;
				break;
			default:
				throw new ArgumentException(string.Format(_0096(107390503), waveFormat.Encoding));
			}
		}
		bFixedSizeSamples = SubType == AudioMediaSubtypes.MEDIASUBTYPE_PCM || SubType == AudioMediaSubtypes.MEDIASUBTYPE_IEEE_FLOAT;
		formattype = DmoMediaTypeGuids.FORMAT_WaveFormatEx;
		if (cbFormat < Marshal.SizeOf((object)waveFormat))
		{
			throw new InvalidOperationException(_0096(107390462));
		}
		Marshal.StructureToPtr((object)waveFormat, pbFormat, fDeleteOld: false);
	}

	static DmoMediaType()
	{
		Strings.CreateGetStringDelegate(typeof(DmoMediaType));
	}
}
