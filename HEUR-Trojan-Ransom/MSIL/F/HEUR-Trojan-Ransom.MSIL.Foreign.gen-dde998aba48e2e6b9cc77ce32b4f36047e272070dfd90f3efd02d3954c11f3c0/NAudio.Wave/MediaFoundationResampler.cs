using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Dmo;
using NAudio.MediaFoundation;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MediaFoundationResampler : MediaFoundationTransform
{
	private int resamplerQuality;

	private static readonly Guid ResamplerClsid;

	private static readonly Guid IMFTransformIid;

	private IMFActivate activate;

	[NonSerialized]
	internal static GetString _0019;

	public int ResamplerQuality
	{
		get
		{
			return resamplerQuality;
		}
		set
		{
			if (value < 1 || value > 60)
			{
				throw new ArgumentOutOfRangeException(_0019(107387119));
			}
			resamplerQuality = value;
		}
	}

	private static bool IsPcmOrIeeeFloat(WaveFormat waveFormat)
	{
		WaveFormatExtensible waveFormatExtensible = waveFormat as WaveFormatExtensible;
		if (waveFormat.Encoding != WaveFormatEncoding.Pcm && waveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			if (waveFormatExtensible != null)
			{
				if (!(waveFormatExtensible.SubFormat == AudioSubtypes.MFAudioFormat_PCM))
				{
					return waveFormatExtensible.SubFormat == AudioSubtypes.MFAudioFormat_Float;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public MediaFoundationResampler(IWaveProvider sourceProvider, WaveFormat outputFormat)
		: base(sourceProvider, outputFormat)
	{
		if (!IsPcmOrIeeeFloat(sourceProvider.WaveFormat))
		{
			throw new ArgumentException(_0019(107387759), _0019(107387714));
		}
		if (!IsPcmOrIeeeFloat(outputFormat))
		{
			throw new ArgumentException(_0019(107387181), _0019(107387168));
		}
		MediaFoundationApi.Startup();
		ResamplerQuality = 60;
		object comObject = CreateResamplerComObject();
		FreeComObject(comObject);
	}

	private void FreeComObject(object comObject)
	{
		if (activate != null)
		{
			activate.ShutdownObject();
		}
		Marshal.ReleaseComObject(comObject);
	}

	private object CreateResamplerComObject()
	{
		return new ResamplerMediaComObject();
	}

	private object CreateResamplerComObjectUsingActivator()
	{
		foreach (IMFActivate item in MediaFoundationApi.EnumerateTransforms(MediaFoundationTransformCategories.AudioEffect))
		{
			item.GetGUID(MediaFoundationAttributes.MFT_TRANSFORM_CLSID_Attribute, out var pguidValue);
			if (pguidValue.Equals(ResamplerClsid))
			{
				item.ActivateObject(IMFTransformIid, out var ppv);
				activate = item;
				return ppv;
			}
		}
		return null;
	}

	public MediaFoundationResampler(IWaveProvider sourceProvider, int outputSampleRate)
		: this(sourceProvider, CreateOutputFormat(sourceProvider.WaveFormat, outputSampleRate))
	{
	}

	protected override IMFTransform CreateTransform()
	{
		object obj = CreateResamplerComObject();
		IMFTransform obj2 = (IMFTransform)obj;
		IMFMediaType iMFMediaType = MediaFoundationApi.CreateMediaTypeFromWaveFormat(sourceProvider.WaveFormat);
		obj2.SetInputType(0, iMFMediaType, _MFT_SET_TYPE_FLAGS.None);
		Marshal.ReleaseComObject(iMFMediaType);
		IMFMediaType iMFMediaType2 = MediaFoundationApi.CreateMediaTypeFromWaveFormat(outputWaveFormat);
		obj2.SetOutputType(0, iMFMediaType2, _MFT_SET_TYPE_FLAGS.None);
		Marshal.ReleaseComObject(iMFMediaType2);
		((IWMResamplerProps)obj).SetHalfFilterLength(ResamplerQuality);
		return obj2;
	}

	private static WaveFormat CreateOutputFormat(WaveFormat inputFormat, int outputSampleRate)
	{
		if (inputFormat.Encoding == WaveFormatEncoding.Pcm)
		{
			return new WaveFormat(outputSampleRate, inputFormat.BitsPerSample, inputFormat.Channels);
		}
		if (inputFormat.Encoding == WaveFormatEncoding.IeeeFloat)
		{
			return WaveFormat.CreateIeeeFloatWaveFormat(outputSampleRate, inputFormat.Channels);
		}
		throw new ArgumentException(_0019(107387094));
	}

	protected override void Dispose(bool disposing)
	{
		if (activate != null)
		{
			activate.ShutdownObject();
			activate = null;
		}
		base.Dispose(disposing);
	}

	static MediaFoundationResampler()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationResampler));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0019(107398323), _0019(107398286)).Replace(_0019(107398281), _0019(107398276)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0019(107398303)))
		{
			throw new SecurityException(_0019(107398246));
		}
		ResamplerClsid = new Guid(_0019(107387013));
		IMFTransformIid = new Guid(_0019(107386996));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
