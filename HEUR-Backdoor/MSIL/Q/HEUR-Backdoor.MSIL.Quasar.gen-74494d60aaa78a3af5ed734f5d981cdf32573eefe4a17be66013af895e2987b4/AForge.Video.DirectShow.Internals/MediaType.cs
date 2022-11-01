using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class MediaType
{
	public static readonly Guid Video = new Guid(1935960438, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid Interleaved = new Guid(1937138025, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid Audio = new Guid(1935963489, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid Text = new Guid(1937012852, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);

	public static readonly Guid Stream = new Guid(3828804483u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
}
