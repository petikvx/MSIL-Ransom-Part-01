using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow;

[ComVisible(false)]
public static class FilterCategory
{
	public static readonly Guid AudioInputDevice = new Guid(869902178u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);

	public static readonly Guid VideoInputDevice = new Guid(2248913680u, 23809, 4560, 189, 59, 0, 160, 201, 17, 206, 134);

	public static readonly Guid VideoCompressorCategory = new Guid(869902176u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);

	public static readonly Guid AudioCompressorCategory = new Guid(869902177u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
}
