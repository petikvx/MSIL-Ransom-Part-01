using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class FormatType
{
	public static readonly Guid VideoInfo = new Guid(89694080u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);

	public static readonly Guid VideoInfo2 = new Guid(4146755232u, 60170, 4560, 172, 228, 0, 0, 192, 204, 22, 186);
}
