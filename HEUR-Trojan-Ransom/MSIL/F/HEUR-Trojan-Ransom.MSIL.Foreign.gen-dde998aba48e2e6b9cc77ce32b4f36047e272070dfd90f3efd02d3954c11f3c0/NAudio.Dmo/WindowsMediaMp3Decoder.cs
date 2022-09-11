using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.Dmo;

public sealed class WindowsMediaMp3Decoder : IDisposable
{
	private MediaObject mediaObject;

	private IPropertyStore propertyStoreInterface;

	private WindowsMediaMp3DecoderComObject mediaComObject;

	public MediaObject MediaObject => mediaObject;

	public WindowsMediaMp3Decoder()
	{
		mediaComObject = new WindowsMediaMp3DecoderComObject();
		mediaObject = new MediaObject((IMediaObject)(object)mediaComObject);
		propertyStoreInterface = (IPropertyStore)(object)mediaComObject;
	}

	public void Dispose()
	{
		if (propertyStoreInterface != null)
		{
			Marshal.ReleaseComObject(propertyStoreInterface);
			propertyStoreInterface = null;
		}
		if (mediaObject != null)
		{
			mediaObject.Dispose();
			mediaObject = null;
		}
		if (mediaComObject != null)
		{
			Marshal.ReleaseComObject(mediaComObject);
			mediaComObject = null;
		}
	}
}
