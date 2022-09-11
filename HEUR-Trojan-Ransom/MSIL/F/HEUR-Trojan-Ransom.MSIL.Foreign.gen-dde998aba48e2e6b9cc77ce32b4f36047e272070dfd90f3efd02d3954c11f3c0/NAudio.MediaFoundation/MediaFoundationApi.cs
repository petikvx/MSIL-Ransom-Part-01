using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NAudio.Wave;

namespace NAudio.MediaFoundation;

public static class MediaFoundationApi
{
	private static bool initialized;

	public static void Startup()
	{
		if (!initialized)
		{
			int num = 2;
			OperatingSystem oSVersion = Environment.OSVersion;
			if (oSVersion.Version.Major == 6 && oSVersion.Version.Minor == 0)
			{
				num = 1;
			}
			MediaFoundationInterop.MFStartup((num << 16) | 0x70);
			initialized = true;
		}
	}

	public static IEnumerable<IMFActivate> EnumerateTransforms(Guid category)
	{
		MediaFoundationInterop.MFTEnumEx(category, _MFT_ENUM_FLAG.MFT_ENUM_FLAG_ALL, null, null, out var interfacesPointer, out var pcMFTActivate);
		IMFActivate[] array = new IMFActivate[pcMFTActivate];
		for (int i = 0; i < pcMFTActivate; i++)
		{
			IntPtr pUnk = Marshal.ReadIntPtr(new IntPtr(interfacesPointer.ToInt64() + i * Marshal.SizeOf((object)(nint)interfacesPointer)));
			array[i] = (IMFActivate)Marshal.GetObjectForIUnknown(pUnk);
		}
		IMFActivate[] array2 = array;
		for (int j = 0; j < array2.Length; j++)
		{
			yield return array2[j];
		}
		Marshal.FreeCoTaskMem(interfacesPointer);
	}

	public static void Shutdown()
	{
		if (initialized)
		{
			MediaFoundationInterop.MFShutdown();
			initialized = false;
		}
	}

	public static IMFMediaType CreateMediaType()
	{
		MediaFoundationInterop.MFCreateMediaType(out var ppMFType);
		return ppMFType;
	}

	public static IMFMediaType CreateMediaTypeFromWaveFormat(WaveFormat waveFormat)
	{
		IMFMediaType iMFMediaType = CreateMediaType();
		try
		{
			MediaFoundationInterop.MFInitMediaTypeFromWaveFormatEx(iMFMediaType, waveFormat, Marshal.SizeOf((object)waveFormat));
			return iMFMediaType;
		}
		catch (Exception)
		{
			Marshal.ReleaseComObject(iMFMediaType);
			throw;
		}
	}

	public static IMFMediaBuffer CreateMemoryBuffer(int bufferSize)
	{
		MediaFoundationInterop.MFCreateMemoryBuffer(bufferSize, out var ppBuffer);
		return ppBuffer;
	}

	public static IMFSample CreateSample()
	{
		MediaFoundationInterop.MFCreateSample(out var ppIMFSample);
		return ppIMFSample;
	}

	public static IMFAttributes CreateAttributes(int initialSize)
	{
		MediaFoundationInterop.MFCreateAttributes(out var ppMFAttributes, initialSize);
		return ppMFAttributes;
	}

	public static IMFByteStream CreateByteStream(object stream)
	{
		MediaFoundationInterop.MFCreateMFByteStreamOnStreamEx(stream, out var ppByteStream);
		return ppByteStream;
	}

	public static IMFSourceReader CreateSourceReaderFromByteStream(IMFByteStream byteStream)
	{
		MediaFoundationInterop.MFCreateSourceReaderFromByteStream(byteStream, null, out var ppSourceReader);
		return ppSourceReader;
	}
}
