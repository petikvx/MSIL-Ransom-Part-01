using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

namespace AForge.Video.DirectShow;

public class VideoCapabilities
{
	public readonly Size FrameSize;

	public readonly int AverageFrameRate;

	public readonly int MaximumFrameRate;

	public readonly int BitCount;

	[Obsolete("No longer supported. Use AverageFrameRate instead.")]
	public int FrameRate => AverageFrameRate;

	internal VideoCapabilities()
	{
	}

	internal static VideoCapabilities[] FromStreamConfig(IAMStreamConfig videoStreamConfig)
	{
		if (videoStreamConfig == null)
		{
			throw new ArgumentNullException("videoStreamConfig");
		}
		int count;
		int size;
		int numberOfCapabilities = videoStreamConfig.GetNumberOfCapabilities(out count, out size);
		if (numberOfCapabilities != 0)
		{
			Marshal.ThrowExceptionForHR(numberOfCapabilities);
		}
		if (count <= 0)
		{
			throw new NotSupportedException("This video device does not report capabilities.");
		}
		if (size > Marshal.SizeOf(typeof(VideoStreamConfigCaps)))
		{
			throw new NotSupportedException("Unable to retrieve video device capabilities. This video device requires a larger VideoStreamConfigCaps structure.");
		}
		Dictionary<uint, VideoCapabilities> dictionary = new Dictionary<uint, VideoCapabilities>();
		for (int i = 0; i < count; i++)
		{
			try
			{
				VideoCapabilities videoCapabilities = new VideoCapabilities(videoStreamConfig, i);
				Size frameSize = videoCapabilities.FrameSize;
				int height = frameSize.Height;
				frameSize = videoCapabilities.FrameSize;
				uint key = (uint)(height | (frameSize.Width << 16));
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, videoCapabilities);
				}
				else if (videoCapabilities.BitCount > dictionary[key].BitCount)
				{
					dictionary[key] = videoCapabilities;
				}
			}
			catch
			{
			}
		}
		VideoCapabilities[] array = new VideoCapabilities[dictionary.Count];
		dictionary.Values.CopyTo(array, 0);
		return array;
	}

	internal VideoCapabilities(IAMStreamConfig videoStreamConfig, int index)
	{
		AMMediaType mediaType = null;
		VideoStreamConfigCaps videoStreamConfigCaps = new VideoStreamConfigCaps();
		try
		{
			int streamCaps = videoStreamConfig.GetStreamCaps(index, out mediaType, videoStreamConfigCaps);
			if (streamCaps != 0)
			{
				Marshal.ThrowExceptionForHR(streamCaps);
			}
			if (mediaType.FormatType == FormatType.VideoInfo)
			{
				VideoInfoHeader videoInfoHeader = (VideoInfoHeader)Marshal.PtrToStructure(mediaType.FormatPtr, typeof(VideoInfoHeader));
				FrameSize = new Size(videoInfoHeader.BmiHeader.Width, videoInfoHeader.BmiHeader.Height);
				BitCount = videoInfoHeader.BmiHeader.BitCount;
				AverageFrameRate = (int)(10000000 / videoInfoHeader.AverageTimePerFrame);
				MaximumFrameRate = (int)(10000000 / videoStreamConfigCaps.MinFrameInterval);
			}
			else
			{
				if (!(mediaType.FormatType == FormatType.VideoInfo2))
				{
					throw new ApplicationException("Unsupported format found.");
				}
				VideoInfoHeader2 videoInfoHeader2 = (VideoInfoHeader2)Marshal.PtrToStructure(mediaType.FormatPtr, typeof(VideoInfoHeader2));
				FrameSize = new Size(videoInfoHeader2.BmiHeader.Width, videoInfoHeader2.BmiHeader.Height);
				BitCount = videoInfoHeader2.BmiHeader.BitCount;
				AverageFrameRate = (int)(10000000 / videoInfoHeader2.AverageTimePerFrame);
				MaximumFrameRate = (int)(10000000 / videoStreamConfigCaps.MinFrameInterval);
			}
			if (BitCount <= 12)
			{
				throw new ApplicationException("Unsupported format found.");
			}
		}
		finally
		{
			mediaType?.Dispose();
		}
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as VideoCapabilities);
	}

	public bool Equals(VideoCapabilities vc2)
	{
		if ((object)vc2 == null)
		{
			return false;
		}
		if (FrameSize == vc2.FrameSize)
		{
			return BitCount == vc2.BitCount;
		}
		return false;
	}

	public override int GetHashCode()
	{
		Size frameSize = FrameSize;
		return frameSize.GetHashCode() ^ BitCount;
	}

	public static bool operator ==(VideoCapabilities a, VideoCapabilities b)
	{
		if ((object)a == b)
		{
			return true;
		}
		if ((object)a == null || (object)b == null)
		{
			return false;
		}
		return a.Equals(b);
	}

	public static bool operator !=(VideoCapabilities a, VideoCapabilities b)
	{
		return !(a == b);
	}
}
