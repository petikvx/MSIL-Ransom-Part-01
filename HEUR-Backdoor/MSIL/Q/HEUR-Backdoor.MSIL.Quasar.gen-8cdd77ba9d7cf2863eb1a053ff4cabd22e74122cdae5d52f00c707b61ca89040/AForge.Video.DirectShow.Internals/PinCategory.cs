using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class PinCategory
{
	public static readonly Guid Capture = new Guid(4218176129u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);

	public static readonly Guid StillImage = new Guid(4218176138u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);
}
