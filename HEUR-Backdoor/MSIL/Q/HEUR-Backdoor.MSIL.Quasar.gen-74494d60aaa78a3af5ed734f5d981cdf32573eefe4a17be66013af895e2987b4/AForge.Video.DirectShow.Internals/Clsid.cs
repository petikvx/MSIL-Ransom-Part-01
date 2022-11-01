using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class Clsid
{
	public static readonly Guid SystemDeviceEnum = new Guid(1656642832, 24811, 4560, 189, 59, 0, 160, 201, 17, 206, 134);

	public static readonly Guid FilterGraph = new Guid(3828804531u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);

	public static readonly Guid SampleGrabber = new Guid(3253993632u, 16136, 4563, 159, 11, 0, 96, 8, 3, 158, 55);

	public static readonly Guid CaptureGraphBuilder2 = new Guid(3213342433u, 35879, 4560, 179, 240, 0, 170, 0, 55, 97, 197);

	public static readonly Guid AsyncReader = new Guid(3828804533u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
}
