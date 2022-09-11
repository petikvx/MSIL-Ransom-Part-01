using System;
using System.IO;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;
using NAudio.MediaFoundation;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public class MediaFoundationReader : WaveStream
{
	public sealed class MediaFoundationReaderSettings
	{
		public bool RequestFloatOutput { get; set; }

		public bool SingleReaderObject { get; set; }

		public bool RepositionInRead { get; set; }

		public MediaFoundationReaderSettings()
		{
			RepositionInRead = true;
		}
	}

	private WaveFormat waveFormat;

	private long length;

	private MediaFoundationReaderSettings settings;

	private readonly string file;

	private IMFSourceReader pReader;

	private long position;

	private byte[] decoderOutputBuffer;

	private int decoderOutputOffset;

	private int decoderOutputCount;

	private long repositionTo = -1L;

	[NonSerialized]
	internal static GetString _0094;

	public override WaveFormat WaveFormat => waveFormat;

	public override long Length => length;

	public override long Position
	{
		get
		{
			return position;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException(_0094(107391667), _0094(107385841));
			}
			if (settings.RepositionInRead)
			{
				repositionTo = value;
				position = value;
			}
			else
			{
				Reposition(value);
			}
		}
	}

	public event EventHandler WaveFormatChanged;

	protected MediaFoundationReader()
	{
	}

	public MediaFoundationReader(string file)
		: this(file, null)
	{
	}

	public MediaFoundationReader(string file, MediaFoundationReaderSettings settings)
	{
		this.file = file;
		Init(settings);
	}

	protected void Init(MediaFoundationReaderSettings initialSettings)
	{
		MediaFoundationApi.Startup();
		settings = initialSettings ?? new MediaFoundationReaderSettings();
		IMFSourceReader iMFSourceReader = CreateReader(settings);
		waveFormat = GetCurrentWaveFormat(iMFSourceReader);
		iMFSourceReader.SetStreamSelection(-3, pSelected: true);
		length = GetLength(iMFSourceReader);
		if (settings.SingleReaderObject)
		{
			pReader = iMFSourceReader;
		}
	}

	private WaveFormat GetCurrentWaveFormat(IMFSourceReader reader)
	{
		reader.GetCurrentMediaType(-3, out var ppMediaType);
		MediaType mediaType = new MediaType(ppMediaType);
		_ = mediaType.MajorType;
		Guid subType = mediaType.SubType;
		int channelCount = mediaType.ChannelCount;
		int bitsPerSample = mediaType.BitsPerSample;
		int sampleRate = mediaType.SampleRate;
		if (subType == AudioSubtypes.MFAudioFormat_PCM)
		{
			return new WaveFormat(sampleRate, bitsPerSample, channelCount);
		}
		if (subType == AudioSubtypes.MFAudioFormat_Float)
		{
			return WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channelCount);
		}
		string arg = FieldDescriptionHelper.Describe(typeof(AudioSubtypes), subType);
		throw new InvalidDataException(string.Format(_0094(107385891), arg));
	}

	private static MediaType GetCurrentMediaType(IMFSourceReader reader)
	{
		reader.GetCurrentMediaType(-3, out var ppMediaType);
		return new MediaType(ppMediaType);
	}

	protected virtual IMFSourceReader CreateReader(MediaFoundationReaderSettings settings)
	{
		MediaFoundationInterop.MFCreateSourceReaderFromURL(file, null, out var ppSourceReader);
		ppSourceReader.SetStreamSelection(-2, pSelected: false);
		ppSourceReader.SetStreamSelection(-3, pSelected: true);
		MediaType mediaType = new MediaType();
		mediaType.MajorType = MediaTypes.MFMediaType_Audio;
		mediaType.SubType = (settings.RequestFloatOutput ? AudioSubtypes.MFAudioFormat_Float : AudioSubtypes.MFAudioFormat_PCM);
		MediaType currentMediaType = GetCurrentMediaType(ppSourceReader);
		mediaType.ChannelCount = currentMediaType.ChannelCount;
		mediaType.SampleRate = currentMediaType.SampleRate;
		ppSourceReader.SetCurrentMediaType(-3, IntPtr.Zero, mediaType.MediaFoundationObject);
		Marshal.ReleaseComObject(currentMediaType.MediaFoundationObject);
		return ppSourceReader;
	}

	private long GetLength(IMFSourceReader reader)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(MarshalHelpers.SizeOf<PropVariant>());
		try
		{
			int presentationAttribute = reader.GetPresentationAttribute(-1, MediaFoundationAttributes.MF_PD_DURATION, intPtr);
			switch (presentationAttribute)
			{
			case -1072875802:
				return 0L;
			default:
				Marshal.ThrowExceptionForHR(presentationAttribute);
				break;
			case 0:
				break;
			}
			return (long)MarshalHelpers.PtrToStructure<PropVariant>(intPtr).Value * waveFormat.AverageBytesPerSecond / 10000000;
		}
		finally
		{
			PropVariant.Clear(intPtr);
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private void EnsureBuffer(int bytesRequired)
	{
		if (decoderOutputBuffer == null || decoderOutputBuffer.Length < bytesRequired)
		{
			decoderOutputBuffer = new byte[bytesRequired];
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (pReader == null)
		{
			pReader = CreateReader(settings);
		}
		if (repositionTo != -1)
		{
			Reposition(repositionTo);
		}
		int num = 0;
		if (decoderOutputCount > 0)
		{
			num += ReadFromDecoderBuffer(buffer, offset, count - num);
		}
		while (num < count)
		{
			pReader.ReadSample(-3, 0, out var _, out var pdwStreamFlags, out var _, out var ppSample);
			if ((pdwStreamFlags & MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_ENDOFSTREAM) != 0)
			{
				break;
			}
			if ((pdwStreamFlags & MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED) != 0)
			{
				waveFormat = GetCurrentWaveFormat(pReader);
				OnWaveFormatChanged();
			}
			else if (pdwStreamFlags != 0)
			{
				throw new InvalidOperationException(string.Format(_0094(107385850), pdwStreamFlags));
			}
			ppSample.ConvertToContiguousBuffer(out var ppBuffer);
			ppBuffer.Lock(out var ppbBuffer, out var _, out var pcbCurrentLength);
			EnsureBuffer(pcbCurrentLength);
			Marshal.Copy(ppbBuffer, decoderOutputBuffer, 0, pcbCurrentLength);
			decoderOutputOffset = 0;
			decoderOutputCount = pcbCurrentLength;
			num += ReadFromDecoderBuffer(buffer, offset + num, count - num);
			ppBuffer.Unlock();
			Marshal.ReleaseComObject(ppBuffer);
			Marshal.ReleaseComObject(ppSample);
		}
		position += num;
		return num;
	}

	private int ReadFromDecoderBuffer(byte[] buffer, int offset, int needed)
	{
		int num = Math.Min(needed, decoderOutputCount);
		Array.Copy(decoderOutputBuffer, decoderOutputOffset, buffer, offset, num);
		decoderOutputOffset += num;
		decoderOutputCount -= num;
		if (decoderOutputCount == 0)
		{
			decoderOutputOffset = 0;
		}
		return num;
	}

	private void Reposition(long desiredPosition)
	{
		PropVariant propVariant = PropVariant.FromLong(10000000 * repositionTo / waveFormat.AverageBytesPerSecond);
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)propVariant));
		Marshal.StructureToPtr((object)propVariant, intPtr, fDeleteOld: false);
		pReader.SetCurrentPosition(Guid.Empty, intPtr);
		Marshal.FreeHGlobal(intPtr);
		decoderOutputCount = 0;
		decoderOutputOffset = 0;
		position = desiredPosition;
		repositionTo = -1L;
	}

	protected override void Dispose(bool disposing)
	{
		if (pReader != null)
		{
			Marshal.ReleaseComObject(pReader);
			pReader = null;
		}
		base.Dispose(disposing);
	}

	private void OnWaveFormatChanged()
	{
		this.WaveFormatChanged?.Invoke(this, EventArgs.Empty);
	}

	static MediaFoundationReader()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationReader));
	}
}
