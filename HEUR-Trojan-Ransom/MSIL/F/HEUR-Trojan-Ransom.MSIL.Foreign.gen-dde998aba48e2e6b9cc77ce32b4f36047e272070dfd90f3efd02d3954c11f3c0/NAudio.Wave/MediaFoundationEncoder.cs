using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NAudio.MediaFoundation;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class MediaFoundationEncoder : IDisposable
{
	private readonly MediaType outputMediaType;

	private bool disposed;

	[NonSerialized]
	internal static GetString _001C;

	public static int[] GetEncodeBitrates(Guid audioSubtype, int sampleRate, int channels)
	{
		return (from br in (from mt in GetOutputMediaTypes(audioSubtype)
				where mt.SampleRate == sampleRate && mt.ChannelCount == channels
				select mt.AverageBytesPerSecond * 8).Distinct()
			orderby br
			select br).ToArray();
	}

	public static MediaType[] GetOutputMediaTypes(Guid audioSubtype)
	{
		IMFCollection ppAvailableTypes;
		try
		{
			MediaFoundationInterop.MFTranscodeGetAudioOutputAvailableTypes(audioSubtype, _MFT_ENUM_FLAG.MFT_ENUM_FLAG_ALL, null, out ppAvailableTypes);
		}
		catch (COMException exception)
		{
			if (exception.GetHResult() == -1072875819)
			{
				return new MediaType[0];
			}
			throw;
		}
		ppAvailableTypes.GetElementCount(out var pcElements);
		List<MediaType> list = new List<MediaType>(pcElements);
		for (int i = 0; i < pcElements; i++)
		{
			ppAvailableTypes.GetElement(i, out var ppUnkElement);
			IMFMediaType mediaType = (IMFMediaType)ppUnkElement;
			list.Add(new MediaType(mediaType));
		}
		Marshal.ReleaseComObject(ppAvailableTypes);
		return list.ToArray();
	}

	public static void EncodeToWma(IWaveProvider inputProvider, string outputFile, int desiredBitRate = 192000)
	{
		using MediaFoundationEncoder mediaFoundationEncoder = new MediaFoundationEncoder(SelectMediaType(AudioSubtypes.MFAudioFormat_WMAudioV8, inputProvider.WaveFormat, desiredBitRate) ?? throw new InvalidOperationException(_001C(107388939)));
		mediaFoundationEncoder.Encode(outputFile, inputProvider);
	}

	public static void EncodeToMp3(IWaveProvider inputProvider, string outputFile, int desiredBitRate = 192000)
	{
		using MediaFoundationEncoder mediaFoundationEncoder = new MediaFoundationEncoder(SelectMediaType(AudioSubtypes.MFAudioFormat_MP3, inputProvider.WaveFormat, desiredBitRate) ?? throw new InvalidOperationException(_001C(107388890)));
		mediaFoundationEncoder.Encode(outputFile, inputProvider);
	}

	public static void EncodeToAac(IWaveProvider inputProvider, string outputFile, int desiredBitRate = 192000)
	{
		using MediaFoundationEncoder mediaFoundationEncoder = new MediaFoundationEncoder(SelectMediaType(AudioSubtypes.MFAudioFormat_AAC, inputProvider.WaveFormat, desiredBitRate) ?? throw new InvalidOperationException(_001C(107388873)));
		mediaFoundationEncoder.Encode(outputFile, inputProvider);
	}

	public static MediaType SelectMediaType(Guid audioSubtype, WaveFormat inputFormat, int desiredBitRate)
	{
		return (from mt in GetOutputMediaTypes(audioSubtype)
			where mt.SampleRate == inputFormat.SampleRate && mt.ChannelCount == inputFormat.Channels
			select new
			{
				MediaType = mt,
				Delta = Math.Abs(desiredBitRate - mt.AverageBytesPerSecond * 8)
			} into mt
			orderby mt.Delta
			select mt.MediaType).FirstOrDefault();
	}

	public MediaFoundationEncoder(MediaType outputMediaType)
	{
		if (outputMediaType == null)
		{
			throw new ArgumentNullException(_001C(107389304));
		}
		this.outputMediaType = outputMediaType;
	}

	public void Encode(string outputFile, IWaveProvider inputProvider)
	{
		if (inputProvider.WaveFormat.Encoding != WaveFormatEncoding.Pcm && inputProvider.WaveFormat.Encoding != WaveFormatEncoding.IeeeFloat)
		{
			throw new ArgumentException(_001C(107389315));
		}
		MediaType mediaType = new MediaType(inputProvider.WaveFormat);
		IMFSinkWriter iMFSinkWriter = CreateSinkWriter(outputFile);
		try
		{
			iMFSinkWriter.AddStream(outputMediaType.MediaFoundationObject, out var pdwStreamIndex);
			iMFSinkWriter.SetInputMediaType(pdwStreamIndex, mediaType.MediaFoundationObject, null);
			PerformEncode(iMFSinkWriter, pdwStreamIndex, inputProvider);
		}
		finally
		{
			Marshal.ReleaseComObject(iMFSinkWriter);
			Marshal.ReleaseComObject(mediaType.MediaFoundationObject);
		}
	}

	private static IMFSinkWriter CreateSinkWriter(string outputFile)
	{
		IMFAttributes iMFAttributes = MediaFoundationApi.CreateAttributes(1);
		iMFAttributes.SetUINT32(MediaFoundationAttributes.MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS, 1);
		try
		{
			MediaFoundationInterop.MFCreateSinkWriterFromURL(outputFile, null, iMFAttributes, out var ppSinkWriter);
			return ppSinkWriter;
		}
		catch (COMException exception)
		{
			if (exception.GetHResult() == -1072875819)
			{
				throw new ArgumentException(_001C(107389254));
			}
			throw;
		}
		finally
		{
			Marshal.ReleaseComObject(iMFAttributes);
		}
	}

	private void PerformEncode(IMFSinkWriter writer, int streamIndex, IWaveProvider inputProvider)
	{
		byte[] managedBuffer = new byte[inputProvider.WaveFormat.AverageBytesPerSecond * 4];
		writer.BeginWriting();
		long num = 0L;
		long num2 = 0L;
		do
		{
			num2 = ConvertOneBuffer(writer, streamIndex, inputProvider, num, managedBuffer);
			num += num2;
		}
		while (num2 > 0);
		writer.DoFinalize();
	}

	private static long BytesToNsPosition(int bytes, WaveFormat waveFormat)
	{
		return 10000000L * (long)bytes / waveFormat.AverageBytesPerSecond;
	}

	private long ConvertOneBuffer(IMFSinkWriter writer, int streamIndex, IWaveProvider inputProvider, long position, byte[] managedBuffer)
	{
		long num = 0L;
		IMFMediaBuffer iMFMediaBuffer = MediaFoundationApi.CreateMemoryBuffer(managedBuffer.Length);
		iMFMediaBuffer.GetMaxLength(out var pcbMaxLength);
		IMFSample iMFSample = MediaFoundationApi.CreateSample();
		iMFSample.AddBuffer(iMFMediaBuffer);
		iMFMediaBuffer.Lock(out var ppbBuffer, out pcbMaxLength, out var _);
		int num2 = inputProvider.Read(managedBuffer, 0, pcbMaxLength);
		if (num2 > 0)
		{
			num = BytesToNsPosition(num2, inputProvider.WaveFormat);
			Marshal.Copy(managedBuffer, 0, ppbBuffer, num2);
			iMFMediaBuffer.SetCurrentLength(num2);
			iMFMediaBuffer.Unlock();
			iMFSample.SetSampleTime(position);
			iMFSample.SetSampleDuration(num);
			writer.WriteSample(streamIndex, iMFSample);
		}
		else
		{
			iMFMediaBuffer.Unlock();
		}
		Marshal.ReleaseComObject(iMFSample);
		Marshal.ReleaseComObject(iMFMediaBuffer);
		return num;
	}

	protected void Dispose(bool disposing)
	{
		Marshal.ReleaseComObject(outputMediaType.MediaFoundationObject);
	}

	public void Dispose()
	{
		if (!disposed)
		{
			disposed = true;
			Dispose(disposing: true);
		}
		GC.SuppressFinalize(this);
	}

	~MediaFoundationEncoder()
	{
		Dispose(disposing: false);
	}

	static MediaFoundationEncoder()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationEncoder));
	}
}
