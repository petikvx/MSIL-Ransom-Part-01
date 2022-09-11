using System;
using System.Runtime.InteropServices;
using NAudio.Utils;
using NAudio.Wave;

namespace NAudio.MediaFoundation;

public abstract class MediaFoundationTransform : IDisposable, IWaveProvider
{
	protected readonly IWaveProvider sourceProvider;

	protected readonly WaveFormat outputWaveFormat;

	private readonly byte[] sourceBuffer;

	private byte[] outputBuffer;

	private int outputBufferOffset;

	private int outputBufferCount;

	private IMFTransform transform;

	private bool disposed;

	private long inputPosition;

	private long outputPosition;

	private bool initializedForStreaming;

	public WaveFormat WaveFormat => outputWaveFormat;

	public MediaFoundationTransform(IWaveProvider sourceProvider, WaveFormat outputFormat)
	{
		outputWaveFormat = outputFormat;
		this.sourceProvider = sourceProvider;
		sourceBuffer = new byte[sourceProvider.WaveFormat.AverageBytesPerSecond];
		outputBuffer = new byte[outputWaveFormat.AverageBytesPerSecond + outputWaveFormat.BlockAlign];
	}

	private void InitializeTransformForStreaming()
	{
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_FLUSH, IntPtr.Zero);
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_BEGIN_STREAMING, IntPtr.Zero);
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_START_OF_STREAM, IntPtr.Zero);
		initializedForStreaming = true;
	}

	protected abstract IMFTransform CreateTransform();

	protected virtual void Dispose(bool disposing)
	{
		if (transform != null)
		{
			Marshal.ReleaseComObject(transform);
		}
	}

	public void Dispose()
	{
		if (!disposed)
		{
			disposed = true;
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}

	~MediaFoundationTransform()
	{
		Dispose(disposing: false);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		if (transform == null)
		{
			transform = CreateTransform();
			InitializeTransformForStreaming();
		}
		int i = 0;
		if (outputBufferCount > 0)
		{
			i += ReadFromOutputBuffer(buffer, offset, count - i);
		}
		for (; i < count; i += ReadFromOutputBuffer(buffer, offset + i, count - i))
		{
			IMFSample iMFSample = ReadFromSource();
			if (iMFSample == null)
			{
				EndStreamAndDrain();
				i += ReadFromOutputBuffer(buffer, offset + i, count - i);
				break;
			}
			if (!initializedForStreaming)
			{
				InitializeTransformForStreaming();
			}
			transform.ProcessInput(0, iMFSample, 0);
			Marshal.ReleaseComObject(iMFSample);
			ReadFromTransform();
		}
		return i;
	}

	private void EndStreamAndDrain()
	{
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_END_OF_STREAM, IntPtr.Zero);
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_COMMAND_DRAIN, IntPtr.Zero);
		int num;
		do
		{
			num = ReadFromTransform();
		}
		while (num > 0);
		outputBufferCount = 0;
		outputBufferOffset = 0;
		inputPosition = 0L;
		outputPosition = 0L;
		transform.ProcessMessage(MFT_MESSAGE_TYPE.MFT_MESSAGE_NOTIFY_END_STREAMING, IntPtr.Zero);
		initializedForStreaming = false;
	}

	private int ReadFromTransform()
	{
		MFT_OUTPUT_DATA_BUFFER[] array = new MFT_OUTPUT_DATA_BUFFER[1];
		IMFSample iMFSample = MediaFoundationApi.CreateSample();
		IMFMediaBuffer iMFMediaBuffer = MediaFoundationApi.CreateMemoryBuffer(outputBuffer.Length);
		iMFSample.AddBuffer(iMFMediaBuffer);
		iMFSample.SetSampleTime(outputPosition);
		array[0].pSample = iMFSample;
		_MFT_PROCESS_OUTPUT_STATUS pdwStatus;
		int num = transform.ProcessOutput(_MFT_PROCESS_OUTPUT_FLAGS.None, 1, array, out pdwStatus);
		switch (num)
		{
		case -1072861838:
			Marshal.ReleaseComObject(iMFMediaBuffer);
			Marshal.ReleaseComObject(iMFSample);
			return 0;
		default:
			Marshal.ThrowExceptionForHR(num);
			break;
		case 0:
			break;
		}
		array[0].pSample.ConvertToContiguousBuffer(out var ppBuffer);
		ppBuffer.Lock(out var ppbBuffer, out var _, out var pcbCurrentLength);
		outputBuffer = BufferHelpers.Ensure(outputBuffer, pcbCurrentLength);
		Marshal.Copy(ppbBuffer, outputBuffer, 0, pcbCurrentLength);
		outputBufferOffset = 0;
		outputBufferCount = pcbCurrentLength;
		ppBuffer.Unlock();
		outputPosition += BytesToNsPosition(outputBufferCount, WaveFormat);
		Marshal.ReleaseComObject(iMFMediaBuffer);
		Marshal.ReleaseComObject(iMFSample);
		Marshal.ReleaseComObject(ppBuffer);
		return pcbCurrentLength;
	}

	private static long BytesToNsPosition(int bytes, WaveFormat waveFormat)
	{
		return 10000000L * (long)bytes / waveFormat.AverageBytesPerSecond;
	}

	private IMFSample ReadFromSource()
	{
		int num = sourceProvider.Read(sourceBuffer, 0, sourceBuffer.Length);
		if (num == 0)
		{
			return null;
		}
		IMFMediaBuffer iMFMediaBuffer = MediaFoundationApi.CreateMemoryBuffer(num);
		iMFMediaBuffer.Lock(out var ppbBuffer, out var _, out var _);
		Marshal.Copy(sourceBuffer, 0, ppbBuffer, num);
		iMFMediaBuffer.Unlock();
		iMFMediaBuffer.SetCurrentLength(num);
		IMFSample iMFSample = MediaFoundationApi.CreateSample();
		iMFSample.AddBuffer(iMFMediaBuffer);
		iMFSample.SetSampleTime(inputPosition);
		long num2 = BytesToNsPosition(num, sourceProvider.WaveFormat);
		iMFSample.SetSampleDuration(num2);
		inputPosition += num2;
		Marshal.ReleaseComObject(iMFMediaBuffer);
		return iMFSample;
	}

	private int ReadFromOutputBuffer(byte[] buffer, int offset, int needed)
	{
		int num = Math.Min(needed, outputBufferCount);
		Array.Copy(outputBuffer, outputBufferOffset, buffer, offset, num);
		outputBufferOffset += num;
		outputBufferCount -= num;
		if (outputBufferCount == 0)
		{
			outputBufferOffset = 0;
		}
		return num;
	}

	public void Reposition()
	{
		if (initializedForStreaming)
		{
			EndStreamAndDrain();
			InitializeTransformForStreaming();
		}
	}
}
