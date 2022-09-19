using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

public class GClass60
{
	public readonly Size size_0;

	public readonly int int_0;

	public readonly int int_1;

	public readonly int int_2;

	[Obsolete("No longer supported. Use AverageFrameRate instead.")]
	public int FrameRate => int_0;

	internal GClass60()
	{
	}

	internal static GClass60[] smethod_0(Interface2 videoStreamConfig)
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
		if (size > Marshal.SizeOf(typeof(Class40)))
		{
			throw new NotSupportedException("Unable to retrieve video device capabilities. This video device requires a larger VideoStreamConfigCaps structure.");
		}
		Dictionary<uint, GClass60> dictionary = new Dictionary<uint, GClass60>();
		for (int i = 0; i < count; i++)
		{
			try
			{
				GClass60 gClass = new GClass60(videoStreamConfig, i);
				Size size2 = gClass.size_0;
				int height = size2.Height;
				size2 = gClass.size_0;
				uint key = (uint)(height | (size2.Width << 16));
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, gClass);
				}
				else if (gClass.int_2 > dictionary[key].int_2)
				{
					dictionary[key] = gClass;
				}
			}
			catch
			{
			}
		}
		GClass60[] array = new GClass60[dictionary.Count];
		dictionary.Values.CopyTo(array, 0);
		return array;
	}

	internal GClass60(Interface2 videoStreamConfig, int index)
	{
		AMMediaType mediaType = null;
		Class40 @class = new Class40();
		try
		{
			int streamCaps = videoStreamConfig.GetStreamCaps(index, out mediaType, @class);
			if (streamCaps != 0)
			{
				Marshal.ThrowExceptionForHR(streamCaps);
			}
			if (mediaType.FormatType == Class42.guid_0)
			{
				Struct15 @struct = (Struct15)Marshal.PtrToStructure(mediaType.FormatPtr, typeof(Struct15));
				size_0 = new Size(@struct.struct17_0.int_1, @struct.struct17_0.int_2);
				int_2 = @struct.struct17_0.short_1;
				int_0 = (int)(10000000L / @struct.long_0);
				int_1 = (int)(10000000L / @class.long_0);
			}
			else
			{
				if (!(mediaType.FormatType == Class42.guid_1))
				{
					throw new ApplicationException("Unsupported format found.");
				}
				Struct16 struct2 = (Struct16)Marshal.PtrToStructure(mediaType.FormatPtr, typeof(Struct16));
				size_0 = new Size(struct2.struct17_0.int_1, struct2.struct17_0.int_2);
				int_2 = struct2.struct17_0.short_1;
				int_0 = (int)(10000000L / struct2.long_0);
				int_1 = (int)(10000000L / @class.long_0);
			}
			if (int_2 <= 12)
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
		return method_0(obj as GClass60);
	}

	public bool method_0(GClass60 vc2)
	{
		if (vc2 == null)
		{
			return false;
		}
		if (size_0 == vc2.size_0)
		{
			return int_2 == vc2.int_2;
		}
		return false;
	}

	public override int GetHashCode()
	{
		Size size = size_0;
		return size.GetHashCode() ^ int_2;
	}

	[SpecialName]
	public static bool smethod_1(GClass60 a, GClass60 b)
	{
		if (a == b)
		{
			return true;
		}
		if (a != null && b != null)
		{
			return a.method_0(b);
		}
		return false;
	}

	[SpecialName]
	public static bool smethod_2(GClass60 a, GClass60 b)
	{
		return !smethod_1(a, b);
	}
}
